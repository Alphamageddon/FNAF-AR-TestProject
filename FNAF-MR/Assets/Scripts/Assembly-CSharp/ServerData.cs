using System;
using System.Collections.Generic;
using PlayFab.Json;
using UnityEngine;

public class ServerData
{
	private readonly JsonObject _json;

	public virtual IDictionary<string, object> BaseData => _json;

	public virtual string JSON => _json.ToString();

	public ICollection<string> Keys => _json.Keys;

	public ServerData(JsonObject jsonObject)
	{
		if (jsonObject != null)
		{
			_json = jsonObject;
		}
		else
		{
			Debug.LogError("JsonObject is null or invalid!");
		}
	}

	public ServerData()
	{
		_json = new JsonObject();
	}

	public virtual int? GetInt(string key)
	{
		if (_json.ContainsKey(key))
		{
			return Convert.ToInt32(_json[key]);
		}
		return null;
	}

	public virtual string GetString(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		if (_json[key] == null)
		{
			return null;
		}
		return Convert.ToString(_json[key]);
	}

	public virtual DateTime? GetDate(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		return Convert.ToDateTime(_json[key]);
	}

	public virtual double? GetDouble(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		return Convert.ToDouble(_json[key]);
	}

	public virtual long? GetLong(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		return Convert.ToInt64(_json[key]);
	}

	public virtual float? GetFloat(string key)
	{
		if (_json.ContainsKey(key))
		{
			return Convert.ToSingle(_json[key]);
		}
		return null;
	}

	public virtual long? GetNumber(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		return Convert.ToInt64(_json[key]);
	}

	public virtual bool? GetBoolean(string key)
	{
		if (_json.ContainsKey(key))
		{
			return (bool)_json[key];
		}
		return null;
	}

	public virtual bool ContainsKey(string key)
	{
		if (_json != null)
		{
			return _json.ContainsKey(key);
		}
		return false;
	}

	public virtual List<int> GetIntList(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		if (_json[key] == null)
		{
			return null;
		}
		List<object> list = (List<object>)_json[key];
		List<int> list2 = new List<int>();
		list2.Capacity = list.Count;
		foreach (object item in list)
		{
			list2.Add(Convert.ToInt32(item));
		}
		return list2;
	}

	public virtual List<long> GetLongList(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		if (_json[key] == null)
		{
			return null;
		}
		List<object> list = (List<object>)_json[key];
		List<long> list2 = new List<long>();
		list2.Capacity = list.Count;
		foreach (object item in list)
		{
			list2.Add(Convert.ToInt64(item));
		}
		return list2;
	}

	public virtual List<float> GetFloatList(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		if (_json[key] == null)
		{
			return null;
		}
		List<object> list = (List<object>)_json[key];
		List<float> list2 = new List<float>();
		list2.Capacity = list.Count;
		foreach (object item in list)
		{
			list2.Add(Convert.ToSingle(item));
		}
		return list2;
	}

	public virtual List<double> GetDoubleList(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		if (_json[key] == null)
		{
			return null;
		}
		List<object> list = (List<object>)_json[key];
		List<double> list2 = new List<double>();
		list2.Capacity = list.Count;
		foreach (object item in list)
		{
			list2.Add(Convert.ToDouble(item));
		}
		return list2;
	}

	public virtual List<string> GetStringList(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		if (_json[key] == null)
		{
			return null;
		}
		List<object> list = (List<object>)_json[key];
		List<string> list2 = new List<string>();
		list2.Capacity = list.Count;
		foreach (object item in list)
		{
			list2.Add((string)item);
		}
		return list2;
	}

	public virtual List<bool> GetBooleanList(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		if (_json[key] == null)
		{
			return null;
		}
		List<object> list = (List<object>)_json[key];
		List<bool> list2 = new List<bool>();
		list2.Capacity = list.Count;
		foreach (object item in list)
		{
			list2.Add((bool)item);
		}
		return list2;
	}

	public virtual ServerData GetServerData(string key)
	{
		if (_json.ContainsKey(key))
		{
			return new ServerData((JsonObject)_json[key]);
		}
		return null;
	}

	public virtual List<ServerData> GetServerDataList(string key)
	{
		if (!_json.ContainsKey(key))
		{
			return null;
		}
		if (_json[key] == null)
		{
			return null;
		}
		List<object> list = (List<object>)_json[key];
		List<ServerData> list2 = new List<ServerData>();
		list2.Capacity = list.Count;
		if (list.Count < 1)
		{
			return list2;
		}
		foreach (object item in list)
		{
			list2.Add(new ServerData((JsonObject)item));
		}
		return list2;
	}
}
