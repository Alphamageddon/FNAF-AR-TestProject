using System;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpawner
{
	private EventExposer _masterEventExposer;

	private AnimatronicEntityDomain _animatronicEntityDomain;

	private Animatronic3DDomain _animatronic3DDomain;

	private ItemDefinitions _itemDefinitions;

	private AttackAnimatronicExternalSystems _systems;

	private readonly Queue<AnimatronicEntity> _waitingSpawns;

	private List<AnimatronicEntity> _spawningEntities;

	private List<CreationRequest> _creationRequests;

	private bool _gameReadyForAnimatronics = true;

	public event Action<AttackAnimatronic> OnAnimatronicSpawned;

	private void AttackAnimatronicContainerEmpty()
	{
		TryToSpawn();
	}

	private void GameReadyForAnimatronics()
	{
		_gameReadyForAnimatronics = true;
		TryToSpawn();
	}

	private void EntityFastForwardComplete(FastForwardCompleteArgs args)
	{
		SpawnIfClose(_animatronicEntityDomain.container.AnimatronicEntities);
	}

	private void EntityAddedEvent(Container.EntityAddedRemovedArgs args)
	{
		Debug.LogError("SPAWNER HAS RECEIVED ENTITY ADDED EVENT");
		SpawnIfClose(args.Entities);
	}

	private void EntityStateChangedEvent(StateChooser.EntityStateChangedArgs args)
	{
		SpawnIfClose(args.entity);
	}

	private bool EntityIdIsDuplicate(AnimatronicEntity entity)
	{
		if (_systems.Encounter.GetEntityId() == entity.entityId)
		{
			return true;
		}
		if (_spawningEntities.Contains(entity))
		{
			return true;
		}
		return _waitingSpawns.Contains(entity);
	}

	private void SpawnIfClose(AnimatronicEntity entity)
	{
		if (!EntityIdIsDuplicate(entity))
		{
			Debug.LogError("SPAWNER VERIFIED ENTITY IS NOT DUPLICATE. QUEUEING TO WAITING SPAWNS");
			_waitingSpawns.Enqueue(entity);
			TryToSpawn();
		}
	}

	private void SpawnIfClose(IEnumerable<AnimatronicEntity> entities)
	{
		foreach (AnimatronicEntity entity in entities)
		{
			if (!EntityIdIsDuplicate(entity) && entity.stateData.animatronicState == StateData.AnimatronicState.NearPlayer)
			{
				Debug.LogError("SPAWNER VERIFIED ENTITY IS NOT DUPLICATE. QUEUEING TO WAITING SPAWNS");
				_waitingSpawns.Enqueue(entity);
			}
		}
		Debug.LogError("SPAWNER ATTEMPTING TRYTOSPAWN()");
		TryToSpawn();
	}

	private void TryToSpawn()
	{
		if (!_gameReadyForAnimatronics)
		{
			Debug.LogError("SPAWNER THINKS GAME NOT READY FOR ANIMATRONICS");
			return;
		}
		if (_spawningEntities.Count > 0)
		{
			Debug.LogError("SPAWNER THINKS ALREADY SPAWNING");
			return;
		}
		if (_waitingSpawns.Count == 0)
		{
			Debug.LogError("SPAWNER THINKS NO WAITING SPAWNS");
			return;
		}
		if (_systems.Encounter.IsInProgress())
		{
			Debug.LogError("SPAWNER THINKS ENCOUNTER IN PROCESS");
			return;
		}
		Debug.LogError("SPAWNER CREATING CREATION REQUESTS!");
		int count = _waitingSpawns.Count;
		for (int i = 0; i < count; i++)
		{
			_creationRequests.Add(CreateSpawnRequest());
		}
		Debug.LogError("SPAWNER CREATING ANIMATRONIC 3DS FOR REQUESTS!");
		foreach (CreationRequest item in new List<CreationRequest>(_creationRequests))
		{
			_animatronic3DDomain.CreateAnimatronic3D(item);
		}
		CreationRequest CreateSpawnRequest()
		{
			AnimatronicEntity animatronicEntity = _waitingSpawns.Dequeue();
			_spawningEntities.Add(animatronicEntity);
			CreationRequest creationRequest = new CreationRequest(animatronicEntity, null);
			creationRequest.OnRequestComplete += LoadComplete;
			return creationRequest;
		}
	}

	private void LoadComplete(CreationRequest result)
	{
		List<AnimatronicEntity> entities = new List<AnimatronicEntity>();
		List<Animatronic3D> animatronics3D = new List<Animatronic3D>();
		List<AttackProfile> attackProfiles = new List<AttackProfile>();
		ScavengingAttackProfile scavengingAttackProfile = null;
		List<AnimatronicState> animatronicStates = new List<AnimatronicState>();
		if (IsRequestValid(result) && AllCreationRequestsCompleted())
		{
			SetUpAttackAnimatronicArguments();
			if (result.Entity.AttackSequenceData.encounterStartTime == 0L)
			{
				result.Entity.AttackSequenceData.encounterStartTime = ServerTime.GetCurrentTime();
			}
			_spawningEntities.Clear();
			_creationRequests.Clear();
			if (this.OnAnimatronicSpawned != null)
			{
				Debug.Log("making animatronic! systems are null? " + (_systems == null) + " - camera stable transform is null? " + (_systems.CameraStableTransform == null));
				this.OnAnimatronicSpawned(new AttackAnimatronic(_masterEventExposer, _systems, entities, animatronics3D, attackProfiles, scavengingAttackProfile, animatronicStates, result.Entity.isScavenging, result.Entity.scavengingData));
			}
		}
		bool AllCreationRequestsCompleted()
		{
			foreach (CreationRequest creationRequest in _creationRequests)
			{
				if (!creationRequest.IsComplete)
				{
					return false;
				}
			}
			return true;
		}
		bool IsRequestValid(CreationRequest request)
		{
			if (request.Animatronic3D == null)
			{
				string text = "Animatronic3D failed to load for " + request.Entity.entityId + ". Cannot spawn AttackAnimatronic";
				Debug.LogError("AttackSpawner LoadComplete - " + text);
				return false;
			}
			if (!_creationRequests.Contains(request))
			{
				string text2 = "Animatronic3D for " + request.Entity.entityId + " loaded, but was not requested";
				Debug.LogError("AttackSpawner LoadComplete - " + text2);
				return false;
			}
			if (!_spawningEntities.Contains(request.Entity))
			{
				LogEntityIdMismatch(request.Entity.entityId);
				return false;
			}
			return true;
		}
		static void LogEntityIdMismatch(string entityId)
		{
			Debug.Log("AttackSpawner LoadComplete - Animatronic3D for " + entityId + " loaded, but does not match ");
		}
		void SetUpAttackAnimatronicArguments()
		{
			foreach (CreationRequest creationRequest2 in _creationRequests)
			{
				entities.Add(creationRequest2.Entity);
				animatronics3D.Add(creationRequest2.Animatronic3D);
				Dictionary<string, float> modifiersForAttackProfile = _itemDefinitions.GetModifiersForAttackProfile(creationRequest2.Entity.endoskeletonData, creationRequest2.Entity.wearAndTear);
				AttackProfile attackProfile = _itemDefinitions.GetAttackProfile(creationRequest2.ConfigData.CpuData.AttackProfile);
				attackProfiles.Add(ApplyModsToAttackProfile(attackProfile, modifiersForAttackProfile));
				ScavengingAttackProfile scavengingAttackProfile2 = _itemDefinitions.GetScavengingAttackProfile(creationRequest2.ConfigData.CpuData.ScavengingAttackProfile);
				scavengingAttackProfile = scavengingAttackProfile2;
				animatronicStates.Add(new AnimatronicState(creationRequest2.ConfigData));
			}
		}
	}

	private void AddRemnantShockWindowModifier(Dictionary<string, float> mods)
	{
	}

	private AttackProfile ApplyModsToAttackProfile(AttackProfile attackProfile, Dictionary<string, float> modEffects)
	{
		return new AttackProfile(attackProfile, modEffects);
	}

	public AttackSpawner(EventExposer masterEventExposer, AnimatronicEntityDomain animatronicEntityDomain, Animatronic3DDomain animatronic3DDomain, ItemDefinitionDomain itemDefinitionDomain)
	{
		_waitingSpawns = new Queue<AnimatronicEntity>();
		_spawningEntities = new List<AnimatronicEntity>();
		_creationRequests = new List<CreationRequest>();
		_masterEventExposer = masterEventExposer;
		_animatronicEntityDomain = animatronicEntityDomain;
		Animatronic3DDomainReady(animatronic3DDomain);
		ItemDefinitionDomainReady(itemDefinitionDomain);
		_masterEventExposer.add_AttackEncounterEnded(AttackAnimatronicContainerEmpty);
		_masterEventExposer.add_AttackScavengingEncounterEnded(AttackAnimatronicContainerEmpty);
	}

	private void Animatronic3DDomainReady(Animatronic3DDomain animatronic3DDomain)
	{
		_animatronic3DDomain = animatronic3DDomain;
	}

	private void ItemDefinitionDomainReady(ItemDefinitionDomain itemDefinitionDomain)
	{
		_itemDefinitions = itemDefinitionDomain.ItemDefinitions;
	}

	public void InitialSetup(AttackAnimatronicExternalSystems systems)
	{
		_systems = systems;
		_masterEventExposer.add_EntityFastForwardComplete(EntityFastForwardComplete);
		_masterEventExposer.add_EntityAddedEvent(EntityAddedEvent);
	}

	public void Setup(AttackAnimatronicExternalSystems systems)
	{
		_systems = systems;
		Debug.Log("received systems, camera stable transform is null? " + (_systems.CameraStableTransform == null));
	}

	public void Teardown()
	{
		_masterEventExposer.remove_EntityAddedEvent(EntityAddedEvent);
		_masterEventExposer.remove_EntityFastForwardComplete(EntityFastForwardComplete);
		_masterEventExposer.remove_AttackEncounterEnded(AttackAnimatronicContainerEmpty);
		_masterEventExposer.remove_AttackScavengingEncounterEnded(AttackAnimatronicContainerEmpty);
		_systems = null;
		_spawningEntities.Clear();
		_spawningEntities = null;
		_waitingSpawns.Clear();
		_masterEventExposer = null;
	}
}
