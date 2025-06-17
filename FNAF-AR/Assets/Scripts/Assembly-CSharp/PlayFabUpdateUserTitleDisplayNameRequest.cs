using System;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;

public class PlayFabUpdateUserTitleDisplayNameRequest : IUpdateUserTitleDisplayNameRequest
{
	private Action<string> _resultCallback;

	private Action<IllumixErrorData> _errorCallback;

	private readonly Action<UpdateUserTitleDisplayNameRequest, Action<UpdateUserTitleDisplayNameResult>, Action<PlayFabError>, object, Dictionary<string, string>> _updateUserTitleDisplayName;

	public PlayFabUpdateUserTitleDisplayNameRequest(Action<UpdateUserTitleDisplayNameRequest, Action<UpdateUserTitleDisplayNameResult>, Action<PlayFabError>, object, Dictionary<string, string>> updateUserTitleDisplayName)
	{
		if (updateUserTitleDisplayName != null)
		{
			_updateUserTitleDisplayName = updateUserTitleDisplayName;
		}
		else
		{
			new NullReferenceException("updateUserTitleDisplayName");
		}
	}

	public void SetCallbacks(Action<string> result, Action<IllumixErrorData> error)
	{
		_resultCallback = result;
		_errorCallback = error;
	}

	public void UpdateWithDisplayName(string displayName)
	{
		UpdateUserTitleDisplayNameRequest updateUserTitleDisplayNameRequest = new UpdateUserTitleDisplayNameRequest();
		updateUserTitleDisplayNameRequest.DisplayName = displayName;
		_updateUserTitleDisplayName(updateUserTitleDisplayNameRequest, OnChangeDisplayNameSuccess, OnChangeDisplayNameError, null, null);
	}

	private void OnChangeDisplayNameSuccess(UpdateUserTitleDisplayNameResult result)
	{
		_resultCallback(result.DisplayName);
	}

	private void OnChangeDisplayNameError(PlayFabError playFabError)
	{
		_errorCallback(DataConverter.GenerateErrorData(playFabError));
	}
}
