using System;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimatronic
{
	private EventExposer _masterEventExposer;

	private AttackAnimatronicExternalSystems _systems;

	private int _activeEntityIndex;

	private List<AnimatronicEntity> _entities;

	private List<Animatronic3D> _models;

	private List<AttackProfile> _attackProfiles;

	private ScavengingAttackProfile _scavengingAttackProfile;

	private ScavengingData _scavengingData;

	private List<AnimatronicState> _animatronicStates;

	private bool _isScavenging;

	private Blackboard _blackboard;

	private PhaseChooser _phaseChooser;

	private bool _offscreenLossStarted;

	private bool _readyForCleanup;

	private string _deathText = "death_generic";

	public string EntityId
	{
		get
		{
			if (_entity != null)
			{
				return _entity.entityId;
			}
			Debug.Log("entity is null bro.");
			return null;
		}
	}

	public string CpuAudioId => _entity.animatronicConfigData.CpuData.SoundBankName;

	public string CpuId => _entity.animatronicConfigData.CpuData.Id;

	public string PlushSuitId => _entity.animatronicConfigData.PlushSuitData.Id;

	public EncounterType EncounterType
	{
		get
		{
			if (!_isScavenging)
			{
				return _blackboard.AttackProfile.EncounterType;
			}
			return EncounterType.Scavenging;
		}
	}

	public long EncounterStartTime => _entity.AttackSequenceData.encounterStartTime;

	public AttackUIData AttackUIData
	{
		get
		{
			if (!_isScavenging)
			{
				return _blackboard.AttackProfile.AttackUIData;
			}
			return _blackboard.ScavengingAttackProfile.AttackUIData;
		}
	}

	public DropsObjectsMechanicViewModel DropsObjectsMechanicViewModel => _systems.DropsObjectsMechanic.ViewModel;

	public RewardDataV3 RewardData => _entity.rewardDataV3;

	public AnimatronicEntity Entity => _entity;

	public Animatronic3D Model => _model;

	public string DeathText
	{
		get
		{
			return _deathText;
		}
		set
		{
			_deathText = value;
		}
	}

	private AnimatronicEntity _entity
	{
		get
		{
			if (_entities == null)
			{
				Debug.LogError("entities... null?");
				return null;
			}
			if (_entities[_activeEntityIndex] == null)
			{
				Debug.LogError("entities at active index... null?");
				return null;
			}
			return _entities[_activeEntityIndex];
		}
	}

	private Animatronic3D _model => _models[_activeEntityIndex];

	private AttackProfile _attackProfile => _attackProfiles[_activeEntityIndex];

	private AnimatronicState _animatronicState => _animatronicStates[_activeEntityIndex];

	private ShockTargetBorderData _shockTargetBorder => _entity.animatronicConfigData.PlushSuitData.ShockTargetBorder;

	public event Action<AttackAnimatronic> OnReadyForCleanup;

	public void EnteredCameraMode()
	{
		_blackboard.HasEnteredCameraMode = true;
	}

	public void OffscreenLossTriggered()
	{
		if (!_offscreenLossStarted)
		{
			_offscreenLossStarted = true;
			_phaseChooser.OffscreenLossTriggered();
		}
	}

	public bool HitByShocker()
	{
		Debug.Log("Can be shocked - " + IsShockable());
		if (IsShockable())
		{
			return true;
		}
		if (_blackboard.IsScavenging && (_phaseChooser.Phase == AttackPhase.ScavengingSearching || _phaseChooser.Phase == AttackPhase.ScavengingSpotted))
		{
			if (_blackboard.Model.GetDistanceFromCamera() < 5f)
			{
				return _blackboard.IsOnScreen;
			}
			return false;
		}
		if (_blackboard.IsOnScreen)
		{
			if (_phaseChooser.Phase != AttackPhase.Haywire)
			{
				return _phaseChooser.Phase == AttackPhase.Slash;
			}
			return true;
		}
		return false;
	}

	private bool IsShockable()
	{
		bool result = _blackboard.InShockableWindow && _blackboard.IsOnScreen;
		Debug.Log("On Screen? - " + _blackboard.IsOnScreen);
		Debug.Log("Shockable? = " + _blackboard.InShockableWindow);
		return result;
	}

	private void ShockerActivated(ShockerActivation shockerActivation)
	{
		Debug.Log("Shocker activated");
		if (shockerActivation.OnCooldown)
		{
			Debug.Log("Cant shock - on cooldown");
			return;
		}
		if (shockerActivation.NoBattery)
		{
			Debug.Log("Cant shock - no battery");
			return;
		}
		if (!shockerActivation.DidHit)
		{
			Debug.Log("Cant shock - didnt hit");
			return;
		}
		if (_phaseChooser != null)
		{
			if (_phaseChooser.Phase == AttackPhase.Haywire)
			{
				_blackboard.ShockedDuringHaywire = true;
				return;
			}
			if (_phaseChooser.Phase == AttackPhase.Slash)
			{
				_blackboard.ShockedDuringSlash = true;
				return;
			}
		}
		else
		{
			Debug.Log("somehow phase chooser is null");
		}
		Debug.Log("Shocking!");
		Shock();
	}

	private void AnimationGameEventReceived(AnimationEvent animationEvent)
	{
		Debug.Log("AttackAnimatronic received game event " + animationEvent.intParameter);
		switch (animationEvent.intParameter)
		{
		case 2000:
			_blackboard.InShockableWindow = true;
			break;
		case 2001:
			_blackboard.InShockableWindow = false;
			break;
		case 2002:
			_blackboard.PhantomOverloadRequested = true;
			break;
		case 2003:
			_blackboard.PhantomRepositionRequested = true;
			break;
		case 1008:
			Debug.Log("NOW! PARRY NOW!");
			if (_blackboard.Systems.Mask.IsMaskInRaiseTransition() && _blackboard.IsAABBOnScreen)
			{
				Debug.Log("THE GOAT.");
				_blackboard.Model.RaiseAudioEventCamera(AudioEventName.ParrySlash, useCpu: false);
				Shock();
				break;
			}
			Debug.Log("Great job dickwad. You fucked it.");
			if (!_blackboard.Systems.Mask.IsMaskFullyOn() || !_blackboard.IsAABBOnScreen)
			{
				DeathText = "death_slash";
				_blackboard.ForceJumpscare = true;
			}
			break;
		}
	}

	private void FootstepEffectTriggered(bool isWalking)
	{
		_systems.AttackStatic.Container.AddFootstepAdditive(EntityId, (!isWalking) ? _blackboard.StaticConfig.WalkFootsteps : _blackboard.StaticConfig.RunFootsteps);
	}

	private void Shock()
	{
		if (_isScavenging)
		{
			Debug.Log("Shocked during Scavenging");
			_blackboard.ShockedDuringScavenging = true;
		}
		else
		{
			_blackboard.NumShocksRemaining--;
			Debug.Log("NumShocksRemaning: " + _blackboard.NumShocksRemaining);
		}
	}

	private void UpdateBlackboard()
	{
		if (_phaseChooser == null)
		{
			Debug.Log("phase choose is null");
		}
		if (_blackboard != null)
		{
			_blackboard.Phase = _phaseChooser.Phase;
			_blackboard.AbsoluteAngleFromCamera = _model.GetAbsoluteAngleFromCamera();
			_blackboard.SignedAngleFromCamera = _model.GetSignedAngleFromCamera();
			_blackboard.DistanceFromCamera = _model.GetDistanceFromCamera();
			_blackboard.IsAABBOnScreen = _model.IsAABBInCameraFrustum(_systems.CameraController.Camera);
			_blackboard.IsOnScreen = _model.IsOnScreen(_systems.CameraController.Camera, _shockTargetBorder);
		}
	}

	public AttackAnimatronic(EventExposer masterEventExposer, AttackAnimatronicExternalSystems systems, List<AnimatronicEntity> entities, List<Animatronic3D> models, List<AttackProfile> attackProfiles, ScavengingAttackProfile scavengingAttackProfile, List<AnimatronicState> animatronicStates, bool isScavenging, ScavengingData scavengingData)
	{
		_activeEntityIndex = 0;
		_masterEventExposer = masterEventExposer;
		_systems = systems;
		_entities = entities;
		_models = models;
		_attackProfiles = attackProfiles;
		_scavengingAttackProfile = scavengingAttackProfile;
		_animatronicStates = animatronicStates;
		_isScavenging = isScavenging;
		_scavengingData = scavengingData;
		InitializeModels(systems.CameraStableTransform);
		_model.SetVisible(isVisible: true);
		Debug.LogWarning("MAKING BLACKBOARD.");
		InitializeBlackboard();
		Debug.LogWarning("MAKING PHASE CHOOSER.");
		_phaseChooser = new PhaseChooser(_masterEventExposer, ReadyForCleanup);
		_phaseChooser.Setup(_blackboard);
		_systems.AttackStatic.Container.RegisterStaticSource(EntityId);
		_systems.AnimatronicState = _animatronicState;
		_masterEventExposer.add_ShockerActivated(ShockerActivated);
	}

	private void InitializeModels(Transform cameraTransform)
	{
		foreach (Animatronic3D model in _models)
		{
			int index = _models.IndexOf(model);
			AnimatronicEntity entity = _entities[index];
			SetupModel(model, entity, cameraTransform);
		}
		void SetupModel(Animatronic3D model, AnimatronicEntity animatronicEntity, Transform cameraStableTransform)
		{
			model.Setup(animatronicEntity.animatronicConfigData, AudioMode.Camera, cameraStableTransform);
			model.RegisterForAnimationGameEvents(AnimationGameEventReceived);
			model.RegisterUpdateCallback(Update);
			model.SetFootstepEffectCallback(FootstepEffectTriggered);
			model.SetWearAndTear(100 - animatronicEntity.wearAndTear);
			model.SetVisible(isVisible: false);
		}
	}

	private void TeardownModels()
	{
		foreach (Animatronic3D model in _models)
		{
			model.UnregisterUpdateCallback(Update);
			model.UnregisterFromAnimationGameEvents(AnimationGameEventReceived);
			model.Teardown();
		}
		_models.Clear();
	}

	private void InitializeBlackboard()
	{
		Blackboard blackboard = new Blackboard();
		blackboard.NumShocksRemaining = _attackProfile.NumShocksToDefeat;
		Debug.Log("NumShocksRemaining: " + blackboard.NumShocksRemaining);
		blackboard.NumAnimatronicsRemaining = _entities.Count;
		blackboard.EntityId = EntityId;
		blackboard.Model = _model;
		blackboard.Systems = _systems;
		blackboard.IsExpressDelivery = _entity.stateData.expressDelivery;
		blackboard.StaticConfig = _systems.AttackStatic.Configs.GetStaticConfig(_attackProfile.StaticProfile);
		blackboard.AttackProfile = _attackProfile;
		blackboard.ScavengingAttackProfile = _scavengingAttackProfile;
		blackboard.IsScavenging = _isScavenging;
		blackboard.ScavengingData = _scavengingData;
		blackboard.PlushSuitData = _entity.animatronicConfigData.PlushSuitData;
		blackboard.HaywireState = new HaywireGlobalState(_attackProfile.Haywire);
		blackboard.SlashState = new SlashGlobalState(_attackProfile.Slash);
		blackboard.ScavengingState = new ScavengingGlobalState(_scavengingAttackProfile);
		blackboard.OnAnimatronicDefeated = SetUpNextAnimatronic;
		blackboard.HasAnimatronicToActivate = HasAnimatronicToActivate;
		blackboard.ActivateNextAnimatronic = ActivateNextAnimatronic;
		_blackboard = blackboard;
		_blackboard.EncounterType = EncounterType;
	}

	private void SetUpNextAnimatronic()
	{
		if (!_blackboard.HasDefeatedAllAnimatronics)
		{
			_model.SetVisible(isVisible: false);
			_systems.AttackStatic.Container.DeregisterStaticSource(EntityId);
			_activeEntityIndex++;
			_model.SetVisible(isVisible: true);
			_systems.AttackStatic.Container.RegisterStaticSource(EntityId);
			_systems.AnimatronicState = _animatronicState;
			SetUpBlackboardForActiveAnimatronic();
		}
	}

	private void SetUpBlackboardForActiveAnimatronic()
	{
		_blackboard.NumShocksRemaining = _attackProfile.NumShocksToDefeat;
		_blackboard.EntityId = EntityId;
		_blackboard.Model = _model;
		_blackboard.IsExpressDelivery = _entity.stateData.expressDelivery;
		_blackboard.StaticConfig = _systems.AttackStatic.Configs.GetStaticConfig(_attackProfile.StaticProfile);
		_blackboard.AttackProfile = _attackProfile;
		_blackboard.ScavengingAttackProfile = _scavengingAttackProfile;
		_blackboard.IsScavenging = _isScavenging;
		_blackboard.ScavengingData = _scavengingData;
		_blackboard.PlushSuitData = _entity.animatronicConfigData.PlushSuitData;
		_blackboard.HaywireState = new HaywireGlobalState(_attackProfile.Haywire);
		_blackboard.SlashState = new SlashGlobalState(_attackProfile.Slash);
		_blackboard.ScavengingState = new ScavengingGlobalState(_scavengingAttackProfile);
		_blackboard.ResetPausePhaseChangeGroup = true;
		_blackboard.EncounterType = EncounterType;
	}

	private bool CanActivateEntityAt(int index)
	{
		if (_entities.Count <= index)
		{
			Debug.LogError("Cant activate index " + index + " as it is outside the entity list count of " + _entities.Count + ". Current index is " + _activeEntityIndex + ".");
			return false;
		}
		if (_activeEntityIndex == index)
		{
			Debug.LogError("Cant activate index " + index + " as it is the active index!");
			return false;
		}
		return true;
	}

	private void ActivateAnimatronicEntityAt(int index)
	{
		_model.SetVisible(isVisible: false);
		_systems.AttackStatic.Container.DeregisterStaticSource(EntityId);
		_activeEntityIndex = index;
		_model.SetVisible(isVisible: true);
		_systems.AttackStatic.Container.RegisterStaticSource(EntityId);
		_systems.AnimatronicState = _animatronicState;
		_phaseChooser.ClearPhases();
		SetUpBlackboardForActiveAnimatronic();
		_phaseChooser.Setup(_blackboard);
	}

	private bool HasAnimatronicToActivate(EncounterTrigger trigger)
	{
		if (_attackProfile.EncounterTriggerSettings != null)
		{
			Debug.Log("Can activate for trigger " + trigger.ToString() + " - " + CanActivateEntityAt(_attackProfile.EncounterTriggerSettings.GetNextIndexForPhase(trigger, _activeEntityIndex)) + " - Logical: " + _attackProfile.Logical);
			return CanActivateEntityAt(_attackProfile.EncounterTriggerSettings.GetNextIndexForPhase(trigger, _activeEntityIndex));
		}
		return false;
	}

	private void ActivateNextAnimatronic(EncounterTrigger trigger)
	{
		ActivateAnimatronicEntityAt(_attackProfile.EncounterTriggerSettings.GetNextIndexForPhase(trigger, _activeEntityIndex));
	}

	public void RequestDestruction()
	{
		_phaseChooser.RequestDestruction();
	}

	public void Teardown()
	{
		Debug.Log("Teardown called for attack animatronic");
		_masterEventExposer.remove_ShockerActivated(ShockerActivated);
		_systems.AttackStatic.Container.DeregisterStaticSource(EntityId);
		_phaseChooser.Teardown();
		_phaseChooser = null;
		_blackboard.Teardown();
		_blackboard = null;
		_attackProfiles.Clear();
		_attackProfiles = null;
		TeardownModels();
		_models = null;
		_entities.Clear();
		_entities = null;
		_masterEventExposer = null;
		_systems = null;
	}

	private void Update()
	{
		if (_readyForCleanup)
		{
			PerformCleanup();
			return;
		}
		if (_systems.CameraStableTransform == null)
		{
			Debug.LogError("CAMERA STABLE TRANSFORM NULL");
		}
		if (_blackboard == null)
		{
			Debug.LogError("BLACKBOARD NULL");
		}
		if (_phaseChooser == null)
		{
			Debug.LogError("PHASE CHOOSER NULL");
		}
		UpdateBlackboard();
		_phaseChooser.Update();
		_blackboard.Phase = _phaseChooser.Phase;
		if (!_blackboard.FreezeStaticAngle)
		{
			_systems.AttackStatic.Container.UpdateStaticSourceAngle(EntityId, _model.GetAbsoluteAngleFromCamera());
		}
		else
		{
			_systems.AttackStatic.Container.UpdateStaticSourceAngle(EntityId, _model.GetAbsoluteAngleBetweenPositionAndCamera(_blackboard.FrozenStaticPosition));
		}
	}

	private void ReadyForCleanup()
	{
		Debug.Log("Cleanup set for AttackAnimatronic");
		_readyForCleanup = true;
	}

	private void PerformCleanup()
	{
		Debug.LogError("performing cleanup on attack animatronic!");
		Debug.LogError("cleanup animatronic cpu: " + Entity.endoskeletonData.cpu);
		_readyForCleanup = false;
		_entities[_activeEntityIndex].AttackSequenceData.attackSequenceComplete = true;
		this.OnReadyForCleanup?.Invoke(this);
	}
}
