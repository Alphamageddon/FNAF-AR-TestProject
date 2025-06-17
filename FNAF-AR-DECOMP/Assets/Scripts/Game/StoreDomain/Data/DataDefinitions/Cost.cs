using UnityEngine;

namespace Game.StoreDomain.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Cost
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int HardCurrency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SoftCurrency;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Cost(ProtoData.STORE_DATA.Types.ENTRY.Types.COST cost)
        {
            int val_3;
            if(cost == null)
            {
                goto label_0;
            }
            
            if(this != null)
            {
                goto label_4;
            }
            
            label_5:
            label_4:
            this.HardCurrency = (int)cost.HardCurrency;
            if(cost == null)
            {
                goto label_2;
            }
            
            val_3 = (int)cost.SoftCurrency;
            goto label_3;
            label_0:
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            val_3 = 0;
            label_3:
            this.SoftCurrency = val_3;
        }
    
    }

}
