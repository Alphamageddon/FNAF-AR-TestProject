using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LayerModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _layerId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            ve.GameObject.layer = this._layerId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerModifier()
        {
            mem[1152921519692303736] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
