using System;
using System.Collections.Generic;
using UnityEngine;

public class CrateRewardResponseHandler : EventResponseHandler
{
	private Func<List<ServerData>, List<LootRewardEntry>> ProcessRewards;

	private Action<LootRewardDisplayData> LootRewardProcessed;

	public void Setup(Action<LootRewardDisplayData> callback)
	{
		LootRewardProcessed = callback;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerData("CrateRewards") != null)
		{
			HandleResponse(data.GetServerData("CrateRewards"));
		}
	}

	private void HandleResponse(ServerData data)
	{
		LootRewardDisplayData lootRewardDisplayData = new LootRewardDisplayData();
		if (!string.IsNullOrEmpty(data.GetString("CrateInfo")))
		{
			lootRewardDisplayData.crateInfo = MasterDomain.GetDomain().LootDomain.LootContainer.GetCrateInfoForId(data.GetString("CrateInfo"));
		}
		else
		{
			lootRewardDisplayData.crateInfo = MasterDomain.GetDomain().LootDomain.LootContainer.GetCrateInfoForId("RewardInfo_Bronze");
		}
		List<ServerData> serverDataList = data.GetServerDataList("RewardList");
		Debug.LogError("Reward list count: " + serverDataList.Count);
		lootRewardDisplayData.rewards = ProcessLootRewards(serverDataList);
		LootRewardProcessed(lootRewardDisplayData);
	}

	private List<LootRewardEntry> ProcessLootRewards(List<ServerData> data)
	{
		List<LootRewardEntry> list = new List<LootRewardEntry>();
		foreach (ServerData datum in data)
		{
			LootRewardEntry lootRewardEntry = new LootRewardEntry();
			ServerData serverData = datum.GetServerData("LootItem");
			LootItemData lootItemData = new LootItemData(serverData.GetString("Logical"), serverData.GetString("Type"), serverData.GetString("Subtype"));
			Debug.Log(lootItemData.Logical + " - " + lootItemData.Type);
			lootRewardEntry.LootItem = lootItemData;
			lootRewardEntry.NumToGive = datum.GetInt("NumToGive").Value;
			list.Add(lootRewardEntry);
		}
		return list;
	}
}
