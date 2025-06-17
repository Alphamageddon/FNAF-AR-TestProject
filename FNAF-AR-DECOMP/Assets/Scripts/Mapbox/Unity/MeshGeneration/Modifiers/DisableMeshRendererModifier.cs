using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DisableMeshRendererModifier : GameObjectModifier
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            ve.MeshRenderer.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DisableMeshRendererModifier()
        {
            mem[1152921519691599352] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
