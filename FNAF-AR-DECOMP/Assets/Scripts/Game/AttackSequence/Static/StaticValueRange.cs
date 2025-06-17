using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StaticValueRange
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Max;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StaticValueRange(ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS rawSettings)
        {
            float val_3;
            if(rawSettings == null)
            {
                goto label_0;
            }
            
            if(this != null)
            {
                goto label_4;
            }
            
            label_5:
            label_4:
            this.Min = (float)rawSettings.Min;
            if(rawSettings == null)
            {
                goto label_2;
            }
            
            val_3 = (float)rawSettings.Max;
            goto label_3;
            label_0:
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            val_3 = 0f;
            label_3:
            this.Max = val_3;
        }
    
    }

}
