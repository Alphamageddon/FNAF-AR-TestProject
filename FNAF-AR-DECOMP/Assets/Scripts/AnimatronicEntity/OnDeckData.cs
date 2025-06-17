using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class OnDeckData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <CompletedTimestamp>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long CompletedTimestamp { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_CompletedTimestamp()
        {
            return (long)this.<CompletedTimestamp>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CompletedTimestamp(long value)
        {
            this.<CompletedTimestamp>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OnDeckData()
        {
            this.<CompletedTimestamp>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OnDeckData(AnimatronicEntity.OnDeckData onDeckData)
        {
            this.<CompletedTimestamp>k__BackingField = onDeckData.<CompletedTimestamp>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OnDeckData(long completedTimestamp)
        {
            this.<CompletedTimestamp>k__BackingField = completedTimestamp;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)this.<CompletedTimestamp>k__BackingField.ToString();
        }
    
    }

}
