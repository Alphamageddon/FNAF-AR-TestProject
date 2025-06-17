using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HaywireData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HAYWIRE_CIRCLE_CHANCE = "HaywireCircleActivation";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HAYWIRE_CIRCLE_MODIFIER = "HaywireCircleActivationModifier";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HAYWIRE_PAUSE_CHANCE = "HaywirePauseActivation";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HAYWIRE_PAUSE_MODIFIER = "HaywirePauseActivationModifier";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HAYWIRE_CHARGE_CHANCE = "HaywireChargeActivation";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HAYWIRE_CHARGE_MODIFIER = "HaywireChargeActivationModifier";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HAYWIRE_LOOK_TIMER = "HaywireLookTimer";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData Seconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool ShockCausesJumpscare;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.HaywireMaskState RequiredMaskState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData LookAway;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData LookAt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData LookAtThenAway;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData LookChangeTriggerPercent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float LookTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Cooldown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float MaxCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.MultiwireData Multiwire;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData Circle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData Pause;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData Charge;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HaywireData(ProtoData.ATTACK_DATA.Types.HAYWIRE rawSettings)
        {
            PHASESETTINGS val_43;
            RANGE val_44;
            var val_45;
            bool val_46;
            int val_47;
            CHANCE val_48;
            CHANCE val_49;
            CHANCE val_50;
            RANGE val_51;
            float val_52;
            float val_53;
            float val_54;
            MULTIWIRE val_55;
            PHASESETTINGS val_56;
            val_43 = rawSettings;
            if(val_43 == null)
            {
                goto label_2;
            }
            
            SETTINGS val_1 = val_43.Settings;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            val_44 = val_1.Seconds;
            goto label_3;
            label_2:
            val_44 = 0;
            label_3:
            this.Seconds = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_44);
            if(val_43 == null)
            {
                goto label_6;
            }
            
            SETTINGS val_4 = val_43.Settings;
            if(val_4 == null)
            {
                goto label_6;
            }
            
            bool val_6 = val_4.ShockCausesJumpscare;
            val_45 = 0;
            goto label_7;
            label_6:
            val_45 = 0;
            label_7:
            if(((-784664580) & 1) == 0)
            {
                goto label_8;
            }
            
            val_46 = val_45.GetValueOrDefault();
            if(this != null)
            {
                goto label_11;
            }
            
            goto label_10;
            label_8:
            val_46 = false;
            if(this != null)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            this.ShockCausesJumpscare = val_46;
            if(val_43 == null)
            {
                goto label_13;
            }
            
            SETTINGS val_8 = val_43.Settings;
            if(val_8 == null)
            {
                goto label_13;
            }
            
            val_47 = val_8.RequiredMaskState;
            if(val_47 != null)
            {
                goto label_14;
            }
            
            label_13:
            val_47 = System.String.alignConst;
            label_14:
            if((System.Enum.TryParse<Game.ItemDefinition.Data.DataDefinitions.HaywireMaskState>(value:  val_47, ignoreCase:  true, result: out  this.RequiredMaskState)) != true)
            {
                    mem2[0] = 0;
            }
            
            if(val_43 == null)
            {
                goto label_19;
            }
            
            SETTINGS val_12 = val_43.Settings;
            if(val_12 == null)
            {
                goto label_19;
            }
            
            val_48 = val_12.ShouldLookAway;
            goto label_20;
            label_19:
            val_48 = 0;
            label_20:
            this.LookAway = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_48);
            if(val_43 == null)
            {
                goto label_23;
            }
            
            SETTINGS val_15 = val_43.Settings;
            if(val_15 == null)
            {
                goto label_23;
            }
            
            val_49 = val_15.ShouldLookAt;
            goto label_24;
            label_23:
            val_49 = 0;
            label_24:
            this.LookAt = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_49);
            if(val_43 == null)
            {
                goto label_27;
            }
            
            SETTINGS val_18 = val_43.Settings;
            if(val_18 == null)
            {
                goto label_27;
            }
            
            val_50 = val_18.ShouldLookAtThenAway;
            goto label_28;
            label_27:
            val_50 = 0;
            label_28:
            this.LookAtThenAway = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_50);
            if(val_43 == null)
            {
                goto label_31;
            }
            
            SETTINGS val_21 = val_43.Settings;
            if(val_21 == null)
            {
                goto label_31;
            }
            
            val_51 = val_21.LookChangeTriggerPercent;
            goto label_32;
            label_31:
            val_51 = 0;
            label_32:
            this.LookChangeTriggerPercent = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_51);
            if(val_43 == null)
            {
                goto label_35;
            }
            
            SETTINGS val_24 = val_43.Settings;
            if(val_24 == null)
            {
                goto label_35;
            }
            
            double val_25 = val_24.LookTime;
            goto label_36;
            label_35:
            label_36:
            val_52 = 0f;
            if(((-784664608) & 1) != 0)
            {
                    val_52 = (float)0.South;
            }
            
            this.LookTime = val_52;
            if(val_43 == null)
            {
                goto label_40;
            }
            
            SETTINGS val_27 = val_43.Settings;
            if(val_27 == null)
            {
                goto label_40;
            }
            
            double val_28 = val_27.Cooldown;
            goto label_41;
            label_40:
            label_41:
            val_53 = 0f;
            if(((-784664608) & 1) != 0)
            {
                    val_53 = (float)0.South;
            }
            
            this.Cooldown = val_53;
            if(val_43 == null)
            {
                goto label_45;
            }
            
            SETTINGS val_30 = val_43.Settings;
            if(val_30 == null)
            {
                goto label_45;
            }
            
            double val_31 = val_30.MaxCount;
            goto label_46;
            label_45:
            label_46:
            val_54 = 0f;
            if(((-784664608) & 1) != 0)
            {
                    val_54 = (float)0.South;
            }
            
            this.MaxCount = val_54;
            if(val_43 != null)
            {
                    val_55 = val_43.Multiwire;
            }
            else
            {
                    val_55 = 0;
            }
            
            this.Multiwire = new Game.ItemDefinition.Data.DataDefinitions.MultiwireData(rawSettings:  val_55);
            if(val_43 != null)
            {
                    this.Circle = new Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData(rawSettings:  val_43.Circle);
                val_56 = val_43.Pause;
            }
            else
            {
                    val_56 = 0;
                this.Circle = new Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData(rawSettings:  0);
            }
            
            this.Pause = new Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData(rawSettings:  val_56);
            if(val_43 != null)
            {
                    val_43 = val_43.Charge;
            }
            
            this.Charge = new Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData(rawSettings:  val_43);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HaywireData(Game.ItemDefinition.Data.DataDefinitions.RangeData seconds, bool shockCausesJumpscare, Game.ItemDefinition.Data.DataDefinitions.HaywireMaskState requiredMaskState, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData lookAway, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData lookAt, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData lookAtThenAway, Game.ItemDefinition.Data.DataDefinitions.RangeData lookChangeTriggerPercent, float lookTime, float cooldown, float maxCount, Game.ItemDefinition.Data.DataDefinitions.MultiwireData multiwire, Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData circle, Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData pause, Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData charge)
        {
            Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData val_1 = charge;
            val_1 = new System.Object();
            this.Seconds = seconds;
            this.RequiredMaskState = requiredMaskState;
            this.LookAway = lookAway;
            this.LookAt = lookAt;
            this.LookAtThenAway = lookAtThenAway;
            this.LookTime = lookTime;
            this.Cooldown = cooldown;
            this.MaxCount = maxCount;
            this.LookChangeTriggerPercent = lookChangeTriggerPercent;
            this.Multiwire = multiwire;
            this.Circle = circle;
            this.ShockCausesJumpscare = shockCausesJumpscare;
            this.Pause = pause;
            this.Charge = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HaywireData(Game.ItemDefinition.Data.DataDefinitions.HaywireData haywire, System.Collections.Generic.Dictionary<string, float> mods)
        {
            Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData val_7;
            val_1 = new System.Object();
            if(haywire != null)
            {
                    this.Seconds = haywire.Seconds;
                this.ShockCausesJumpscare = haywire.ShockCausesJumpscare;
                this.RequiredMaskState = haywire.RequiredMaskState;
                this.LookAway = haywire.LookAway;
                this.LookAt = haywire.LookAt;
                this.LookAtThenAway = haywire.LookAtThenAway;
                this.LookChangeTriggerPercent = haywire.LookChangeTriggerPercent;
            }
            else
            {
                    this.Seconds = 11993091;
                this.ShockCausesJumpscare = false;
                this.RequiredMaskState = 0;
                this.LookAway = 64;
                this.LookAt = 69077560;
                this.LookAtThenAway = 0;
                this.LookChangeTriggerPercent = 4194311;
            }
            
            this.LookTime = Game.ItemDefinition.Data.DataDefinitions.FloatHelper.ApplyModifier(baseValue:  haywire.LookTime, key:  "HaywireLookTimer", mods:  System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = mods);
            if(haywire != null)
            {
                    this.Cooldown = haywire.Cooldown;
                this.MaxCount = haywire.MaxCount;
                this.Multiwire = haywire.Multiwire;
            }
            else
            {
                    this.Cooldown = 7.006492E-45f;
                this.MaxCount = 0f;
                this.Multiwire = 0;
            }
            
            this.Circle = new Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData(phaseSettings:  haywire.Circle, chanceKey:  "HaywireCircleActivation", modifierKey:  "HaywireCircleActivationModifier", mods:  val_1);
            if(haywire != null)
            {
                    Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData val_4 = null;
                val_7 = val_4;
                val_4 = new Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData(phaseSettings:  haywire.Pause, chanceKey:  "HaywirePauseActivation", modifierKey:  "HaywirePauseActivationModifier", mods:  val_1);
                this.Pause = val_7;
            }
            else
            {
                    Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData val_5 = null;
                val_7 = val_5;
                val_5 = new Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData(phaseSettings:  62590012, chanceKey:  "HaywirePauseActivation", modifierKey:  "HaywirePauseActivationModifier", mods:  val_1);
                this.Pause = val_7;
            }
            
            this.Charge = new Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData(phaseSettings:  haywire.Charge, chanceKey:  "HaywireChargeActivation", modifierKey:  "HaywireChargeActivationModifier", mods:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.LookTime != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.LookTime == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.LookTime;
            val_1[1] = this.Circle;
            val_1[2] = this.Pause;
            val_1[3] = this.Charge;
            return (string)System.String.Format(format:  "{{\"LookTime\":{0},\"Circle\":{1},\"Pause\":{2},\"Charge\":{3}}}", args:  val_1);
        }
    
    }

}
