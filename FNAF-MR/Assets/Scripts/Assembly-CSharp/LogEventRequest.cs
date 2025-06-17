using System.Collections.Generic;
using PlayFab.Json;

public class LogEventRequest
{
	public readonly JsonObject JSONData;

	private string eventKey;

	public string JSONString => JSONData.ToString();

	public void SetEventKey(string key)
	{
		eventKey = key;
	}

	public void SetEventAttribute(string key, string value)
	{
		JSONData[key] = value;
	}

	public void SetEventAttribute(string key, int value)
	{
		JSONData[key] = value;
	}

	public void SetEventAttribute(string key, List<string> value)
	{
		JSONData[key] = value;
	}

	public void SetEventAttribute(string key, long value)
	{
		JSONData[key] = value;
	}

	public void SetEventAttribute(string key, ServerRequestData value)
	{
		JSONData[key] = value.BaseData;
	}

	public void SetEventAttribute(string key, ServerData value)
	{
		JSONData[key] = value;
	}

	public void SetEventAttribute(string steps, JsonArray value)
	{
		JSONData[steps] = value;
	}

	public void SetEventAttribute(string key, bool value)
	{
		JSONData[key] = value;
	}

	public string GetEventKey()
	{
		return eventKey;
	}

	public LogEventRequest()
	{
		JSONData = new JsonObject();
	}
}
