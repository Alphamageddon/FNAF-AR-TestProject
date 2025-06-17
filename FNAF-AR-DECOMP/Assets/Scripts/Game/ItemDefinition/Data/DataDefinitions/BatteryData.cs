using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BatteryData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string BATTERY_DRAIN_RATE = "BatteryDrainRate";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float BaseDrain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float FlashlightActivationDrain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float FlashlightActiveDrain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float ShockerActivationDrain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float HaywireShockDrain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BatteryData(ProtoData.ATTACK_DATA.Types.BATTERY rawSettings)
        {
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            if(rawSettings == null)
            {
                goto label_2;
            }
            
            BASE val_1 = rawSettings.Base;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            double val_2 = val_1.BaseDrain;
            goto label_3;
            label_2:
            label_3:
            val_17 = 0f;
            if(((-781853488) & 1) != 0)
            {
                    val_17 = (float)0.South;
            }
            
            this.BaseDrain = val_17;
            if(rawSettings == null)
            {
                goto label_7;
            }
            
            FLASHLIGHT val_4 = rawSettings.Flashlight;
            if(val_4 == null)
            {
                goto label_7;
            }
            
            double val_5 = val_4.ActivationDrain;
            goto label_8;
            label_7:
            label_8:
            val_18 = 0f;
            if(((-781853488) & 1) != 0)
            {
                    val_18 = (float)0.South;
            }
            
            this.FlashlightActivationDrain = val_18;
            if(rawSettings == null)
            {
                goto label_11;
            }
            
            FLASHLIGHT val_7 = rawSettings.Flashlight;
            if(val_7 == null)
            {
                goto label_11;
            }
            
            double val_8 = val_7.ActiveDrain;
            goto label_12;
            label_11:
            label_12:
            val_19 = 0f;
            if(((-781853488) & 1) != 0)
            {
                    val_19 = (float)0.South;
            }
            
            this.FlashlightActiveDrain = val_19;
            if(rawSettings == null)
            {
                goto label_15;
            }
            
            SHOCKER val_10 = rawSettings.Shocker;
            if(val_10 == null)
            {
                goto label_15;
            }
            
            double val_11 = val_10.ActivationDrain;
            goto label_16;
            label_15:
            label_16:
            val_20 = 0f;
            if(((-781853488) & 1) != 0)
            {
                    val_20 = (float)0.South;
            }
            
            this.ShockerActivationDrain = val_20;
            if(rawSettings == null)
            {
                goto label_19;
            }
            
            HAYWIRE val_13 = rawSettings.Haywire;
            if(val_13 == null)
            {
                goto label_19;
            }
            
            double val_14 = val_13.ShockDrain;
            goto label_20;
            label_19:
            label_20:
            val_21 = 0f;
            if(((-781853488) & 1) != 0)
            {
                    val_21 = (float)0.South;
            }
            
            this.HaywireShockDrain = val_21;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BatteryData(Game.ItemDefinition.Data.DataDefinitions.BatteryData batteryData, System.Collections.Generic.Dictionary<string, float> mods)
        {
            val_1 = new System.Object();
            float val_2 = Game.ItemDefinition.Data.DataDefinitions.FloatHelper.ApplyModifier(baseValue:  1f, key:  "BatteryDrainRate", mods:  System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = mods);
            if(batteryData != null)
            {
                    float val_3 = batteryData.BaseDrain;
                val_3 = val_2 * val_3;
                this.BaseDrain = val_3;
                float val_4 = batteryData.FlashlightActivationDrain;
                val_4 = val_2 * val_4;
                this.FlashlightActivationDrain = val_4;
                float val_5 = batteryData.FlashlightActiveDrain;
                val_5 = val_2 * val_5;
                this.FlashlightActiveDrain = val_5;
                float val_6 = batteryData.ShockerActivationDrain;
                val_6 = val_2 * val_6;
                this.ShockerActivationDrain = val_6;
            }
            else
            {
                    float val_7 = 1.68059E-38f;
                val_7 = val_2 * val_7;
                this.BaseDrain = val_7;
                float val_8 = 1.401298E-45f;
                val_8 = val_2 * val_8;
                this.FlashlightActivationDrain = val_8;
                float val_9 = 2.105703E-38f;
                val_9 = val_2 * val_9;
                this.FlashlightActiveDrain = val_9;
                float val_10 = 0f;
                val_10 = val_2 * val_10;
                this.ShockerActivationDrain = val_10;
            }
            
            float val_11 = batteryData.HaywireShockDrain;
            val_11 = val_2 * val_11;
            this.HaywireShockDrain = val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.BaseDrain != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.BaseDrain == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.BaseDrain;
            val_1[1] = this.FlashlightActivationDrain;
            val_1[2] = this.FlashlightActiveDrain;
            val_1[3] = this.ShockerActivationDrain;
            val_1[4] = this.HaywireShockDrain;
            return (string)System.String.Format(format:  "{{\"BaseDrain\":{0},\"FlashlightActivationDrain\":{1},\"FlashlightActiveDrain\":{2},\"ShockerActivationDrain\":{3},\"HaywireShockDrain\":{4}}}", args:  val_1);
        }
    
    }

}
