using System;
using System.Collections.Generic;

public class StateChooser
{
	public class EntityStateChangedArgs
	{
		public AnimatronicEntity entity;

		public StateData.AnimatronicState animatronicState;
	}

	private AnimatronicEntityDomain _animatronicEntityDomain;

	private IChooseState[] _states;

	public event Action<EntityStateChangedArgs> EntityStateChangedEvent;

	private void Broker_EntityMovedEvent()
	{
	}

	public StateChooser(AnimatronicEntityDomain animatronicEntityDomain)
	{
		_animatronicEntityDomain = animatronicEntityDomain;
		_states = new IChooseState[16];
	}

	private void UpdateEntityStates()
	{
		foreach (AnimatronicEntity allEntity in _animatronicEntityDomain.container.GetAllEntities())
		{
			UpdateEntityState(allEntity);
		}
	}

	public bool UpdateEntityState(AnimatronicEntity entity)
	{
		if (entity.stateData.animatronicState == StateData.AnimatronicState.Destroy)
		{
			return false;
		}
		if (!entity.LocationInitialized)
		{
			InitDataForState(entity);
			_animatronicEntityDomain.animatronicEntityUpdater.SaveRequest();
		}
		if (ChooseCorrectStateForEntity(entity))
		{
			if (this.EntityStateChangedEvent == null)
			{
				return false;
			}
			EntityStateChangedArgs entityStateChangedArgs = new EntityStateChangedArgs();
			entityStateChangedArgs.entity = entity;
			entityStateChangedArgs.animatronicState = entity.stateData.animatronicState;
			this.EntityStateChangedEvent(entityStateChangedArgs);
			return true;
		}
		return false;
	}

	private void CleanupDestroyed()
	{
		foreach (AnimatronicEntity item in new List<AnimatronicEntity>(_animatronicEntityDomain.container.GetAllEntities()))
		{
			if (item.stateData.animatronicState == StateData.AnimatronicState.Destroy)
			{
				_animatronicEntityDomain.container.RemoveEntity(item);
			}
		}
	}

	public bool ChooseCorrectStateForEntity(AnimatronicEntity entity)
	{
		StateData.AnimatronicState animatronicState = entity.stateData.animatronicState;
		if ((int)animatronicState >= _states.Length)
		{
			return false;
		}
		if (_states[(int)animatronicState] != null && _states[(int)animatronicState].DidChooseNewState(entity))
		{
			entity.StateChanged?.Invoke();
			_animatronicEntityDomain.animatronicEntityUpdater.SaveRequest();
			return true;
		}
		return false;
	}

	public void Init()
	{
	}

	public void InitDataForState(AnimatronicEntity entity)
	{
		switch (entity.stateData.animatronicState)
		{
		case StateData.AnimatronicState.FarAway:
			entity.InitDataForFarAwayState();
			break;
		case StateData.AnimatronicState.NearPlayer:
			entity.InitDataForNearPlayerState();
			break;
		case StateData.AnimatronicState.Scavenging:
			entity.InitDataForScavengeState();
			break;
		case StateData.AnimatronicState.SentAway:
			entity.InitDataForSentAwayState();
			break;
		case StateData.AnimatronicState.ScavengeAppointment:
			entity.InitDataForScavengeAppointmentState();
			break;
		default:
			entity.InitDataGeneric();
			break;
		}
	}

	public void Update()
	{
		UpdateEntityStates();
		CleanupDestroyed();
	}

	public void RegisterStateChangedEvent(Action<EntityStateChangedArgs> callback)
	{
		this.EntityStateChangedEvent = callback;
	}
}
