using UnityEngine;

namespace SRF.Service
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ServiceAttribute : Attribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Type <ServiceType>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type ServiceType { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServiceAttribute(System.Type serviceType)
        {
            this.<ServiceType>k__BackingField = serviceType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type get_ServiceType()
        {
            return (System.Type)this.<ServiceType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ServiceType(System.Type value)
        {
            this.<ServiceType>k__BackingField = value;
        }
    
    }

}
