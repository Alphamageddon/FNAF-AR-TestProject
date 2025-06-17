using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Glimpse : Phase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase <AttackPhase>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.GlimpseState _state;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic.GlimpseActivator _glimpseActivator;
        
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
            var val_18;
            var val_21;
            var val_24;
            var val_27;
            var val_30;
            var val_33;
            bool val_29 = static_value_04281000;
            var val_26 = static_value_04281000 + 176;
            var val_27 = 0;
            val_26 = val_26 + 8;
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            val_18 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_1 = Model;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_18 = 15;
            val_21 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_1.SetCloakState(cloakEnabled:  true);
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_21 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_1.Model;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_21 = 18;
            val_24 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_4.SetEyeCloakState(eyeCloakEnabled:  true);
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_24 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_7 = val_4.Model;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_24 = 13;
            val_27 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode);
            val_7.SetEyeColorMode(mode:  0);
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_27 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_10 = val_7.Model;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_27 = 14;
            val_30 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeGlow(bool eyeGlowEnabled);
            val_10.SetEyeGlow(eyeGlowEnabled:  false);
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_30 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_13 = val_10.Model;
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_30 = 8;
            val_33 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            val_13.RaiseAudioEventFromCpu(eventName:  9);
            if(this._state != null)
            {
                    this._state.Reset();
            }
            else
            {
                    var val_39 = 0;
                val_39 = val_39 + 1;
                val_33 = 6;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_16 = val_13.AttackProfile;
                Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.GlimpseState val_17 = new Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.GlimpseState(config:  val_16.Glimpse);
                this._state = val_17;
            }
            
            if(this._glimpseActivator != null)
            {
                
            }
            else
            {
                    var val_40 = 0;
                val_40 = val_40 + 1;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_19 = val_16.Glimpse.AttackProfile;
                var val_41 = 0;
                val_41 = val_41 + 1;
                var val_42 = 0;
                val_42 = val_42 + 1;
                Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic.GlimpseActivator val_24 = new Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic.GlimpseActivator(config:  val_19.Glimpse, cloakConfig:  val_17.Model.GetCloakSettings());
                ._shouldUseDeadZone = false;
                val_24.StartCooldown();
                this._glimpseActivator = val_24;
            }
            
            val_19.Glimpse.StartTimer(time:  UnityEngine.Random.Range(min:  this._state.Config.PhaseDuration.Min, max:  this._state.Config.PhaseDuration.Max));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            SimpleTimer val_10;
            var val_11;
            var val_12;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.GlimpseState val_15;
            if(this._state.ExitTimer.Started() != false)
            {
                    val_10 = this._state.ExitTimer;
                var val_3 = (val_10.IsExpired() != true) ? 4 : 0;
                return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_11;
            }
            
            if((this._state.ExitTimer.Started() == false) || (this._state.ExitTimer.IsExpired() == false))
            {
                goto label_10;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = 2;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = 8;
            this._state.ExitTimer.Model.RaiseAudioEventFromCpu(eventName:  11);
            val_15 = this._state;
            if(this._state != null)
            {
                goto label_21;
            }
            
            val_15 = this._state;
            if(val_15 == null)
            {
                goto label_22;
            }
            
            label_21:
            this._state.ExitTimer.StartTimer(time:  UnityEngine.Random.Range(min:  this._state.Config.RepositionDelay.Min, max:  this._state.Config.RepositionDelay.Max));
            label_10:
            val_10 = this._glimpseActivator;
            float val_10 = this._state.Config.RepositionDelay.GetRemainingTime();
            val_11 = 0;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_11;
            label_22:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            var val_11;
            var val_14;
            var val_17;
            var val_20;
            var val_23;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_11 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_2 = this._glimpseActivator.Model;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_11 = 15;
            val_14 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_2.SetCloakState(cloakEnabled:  true);
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_14 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_5 = val_2.Model;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_14 = 18;
            val_17 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_5.SetEyeCloakState(eyeCloakEnabled:  true);
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_17 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_8 = val_5.Model;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_17 = 13;
            val_20 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode);
            val_8.SetEyeColorMode(mode:  0);
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_20 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_11 = val_8.Model;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_20 = 14;
            val_23 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeGlow(bool eyeGlowEnabled);
            val_11.SetEyeGlow(eyeGlowEnabled:  false);
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_23 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_14 = val_11.Model;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_23 = 8;
            val_14.RaiseAudioEventFromCpu(eventName:  10);
            Game.AttackSequence.Animatronic.TeleportReposition.NormalTeleport(blackboard:  val_14);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Glimpse()
        {
            this.<AttackPhase>k__BackingField = 6;
            val_1 = new System.Object();
        }
    
    }

}
