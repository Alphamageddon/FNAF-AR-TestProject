using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Protocol
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <metadataCrc>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.List<string>> <ticketKeys>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int metadataCrc { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<string>> ticketKeys { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_metadataCrc()
        {
            return (int)this.<metadataCrc>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_metadataCrc(int value)
        {
            this.<metadataCrc>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<string>> get_ticketKeys()
        {
            return (System.Collections.Generic.List<System.Collections.Generic.List<System.String>>)this.<ticketKeys>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ticketKeys(System.Collections.Generic.List<System.Collections.Generic.List<string>> value)
        {
            this.<ticketKeys>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Protocol()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Protocol(string fullName, string name)
        {
            val_1 = new System.Object();
        }
    
    }

}
