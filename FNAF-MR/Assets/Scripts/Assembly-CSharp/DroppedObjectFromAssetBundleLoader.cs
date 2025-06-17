using System;
using System.Collections.Generic;
using UnityEngine;

public class DroppedObjectFromAssetBundleLoader : IDroppedObjectLoader
{
	private AssetCache _assetCache;

	private string _templateBundleName;

	private string _templateAssetName;

	private string _objectBundleName;

	private string[] _objectAssetNames;

	private DroppedObject _templatePrefab;

	private Transform _parent;

	private List<DroppedObject> _droppedObjects;

	private List<GameObject> _loadedDroppedObjectModels;

	private Action<List<DroppedObject>> _onComplete;

	private bool _hasBeenUsed;

	private bool _isLoading;

	private bool _unloadRequested;

	private int _failureCount;

	public DroppedObjectFromAssetBundleLoader(AssetCache assetCache, string templateBundleName, string templateAssetName, string objectBundleName, string[] objectAssetNames)
	{
		_assetCache = assetCache;
		_templateBundleName = templateBundleName;
		_templateAssetName = templateAssetName;
		_objectBundleName = objectBundleName;
		_objectAssetNames = objectAssetNames;
	}

	public void Load(Transform parent, Action<List<DroppedObject>> onComplete)
	{
		if (_hasBeenUsed)
		{
			Debug.LogError("DroppedObjectFromAssetBundleLoader Load - Load cannot be called more than once");
			return;
		}
		_hasBeenUsed = true;
		if (_objectAssetNames.Length != 0)
		{
			_parent = parent;
			_droppedObjects = new List<DroppedObject>();
			_loadedDroppedObjectModels = new List<GameObject>();
			_onComplete = onComplete;
			_isLoading = true;
			_assetCache.LoadAsset<GameObject>(_templateBundleName, _templateAssetName, TemplatePrefabLoaded, delegate
			{
				AssetLoadFailure(_templateBundleName, _templateAssetName);
			});
		}
		else
		{
			onComplete?.Invoke(new List<DroppedObject>());
		}
	}

	public void Unload()
	{
		_onComplete = null;
		if (_isLoading)
		{
			_unloadRequested = true;
		}
		else
		{
			UnloadAssets();
		}
	}

	private void TemplatePrefabLoaded(GameObject gameObject)
	{
		if (gameObject != null)
		{
			_templatePrefab = gameObject.GetComponent<DroppedObject>();
		}
		if (_templatePrefab == null)
		{
			AssetLoadFailure(_templateBundleName, _templateAssetName);
		}
		else
		{
			CreateDroppedObjects();
		}
	}

	private void CreateDroppedObjects()
	{
		GameAssetManagementDomain gameAssetManagementDomain = MasterDomain.GetDomain().GameAssetManagementDomain;
		string[] objectAssetNames = _objectAssetNames;
		string assetName;
		for (int i = 0; i < objectAssetNames.Length; i++)
		{
			GenericCreationRequest genericCreationRequest = new GenericCreationRequest(asset: assetName = objectAssetNames[i], bundle: _objectBundleName);
			genericCreationRequest.add_OnRequestComplete(PrefabSpawned);
			gameAssetManagementDomain.CreateSafeObject(genericCreationRequest);
		}
		void PrefabSpawned(GenericCreationRequest req)
		{
			if (req.SpawnedObject == null)
			{
				AssetLoadFailure(_objectBundleName, assetName);
			}
			else
			{
				CreateDroppedObject(req.SpawnedObject);
			}
		}
	}

	private bool CreateDroppedObject(GameObject droppedObjectInstance)
	{
		droppedObjectInstance.name = droppedObjectInstance.name.Replace("(Clone)", "");
		DroppedObject droppedObject = UnityEngine.Object.Instantiate(_templatePrefab, _parent);
		if (droppedObject != null && droppedObject.modelRoot != null)
		{
			droppedObjectInstance.transform.SetParent(droppedObject.modelRoot, worldPositionStays: false);
			if (droppedObjectInstance != null)
			{
				droppedObject.gameObject.AddComponent<DroppedObjectMaterialController>().Setup(droppedObject);
				droppedObject.modelRoot.gameObject.SetActive(value: false);
				if (droppedObject.animator != null)
				{
					droppedObject.animator.enabled = true;
					droppedObject.animator.Rebind();
				}
				_droppedObjects.Add(droppedObject);
				_loadedDroppedObjectModels.Add(droppedObjectInstance);
				TryToCompleteLoading();
				return true;
			}
			UnityEngine.Object.Destroy(droppedObject);
		}
		return false;
	}

	private void AssetLoadFailure(string bundleName, string assetName)
	{
		Debug.LogError("DroppedObjectFromAssetBundleLoader AssetLoadFailure - Failed to load " + assetName + " from " + bundleName);
		_failureCount++;
		TryToCompleteLoading();
	}

	private void TryToCompleteLoading()
	{
		if (_droppedObjects.Count + _failureCount == _objectAssetNames.Length)
		{
			_onComplete?.Invoke(_droppedObjects);
			_parent = null;
			_onComplete = null;
			_isLoading = false;
			if (_unloadRequested)
			{
				UnloadAssets();
			}
		}
	}

	private void UnloadAssets()
	{
		if (_loadedDroppedObjectModels == null)
		{
			Debug.LogError("Unload already fuckin requested! Time out lil bro!");
			return;
		}
		foreach (GameObject loadedDroppedObjectModel in _loadedDroppedObjectModels)
		{
			_assetCache.ReleaseInstance(loadedDroppedObjectModel);
		}
		_loadedDroppedObjectModels.Clear();
		_loadedDroppedObjectModels = null;
		_objectBundleName = null;
		_objectAssetNames = null;
		_assetCache.ReleaseAsset(_templatePrefab.gameObject);
		_templatePrefab = null;
		_templateBundleName = null;
		_templateAssetName = null;
		_droppedObjects.Clear();
		_droppedObjects = null;
		_assetCache = null;
	}
}
