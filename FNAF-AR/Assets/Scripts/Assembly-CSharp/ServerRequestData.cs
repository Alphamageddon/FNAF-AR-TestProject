using System.Collections.Generic;
using PlayFab.Json;

public class ServerRequestData
{
	public readonly JsonObject BaseData;

	public ServerRequestData()
	{
		BaseData = new JsonObject();
	}

	public void AddObject(string key, ServerRequestData value)
	{
		BaseData[key] = value.BaseData;
	}

	public void AddNumber(string key, int value)
	{
		BaseData[key] = value;
	}

	public void AddStringList(string key, List<string> value)
	{
		BaseData[key] = value;
	}

	public void AddString(string key, string value)
	{
		BaseData[key] = value;
	}

	public void AddBoolean(string key, bool value)
	{
		BaseData[key] = value;
	}

	public void AddNumber(string key, float value)
	{
		BaseData[key] = value;
	}

	public void AddNumber(string key, double value)
	{
		BaseData[key] = value;
	}
}
