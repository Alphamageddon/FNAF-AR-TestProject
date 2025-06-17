using UnityEngine;

public class ScavengingEncounter : IEncounter
{
	private EventExposer _masterEventExposer;

	private AttackSpawner _spawner;

	private AttackDestroyer _destroyer;

	private IShocker _shocker;

	private AttackAnimatronic _animatronic;

	private bool _encounterDefeated;

	private bool _usedJammer;

	private bool _awaitingUiTrigger;

	private bool _isInRewardsSequence;

	private RewardDispatcher _rewardDispatcher;

	private bool _leftEncounter;

	private bool addedCallbacks;

	public ScavengingEncounter(EventExposer masterEventExposer)
	{
		_masterEventExposer = masterEventExposer;
	}

	public void Setup(AttackSpawner spawner, AttackDestroyer destroyer, RewardDispatcher rewardDispatcher, IShocker shocker, GameDisplayChanger gameDisplayChanger)
	{
		Debug.Log("scavenge encounter setup is called");
		_spawner = spawner;
		_destroyer = destroyer;
		_shocker = shocker;
		_rewardDispatcher = rewardDispatcher;
		if (!addedCallbacks)
		{
			addedCallbacks = true;
			_spawner.OnAnimatronicSpawned += AnimatronicSpawned;
			_destroyer.OnAnimatronicAboutToBeDestroyed += AnimatronicAboutToBeDestroyed;
			_masterEventExposer.add_GameDisplayChange(GameDisplayChanged);
			_masterEventExposer.add_RewardsFlowCompleted(RewardsFlowCompleted);
		}
	}

	public void Teardown()
	{
		_masterEventExposer.remove_RewardsFlowCompleted(RewardsFlowCompleted);
		_masterEventExposer.remove_GameDisplayChange(GameDisplayChanged);
		if (_destroyer != null)
		{
			_destroyer.OnAnimatronicAboutToBeDestroyed -= AnimatronicAboutToBeDestroyed;
		}
		if (_spawner != null)
		{
			_spawner.OnAnimatronicSpawned -= AnimatronicSpawned;
		}
		_spawner = null;
		_destroyer = null;
		_rewardDispatcher = null;
		if (_animatronic != null)
		{
			_animatronic.RequestDestruction();
		}
		_animatronic = null;
		_masterEventExposer = null;
	}

	public void OnApplicationQuit()
	{
		string value;
		if (_animatronic != null)
		{
			value = _animatronic.EntityId;
		}
		else
		{
			if (!_isInRewardsSequence)
			{
				return;
			}
			value = null;
		}
		PlayerPrefs.SetString("FORCE_LOSE_SCAVENGE_BATTLE", value);
	}

	public string GetCPUId()
	{
		return _animatronic.CpuId;
	}

	public long GetStartTime()
	{
		return _animatronic.EncounterStartTime;
	}

	public string GetEntityId()
	{
		if (_animatronic != null)
		{
			return _animatronic.EntityId;
		}
		return "AnimatronicIsNull";
	}

	public bool IsInProgress()
	{
		if (_animatronic != null)
		{
			return true;
		}
		return _isInRewardsSequence;
	}

	public bool IsPlayingOutro()
	{
		return _awaitingUiTrigger;
	}

	public bool CanReturnToMap()
	{
		return true;
	}

	public AttackUIData GetEncounterUIConfig()
	{
		if (_animatronic == null)
		{
			Debug.LogError("ASKED FOR UI CONFIG BEFORE ATTACK ANIMATRONIC EXISTS");
			return null;
		}
		if (IsPlayingOutro())
		{
			Debug.LogError("ASKED FOR UI CONFIG WHILE IN OUTRO");
			return null;
		}
		if (_isInRewardsSequence)
		{
			Debug.LogError("ASKED FOR UI CONFIG WHILE IN REWARD SEQUENCE");
			return null;
		}
		Debug.LogError("GOT ATTACK UI DATA BITCH");
		return _animatronic.AttackUIData;
	}

	public DropsObjectsMechanicViewModel GetEncounterDropsObjectsViewModel()
	{
		return _animatronic.DropsObjectsMechanicViewModel;
	}

	public void ShockerActivated(bool isDisruptionFullyActive)
	{
		_shocker.Activate(_animatronic.HitByShocker(), isDisruptionFullyActive);
	}

	public void FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)
	{
	}

	public void EncounterAnimatronicInitialized()
	{
		_masterEventExposer.OnScavengingEncounterAnimatronicInitialized(_animatronic.CpuId);
	}

	public void OnChargeStarted(float angleFromCamera, float fov)
	{
	}

	public void EncounterWon()
	{
		if (_animatronic == null)
		{
			Debug.LogError("EncounterWonCannot mark encounter won. Encounter already ending");
		}
		else if (!_awaitingUiTrigger && !_isInRewardsSequence && !_isInRewardsSequence)
		{
			_encounterDefeated = true;
			_awaitingUiTrigger = true;
		}
		else
		{
			Debug.LogError("EncounterWonCannot mark encounter won. Encounter already ending");
		}
	}

	public void EncounterLost()
	{
		if (_animatronic == null)
		{
			Debug.Log("EncounterLostCannot mark encounter lost. Encounter already ending");
		}
		else if (!_awaitingUiTrigger && !_isInRewardsSequence)
		{
			_encounterDefeated = false;
			_awaitingUiTrigger = true;
		}
		else
		{
			Debug.Log("EncounterLostCannot mark encounter lost. Encounter already ending");
		}
	}

	public void UsedJammer()
	{
		_usedJammer = true;
		_animatronic.OffscreenLossTriggered();
	}

	public void LeaveEncounter()
	{
		_leftEncounter = true;
		_animatronic.OffscreenLossTriggered();
	}

	public void SetDeathText(string text)
	{
		_animatronic.DeathText = text;
	}

	public void ReadyForUi()
	{
		if (_animatronic == null)
		{
			Debug.LogError("Encounter ReadyForUi - Cannot mark encounter ready for UI. No encounter in progress");
			return;
		}
		if (!_awaitingUiTrigger)
		{
			Debug.LogError("Encounter ReadyForUi - Cannot mark encounter ready for UI. Not awaiting UI trigger");
			return;
		}
		if (_isInRewardsSequence)
		{
			Debug.LogError("Encounter ReadyForUi - Cannot mark encounter ready for UI. UI already showing");
			return;
		}
		EncounterResult result = new EncounterResult
		{
			EncounterType = _animatronic.EncounterType,
			EntityId = _animatronic.EntityId,
			CpuId = _animatronic.CpuId,
			PlushSuitId = _animatronic.PlushSuitId,
			AnimatronicAudioId = _animatronic.CpuAudioId,
			DeathText = _animatronic.DeathText,
			PlayerDidWin = _encounterDefeated,
			OldCurrentStreak = 0,
			OldBestStreak = 0,
			NewCurrentStreak = 0,
			NewBestStreak = 0,
			CurrentRemnant = 0
		};
		Debug.LogError("requesting rewards win or loss");
		_rewardDispatcher.RequestRewards(_animatronic.Entity, _encounterDefeated, delegate
		{
			OnRewardsReceived(result);
		}, _usedJammer, _leftEncounter);
		_masterEventExposer.OnAttackSequenceEnded();
		_usedJammer = false;
		_leftEncounter = false;
	}

	private void AnimatronicSpawned(AttackAnimatronic animatronic)
	{
		_animatronic = animatronic;
		_animatronic.EnteredCameraMode();
		if (animatronic == null)
		{
			Debug.LogError("animatronic is null");
		}
		_masterEventExposer.OnAttackScavengingEncounterStarted(animatronic.EncounterType);
	}

	private void AnimatronicAboutToBeDestroyed(AttackAnimatronicDestroyedPayload animatronicDestroyedPayload)
	{
		if (_animatronic != null && !(_animatronic.EntityId != animatronicDestroyedPayload.EntityId))
		{
			_animatronic = null;
		}
	}

	private void GameDisplayChanged(GameDisplayData data)
	{
		if (_animatronic != null && data.currentDisplay != GameDisplayData.DisplayType.scavengingui)
		{
			_animatronic.OffscreenLossTriggered();
		}
	}

	private void OnRewardsReceived(EncounterResult result)
	{
		if (_usedJammer)
		{
			FinalizeEncounter();
			return;
		}
		_isInRewardsSequence = true;
		_masterEventExposer.add_RewardsFlowCompleted(RewardsFlowCompleted);
		_masterEventExposer.OnAttackSequenceReadyForUi(result);
	}

	private void RewardsFlowCompleted()
	{
		_masterEventExposer.remove_RewardsFlowCompleted(RewardsFlowCompleted);
		FinalizeEncounter();
	}

	private void FinalizeEncounter()
	{
		_animatronic = null;
		_awaitingUiTrigger = false;
		_isInRewardsSequence = false;
		Debug.Log("Telling game the encounter is OVER!");
		_masterEventExposer.OnAttackScavengingEncounterEnded();
	}
}
