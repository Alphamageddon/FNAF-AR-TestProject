using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class CustomerContent
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Microsoft.Applications.Events.DataModels.CustomerContentKind <Kind>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.Applications.Events.DataModels.CustomerContentKind Kind { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.Applications.Events.DataModels.CustomerContentKind get_Kind()
        {
            return (Microsoft.Applications.Events.DataModels.CustomerContentKind)this.<Kind>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Kind(Microsoft.Applications.Events.DataModels.CustomerContentKind value)
        {
            this.<Kind>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CustomerContent()
        {
            this.<Kind>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected CustomerContent(string fullName, string name)
        {
            val_1 = new System.Object();
            this.<Kind>k__BackingField = 0;
        }
    
    }

}
