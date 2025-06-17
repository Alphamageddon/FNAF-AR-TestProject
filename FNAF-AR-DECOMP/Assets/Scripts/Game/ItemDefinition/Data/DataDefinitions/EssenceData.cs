using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Essence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BatteryMult;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceData(ProtoData.ESSENCE_DATA.Types.ENTRY data)
        {
            int val_8;
            float val_9;
            if(data == null)
            {
                goto label_2;
            }
            
            ESSENCEVALUES val_1 = data.EssenceValues;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            double val_2 = val_1.Essence;
            goto label_3;
            label_2:
            label_3:
            if(((-771581856) & 1) == 0)
            {
                goto label_4;
            }
            
            val_8 = (int)0.South;
            if(this != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_4:
            val_8 = 0;
            if(this != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            this.Essence = val_8;
            if(data == null)
            {
                goto label_9;
            }
            
            ESSENCEVALUES val_4 = data.EssenceValues;
            if(val_4 == null)
            {
                goto label_9;
            }
            
            double val_5 = val_4.BatteryMult;
            goto label_10;
            label_9:
            label_10:
            if(((-771581856) & 1) != 0)
            {
                    val_9 = (float)0.South;
            }
            else
            {
                    val_9 = 1f;
            }
            
            this.BatteryMult = val_9;
            if((SRF.SRFFloatExtensions.Approx(f:  val_9, f2:  0f)) == false)
            {
                    return;
            }
            
            this.BatteryMult = 1f;
        }
    
    }

}
