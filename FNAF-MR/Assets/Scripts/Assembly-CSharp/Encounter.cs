using System.Collections.Generic;
using UnityEngine;

public class Encounter : IEncounter
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

	private GameDisplayChanger _gameDisplayChanger;

	private int _currentStreak;

	private int _bestStreak;

	private int _currentRemnant;

	private bool _leftEncounter;

	private bool addedCallbacks;

	public Encounter(EventExposer masterEventExposer)
	{
		_masterEventExposer = masterEventExposer;
	}

	public void Setup(AttackSpawner spawner, AttackDestroyer destroyer, RewardDispatcher rewardDispatcher, IShocker shocker, GameDisplayChanger gameDisplayChanger)
	{
		Debug.Log("encounter setup is called");
		_spawner = spawner;
		_destroyer = destroyer;
		_shocker = shocker;
		_rewardDispatcher = rewardDispatcher;
		_gameDisplayChanger = gameDisplayChanger;
		if (!addedCallbacks)
		{
			addedCallbacks = true;
			_spawner.OnAnimatronicSpawned += AnimatronicSpawned;
			_destroyer.OnAnimatronicAboutToBeDestroyed += AnimatronicAboutToBeDestroyed;
			_masterEventExposer.add_GameDisplayChange(GameDisplayChanged);
			_masterEventExposer.add_StreakDataUpdated(StreakDataUpdated);
			_masterEventExposer.add_RewardsFlowCompleted(RewardsFlowCompleted);
		}
	}

	public void Teardown()
	{
		_masterEventExposer.remove_RewardsFlowCompleted(RewardsFlowCompleted);
		_masterEventExposer.remove_StreakDataUpdated(StreakDataUpdated);
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
		_gameDisplayChanger = null;
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
		PlayerPrefs.SetString("FORCE_LOSE_BATTLE", value);
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

	public bool IsTutorialEncounter(EncounterType type)
	{
		return type - 1 < EncounterType.TutorialAutoWin;
	}

	public bool IsInProgress()
	{
		if (_animatronic == null)
		{
			return _isInRewardsSequence;
		}
		return true;
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
			return null;
		}
		if (IsPlayingOutro())
		{
			return null;
		}
		if (_isInRewardsSequence)
		{
			return null;
		}
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
		_masterEventExposer.OnEncounterAnimatronicInitialized(_animatronic.CpuId);
	}

	public void OnChargeStarted(float angleFromCamera, float fov)
	{
		_ = fov * 0.5f;
	}

	public void EncounterWon()
	{
		if (_animatronic == null)
		{
			Debug.LogError("EncounterWonCannot mark encounter won. Encounter already ending");
		}
		else if (!_awaitingUiTrigger && !_isInRewardsSequence)
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
		else if (!_awaitingUiTrigger && !_isInRewardsSequence && !_isInRewardsSequence)
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
			OldCurrentStreak = _currentStreak,
			OldBestStreak = _bestStreak,
			CurrentRemnant = _currentRemnant
		};
		if (!result.PlayerDidWin)
		{
			result.NewCurrentStreak = 0;
			result.NewBestStreak = Mathf.Max(result.OldBestStreak, result.OldBestStreak);
		}
		else
		{
			result.NewCurrentStreak = result.OldCurrentStreak + 1;
			result.NewBestStreak = Mathf.Max(result.NewCurrentStreak, result.OldBestStreak);
		}
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
		_masterEventExposer.OnAttackEncounterStarted(animatronic.EncounterType);
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
		if (data.currentDisplay == GameDisplayData.DisplayType.camera)
		{
			_ = _animatronic;
		}
		else if (_animatronic != null)
		{
			_animatronic.OffscreenLossTriggered();
		}
	}

	private void StreakDataUpdated(StreakData data)
	{
		_currentStreak = data.currentStreak;
		_bestStreak = data.bestStreak;
	}

	private void PlayerCurrencyRefreshed(Dictionary<string, int> currencies)
	{
		_currentRemnant = currencies["ESSENCE"];
	}

	private void RecordRewardsAnalytics()
	{
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
		_masterEventExposer.OnAttackEncounterEnded();
	}
}
