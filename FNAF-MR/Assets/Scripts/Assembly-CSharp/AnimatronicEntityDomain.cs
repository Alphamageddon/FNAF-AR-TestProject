using System.Collections.Generic;
using UnityEngine;

public class AnimatronicEntityDomain
{
	public const int DEFAULT_PERIOD_FALLBACK = 30;

	private AnimatronicEntityConfig _animatronicEntityConfig;

	private ServerDomain _serverDomain;

	private ItemDefinitionDomain _itemDefinitionDomain;

	private SceneLookupTableAccess _sceneLookupTableAccess;

	private EventExposer _eventExposer;

	private bool _showPreencounterStats;

	private bool _realSpawns;

	private float _scavengePeriod;

	public AnimatronicEntityConfig AnimatronicEntityConfig => _animatronicEntityConfig;

	public ServerDomain serverDomain => _serverDomain;

	public EventExposer eventExposer => _eventExposer;

	public Creator creator { get; set; }

	public Container container { get; set; }

	public StateChooser stateChooser { get; set; }

	public AnimatronicEntityUpdater animatronicEntityUpdater { get; set; }

	public bool ForceMalfunction { get; set; }

	public float ScavengePeriod { get; }

	public AnimatronicEntityDomain(EventExposer exposer, MasterDataDomain masterDataDomain)
	{
		_scavengePeriod = 30f;
		_eventExposer = exposer;
	}

	public void Setup(SceneLookupTableAccess sceneLookupTableAccess, AnimatronicEntityConfig animatronicEntityConfig, ItemDefinitionDomain itemDefinitionDomain, ServerDomain serverDomain)
	{
		Debug.Log("entity domain setup called");
		_serverDomain = serverDomain;
		_animatronicEntityConfig = animatronicEntityConfig;
		_itemDefinitionDomain = itemDefinitionDomain;
		_sceneLookupTableAccess = sceneLookupTableAccess;
		_realSpawns = true;
		CreateSubclasses(itemDefinitionDomain);
		CompleteSetup();
	}

	public void Teardown()
	{
		_eventExposer.remove_AnimatronicEncounterStarted(OnAnimatronicEncounterStarted);
		_eventExposer.remove_AnimatronicScavengingEncounterStarted(OnAnimatronicScavengingEncounterStarted);
		_eventExposer = null;
		container.Clear();
		container = null;
		animatronicEntityUpdater.Teardown();
		creator = null;
		animatronicEntityUpdater = null;
	}

	private void CreateSubclasses(ItemDefinitionDomain itemDefinitionDomain)
	{
		creator = new Creator(this, itemDefinitionDomain);
		container = new Container();
		stateChooser = new StateChooser(this);
		animatronicEntityUpdater = new AnimatronicEntityUpdater(this);
		stateChooser.Init();
	}

	private void CompleteSetup()
	{
		_eventExposer.add_AnimatronicEncounterStarted(OnAnimatronicEncounterStarted);
		_eventExposer.add_AnimatronicScavengingEncounterStarted(OnAnimatronicScavengingEncounterStarted);
		container.OnEntityAddedEvent += _eventExposer.OnEntityAddedEvent;
		container.OnEntityRemovedEvent += _eventExposer.OnEntityRemovedEvent;
		container.OnEntitiesClearedEvent += _eventExposer.OnEntitiesClearedEvent;
	}

	public void Update()
	{
		animatronicEntityUpdater.UpdateEntities(Time.deltaTime);
	}

	public void HandleApplicationPause(bool paused)
	{
		if (animatronicEntityUpdater != null)
		{
			animatronicEntityUpdater.HandleApplicationPause(paused);
		}
	}

	public void HandleApplicationFocus(bool hasFocus)
	{
		if (animatronicEntityUpdater != null)
		{
			animatronicEntityUpdater.HandleApplicationFocus(hasFocus);
		}
	}

	public void HandleApplicationQuit()
	{
		if (animatronicEntityUpdater != null)
		{
			animatronicEntityUpdater.HandleApplicationQuit();
		}
	}

	private void OnEntitySent(string id)
	{
		creator.CreateFakeEntityToSend(id);
	}

	private void OnEntityUpdated()
	{
		Debug.LogWarning("Trying to update an entity that doesn't exist");
	}

	private void OnScavengeRecallReceived(List<string> entityIdList)
	{
		foreach (string entityId in entityIdList)
		{
			_ = entityId;
			AnimatronicEntity entity = container.GetEntity(entityIdList[0]);
			if (entity == null)
			{
				Debug.LogWarning("Trying to update an entity that doesn't exist");
			}
			else
			{
				SetRecall(entity);
			}
		}
	}

	private void SetRecall(AnimatronicEntity entity)
	{
		entity.stateData.animatronicState = StateData.AnimatronicState.Recall;
		entity.StateChangedByServer();
	}

	private void OnAnimatronicEncounterStarted(MapEntity mapEntity)
	{
		Debug.Log("AnimatronicEntityDomain has received AnimatronicEncounterStarted - Start button pressed.");
		_eventExposer.OnStartAttackEncounter(new Encounter(_eventExposer));
		Debug.LogError("TELLING CREATOR TO ADD ENTITIES USING MAP ENTITY");
		List<AnimatronicEntity> entities = creator.CreateLocalAnimatronicEntitiesForMapEntity(mapEntity);
		Debug.LogError("ADDING ENTITIES TO CONTAINER");
		container.AddEntities(entities);
		Debug.LogError("SWITCHING SCENE");
		_eventExposer.OnMapEntityHasSpawnedAnimatronics(entities);
	}

	private void OnAnimatronicScavengingEncounterStarted(ScavengingEntity scavengingEntity)
	{
		Debug.Log("AnimatronicEntityDomain has received AnimatronicScavengingEncounterStarted - Start button pressed.");
		_eventExposer.OnStartAttackScavengingEncounter(new ScavengingEncounter(_eventExposer));
		Debug.LogError("TELLING CREATOR TO ADD SCAVENGING ENTITIES USING MAP ENTITY");
		AnimatronicEntity entity = creator.CreateLocalAnimatronicEntityForScavengingEntity(scavengingEntity);
		Debug.LogError("ADDING ENTITY TO CONTAINER");
		container.AddEntity(entity);
		Debug.LogError("SWITCHING SCENE");
	}
}
