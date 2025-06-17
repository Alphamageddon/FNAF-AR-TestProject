using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Circle : Phase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase <AttackPhase>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.CircleState _state;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup _speedChangeChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup _nextPhaseChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _lastWalkedClockwise;
        
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
            var val_32;
            var val_33;
            var val_34;
            Game.AttackSequence.Static.PhaseStaticSettings val_35;
            var val_38;
            var val_41;
            var val_44;
            string val_47;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.CircleState val_50;
            bool val_46 = static_value_04281000;
            var val_43 = static_value_04281000 + 176;
            var val_44 = 0;
            val_43 = val_43 + 8;
            val_44 = val_44 + 1;
            val_43 = val_43 + 16;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_50 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_47 = X21 + 176;
            var val_48 = 0;
            val_47 = val_47 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_48 = val_48 + 1;
            val_47 = val_47 + 16;
            if(val_48 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_49 = val_47;
            val_49 = val_49 + 1;
            val_50 = val_50 + val_49;
            val_32 = val_50 + 296;
            label_12:
            var val_54 = X22;
            if((X22 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_51 = X22 + 176;
            var val_52 = 0;
            val_51 = val_51 + 8;
            label_16:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_52 = val_52 + 1;
            val_51 = val_51 + 16;
            if(val_52 < (X22 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            var val_53 = val_51;
            val_53 = val_53 + 5;
            val_54 = val_54 + val_53;
            val_33 = val_54 + 296;
            label_17:
            Game.AttackSequence.Static.StaticConfig val_3 = X22.StaticConfig;
            var val_58 = X23;
            if((X23 + 286) == 0)
            {
                goto label_23;
            }
            
            var val_55 = X23 + 176;
            var val_56 = 0;
            val_55 = val_55 + 8;
            label_22:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_56 = val_56 + 1;
            val_55 = val_55 + 16;
            if(val_56 < (X23 + 286))
            {
                goto label_22;
            }
            
            goto label_23;
            label_21:
            var val_57 = val_55;
            val_57 = val_57 + 6;
            val_58 = val_58 + val_57;
            val_34 = val_58 + 296;
            label_23:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4 = X23.AttackProfile;
            val_35 = val_3.Circle;
            val_1.AttackStatic.<Container>k__BackingField.UpdatePhaseStaticSettings(entityId:  X21.EntityId, settings:  val_35, shearModifier:  val_4.ShearModifier);
            var val_59 = 0;
            val_59 = val_59 + 1;
            val_35 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_6 = val_1.AttackStatic.<Container>k__BackingField.Model;
            var val_60 = 0;
            val_60 = val_60 + 1;
            val_35 = 8;
            val_38 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            val_6.RaiseAudioEventFromCpu(eventName:  27);
            var val_61 = 0;
            val_61 = val_61 + 1;
            val_38 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_9 = val_6.Model;
            var val_62 = 0;
            val_62 = val_62 + 1;
            val_38 = 15;
            val_41 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_9.SetCloakState(cloakEnabled:  true);
            var val_63 = 0;
            val_63 = val_63 + 1;
            val_41 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_12 = val_9.Model;
            var val_64 = 0;
            val_64 = val_64 + 1;
            val_41 = 18;
            val_44 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_12.SetEyeCloakState(eyeCloakEnabled:  true);
            var val_65 = 0;
            val_65 = val_65 + 1;
            val_44 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_15 = val_12.Model;
            var val_66 = 0;
            val_66 = val_66 + 1;
            val_44 = 14;
            val_47 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeGlow(bool eyeGlowEnabled);
            val_15.SetEyeGlow(eyeGlowEnabled:  false);
            if(this._state != null)
            {
                    this._state.Reset();
            }
            else
            {
                    var val_67 = 0;
                val_67 = val_67 + 1;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_18 = val_15.AttackProfile;
                this._state = new Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.CircleState(config:  val_18.Circle);
                float val_68 = 1f;
                val_68 = val_68 - (Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.CircleState)[1152921525469647504].Config.ChangeSpeedChance.Chance;
                this._speedChangeChance.AddOption(id:  0, debugOptionName:  "NoSpeedChange", baseChance:  val_68, modifier:  0f);
                this._speedChangeChance.AddOption(id:  1, debugOptionName:  "YesSpeedChange", baseChance:  this._state.Config.ChangeSpeedChance.Chance, modifier:  this._state.Config.ChangeSpeedChance.Modifier);
                this._speedChangeChance._setupComplete = true;
                this._speedChangeChance.EnsureChanceRange();
                long val_21 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 4});
                this._nextPhaseChance.AddOption(id:  4, debugOptionName:  4.ToString(), baseChance:  this._state.Config.CircleChance.Chance, modifier:  this._state.Config.CircleChance.Modifier);
                long val_23 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 7});
                this._nextPhaseChance.AddOption(id:  7, debugOptionName:  7.ToString(), baseChance:  this._state.Config.ChargeChance.Chance, modifier:  this._state.Config.ChargeChance.Modifier);
                long val_25 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 5});
                val_47 = 5.ToString();
                this._nextPhaseChance.AddOption(id:  5, debugOptionName:  val_47, baseChance:  this._state.Config.PauseChance.Chance, modifier:  this._state.Config.PauseChance.Modifier);
                this._nextPhaseChance._setupComplete = true;
                this._nextPhaseChance.EnsureChanceRange();
            }
            
            this._state.UseMinSpeed = ((UnityEngine.Random.Range(min:  0f, max:  1f)) <= 0.5f) ? 1 : 0;
            float val_28 = UnityEngine.Random.Range(min:  this._state.Config.Seconds.Min, max:  this._state.Config.Seconds.Max);
            bool val_30 = ((UnityEngine.Random.Range(min:  0f, max:  1f)) >= 0.5f) ? 1 : 0;
            this._lastWalkedClockwise = val_30;
            val_50 = val_30 ^ ((this._lastWalkedClockwise == true) ? 1 : 0);
            var val_69 = 0;
            val_69 = val_69 + 1;
            val_47 = 16;
            if((val_50 & this._state.Config.Seconds.ShouldCheckForDirectionChange) == true)
            {
                    var val_70 = 0;
                val_70 = val_70 + 1;
                val_47 = 2;
                var val_71 = 0;
                val_71 = val_71 + 1;
                val_47 = 8;
                this._state.Config.Seconds.Model.RaiseAudioEventFromCpu(eventName:  6);
            }
            
            if(this.ShouldChangeSpeed() != false)
            {
                    val_50 = this._state;
                float val_72 = UnityEngine.Random.Range(min:  this._state.Config.TriggerPercent.Min, max:  this._state.Config.TriggerPercent.Max);
                val_72 = val_28 * val_72;
                this._state.SpeedChangeTimer.StartTimer(time:  val_72);
            }
            
            if(this.ShouldGoHaywire() != false)
            {
                    var val_73 = 0;
                val_73 = val_73 + 1;
                Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState val_42 = this._state.SpeedChangeTimer.HaywireState;
                val_50 = this._state;
                float val_74 = val_42.ActiveState.TriggerPercent;
                val_74 = val_28 * val_74;
                this._state.HaywireTimer.StartTimer(time:  val_74);
            }
            
            this.StartMovement();
            this.StartTimer(time:  val_28);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            bool val_9;
            var val_10;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.CircleState val_11;
            if((this._state.HaywireTimer.Started() == false) || (this._state.HaywireTimer.IsExpired() == false))
            {
                goto label_18;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            var val_13 = X21;
            if((X21 + 286) == 0)
            {
                goto label_16;
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
            
            goto label_16;
            label_14:
            var val_12 = val_10;
            val_12 = val_12 + 9;
            val_13 = val_13 + val_12;
            val_10 = val_13 + 296;
            label_16:
            if((this._state.HaywireTimer.HaywireState != null) && (val_4.ActiveState != null))
            {
                    if(val_4.ActiveState.Config.AllowedHalfAngle >= X21.AbsoluteAngleFromCamera)
            {
                    return 0;
            }
            
            }
            
            label_18:
            if((this._state.SpeedChangeTimer.Started() != false) && (this._state.SpeedChangeTimer.IsExpired() != false))
            {
                    this._state.SpeedChangeTimer.Reset();
                val_11 = this._state;
                if(val_11 != null)
            {
                    val_9 = this._state.UseMinSpeed;
            }
            else
            {
                    val_11 = 40;
                val_9 = 56;
            }
            
                mem[40] = 57;
                this.StartMovement();
            }
            
            if(mem[40].IsExpired() != false)
            {
                    return this.ChooseNextPhase();
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            var val_7;
            var val_9;
            var val_12;
            var val_16;
            bool val_14 = static_value_04281000;
            var val_11 = static_value_04281000 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            val_7 = 3;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_18 = X21;
            if((X21 + 286) == 0)
            {
                goto label_9;
            }
            
            var val_15 = X21 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (X21 + 286))
            {
                goto label_11;
            }
            
            label_9:
            val_7 = 1;
            goto label_12;
            label_10:
            var val_17 = val_15;
            val_17 = val_17 + 1;
            val_18 = val_18 + val_17;
            val_9 = val_18 + 296;
            label_12:
            val_1.AttackStatic.<Container>k__BackingField.ClearPhaseStaticSettings(entityId:  X21.EntityId);
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_7 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_1.AttackStatic.<Container>k__BackingField.Model;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_7 = 8;
            val_12 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            val_4.RaiseAudioEventFromCpu(eventName:  28);
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_12 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_7 = val_4.Model;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_12 = 46;
            val_7.StopMoving();
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_12 = 21;
            val_16 = public System.Void Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess::set_ForceCircleAfterPause(bool value);
            val_7.ForceCircleAfterPause = false;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_16 = 17;
            this.ShouldCheckForDirectionChange = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldChangeSpeed()
        {
            return (bool)(this._speedChangeChance.GetRandomOption() > 0) ? 1 : 0;
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
            Game.AttackSequence.Animatronic.PhaseManagement.HaywireActivator.CalculateActivation(haywireState:  HaywireState, sourcePhase:  4);
            var val_9 = 0;
            val_9 = val_9 + 1;
            Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState val_3 = this.HaywireState;
            return (bool)(val_3.ActiveState != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartMovement()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.CircleState val_7;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.CircleState val_8;
            var val_9;
            var val_10;
            var val_12;
            val_7 = this._state;
            if(this._state != null)
            {
                goto label_1;
            }
            
            val_7 = this._state;
            if(val_7 == null)
            {
                goto label_6;
            }
            
            label_1:
            float val_13 = (this._state.UseMinSpeed == false) ? this._state.Config.DegreesPerSecond.Max : this._state.Config.DegreesPerSecond.Min;
            val_8 = this._state;
            if(this._state != null)
            {
                goto label_5;
            }
            
            val_8 = this._state;
            if(val_8 == null)
            {
                goto label_6;
            }
            
            label_5:
            bool val_12 = this._state.UseMinSpeed;
            if((this._state.UseMinSpeed + 286) == 0)
            {
                goto label_10;
            }
            
            var val_9 = this._state.UseMinSpeed + 176;
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_12:
            if(((this._state.UseMinSpeed + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < (this._state.UseMinSpeed + 286))
            {
                goto label_12;
            }
            
            label_10:
            val_9 = 2;
            goto label_13;
            label_11:
            var val_11 = val_9;
            val_11 = val_11 + 2;
            val_12 = val_12 + val_11;
            val_10 = val_12 + 296;
            label_13:
            val_13 = val_13 * ((this._lastWalkedClockwise == true) ? -1f : 1f);
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_9 = 47;
            val_12 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::MoveInCircleAroundCamera(float degreesPerSecond, bool isWalking, float duration);
            this._state.UseMinSpeed.Model.MoveInCircleAroundCamera(degreesPerSecond:  val_13, isWalking:  true, duration:  -1f);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_12 = 2;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_12 = 4;
            this.Model.SetAnimationFloat(animationFloat:  1.401298E-45f, value:  (this._state.UseMinSpeed == false) ? this._state.Config.FootstepSpeedScalar.Max : this._state.Config.FootstepSpeedScalar.Min);
            return;
            label_6:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase ChooseNextPhase()
        {
            if((Game.AttackSequence.Animatronic.PhaseManagement.LowBatteryDetector.ShouldCharge(blackboard:  this)) != false)
            {
                    return 7;
            }
            
            if(this._nextPhaseChance != null)
            {
                    return this._nextPhaseChance.GetRandomOption();
            }
            
            return this._nextPhaseChance.GetRandomOption();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Circle()
        {
            this.<AttackPhase>k__BackingField = 4;
            this._speedChangeChance = new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup(debugGroupName:  "CircleSpeedChange");
            this._nextPhaseChance = new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup(debugGroupName:  "CircleNextPhase");
            this = new System.Object();
        }
    
    }

}
