using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ImportAttribute : Attribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Type Service;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ImportAttribute()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ImportAttribute(System.Type serviceType)
        {
            this.Service = serviceType;
        }
    
    }

}
