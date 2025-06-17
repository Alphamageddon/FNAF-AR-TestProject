using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ColliderOptions : ModifierProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ColliderType colliderType;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type ModifierType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type get_ModifierType()
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ColliderOptions()
        {
        
        }
    
    }

}
