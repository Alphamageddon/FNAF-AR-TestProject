using System.Collections.Generic;
using UnityEngine;

public class Creator
{
	private const int MAX_WEAR_AND_TEAR = 100;

	private const string GOLDEN_FREDDY_CPU_ID = "GoldenFreddy";

	private AnimatronicEntityDomain _animatronicEntityDomain;

	private ItemDefinitions _itemDefinitions;

	public Creator(AnimatronicEntityDomain animatronicEntityDomain, ItemDefinitionDomain itemDefinitionDomain)
	{
		_animatronicEntityDomain = animatronicEntityDomain;
		ItemDefinitionDomainReady(itemDefinitionDomain);
	}

	private void ItemDefinitionDomainReady(ItemDefinitionDomain itemDefinitionDomain)
	{
		_itemDefinitions = itemDefinitionDomain.ItemDefinitions;
	}

	public AnimatronicEntity CreateEntity(SaveGameChunk saveGameChunk)
	{
		CPUData cPUById = _itemDefinitions.GetCPUById(saveGameChunk.endoskeletonData.cpu);
		PlushSuitData plushSuitById = _itemDefinitions.GetPlushSuitById(saveGameChunk.endoskeletonData.plushSuit);
		AttackProfile attackProfile = _itemDefinitions.GetAttackProfile(cPUById.AttackProfile);
		return CreateEntity(saveGameChunk.entityId, saveGameChunk.stateData, saveGameChunk.originData, new AnimatronicConfigData(cPUById, plushSuitById, attackProfile), saveGameChunk.AttackSequenceData, saveGameChunk.endoskeletonData, saveGameChunk.wearAndTear, saveGameChunk.rewardDataV3);
	}

	public AnimatronicEntity CreateEntity(string entityId, StateData stateData, OriginData originData, AnimatronicConfigData animatronicConfigData, AttackSequenceData attackSequenceData, EndoskeletonData endoskeletonData, int wearAndTear, RewardDataV3 rewardDataV3)
	{
		return new AnimatronicEntity(_animatronicEntityDomain, entityId, stateData, originData, animatronicConfigData, attackSequenceData, endoskeletonData, wearAndTear, rewardDataV3);
	}

	public List<AnimatronicEntity> CreateLocalAnimatronicEntitiesForMapEntity(MapEntity mapEntity)
	{
		List<AnimatronicEntity> list = null;
		list = new List<AnimatronicEntity>();
		mapEntity.SynchronizeableState.parts.TryGetValue("Cpu", out var value);
		mapEntity.SynchronizeableState.parts.TryGetValue("PlushSuit", out var value2);
		string[] cpuIds = GetCpuIds(_itemDefinitions.GetCPUById(value));
		string[] plushSuitIds = GetPlushSuitIds(_itemDefinitions.GetCPUById(value), value2);
		for (int i = 0; i < cpuIds.Length; i++)
		{
			list.Add(CreateLocalAnimatronicEntityForMapEntity(mapEntity, cpuIds[i], plushSuitIds[i], mapEntity.SynchronizeableState.parts, GetDurabilities(cpuIds, mapEntity.SynchronizeableState.durability)[i], GetAttacks(cpuIds, mapEntity.SynchronizeableState.attack)[i]));
		}
		return list;
	}

	private AnimatronicEntity CreateLocalAnimatronicEntityForMapEntity(MapEntity mapEntity, string entityCpuId, string plushsuitId, Dictionary<string, string> entityParts, int durability, int attack)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < 4; i++)
		{
			if (entityParts.TryGetValue($"mod{i}", out var value))
			{
				list.Add(value);
			}
		}
		CPUData cPUById = _itemDefinitions.GetCPUById(entityCpuId);
		PlushSuitData plushSuitById = _itemDefinitions.GetPlushSuitById(plushsuitId);
		EndoskeletonData endoskeletonData = new EndoskeletonData
		{
			cpu = entityCpuId,
			plushSuit = plushsuitId,
			mods = list
		};
		RewardDataV3 rewardDataV = mapEntity.SynchronizeableState.rewards;
		if (rewardDataV == null)
		{
			rewardDataV = new RewardDataV3();
		}
		return new AnimatronicEntity(_animatronicEntityDomain, mapEntity.EntityId, new StateData(StateData.AnimatronicState.NearPlayer, expressDelivery: false), new OriginData(OriginData.OriginState.MapEntitySystem), new AnimatronicConfigData(cPUById, plushSuitById, null, durability, attack), new AttackSequenceData(attackSequenceComplete: false, 0L), endoskeletonData, 100, rewardDataV);
	}

	public AnimatronicEntity CreateLocalAnimatronicEntityForScavengingEntity(ScavengingEntity scavengingEntity)
	{
		scavengingEntity.SynchronizeableState.parts.TryGetValue("Cpu", out var value);
		scavengingEntity.SynchronizeableState.parts.TryGetValue("PlushSuit", out var value2);
		CPUData cPUById = _itemDefinitions.GetCPUById(value);
		PlushSuitData plushSuitById = _itemDefinitions.GetPlushSuitById(value2);
		EndoskeletonData endoskeletonData = new EndoskeletonData
		{
			cpu = value,
			plushSuit = value2,
			mods = new List<string>()
		};
		ScavengingData scavengingLevelById = _itemDefinitions.GetScavengingLevelById(scavengingEntity.SynchronizeableState.environment);
		return new AnimatronicEntity(_animatronicEntityDomain, scavengingEntity.EntityId, new StateData(StateData.AnimatronicState.NearPlayer, expressDelivery: false), new OriginData(OriginData.OriginState.MapEntitySystem), new AnimatronicConfigData(cPUById, plushSuitById, null), new AttackSequenceData(attackSequenceComplete: false, 0L), endoskeletonData, 100, new RewardDataV3(), isScavenging: true, scavengingLevelById);
	}

	private string[] GetCpuIds(CPUData cpuData)
	{
		if (cpuData.MultiAnimatronicConfig != null && cpuData.MultiAnimatronicConfig.SelectionType != SelectionType.None)
		{
			return cpuData.MultiAnimatronicConfig.GenerateCpuIds();
		}
		if (string.IsNullOrEmpty(cpuData.Id) || cpuData.Id != "GoldenFreddy")
		{
			if (cpuData.Id == "GreatEscapeGoldenFreddySkin")
			{
				return RollGreatEscapeCpuIds();
			}
			return new string[1] { cpuData.Id };
		}
		return RollGoldenFreddyCpuIds(new string[5] { "GoldenFreddy_FreddyFazbear", "GoldenFreddy_ToyFreddy", "GoldenFreddy_Mangle", "GoldenFreddy_Springtrap", "GoldenFreddy_Ballora" }, 3);
	}

	private string[] RollGreatEscapeCpuIds()
	{
		return RollGoldenFreddyCpuIds(new string[5] { "GreatEscapeGoldenFreddySkin_FreddyFazbear", "GreatEscapeGoldenFreddySkin_ToyFreddy", "GreatEscapeGoldenFreddySkin_Springtrap", "GreatEscapeGoldenFreddySkin_Ballora", "GreatEscapeGoldenFreddySkin_Mangle" }, 3);
	}

	private string[] RollGoldenFreddyCpuIds(string[] goldenFreddyCpuIds, int cpuCount)
	{
		List<string> list = new List<string>(goldenFreddyCpuIds);
		List<string> list2 = new List<string>();
		while (list.Count >= 1 && list2.Count < cpuCount)
		{
			int index = Random.Range(0, list.Count);
			list2.Add(list[index]);
			list.RemoveAt(index);
		}
		return list2.ToArray();
	}

	private string[] GetPlushSuitIds(CPUData cpuData, string plushSuit)
	{
		if (cpuData.MultiAnimatronicConfig != null && cpuData.MultiAnimatronicConfig.SelectionType != SelectionType.None)
		{
			return cpuData.MultiAnimatronicConfig.GeneratePlushsuitIds(plushSuit);
		}
		if (string.IsNullOrEmpty(cpuData.Id))
		{
			return new string[1] { plushSuit };
		}
		if (cpuData.Id != "GoldenFreddy" && cpuData.Id != "GreatEscapeGoldenFreddySkin")
		{
			return new string[1] { plushSuit };
		}
		List<string> list = new List<string>();
		for (int i = 0; i < 3; i++)
		{
			list.Add(plushSuit);
		}
		return list.ToArray();
	}

	private int[] GetDurabilities(string[] cpuIds, int synchronizeableStateDurability)
	{
		int[] array = new int[cpuIds.Length];
		if (cpuIds.Length < 1)
		{
			return array;
		}
		for (int i = 0; i < cpuIds.Length; i++)
		{
			array[i] = 0;
		}
		return array;
	}

	private int[] GetAttacks(string[] cpuIds, int synchronizeableStateAttack)
	{
		int[] array = new int[cpuIds.Length];
		if (cpuIds.Length < 1)
		{
			return array;
		}
		for (int i = 0; i < cpuIds.Length; i++)
		{
			array[i] = 0;
		}
		return array;
	}

	public void CreateFakeEntityToSend(string id)
	{
		CPUData cPUById = _itemDefinitions.GetCPUById(id);
		PlushSuitData plushSuitById = _itemDefinitions.GetPlushSuitById(id);
		AnimatronicEntity animatronicEntity = new AnimatronicEntity(id, _animatronicEntityDomain, cPUById, plushSuitById, OriginData.OriginState.Sent);
		animatronicEntity.InitDataForSent();
		_animatronicEntityDomain.container.AddFakeEntity(animatronicEntity);
	}

	public List<AnimatronicEntity> CreateLocalAnimatronicEntity(string cpuId, string plushsuitId)
	{
		List<AnimatronicEntity> list = new List<AnimatronicEntity>();
		string[] cpuIds = GetCpuIds(_itemDefinitions.GetCPUById(cpuId));
		foreach (string id in cpuIds)
		{
			CPUData cPUById = _itemDefinitions.GetCPUById(id);
			PlushSuitData plushSuitById = _itemDefinitions.GetPlushSuitById(plushsuitId);
			AnimatronicEntity animatronicEntity = new AnimatronicEntity(id, _animatronicEntityDomain, cPUById, plushSuitById, OriginData.OriginState.MapEntitySystem);
			animatronicEntity.stateData.animatronicState = StateData.AnimatronicState.NearPlayer;
			list.Add(animatronicEntity);
		}
		return list;
	}
}
