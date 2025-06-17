using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Haywire : Phase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase <AttackPhase>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.HaywireState _state;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup _haywireTypeChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup _nextPhaseChance;
        
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
            float val_10;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.HaywireState val_11;
            float val_12;
            if(this._state == null)
            {
                    bool val_12 = static_value_04281000;
                var val_9 = static_value_04281000 + 176;
                var val_10 = 0;
                val_9 = val_9 + 8;
                val_10 = val_10 + 1;
                val_9 = val_9 + 16;
                this._state = new Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.HaywireState(globalState:  HaywireState);
                this.BuildHaywireTypeChance();
                this.BuildNextPhaseChance();
            }
            
            0.Reset();
            int val_3 = this._haywireTypeChance.GetRandomOption();
            val_10 = this._state.Config.Seconds.Min;
            this._state.Duration = UnityEngine.Random.Range(min:  val_10, max:  this._state.Config.Seconds.Max);
            val_11 = this._state;
            this._state.LookAway = (val_3 == 0) ? 1 : 0;
            if(val_3 == 2)
            {
                    val_11 = this._state;
                float val_7 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Random.Range(min:  this._state.Config.LookChangeTriggerPercent.Min, max:  this._state.Config.LookChangeTriggerPercent.Max), min:  0f, max:  1f);
                val_10 = this._state.Duration * val_7;
                if(this._state != null)
            {
                    val_12 = this._state.Duration;
            }
            else
            {
                    val_12 = 8.96831E-44f;
            }
            
                val_7 = val_12 - val_10;
                this._state.LookSwapTime = val_7;
            }
            
            if(this._state.GlobalState.UseMultiwire() != false)
            {
                    this.StartMultiwire();
                return;
            }
            
            this.StartHaywire();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            Game.ItemDefinition.Data.DataDefinitions.RangeData val_28;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.HaywireState val_29;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.HaywireState val_30;
            float val_31;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.HaywireState val_33;
            bool val_34;
            var val_35;
            var val_38;
            var val_40;
            var val_41;
            var val_42;
            Game.CameraEquipment.Mask.IMask val_43;
            var val_45;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.HaywireState val_48;
            float val_49;
            float val_50;
            var val_51;
            var val_52;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.HaywireState val_53;
            Game.ItemDefinition.Data.DataDefinitions.HaywireData val_54;
            float val_55;
            var val_56;
            val_28 = this;
            bool val_1 = this._state.HiddenTimer.Started();
            val_29 = this._state;
            if(val_29 == null)
            {
                goto label_3;
            }
            
            if(val_1 == false)
            {
                goto label_4;
            }
            
            label_20:
            if(this._state.HiddenTimer.IsExpired() == false)
            {
                    return 0;
            }
            
            this._state.HiddenTimer.Reset();
            this.RepositionForMultiwire();
            this.BeginHaywireEffect();
            val_30 = this._state;
            if(this._state != null)
            {
                goto label_9;
            }
            
            val_30 = this._state;
            if(val_30 == null)
            {
                goto label_116;
            }
            
            label_9:
            val_29 = this._state.Config.Multiwire.LocateTime;
            val_28 = this._state.Config.Multiwire.LocateTime;
            val_31 = UnityEngine.Random.Range(min:  this._state.Config.Multiwire.LocateTime.Min, max:  this._state.Config.Multiwire.LocateTime.Max);
            if(this._state.LocateTimer != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_3:
            if(val_1 == true)
            {
                goto label_20;
            }
            
            label_4:
            if(this._state.LocateTimer.Started() == false)
            {
                goto label_22;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            goto label_27;
            label_22:
            if(((this._state.LookSwapTime < 0f) || (this._state.Started() == false)) || (this._state.LookSwapTime < this._state.GetRemainingTime()))
            {
                goto label_34;
            }
            
            val_33 = this._state;
            if(val_33 == null)
            {
                goto label_35;
            }
            
            val_34 = this._state.LookAway;
            goto label_36;
            label_27:
            if(this._state.LocateTimer.IsAABBOnScreen != true)
            {
                    if(this._state.LocateTimer.IsExpired() == false)
            {
                    return 0;
            }
            
            }
            
            this._state.LocateTimer.Reset();
            val_31 = this._state.Duration;
            label_19:
            this.StartTimer(time:  val_31);
            return 0;
            label_35:
            val_33 = 36;
            val_34 = 0;
            label_36:
            mem[36] = 1;
            this._state.LookSwapTime = -1f;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_35 = 2;
            var val_37 = this._state.Model;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_35 = 13;
            val_38 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode);
            val_37.SetEyeColorMode(mode:  (this._state.LookAway == true) ? (2 + 1) : 2);
            label_34:
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_38 = 11;
            val_37 = ((this._state.LookAway == true) ? 1 : 0) ^ val_37.IsAABBOnScreen;
            var val_18 = (this._state.Config.RequiredMaskState == 0) ? 1 : 0;
            val_18 = val_18 | val_37 ^ 1;
            if(val_18 == true)
            {
                goto label_69;
            }
            
            if(this._state.Config.RequiredMaskState == 2)
            {
                goto label_68;
            }
            
            if(this._state.Config.RequiredMaskState != 1)
            {
                goto label_69;
            }
            
            var val_43 = val_37;
            if(((this._state.LookAway == true ? 1 : 0 ^ val_16) + 286) == 0)
            {
                goto label_71;
            }
            
            var val_38 = (this._state.LookAway == true ? 1 : 0 ^ val_16) + 176;
            var val_39 = 0;
            val_38 = val_38 + 8;
            label_73:
            if((((this._state.LookAway == true ? 1 : 0 ^ val_16) + 176 + 8) + -8) == null)
            {
                goto label_72;
            }
            
            val_39 = val_39 + 1;
            val_38 = val_38 + 16;
            if(val_39 < ((this._state.LookAway == true ? 1 : 0 ^ val_16) + 286))
            {
                goto label_73;
            }
            
            label_71:
            val_38 = 3;
            goto label_74;
            label_69:
            if(val_37 == false)
            {
                goto label_75;
            }
            
            label_96:
            val_41 = 0;
            this._state.HasTriggeredCounter = false;
            goto label_77;
            label_68:
            var val_46 = val_37;
            if(((this._state.LookAway == true ? 1 : 0 ^ val_16) + 286) == 0)
            {
                goto label_79;
            }
            
            var val_40 = (this._state.LookAway == true ? 1 : 0 ^ val_16) + 176;
            var val_41 = 0;
            val_40 = val_40 + 8;
            label_81:
            if((((this._state.LookAway == true ? 1 : 0 ^ val_16) + 176 + 8) + -8) == null)
            {
                goto label_80;
            }
            
            val_41 = val_41 + 1;
            val_40 = val_40 + 16;
            if(val_41 < ((this._state.LookAway == true ? 1 : 0 ^ val_16) + 286))
            {
                goto label_81;
            }
            
            label_79:
            val_38 = 3;
            goto label_82;
            label_72:
            var val_42 = val_38;
            val_42 = val_42 + 3;
            val_43 = val_43 + val_42;
            val_40 = val_43 + 296;
            label_74:
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_19 = val_37.Systems;
            val_43 = val_19.Mask;
            val_45 = null;
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_38 = 1;
            goto label_94;
            label_80:
            var val_45 = val_40;
            val_45 = val_45 + 3;
            val_46 = val_46 + val_45;
            val_42 = val_46 + 296;
            label_82:
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_20 = val_37.Systems;
            val_43 = val_20.Mask;
            val_45 = null;
            var val_47 = 0;
            val_47 = val_47 + 1;
            val_38 = 2;
            label_94:
            if(val_43.IsMaskFullyOff() == true)
            {
                goto label_96;
            }
            
            label_75:
            val_41 = 1;
            label_77:
            var val_23 = (this._state.HasTriggeredCounter == true) ? 1 : 0;
            val_23 = val_41 & val_23;
            if(val_23 != 1)
            {
                goto label_98;
            }
            
            val_48 = this._state;
            if(val_48 == null)
            {
                goto label_99;
            }
            
            val_49 = this._state.CumulativeLookTime;
            val_50 = UnityEngine.Time.deltaTime;
            goto label_100;
            label_98:
            if(val_41 == 0)
            {
                goto label_103;
            }
            
            this._state.HasTriggeredCounter = true;
            goto label_103;
            label_99:
            val_48 = 48;
            val_49 = 0f;
            float val_25 = UnityEngine.Time.deltaTime;
            val_50 = val_25;
            label_100:
            val_25 = val_50 + val_49;
            mem[48] = val_25;
            label_103:
            float val_51 = mem[48];
            if(((val_25 + val_49) + 286) == 0)
            {
                goto label_105;
            }
            
            var val_48 = (val_25 + val_49) + 176;
            var val_49 = 0;
            val_48 = val_48 + 8;
            label_107:
            if((((val_25 + val_49) + 176 + 8) + -8) == null)
            {
                goto label_106;
            }
            
            val_49 = val_49 + 1;
            val_48 = val_48 + 16;
            if(val_49 < ((val_25 + val_49) + 286))
            {
                goto label_107;
            }
            
            label_105:
            val_38 = 18;
            goto label_108;
            label_106:
            var val_50 = val_48;
            val_50 = val_50 + 18;
            val_51 = val_51 + val_50;
            val_51 = val_51 + 296;
            label_108:
            if(mem[48].ShockedDuringHaywire == false)
            {
                goto label_109;
            }
            
            float val_55 = mem[48];
            if(((val_25 + val_49) + 286) == 0)
            {
                goto label_111;
            }
            
            var val_52 = (val_25 + val_49) + 176;
            var val_53 = 0;
            val_52 = val_52 + 8;
            label_113:
            if((((val_25 + val_49) + 176 + 8) + -8) == null)
            {
                goto label_112;
            }
            
            val_53 = val_53 + 1;
            val_52 = val_52 + 16;
            if(val_53 < ((val_25 + val_49) + 286))
            {
                goto label_113;
            }
            
            label_111:
            val_38 = 19;
            goto label_114;
            label_109:
            val_53 = this._state;
            if(this._state != null)
            {
                goto label_115;
            }
            
            val_53 = this._state;
            if(val_53 == null)
            {
                goto label_116;
            }
            
            label_115:
            val_54 = this._state.Config;
            val_55 = this._state.CumulativeLookTime;
            if(val_55 >= this._state.Config.LookTime)
            {
                    return 0;
            }
            
            if(this._state.IsExpired() == false)
            {
                    return 0;
            }
            
            this.PrepareForNonJumpscareExit();
            val_56 = 1;
            return this.ChooseNextPhase(shouldCheckForMultiwire:  false);
            label_112:
            var val_54 = val_52;
            val_54 = val_54 + 19;
            val_55 = val_55 + val_54;
            val_52 = val_55 + 296;
            label_114:
            mem[48].ShockedDuringHaywire = false;
            if(this._state.Config.ShockCausesJumpscare != false)
            {
                    return 0;
            }
            
            var val_56 = 0;
            val_56 = val_56 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_29 = this._state.Config.Systems;
            var val_57 = 0;
            val_57 = val_57 + 1;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_31 = this._state.AttackProfile;
            val_54 = val_31.Battery;
            val_55 = val_31.Battery.HaywireShockDrain;
            var val_58 = 0;
            val_58 = val_58 + 1;
            val_29.Battery.DrainCharge(drainAmount:  val_55);
            this.PrepareForNonJumpscareExit();
            val_56 = 0;
            return this.ChooseNextPhase(shouldCheckForMultiwire:  false);
            label_116:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            this.EndHaywireEffect();
            if((this._state.GlobalState.IsMultiwireActive != false) && (this._state.GlobalState.RemainingActivations != 0))
            {
                    return;
            }
            
            this._state.GlobalState.ActiveState = 0;
            this._state.GlobalState.Cooldown.StartTimer(time:  this._state.Config.Cooldown);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildHaywireTypeChance()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup val_1 = new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup(debugGroupName:  "HaywireLookType");
            this._haywireTypeChance = val_1;
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime());
            val_1.AddOption(id:  0, debugOptionName:  0.ToString(), baseChance:  this._state.Config.LookAway.Chance, modifier:  this._state.Config.LookAway.Modifier);
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1});
            this._haywireTypeChance.AddOption(id:  1, debugOptionName:  1.ToString(), baseChance:  this._state.Config.LookAt.Chance, modifier:  this._state.Config.LookAt.Modifier);
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 2});
            this._haywireTypeChance.AddOption(id:  2, debugOptionName:  2.ToString(), baseChance:  this._state.Config.LookAtThenAway.Chance, modifier:  this._state.Config.LookAtThenAway.Modifier);
            this._haywireTypeChance._setupComplete = true;
            this._haywireTypeChance.EnsureChanceRange();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildNextPhaseChance()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup val_1 = new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup(debugGroupName:  "HaywireNextPhase");
            this._nextPhaseChance = val_1;
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 4});
            val_1.AddOption(id:  4, debugOptionName:  4.ToString(), baseChance:  this._state.GlobalState.ActiveState.Config.CircleChance.Chance, modifier:  this._state.GlobalState.ActiveState.Config.CircleChance.Modifier);
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 5});
            this._nextPhaseChance.AddOption(id:  5, debugOptionName:  5.ToString(), baseChance:  this._state.GlobalState.ActiveState.Config.PauseChance.Chance, modifier:  this._state.GlobalState.ActiveState.Config.PauseChance.Modifier);
            this._nextPhaseChance._setupComplete = true;
            this._nextPhaseChance.EnsureChanceRange();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartHaywire()
        {
            var val_5;
            var val_7;
            var val_9;
            if(this._state.GlobalState.ActiveState != null)
            {
                    var val_1 = (this._state.GlobalState.ActiveState.Config.TeleportToCamera == true) ? 1 : 0;
            }
            else
            {
                    val_5 = 0;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            var val_12 = X21;
            if((X21 + 286) == 0)
            {
                goto label_15;
            }
            
            var val_9 = X21 + 176;
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_14:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < (X21 + 286))
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            var val_11 = val_9;
            val_11 = val_11 + 2;
            val_12 = val_12 + val_11;
            val_7 = val_12 + 296;
            label_15:
            var val_13 = 0;
            val_13 = val_13 + 1;
            Animatronics.Animatronic3d.Model.MovementSettings val_6 = X21.Model.GetMovementSettings();
            if(val_5 != 0)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_9 = 41;
            }
            else
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_9 = 42;
            }
            
            this._state.GlobalState.Model.TeleportAtCurrentAngle(distanceFromCamera:  val_6.HaywireDistance);
            this.BeginHaywireEffect();
            this.StartTimer(time:  this._state.Duration);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartMultiwire()
        {
            Game.ItemDefinition.Data.DataDefinitions.RangeData val_4;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.HaywireState val_5;
            Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState val_6;
            int val_7;
            if(this._state == null)
            {
                goto label_2;
            }
            
            if(this._state.GlobalState.IsMultiwireActive == false)
            {
                goto label_3;
            }
            
            label_14:
            val_4 = this._state.Config.Multiwire.HiddenTime;
            this._state.HiddenTimer.StartTimer(time:  UnityEngine.Random.Range(min:  this._state.Config.Multiwire.HiddenTime.Min, max:  this._state.Config.Multiwire.HiddenTime.Max));
            goto label_13;
            label_2:
            if(this._state.GlobalState.IsMultiwireActive == true)
            {
                goto label_14;
            }
            
            label_3:
            this._state.GlobalState.IsMultiwireActive = true;
            val_5 = this._state;
            if(this._state != null)
            {
                goto label_16;
            }
            
            val_5 = this._state;
            if(val_5 == null)
            {
                goto label_17;
            }
            
            label_16:
            val_4 = this._state.GlobalState;
            this._state.GlobalState.RemainingActivations = UnityEngine.Random.Range(min:  this._state.Config.Multiwire.Count.Min, max:  this._state.Config.Multiwire.Count.Max + 1);
            this.StartHaywire();
            label_13:
            val_6 = this._state.GlobalState;
            if(val_6 != null)
            {
                    val_7 = this._state.GlobalState.RemainingActivations;
            }
            else
            {
                    val_6 = 84;
                val_7 = 0;
            }
            
            mem[84] = -1;
            return;
            label_17:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RepositionForMultiwire()
        {
            var val_8 = 0;
            float val_14 = UnityEngine.Random.Range(min:  this._state.Config.Multiwire.HalfAngle.Min, max:  this._state.Config.Multiwire.HalfAngle.Max);
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_8 = 2;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_8 = 2;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_8 = 33;
            Animatronics.Animatronic3d.Model.MovementSettings val_9 = this._state.Config.Multiwire.HalfAngle.Model.GetMovementSettings();
            val_14 = val_14 * (((UnityEngine.Random.Range(min:  0, max:  2)) > 0) ? -1f : 1f);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_8 = 39;
            this._state.Config.Multiwire.HalfAngle.Model.Teleport(angleFromCamera:  val_14, distanceFromCamera:  val_9.HaywireDistance, faceCamera:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BeginHaywireEffect()
        {
            var val_12;
            var val_18;
            var val_21;
            var val_24;
            var val_27;
            bool val_24 = static_value_04281000;
            var val_21 = static_value_04281000 + 176;
            var val_22 = 0;
            val_21 = val_21 + 8;
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            val_12 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_1 = Model;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_12 = 8;
            val_1.RaiseAudioEventFromCpu(eventName:  14);
            var val_26 = 0;
            val_26 = val_26 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_4 = val_1.Systems;
            val_4.HaywireFxController.SetStrength(strength:  1f);
            var val_27 = 0;
            val_27 = val_27 + 1;
            Animatronics.Animatronic3d.IAnimatronic3D val_6 = val_4.HaywireFxController.Model;
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_18 = 1;
            val_6.SetAnimationTrigger(animationTrigger:  3, shouldSet:  true);
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_18 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_9 = val_6.Model;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_18 = 15;
            val_21 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_9.SetCloakState(cloakEnabled:  false);
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_21 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_12 = val_9.Model;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_21 = 18;
            val_24 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_12.SetEyeCloakState(eyeCloakEnabled:  false);
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_24 = 2;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_24 = 13;
            val_27 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode);
            val_12.Model.SetEyeColorMode(mode:  (this._state.LookAway == true) ? (2 + 1) : 2);
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_27 = 2;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_27 = 14;
            this.Model.SetEyeGlow(eyeGlowEnabled:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EndHaywireEffect()
        {
            var val_9;
            var val_12;
            var val_16;
            var val_19;
            var val_22;
            bool val_20 = static_value_04281000;
            var val_17 = static_value_04281000 + 176;
            var val_18 = 0;
            val_17 = val_17 + 8;
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            val_9 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_1 = Model;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_9 = 8;
            val_12 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            val_1.RaiseAudioEventFromCpu(eventName:  15);
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_12 = 3;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_4 = val_1.Systems;
            val_4.HaywireFxController.SetStrength(strength:  0f);
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_12 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_6 = val_4.HaywireFxController.Model;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_12 = 15;
            val_16 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_6.SetCloakState(cloakEnabled:  true);
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_16 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_9 = val_6.Model;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_16 = 18;
            val_19 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_9.SetEyeCloakState(eyeCloakEnabled:  true);
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_19 = 2;
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_19 = 13;
            val_22 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode);
            val_9.Model.SetEyeColorMode(mode:  0);
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_22 = 2;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_22 = 14;
            this.Model.SetEyeGlow(eyeGlowEnabled:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PrepareForNonJumpscareExit()
        {
            bool val_6 = static_value_04281000;
            var val_3 = static_value_04281000 + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            Animatronics.Animatronic3d.IAnimatronic3D val_1 = Model;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_1.SetAnimationTrigger(animationTrigger:  4, shouldSet:  true);
            Game.AttackSequence.Animatronic.TeleportReposition.NormalTeleport(blackboard:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase ChooseNextPhase(bool shouldCheckForMultiwire)
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(((shouldCheckForMultiwire != false) && (this._state.GlobalState.IsMultiwireActive != false)) && (this._state.GlobalState.RemainingActivations > 0))
            {
                    val_6 = 8;
                return 5;
            }
            
            if((Game.AttackSequence.Animatronic.PhaseManagement.LowBatteryDetector.ShouldCharge(blackboard:  25809)) != false)
            {
                    val_6 = 7;
                return 5;
            }
            
            val_6 = this._nextPhaseChance;
            if(val_6.GetRandomOption() != 5)
            {
                    return 5;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.ForceCircleAfterPause = (this._state.GlobalState.ActiveState.Config.ForceCircleAfterPause == true) ? 1 : 0;
            val_6 = 5;
            return 5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Haywire()
        {
            this.<AttackPhase>k__BackingField = 8;
            val_1 = new System.Object();
        }
    
    }

}
