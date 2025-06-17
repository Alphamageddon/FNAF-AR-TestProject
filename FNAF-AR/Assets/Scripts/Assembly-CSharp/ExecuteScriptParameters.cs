using System;
using PlayFab.Json;

public class ExecuteScriptParameters
{
	public string functionName;

	public JsonObject functionParameter;

	public Action<ExecuteScriptResult> resultCallback;

	public Action<IllumixErrorData> errorCallback;

	public IllumixAuthenticationContext authContext;

	public bool generatePlayStreamEvent;

	public ExecuteScriptParameters()
	{
	}

	public ExecuteScriptParameters(ExecuteScriptParameters scriptParameters)
	{
		if (scriptParameters != null)
		{
			functionName = scriptParameters.functionName;
			functionParameter = scriptParameters.functionParameter;
			resultCallback = scriptParameters.resultCallback;
			errorCallback = scriptParameters.errorCallback;
			authContext = scriptParameters.authContext;
			generatePlayStreamEvent = scriptParameters.generatePlayStreamEvent;
		}
	}
}
