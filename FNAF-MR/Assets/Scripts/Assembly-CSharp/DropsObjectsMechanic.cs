using System;
using System.Collections.Generic;
using UnityEngine;

public class DropsObjectsMechanic
{
	public enum SpawnType
	{
		None = 0,
		FromBundle = 1,
		FromPlushSuit = 2
	}

	public enum SuccessAction
	{
		None = 0,
		ForceCharge = 1,
		ForceFrontalCharge = 2
	}

	public enum FailureAction
	{
		None = 0,
		Jumpscare = 1
	}

	public enum DropsObjectUiTarget
	{
		None = 0,
		PlayerNoiseMeter = 1
	}

	private EventExposer _masterEventExposer;

	private AssetCache _assetCache;

	private Transform _droppedObjectVisualsParent;

	private CameraSceneController _cameraController;

	private DroppedObjectVisuals _droppedObjectVisuals;

	private DropsObjectsData _settings;

	private Blackboard _blackboard;

	private AttackAnimatronicExternalSystems _systems;

	private bool _isReady;

	private bool _allowSpawn;

	private bool _forceSpawn;

	private List<DroppedObject> _wasCollected;

	private int _collectedDrops;

	private int _failedDrops;

	private int _lastSuccessActionCollectedDrops;

	private readonly SimpleTimer _cooldown;

	private readonly SimpleTimer _fallback;

	private float _dropExpireTotal;

	private readonly DropsObjectsMechanicViewModel _viewModel;

	private Action _updateAttackUI;

	public DropsObjectsMechanicViewModel ViewModel => _viewModel;

	public void StartSystem(DropsObjectsData settings, Blackboard blackboard)
	{
		_settings = settings;
		_blackboard = blackboard;
		_collectedDrops = 0;
		_failedDrops = 0;
		_lastSuccessActionCollectedDrops = 0;
		SetUpForNextDrop();
		UpdateViewModel();
		_isReady = false;
		if (_droppedObjectVisuals != null)
		{
			_droppedObjectVisuals.PreloadDroppableObjects(_settings, _blackboard.PlushSuitData, DroppedObjectVisualsReady);
		}
	}

	public void StopSystem()
	{
		foreach (DroppedObject activeObject in _droppedObjectVisuals.ActiveObjects)
		{
			DespawnDroppedObject(activeObject, wasCollected: false);
		}
		_droppedObjectVisuals.DestroyDroppableObjects();
		_isReady = false;
		_settings = null;
		_blackboard = null;
		ResetSpawnVariables();
		UpdateViewModel();
	}

	public void Update()
	{
		if (_isReady)
		{
			if (_cooldown.Started && _cooldown.IsExpired())
			{
				_cooldown.Reset();
				_allowSpawn = true;
				StartFallbackTimer();
			}
			if (_fallback.Started && _fallback.IsExpired())
			{
				_fallback.Reset();
				_forceSpawn = true;
			}
			if (_allowSpawn && !IsInBlacklistedPhase())
			{
				TryToSpawn(_forceSpawn);
			}
			if (_droppedObjectVisuals != null && _droppedObjectVisuals.ActiveObjects.Count >= 1)
			{
				UpdateActiveDroppedObjects();
			}
			UpdateViewModel();
		}
	}

	private void DroppedObjectVisualsReady()
	{
		_isReady = true;
	}

	private void SetUpForNextDrop()
	{
		if (_droppedObjectVisuals != null && _settings != null)
		{
			StartCooldownTimer();
		}
	}

	private void ResetSpawnVariables()
	{
		_allowSpawn = false;
		_forceSpawn = false;
		_cooldown.Reset();
		_fallback.Reset();
		_dropExpireTotal = 0f;
	}

	private void StartCooldownTimer()
	{
		float minInclusive = 0f;
		float maxInclusive = 0f;
		if (_settings != null && _settings.CooldownSeconds != null)
		{
			minInclusive = _settings.CooldownSeconds.Min;
			maxInclusive = _settings.CooldownSeconds.Max;
		}
		_cooldown.StartTimer(UnityEngine.Random.Range(minInclusive, maxInclusive));
	}

	private void StartFallbackTimer()
	{
		float minInclusive = 0f;
		float maxInclusive = 0f;
		if (_settings != null && _settings.FallbackSeconds != null)
		{
			minInclusive = _settings.FallbackSeconds.Min;
			maxInclusive = _settings.FallbackSeconds.Max;
		}
		_fallback.StartTimer(UnityEngine.Random.Range(minInclusive, maxInclusive));
	}

	private bool IsInBlacklistedPhase()
	{
		return _settings.BlacklistedPhases.Contains(_blackboard.Phase);
	}

	private void TryToSpawn(bool forceSpawn)
	{
		if (_failedDrops + _collectedDrops >= _settings.DropCount)
		{
			return;
		}
		if (_droppedObjectVisuals.ActiveObjects.Count >= _settings.MaxConcurrentObjects)
		{
			string text = _droppedObjectVisuals.ActiveObjects.Count.ToString();
			int maxConcurrentObjects = _settings.MaxConcurrentObjects;
			Debug.LogError("ACTIVE DROPPED OBJECTS IS AT MAX VALUE. ACTIVE: " + text + " - " + maxConcurrentObjects);
			return;
		}
		if (forceSpawn)
		{
			ResetSpawnVariables();
			if (_blackboard.Systems.EncounterEnvironment.droppablePositions.Count > 0)
			{
				List<Transform> list = new List<Transform>();
				foreach (Transform droppablePosition in _blackboard.Systems.EncounterEnvironment.droppablePositions)
				{
					if (droppablePosition.gameObject.activeSelf)
					{
						list.Add(droppablePosition);
					}
				}
				Transform transform = list[UnityEngine.Random.Range(0, list.Count)];
				SpawnDroppedObject(usePosition: true, transform.position);
			}
			else
			{
				SpawnDroppedObject(usePosition: false, Vector3.zero);
			}
		}
		SetUpForNextDrop();
		_updateAttackUI?.Invoke();
	}

	private void SpawnDroppedObject(bool usePosition, Vector3 spawnPosition)
	{
		DroppedObject droppedObject = ((!usePosition) ? _droppedObjectVisuals.SpawnDroppedObject(Vector3.zero) : _droppedObjectVisuals.SpawnDroppedObject(spawnPosition));
		if (droppedObject == null)
		{
			Debug.LogError("DropsObjectsMechanic SpawnDroppedObject - Failed to spawn dropped object");
			return;
		}
		_dropExpireTotal = _settings.DropDurations[_failedDrops + _collectedDrops];
		if (_dropExpireTotal > -1f)
		{
			droppedObject.expirationTimer.StartTimer(_dropExpireTotal);
		}
		_blackboard.Model.SetAudioState(AudioStateGroupName.Drops, GetDropAudioState());
		_blackboard.Model.RaiseAudioEventAnimatronic(AudioEventName.CameraObjectDropBegin, droppedObject.audioPrefix);
	}

	private AudioStateName GetDropAudioState()
	{
		return (_failedDrops + _collectedDrops) switch
		{
			0 => AudioStateName.Drop1, 
			1 => AudioStateName.Drop2, 
			_ => AudioStateName.Drop3, 
		};
	}

	private void DespawnDroppedObject(DroppedObject droppedObject, bool wasCollected)
	{
		if (wasCollected)
		{
			_blackboard.Model.RaiseAudioEventAnimatronic(AudioEventName.CameraObjectDropEnd, droppedObject.audioPrefix);
		}
		_droppedObjectVisuals.DespawnDroppedObject(droppedObject);
		SetUpForNextDrop();
	}

	public void DespawnAllDroppedObjects()
	{
		_droppedObjectVisuals.DespawnDroppedObjects();
	}

	private void UpdateActiveDroppedObjects()
	{
		if (_wasCollected.Count >= 1)
		{
			_wasCollected.ForEach(delegate(DroppedObject droppedObject)
			{
				_collectedDrops++;
				_blackboard.Model.RaiseAudioEventAnimatronic(AudioEventName.CameraObjectDropCollected, droppedObject.audioPrefix);
				_blackboard.DroppedObjectsCollected = _collectedDrops;
				if (_collectedDrops - _lastSuccessActionCollectedDrops >= _settings.CollectCountForSuccess)
				{
					_lastSuccessActionCollectedDrops = _collectedDrops;
					RunSuccessAction();
				}
				DespawnDroppedObject(droppedObject, wasCollected: true);
			});
			_wasCollected.Clear();
		}
		List<DroppedObject> objectsToDespawn = new List<DroppedObject>();
		_droppedObjectVisuals.ActiveObjects.ForEach(delegate(DroppedObject droppedObject)
		{
			if (droppedObject.expirationTimer.Started && droppedObject.expirationTimer.IsExpired())
			{
				droppedObject.expirationTimer.Reset();
				_failedDrops++;
				_blackboard.Model.RaiseAudioEventAnimatronic(AudioEventName.CameraObjectDropFailed, droppedObject.audioPrefix);
				RunFailureAction();
				objectsToDespawn.Add(droppedObject);
			}
		});
		if (objectsToDespawn.Count >= 1)
		{
			foreach (DroppedObject item in objectsToDespawn)
			{
				DespawnDroppedObject(item, wasCollected: false);
			}
		}
		UpdateDroppedObjectNoiseMeter();
	}

	private void TouchDetected(Vector2 position)
	{
		if (_droppedObjectVisuals != null && _isReady)
		{
			DroppedObject droppedObject = _droppedObjectVisuals.TestTouchVsDroppedObjects(position);
			if (droppedObject != null)
			{
				_wasCollected.Add(droppedObject);
			}
		}
	}

	private void RunSuccessAction()
	{
		if (_settings.SuccessAction == SuccessAction.ForceFrontalCharge)
		{
			_blackboard.ForceFrontalCharge = true;
			_blackboard.ForceCharge = true;
		}
		else if (_settings.SuccessAction == SuccessAction.ForceCharge)
		{
			_blackboard.ForceCharge = true;
		}
	}

	private void RunFailureAction()
	{
		if (_settings.FailureAction == FailureAction.Jumpscare)
		{
			_blackboard.Systems.Encounter.SetDeathText("death_drops");
			_blackboard.ForceJumpscare = true;
		}
	}

	private void UpdateViewModel()
	{
		if (_droppedObjectVisuals != null && _viewModel != null)
		{
			_viewModel.IsDroppedObjectActive = _droppedObjectVisuals.ActiveObjects.Count > 0;
			if (_viewModel.IsDroppedObjectActive)
			{
				DroppedObject droppedObject = _droppedObjectVisuals.ActiveObjects[0];
				_viewModel.CollectionTimeRemaining = (droppedObject.expirationTimer.Started ? droppedObject.expirationTimer.GetRemainingTime() : (-1f));
				_viewModel.CollectionPercentRemaining = ((_dropExpireTotal > 0f) ? (_viewModel.CollectionTimeRemaining / _dropExpireTotal) : (-1f));
				_viewModel.NumCollected = _collectedDrops;
				_viewModel.NumFailed = _failedDrops;
				_viewModel.NumRemaining = _settings.DropCount - _collectedDrops - _failedDrops;
			}
		}
	}

	private void UpdateDroppedObjectNoiseMeter()
	{
		if (_settings.UITarget != DropsObjectUiTarget.PlayerNoiseMeter || _systems.NoiseMechanic == null || _systems.NoiseMechanic.PlayerNoiseMeter == null)
		{
			return;
		}
		float num = 0f;
		foreach (DroppedObject activeObject in _droppedObjectVisuals.ActiveObjects)
		{
			num += Math.Min(Time.time - activeObject.SpawnTime, _settings.UITargetDuration);
		}
		float num2 = ((!(_settings.UITargetDuration < 0f)) ? (num / _settings.UITargetDuration * (_settings.UITargetRange.Max - _settings.UITargetRange.Min) + _settings.UITargetRange.Min * (float)_droppedObjectVisuals.ActiveObjects.Count) : (_settings.UITargetRange.Max * (float)_droppedObjectVisuals.ActiveObjects.Count));
		_systems.NoiseMechanic.PlayerNoiseMeter.SetNoiseModifier(num2 + 1f);
	}

	public DropsObjectsMechanic(EventExposer masterEventExposer, AssetCache assetCacheAccess)
	{
		_wasCollected = new List<DroppedObject>();
		_cooldown = new SimpleTimer();
		_fallback = new SimpleTimer();
		_viewModel = new DropsObjectsMechanicViewModel();
		_masterEventExposer = masterEventExposer;
		AssetCacheReady(assetCacheAccess);
	}

	private void AssetCacheReady(AssetCache assetCache)
	{
		_assetCache = assetCache;
		TryToCreateDroppedObjectVisuals();
	}

	public void Setup(Transform droppedObjectVisualsParent, CameraSceneController cameraController, AttackAnimatronicExternalSystems systems, Action updateAttackUI)
	{
		_droppedObjectVisualsParent = droppedObjectVisualsParent;
		_cameraController = cameraController;
		_systems = systems;
		_masterEventExposer.add_TouchDetected(TouchDetected);
		_updateAttackUI = (Action)Delegate.Combine(_updateAttackUI, updateAttackUI);
		TryToCreateDroppedObjectVisuals();
	}

	private void TryToCreateDroppedObjectVisuals()
	{
		if (_assetCache != null && !(_droppedObjectVisualsParent == null) && !(_cameraController.Camera == null))
		{
			_droppedObjectVisuals = new DroppedObjectVisuals(_assetCache, _droppedObjectVisualsParent, _cameraController.Camera);
		}
	}

	public void Teardown()
	{
		_masterEventExposer.remove_TouchDetected(TouchDetected);
		_masterEventExposer = null;
		if (_droppedObjectVisuals != null)
		{
			_droppedObjectVisuals.Teardown();
		}
		_droppedObjectVisuals = null;
	}
}
