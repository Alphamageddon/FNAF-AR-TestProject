using UnityEngine;

public class Music
{
	private enum ModalDisplayTypes
	{
		none = 0,
		inbox = 1,
		store = 2,
		ad = 3,
		reward = 4
	}

	private const string GameMode = "Game_Mode";

	private const string GameMood = "Game_Mood";

	private EventExposer _masterEventExposer;

	private AudioPlayer _audioPlayer;

	private bool _soundBankLoaded;

	private GameDisplayData _displayData;

	private GameDisplayData.DisplayType _lastDisplayType;

	private ModalDisplayTypes _modalDisplayType;

	private bool _wasReset = true;

	private bool _shouldSetScaryMood;

	private bool _encounterActive;

	private bool _remnantActive;

	private bool _scavengingEncounterActive;

	private void GameDisplayChanged(GameDisplayData displayData)
	{
		_displayData = displayData;
		SetGameMode(displayData.currentDisplay);
		if (_soundBankLoaded && _wasReset)
		{
			StartMusic();
			_wasReset = false;
		}
	}

	private void StartMusic()
	{
		if (_shouldSetScaryMood)
		{
			SetGameMoodState("Scary");
		}
		else
		{
			SetGameMoodState("Happy");
		}
		_audioPlayer.RaiseGameEventForMode(AudioEventName.MusicStart, AudioMode.Global);
	}

	private void ReturnToPreviousState()
	{
		_modalDisplayType = ModalDisplayTypes.none;
		SetGameMode(_lastDisplayType);
	}

	private void SetGameModeForInbox()
	{
		SetGameModeForModal(ModalDisplayTypes.inbox);
	}

	private void SetGameModeForStore()
	{
		SetGameModeForModal(ModalDisplayTypes.store);
	}

	private void SetGameModeForReward()
	{
		SetGameModeForModal(ModalDisplayTypes.reward);
	}

	private void AttackEncounterStarted(EncounterType encounterType)
	{
		_encounterActive = true;
		SetCameraGameMode();
	}

	private void AttackEncounterEnded()
	{
		_encounterActive = false;
		SetCameraGameMode();
	}

	private void AttackScavengingEncounterStarted(EncounterType encounterType)
	{
		_scavengingEncounterActive = true;
		SetCameraGameMode();
	}

	private void AttackScavengingEncounterEnded()
	{
		_scavengingEncounterActive = false;
		SetCameraGameMode();
	}

	private void RemnantCollectionAudioStarted()
	{
		_remnantActive = true;
		SetCameraGameMode();
	}

	private void RemnantCollectionAudioEnded()
	{
		_remnantActive = false;
		SetCameraGameMode();
	}

	private void SetGameModeForModal(ModalDisplayTypes modalType)
	{
		_modalDisplayType = modalType;
		if (_soundBankLoaded)
		{
			switch (modalType)
			{
			case ModalDisplayTypes.inbox:
				SetGameModeState("Inbox");
				break;
			case ModalDisplayTypes.store:
				SetGameModeState("Store");
				break;
			case ModalDisplayTypes.ad:
				SetGameModeState("Ad");
				break;
			case ModalDisplayTypes.reward:
				SetGameModeState("Reward");
				break;
			case ModalDisplayTypes.none:
				break;
			}
		}
	}

	private void SetGameMode(GameDisplayData.DisplayType displayType)
	{
		_lastDisplayType = displayType;
		if (_soundBankLoaded)
		{
			switch (_lastDisplayType)
			{
			case GameDisplayData.DisplayType.map:
				SetGameModeState("Map");
				break;
			case GameDisplayData.DisplayType.camera:
				SetCameraGameMode();
				break;
			case GameDisplayData.DisplayType.scavengingui:
				SetCameraGameMode();
				break;
			}
		}
	}

	private void SetCameraGameMode()
	{
		if ((_lastDisplayType == GameDisplayData.DisplayType.results || _lastDisplayType == GameDisplayData.DisplayType.camera || _lastDisplayType == GameDisplayData.DisplayType.scavengingui) && _modalDisplayType == ModalDisplayTypes.none)
		{
			if (_scavengingEncounterActive)
			{
				SetGameModeState("Scavenging");
			}
			else if (_encounterActive)
			{
				SetGameModeState("Encounter");
			}
			else
			{
				SetGameModeState(_remnantActive ? "Remnant" : "Camera");
			}
		}
	}

	private void LoadSuccess(string soundBankName)
	{
		_soundBankLoaded = true;
	}

	private void LoadFailure(string soundBankName)
	{
		Debug.LogError("Music.GameMood LoadFailure - Failed to load SoundBank '" + soundBankName + "'. Cannot play music");
	}

	private void SetGameModeState(string state)
	{
		_audioPlayer.SetState("Game_Mode", state);
	}

	private void SetGameMoodState(string state)
	{
		_audioPlayer.SetState("Game_Mood", state);
	}

	public Music(EventExposer masterEventExposer)
	{
		_lastDisplayType = GameDisplayData.DisplayType.splash;
		_masterEventExposer = masterEventExposer;
		_masterEventExposer.add_GameDisplayChange(GameDisplayChanged);
		_masterEventExposer.add_StoreOpened(SetGameModeForStore);
		_masterEventExposer.add_StoreClosed(ReturnToPreviousState);
		_masterEventExposer.add_RewardDialogOpened(SetGameModeForReward);
		_masterEventExposer.add_RewardDialogClosed(ReturnToPreviousState);
		_masterEventExposer.add_AttackEncounterStarted(AttackEncounterStarted);
		_masterEventExposer.add_AttackScavengingEncounterStarted(AttackScavengingEncounterStarted);
		_masterEventExposer.add_AttackEncounterEnded(AttackEncounterEnded);
		_masterEventExposer.add_AttackScavengingEncounterEnded(AttackScavengingEncounterEnded);
	}

	public void Setup(AudioPlayer audioPlayer)
	{
		_audioPlayer = audioPlayer;
		_audioPlayer.GetSoundBankLoaderAsync(StartSoundEffects);
	}

	private void StartSoundEffects(SoundBankLoader loader)
	{
		SoundBankRequest soundBankRequest = new SoundBankRequest();
		soundBankRequest.SoundBankName = "Music";
		soundBankRequest.Success = LoadSuccess;
		soundBankRequest.Failure = LoadFailure;
		loader.RequestSoundBank(soundBankRequest);
	}

	public void Reset()
	{
		_soundBankLoaded = false;
		_wasReset = true;
		_audioPlayer.RaiseGameEventForMode(AudioEventName.MusicStop, AudioMode.Global);
	}

	public void Teardown()
	{
		_audioPlayer = null;
		_masterEventExposer.remove_AttackEncounterEnded(AttackEncounterEnded);
		_masterEventExposer.remove_AttackScavengingEncounterEnded(AttackScavengingEncounterEnded);
		_masterEventExposer.remove_AttackEncounterStarted(AttackEncounterStarted);
		_masterEventExposer.remove_AttackScavengingEncounterStarted(AttackScavengingEncounterStarted);
		_masterEventExposer.remove_RewardDialogClosed(ReturnToPreviousState);
		_masterEventExposer.remove_RewardDialogOpened(SetGameModeForReward);
		_masterEventExposer.remove_StoreClosed(ReturnToPreviousState);
		_masterEventExposer.remove_StoreOpened(SetGameModeForStore);
		_masterEventExposer.remove_GameDisplayChange(GameDisplayChanged);
		_masterEventExposer = null;
	}
}
