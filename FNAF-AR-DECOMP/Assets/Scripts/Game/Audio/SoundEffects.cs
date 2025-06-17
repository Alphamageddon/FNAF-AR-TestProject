using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SoundEffects
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isStaticPlaying;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isAmbGlitchesPlaying;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MaskState = "Mask";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MaskOff = "MaskOff";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MaskOn = "MaskOn";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackDisruptionStateChanged(bool isDisruptionActive, Game.AttackSequence.DisruptionMechanic.DisruptionStyle style)
        {
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = style});
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._audioPlayer.RaiseGameEventForModeWithOverride(name:  ((isDisruptionActive & true) != 0) ? (31 + 1) : 31, overridePrefix:  style.ToString(), mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackSurgeStateChanged(bool isSurgeActive, Game.ItemDefinition.Data.DataDefinitions.SurgeData surgeSettings)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  ((isSurgeActive & true) != 0) ? (33 + 1) : 33, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ExtraBatteryStateChanged(Game.CameraEquipment.Battery.ExtraBatteryStateChange extraBatteryStateChange)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  (extraBatteryStateChange.IsExtraBatteryRunning == false) ? (35 + 1) : 35, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)
        {
            if(shouldPlayAudio == false)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  (isFlashlightOn != true) ? (39 + 1) : 39, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FlashlightCooldownComplete()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  38, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FlashlightTriedToActivate()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  37, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MaskForcedOff()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  41, mode:  2);
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._audioPlayer.SetState(group:  "Mask", state:  "MaskOff");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MaskStateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning)
        {
            var val_13;
            Game.Audio.IAudioPlayer val_14;
            var val_16;
            var val_20;
            var val_21;
            Game.Audio.IAudioPlayer val_22;
            var val_23;
            string val_25;
            string val_26;
            val_13 = isMaskTransitionBeginning;
            val_14 = this._audioPlayer;
            if(isMaskGoingOn == false)
            {
                goto label_2;
            }
            
            if(val_13 == false)
            {
                goto label_3;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_7;
            label_2:
            if(val_13 == false)
            {
                goto label_8;
            }
            
            var val_6 = 0;
            val_16 = 1152921505275252744;
            val_6 = val_6 + 1;
            val_16 = 1152921505275252760;
            goto label_12;
            label_3:
            var val_7 = 0;
            val_16 = 1152921505275252744;
            val_7 = val_7 + 1;
            val_16 = 1152921505275252760;
            goto label_16;
            label_8:
            var val_8 = 0;
            val_16 = 1152921505275252744;
            val_8 = val_8 + 1;
            goto label_20;
            label_7:
            val_20 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            goto label_21;
            label_12:
            val_21 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            val_14.RaiseGameEventForMode(name:  42, mode:  2);
            val_22 = this._audioPlayer;
            val_23 = null;
            val_25 = "Mask";
            val_26 = "MaskOff";
            var val_9 = 0;
            val_16 = 1152921505275252744;
            val_9 = val_9 + 1;
            val_16 = 1152921505275252760;
            goto label_31;
            label_16:
            val_21 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            val_14.RaiseGameEventForMode(name:  45, mode:  2);
            val_22 = this._audioPlayer;
            val_23 = null;
            val_25 = "Mask";
            val_26 = "MaskOn";
            var val_10 = 0;
            val_16 = 1152921505275252744;
            val_10 = val_10 + 1;
            val_16 = 1152921505275252760;
            label_31:
            val_14 = ???;
            val_13 = ???;
            val_22.SetState(group:  val_25, state:  val_26);
            return;
            label_20:
            val_20 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            label_21:
            val_14.RaiseGameEventForMode(name:  43, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShockerActivated(Game.CameraEquipment.Shocker.ShockerActivation shockerActivation)
        {
            Game.Audio.IAudioPlayer val_5;
            var val_7;
            Game.Audio.IAudioPlayer val_9;
            var val_11;
            var val_12;
            var val_13;
            var val_15;
            if(shockerActivation.OnCooldown == false)
            {
                goto label_2;
            }
            
            val_5 = this._audioPlayer;
            var val_3 = 0;
            val_7 = 1152921505275252744;
            val_3 = val_3 + 1;
            val_7 = 1152921505275252760;
            goto label_7;
            label_2:
            val_9 = this._audioPlayer;
            if(shockerActivation.NoBattery == false)
            {
                goto label_8;
            }
            
            var val_4 = 0;
            val_7 = 1152921505275252744;
            val_4 = val_4 + 1;
            val_7 = 1152921505275252760;
            goto label_13;
            label_7:
            val_11 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            val_12 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            goto label_14;
            label_8:
            var val_1 = (shockerActivation.DidHit == false) ? (46 + 1) : 46;
            var val_5 = 0;
            val_7 = 1152921505275252744;
            val_5 = val_5 + 1;
            goto label_20;
            label_13:
            val_11 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            val_12 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            label_14:
            label_20:
            val_13 = ???;
            val_15 = ???;
            val_9.RaiseGameEventForMode(name:  48, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShockerCooldownComplete()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  50, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StaticSettingsUpdated(Game.AttackSequence.Static.StaticSettings staticSettings)
        {
            if(this._isStaticPlaying == false)
            {
                goto label_1;
            }
            
            this.SetStaticStrengths(staticSettings:  staticSettings);
            if(staticSettings != null)
            {
                goto label_3;
            }
            
            goto label_3;
            label_1:
            if(staticSettings.StaticAudioStrength <= 0f)
            {
                goto label_5;
            }
            
            this.SetStaticStrengths(staticSettings:  staticSettings);
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto label_10;
            label_5:
            if(this._isStaticPlaying == false)
            {
                    return;
            }
            
            this.SetStaticStrengths(staticSettings:  staticSettings);
            label_3:
            if(staticSettings.StaticAudioStrength > 0f)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  52, mode:  2);
            this._isStaticPlaying = false;
            return;
            label_10:
            this._audioPlayer.RaiseGameEventForMode(name:  51, mode:  2);
            this._isStaticPlaying = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void NewAnimatronicSpawned()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  75, mode:  3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetStaticStrengths(Game.AttackSequence.Static.StaticSettings staticSettings)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.SetParameterForMode(name:  0, value:  UnityEngine.Mathf.Clamp(value:  staticSettings.StaticAudioStrength, min:  0f, max:  1f), mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AmbGlitchesBegin()
        {
            if(this._isAmbGlitchesPlaying == true)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  80, mode:  1);
            this._isAmbGlitchesPlaying = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AmbGlitchesEnd(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)
        {
            if(tutorialUIEvent != 3)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  81, mode:  1);
            this._isAmbGlitchesPlaying = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HardGlitchesBegin(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)
        {
            if(tutorialUIEvent != 6)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForMode(name:  82, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PurchaseRequestAudioInvoked(bool canAfford)
        {
            var val_5;
            if(canAfford == false)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto label_6;
            label_2:
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_10;
            label_6:
            val_5 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            goto label_11;
            label_10:
            val_5 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            label_11:
            this._audioPlayer.RaiseGameEventForMode(name:  86, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WorkshopModIconPressed(bool unlocked)
        {
            var val_5;
            if(unlocked == false)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto label_6;
            label_2:
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_10;
            label_6:
            val_5 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            goto label_11;
            label_10:
            val_5 = public System.Void Game.Audio.IAudioPlayer::RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode);
            label_11:
            this._audioPlayer.RaiseGameEventForMode(name:  88, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SoundEffects(Master.EventExposer masterEventExposer)
        {
            this._masterEventExposer = masterEventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.Audio.IAudioPlayer audioPlayer, bool localGameplay)
        {
            System.Action<System.String> val_12;
            IntPtr val_13;
            var val_16;
            System.Action<System.String> val_18;
            IntPtr val_19;
            this._audioPlayer = audioPlayer;
            var val_13 = 0;
            val_13 = val_13 + 1;
            .SoundBankName = "Shared_Initial";
            .Success = new System.Action<System.String>(object:  this, method:  System.Void Game.Audio.SoundEffects::StartSoundEffects(string soundBankName));
            System.Action<System.String> val_5 = null;
            val_12 = val_5;
            val_13 = System.Void Game.Audio.SoundEffects::LoadFailure(string soundBankName);
            val_5 = new System.Action<System.String>(object:  this, method:  val_13);
            .Failure = val_12;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_13 = 0;
            audioPlayer.SoundBankLoader.RequestSoundBank(request:  new Systems.Audio.Wwise.SoundBankRequest());
            if(localGameplay != false)
            {
                    return;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            .SoundBankName = "Shared";
            val_16 = null;
            val_16 = null;
            val_18 = SoundEffects.<>c.<>9__27_0;
            if(val_18 == null)
            {
                    System.Action<System.String> val_10 = null;
                val_18 = val_10;
                val_10 = new System.Action<System.String>(object:  SoundEffects.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SoundEffects.<>c::<Setup>b__27_0(string soundBankName));
                SoundEffects.<>c.<>9__27_0 = val_18;
            }
            
            .Success = val_18;
            System.Action<System.String> val_11 = null;
            val_19 = System.Void Game.Audio.SoundEffects::LoadFailure(string soundBankName);
            val_11 = new System.Action<System.String>(object:  this, method:  val_19);
            .Failure = val_11;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_19 = 0;
            this._audioPlayer.SoundBankLoader.RequestSoundBank(request:  new Systems.Audio.Wwise.SoundBankRequest());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartSoundEffects(string soundBankName)
        {
            this._masterEventExposer.add_HardGlitchesEnded(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::AmbGlitchesBegin()));
            this._masterEventExposer.add_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.SoundEffects::AmbGlitchesEnd(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.add_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.SoundEffects::HardGlitchesBegin(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.add_AttackDisruptionStateChanged(value:  new AttackDisruption.StateChanged(object:  this, method:  System.Void Game.Audio.SoundEffects::AttackDisruptionStateChanged(bool isDisruptionActive, Game.AttackSequence.DisruptionMechanic.DisruptionStyle style)));
            this._masterEventExposer.add_AttackSurgeStateChanged(value:  new AttackSurge.StateChanged(object:  this, method:  System.Void Game.Audio.SoundEffects::AttackSurgeStateChanged(bool isSurgeActive, Game.ItemDefinition.Data.DataDefinitions.SurgeData surgeSettings)));
            this._masterEventExposer.add_ExtraBatteryStateChanged(value:  new System.Action<Game.CameraEquipment.Battery.ExtraBatteryStateChange>(object:  this, method:  System.Void Game.Audio.SoundEffects::ExtraBatteryStateChanged(Game.CameraEquipment.Battery.ExtraBatteryStateChange extraBatteryStateChange)));
            mem[1152921525427101552] = this;
            mem[1152921525427101560] = System.Void Game.Audio.SoundEffects::FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio);
            mem[1152921525427101536] = System.Void Game.Audio.SoundEffects::FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio);
            this._masterEventExposer.add_FlashlightStateChanged(value:  new FlashlightState.StateChanged());
            this._masterEventExposer.add_FlashlightCooldownComplete(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::FlashlightCooldownComplete()));
            this._masterEventExposer.add_FlashlightTriedToActivate(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::FlashlightTriedToActivate()));
            this._masterEventExposer.add_MaskForcedOff(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::MaskForcedOff()));
            mem[1152921525427134320] = this;
            mem[1152921525427134328] = System.Void Game.Audio.SoundEffects::MaskStateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning);
            mem[1152921525427134304] = System.Void Game.Audio.SoundEffects::MaskStateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning);
            this._masterEventExposer.add_MaskStateChanged(value:  new MaskState.StateChanged());
            this._masterEventExposer.add_NewAnimatronicSpawned(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::NewAnimatronicSpawned()));
            this._masterEventExposer.add_ShockerActivated(value:  new System.Action<Game.CameraEquipment.Shocker.ShockerActivation>(object:  this, method:  System.Void Game.Audio.SoundEffects::ShockerActivated(Game.CameraEquipment.Shocker.ShockerActivation shockerActivation)));
            this._masterEventExposer.add_ShockerCooldownComplete(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::ShockerCooldownComplete()));
            this._masterEventExposer.add_StaticSettingsUpdated(value:  new System.Action<Game.AttackSequence.Static.StaticSettings>(object:  this, method:  System.Void Game.Audio.SoundEffects::StaticSettingsUpdated(Game.AttackSequence.Static.StaticSettings staticSettings)));
            this._masterEventExposer.add_PurchaseRequestAudioInvoked(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Game.Audio.SoundEffects::PurchaseRequestAudioInvoked(bool canAfford)));
            this._masterEventExposer.add_WorkshopModIconPressed(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Game.Audio.SoundEffects::WorkshopModIconPressed(bool unlocked)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadFailure(string soundBankName)
        {
            null = null;
            ConsoleLogger.LogError(className:  Game.Audio.SoundEffects.MaskOn, functionName:  "LoadFailure", logString:  "Failed to load SoundBank \'" + soundBankName + "\'. Cannot play sound effects");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._audioPlayer = 0;
            this._masterEventExposer.remove_StaticSettingsUpdated(value:  new System.Action<Game.AttackSequence.Static.StaticSettings>(object:  this, method:  System.Void Game.Audio.SoundEffects::StaticSettingsUpdated(Game.AttackSequence.Static.StaticSettings staticSettings)));
            this._masterEventExposer.remove_ShockerCooldownComplete(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::ShockerCooldownComplete()));
            this._masterEventExposer.remove_ShockerActivated(value:  new System.Action<Game.CameraEquipment.Shocker.ShockerActivation>(object:  this, method:  System.Void Game.Audio.SoundEffects::ShockerActivated(Game.CameraEquipment.Shocker.ShockerActivation shockerActivation)));
            mem[1152921525427596016] = this;
            mem[1152921525427596024] = System.Void Game.Audio.SoundEffects::MaskStateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning);
            mem[1152921525427596000] = System.Void Game.Audio.SoundEffects::MaskStateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning);
            this._masterEventExposer.remove_MaskStateChanged(value:  new MaskState.StateChanged());
            this._masterEventExposer.remove_MaskForcedOff(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::MaskForcedOff()));
            this._masterEventExposer.remove_FlashlightTriedToActivate(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::FlashlightTriedToActivate()));
            this._masterEventExposer.remove_FlashlightCooldownComplete(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::FlashlightCooldownComplete()));
            mem[1152921525427628784] = this;
            mem[1152921525427628792] = System.Void Game.Audio.SoundEffects::FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio);
            mem[1152921525427628768] = System.Void Game.Audio.SoundEffects::FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio);
            this._masterEventExposer.remove_FlashlightStateChanged(value:  new FlashlightState.StateChanged());
            this._masterEventExposer.remove_NewAnimatronicSpawned(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::NewAnimatronicSpawned()));
            this._masterEventExposer.remove_ExtraBatteryStateChanged(value:  new System.Action<Game.CameraEquipment.Battery.ExtraBatteryStateChange>(object:  this, method:  System.Void Game.Audio.SoundEffects::ExtraBatteryStateChanged(Game.CameraEquipment.Battery.ExtraBatteryStateChange extraBatteryStateChange)));
            this._masterEventExposer.remove_AttackDisruptionStateChanged(value:  new AttackDisruption.StateChanged(object:  this, method:  System.Void Game.Audio.SoundEffects::AttackDisruptionStateChanged(bool isDisruptionActive, Game.AttackSequence.DisruptionMechanic.DisruptionStyle style)));
            this._masterEventExposer.remove_AttackSurgeStateChanged(value:  new AttackSurge.StateChanged(object:  this, method:  System.Void Game.Audio.SoundEffects::AttackSurgeStateChanged(bool isSurgeActive, Game.ItemDefinition.Data.DataDefinitions.SurgeData surgeSettings)));
            this._masterEventExposer.remove_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.SoundEffects::AmbGlitchesEnd(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.remove_HardGlitchesEnded(value:  new System.Action(object:  this, method:  System.Void Game.Audio.SoundEffects::AmbGlitchesBegin()));
            this._masterEventExposer.remove_TutorialUIEvent(value:  new System.Action<TutorialUIEvent>(object:  this, method:  System.Void Game.Audio.SoundEffects::HardGlitchesBegin(TutorialSendUIEvent.TutorialUIEvent tutorialUIEvent)));
            this._masterEventExposer.remove_PurchaseRequestAudioInvoked(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Game.Audio.SoundEffects::PurchaseRequestAudioInvoked(bool canAfford)));
            this._masterEventExposer.remove_WorkshopModIconPressed(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Game.Audio.SoundEffects::WorkshopModIconPressed(bool unlocked)));
            this._masterEventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SoundEffects()
        {
            Game.Audio.SoundEffects.MaskOn = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
