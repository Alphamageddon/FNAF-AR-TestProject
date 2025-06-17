using UnityEngine;

namespace AnimatronicEntity.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopEntry
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Data.WorkshopEntry.Status status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double lastCommand;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string entityId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int health;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeleton;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetWearAndTearPercentage()
        {
            return (int)100 - this.health;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopEntry()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopEntry(AnimatronicEntity.Data.WorkshopEntry entryToCopy)
        {
            if(entryToCopy != null)
            {
                    this.status = entryToCopy.status;
                this.lastCommand = entryToCopy.lastCommand;
                this.entityId = entryToCopy.entityId;
                this.health = entryToCopy.health;
            }
            else
            {
                    this.status = 11993091;
                this.lastCommand = 7.42422564692724E-317;
                this.entityId = 64;
                this.health = 69077560;
            }
            
            if(entryToCopy.endoskeleton == null)
            {
                    return;
            }
            
            this.endoskeleton = new Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData(data:  entryToCopy.endoskeleton);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Equals(AnimatronicEntity.Data.WorkshopEntry other)
        {
            if((this.EqualsExceptForEndoskeleton(other:  other)) == false)
            {
                    return false;
            }
            
            if(this.endoskeleton != null)
            {
                    return this.endoskeleton.Equals(other:  other.endoskeleton);
            }
            
            return this.endoskeleton.Equals(other:  other.endoskeleton);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EqualsExceptForEndoskeleton(AnimatronicEntity.Data.WorkshopEntry other)
        {
            Status val_7;
            int val_8;
            val_7 = this.status;
            mem2[0] = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_7});
            if(((val_7.Equals(obj:  other.status)) == false) || ((UnityEngine.Mathf.Approximately(a:  (float)this.lastCommand - other.lastCommand, b:  0f)) == false))
            {
                goto label_9;
            }
            
            val_7 = this.entityId;
            if((val_7.Equals(value:  other.entityId)) == false)
            {
                goto label_9;
            }
            
            val_8 = this.health;
            bool val_6 = val_8.Equals(obj:  other.health);
            goto label_10;
            label_9:
            val_8 = 0;
            label_10:
            val_8 = val_8 & 1;
            return (bool)val_8;
        }
    
    }

}
