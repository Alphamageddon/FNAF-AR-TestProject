using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLookupTableAccess : MonoBehaviour
{
	public delegate void ReturnWorkshopSceneLookupTable(WorkshopSceneLookupTable workshopSceneLookupTable);

	public delegate void ReturnCameraSceneLookupTable(CameraSceneLookupTable cameraSceneLookupTable);

	private WorkshopSceneLookupTable _workshopSceneLookupTable;

	private CameraSceneLookupTable _cameraSceneLookupTable;

	private List<ReturnWorkshopSceneLookupTable> _returnWorkshopSceneLookupTableCallbacks;

	private List<ReturnCameraSceneLookupTable> _returnCameraSceneLookupTableCallbacks;

	private bool foundCam;

	private bool foundWork;

	public void GetWorkshopSceneLookupTableAsync(ReturnWorkshopSceneLookupTable returnWorkshopSceneLookupTableCallback)
	{
		AddWorkshopSceneLookupTableCallback(returnWorkshopSceneLookupTableCallback);
		TryCallWorkshopSceneLookupTableCallbacks();
	}

	public void GetCameraSceneLookupTableAsync(ReturnCameraSceneLookupTable returnCameraSceneLookupTableCallback)
	{
		AddCameraSceneLookupTableCallback(returnCameraSceneLookupTableCallback);
		TryCallCameraSceneLookupTableCallbacks();
	}

	public void UnloadMapSceneLookupTable()
	{
	}

	private void AddWorkshopSceneLookupTableCallback(ReturnWorkshopSceneLookupTable returnWorkshopSceneLookupTableCallback)
	{
		_returnWorkshopSceneLookupTableCallbacks.Add(returnWorkshopSceneLookupTableCallback);
	}

	private void TryCallWorkshopSceneLookupTableCallbacks()
	{
		if (_workshopSceneLookupTable == null || !foundWork)
		{
			return;
		}
		foreach (ReturnWorkshopSceneLookupTable returnWorkshopSceneLookupTableCallback in _returnWorkshopSceneLookupTableCallbacks)
		{
			returnWorkshopSceneLookupTableCallback(_workshopSceneLookupTable);
		}
		_returnWorkshopSceneLookupTableCallbacks.Clear();
	}

	private void AddCameraSceneLookupTableCallback(ReturnCameraSceneLookupTable returnCameraSceneLookupTableCallback)
	{
		_returnCameraSceneLookupTableCallbacks.Remove(returnCameraSceneLookupTableCallback);
		_returnCameraSceneLookupTableCallbacks.Add(returnCameraSceneLookupTableCallback);
	}

	private void TryCallCameraSceneLookupTableCallbacks()
	{
		if (_cameraSceneLookupTable == null || !foundCam)
		{
			return;
		}
		foreach (ReturnCameraSceneLookupTable returnCameraSceneLookupTableCallback in _returnCameraSceneLookupTableCallbacks)
		{
			returnCameraSceneLookupTableCallback(_cameraSceneLookupTable);
		}
		_returnCameraSceneLookupTableCallbacks.Clear();
	}

	private void TryCallSplashSceneLookupTableCallbacks()
	{
	}

	private void Update()
	{
		if (SceneManager.GetActiveScene().name == "Encounter" || SceneManager.GetActiveScene().name == "ScavengingUI")
		{
			if (_cameraSceneLookupTable == null || !foundCam)
			{
				Debug.LogWarning("Grabbed camera scene lookup table");
				_cameraSceneLookupTable = GameObject.Find("CameraSceneLookupTable").GetComponent<CameraSceneLookupTable>();
				foundCam = true;
			}
		}
		else
		{
			foundCam = false;
		}
		if (SceneManager.GetActiveScene().buildIndex == 1)
		{
			if (_workshopSceneLookupTable == null || !foundWork)
			{
				_workshopSceneLookupTable = GameObject.Find("WorkshopSceneLookupTable").GetComponent<WorkshopSceneLookupTable>();
				foundWork = true;
			}
		}
		else
		{
			foundWork = false;
		}
		TryCallWorkshopSceneLookupTableCallbacks();
		TryCallCameraSceneLookupTableCallbacks();
	}

	public SceneLookupTableAccess()
	{
		_returnWorkshopSceneLookupTableCallbacks = new List<ReturnWorkshopSceneLookupTable>();
		_returnCameraSceneLookupTableCallbacks = new List<ReturnCameraSceneLookupTable>();
	}
}
