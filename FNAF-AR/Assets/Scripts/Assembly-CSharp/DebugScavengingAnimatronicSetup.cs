using System;
using System.Collections.Generic;
using UnityEngine;

public class DebugScavengingAnimatronicSetup : MonoBehaviour
{
	public void StartScavenge(string Id)
	{
		MapEntitySynchronizeableState obj = new MapEntitySynchronizeableState
		{
			entityId = Id + Guid.NewGuid().ToString(),
			entityClass = MapEntityType.SpecialDelivery,
			spawnTimeStamp = ServerTime.GetCurrentTime(),
			removeTimeStamp = ServerTime.GetCurrentTime() + 9999999,
			revealedBy = RevealedBy.Client,
			history = null
		};
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{ "Cpu", Id },
			{ "PlushSuit", Id }
		};
		if (Id == "Corruption")
		{
			dictionary.Add("mod1", "PhantomFreddy");
			dictionary.Add("mod2", "PhantomBB");
			dictionary.Add("mod3", "MXES");
		}
		obj.parts = dictionary;
		obj.legacyEssence = 0;
		obj.onScreenDuration = 99999999999999L;
		obj.remnantSpawnWeights = new Dictionary<string, float>();
		obj.lootStructureId = Id;
		obj.aggression = 0;
		obj.perception = 0;
		obj.durability = 0;
		obj.attack = 0;
		RewardDataV3 rewards = new RewardDataV3();
		obj.rewards = rewards;
		MapEntity mapEntity = new MapEntity(obj, synchronizeOnServer: false, new MapEntitySpecialDeliveryInteractionController(MasterDomain.GetDomain().eventExposer, new MapEntityInteractionMutex()));
		mapEntity.HideOnMap = false;
		Debug.Log("calling animatronic scavenging encounter started with entity " + mapEntity.CPUId);
	}
}
