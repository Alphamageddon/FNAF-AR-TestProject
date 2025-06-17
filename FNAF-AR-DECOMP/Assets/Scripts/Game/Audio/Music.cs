using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Music
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GameMode = "Game_Mode";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GameMood = "Game_Mood";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _soundBankLoaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _lastDisplayType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.Music.ModalDisplayTypes _modalDisplayType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _wasReset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldSetScaryMood;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _encounterActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _remnantActive;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameDisplayChanged(TheGame.GameDisplayData args)
        {
            this.SetGameMode(displayType:  args.currentDisplay);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartMusic()
        {
            string val_2;
            if(this._shouldSetScaryMood != false)
            {
                    val_2 = "Scary";
            }
            else
            {
                    val_2 = "Happy";
            }
            
            this.SetGameMoodState(state:  val_2);
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  53, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnToPreviousState()
        {
            this._modalDisplayType = 0;
            this.SetGameMode(displayType:  this._lastDisplayType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetGameModeForInbox()
        {
            this.SetGameModeForModal(modalType:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetGameModeForStore()
        {
            this.SetGameModeForModal(modalType:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetGameModeForReward()
        {
            this.SetGameModeForModal(modalType:  4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetMusicStateForFTUE(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)
        {
            if(tutorialUIEvent > 8)
            {
                    return;
            }
            
            var val_11 = 52947256 + (tutorialUIEvent) << 2;
            val_11 = val_11 + 52947256;
            goto (52947256 + (tutorialUIEvent) << 2 + 52947256);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BeginStarParticleAudio(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)
        {
            if((tutorialUIEvent | 4) != 4)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  79, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetSoftGlitches(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)
        {
            Game.Audio.IAudioPlayer val_3;
            var val_6;
            if(tutorialUIEvent == 6)
            {
                goto label_1;
            }
            
            if(tutorialUIEvent != 4)
            {
                    return;
            }
            
            val_3 = this._audioPlayer;
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto label_7;
            label_1:
            val_3 = this._audioPlayer;
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_12;
            label_7:
            val_6 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            goto label_13;
            label_12:
            val_6 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            label_13:
            val_3.RaiseGameEventForMode(name:  84, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BeginSubGimmickVO(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)
        {
            Game.Audio.IAudioPlayer val_4;
            var val_8;
            if(tutorialUIEvent == 6)
            {
                goto label_1;
            }
            
            if(tutorialUIEvent == 5)
            {
                goto label_2;
            }
            
            if(tutorialUIEvent != 4)
            {
                    return;
            }
            
            val_4 = this._audioPlayer;
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_8;
            label_1:
            val_4 = this._audioPlayer;
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_13;
            label_2:
            val_4 = this._audioPlayer;
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_18;
            label_8:
            val_8 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            goto label_20;
            label_13:
            val_8 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            goto label_20;
            label_18:
            val_8 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            label_20:
            val_4.RaiseGameEventForMode(name:  73, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DetermineInitialMood(Systems.Guide.FeatureFlags.FeatureFlagMap flags)
        {
            this._shouldSetScaryMood = flags.IsScaryMoodAllowed();
            this._masterEventExposer.remove_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void Game.Audio.Music::DetermineInitialMood(Systems.Guide.FeatureFlags.FeatureFlagMap flags)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType encounterType)
        {
            this._encounterActive = true;
            this.SetCameraGameMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackEncounterEnded()
        {
            this._encounterActive = false;
            this.SetCameraGameMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemnantCollectionAudioStarted()
        {
            this._remnantActive = true;
            this.SetCameraGameMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemnantCollectionAudioEnded()
        {
            this._remnantActive = false;
            this.SetCameraGameMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetGameModeForModal(Game.Audio.Music.ModalDisplayTypes modalType)
        {
            this._modalDisplayType = modalType;
            if(this._soundBankLoaded == false)
            {
                    return;
            }
            
            if((modalType - 1) > 3)
            {
                    return;
            }
            
            var val_7 = 52947240 + ((modalType - 1)) << 2;
            val_7 = val_7 + 52947240;
            goto (52947240 + ((modalType - 1)) << 2 + 52947240);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetGameMode(TheGame.GameDisplayData.DisplayType displayType)
        {
            this._lastDisplayType = displayType;
            if(this._soundBankLoaded == false)
            {
                    return;
            }
            
            if(displayType > 7)
            {
                    return;
            }
            
            var val_1 = 52947208 + (displayType) << 2;
            val_1 = val_1 + 52947208;
            goto (52947208 + (displayType) << 2 + 52947208);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCameraGameMode()
        {
            string val_1;
            if(this._lastDisplayType != 7)
            {
                    if(this._lastDisplayType != 1)
            {
                    return;
            }
            
            }
            
            if(this._modalDisplayType != 0)
            {
                    return;
            }
            
            if(this._encounterActive != false)
            {
                    val_1 = "Encounter";
            }
            else
            {
                    if(this._remnantActive != false)
            {
                    val_1 = "Remnant";
            }
            else
            {
                    val_1 = "Camera";
            }
            
            }
            
            this.SetGameModeState(state:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadSuccess(string soundBankName)
        {
            this._soundBankLoaded = true;
            if(this._wasReset == false)
            {
                    return;
            }
            
            this._wasReset = false;
            this.StartMusic();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadFailure(string soundBankName)
        {
            null = null;
            ConsoleLogger.LogError(className:  Game.Audio.Music.GameMood, functionName:  "LoadFailure", logString:  "Failed to load SoundBank \'" + soundBankName + "\'. Cannot play ambience");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetGameModeState(string state)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.SetState(group:  "Game_Mode", state:  state);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetGameMoodState(string state)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.SetState(group:  "Game_Mood", state:  state);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Music(Master.EventExposer masterEventExposer)
        {
            this._lastDisplayType = 6;
            this._masterEventExposer = masterEventExposer;
            masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.Audio.Music::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._masterEventExposer.add_StartMusic(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::StartMusic()));
            this._masterEventExposer.add_InboxOpened(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::SetGameModeForInbox()));
            this._masterEventExposer.add_InboxClosed(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::ReturnToPreviousState()));
            this._masterEventExposer.add_StoreOpened(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::SetGameModeForStore()));
            this._masterEventExposer.add_StoreClosed(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::ReturnToPreviousState()));
            this._masterEventExposer.add_RewardDialogOpened(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::SetGameModeForReward()));
            this._masterEventExposer.add_RewardDialogClosed(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::ReturnToPreviousState()));
            this._masterEventExposer.add_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.Music::SetMusicStateForFTUE(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.add_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.Music::BeginStarParticleAudio(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.add_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.Music::BeginSubGimmickVO(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.add_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.Music::SetSoftGlitches(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.add_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void Game.Audio.Music::DetermineInitialMood(Systems.Guide.FeatureFlags.FeatureFlagMap flags)));
            this._masterEventExposer.add_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  System.Void Game.Audio.Music::AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType encounterType)));
            this._masterEventExposer.add_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::AttackEncounterEnded()));
            this._masterEventExposer.add_RemnantCollectionAudioStarted(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::RemnantCollectionAudioStarted()));
            this._masterEventExposer.add_RemnantCollectionAudioEnded(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::RemnantCollectionAudioEnded()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.Audio.IAudioPlayer audioPlayer)
        {
            IntPtr val_7;
            this._audioPlayer = audioPlayer;
            var val_7 = 0;
            val_7 = val_7 + 1;
            Systems.Audio.Wwise.ISoundBankLoader val_2 = audioPlayer.SoundBankLoader;
            Systems.Audio.Wwise.SoundBankRequest val_3 = new Systems.Audio.Wwise.SoundBankRequest();
            .SoundBankName = "Music";
            .Success = new System.Action<System.String>(object:  this, method:  System.Void Game.Audio.Music::LoadSuccess(string soundBankName));
            System.Action<System.String> val_5 = null;
            val_7 = System.Void Game.Audio.Music::LoadFailure(string soundBankName);
            val_5 = new System.Action<System.String>(object:  this, method:  val_7);
            .Failure = val_5;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_7 = 0;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_2, typeof(0x31262DC), slot: 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this._soundBankLoaded = false;
            this._wasReset = true;
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  54, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._audioPlayer = 0;
            this._masterEventExposer.remove_RemnantCollectionAudioEnded(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::RemnantCollectionAudioEnded()));
            this._masterEventExposer.remove_RemnantCollectionAudioStarted(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::RemnantCollectionAudioStarted()));
            this._masterEventExposer.remove_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::AttackEncounterEnded()));
            this._masterEventExposer.remove_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  System.Void Game.Audio.Music::AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType encounterType)));
            this._masterEventExposer.remove_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void Game.Audio.Music::DetermineInitialMood(Systems.Guide.FeatureFlags.FeatureFlagMap flags)));
            this._masterEventExposer.remove_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.Music::SetMusicStateForFTUE(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.remove_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.Music::BeginStarParticleAudio(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.remove_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.Music::BeginSubGimmickVO(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.remove_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.Music::SetSoftGlitches(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.remove_RewardDialogClosed(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::ReturnToPreviousState()));
            this._masterEventExposer.remove_RewardDialogOpened(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::SetGameModeForReward()));
            this._masterEventExposer.remove_StoreClosed(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::ReturnToPreviousState()));
            this._masterEventExposer.remove_StoreOpened(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::SetGameModeForStore()));
            this._masterEventExposer.remove_InboxClosed(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::ReturnToPreviousState()));
            this._masterEventExposer.remove_InboxOpened(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::SetGameModeForInbox()));
            this._masterEventExposer.remove_StartMusic(value:  new System.Action(object:  this, method:  System.Void Game.Audio.Music::StartMusic()));
            this._masterEventExposer.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.Audio.Music::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._masterEventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Music()
        {
            Game.Audio.Music.GameMood = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
