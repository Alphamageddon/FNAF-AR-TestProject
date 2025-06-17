using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DisruptionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string DISRUPTION_CHANCE = "ChanceToDisrupt";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string DISRUPTION_CHANCE_MODIFIER = "ChanceToDisruptModifier";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string CANCEL_DURATION = "CancelDuration";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.DisruptionMechanic.DisruptionStyle Style;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData Seconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData ActivationChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float RampTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float CancelTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.DisruptionMechanic.DisruptionCancelAction CancelAction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float ShakeMagnitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float ShakeGraceTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DisruptionData(ProtoData.ATTACK_DATA.Types.DISRUPTION rawSettings)
        {
            int val_27;
            RANGE val_28;
            CHANCE val_29;
            float val_30;
            float val_31;
            int val_32;
            float val_33;
            float val_34;
            if(rawSettings == null)
            {
                goto label_2;
            }
            
            SETTINGS val_1 = rawSettings.Settings;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            val_27 = val_1.Style;
            if(val_27 != null)
            {
                goto label_3;
            }
            
            label_2:
            val_27 = System.String.alignConst;
            label_3:
            if((System.Enum.TryParse<Game.AttackSequence.DisruptionMechanic.DisruptionStyle>(value:  val_27, ignoreCase:  true, result: out  this.Style)) != true)
            {
                    mem2[0] = 0;
            }
            
            if(rawSettings == null)
            {
                goto label_8;
            }
            
            SETTINGS val_5 = rawSettings.Settings;
            if(val_5 == null)
            {
                goto label_8;
            }
            
            val_28 = val_5.Cooldown;
            goto label_9;
            label_8:
            val_28 = 0;
            label_9:
            this.Seconds = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_28);
            if(rawSettings == null)
            {
                goto label_12;
            }
            
            SETTINGS val_8 = rawSettings.Settings;
            if(val_8 == null)
            {
                goto label_12;
            }
            
            val_29 = val_8.Activation;
            goto label_13;
            label_12:
            val_29 = 0;
            label_13:
            this.ActivationChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_29);
            if(rawSettings == null)
            {
                goto label_16;
            }
            
            SETTINGS val_11 = rawSettings.Settings;
            if(val_11 == null)
            {
                goto label_16;
            }
            
            double val_12 = val_11.RampTime;
            goto label_17;
            label_16:
            label_17:
            val_30 = 0f;
            if(((-782908288) & 1) != 0)
            {
                    val_30 = (float)0.South;
            }
            
            this.RampTime = val_30;
            if(rawSettings == null)
            {
                goto label_20;
            }
            
            SETTINGS val_14 = rawSettings.Settings;
            if(val_14 == null)
            {
                goto label_20;
            }
            
            double val_15 = val_14.CancelTime;
            goto label_21;
            label_20:
            label_21:
            val_31 = 0f;
            if(((-782908288) & 1) != 0)
            {
                    val_31 = (float)0.South;
            }
            
            this.CancelTime = val_31;
            if(rawSettings == null)
            {
                goto label_24;
            }
            
            SETTINGS val_17 = rawSettings.Settings;
            if(val_17 == null)
            {
                goto label_24;
            }
            
            val_32 = val_17.CancelAction;
            if(val_32 != null)
            {
                goto label_25;
            }
            
            label_24:
            val_32 = System.String.alignConst;
            label_25:
            if((System.Enum.TryParse<Game.AttackSequence.DisruptionMechanic.DisruptionCancelAction>(value:  val_32, ignoreCase:  true, result: out  this.CancelAction)) != true)
            {
                    mem2[0] = 0;
            }
            
            if(rawSettings == null)
            {
                goto label_30;
            }
            
            SHAKE val_21 = rawSettings.Shake;
            if(val_21 == null)
            {
                goto label_30;
            }
            
            double val_22 = val_21.ShakeMagnitude;
            goto label_31;
            label_30:
            label_31:
            val_33 = 0f;
            if(((-782908288) & 1) != 0)
            {
                    val_33 = (float)0.South;
            }
            
            this.ShakeMagnitude = val_33;
            if(rawSettings == null)
            {
                goto label_34;
            }
            
            SHAKE val_24 = rawSettings.Shake;
            if(val_24 == null)
            {
                goto label_34;
            }
            
            double val_25 = val_24.ShakeGraceTime;
            goto label_35;
            label_34:
            label_35:
            val_34 = 0f;
            if(((-782908288) & 1) != 0)
            {
                    val_34 = (float)0.South;
            }
            
            this.ShakeGraceTime = val_34;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DisruptionData(Game.ItemDefinition.Data.DataDefinitions.DisruptionData disruption, System.Collections.Generic.Dictionary<string, float> mods)
        {
            val_1 = new System.Object();
            if(disruption != null)
            {
                    this.Style = disruption.Style;
                this.Seconds = disruption.Seconds;
            }
            else
            {
                    this.Style = 11993091;
                this.Seconds = 15026800;
            }
            
            this.ActivationChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(chance:  disruption.ActivationChance, chanceKey:  "ChanceToDisrupt", modifierKey:  "ChanceToDisruptModifier", mods:  System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = mods);
            if(disruption != null)
            {
                    this.RampTime = disruption.RampTime;
            }
            else
            {
                    this.RampTime = 1.85775E-36f;
            }
            
            this.CancelTime = Game.ItemDefinition.Data.DataDefinitions.FloatHelper.ApplyModifier(baseValue:  disruption.CancelTime, key:  "CancelDuration", mods:  val_1);
            if(disruption != null)
            {
                    this.CancelAction = disruption.CancelAction;
                this.ShakeMagnitude = disruption.ShakeMagnitude;
            }
            else
            {
                    this.CancelAction = 0;
                this.ShakeMagnitude = 5.142877E-39f;
            }
            
            this.ShakeGraceTime = disruption.ShakeGraceTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{{\"ActivationChance\":{0},\"CancelTime\":{1}}}", arg0:  this.ActivationChance, arg1:  this.CancelTime);
        }
    
    }

}
