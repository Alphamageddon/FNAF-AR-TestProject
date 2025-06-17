using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerModifierOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Modifiers.PositionTargetType moveFeaturePositionTo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier> MeshModifiers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.GameObjectModifier> GoModifiers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerModifierOptions()
        {
        
        }
    
    }

}
