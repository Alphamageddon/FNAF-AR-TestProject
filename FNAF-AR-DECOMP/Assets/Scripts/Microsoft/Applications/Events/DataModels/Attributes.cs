using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Attributes
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.PII> <pii>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.CustomerContent> <customerContent>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.PII> pii { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.CustomerContent> customerContent { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.PII> get_pii()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.PII>)this.<pii>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_pii(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.PII> value)
        {
            this.<pii>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.CustomerContent> get_customerContent()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.CustomerContent>)this.<customerContent>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_customerContent(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.CustomerContent> value)
        {
            this.<customerContent>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Attributes()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Attributes(string fullName, string name)
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Release()
        {
            this.<customerContent>k__BackingField = 0;
        }
    
    }

}
