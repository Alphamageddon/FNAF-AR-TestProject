using System.Collections.Generic;
using UnityEngine;

public class StaticConfigs
{
	private static readonly StaticConfig NullConfig;

	private readonly Dictionary<string, StaticConfig> _staticConfigs;

	public StaticConfig GetStaticConfig(string profileId)
	{
		StaticConfig value = null;
		if (_staticConfigs.ContainsKey(profileId))
		{
			_staticConfigs.TryGetValue(profileId, out value);
			return value;
		}
		return NullConfig;
	}

	public StaticConfigs(MasterDataDomain masterDataDomain)
	{
		_staticConfigs = new Dictionary<string, StaticConfig>();
		masterDataDomain.GetAccessToData.GetStaticDataAsync(StaticDataReady);
	}

	private void StaticDataReady(STATIC_DATA.Root staticData)
	{
		if (staticData == null)
		{
			Debug.LogError("Static data null??");
		}
		foreach (STATIC_DATA.Entry entry in staticData.Entries)
		{
			if (entry != null && !string.IsNullOrWhiteSpace(entry.Profile) && !_staticConfigs.ContainsKey(entry.Profile))
			{
				_staticConfigs.Add(entry.Profile, new StaticConfig(entry));
			}
		}
	}

	static StaticConfigs()
	{
		NullConfig = null;
	}
}
