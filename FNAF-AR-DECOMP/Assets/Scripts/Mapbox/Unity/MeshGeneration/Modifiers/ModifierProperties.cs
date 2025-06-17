using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public abstract class ModifierProperties
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Type ModifierType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Type get_ModifierType(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ModifierProperties()
        {
        
        }
    
    }

}
