using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedObjectVisuals
{
	private AssetCache _assetCache;

	private IDroppedObjectLoader _loader;

	private Transform _parent;

	private Camera _camera;

	private DropsObjectsData _settings;

	private Action _readyCallback;

	private Transform _root;

	private List<DroppedObject> _preloadedDroppedObjects;

	private List<int> _remainingIndexList;

	private List<DroppedObject> _activeDroppedObjects;

	private const string DroppedObjectRootName = "DroppedObjectsRoot";

	private const string DroppedObjectTagName = "DroppedObject";

	private const string SpawnTriggerName = "Spawn";

	private const string DespawnTriggerName = "Despawn";

	public List<DroppedObject> ActiveObjects => _activeDroppedObjects;

	public DroppedObjectVisuals(AssetCache assetCache, Transform parent, Camera camera)
	{
		_assetCache = assetCache;
		_parent = parent;
		_camera = camera;
		_activeDroppedObjects = new List<DroppedObject>();
	}

	public void Teardown()
	{
		_assetCache = null;
		_activeDroppedObjects = null;
		_parent = null;
		_camera = null;
	}

	public void PreloadDroppableObjects(DropsObjectsData settings, PlushSuitData plushSuitData, Action readyCallback)
	{
		_settings = settings;
		_readyCallback = readyCallback;
		if (settings.SpawnType != DropsObjectsMechanic.SpawnType.FromPlushSuit)
		{
			if (settings.SpawnType == DropsObjectsMechanic.SpawnType.FromBundle)
			{
				PreloadFromBundle();
			}
		}
		else
		{
			PreloadFromPlushSuit(plushSuitData);
		}
	}

	public void DestroyDroppableObjects()
	{
		if (_root != null)
		{
			UnityEngine.Object.Destroy(_root.gameObject);
			_root = null;
		}
		_remainingIndexList = null;
		_activeDroppedObjects.Clear();
		if (_loader != null)
		{
			_loader.Unload();
		}
		_loader = null;
		_settings = null;
		_readyCallback = null;
	}

	public DroppedObject SpawnDroppedObject(Vector3 pos)
	{
		if (_root == null)
		{
			return null;
		}
		if (_preloadedDroppedObjects.Count < 1)
		{
			return null;
		}
		DroppedObject droppedObject = _preloadedDroppedObjects[PickIndexToSpawn()];
		if (droppedObject == null)
		{
			return null;
		}
		droppedObject.SpawnTime = Time.time;
		if (pos != Vector3.zero)
		{
			droppedObject.transform.position = pos;
			droppedObject.transform.LookAt(new Vector3(0f, droppedObject.transform.position.y, 0f));
		}
		else
		{
			droppedObject.transform.position = CalculateWorldPositionFromCameraTransform(_camera.transform);
		}
		droppedObject.GetComponentInChildren<Collider>(includeInactive: true).enabled = true;
		if (droppedObject.animator != null)
		{
			droppedObject.animator.SetTrigger("Spawn");
		}
		droppedObject.modelRoot.gameObject.SetActive(value: true);
		_activeDroppedObjects.Add(droppedObject);
		return droppedObject;
	}

	public void DespawnDroppedObjects()
	{
		if (_root == null)
		{
			return;
		}
		foreach (DroppedObject activeDroppedObject in _activeDroppedObjects)
		{
			DespawnDroppedObject(activeDroppedObject);
		}
	}

	public void DespawnDroppedObject(DroppedObject activeDroppedObject)
	{
		if (!(_root == null) && !(activeDroppedObject == null))
		{
			if (activeDroppedObject.animator != null)
			{
				activeDroppedObject.animator.SetTrigger("Despawn");
			}
			else
			{
				activeDroppedObject.gameObject.SetActive(value: false);
			}
			CoroutineHelper.StartCoroutine(WaitAndRemoveFromList(activeDroppedObject));
		}
	}

	private IEnumerator WaitAndRemoveFromList(DroppedObject activeDroppedObject)
	{
		yield return new WaitForEndOfFrame();
		if (_activeDroppedObjects.Contains(activeDroppedObject))
		{
			_activeDroppedObjects.Remove(activeDroppedObject);
		}
		yield return null;
	}

	public DroppedObject TestTouchVsDroppedObjects(Vector2 position)
	{
		if (!_camera.gameObject.activeSelf)
		{
			return null;
		}
		Ray ray = _camera.ScreenPointToRay(position);
		Debug.Log("Casting");
		if (!Physics.Raycast(ray, out var hitInfo, 1000f))
		{
			return null;
		}
		Debug.Log("HIT: " + hitInfo.transform.name);
		MoveableEnvironmentObject component = hitInfo.transform.parent.GetComponent<MoveableEnvironmentObject>();
		if (component != null)
		{
			Debug.Log("moving moveable object");
			component.Tapped();
			return null;
		}
		DroppedObject component2 = hitInfo.transform.parent.parent.GetComponent<DroppedObject>();
		if (component2 == null)
		{
			Debug.LogError("No DroppedObject script on parent parent");
			return null;
		}
		component2.GetComponentInChildren<Collider>(includeInactive: true).enabled = false;
		return component2;
	}

	private void NotifyReady()
	{
		_readyCallback?.Invoke();
		_readyCallback = null;
	}

	private void PreloadFromBundle()
	{
		CreateRoot();
		if (!(_root == null) && _settings != null)
		{
			_loader = new DroppedObjectFromAssetBundleLoader(_assetCache, _settings.TemplateBundleName, _settings.TemplateAssetName, _settings.ObjectBundleName, _settings.ObjectAssetNames);
			_loader.Load(_root, LoadComplete);
		}
	}

	private void PreloadFromPlushSuit(PlushSuitData plushSuitData)
	{
		CreateRoot();
		if (!(_root == null) && _settings != null)
		{
			_loader = new DroppedObjectFromAssetBundleLoader(_assetCache, _settings.TemplateBundleName, _settings.TemplateAssetName, plushSuitData.MangleEncounterBundleName, plushSuitData.MangleEncounterAssetNames);
			_loader.Load(_root, LoadComplete);
		}
	}

	private void LoadComplete(List<DroppedObject> droppedObjects)
	{
		_preloadedDroppedObjects = droppedObjects;
		BuildRemainingIndexList();
		NotifyReady();
	}

	private void BuildRemainingIndexList()
	{
		if (_remainingIndexList == null)
		{
			_remainingIndexList = new List<int>(_preloadedDroppedObjects.Count);
		}
		foreach (DroppedObject preloadedDroppedObject in _preloadedDroppedObjects)
		{
			_remainingIndexList.Add(_preloadedDroppedObjects.IndexOf(preloadedDroppedObject));
		}
	}

	private void CreateRoot()
	{
		GameObject gameObject = new GameObject("DroppedObjectsRoot");
		if (!(gameObject == null))
		{
			_root = gameObject.transform;
			_root.parent = _parent;
		}
	}

	private int PickIndexToSpawn()
	{
		int index = UnityEngine.Random.Range(0, _remainingIndexList.Count);
		if (_remainingIndexList.Count != 0)
		{
			int result = _remainingIndexList[index];
			_remainingIndexList.RemoveAt(index);
			return result;
		}
		BuildRemainingIndexList();
		int result2 = _remainingIndexList[index];
		_remainingIndexList.RemoveAt(index);
		return result2;
	}

	private Vector3 CalculateWorldPositionFromCameraTransform(Transform camera)
	{
		Vector3 vector = Vector3.ProjectOnPlane(camera.forward, Vector3.up);
		Quaternion quaternion = Quaternion.AngleAxis(UnityEngine.Random.Range(_settings.AllowedAngle.Min, _settings.AllowedAngle.Max), Vector3.up);
		Vector3 result = camera.position + quaternion * vector * UnityEngine.Random.Range(_settings.AllowedDistance.Min, _settings.AllowedDistance.Max);
		result.y = UnityEngine.Random.Range(_settings.FallbackHeightOffset.Min, _settings.FallbackHeightOffset.Max) + result.y;
		return result;
	}
}
