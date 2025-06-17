using System;
using FMODUnity;
using UnityEngine;

public class WwiseSoundBank
{
	private Action<string> _onSuccess;

	private Action<string> _onFailure;

	private AssetCache _assetCache;

	private string _bankName;

	public void Setup(AssetCache assetCache, string bankName, Action<string> onSuccess, Action<string> onFailure)
	{
		_bankName = bankName;
		_onSuccess = onSuccess;
		_onFailure = onFailure;
		_assetCache = assetCache;
		_assetCache.LoadAsset<TextAsset>("audio", _bankName + ".bytes", LoadSuccess, LoadFailure);
	}

	private void LoadSuccess(TextAsset loadedFile)
	{
		if (loadedFile != null)
		{
			Debug.Log("success loading bank " + _bankName);
			RuntimeManager.LoadBank(loadedFile);
			_onSuccess?.Invoke(_bankName);
			_onSuccess = null;
			_onFailure = null;
			_assetCache.ReleaseAsset(loadedFile);
			_assetCache = null;
		}
		else
		{
			_onFailure?.Invoke(_bankName);
			_onSuccess = null;
			_onFailure = null;
		}
	}

	private void LoadFailure()
	{
		_onFailure?.Invoke(_bankName);
		_onSuccess = null;
		_onFailure = null;
	}

	private void ClearCallbacks()
	{
		_onSuccess = null;
		_onFailure = null;
	}

	public void Teardown()
	{
		_onSuccess = null;
		_onFailure = null;
		Debug.Log("unloaded bank " + _bankName);
		RuntimeManager.UnloadBank(_bankName);
	}
}
