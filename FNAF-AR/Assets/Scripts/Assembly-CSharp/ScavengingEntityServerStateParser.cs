using System;
using System.Collections.Generic;

public class ScavengingEntityServerStateParser
{
	public ScavengingEntitySynchronizeableState Parse(ServerData data)
	{
		return new ScavengingEntitySynchronizeableState
		{
			entityId = data.GetString("EntityId"),
			entityClass = (ScavengingEntityType)Enum.Parse(typeof(ScavengingEntityType), data.GetString("EntityClass")),
			spawnTimeStamp = data.GetLong("SpawnTime").Value,
			removeTimeStamp = data.GetLong("RemoveTime").Value,
			onScreenDuration = data.GetLong("OnScreenDuration").Value,
			parts = GenerateScavengingEntityParts(data.GetServerData("AnimatronicParts")),
			environment = data.GetString("ScavengingLocation")
		};
	}

	private Dictionary<string, string> GenerateScavengingEntityParts(ServerData data)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (string key in data.Keys)
		{
			dictionary.Add(key, data.GetString(key));
		}
		return dictionary;
	}
}
