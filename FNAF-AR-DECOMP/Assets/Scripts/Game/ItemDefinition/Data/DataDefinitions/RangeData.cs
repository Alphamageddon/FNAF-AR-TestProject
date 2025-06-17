using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RangeData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Max;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeData(ProtoData.ATTACK_DATA.Types.RANGE rawSettings)
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
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeData(float min, float max)
        {
            this.Min = min;
            this.Max = max;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeData(Game.ItemDefinition.Data.DataDefinitions.RangeData range, string key, System.Collections.Generic.Dictionary<string, float> mods)
        {
            float val_4;
            val_1 = new System.Object();
            if((mods.ContainsKey(key:  string val_1 = key)) == false)
            {
                goto label_2;
            }
            
            val_4 = mods.Item[val_1];
            if(range == null)
            {
                goto label_4;
            }
            
            label_6:
            float val_4 = range.Min;
            val_4 = val_4 * val_4;
            this.Min = val_4;
            goto label_5;
            label_2:
            val_4 = 1f;
            if(range != null)
            {
                goto label_6;
            }
            
            label_4:
            float val_5 = 1.68059E-38f;
            val_5 = val_4 * val_5;
            this.Min = val_5;
            label_5:
            float val_6 = range.Max;
            val_6 = val_4 * val_6;
            this.Max = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{{\"Min\":{0},\"Min\":{1}}}", arg0:  this.Min, arg1:  this.Min);
        }
    
    }

}
