using System;
using UnityEngine;

public class AttackSequenceDomain
{
	private SceneLookupTableAccess _sceneLookupTableAccess;

	private EventExposer _masterEventExposer;

	private AttackSequenceConfigs _configs;

	private AnimatronicEntityDomain _animatronicEntityDomain;

	private Animatronic3DDomain _animatronic3DDomain;

	private CameraEquipmentDomain _cameraEquipmentDomain;

	private GameAssetManagementDomain _gameAssetManagementDomain;

	private ItemDefinitionDomain _itemDefinitionDomain;

	private MasterDataDomain _masterDataDomain;

	private ServerDomain _serverDomain;

	private LootDomain _lootDomain;

	private GameDisplayChanger _gameDisplayChanger;

	private CameraFx _cameraFx;

	private AttackSpawner _animatronicSpawner;

	private AttackDestroyer _animatronicDestroyer;

	private IEncounter _encounter;

	private AttackStatic _attackStatic;

	private ShakeDetector _shakeDetector;

	private AttackDisruption _attackDisruption;

	private AttackSurge _attackSurge;

	private VisibilityAlterEffect _visibilityAlterEffect;

	private DropsObjectsMechanic _dropsObjectsMechanic;

	private NoiseMechanic _noiseMechanic;

	private IntroScreen _introScreen;

	private SubEntityMechanic _subEntityMechanic;

	private HaywireIndicator _haywireIndicator;

	private RewardDispatcher _rewardDispatcher;

	private AttackAnimatronicExternalSystems _systems;

	private AudioPlayer _audioPlayer;

	private bool addedCallback;

	private CameraSceneLookupTable lookupTable;

	public AttackSequenceConfigs Configs => _configs;

	protected bool IsReady => true;

	protected AttackSequenceDomain GetPublicInterface => this;

	public event Action UpdateAttackUI;

	public bool IsInEncounter()
	{
		if (_encounter == null)
		{
			return false;
		}
		return _encounter.IsInProgress();
	}

	public bool IsEncounterPlayingOutro()
	{
		if (_encounter == null)
		{
			return false;
		}
		return _encounter.IsPlayingOutro();
	}

	public bool CanReturnToMap()
	{
		if (_encounter == null)
		{
			return true;
		}
		return _encounter.CanReturnToMap();
	}

	public AttackUIData GetEncounterUIConfig()
	{
		if (_encounter == null)
		{
			Debug.LogError("ASKED FOR UI CONFIG BEFORE ENCOUNTER IS READY!");
			return null;
		}
		return _encounter.GetEncounterUIConfig();
	}

	public DropsObjectsMechanicViewModel GetEncounterDropsObjectsViewModel()
	{
		if (_encounter == null)
		{
			return null;
		}
		return _encounter.GetEncounterDropsObjectsViewModel();
	}

	public PlayerNoiseMeter GetPlayerNoiseMeter()
	{
		if (_noiseMechanic == null)
		{
			return null;
		}
		return _noiseMechanic.PlayerNoiseMeter;
	}

	public AnimatronicNoiseMeter GetAnimatronicNoiseMeter()
	{
		if (_noiseMechanic == null)
		{
			return null;
		}
		return _noiseMechanic.AnimatronicNoiseMeter;
	}

	public HaywireIndicator GetHaywireIndicator()
	{
		if (_haywireIndicator == null)
		{
			return null;
		}
		return _haywireIndicator;
	}

	public AnimatronicState GetAnimatronicState()
	{
		return _systems.AnimatronicState;
	}

	public bool IsLegacyAnimatronic()
	{
		if (_systems.AnimatronicState != null)
		{
			return _systems.AnimatronicState.IsLegacyAnimatronic;
		}
		return true;
	}

	public bool IsDisruptionFullyActive()
	{
		if (IsInEncounter() && _attackDisruption != null)
		{
			return _attackDisruption.IsDisruptionFullyActive;
		}
		return false;
	}

	public void UsedJammer()
	{
		_encounter.UsedJammer();
	}

	public void LeaveEncounter()
	{
		_encounter.LeaveEncounter();
	}

	public void ShockerActivated(bool activated)
	{
		if (activated)
		{
			if (!IsInEncounter() || _attackDisruption == null)
			{
				Debug.LogError("Cannot use Shocker - Not in encounter or Disruption is null!");
			}
			else
			{
				_encounter.ShockerActivated(_attackDisruption.IsDisruptionFullyActive);
			}
		}
	}

	private void SetEncounter(Encounter encounter)
	{
		if (_encounter != null)
		{
			_encounter.Teardown();
		}
		encounter.Setup(_animatronicSpawner, _animatronicDestroyer, shocker: _cameraEquipmentDomain.Shocker, gameDisplayChanger: _gameDisplayChanger, rewardDispatcher: _rewardDispatcher);
		_encounter = encounter;
		if (_systems != null)
		{
			_systems.Encounter = _encounter;
		}
	}

	private void SetScavengingEncounter(ScavengingEncounter scavengeEncounter)
	{
		if (_encounter != null)
		{
			_encounter.Teardown();
		}
		scavengeEncounter.Setup(_animatronicSpawner, _animatronicDestroyer, shocker: _cameraEquipmentDomain.Shocker, gameDisplayChanger: _gameDisplayChanger, rewardDispatcher: _rewardDispatcher);
		_encounter = scavengeEncounter;
		if (_systems != null)
		{
			_systems.Encounter = _encounter;
		}
	}

	public AttackSequenceDomain(EventExposer masterEventExposer, MasterDataDomain masterDataDomain)
	{
		_masterEventExposer = masterEventExposer;
		_masterDataDomain = masterDataDomain;
		masterEventExposer.add_StartAttackEncounter(SetEncounter);
		masterEventExposer.add_StartAttackScavengingEncounter(SetScavengingEncounter);
		BuildInternalsAtConstruction();
	}

	private void BuildInternalsAtConstruction()
	{
		_animatronicDestroyer = new AttackDestroyer();
		_configs = new AttackSequenceConfigs();
		_encounter = new Encounter(_masterEventExposer);
		_attackStatic = new AttackStatic(_masterEventExposer, _masterDataDomain);
		_shakeDetector = new ShakeDetector();
		_attackDisruption = new AttackDisruption(_masterEventExposer, _shakeDetector);
		_attackSurge = new AttackSurge(_masterEventExposer);
		_visibilityAlterEffect = new VisibilityAlterEffect(_masterEventExposer);
		_introScreen = new IntroScreen(_masterEventExposer);
		_subEntityMechanic = new SubEntityMechanic(_masterEventExposer);
		_haywireIndicator = new HaywireIndicator();
	}

	private void OnAttackUIUpdated()
	{
		this.UpdateAttackUI?.Invoke();
	}

	public void Setup(SceneLookupTableAccess sceneLookupTableAccess, AnimatronicEntityDomain animatronicEntityDomain, Animatronic3DDomain animatronic3DDomain, CameraEquipmentDomain cameraEquipmentDomain, ItemDefinitionDomain itemDefinitionDomain, CameraFx cameraFx, GameDisplayChanger gameDisplayChanger, GameAudioDomain gameAudioDomain, GameAssetManagementDomain gameAssetManagementDomain, LootDomain lootDomain, ServerDomain serverDomain)
	{
		_sceneLookupTableAccess = sceneLookupTableAccess;
		_animatronicEntityDomain = animatronicEntityDomain;
		_animatronic3DDomain = animatronic3DDomain;
		_cameraEquipmentDomain = cameraEquipmentDomain;
		_gameAssetManagementDomain = gameAssetManagementDomain;
		_itemDefinitionDomain = itemDefinitionDomain;
		_serverDomain = serverDomain;
		_gameDisplayChanger = gameDisplayChanger;
		_cameraFx = cameraFx;
		_lootDomain = lootDomain;
		_audioPlayer = gameAudioDomain.AudioPlayer;
		_masterEventExposer.add_GameDisplayChange(GameDisplayOrtonChange);
		BuildInternalsAfterSetup();
	}

	private void GameDisplayOrtonChange(GameDisplayData yeah)
	{
		Debug.LogWarning("GAME DISPLAY CHANGE SEEN!");
		if ((yeah.currentDisplay == GameDisplayData.DisplayType.camera || yeah.currentDisplay == GameDisplayData.DisplayType.scavengingui) && lookupTable == null)
		{
			_sceneLookupTableAccess.GetCameraSceneLookupTableAsync(CameraSceneLookupTableReady);
		}
	}

	private void BuildInternalsAfterSetup()
	{
		_animatronicSpawner = new AttackSpawner(_masterEventExposer, _animatronicEntityDomain, _animatronic3DDomain, _itemDefinitionDomain);
		_dropsObjectsMechanic = new DropsObjectsMechanic(_masterEventExposer, _gameAssetManagementDomain.AssetCacheAccess);
		_noiseMechanic = new NoiseMechanic(_configs);
		_rewardDispatcher = new RewardDispatcher(_masterEventExposer, _serverDomain);
		_systems = new AttackAnimatronicExternalSystems();
		_systems.Encounter = _encounter;
		_animatronicSpawner.InitialSetup(_systems);
		Debug.LogWarning("INITIAL SETUP. WHO DID THIS.");
	}

	private void CameraSceneLookupTableReady(CameraSceneLookupTable cameraSceneLookupTable)
	{
		lookupTable = cameraSceneLookupTable;
		Debug.LogError("CAMERA SCENE LOOKUP TABLE WAS FOUND BY ATTACK SEQUENCE DOMAIN");
		Debug.Log("camera scene lookup table null? " + (cameraSceneLookupTable == null));
		Debug.Log("camera stable transform null? " + (cameraSceneLookupTable.StableCameraTransform == null));
		_systems = null;
		_systems = new AttackAnimatronicExternalSystems();
		_systems.CameraController = cameraSceneLookupTable.CameraController;
		_systems.CameraStableTransform = cameraSceneLookupTable.StableCameraTransform;
		Debug.LogWarning("Making systems. CameraStableTransform null? " + (cameraSceneLookupTable.StableCameraTransform == null));
		_systems.Encounter = _encounter;
		_systems.AttackStatic = _attackStatic;
		_systems.AttackDisruption = _attackDisruption;
		_systems.AttackSurge = _attackSurge;
		_systems.VisibilityAlterEffect = _visibilityAlterEffect;
		_systems.DropsObjectsMechanic = _dropsObjectsMechanic;
		_systems.HaywireFxController = cameraSceneLookupTable.HaywireFxController;
		_systems.IntroScreen = _introScreen;
		_systems.SubEntityMechanic = _subEntityMechanic;
		_systems.HaywireIndicator = _haywireIndicator;
		_systems.Battery = _cameraEquipmentDomain.Battery;
		_systems.Flashlight = _cameraEquipmentDomain.Flashlight;
		_systems.Mask = _cameraEquipmentDomain.Mask;
		_systems.Shocker = _cameraEquipmentDomain.Shocker;
		if (_systems.Shocker == null)
		{
			Debug.LogError("Shocker is null from camera equipment domain");
		}
		_systems.NoiseMechanic = _noiseMechanic;
		_systems.AssetCacheAccess = _gameAssetManagementDomain.AssetCacheAccess;
		_systems.AudioPlayer = _audioPlayer;
		_attackStatic.Setup(cameraSceneLookupTable.ModifiedGlitchShader);
		_attackDisruption.Setup(cameraSceneLookupTable.DisruptionFxController, cameraSceneLookupTable.MinireenaCamera, _systems);
		_attackSurge.Setup(_systems);
		_visibilityAlterEffect.Setup(_systems);
		_introScreen.Setup(_systems);
		_subEntityMechanic.Setup(_systems, cameraSceneLookupTable.ModifiedGlitchShader);
		_haywireIndicator.Setup(_systems);
		_dropsObjectsMechanic.Setup(cameraSceneLookupTable.DroppedObjectsVisualsParent, cameraSceneLookupTable.CameraController, _systems, OnAttackUIUpdated);
		_animatronicSpawner.Setup(_systems);
		_animatronicDestroyer.Setup(_animatronicSpawner, _animatronic3DDomain);
		_encounter.Setup(_animatronicSpawner, _animatronicDestroyer, shocker: _cameraEquipmentDomain.Shocker, gameDisplayChanger: _gameDisplayChanger, rewardDispatcher: _rewardDispatcher);
		_noiseMechanic.Setup(cameraSceneLookupTable.StableCameraTransform);
		_shakeDetector.SetTransform(cameraSceneLookupTable.StableCameraTransform);
	}

	public void Teardown()
	{
		_masterEventExposer.remove_GameDisplayChange(GameDisplayOrtonChange);
		_masterEventExposer.remove_StartAttackEncounter(SetEncounter);
		_masterEventExposer.remove_StartAttackScavengingEncounter(SetScavengingEncounter);
		_systems = null;
		if (_rewardDispatcher != null)
		{
			_rewardDispatcher.Teardown();
		}
		_rewardDispatcher = null;
		if (_dropsObjectsMechanic != null)
		{
			_dropsObjectsMechanic.Teardown();
		}
		_dropsObjectsMechanic = null;
		if (_noiseMechanic != null)
		{
			_noiseMechanic.Teardown();
		}
		_noiseMechanic = null;
		if (_visibilityAlterEffect != null)
		{
			_visibilityAlterEffect.Teardown();
		}
		_visibilityAlterEffect = null;
		if (_introScreen != null)
		{
			_introScreen.Teardown();
		}
		_introScreen = null;
		if (_subEntityMechanic != null)
		{
			_subEntityMechanic.TearDown();
		}
		_subEntityMechanic = null;
		if (_haywireIndicator != null)
		{
			_haywireIndicator.TearDown();
		}
		_haywireIndicator = null;
		if (_attackSurge != null)
		{
			_attackSurge.Teardown();
		}
		_attackSurge = null;
		if (_attackDisruption != null)
		{
			_attackDisruption.Teardown();
		}
		_attackDisruption = null;
		if (_encounter != null)
		{
			_encounter.Teardown();
		}
		_encounter = null;
		_animatronicSpawner.Teardown();
		_animatronicSpawner = null;
		_shakeDetector = null;
		if (_attackStatic != null)
		{
			_attackStatic.Teardown();
		}
		_attackStatic = null;
		_animatronicDestroyer.Teardown();
		_animatronicDestroyer = null;
		_sceneLookupTableAccess = null;
		_cameraFx = null;
		_itemDefinitionDomain = null;
		_animatronicEntityDomain = null;
		_cameraEquipmentDomain = null;
		_lootDomain = null;
	}

	public void Update()
	{
		if (_attackStatic != null)
		{
			_attackStatic.Update();
		}
		if (_shakeDetector != null)
		{
			_shakeDetector.Update();
		}
		if (_attackDisruption != null)
		{
			_attackDisruption.Update();
		}
		if (_attackSurge != null)
		{
			_attackSurge.Update();
		}
		if (_visibilityAlterEffect != null)
		{
			_visibilityAlterEffect.Update();
		}
		if (_subEntityMechanic != null)
		{
			_subEntityMechanic.Update();
		}
		if (_haywireIndicator != null)
		{
			_haywireIndicator.Update();
		}
		if (_dropsObjectsMechanic != null)
		{
			_dropsObjectsMechanic.Update();
		}
		if (_noiseMechanic != null)
		{
			_noiseMechanic.Update();
		}
	}

	public void OnApplicationQuit()
	{
		if (_encounter != null)
		{
			_encounter.OnApplicationQuit();
		}
	}
}
