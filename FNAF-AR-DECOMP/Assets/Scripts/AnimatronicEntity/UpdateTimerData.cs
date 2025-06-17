using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UpdateTimerData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <accumulatedDeltaTime>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <nextUpdateTimer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <LastUpdateTimestamp>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float accumulatedDeltaTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float nextUpdateTimer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long LastUpdateTimestamp { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_accumulatedDeltaTime()
        {
            return (float)this.<accumulatedDeltaTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_accumulatedDeltaTime(float value)
        {
            this.<accumulatedDeltaTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_nextUpdateTimer()
        {
            return (float)this.<nextUpdateTimer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_nextUpdateTimer(float value)
        {
            this.<nextUpdateTimer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_LastUpdateTimestamp()
        {
            return (long)this.<LastUpdateTimestamp>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LastUpdateTimestamp(long value)
        {
            this.<LastUpdateTimestamp>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateTimerData()
        {
            this.<accumulatedDeltaTime>k__BackingField = 0f;
            this.<nextUpdateTimer>k__BackingField = 0f;
            this.<LastUpdateTimestamp>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateTimerData(AnimatronicEntity.UpdateTimerData updateTimerData)
        {
            if(updateTimerData != null)
            {
                    this.<accumulatedDeltaTime>k__BackingField = updateTimerData.<accumulatedDeltaTime>k__BackingField;
                this.<nextUpdateTimer>k__BackingField = updateTimerData.<nextUpdateTimer>k__BackingField;
            }
            else
            {
                    this.<accumulatedDeltaTime>k__BackingField = 1.68059E-38f;
                this.<nextUpdateTimer>k__BackingField = 1.401298E-45f;
            }
            
            this.<LastUpdateTimestamp>k__BackingField = updateTimerData.<LastUpdateTimestamp>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateTimerData(float lastUpdateTime, long lastUpdateTimestamp)
        {
            this.<accumulatedDeltaTime>k__BackingField = lastUpdateTime;
            this.<nextUpdateTimer>k__BackingField = 0f;
            this.<LastUpdateTimestamp>k__BackingField = lastUpdateTimestamp;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)this.<accumulatedDeltaTime>k__BackingField.ToString();
        }
    
    }

}
