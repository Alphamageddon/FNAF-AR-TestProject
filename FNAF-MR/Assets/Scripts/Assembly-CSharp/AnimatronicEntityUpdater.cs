using System.Collections.Generic;
using UnityEngine;

public class AnimatronicEntityUpdater
{
	private const float MinSaveDelayForPeriodicSaves = 600f;

	private const float MinSaveDelayForOnDemandSaves = 5f;

	private AnimatronicEntityDomain _animatronicEntityDomain;

	private bool _shouldSave;

	private float _lastSave;

	private List<AnimatronicEntity> _scavengers;

	public bool CanAttack { get; set; }

	public AnimatronicEntityUpdater(AnimatronicEntityDomain animatronicEntityDomain)
	{
		CanAttack = true;
		_scavengers = new List<AnimatronicEntity>();
		_animatronicEntityDomain = animatronicEntityDomain;
		animatronicEntityDomain.eventExposer.add_EntityFastForwardComplete(EntityFastForwardComplete);
		animatronicEntityDomain.eventExposer.add_AttackEncounterStarted(AttackEncounterStarted);
		animatronicEntityDomain.eventExposer.add_AttackScavengingEncounterStarted(AttackEncounterStarted);
		animatronicEntityDomain.eventExposer.add_AttackEncounterEnded(AttackEncounterEnded);
		animatronicEntityDomain.eventExposer.add_AttackScavengingEncounterEnded(AttackEncounterEnded);
	}

	private void EntityFastForwardComplete(FastForwardCompleteArgs obj)
	{
		ResetStalkingTimers();
	}

	private void AttackEncounterStarted(EncounterType obj)
	{
		CanAttack = false;
	}

	private void AttackEncounterEnded()
	{
		ResetStalkingTimers();
		CanAttack = true;
	}

	private void ResetStalkingTimers()
	{
		foreach (AnimatronicEntity allEntity in _animatronicEntityDomain.container.GetAllEntities())
		{
			_ = allEntity.stateData.animatronicState;
			_ = 1;
		}
	}

	public void HandleApplicationPause(bool paused)
	{
		if (paused)
		{
			SaveOnDemand();
		}
	}

	public void HandleApplicationFocus(bool hasFocus)
	{
		if (!hasFocus)
		{
			SaveOnDemand();
		}
	}

	public void HandleApplicationQuit()
	{
		SaveOnDemand();
	}

	public void UpdateEntities(float deltaTime)
	{
		ResetCounters();
		_animatronicEntityDomain.stateChooser.Update();
		HandleServerCalls();
	}

	private void ResetCounters()
	{
		_scavengers.Clear();
	}

	private void HandleServerCalls()
	{
		if (_shouldSave)
		{
			CanSave(600f);
		}
		ResetCounters();
	}

	private bool CanSave(float cooldown)
	{
		return Time.time > _lastSave + cooldown;
	}

	public void Teardown()
	{
		_scavengers.Clear();
	}

	public void SaveRequest()
	{
		_shouldSave = true;
	}

	public void SaveOnDemand()
	{
		CanSave(5f);
	}

	public void RequestScavenge(AnimatronicEntity entity)
	{
		_scavengers.Add(entity);
	}
}
