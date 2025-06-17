using System.Collections.Generic;
using UnityEngine;

public class MapEntityBuilder
{
	private readonly EventExposer _events;

	private readonly ServerDomain _serverDomain;

	private CONFIG_DATA.MapEntities _mapEntityConfig;

	private ItemDefinitions _itemDefinitions;

	private MapEntityInteractionMutex _interactionMutex;

	public MapEntityBuilder(EventExposer events, ServerDomain serverDomain)
	{
		_events = events;
		_serverDomain = serverDomain;
	}

	public void Setup(CONFIG_DATA.MapEntities mapEntityConfig, ItemDefinitions itemDefinitions, MapEntityInteractionMutex interactionMutex)
	{
		_mapEntityConfig = mapEntityConfig;
		_itemDefinitions = itemDefinitions;
		_interactionMutex = interactionMutex;
	}

	public MapEntity CreateEntityFromState(MapEntitySynchronizeableState synchronizeableState)
	{
		return new MapEntity(synchronizeableState, synchronizeOnServer: true, GenerateInteractionControllerForServerState(synchronizeableState))
		{
			LocalSpawnTime = Time.time,
			LocalRemoveTime = Time.time + (float)synchronizeableState.onScreenDuration
		};
	}

	public void UpdateExistingEntityState(MapEntity entity, MapEntitySynchronizeableState synchronizeableState)
	{
		entity.SynchronizeableState = synchronizeableState;
	}

	public MapEntity CreateClientOnlyEntity(MapEntityType entityType, long lifespanInMilliseconds, string cpuId, string plushSuitId)
	{
		MapEntityHistory mapEntityHistory = new MapEntityHistory();
		mapEntityHistory.owner = "";
		if (cpuId == null || plushSuitId == null)
		{
			return null;
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("Cpu", cpuId);
		dictionary.Add("PlushSuit", plushSuitId);
		CPUData cPUById = _itemDefinitions.GetCPUById(cpuId);
		MapEntitySynchronizeableState mapEntitySynchronizeableState = new MapEntitySynchronizeableState();
		mapEntitySynchronizeableState.entityId = $"{cPUById.Id.ToString()}_{Time.time}";
		mapEntitySynchronizeableState.entityClass = entityType;
		mapEntitySynchronizeableState.spawnTimeStamp = 0L;
		mapEntitySynchronizeableState.removeTimeStamp = lifespanInMilliseconds;
		mapEntitySynchronizeableState.onScreenDuration = lifespanInMilliseconds;
		mapEntitySynchronizeableState.revealedBy = RevealedBy.Client;
		mapEntitySynchronizeableState.history = mapEntityHistory;
		mapEntitySynchronizeableState.parts = dictionary;
		mapEntitySynchronizeableState.legacyEssence = 0;
		mapEntitySynchronizeableState.remnantSpawnWeights = new Dictionary<string, float>();
		mapEntitySynchronizeableState.lootStructureId = null;
		mapEntitySynchronizeableState.aggression = Random.Range(cPUById.Aggression.Min, cPUById.Aggression.Max + 1);
		mapEntitySynchronizeableState.perception = Random.Range(cPUById.Perception.Min, cPUById.Perception.Max + 1);
		return new MapEntity(mapEntitySynchronizeableState, synchronizeOnServer: false, GenerateInteractionControllerForClientOnly(entityType))
		{
			LocalSpawnTime = Time.time,
			LocalRemoveTime = Time.time + (float)mapEntitySynchronizeableState.onScreenDuration
		};
	}

	private IMapEntityInteraction GenerateInteractionControllerForServerState(MapEntitySynchronizeableState synchronizeableState)
	{
		_ = synchronizeableState.entityClass;
		switch (synchronizeableState.entityClass)
		{
		case MapEntityType.Scavenging:
			return new MapEntityWanderingAnimatronicInteractionController(_events, _interactionMutex);
		case MapEntityType.SpecialDelivery:
			return new MapEntitySpecialDeliveryInteractionController(_events, _interactionMutex);
		default:
			Debug.LogError($"Can't construct interaction controller - Unrecognized entity type {synchronizeableState.entityClass}");
			return null;
		}
	}

	private IMapEntityInteraction GenerateInteractionControllerForClientOnly(MapEntityType entityType)
	{
		_ = 6;
		_ = 5;
		Debug.LogError($"Can't construct client interaction controller - Unrecognized entity type {entityType}");
		return null;
	}
}
