using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModifierStackBase : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier> MeshModifiers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.GameObjectModifier> GoModifiers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual UnityEngine.GameObject Execute(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData meshData, UnityEngine.GameObject parent, string type = "")
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Initialize()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            goto typeof(Mapbox.Unity.MeshGeneration.Modifiers.ModifierStackBase).__il2cppRuntimeField_188;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void OnUnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModifierStackBase()
        {
            this.MeshModifiers = new System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier>();
            this.GoModifiers = new System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.GameObjectModifier>();
        }
    
    }

}
