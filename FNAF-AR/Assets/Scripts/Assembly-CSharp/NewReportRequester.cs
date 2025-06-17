using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using PlayFab.Json;
using UnityEngine;

public class NewReportRequester : MonoBehaviour
{
	public void RequestReports()
	{
		MasterDomain.GetDomain().ServerDomain.grantItemRequester.GrantPlayerItem("MXES_Mod");
	}

	private void OnHorrificFailure(PlayFabError error)
	{
		string text = error.ErrorDetails.ToString();
		Debug.LogError("OH GOD ITS ALL GONE TO SHIT ORTON.... THERE WAS A PLAYFAB ERROR.. THIS IS ALL I KNOW: \n" + text);
	}

	private void OnReportSuccess(ExecuteCloudScriptResult result)
	{
		Debug.Log("null create report result?" + (result.FunctionResult == null));
		if (result.FunctionResult != null)
		{
			Debug.Log("CREATE NEW REPORTS result: " + result.FunctionResult.ToString());
		}
	}

	private void GetPlayerDataNewError(ServerData data)
	{
		Debug.LogError(data.Keys);
	}

	private void OnGetPlayerDataSuccess(ExecuteCloudScriptResult result)
	{
		Debug.Log("null get player data result?" + (result.FunctionResult == null));
		if (result.FunctionResult != null)
		{
			ServerData serverResponse = new ServerData((JsonObject)result.FunctionResult);
			ProcessResponse(serverResponse);
			string text = result.FunctionResult.ToString();
			Debug.Log("GET PLAYER DATA result: " + text);
			ReportController.Instance.SetReportData(text);
		}
	}

	private void ProcessResponse(ServerData serverResponse)
	{
		ServerResponse serverResponse2 = new ServerResponse(serverResponse);
		if (serverResponse2.HasErrors)
		{
			Debug.LogError("PLAYFAB RESPONSE HAS ERRORS.");
		}
		else if (serverResponse2.ScriptData != null)
		{
			ProcessServerData(serverResponse2.ScriptData);
		}
	}

	private void ProcessServerData(ServerData scriptData)
	{
		TryHandleResponse(scriptData);
	}

	private void TryHandleResponse(ServerData data)
	{
		if (data.GetServerData("Reports") != null)
		{
			HandleResponse(data.GetServerData("Reports"));
		}
	}

	private void HandleResponse(ServerData data)
	{
		ConstructMapEntities(data);
	}

	private void ConstructMapEntities(ServerData data)
	{
		new List<MapEntitySynchronizeableState>();
		foreach (string key in data.Keys)
		{
			Debug.Log(key.ToString());
		}
	}

	private MapEntitySynchronizeableState Parse(ServerData data)
	{
		return new MapEntitySynchronizeableState();
	}
}
