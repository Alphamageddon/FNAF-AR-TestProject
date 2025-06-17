using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomOverload : Phase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase <AttackPhase>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomOverloadState _state;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase AttackPhase { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase get_AttackPhase()
        {
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)this.<AttackPhase>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            var val_11;
            var val_12;
            var val_13;
            Game.AttackSequence.Static.PhaseStaticSettings val_14;
            var val_18;
            bool val_18 = static_value_04281000;
            var val_15 = static_value_04281000 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_22 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_19 = X21 + 176;
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_21 = val_19;
            val_21 = val_21 + 1;
            val_22 = val_22 + val_21;
            val_11 = val_22 + 296;
            label_12:
            var val_26 = X22;
            if((X22 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_23 = X22 + 176;
            var val_24 = 0;
            val_23 = val_23 + 8;
            label_16:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_24 = val_24 + 1;
            val_23 = val_23 + 16;
            if(val_24 < (X22 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            var val_25 = val_23;
            val_25 = val_25 + 5;
            val_26 = val_26 + val_25;
            val_12 = val_26 + 296;
            label_17:
            Game.AttackSequence.Static.StaticConfig val_3 = X22.StaticConfig;
            var val_30 = X23;
            if((X23 + 286) == 0)
            {
                goto label_23;
            }
            
            var val_27 = X23 + 176;
            var val_28 = 0;
            val_27 = val_27 + 8;
            label_22:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_28 = val_28 + 1;
            val_27 = val_27 + 16;
            if(val_28 < (X23 + 286))
            {
                goto label_22;
            }
            
            goto label_23;
            label_21:
            var val_29 = val_27;
            val_29 = val_29 + 6;
            val_30 = val_30 + val_29;
            val_13 = val_30 + 296;
            label_23:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4 = X23.AttackProfile;
            val_14 = val_3.PhantomWalk;
            val_1.AttackStatic.<Container>k__BackingField.UpdatePhaseStaticSettings(entityId:  X21.EntityId, settings:  val_14, shearModifier:  val_4.ShearModifier);
            if(this._state != null)
            {
                    this._state.Reset();
            }
            else
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_14 = 6;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_6 = val_1.AttackStatic.<Container>k__BackingField.AttackProfile;
                this._state = new Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomOverloadState(config:  val_6.PhantomOverload);
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_14 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_9 = val_6.PhantomOverload.Model;
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_14 = 8;
            val_18 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            val_9.RaiseAudioEventFromCpu(eventName:  22);
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_18 = 2;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_18 = 27;
            val_9.Model.SetPhantomEffectAndAnimationState(state:  5);
            this._state.OverloadTimer.StartTimer(time:  UnityEngine.Random.Range(min:  this._state.Config.ReactionTime.Min, max:  this._state.Config.ReactionTime.Max));
            this.ClearTriggers();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            var val_11;
            var val_12;
            var val_15;
            if(Started() != false)
            {
                    if(IsExpired() != false)
            {
                    val_11 = 5;
                return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_11;
            }
            
            }
            
            if(this._state.OverloadTimer.Started() != false)
            {
                    if(this._state.OverloadTimer.IsExpired() != false)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_12 = 2;
                Animatronics.Animatronic3d.IAnimatronic3D val_6 = this._state.OverloadTimer.Model;
                var val_16 = 0;
                val_16 = val_16 + 1;
                val_12 = 8;
                val_15 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
                val_6.RaiseAudioEventFromCpu(eventName:  23);
                var val_17 = 0;
                val_17 = val_17 + 1;
                val_15 = 2;
                var val_18 = 0;
                val_18 = val_18 + 1;
                val_15 = 27;
                val_6.Model.SetPhantomEffectAndAnimationState(state:  6);
                this._state.OverloadTimer.Reset();
            }
            
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            if((this._state.OverloadTimer.PhantomRepositionRequested != false) && (this._state.HasRepositionTriggered != true))
            {
                    this.TriggerReposition();
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            if((this._state.PhantomOverloadRequested != false) && (this._state.HasOverloadEffectTriggered != true))
            {
                    this.TriggerOverloadEffect();
            }
            
            val_11 = 0;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            var val_5;
            var val_7;
            bool val_11 = static_value_04281000;
            var val_8 = static_value_04281000 + 176;
            var val_9 = 0;
            val_8 = val_8 + 8;
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            val_5 = 3;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_15 = X21;
            if((X21 + 286) == 0)
            {
                goto label_9;
            }
            
            var val_12 = X21 + 176;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (X21 + 286))
            {
                goto label_11;
            }
            
            label_9:
            val_5 = 1;
            goto label_12;
            label_10:
            var val_14 = val_12;
            val_14 = val_14 + 1;
            val_15 = val_15 + val_14;
            val_7 = val_15 + 296;
            label_12:
            val_1.AttackStatic.<Container>k__BackingField.ClearPhaseStaticSettings(entityId:  X21.EntityId);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_5 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_1.AttackStatic.<Container>k__BackingField.Model;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_5 = 27;
            val_4.SetPhantomEffectAndAnimationState(state:  1);
            var val_18 = 0;
            val_18 = val_18 + 1;
            Game.AttackSequence.Animatronic.TeleportReposition.PhantomTeleport(blackboard:  val_4, distance:  val_4.DistanceFromCamera);
            this.ClearTriggers();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearTriggers()
        {
            var val_4;
            bool val_5 = static_value_04281000;
            var val_2 = static_value_04281000 + 176;
            var val_3 = 0;
            val_2 = val_2 + 8;
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            val_4 = public System.Void Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess::set_PhantomOverloadRequested(bool value);
            PhantomOverloadRequested = false;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_4 = 25;
            this.PhantomRepositionRequested = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TriggerOverloadEffect()
        {
            EZCameraShake.CameraShaker val_12;
            var val_13;
            var val_22;
            val_12 = this;
            this._state.HasOverloadEffectTriggered = true;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_13 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_2 = this._state.Model;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_13 = 8;
            val_2.RaiseAudioEventFromCpu(eventName:  24);
            var val_19 = 0;
            val_19 = val_19 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_5 = val_2.Systems;
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_5.Flashlight.IsOn == false)
            {
                    return;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_10 = this._state.Config.FlashlightDisableTime.Systems;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_10.Flashlight.SetFlashlightState(setOn:  false, shouldPlayAudio:  false);
            var val_23 = 0;
            val_23 = val_23 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_13 = this.Systems;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_13.Flashlight.SetFlashlightCooldown(cooldown:  UnityEngine.Random.Range(min:  this._state.Config.FlashlightDisableTime.Min, max:  this._state.Config.FlashlightDisableTime.Max));
            val_22 = null;
            val_22 = null;
            val_12 = EZCameraShake.CameraShaker.Instance;
            EZCameraShake.CameraShakeInstance val_15 = val_12.ShakeOnce(magnitude:  0.5f, roughness:  5f, fadeInTime:  0f, fadeOutTime:  1.8f);
            if(VibrationSettings.VibrationIsEnabled() == false)
            {
                    return;
            }
            
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  6, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TriggerReposition()
        {
            var val_7;
            var val_10;
            this._state.HasRepositionTriggered = true;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_7 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_2 = this._state.Model;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_7 = 8;
            val_10 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            val_2.RaiseAudioEventFromCpu(eventName:  25);
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_10 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_5 = val_2.Model;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_10 = 27;
            val_5.SetPhantomEffectAndAnimationState(state:  7);
            var val_15 = 0;
            val_15 = val_15 + 1;
            var val_16 = 0;
            val_16 = val_16 + 1;
            this.StartTimer(time:  val_5.Model.GetPhantomRepositionEffectTime());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomOverload()
        {
            this.<AttackPhase>k__BackingField = 13;
            val_1 = new System.Object();
        }
    
    }

}
