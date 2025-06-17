using System.Collections.Generic;
using UnityEngine;

public class ScavengingEntityLifecycleRegulator
{
	private EventExposer _eventExposer;

	private ServerDomain _serverDomain;

	private Dictionary<string, ScavengingEntity> _allEntitiesRef;

	private float _syncTimer;

	private Dictionary<string, ScavengingEntity> _tempValidEntities;

	private List<string> _entityIdsToRetire;

	private List<string> _retiredEntityIdsForServer;

	private CONFIG_DATA.MapEntities _mapEntityConfig;

	public void DispatchValidEntityModelState()
	{
		_tempValidEntities.Clear();
		Debug.Log("entities count: " + _allEntitiesRef.Keys.Count);
		foreach (string key in _allEntitiesRef.Keys)
		{
			if (IsCurrentTimeValidForEntity(_allEntitiesRef[key]))
			{
				Debug.Log("adding temp scavenge entity");
				_tempValidEntities[key] = _allEntitiesRef[key];
			}
			else
			{
				Debug.Log("time aint valid");
			}
		}
		Debug.Log("updating temp valid scavenge entities");
		_eventExposer.OnScavengingEntitiesModelsUpdated(_tempValidEntities.Values);
	}

	public void ClearEntityModelState()
	{
		Debug.Log("Cleared model states");
		_eventExposer.OnScavengingEntitiesModelsUpdated(new List<ScavengingEntity>());
	}

	private void EventExposer_UnityFrameUpdate(float dt)
	{
		_syncTimer += dt;
		if (CountEntitiesActivatedBetween(Time.time - dt, Time.time) > 0 || TryFlushExpiredEntities())
		{
			DispatchValidEntityModelState();
		}
		if (!((double)_mapEntityConfig.Server.ClientBatchedRetireEventPeriodSeconds > (double)_syncTimer))
		{
			DispatchExpiredEntityUpdateToServer();
			_syncTimer = 0f;
		}
	}

	public ScavengingEntityLifecycleRegulator(EventExposer eventExposer, Dictionary<string, ScavengingEntity> entities)
	{
		_eventExposer = eventExposer;
		_allEntitiesRef = entities;
		Debug.LogWarning("should be THIS MANY SCAVENGE ENTITIES: " + entities.Values.Count);
		_tempValidEntities = new Dictionary<string, ScavengingEntity>();
		_entityIdsToRetire = new List<string>();
		_retiredEntityIdsForServer = new List<string>();
	}

	public void Setup(ServerDomain serverDomain, CONFIG_DATA.MapEntities mapEntityConfig)
	{
		_serverDomain = serverDomain;
		_syncTimer = 0f;
		_eventExposer.add_UnityFrameUpdate(EventExposer_UnityFrameUpdate);
		_mapEntityConfig = mapEntityConfig;
	}

	public void Teardown()
	{
		_eventExposer.remove_UnityFrameUpdate(EventExposer_UnityFrameUpdate);
		_eventExposer = null;
		_allEntitiesRef = null;
		_tempValidEntities = null;
		_retiredEntityIdsForServer = null;
	}

	private int CountEntitiesActivatedBetween(float previousTime, float currentTime)
	{
		int num = 0;
		foreach (string key in _allEntitiesRef.Keys)
		{
			ScavengingEntity scavengingEntity = _allEntitiesRef[key];
			if (scavengingEntity.LocalSpawnTime > previousTime && scavengingEntity.LocalSpawnTime <= currentTime)
			{
				num++;
			}
		}
		return num;
	}

	private bool TryFlushExpiredEntities()
	{
		foreach (string key in _allEntitiesRef.Keys)
		{
			if (IsEntityExpired(_allEntitiesRef[key]))
			{
				_entityIdsToRetire.Add(key);
				if (_allEntitiesRef[key].SynchronizeOnServer)
				{
					_retiredEntityIdsForServer.Add(key);
				}
			}
		}
		if (_entityIdsToRetire.Count < 1)
		{
			return false;
		}
		foreach (string item in _entityIdsToRetire)
		{
			Debug.Log("scavenging retire: " + item);
			if (_allEntitiesRef.ContainsKey(item))
			{
				Debug.Log("retiring scavenge.");
				_allEntitiesRef.Remove(item);
			}
		}
		return true;
	}

	private void DispatchExpiredEntityUpdateToServer()
	{
		if (_retiredEntityIdsForServer.Count >= 1)
		{
			_serverDomain.scavengingEntityRetireEntitiesRequester.RetireEntities(_retiredEntityIdsForServer);
		}
		_retiredEntityIdsForServer.Clear();
	}

	private void FlushAllServerEntities()
	{
		Debug.Log("FLUSHING SCAVENGE");
		foreach (string key in _allEntitiesRef.Keys)
		{
			if (_allEntitiesRef[key].SynchronizeOnServer)
			{
				_allEntitiesRef.Remove(key);
				_retiredEntityIdsForServer.Add(key);
			}
		}
	}

	private bool IsEntityExpired(ScavengingEntity entity)
	{
		return Time.time >= entity.LocalRemoveTime;
	}

	private bool IsCurrentTimeValidForEntity(ScavengingEntity entity)
	{
		if (Time.time < entity.LocalSpawnTime)
		{
			return false;
		}
		return Time.time < entity.LocalRemoveTime;
	}
}
