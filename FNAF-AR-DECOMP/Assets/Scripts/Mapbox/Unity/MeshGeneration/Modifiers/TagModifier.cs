using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TagModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _tag;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            ve.GameObject.tag = this._tag;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TagModifier()
        {
            mem[1152921519696937880] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
