using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModifierBase : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Active;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void SetProperties(Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties properties)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Initialize()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void FeaturePreProcess(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModifierBase()
        {
            this.Active = true;
        }
    
    }

}
