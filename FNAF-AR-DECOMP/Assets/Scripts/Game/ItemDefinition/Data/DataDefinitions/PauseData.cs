using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PauseData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData Seconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool UseGlimpse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData GlimpseChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData CircleChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData ChargeChance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PauseData(ProtoData.ATTACK_DATA.Types.PAUSE rawSettings)
        {
            CHANCE val_15;
            RANGE val_16;
            CHANCE val_17;
            CHANCE val_18;
            val_15 = rawSettings;
            if(val_15 != null)
            {
                    val_16 = val_15.Seconds;
            }
            else
            {
                    val_16 = 0;
            }
            
            this.Seconds = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  val_16);
            if(val_15 == null)
            {
                goto label_4;
            }
            
            this.UseGlimpse = val_15.UseGlimpse;
            NEXTPHASE val_5 = val_15.NextPhase;
            if(val_5 == null)
            {
                goto label_5;
            }
            
            val_17 = val_5.Glimpse;
            goto label_7;
            label_4:
            val_17 = 0;
            this.UseGlimpse = false;
            goto label_7;
            label_5:
            val_17 = 0;
            label_7:
            this.GlimpseChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_17);
            if(val_15 == null)
            {
                goto label_8;
            }
            
            NEXTPHASE val_8 = val_15.NextPhase;
            if(val_8 == null)
            {
                goto label_9;
            }
            
            val_18 = val_8.Circle;
            goto label_10;
            label_8:
            this.CircleChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  0);
            goto label_14;
            label_9:
            val_18 = 0;
            label_10:
            this.CircleChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_18);
            if(val_15 != null)
            {
                    NEXTPHASE val_12 = val_15.NextPhase;
                if(val_12 != null)
            {
                    val_15 = val_12.Charge;
            }
            else
            {
                    val_15 = 0;
            }
            
            }
            
            label_14:
            this.ChargeChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_15);
        }
    
    }

}
