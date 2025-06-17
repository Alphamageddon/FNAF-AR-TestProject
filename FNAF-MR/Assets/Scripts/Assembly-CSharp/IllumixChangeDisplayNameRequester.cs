using System;
using UnityEngine;

public class IllumixChangeDisplayNameRequester : ChangeDisplayNameRequester
{
	private const string ClassName = "IllumixChangeDisplayNameRequester";

	private Action<UserNameSetError> _obscenityFoundCallback;

	private Action<PlayerProfile> _playerProfileUpdated;

	private IUpdateUserTitleDisplayNameRequest _updateUserTitleDisplayNameRequest;

	public IllumixChangeDisplayNameRequester(IUpdateUserTitleDisplayNameRequest updateUserTitleDisplayNameRequest)
	{
		_updateUserTitleDisplayNameRequest = updateUserTitleDisplayNameRequest;
		updateUserTitleDisplayNameRequest.SetCallbacks(OnUserTitleDisplayNameUpdated, IllumixErrorCallback);
	}

	public void Setup(Action<PlayerProfile> playerProfileCallback, Action<UserNameSetError> obscenityFoundCallback)
	{
		_obscenityFoundCallback = obscenityFoundCallback;
		_playerProfileUpdated = playerProfileCallback;
	}

	public void ChangeDisplayName(string displayName)
	{
		_updateUserTitleDisplayNameRequest.UpdateWithDisplayName(displayName);
	}

	private void OnUserTitleDisplayNameUpdated(string displayName)
	{
		PlayerProfile playerProfile = MasterDomain.GetDomain().TheGameDomain.loginDomain.playerProfile;
		playerProfile.displayName = displayName;
		if (_playerProfileUpdated != null)
		{
			_playerProfileUpdated(playerProfile);
		}
	}

	private void IllumixErrorCallback(IllumixErrorData error)
	{
		if (error.errorCode == "NameNotAvailable")
		{
			_obscenityFoundCallback(UserNameSetError.NAME_NOT_UNIQUE);
		}
		else if (error.errorCode == "ProfaneDisplayName")
		{
			_obscenityFoundCallback(UserNameSetError.NAME_OBSCENE);
		}
		else
		{
			Debug.LogError("IllumixChangeDisplayNameRequester IllumixErrorCallback - " + error.errorMessage);
		}
	}
}
