using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IntRangeData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Max;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntRangeData(ProtoData.ATTACK_DATA.Types.RANGE rawSettings)
        {
            float val_5;
            float val_6;
            if(rawSettings != null)
            {
                    val_5 = (float)rawSettings.Min;
            }
            else
            {
                    val_5 = 0f;
            }
            
            this.Min = UnityEngine.Mathf.RoundToInt(f:  val_5);
            if(rawSettings != null)
            {
                    val_6 = (float)rawSettings.Max;
            }
            else
            {
                    val_6 = 0f;
            }
            
            this.Max = UnityEngine.Mathf.RoundToInt(f:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntRangeData(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{{\"Min\":{0},\"Min\":{1}}}", arg0:  this.Min, arg1:  this.Min);
        }
    
    }

}
