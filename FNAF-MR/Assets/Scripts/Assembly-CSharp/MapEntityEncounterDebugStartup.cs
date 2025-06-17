using System;
using System.Collections.Generic;
using UnityEngine;

public class MapEntityEncounterDebugStartup : MonoBehaviour
{
	public void CreateAnimatronicMapEntityEncounter(string Id)
	{
		MapEntitySynchronizeableState obj = new MapEntitySynchronizeableState
		{
			entityId = Id + Guid.NewGuid().ToString(),
			entityClass = MapEntityType.SpecialDelivery,
			spawnTimeStamp = ServerTime.GetCurrentTime(),
			removeTimeStamp = ServerTime.GetCurrentTime() + 9999999,
			revealedBy = RevealedBy.Client,
			history = null,
			parts = new Dictionary<string, string>
			{
				{ "Cpu", Id },
				{ "PlushSuit", Id }
			},
			legacyEssence = 0,
			onScreenDuration = 99999999999999L,
			remnantSpawnWeights = new Dictionary<string, float>(),
			lootStructureId = Id,
			aggression = 0,
			perception = 0,
			durability = 0,
			attack = 0
		};
		RewardDataV3 rewardDataV = new RewardDataV3();
		RewardItem item = new RewardItem
		{
			amount = 69,
			item = "FAZ_TOKENS"
		};
		rewardDataV.currencyRewardList.Add(item);
		RewardItem item2 = new RewardItem
		{
			amount = 69,
			item = "PARTS"
		};
		rewardDataV.currencyRewardList.Add(item2);
		RewardItem item3 = new RewardItem
		{
			amount = 420,
			item = "ESSENCE"
		};
		rewardDataV.currencyRewardList.Add(item3);
		RewardItem item4 = new RewardItem
		{
			amount = 1,
			item = "Freddy"
		};
		rewardDataV.cpuRewardList.Add(item4);
		RewardItem item5 = new RewardItem
		{
			amount = 1,
			item = "PlushSuit"
		};
		List<RewardItem> value = new List<RewardItem> { item5 };
		rewardDataV.animatronicRewardTable.Add("Freddy", value);
		rewardDataV.essenceOnLoss = 23;
		obj.rewards = rewardDataV;
		MapEntity mapEntity = new MapEntity(obj, synchronizeOnServer: true, new MapEntitySpecialDeliveryInteractionController(MasterDomain.GetDomain().eventExposer, new MapEntityInteractionMutex()));
		mapEntity.HideOnMap = false;
		Debug.Log("calling animatronic encounter started with entity " + mapEntity.CPUId);
		MasterDomain.GetDomain().eventExposer.OnAnimatronicEncounterStarted(mapEntity);
	}
}
