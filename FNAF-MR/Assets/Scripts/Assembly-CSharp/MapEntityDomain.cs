using System.Collections.Generic;
using UnityEngine;

public class MapEntityDomain
{
	private EventExposer _eventExposer;

	private ServerDomain _serverDomain;

	private ItemDefinitions _itemDefinitions;

	private MapEntityBuilder _builder;

	private Dictionary<string, MapEntity> _entities;

	private IEnumerable<MapEntitySynchronizeableState> _mapEntityServerStates;

	private bool _readyToPopulateEntities;

	private MapEntityLifecycleRegulator _lifecycleRegulator;

	private MasterDataConnector _masterDataConnector;

	private MapEntityInteractionMutex _interactionMutex;

	private CONFIG_DATA.MapEntities _mapEntityConfig;

	protected bool IsReady => true;

	public MapEntityBuilder Builder => _builder;

	private void ReloadLookupTableForEntities()
	{
	}

	private void EventExposer_MapEntitiesReceivedFromServer(IEnumerable<MapEntitySynchronizeableState> entityServerStates)
	{
		_mapEntityServerStates = entityServerStates;
		if (_readyToPopulateEntities)
		{
			ProcessNewEntityServerStates(entityServerStates);
		}
	}

	private void EventExposer_MapEntityInteractionFinished(MapEntity entity, bool giveRewards)
	{
		if (entity.SynchronizeOnServer)
		{
			_serverDomain.mapEntityInteractionFinishedRequester.FinishInteraction(entity.SynchronizeableState.entityId, giveRewards);
		}
		_entities.Remove(entity.SynchronizeableState.entityId);
		_lifecycleRegulator.DispatchValidEntityModelState();
	}

	private void EventExposer_MapEntityScanned(MapEntity entity)
	{
		if (entity.SynchronizeableState.revealedBy == RevealedBy.None)
		{
			_lifecycleRegulator.AddClientsideScan(entity);
		}
		entity.SynchronizeableState.revealedBy = RevealedBy.Scanner;
	}

	private void ConfigDataReady(CONFIG_DATA.Root config)
	{
		_mapEntityConfig = config.Entries[0].MapEntities;
		_lifecycleRegulator = new MapEntityLifecycleRegulator(_eventExposer, _entities);
		_lifecycleRegulator.Setup(_serverDomain, _mapEntityConfig);
		OnLoadingFinished();
	}

	public MapEntityDomain(EventExposer eventExposer, MasterDataDomain masterDataDomain)
	{
		_eventExposer = eventExposer;
		_builder = null;
		_lifecycleRegulator = null;
		_entities = new Dictionary<string, MapEntity>();
		_mapEntityServerStates = null;
		_readyToPopulateEntities = false;
		masterDataDomain.GetAccessToData.GetConfigDataEntryAsync(ConfigDataReady);
		_interactionMutex = new MapEntityInteractionMutex();
		_interactionMutex.Setup(eventExposer);
	}

	public void Setup(ServerDomain serverDomain, ItemDefinitions itemDefinitions)
	{
		_serverDomain = serverDomain;
		_itemDefinitions = itemDefinitions;
		_eventExposer.add_MapEntitiesReceivedFromServer(EventExposer_MapEntitiesReceivedFromServer);
		_eventExposer.add_MapEntityInteractionFinished(EventExposer_MapEntityInteractionFinished);
		_eventExposer.add_MapEntityScanned(EventExposer_MapEntityScanned);
		_builder = new MapEntityBuilder(_eventExposer, _serverDomain);
	}

	private void OnLoadingFinished()
	{
		_builder.Setup(_mapEntityConfig, _itemDefinitions, _interactionMutex);
		PopulateEntities();
	}

	private void PopulateEntities()
	{
		_readyToPopulateEntities = true;
		if (_mapEntityServerStates != null)
		{
			ProcessNewEntityServerStates(_mapEntityServerStates);
		}
	}

	public void Teardown()
	{
		if (_lifecycleRegulator != null)
		{
			_lifecycleRegulator.Teardown();
		}
		_lifecycleRegulator = null;
		if (_interactionMutex != null)
		{
			_interactionMutex.Teardown();
		}
		_interactionMutex = null;
		_eventExposer.remove_MapEntityInteractionFinished(EventExposer_MapEntityInteractionFinished);
		_eventExposer.remove_MapEntitiesReceivedFromServer(EventExposer_MapEntitiesReceivedFromServer);
		_eventExposer.remove_MapEntityScanned(EventExposer_MapEntityScanned);
		_mapEntityServerStates = null;
		_entities.Clear();
		_masterDataConnector = null;
		_eventExposer = null;
		_builder = null;
		_entities = null;
	}

	public void AddClientOnlyEntity(MapEntity entity)
	{
	}

	public bool TryGetEntity(string key, out MapEntity result)
	{
		return _entities.TryGetValue(key, out result);
	}

	private void ProcessNewEntityServerStates(IEnumerable<MapEntitySynchronizeableState> entityServerStates)
	{
		foreach (string item in CollectServerOnlyEntityKeys())
		{
			_entities.Remove(item);
		}
		foreach (MapEntitySynchronizeableState entityServerState in entityServerStates)
		{
			if (!entityServerState.entityId.ToLower().Contains("shadowbonnie"))
			{
				ProcessServerUpdateForEntityId(entityServerState);
			}
		}
		Debug.Log("new entities! total: " + _entities.Values.Count);
		RequestNewModels();
	}

	public void RequestNewModels()
	{
		_lifecycleRegulator.DispatchValidEntityModelState();
	}

	private void ProcessNewEntitiesClientOnly()
	{
	}

	private void ProcessServerUpdateForEntityId(MapEntitySynchronizeableState synchronizeableState)
	{
		if (!_entities.ContainsKey(synchronizeableState.entityId))
		{
			_entities[synchronizeableState.entityId] = _builder.CreateEntityFromState(synchronizeableState);
		}
		else
		{
			_entities[synchronizeableState.entityId].SynchronizeableState = synchronizeableState;
		}
	}

	private HashSet<string> CollectServerOnlyEntityKeys()
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string key in _entities.Keys)
		{
			if (_entities[key].SynchronizeOnServer)
			{
				hashSet.Add(key);
			}
		}
		return hashSet;
	}
}
