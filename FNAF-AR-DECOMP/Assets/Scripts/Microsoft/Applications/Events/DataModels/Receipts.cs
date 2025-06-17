using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Receipts
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <originalTime>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <uploadTime>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long originalTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long uploadTime { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_originalTime()
        {
            return (long)this.<originalTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_originalTime(long value)
        {
            this.<originalTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_uploadTime()
        {
            return (long)this.<uploadTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_uploadTime(long value)
        {
            this.<uploadTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Receipts()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Receipts(string fullName, string name)
        {
            val_1 = new System.Object();
        }
    
    }

}
