using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CircleData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string CIRCLE_SPEED = "CircleSpeed";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData Seconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData DegreesPerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData FootstepSpeedScalar;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData ChangeSpeedChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData TriggerPercent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData CircleChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData ChargeChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData PauseChance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CircleData(ProtoData.ATTACK_DATA.Types.CIRCLE rawSettings)
        {
            CHANCE val_24;
            RANGE val_25;
            RANGE val_26;
            RANGE val_27;
            CHANCE val_28;
            CHANCE val_29;
            val_24 = rawSettings;
            if(val_24 != null)
            {
                    val_25 = val_24.Seconds;
            }
            else
            {
                    val_25 = 0;
            }
            
            this.Seconds = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_25);
            if(val_24 != null)
            {
                    this.DegreesPerSecond = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_24.DegreesPerSecond);
                val_26 = val_24.FootstepSpeedScalar;
            }
            else
            {
                    val_26 = 0;
                this.DegreesPerSecond = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  0);
            }
            
            this.FootstepSpeedScalar = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_26);
            if(val_24 != null)
            {
                    this.ChangeSpeedChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_24.ChangeSpeed);
                val_27 = val_24.TriggerPercent;
            }
            else
            {
                    val_27 = 0;
                this.ChangeSpeedChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  0);
            }
            
            this.TriggerPercent = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_27);
            if(val_24 == null)
            {
                goto label_8;
            }
            
            NEXTPHASE val_13 = val_24.NextPhase;
            if(val_13 == null)
            {
                goto label_9;
            }
            
            val_28 = val_13.Circle;
            goto label_10;
            label_8:
            val_29 = 0;
            this.CircleChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  0);
            goto label_14;
            label_9:
            val_28 = 0;
            label_10:
            this.CircleChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_28);
            if(val_24 == null)
            {
                goto label_12;
            }
            
            NEXTPHASE val_17 = val_24.NextPhase;
            if(val_17 == null)
            {
                goto label_13;
            }
            
            val_29 = val_17.Charge;
            goto label_14;
            label_12:
            this.ChargeChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  0);
            goto label_18;
            label_13:
            val_29 = 0;
            label_14:
            this.ChargeChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_29);
            if(val_24 != null)
            {
                    NEXTPHASE val_21 = val_24.NextPhase;
                if(val_21 != null)
            {
                    val_24 = val_21.Pause;
            }
            else
            {
                    val_24 = 0;
            }
            
            }
            
            label_18:
            this.PauseChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_24);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CircleData(Game.ItemDefinition.Data.DataDefinitions.CircleData circle, System.Collections.Generic.Dictionary<string, float> mods)
        {
            val_1 = new System.Object();
            if(circle != null)
            {
                    this.Seconds = circle.Seconds;
            }
            else
            {
                    this.Seconds = 11993091;
            }
            
            this.DegreesPerSecond = new Game.ItemDefinition.Data.DataDefinitions.RangeData(range:  circle.DegreesPerSecond, key:  "CircleSpeed", mods:  System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = mods);
            if(circle != null)
            {
                    this.FootstepSpeedScalar = circle.FootstepSpeedScalar;
                this.ChangeSpeedChance = circle.ChangeSpeedChance;
                this.TriggerPercent = circle.TriggerPercent;
                this.CircleChance = circle.CircleChance;
                this.ChargeChance = circle.ChargeChance;
            }
            else
            {
                    this.FootstepSpeedScalar = 64;
                this.ChangeSpeedChance = 69077560;
                this.TriggerPercent = 0;
                this.CircleChance = 4194311;
                this.ChargeChance = 1;
            }
            
            this.PauseChance = circle.PauseChance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return System.String.Format(format:  "{{\"DegreesPerSecond\":{0}}}", arg0:  this.DegreesPerSecond);
        }
    
    }

}
