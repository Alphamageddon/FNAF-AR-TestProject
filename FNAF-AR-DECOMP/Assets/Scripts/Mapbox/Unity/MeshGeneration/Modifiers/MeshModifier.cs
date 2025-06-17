using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MeshModifier : ModifierBase
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual Mapbox.Unity.MeshGeneration.Modifiers.ModifierType Type { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual Mapbox.Unity.MeshGeneration.Modifiers.ModifierType get_Type()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, float scale)
        {
            goto typeof(Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier).__il2cppRuntimeField_1B8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MeshModifier()
        {
            mem[1152921519701450840] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
