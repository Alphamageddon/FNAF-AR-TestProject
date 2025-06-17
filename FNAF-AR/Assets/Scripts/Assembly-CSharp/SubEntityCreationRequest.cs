using System;
using UnityEngine;

public class SubEntityCreationRequest
{
	private Action<SubEntityCreationRequest> OnRequestComplete;

	private bool _spawnComplete;

	private bool _cancelled;

	public SubEntityData Data;

	public string Bundle { get; }

	public string Asset { get; }

	public GameObject SpawnedObject { get; set; }

	public bool IsComplete { get; set; }

	public void add_OnRequestComplete(Action<SubEntityCreationRequest> request)
	{
		OnRequestComplete = (Action<SubEntityCreationRequest>)Delegate.Combine(OnRequestComplete, request);
	}

	public void remove_OnRequestComplete(Action<SubEntityCreationRequest> request)
	{
		OnRequestComplete = (Action<SubEntityCreationRequest>)Delegate.Remove(OnRequestComplete, request);
	}

	public SubEntityCreationRequest(string bundle, string asset, SubEntityData data)
	{
		Bundle = bundle;
		Asset = asset;
		Data = data;
		SpawnedObject = null;
		IsComplete = false;
		MasterDomain.GetDomain().eventExposer.add_GameDisplayChange(SceneChanged);
	}

	private void SceneChanged(GameDisplayData data)
	{
		Debug.LogError("Scene changed while instantiating sub entity " + Bundle + "_" + Asset);
		CancelRequest();
	}

	public void SetObjectCreationSuccess(GameObject spawnedObj)
	{
		_spawnComplete = true;
		SpawnedObject = spawnedObj;
		TryToNotifyComplete();
	}

	public void SetObjectCreationFailure()
	{
		_spawnComplete = true;
		SpawnedObject = null;
		TryToNotifyComplete();
	}

	public void CancelRequest()
	{
		Debug.Log("Sub entity instantiate req cancelled");
		_cancelled = true;
	}

	public bool IsCancelled()
	{
		return _cancelled;
	}

	private void TryToNotifyComplete()
	{
		if (!_spawnComplete)
		{
			Debug.LogError("Not Complete.");
			return;
		}
		IsComplete = true;
		if (_cancelled)
		{
			MasterDomain.GetDomain().GameAssetManagementDomain.ReleaseGenericSpawn(SpawnedObject);
			UnityEngine.Object.Destroy(SpawnedObject);
			SpawnedObject = null;
		}
		if (OnRequestComplete != null)
		{
			OnRequestComplete(this);
		}
		OnRequestComplete = null;
		MasterDomain.GetDomain().eventExposer.remove_GameDisplayChange(SceneChanged);
	}
}
