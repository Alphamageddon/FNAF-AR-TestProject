using System;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class PlayFabExecuteScriptRequest : IExecuteScriptRequest
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public ExecuteScriptParameters parameters;

		internal void _003CExecuteParameters_003Eg__OnExecuteCloudScriptResponse_007C0(ExecuteCloudScriptResult executeCloudScriptResult)
		{
			if (parameters.resultCallback != null)
			{
				parameters.resultCallback(DataConverter.GenerateExecuteScriptResult(executeCloudScriptResult));
			}
		}

		internal void _003CExecuteParameters_003Eg__OnExecuteCloudScriptError_007C1(PlayFabError playfabError)
		{
			if (parameters.errorCallback != null)
			{
				parameters.errorCallback(DataConverter.GenerateErrorData(playfabError));
			}
		}
	}

	private readonly Action<ExecuteCloudScriptRequest, Action<ExecuteCloudScriptResult>, Action<PlayFabError>, object, Dictionary<string, string>> _executeCloudScriptApi;

	public PlayFabExecuteScriptRequest(Action<ExecuteCloudScriptRequest, Action<ExecuteCloudScriptResult>, Action<PlayFabError>, object, Dictionary<string, string>> executeCloudScriptApi)
	{
		if (executeCloudScriptApi != null)
		{
			_executeCloudScriptApi = executeCloudScriptApi;
		}
		else
		{
			new NullReferenceException("executeCloudScriptAPI");
		}
	}

	public void ExecuteParameters(ExecuteScriptParameters parameters)
	{
		int value = 0;
		CloudScriptRevisionOption value2 = CloudScriptRevisionOption.Live;
		if (PlayerPrefs.HasKey("SpecificRevision") || ConstantVariables.Instance.SpecificRevision != 0)
		{
			value2 = CloudScriptRevisionOption.Specific;
			value = (PlayerPrefs.HasKey("SpecificRevision") ? PlayerPrefs.GetInt("SpecificRevision") : ConstantVariables.Instance.SpecificRevision);
		}
		ExecuteCloudScriptRequest arg = new ExecuteCloudScriptRequest
		{
			FunctionName = parameters.functionName,
			FunctionParameter = parameters.functionParameter,
			GeneratePlayStreamEvent = true,
			AuthenticationContext = DataConverter.GenerateAuthContext(parameters.authContext),
			RevisionSelection = value2,
			SpecificRevision = value
		};
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.parameters = parameters;
		Debug.LogError("EXECUTING SCRIPT REQUEST " + parameters.functionName);
		_executeCloudScriptApi(arg, _003C_003Ec__DisplayClass2_._003CExecuteParameters_003Eg__OnExecuteCloudScriptResponse_007C0, _003C_003Ec__DisplayClass2_._003CExecuteParameters_003Eg__OnExecuteCloudScriptError_007C1, null, null);
	}
}
