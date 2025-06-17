using UnityEngine;

namespace Game.ItemDefinition.Container
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProgressionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int BonusEssence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int BonusParts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int MaxRank;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int MaxStreak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string EndoskeletonUnlock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string ModSlotUnlock;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasEndoskeletonUnlock { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasModSlotUnlock { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasEndoskeletonUnlock()
        {
            return System.String.op_Equality(a:  this.EndoskeletonUnlock, b:  "Yes");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasModSlotUnlock()
        {
            return System.String.op_Equality(a:  this.ModSlotUnlock, b:  "Yes");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProgressionData(ProtoData.PROGRESSION_DATA.Types.ENTRY entry)
        {
            float val_13;
            float val_14;
            float val_15;
            float val_16;
            var val_17;
            if(entry != null)
            {
                    val_13 = (float)entry.BonusEssence;
            }
            else
            {
                    val_13 = 0f;
            }
            
            this.BonusEssence = UnityEngine.Mathf.RoundToInt(f:  val_13);
            if(entry != null)
            {
                    val_14 = (float)entry.BonusParts;
            }
            else
            {
                    val_14 = 0f;
            }
            
            this.BonusParts = UnityEngine.Mathf.RoundToInt(f:  val_14);
            if(entry != null)
            {
                    val_15 = (float)entry.MaxRank;
            }
            else
            {
                    val_15 = 0f;
            }
            
            this.MaxRank = UnityEngine.Mathf.RoundToInt(f:  val_15);
            if(entry != null)
            {
                    val_16 = (float)entry.MaxStreak;
            }
            else
            {
                    val_16 = 0f;
            }
            
            this.MaxStreak = UnityEngine.Mathf.RoundToInt(f:  val_16);
            if(entry != null)
            {
                    string val_9 = entry.EndoskeletonUnlock;
                this.EndoskeletonUnlock = (val_9 == null) ? "" : (val_9);
                string val_11 = entry.ModSlotUnlock;
            }
            else
            {
                    val_17 = 0;
                this.EndoskeletonUnlock = "";
            }
            
            this.ModSlotUnlock = (val_17 == 0) ? "" : (val_17);
        }
    
    }

}
