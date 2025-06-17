using UnityEngine;

namespace AnimatronicEntity.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<AnimatronicEntity.Data.WorkshopEntry> entries;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<AnimatronicEntity.Data.WorkshopEntry> Entries { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<AnimatronicEntity.Data.WorkshopEntry> get_Entries()
        {
            return (System.Collections.Generic.List<AnimatronicEntity.Data.WorkshopEntry>)this.entries;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopData()
        {
            this.entries = new System.Collections.Generic.List<AnimatronicEntity.Data.WorkshopEntry>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(AnimatronicEntity.Data.WorkshopEntry entry)
        {
            this.entries.Add(item:  entry);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetNextAvailableEntrySlot()
        {
            var val_3;
            int val_1 = this.entries.Count;
            if(val_1 >= 1)
            {
                    val_3 = 0;
                do
            {
                AnimatronicEntity.Data.WorkshopEntry val_2 = this.entries.Item[0];
                if(val_2.health >= 1)
            {
                    if(val_2.status == 0)
            {
                    return (int)val_3;
            }
            
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1);
            
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetNextScavengingEntityId()
        {
            var val_3;
            string val_4;
            int val_1 = this.entries.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_3 = 0;
            label_6:
            AnimatronicEntity.Data.WorkshopEntry val_2 = this.entries.Item[0];
            if(val_2.status == 1)
            {
                goto label_5;
            }
            
            val_3 = val_3 + 1;
            if(val_3 < val_1)
            {
                goto label_6;
            }
            
            label_2:
            val_4 = 0;
            return val_4;
            label_5:
            val_4 = val_2.entityId;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldRepair()
        {
            System.Collections.Generic.List<AnimatronicEntity.Data.WorkshopEntry> val_6;
            var val_7;
            val_6 = this.entries;
            List.Enumerator<T> val_1 = val_6.GetEnumerator();
            label_4:
            if(((-1036392712) & 1) == 0)
            {
                goto label_2;
            }
            
            val_6 = 0.emailUIDataHandler;
            if(val_2._emailIdsToBeDeletedOnServer > 99)
            {
                goto label_4;
            }
            
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525045290744});
            val_7 = 1;
            return (bool)val_7;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525045290744});
            val_7 = 0;
            return (bool)val_7;
        }
    
    }

}
