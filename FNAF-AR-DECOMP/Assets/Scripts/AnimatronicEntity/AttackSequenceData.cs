using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AttackSequenceData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <encounterStartTime>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <attackSequenceComplete>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <accumulatedOfflineTime>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long encounterStartTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool attackSequenceComplete { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float accumulatedOfflineTime { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_encounterStartTime()
        {
            return (long)this.<encounterStartTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_encounterStartTime(long value)
        {
            this.<encounterStartTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_attackSequenceComplete()
        {
            return (bool)this.<attackSequenceComplete>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_attackSequenceComplete(bool value)
        {
            this.<attackSequenceComplete>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_accumulatedOfflineTime()
        {
            return (float)this.<accumulatedOfflineTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_accumulatedOfflineTime(float value)
        {
            this.<accumulatedOfflineTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackSequenceData()
        {
            this.<attackSequenceComplete>k__BackingField = false;
            this.<encounterStartTime>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackSequenceData(AnimatronicEntity.AttackSequenceData attackSequenceData)
        {
            if(attackSequenceData != null)
            {
                    this.<attackSequenceComplete>k__BackingField = attackSequenceData.<attackSequenceComplete>k__BackingField;
            }
            else
            {
                    this.<attackSequenceComplete>k__BackingField = false;
            }
            
            this.<encounterStartTime>k__BackingField = attackSequenceData.<encounterStartTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackSequenceData(bool attackSequenceComplete, long encounterStartTime)
        {
            this.<attackSequenceComplete>k__BackingField = attackSequenceComplete;
            this.<encounterStartTime>k__BackingField = encounterStartTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)this.<attackSequenceComplete>k__BackingField.ToString()(this.<attackSequenceComplete>k__BackingField.ToString()) + this.<encounterStartTime>k__BackingField.ToString()(this.<encounterStartTime>k__BackingField.ToString());
        }
    
    }

}
