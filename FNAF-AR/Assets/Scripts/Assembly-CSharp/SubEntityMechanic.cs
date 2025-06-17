using System.Collections.Generic;
using UnityEngine;

public class SubEntityMechanic
{
	private EventExposer eventExposer;

	private AttackAnimatronicExternalSystems _systems;

	private ModifiedGlitchShader glitch;

	private AttackProfile originalProfile;

	private bool inEncounter;

	private Blackboard _blackboard;

	private Dictionary<string, SubEntityMover> subEntityMovers;

	private List<GameObject> _spawnedPrefabs = new List<GameObject>();

	public SubEntityMechanic(EventExposer masterEventExposer)
	{
		eventExposer = masterEventExposer;
		originalProfile = null;
		subEntityMovers = new Dictionary<string, SubEntityMover>();
	}

	public void Setup(AttackAnimatronicExternalSystems sys, ModifiedGlitchShader glitchShader)
	{
		_systems = sys;
		glitch = glitchShader;
	}

	public void Update()
	{
		if (!inEncounter)
		{
			return;
		}
		foreach (SubEntityMover value in subEntityMovers.Values)
		{
			value.Update();
		}
	}

	public void StartSystem(Blackboard blackboard)
	{
		_blackboard = blackboard;
		originalProfile = new AttackProfile(blackboard.AttackProfile);
		if (originalProfile.SubEntityData == null || originalProfile.SubEntityData.Count <= 0)
		{
			Debug.Log("No sub entities.");
			return;
		}
		foreach (SubEntityData subEntityDatum in originalProfile.SubEntityData)
		{
			CreateSubEntity(subEntityDatum);
		}
		inEncounter = true;
	}

	public void CreateSubEntity(SubEntityData data)
	{
		if (subEntityMovers.ContainsKey(data.Logical))
		{
			Debug.LogError("Duplicate Sub Entity!!!! " + data.Logical);
			return;
		}
		SubEntityCreationRequest subEntityCreationRequest = new SubEntityCreationRequest(data.Bundle, data.Asset, data);
		subEntityCreationRequest.add_OnRequestComplete(ArtAssetsLoaded);
		MasterDomain.GetDomain().GameAssetManagementDomain.CreateSubEntity(subEntityCreationRequest);
	}

	private void ArtAssetsLoaded(SubEntityCreationRequest req)
	{
		if (!(req.SpawnedObject == null) && !req.IsCancelled())
		{
			if (subEntityMovers.ContainsKey(req.Data.Logical))
			{
				Debug.LogError("Duplicate Sub Entity!!!! " + req.Data.Logical);
				return;
			}
			SubEntityMover subEntityMover = new SubEntityMover();
			subEntityMover.Setup(_systems.CameraStableTransform, req.SpawnedObject, req.Data, _blackboard, originalProfile, glitch);
			subEntityMovers.Add(req.Data.Logical, subEntityMover);
			_spawnedPrefabs.Add(req.SpawnedObject);
		}
	}

	public void StopSystem()
	{
		inEncounter = false;
		foreach (SubEntityMover value in subEntityMovers.Values)
		{
			value.TearDown();
		}
		subEntityMovers.Clear();
		if (_spawnedPrefabs != null && _spawnedPrefabs.Count > 0)
		{
			foreach (GameObject spawnedPrefab in _spawnedPrefabs)
			{
				Object.Destroy(spawnedPrefab);
			}
		}
		_spawnedPrefabs.Clear();
	}

	public void TearDown()
	{
		StopSystem();
		_systems = null;
		_blackboard = null;
		originalProfile = null;
		eventExposer = null;
		_spawnedPrefabs = null;
		subEntityMovers = null;
	}
}
