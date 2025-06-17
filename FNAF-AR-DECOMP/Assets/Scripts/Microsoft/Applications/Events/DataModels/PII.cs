using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class PII
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Microsoft.Applications.Events.DataModels.PIIKind <Kind>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.Applications.Events.DataModels.PIIKind Kind { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.Applications.Events.DataModels.PIIKind get_Kind()
        {
            return (Microsoft.Applications.Events.DataModels.PIIKind)this.<Kind>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Kind(Microsoft.Applications.Events.DataModels.PIIKind value)
        {
            this.<Kind>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PII()
        {
            this.<Kind>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected PII(string fullName, string name)
        {
            val_1 = new System.Object();
            this.<Kind>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<object> op_Implicit(Microsoft.Applications.Events.DataModels.PII v)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
    
    }

}
