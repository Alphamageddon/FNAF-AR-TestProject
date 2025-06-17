using System;
using System.Collections.Generic;
using PlayFab.ClientModels;
using UnityEngine;

public static class ServerProcessors
{
	public static PlayerFriendsEntry ProcessPlayerFriendsEntry(ServerData entry)
	{
		return new PlayerFriendsEntry
		{
			userId = entry.GetString("userId"),
			displayName = entry.GetString("displayName"),
			avatarId = entry.GetString("avatarId")
		};
	}

	public static Dictionary<string, int> ProcessPlayerGoods(List<ServerData> data)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		foreach (ServerData datum in data)
		{
			ItemInstance itemInstance = JsonUtility.FromJson<ItemInstance>(datum.JSON);
			if (dictionary.ContainsKey(itemInstance.ItemId))
			{
				dictionary[itemInstance.ItemId] = dictionary[itemInstance.ItemId] + 1;
			}
			else
			{
				dictionary.Add(itemInstance.ItemId, 1);
			}
			Debug.Log(itemInstance.ItemId);
		}
		return dictionary;
	}

	public static WorkshopEntry ProcessWorkshopDataEntry(ServerData entry)
	{
		WorkshopEntry.Status result = WorkshopEntry.Status.Available;
		Enum.TryParse<WorkshopEntry.Status>(entry.GetString("status"), out result);
		EndoskeletonData endoskeleton = ProcessEndoskeleton(entry.GetServerData("endoskeleton"));
		return new WorkshopEntry
		{
			lastCommand = entry.GetDouble("lastCommand").Value,
			entityId = entry.GetString("entityId"),
			health = entry.GetInt("wearAndTear").Value,
			endoskeleton = endoskeleton,
			status = result,
			appointmentId = entry.GetString("appointmentId")
		};
	}

	private static EndoskeletonData ProcessEndoskeleton(ServerData endoskeleton)
	{
		if (endoskeleton == null)
		{
			return null;
		}
		EndoskeletonData obj = new EndoskeletonData
		{
			cpu = endoskeleton.GetString("cpu"),
			plushSuit = endoskeleton.GetString("plushSuit"),
			mods = endoskeleton.GetStringList("mods")
		};
		Debug.Log(endoskeleton.JSON);
		obj.numEssence = endoskeleton.GetInt("essence").Value;
		return obj;
	}
}
