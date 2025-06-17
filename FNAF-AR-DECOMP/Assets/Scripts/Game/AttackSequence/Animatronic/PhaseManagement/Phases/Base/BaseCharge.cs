using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BaseCharge : Phase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase <AttackPhase>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base.ChargeState _state;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup _jumpscareChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup _delayJumpscareChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup _skipDelayedJumpscareChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup _nextPhaseChance;
        
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
            Game.AttackSequence.Static.PhaseStaticSettings val_57;
            var val_59;
            var val_60;
            var val_61;
            var val_64;
            var val_67;
            var val_70;
            var val_73;
            string val_76;
            var val_79;
            float val_85;
            float val_86;
            float val_87;
            float val_88;
            float val_91;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base.ChargeState val_92;
            float val_93;
            float val_94;
            var val_95;
            bool val_83 = static_value_04281000;
            var val_80 = static_value_04281000 + 176;
            var val_81 = 0;
            val_80 = val_80 + 8;
            val_81 = val_81 + 1;
            val_80 = val_80 + 16;
            val_57 = 3;
            if(Systems == null)
            {
                goto label_6;
            }
            
            var val_87 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_84 = X21 + 176;
            var val_85 = 0;
            val_84 = val_84 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_85 = val_85 + 1;
            val_84 = val_84 + 16;
            if(val_85 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_86 = val_84;
            val_86 = val_86 + 1;
            val_87 = val_87 + val_86;
            val_59 = val_87 + 296;
            label_12:
            var val_91 = X22;
            if((X22 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_88 = X22 + 176;
            var val_89 = 0;
            val_88 = val_88 + 8;
            label_16:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_89 = val_89 + 1;
            val_88 = val_88 + 16;
            if(val_89 < (X22 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            var val_90 = val_88;
            val_90 = val_90 + 5;
            val_91 = val_91 + val_90;
            val_60 = val_91 + 296;
            label_17:
            Game.AttackSequence.Static.StaticConfig val_3 = X22.StaticConfig;
            var val_95 = X23;
            if((X23 + 286) == 0)
            {
                goto label_23;
            }
            
            var val_92 = X23 + 176;
            var val_93 = 0;
            val_92 = val_92 + 8;
            label_22:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_93 = val_93 + 1;
            val_92 = val_92 + 16;
            if(val_93 < (X23 + 286))
            {
                goto label_22;
            }
            
            goto label_23;
            label_21:
            var val_94 = val_92;
            val_94 = val_94 + 6;
            val_95 = val_95 + val_94;
            val_61 = val_95 + 296;
            label_23:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4 = X23.AttackProfile;
            val_57 = val_3.Charge;
            val_1.AttackStatic.<Container>k__BackingField.UpdatePhaseStaticSettings(entityId:  X21.EntityId, settings:  val_57, shearModifier:  val_4.ShearModifier);
            label_6:
            var val_96 = 0;
            val_96 = val_96 + 1;
            val_57 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_6 = val_1.AttackStatic.<Container>k__BackingField.Model;
            var val_97 = 0;
            val_97 = val_97 + 1;
            val_57 = 8;
            val_64 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::RaiseAudioEventFromCpu(Game.Audio.AudioEventName eventName);
            val_6.RaiseAudioEventFromCpu(eventName:  0);
            var val_98 = 0;
            val_98 = val_98 + 1;
            val_64 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_9 = val_6.Model;
            var val_99 = 0;
            val_99 = val_99 + 1;
            val_64 = 15;
            val_67 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_9.SetCloakState(cloakEnabled:  true);
            var val_100 = 0;
            val_100 = val_100 + 1;
            val_67 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_12 = val_9.Model;
            var val_101 = 0;
            val_101 = val_101 + 1;
            val_67 = 18;
            val_70 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_12.SetEyeCloakState(eyeCloakEnabled:  false);
            var val_102 = 0;
            val_102 = val_102 + 1;
            val_70 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_15 = val_12.Model;
            var val_103 = 0;
            val_103 = val_103 + 1;
            val_70 = 13;
            val_73 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode);
            val_15.SetEyeColorMode(mode:  1);
            var val_104 = 0;
            val_104 = val_104 + 1;
            val_73 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_18 = val_15.Model;
            var val_105 = 0;
            val_105 = val_105 + 1;
            val_73 = 14;
            val_76 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeGlow(bool eyeGlowEnabled);
            val_18.SetEyeGlow(eyeGlowEnabled:  true);
            if(this._state != null)
            {
                    this._state.Reset();
            }
            else
            {
                    var val_106 = 0;
                val_106 = val_106 + 1;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_21 = val_18.AttackProfile;
                this._state = new Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base.ChargeState(config:  val_21.Charge);
                this._jumpscareChance.AddOption(id:  0, debugOptionName:  "NoJumpscare", baseChance:  1f - (Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base.ChargeState)[1152921525485612384].Config.JumpscareChance.Chance, modifier:  0f);
                this._jumpscareChance.AddOption(id:  1, debugOptionName:  "YesJumpscare", baseChance:  this._state.Config.JumpscareChance.Chance, modifier:  this._state.Config.JumpscareChance.Modifier);
                this._jumpscareChance._setupComplete = true;
                this._jumpscareChance.EnsureChanceRange();
                this._delayJumpscareChance.AddOption(id:  0, debugOptionName:  "NoJumpscareDelay", baseChance:  1f - this._state.Config.JumpscareDelayChance.Chance, modifier:  0f);
                this._delayJumpscareChance.AddOption(id:  1, debugOptionName:  "YesJumpscareDelay", baseChance:  this._state.Config.JumpscareDelayChance.Chance, modifier:  this._state.Config.JumpscareDelayChance.Modifier);
                this._delayJumpscareChance._setupComplete = true;
                this._delayJumpscareChance.EnsureChanceRange();
                this._skipDelayedJumpscareChance.AddOption(id:  0, debugOptionName:  "NoSkipDelayedJumpscare", baseChance:  1f - this._state.Config.SkipDelayedJumpscareChance.Chance, modifier:  0f);
                this._skipDelayedJumpscareChance.AddOption(id:  1, debugOptionName:  "YesSkipDelayedJumpscare", baseChance:  this._state.Config.SkipDelayedJumpscareChance.Chance, modifier:  this._state.Config.SkipDelayedJumpscareChance.Modifier);
                this._skipDelayedJumpscareChance._setupComplete = true;
                this._skipDelayedJumpscareChance.EnsureChanceRange();
                long val_27 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 4});
                this._nextPhaseChance.AddOption(id:  4, debugOptionName:  4.ToString(), baseChance:  this._state.Config.CircleChance.Chance, modifier:  this._state.Config.CircleChance.Modifier);
                long val_29 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 5});
                val_76 = 5.ToString();
                this._nextPhaseChance.AddOption(id:  5, debugOptionName:  val_76, baseChance:  this._state.Config.PauseChance.Chance, modifier:  this._state.Config.PauseChance.Modifier);
                this._nextPhaseChance._setupComplete = true;
                this._nextPhaseChance.EnsureChanceRange();
            }
            
            float val_116 = UnityEngine.Mathf.Max(a:  UnityEngine.Random.Range(min:  this._state.Config.Seconds.Min, max:  this._state.Config.Seconds.Max), b:  0.0001f);
            var val_107 = 0;
            val_107 = val_107 + 1;
            val_76 = 0;
            this._state.NumShocksRemaining = this._state.Config.ShockWindow.NumShocksRemaining;
            if((Game.AttackSequence.Animatronic.PhaseManagement.LowBatteryDetector.ShouldCharge(blackboard:  0)) == false)
            {
                goto label_159;
            }
            
            val_79 = 1;
            if(this._state != null)
            {
                goto label_163;
            }
            
            goto label_161;
            label_159:
            if(this._state != null)
            {
                goto label_163;
            }
            
            label_161:
            label_163:
            this._state.WillJumpscare = (this._jumpscareChance.GetRandomOption() > 0) ? 1 : 0;
            if(this._state.WillJumpscare != true)
            {
                    if(this.ShouldGoHaywire() != false)
            {
                    var val_108 = 0;
                val_108 = val_108 + 1;
                val_76 = 7;
                Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState val_40 = this._state.HaywireState;
                float val_109 = val_40.ActiveState.TriggerPercent;
                val_109 = val_116 * val_109;
                this._state.HaywireTimer.StartTimer(time:  val_109);
            }
            
            }
            
            var val_110 = 0;
            val_110 = val_110 + 1;
            val_76 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_42 = this._state.HaywireTimer.Model;
            var val_111 = 0;
            val_111 = val_111 + 1;
            val_76 = 12;
            var val_112 = 0;
            val_112 = val_112 + 1;
            val_76 = 2;
            var val_113 = 0;
            val_113 = val_113 + 1;
            val_76 = 33;
            Animatronics.Animatronic3d.Model.MovementSettings val_48 = val_42.Model.GetMovementSettings();
            if(this._state.WillJumpscare != false)
            {
                    this._state.WillDelayJumpscare = (this._delayJumpscareChance.GetRandomOption() > 0) ? 1 : 0;
                if(this._state.WillDelayJumpscare != false)
            {
                    this._state.JumpscareDelaySeconds = UnityEngine.Random.Range(min:  this._state.Config.JumpscareDelayTime.Min, max:  this._state.Config.JumpscareDelayTime.Max);
                this._state.WillSkipDelayedJumpscare = (this._skipDelayedJumpscareChance.GetRandomOption() > 0) ? 1 : 0;
            }
            
            }
            
            this._state.JumpscareRange = (this._state.WillDelayJumpscare == false) ? val_48.JumpscareDistance : val_48.DelayedJumpscareDistance;
            if(this._state != null)
            {
                    val_85 = this._state.JumpscareRange;
            }
            else
            {
                    val_85 = 1.85775E-36f;
            }
            
            float val_55 = (UnityEngine.Random.Range(min:  this._state.Config.ShockWindow.Min, max:  this._state.Config.ShockWindow.Max)) * val_48.AnimatedSpeed;
            val_55 = val_55 + val_85;
            val_55 = (val_44.ShockWindowOpenTime * val_48.AnimatedSpeed) + val_55;
            this._state.DecloakRange = val_55;
            if(this._state != null)
            {
                    val_86 = this._state.JumpscareRange;
                val_87 = val_44.CloakTime;
            }
            else
            {
                    val_86 = 1.85775E-36f;
                val_87 = val_44.CloakTime;
            }
            
            val_88 = val_86 + (val_48.AnimatedSpeed * val_87);
            this._state.CloakRange = val_88;
            var val_114 = 0;
            val_114 = val_114 + 1;
            val_76 = 3;
            if(val_42.GetCloakSettings().Systems == null)
            {
                goto label_223;
            }
            
            var val_115 = 0;
            val_115 = val_115 + 1;
            val_76 = 0;
            goto label_228;
            label_223:
            val_88 = 0f;
            goto label_229;
            label_228:
            float val_61 = val_59.Shocker.GetTotalMissCooldownTime();
            label_229:
            if(this._state != null)
            {
                    val_91 = this._state.JumpscareRange;
            }
            else
            {
                    val_91 = 1.85775E-36f;
            }
            
            val_61 = val_48.AnimatedSpeed * (val_61 + 0.25f);
            val_61 = val_61 + val_91;
            this._state.BlockExtraBatteryRange = val_61;
            val_92 = this._state;
            if(val_92 == null)
            {
                goto label_232;
            }
            
            val_93 = this._state.DecloakRange;
            val_94 = val_116 * val_48.AnimatedSpeed;
            goto label_233;
            label_232:
            if(this._state == null)
            {
                goto label_234;
            }
            
            val_93 = this._state.DecloakRange;
            val_94 = val_116 * val_48.AnimatedSpeed;
            val_92 = this._state;
            label_233:
            val_116 = val_94 + val_93;
            if(this._state.WillJumpscare != true)
            {
                    val_92 = this._state.Config;
                if(this._state.Config.UseFeintDistance != false)
            {
                    this._state.JumpscareRange = 0f;
                val_92 = this._state;
                this._state.DecloakRange = val_48.ChargeFeintDistance;
            }
            
            }
            
            float val_120 = val_48.ChargeFeintDistance;
            if((val_48.ChargeFeintDistance + 286) == 0)
            {
                goto label_243;
            }
            
            var val_117 = val_48.ChargeFeintDistance + 176;
            var val_118 = 0;
            val_117 = val_117 + 8;
            label_245:
            if(((val_48.ChargeFeintDistance + 176 + 8) + -8) == null)
            {
                goto label_244;
            }
            
            val_118 = val_118 + 1;
            val_117 = val_117 + 16;
            if(val_118 < (val_48.ChargeFeintDistance + 286))
            {
                goto label_245;
            }
            
            label_243:
            val_76 = 2;
            goto label_246;
            label_244:
            var val_119 = val_117;
            val_119 = val_119 + 2;
            val_120 = val_120 + val_119;
            val_95 = val_120 + 296;
            label_246:
            Animatronics.Animatronic3d.IAnimatronic3D val_63 = val_48.ChargeFeintDistance.Model;
            var val_121 = 0;
            val_121 = val_121 + 1;
            val_76 = 42;
            val_63.TeleportAtCurrentAngle(distanceFromCamera:  val_116);
            var val_122 = 0;
            val_122 = val_122 + 1;
            val_76 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_66 = val_63.Model;
            var val_123 = 0;
            val_123 = val_123 + 1;
            val_76 = 48;
            val_66.MoveInLineTowardCamera(unitsPerSecond:  val_48.AnimatedSpeed, isWalking:  false, duration:  -1f);
            var val_124 = 0;
            val_124 = val_124 + 1;
            Animatronics.Animatronic3d.IAnimatronic3D val_69 = val_66.Model;
            var val_125 = 0;
            val_125 = val_125 + 1;
            val_69.SetAnimationTrigger(animationTrigger:  1, shouldSet:  true);
            var val_126 = 0;
            val_126 = val_126 + 1;
            Animatronics.Animatronic3d.IAnimatronic3D val_72 = val_69.Model;
            var val_127 = 0;
            val_127 = val_127 + 1;
            var val_128 = 0;
            val_128 = val_128 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_76 = val_72.Systems;
            var val_129 = 0;
            val_129 = val_129 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_79 = this.Systems;
            val_79.Encounter.OnChargeStarted(angleFromCamera:  val_72.GetAbsoluteAngleFromCamera(), fov:  val_76.Camera.fieldOfView);
            return;
            label_234:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess val_24;
            var val_25;
            float val_27;
            int val_28;
            var val_29;
            var val_33;
            var val_36;
            var val_39;
            val_24 = this;
            bool val_38 = static_value_04281000;
            var val_35 = static_value_04281000 + 176;
            var val_36 = 0;
            val_35 = val_35 + 8;
            val_36 = val_36 + 1;
            val_35 = val_35 + 16;
            val_25 = 10;
            val_27 = DistanceFromCamera;
            if((val_27 <= this._state.BlockExtraBatteryRange) && (this._state.WillJumpscare != false))
            {
                    if(this._state.WillSkipDelayedJumpscare == false)
            {
                goto label_11;
            }
            
            }
            
            label_113:
            if(this._state.WaitingForJumpscareDelay == false)
            {
                goto label_13;
            }
            
            if(this._state.IsExpired() == false)
            {
                goto label_132;
            }
            
            if(this._state.WillSkipDelayedJumpscare == false)
            {
                goto label_98;
            }
            
            return this.ChooseNextPhase();
            label_13:
            val_28 = this._state.NumShocksRemaining;
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_29 = 0;
            if(val_28 != this._state.NumShocksRemaining)
            {
                goto label_24;
            }
            
            if((this._state.HaywireTimer.Started() == false) || (this._state.HaywireTimer.IsExpired() == false))
            {
                goto label_70;
            }
            
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_29 = 7;
            goto label_35;
            label_24:
            var val_41 = 0;
            val_41 = val_41 + 1;
            goto label_40;
            label_11:
            var val_42 = 0;
            val_42 = val_42 + 1;
            val_33 = 3;
            goto label_45;
            label_40:
            val_24 = this.Model;
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_24.CloseShockWindow();
            val_36 = 10;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_36;
            label_45:
            if(this._state.Systems == null)
            {
                goto label_113;
            }
            
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_33 = 3;
            if(val_11.Shocker.GetRemainingCooldownTime() <= 0f)
            {
                goto label_113;
            }
            
            var val_45 = 0;
            val_45 = val_45 + 1;
            val_33 = 3;
            goto label_63;
            label_35:
            var val_49 = val_28;
            if((this._state.NumShocksRemaining + 286) == 0)
            {
                goto label_65;
            }
            
            var val_46 = this._state.NumShocksRemaining + 176;
            var val_47 = 0;
            val_46 = val_46 + 8;
            label_67:
            if(((this._state.NumShocksRemaining + 176 + 8) + -8) == null)
            {
                goto label_66;
            }
            
            val_47 = val_47 + 1;
            val_46 = val_46 + 16;
            if(val_47 < (this._state.NumShocksRemaining + 286))
            {
                goto label_67;
            }
            
            label_65:
            val_29 = 9;
            goto label_68;
            label_66:
            var val_48 = val_46;
            val_48 = val_48 + 9;
            val_49 = val_49 + val_48;
            val_39 = val_49 + 296;
            label_68:
            if((this._state.HaywireTimer.HaywireState != null) && (val_15.ActiveState != null))
            {
                    if(val_15.ActiveState.Config.AllowedHalfAngle >= val_28.AbsoluteAngleFromCamera)
            {
                goto label_72;
            }
            
            }
            
            label_70:
            if(val_27 <= this._state.JumpscareRange)
            {
                goto label_74;
            }
            
            if(((this._state.WillDelayJumpscare == false) || (this._state.StartedCloak == true)) || (val_27 > this._state.CloakRange))
            {
                goto label_80;
            }
            
            this._state.StartedCloak = true;
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_29 = 2;
            goto label_86;
            label_74:
            var val_51 = 0;
            val_51 = val_51 + 1;
            var val_52 = 0;
            val_52 = val_52 + 1;
            this._state.Model.CloseShockWindow();
            if(this._state.WillDelayJumpscare == false)
            {
                goto label_98;
            }
            
            this._state.WaitingForJumpscareDelay = true;
            val_28 = this._state;
            val_27 = this._state.JumpscareDelaySeconds;
            this._state.StartTimer(time:  val_27);
            if(this._state.JumpscareDelaySeconds <= 0f)
            {
                goto label_132;
            }
            
            this.ExecuteChargeFeint(isJumpscareDelay:  true);
            goto label_132;
            label_98:
            val_36 = 9;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_36;
            label_63:
            if(val_11.Shocker.Systems == null)
            {
                goto label_113;
            }
            
            var val_53 = 0;
            val_53 = val_53 + 1;
            val_33 = 4;
            goto label_111;
            label_72:
            val_36 = 8;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_36;
            label_111:
            val_21.Battery.SetExtraBatteryBlocker(isBlocked:  true);
            goto label_113;
            label_86:
            Animatronics.Animatronic3d.IAnimatronic3D val_24 = this._state.Model;
            val_28 = 1152921505251147776;
            var val_54 = 0;
            val_54 = val_54 + 1;
            val_29 = 16;
            val_24.BeginCloak();
            var val_55 = 0;
            val_55 = val_55 + 1;
            val_29 = 2;
            var val_56 = 0;
            val_56 = val_56 + 1;
            val_29 = 19;
            val_24.Model.BeginEyeCloak();
            label_80:
            if((this._state.StartedDecloak != true) && (val_27 <= this._state.DecloakRange))
            {
                    if(this._state.WillJumpscare != false)
            {
                    var val_57 = 0;
                val_57 = val_57 + 1;
                val_29 = 2;
            }
            else
            {
                    this.ExecuteChargeFeint(isJumpscareDelay:  false);
                Game.AttackSequence.Animatronic.TeleportReposition.NormalTeleport(blackboard:  this);
                return this.ChooseNextPhase();
            }
            
                val_28 = 1152921505251147776;
                var val_58 = 0;
                val_58 = val_58 + 1;
                val_29 = 9;
                this._state.Model.RaiseAudioEventFromPlushSuit(eventName:  5);
                this._state.StartedDecloak = true;
                var val_59 = 0;
                val_59 = val_59 + 1;
                val_24 = this.Model;
                var val_60 = 0;
                val_60 = val_60 + 1;
                val_24.BeginDecloak();
            }
            
            label_132:
            val_36 = 0;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_36;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            var val_8;
            var val_10;
            var val_13;
            var val_16;
            bool val_18 = static_value_04281000;
            var val_15 = static_value_04281000 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            val_8 = 3;
            if(Systems == null)
            {
                goto label_6;
            }
            
            var val_22 = X21;
            if((X21 + 286) == 0)
            {
                goto label_9;
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
            
            label_9:
            val_8 = 1;
            goto label_12;
            label_10:
            var val_21 = val_19;
            val_21 = val_21 + 1;
            val_22 = val_22 + val_21;
            val_10 = val_22 + 296;
            label_12:
            val_1.AttackStatic.<Container>k__BackingField.ClearPhaseStaticSettings(entityId:  X21.EntityId);
            label_6:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_8 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_1.AttackStatic.<Container>k__BackingField.Model;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_8 = 15;
            val_13 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_4.SetCloakState(cloakEnabled:  true);
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_13 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_7 = val_4.Model;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_13 = 18;
            val_16 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_7.SetEyeCloakState(eyeCloakEnabled:  true);
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_16 = 2;
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_16 = 14;
            val_7.Model.SetEyeGlow(eyeGlowEnabled:  false);
            var val_29 = 0;
            val_29 = val_29 + 1;
            var val_30 = 0;
            val_30 = val_30 + 1;
            this.Model.StopMoving();
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
            Game.AttackSequence.Animatronic.PhaseManagement.HaywireActivator.CalculateActivation(haywireState:  HaywireState, sourcePhase:  7);
            var val_9 = 0;
            val_9 = val_9 + 1;
            Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState val_3 = this.HaywireState;
            return (bool)(val_3.ActiveState != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ExecuteChargeFeint(bool isJumpscareDelay)
        {
            var val_10;
            var val_13;
            var val_15;
            var val_18;
            var val_21;
            bool val_21 = static_value_04281000;
            var val_18 = static_value_04281000 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            val_10 = 2;
            Game.Audio.AudioEventName val_2 = ((isJumpscareDelay & true) != 0) ? (1 + 1) : 1;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_10 = 8;
            Model.RaiseAudioEventFromCpu(eventName:  val_2);
            var val_26 = val_2;
            if(((isJumpscareDelay & true)!=0 ? (1 + 1) : 1 + 286) == 0)
            {
                goto label_15;
            }
            
            var val_23 = (isJumpscareDelay & true)!=0 ? (1 + 1) : 1 + 176;
            var val_24 = 0;
            val_23 = val_23 + 8;
            label_14:
            if((((isJumpscareDelay & true)!=0 ? (1 + 1) : 1 + 176 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_24 = val_24 + 1;
            val_23 = val_23 + 16;
            if(val_24 < ((isJumpscareDelay & true)!=0 ? (1 + 1) : 1 + 286))
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            var val_25 = val_23;
            val_25 = val_25 + 2;
            val_26 = val_26 + val_25;
            val_13 = val_26 + 296;
            label_15:
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_2.Model;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_15 = 1;
            val_4.SetAnimationTrigger(animationTrigger:  2, shouldSet:  true);
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_15 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_7 = val_4.Model;
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_15 = 15;
            val_18 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_7.SetCloakState(cloakEnabled:  true);
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_18 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_10 = val_7.Model;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_18 = 18;
            val_21 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_10.SetEyeCloakState(eyeCloakEnabled:  true);
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_21 = 2;
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_21 = 14;
            val_10.Model.SetEyeGlow(eyeGlowEnabled:  false);
            var val_34 = 0;
            val_34 = val_34 + 1;
            var val_35 = 0;
            val_35 = val_35 + 1;
            this.Model.StopMoving();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase ChooseNextPhase()
        {
            int val_1 = this._nextPhaseChance.GetRandomOption();
            if(val_1 != 5)
            {
                    return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_1;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.ForceCircleAfterPause = (this._state.Config.ForceCircleAfterPause == true) ? 1 : 0;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BaseCharge()
        {
            this.<AttackPhase>k__BackingField = 7;
            this._jumpscareChance = new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup(debugGroupName:  "ChargeJumpscare");
            this._delayJumpscareChance = new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup(debugGroupName:  "ChargeDelayJumpscareChance");
            this._skipDelayedJumpscareChance = new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup(debugGroupName:  "ChargeSkipDelayedJumpscareChance");
            this._nextPhaseChance = new Game.AttackSequence.Animatronic.PhaseManagement.RandomChance.RandomChanceGroup(debugGroupName:  "ChargeNextPhase");
            this = new System.Object();
        }
    
    }

}
