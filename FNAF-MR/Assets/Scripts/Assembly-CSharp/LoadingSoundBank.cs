using System;
using System.Collections.Generic;

public class LoadingSoundBank
{
	private readonly string _soundBankName;

	private List<SoundBankRequest> _pendingRequests;

	private WwiseSoundBank _loadingSoundBank;

	private Action<string, WwiseSoundBank> _onSuccess;

	private Action<string> _onFailure;

	public LoadingSoundBank(SoundBankRequest request, Action<string, WwiseSoundBank> onSuccess, Action<string> onFailure)
	{
		_pendingRequests = new List<SoundBankRequest>();
		_soundBankName = request.SoundBankName;
		_pendingRequests.Add(request);
		_onSuccess = onSuccess;
		_onFailure = onFailure;
	}

	public void AddRequest(SoundBankRequest request)
	{
		_pendingRequests.Add(request);
	}

	public void Load(AssetCache assetCache)
	{
		_loadingSoundBank = new WwiseSoundBank();
		_loadingSoundBank.Setup(assetCache, _soundBankName, LoadSuccess, LoadFailure);
	}

	private void LoadSuccess(string soundBankName)
	{
		foreach (SoundBankRequest pendingRequest in _pendingRequests)
		{
			pendingRequest.Success?.Invoke(_soundBankName);
		}
		_onSuccess?.Invoke(_soundBankName, _loadingSoundBank);
	}

	private void LoadFailure(string soundBankName)
	{
		foreach (SoundBankRequest pendingRequest in _pendingRequests)
		{
			pendingRequest.Failure?.Invoke(_soundBankName);
		}
		_onFailure?.Invoke(_soundBankName);
	}

	public void Teardown()
	{
		_pendingRequests.Clear();
		_pendingRequests = null;
	}
}
