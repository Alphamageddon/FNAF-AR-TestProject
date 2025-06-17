using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Pause : BasePause
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.PauseState _state;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic.GlimpseActivator _glimpseActivator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup _nextPhaseChance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            var val_32;
            var val_35;
            var val_38;
            var val_41;
            var val_44;
            string val_46;
            float val_50;
            float val_51;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.PauseState val_60;
            bool val_49 = static_value_04281000;
            var val_46 = static_value_04281000 + 176;
            var val_47 = 0;
            val_46 = val_46 + 8;
            val_47 = val_47 + 1;
            val_46 = val_46 + 16;
            val_32 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_1 = Model;
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_32 = 15;
            val_35 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_1.SetCloakState(cloakEnabled:  true);
            var val_51 = 0;
            val_51 = val_51 + 1;
            val_35 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_1.Model;
            var val_52 = 0;
            val_52 = val_52 + 1;
            val_35 = 18;
            val_38 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_4.SetEyeCloakState(eyeCloakEnabled:  true);
            var val_53 = 0;
            val_53 = val_53 + 1;
            val_38 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_7 = val_4.Model;
            var val_54 = 0;
            val_54 = val_54 + 1;
            val_38 = 13;
            val_41 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode);
            val_7.SetEyeColorMode(mode:  0);
            var val_55 = 0;
            val_55 = val_55 + 1;
            val_41 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_10 = val_7.Model;
            var val_56 = 0;
            val_56 = val_56 + 1;
            val_41 = 14;
            val_44 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeGlow(bool eyeGlowEnabled);
            val_10.SetEyeGlow(eyeGlowEnabled:  false);
            var val_57 = 0;
            val_57 = val_57 + 1;
            val_44 = 13;
            val_46 = public System.Void Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess::set_FreezeStaticAngle(bool value);
            val_10.FreezeStaticAngle = true;
            var val_58 = 0;
            val_58 = val_58 + 1;
            val_46 = 2;
            var val_59 = 0;
            val_59 = val_59 + 1;
            val_46 = 30;
            UnityEngine.Vector3 val_16 = val_10.Model.GetRootBonePosition();
            var val_60 = 0;
            val_60 = val_60 + 1;
            val_46 = 15;
            val_50 = val_16.x;
            val_51 = val_16.y;
            val_10.FrozenStaticPosition = new UnityEngine.Vector3() {x = val_50, y = val_51, z = val_16.z};
            if(this._state != null)
            {
                    this._state.Reset();
            }
            else
            {
                    var val_61 = 0;
                val_61 = val_61 + 1;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_19 = val_10.AttackProfile;
                this._state = new Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.PauseState(config:  val_19.Pause);
                long val_22 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 6});
                this._nextPhaseChance.AddOption(id:  6, debugOptionName:  6.ToString(), baseChance:  this._state.Config.GlimpseChance.Chance, modifier:  this._state.Config.GlimpseChance.Modifier);
                long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 4});
                this._nextPhaseChance.AddOption(id:  4, debugOptionName:  4.ToString(), baseChance:  this._state.Config.CircleChance.Chance, modifier:  this._state.Config.CircleChance.Modifier);
                string val_25 = 7.ToString();
                long val_26 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 7});
                val_46 = val_25;
                val_50 = this._state.Config.ChargeChance.Chance;
                val_51 = this._state.Config.ChargeChance.Modifier;
                this._nextPhaseChance.AddOption(id:  7, debugOptionName:  val_46, baseChance:  val_50, modifier:  val_51);
                this._nextPhaseChance._setupComplete = true;
                this._nextPhaseChance.EnsureChanceRange();
            }
            
            if(this._glimpseActivator != null)
            {
                
            }
            else
            {
                    var val_62 = 0;
                val_62 = val_62 + 1;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_28 = this._nextPhaseChance.AttackProfile;
                var val_63 = 0;
                val_63 = val_63 + 1;
                var val_64 = 0;
                val_64 = val_64 + 1;
                Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic.GlimpseActivator val_33 = new Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic.GlimpseActivator(config:  val_28.Glimpse, cloakConfig:  val_25.Model.GetCloakSettings());
                ._shouldUseDeadZone = true;
                val_33.StartCooldown();
                this._glimpseActivator = val_33;
            }
            
            var val_65 = 0;
            val_65 = val_65 + 1;
            Animatronics.Animatronic3d.IAnimatronic3D val_35 = val_28.Glimpse.Model;
            var val_66 = 0;
            val_66 = val_66 + 1;
            UnityEngine.Vector3 val_37 = val_35.GetPosition();
            this._state.SavedPosition = val_37;
            mem2[0] = val_37.y;
            mem2[0] = val_37.z;
            var val_67 = 0;
            val_67 = val_67 + 1;
            var val_68 = 0;
            val_68 = val_68 + 1;
            UnityEngine.Vector3 val_41 = val_35.Model.GetForward();
            this._state.SavedForward = val_41;
            mem2[0] = val_41.y;
            mem2[0] = val_41.z;
            val_60 = this._state;
            float val_42 = UnityEngine.Random.Range(min:  this._state.Config.Seconds.Min, max:  this._state.Config.Seconds.Max);
            if(this.ShouldGoHaywire() != false)
            {
                    var val_69 = 0;
                val_69 = val_69 + 1;
                Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState val_45 = this._state.Config.Seconds.HaywireState;
                val_60 = this._state;
                float val_70 = val_45.ActiveState.TriggerPercent;
                val_70 = val_42 * val_70;
                this._state.HaywireTimer.StartTimer(time:  val_70);
            }
            
            this._state.HaywireTimer.StartTimer(time:  val_42);
            this.RunSharedEnterPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            var val_8;
            var val_9;
            var val_11;
            val_8 = this;
            if((this._state.HaywireTimer.Started() == false) || (this._state.HaywireTimer.IsExpired() == false))
            {
                goto label_18;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = 7;
            var val_13 = X21;
            if((X21 + 286) == 0)
            {
                goto label_13;
            }
            
            var val_10 = X21 + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_15:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (X21 + 286))
            {
                goto label_15;
            }
            
            label_13:
            val_9 = 9;
            goto label_16;
            label_14:
            var val_12 = val_10;
            val_12 = val_12 + 9;
            val_13 = val_13 + val_12;
            val_11 = val_13 + 296;
            label_16:
            if((this._state.HaywireTimer.HaywireState != null) && (val_4.ActiveState != null))
            {
                    if(val_4.ActiveState.Config.AllowedHalfAngle >= X21.AbsoluteAngleFromCamera)
            {
                    return 0;
            }
            
            }
            
            label_18:
            if(val_4.ActiveState.Config.IsExpired() != false)
            {
                    return this.ChooseNextPhase();
            }
            
            if(this._state.Config.UseGlimpse == false)
            {
                    return 0;
            }
            
            bool val_7 = this._state.HaywireTimer.Started();
            if(val_7 == false)
            {
                goto label_28;
            }
            
            if(this._state.HaywireTimer != null)
            {
                goto label_32;
            }
            
            label_33:
            label_32:
            float val_8 = 0.GetRemainingTime();
            return 0;
            label_28:
            if(val_7 == true)
            {
                goto label_32;
            }
            
            goto label_33;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            var val_13;
            var val_16;
            var val_19;
            var val_22;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.PauseState val_26;
            bool val_19 = static_value_04281000;
            var val_16 = static_value_04281000 + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            FreezeStaticAngle = false;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_13 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_2 = this._glimpseActivator.Model;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_13 = 15;
            val_16 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_2.SetCloakState(cloakEnabled:  true);
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_16 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_5 = val_2.Model;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_16 = 18;
            val_19 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_5.SetEyeCloakState(eyeCloakEnabled:  true);
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_19 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_8 = val_5.Model;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_19 = 14;
            val_22 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeGlow(bool eyeGlowEnabled);
            val_8.SetEyeGlow(eyeGlowEnabled:  false);
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_22 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_11 = val_8.Model;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_22 = 13;
            val_11.SetEyeColorMode(mode:  0);
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_26 = this._state;
            if(this._state == null)
            {
                    val_26 = this._state;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_11.Model.TeleportToLocalPosition(position:  new UnityEngine.Vector3() {x = this._state.SavedPosition, y = V9.16B, z = V10.16B}, forward:  new UnityEngine.Vector3() {x = this._state.SavedForward, y = V12.16B, z = V13.16B});
            this.RunSharedExitPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldGoHaywire()
        {
            bool val_8 = static_value_04281000;
            var val_5 = static_value_04281000 + 176;
            var val_6 = 0;
            val_5 = val_5 + 8;
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            Game.AttackSequence.Animatronic.PhaseManagement.HaywireActivator.CalculateActivation(haywireState:  HaywireState, sourcePhase:  5);
            var val_9 = 0;
            val_9 = val_9 + 1;
            Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState val_3 = this.HaywireState;
            return (bool)(val_3.ActiveState != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase ChooseNextPhase()
        {
            var val_3;
            if((Game.AttackSequence.Animatronic.PhaseManagement.LowBatteryDetector.ShouldCharge(blackboard:  35882)) != false)
            {
                    val_3 = 7;
                return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_3;
            }
            
            bool val_6 = static_value_04281000;
            var val_3 = static_value_04281000 + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(ForceCircleAfterPause != false)
            {
                    val_3 = 4;
                return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_3;
            }
            
            if(this._nextPhaseChance != null)
            {
                    return this._nextPhaseChance.GetRandomOption();
            }
            
            return this._nextPhaseChance.GetRandomOption();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Pause()
        {
            this._nextPhaseChance = new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup(debugGroupName:  "PauseNextPhase");
            mem[1152921525477894352] = 5;
            this = new System.Object();
        }
    
    }

}
