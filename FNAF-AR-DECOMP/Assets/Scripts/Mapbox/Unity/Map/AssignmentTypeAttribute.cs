using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AssignmentTypeAttribute : PropertyAttribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type Type;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssignmentTypeAttribute(System.Type t)
        {
            this.Type = t;
        }
    
    }

}
