using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrophiesStateUIView : MonoBehaviour
{
	[Header("Editor Hookups")]
	[SerializeField]
	private Transform trophyPrefabParent;

	[SerializeField]
	private TextMeshProUGUI trophyNameText;

	[SerializeField]
	private TextMeshProUGUI trophyDescriptionText;

	[SerializeField]
	private GameObject checkActiveTrophyCanvas;

	[Header("Selection")]
	[SerializeField]
	private TrophyCell _trophyCellPrefab;

	[SerializeField]
	private Transform _trophyCellParent;

	private GameObject spawnedPrefab;

	private GameAssetManagementDomain gameAssetManagementDomain;

	private Localization loc;

	private TrophySelectionHandler _trophySelectionHandler;

	private float rotateSpeed;

	private GenericCreationRequest _currentRequest;

	private void Awake()
	{
		MasterDomain domain = MasterDomain.GetDomain();
		gameAssetManagementDomain = domain.GameAssetManagementDomain;
		loc = domain.LocalizationDomain.Localization;
		domain.eventExposer.add_TrophyChanged(SpawnTrophy);
		_trophySelectionHandler = new TrophySelectionHandler(new TrophySelectionHandlerLoadData
		{
			cellPrefab = _trophyCellPrefab,
			cellParent = _trophyCellParent,
			assetCache = gameAssetManagementDomain.AssetCacheAccess,
			itemDefinitions = domain.ItemDefinitionDomain.ItemDefinitions,
			inventory = domain.WorkshopDomain.Inventory
		});
		rotateSpeed = 180f / ((float)Screen.width * 0.5f);
	}

	public void SpawnTrophy(TrophyData data)
	{
		if (spawnedPrefab != null)
		{
			Object.Destroy(spawnedPrefab);
		}
		trophyPrefabParent.localRotation = Quaternion.Euler(0f, -90f, 0f);
		trophyNameText.text = loc.GetLocalizedString(data.TrophyName, data.TrophyName);
		trophyDescriptionText.text = loc.GetLocalizedString(data.TrophyDescription, data.TrophyDescription);
		if (_currentRequest != null)
		{
			_currentRequest.CancelRequest();
		}
		_currentRequest = new GenericCreationRequest(data.Bundle, data.Asset);
		_currentRequest.add_OnRequestComplete(PrefabSpawned);
		gameAssetManagementDomain.CreateSafeObject(_currentRequest);
	}

	private void PrefabSpawned(GenericCreationRequest req)
	{
		if (!(req.SpawnedObject == null) && !req.IsCancelled())
		{
			spawnedPrefab = req.SpawnedObject;
			spawnedPrefab.transform.SetParent(trophyPrefabParent, worldPositionStays: true);
			spawnedPrefab.transform.localPosition = Vector3.zero;
			spawnedPrefab.transform.localRotation = Quaternion.Euler(new Vector3(spawnedPrefab.transform.localRotation.eulerAngles.x, spawnedPrefab.transform.localRotation.eulerAngles.y - 90f, spawnedPrefab.transform.localRotation.eulerAngles.z));
			spawnedPrefab.layer = 8;
		}
	}

	private void OnDestroy()
	{
		_trophySelectionHandler.OnDestroy();
		MasterDomain.GetDomain().eventExposer.remove_TrophyChanged(SpawnTrophy);
	}

	private void OnEnable()
	{
		MasterDomain.GetDomain().eventExposer.add_GestureTouchEvent(GestureTouchEventHandler);
	}

	private void OnDisable()
	{
		MasterDomain.GetDomain().eventExposer.remove_GestureTouchEvent(GestureTouchEventHandler);
	}

	private void GestureTouchEventHandler(List<Vector2> prevTouchPosition, List<Vector2> currTouchPosition)
	{
		if (checkActiveTrophyCanvas.activeInHierarchy)
		{
			RotateCamera(prevTouchPosition, currTouchPosition);
		}
	}

	private void RotateCamera(List<Vector2> prevTouches, List<Vector2> currTouches)
	{
		if (prevTouches.Count == 0)
		{
			Debug.Log("No prev");
		}
		else if (currTouches.Count == 1 && currTouches.Count == prevTouches.Count)
		{
			_ = 180f / ((float)Screen.width * 0.5f);
			RotateTrophyFacing(prevTouches[0], currTouches[0]);
		}
	}

	public void RotateTrophyFacing(Vector3 mPrevPos, Vector3 mCurrPos)
	{
		if (!(spawnedPrefab == null))
		{
			trophyPrefabParent.transform.Rotate(0f, 0f - (mCurrPos.x - mPrevPos.x) * rotateSpeed, 0f, Space.Self);
		}
	}
}
