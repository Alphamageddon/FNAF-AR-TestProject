using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SurgeData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SURGE_CHANCE = "ChanceToSurge";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SURGE_CHANCE_MODIFIER = "ChanceToSurgeModifier";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SURGE_CANCEL_DURATION = "SurgeCancelDuration";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData Seconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData ActivationChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float CancelTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.SurgeMechanic.SurgeCancelAction CancelAction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float BatteryDrainRateBase;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float BatteryDrainRateCancel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float BatterySurgeBlinkDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float BatterySurgeMaskLightFadeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly MoreMountains.NiceVibrations.HapticTypes HapticCue;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SurgeData(ProtoData.ATTACK_DATA.Types.SURGE rawSettings)
        {
            RANGE val_30;
            CHANCE val_31;
            int val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            int val_37;
            if(rawSettings == null)
            {
                goto label_2;
            }
            
            SETTINGS val_1 = rawSettings.Settings;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            val_30 = val_1.Cooldown;
            goto label_3;
            label_2:
            val_30 = 0;
            label_3:
            this.Seconds = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_30);
            if(rawSettings == null)
            {
                goto label_6;
            }
            
            SETTINGS val_4 = rawSettings.Settings;
            if(val_4 == null)
            {
                goto label_6;
            }
            
            val_31 = val_4.Activation;
            goto label_7;
            label_6:
            val_31 = 0;
            label_7:
            this.ActivationChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_31);
            if(rawSettings == null)
            {
                goto label_10;
            }
            
            SETTINGS val_7 = rawSettings.Settings;
            if(val_7 == null)
            {
                goto label_10;
            }
            
            double val_8 = val_7.CancelTime;
            goto label_11;
            label_10:
            label_11:
            this.CancelTime = (float)0.South;
            if(rawSettings == null)
            {
                goto label_14;
            }
            
            SETTINGS val_10 = rawSettings.Settings;
            if(val_10 == null)
            {
                goto label_14;
            }
            
            val_32 = val_10.CancelAction;
            if(val_32 != null)
            {
                goto label_15;
            }
            
            label_14:
            val_32 = System.String.alignConst;
            label_15:
            if((System.Enum.TryParse<Game.AttackSequence.SurgeMechanic.SurgeCancelAction>(value:  val_32, ignoreCase:  true, result: out  this.CancelAction)) != true)
            {
                    mem2[0] = 0;
            }
            
            if(rawSettings == null)
            {
                goto label_20;
            }
            
            SETTINGS val_14 = rawSettings.Settings;
            if(val_14 == null)
            {
                goto label_20;
            }
            
            double val_15 = val_14.BatteryDrainRateBase;
            goto label_21;
            label_20:
            label_21:
            val_33 = 0f;
            if(((-782361856) & 1) != 0)
            {
                    val_33 = (float)0.South;
            }
            
            this.BatteryDrainRateBase = val_33;
            if(rawSettings == null)
            {
                goto label_24;
            }
            
            SETTINGS val_17 = rawSettings.Settings;
            if(val_17 == null)
            {
                goto label_24;
            }
            
            double val_18 = val_17.BatteryDrainRateCancel;
            goto label_25;
            label_24:
            label_25:
            val_34 = 0f;
            if(((-782361856) & 1) != 0)
            {
                    val_34 = (float)0.South;
            }
            
            this.BatteryDrainRateCancel = val_34;
            if(rawSettings == null)
            {
                goto label_28;
            }
            
            SETTINGS val_20 = rawSettings.Settings;
            if(val_20 == null)
            {
                goto label_28;
            }
            
            double val_21 = val_20.BlinkDuration;
            goto label_29;
            label_28:
            label_29:
            val_35 = 0f;
            if(((-782361856) & 1) != 0)
            {
                    val_35 = (float)0.South;
            }
            
            this.BatterySurgeBlinkDuration = val_35;
            if(rawSettings == null)
            {
                goto label_32;
            }
            
            SETTINGS val_23 = rawSettings.Settings;
            if(val_23 == null)
            {
                goto label_32;
            }
            
            double val_24 = val_23.MaskLightFadeTime;
            goto label_33;
            label_32:
            label_33:
            val_36 = 0f;
            if(((-782361856) & 1) != 0)
            {
                    val_36 = (float)0.South;
            }
            
            this.BatterySurgeMaskLightFadeTime = val_36;
            if(rawSettings == null)
            {
                goto label_36;
            }
            
            SETTINGS val_26 = rawSettings.Settings;
            if(val_26 == null)
            {
                goto label_36;
            }
            
            val_37 = val_26.HapticCue;
            if(val_37 != null)
            {
                goto label_37;
            }
            
            label_36:
            val_37 = System.String.alignConst;
            label_37:
            if((System.Enum.TryParse<MoreMountains.NiceVibrations.HapticTypes>(value:  val_37, ignoreCase:  true, result: out  this.HapticCue)) == true)
            {
                    return;
            }
            
            mem2[0] = 7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SurgeData(Game.ItemDefinition.Data.DataDefinitions.SurgeData surge, System.Collections.Generic.Dictionary<string, float> mods)
        {
            val_1 = new System.Object();
            if(surge != null)
            {
                    this.Seconds = surge.Seconds;
            }
            else
            {
                    this.Seconds = 11993091;
            }
            
            this.ActivationChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(chance:  surge.ActivationChance, chanceKey:  "ChanceToSurge", modifierKey:  "ChanceToSurgeModifier", mods:  System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = mods);
            if(surge != null)
            {
                    this.CancelTime = Game.ItemDefinition.Data.DataDefinitions.FloatHelper.ApplyModifier(baseValue:  surge.CancelTime, key:  "SurgeCancelDuration", mods:  val_1);
                this.CancelAction = surge.CancelAction;
                this.BatteryDrainRateBase = surge.BatteryDrainRateBase;
                this.BatteryDrainRateCancel = surge.BatteryDrainRateCancel;
                this.BatterySurgeBlinkDuration = surge.BatterySurgeBlinkDuration;
                this.BatterySurgeMaskLightFadeTime = surge.BatterySurgeMaskLightFadeTime;
            }
            else
            {
                    this.CancelTime = Game.ItemDefinition.Data.DataDefinitions.FloatHelper.ApplyModifier(baseValue:  8.96831E-44f, key:  "SurgeCancelDuration", mods:  val_1);
                this.CancelAction = 0;
                this.BatteryDrainRateBase = 1.85775E-36f;
                this.BatteryDrainRateCancel = 0f;
                this.BatterySurgeBlinkDuration = 0f;
                this.BatterySurgeMaskLightFadeTime = 5.142877E-39f;
            }
            
            this.HapticCue = surge.HapticCue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{{\"ActivationChance\":{0},\"CancelTime\":{1}}}", arg0:  this.ActivationChance, arg1:  this.CancelTime);
        }
    
    }

}
