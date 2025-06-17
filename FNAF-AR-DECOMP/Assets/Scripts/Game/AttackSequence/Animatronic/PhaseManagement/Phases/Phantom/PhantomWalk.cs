using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomWalk : Phase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase <AttackPhase>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalkState _state;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _encounterWinTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _encounterBurnTime;
        
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
            var val_12;
            var val_13;
            var val_14;
            bool val_17 = static_value_04281000;
            var val_14 = static_value_04281000 + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_21 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_18 = X21 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_20 = val_18;
            val_20 = val_20 + 1;
            val_21 = val_21 + val_20;
            val_12 = val_21 + 296;
            label_12:
            var val_25 = X22;
            if((X22 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_22 = X22 + 176;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_16:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (X22 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            var val_24 = val_22;
            val_24 = val_24 + 5;
            val_25 = val_25 + val_24;
            val_13 = val_25 + 296;
            label_17:
            Game.AttackSequence.Static.StaticConfig val_3 = X22.StaticConfig;
            var val_29 = X23;
            if((X23 + 286) == 0)
            {
                goto label_23;
            }
            
            var val_26 = X23 + 176;
            var val_27 = 0;
            val_26 = val_26 + 8;
            label_22:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            if(val_27 < (X23 + 286))
            {
                goto label_22;
            }
            
            goto label_23;
            label_21:
            var val_28 = val_26;
            val_28 = val_28 + 6;
            val_29 = val_29 + val_28;
            val_14 = val_29 + 296;
            label_23:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4 = X23.AttackProfile;
            val_1.AttackStatic.<Container>k__BackingField.UpdatePhaseStaticSettings(entityId:  X21.EntityId, settings:  val_3.PhantomWalk, shearModifier:  val_4.ShearModifier);
            if(this._state != null)
            {
                    this._state.HasManifested = false;
                this._state.HasTriggeredCounter = false;
                this._state.WasBurning = false;
                this._state.BurnTimeAllowed = 0f;
                this._state.BurnTime = 0f;
                this._state.AnimatedSpeed = 0f;
                this._state.JumpscareRange = 0f;
            }
            else
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_6 = val_1.AttackStatic.<Container>k__BackingField.AttackProfile;
                .Config = val_6.PhantomWalk;
                this._state = new Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalkState();
                this._encounterWinTime = UnityEngine.Random.Range(min:  (Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalkState)[1152921525483694032].Config.EncounterBurnTime.Min, max:  this._state.Config.EncounterBurnTime.Max);
                this._encounterBurnTime = 0f;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            var val_32 = 0;
            val_32 = val_32 + 1;
            Animatronics.Animatronic3d.Model.MovementSettings val_12 = this._state.Config.EncounterBurnTime.Model.GetMovementSettings();
            this._state.AnimatedSpeed = val_12.AnimatedSpeed;
            this._state.JumpscareRange = val_12.JumpscareDistance;
            this._state.BurnTimeAllowed = UnityEngine.Random.Range(min:  this._state.Config.PhaseBurnTime.Min, max:  this._state.Config.PhaseBurnTime.Max);
            this.StartManifesting();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalkState val_18;
            var val_19;
            var val_21;
            bool val_24;
            var val_25;
            var val_28;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalkState val_29;
            float val_30;
            var val_31;
            var val_33;
            var val_34;
            float val_35;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalkState val_39;
            val_18 = this;
            if(this._state.HasManifested != false)
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_19 = 3;
            }
            else
            {
                    val_21 = 0;
                return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(val_35 > this._state.JumpscareRange) ? 0 : 9;
            }
            
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_2 = this._state.Systems;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_19 = 0;
            if(val_2.Flashlight.IsOn == false)
            {
                goto label_21;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_19 = 11;
            if(val_2.Flashlight.IsAABBOnScreen == false)
            {
                goto label_21;
            }
            
            val_24 = 1;
            goto label_22;
            label_21:
            if(this._state.WasBurning != false)
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_25 = 2;
                var val_29 = 0;
                val_29 = val_29 + 1;
                val_25 = 8;
                val_28 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
                this._state.Model.RaiseAudioEventFromCpu(eventName:  30);
            }
            
            val_24 = false;
            this._state.HasTriggeredCounter = false;
            label_22:
            bool val_30 = this._state.HasTriggeredCounter;
            val_30 = val_24 & val_30;
            if(val_30 == false)
            {
                goto label_37;
            }
            
            float val_10 = UnityEngine.Time.deltaTime;
            val_29 = this._state;
            val_10 = val_10 + this._encounterBurnTime;
            this._encounterBurnTime = val_10;
            if(val_29 == null)
            {
                goto label_38;
            }
            
            val_30 = this._state.BurnTime;
            goto label_39;
            label_37:
            if(val_24 == 0)
            {
                goto label_56;
            }
            
            this._state.HasTriggeredCounter = true;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_31 = 2;
            goto label_46;
            label_38:
            val_29 = 40;
            val_30 = 1.85775E-36f;
            label_39:
            mem[40] = val_10 + val_30;
            float val_35 = mem[40];
            if(((val_10 + val_30) + 286) == 0)
            {
                goto label_50;
            }
            
            var val_32 = (val_10 + val_30) + 176;
            var val_33 = 0;
            val_32 = val_32 + 8;
            label_52:
            if((((val_10 + val_30) + 176 + 8) + -8) == null)
            {
                goto label_51;
            }
            
            val_33 = val_33 + 1;
            val_32 = val_32 + 16;
            if(val_33 < ((val_10 + val_30) + 286))
            {
                goto label_52;
            }
            
            label_50:
            val_33 = 3;
            goto label_53;
            label_51:
            var val_34 = val_32;
            val_34 = val_34 + 3;
            val_35 = val_35 + val_34;
            val_34 = val_35 + 296;
            label_53:
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_14 = mem[40].Systems;
            val_35 = 1f - (UnityEngine.Mathf.Clamp(value:  this._encounterBurnTime / this._encounterWinTime, min:  0f, max:  1f));
            val_14.ThreatLevelFxController.SetStrength(strength:  val_35);
            goto label_56;
            label_46:
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_31 = 8;
            val_33 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            this._state.Model.RaiseAudioEventFromCpu(eventName:  29);
            label_56:
            if(val_24 != this._state.WasBurning)
            {
                    var val_37 = 0;
                val_37 = val_37 + 1;
                val_33 = 2;
                var val_38 = 0;
                val_38 = val_38 + 1;
                val_33 = 27;
                this._state.Model.SetPhantomEffectAndAnimationState(state:  (val_24 != 0) ? (3 + 1) : 3);
                this.SetMovementSpeed();
                this._state.WasBurning = val_24;
            }
            
            if(this._encounterBurnTime >= this._encounterWinTime)
            {
                goto label_75;
            }
            
            val_39 = this._state;
            if(this._state != null)
            {
                goto label_76;
            }
            
            val_39 = this._state;
            if(val_39 == null)
            {
                goto label_77;
            }
            
            label_76:
            if(this._state.BurnTime >= this._state.BurnTimeAllowed)
            {
                goto label_78;
            }
            
            var val_39 = 0;
            val_39 = val_39 + 1;
            goto label_83;
            label_75:
            val_21 = 10;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(val_35 > this._state.JumpscareRange) ? 0 : 9;
            label_78:
            val_21 = 13;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(val_35 > this._state.JumpscareRange) ? 0 : 9;
            label_83:
            val_18 = this._state;
            val_35 = this._state.DistanceFromCamera;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(val_35 > this._state.JumpscareRange) ? 0 : 9;
            label_77:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            var val_14;
            IntPtr val_16;
            var val_18;
            var val_21;
            var val_22;
            var val_25;
            bool val_22 = static_value_04281000;
            var val_19 = static_value_04281000 + 176;
            var val_20 = 0;
            val_19 = val_19 + 8;
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_26 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_23 = X21 + 176;
            var val_24 = 0;
            val_23 = val_23 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_24 = val_24 + 1;
            val_23 = val_23 + 16;
            if(val_24 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_25 = val_23;
            val_25 = val_25 + 1;
            val_26 = val_26 + val_25;
            val_14 = val_26 + 296;
            label_12:
            val_1.AttackStatic.<Container>k__BackingField.ClearPhaseStaticSettings(entityId:  X21.EntityId);
            var val_27 = 0;
            val_27 = val_27 + 1;
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_1.AttackStatic.<Container>k__BackingField.Model;
            System.Action val_5 = null;
            val_16 = System.Void Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalk::StartWalking();
            val_5 = new System.Action(object:  this, method:  val_16);
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_16 = 23;
            val_18 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::UnregisterForPhantomManifestComplete(System.Action callback);
            val_4.UnregisterForPhantomManifestComplete(callback:  val_5);
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_18 = 2;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_18 = 8;
            val_21 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            val_4.Model.RaiseAudioEventFromCpu(eventName:  28);
            if(this._state.WasBurning != false)
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_22 = 2;
                Animatronics.Animatronic3d.IAnimatronic3D val_11 = this._state.Model;
                var val_32 = 0;
                val_32 = val_32 + 1;
                val_22 = 8;
                val_25 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
                val_11.RaiseAudioEventFromCpu(eventName:  30);
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_25 = 2;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_25 = 46;
            val_11.Model.StopMoving();
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_25 = 2;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_25 = 27;
            this.Model.SetPhantomEffectAndAnimationState(state:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartManifesting()
        {
            var val_8;
            IntPtr val_12;
            var val_14;
            bool val_13 = static_value_04281000;
            var val_10 = static_value_04281000 + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            val_8 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_1 = Model;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_8 = 8;
            val_1.RaiseAudioEventFromCpu(eventName:  21);
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Action val_5 = null;
            val_12 = System.Void Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalk::StartWalking();
            val_5 = new System.Action(object:  this, method:  val_12);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_12 = 22;
            val_14 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RegisterForPhantomManifestComplete(System.Action callback);
            val_1.Model.RegisterForPhantomManifestComplete(callback:  val_5);
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_14 = 2;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_14 = 27;
            this.Model.SetPhantomEffectAndAnimationState(state:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartWalking()
        {
            IntPtr val_9;
            var val_11;
            var val_14;
            this._state.HasManifested = true;
            var val_11 = 0;
            val_11 = val_11 + 1;
            Animatronics.Animatronic3d.IAnimatronic3D val_2 = this._state.Model;
            System.Action val_3 = null;
            val_9 = System.Void Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalk::StartWalking();
            val_3 = new System.Action(object:  this, method:  val_9);
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_9 = 23;
            val_11 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::UnregisterForPhantomManifestComplete(System.Action callback);
            val_2.UnregisterForPhantomManifestComplete(callback:  val_3);
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_11 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_6 = val_2.Model;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_11 = 8;
            val_14 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            val_6.RaiseAudioEventFromCpu(eventName:  27);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_14 = 2;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_14 = 27;
            val_6.Model.SetPhantomEffectAndAnimationState(state:  3);
            this.SetMovementSpeed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetMovementSpeed()
        {
            var val_5;
            bool val_10 = static_value_04281000;
            var val_7 = static_value_04281000 + 176;
            var val_8 = 0;
            val_7 = val_7 + 8;
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            val_5 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_1 = Model;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_5 = 24;
            float val_13 = val_1.GetPhantomAnimationSpeedModifier();
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_5 = 2;
            val_13 = val_13 * this._state.AnimatedSpeed;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_5 = 48;
            val_1.Model.MoveInLineTowardCamera(unitsPerSecond:  val_13, isWalking:  false, duration:  -1f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomWalk()
        {
            this.<AttackPhase>k__BackingField = 12;
            val_1 = new System.Object();
        }
    
    }

}
