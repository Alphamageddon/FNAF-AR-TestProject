using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ColliderModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Modifiers.ColliderModifier.IColliderStrategy _colliderStrategy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.ColliderOptions _options;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetProperties(Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties properties)
        {
            Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties val_3 = properties;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this._options = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            IColliderStrategy val_4;
            if(this._colliderStrategy != null)
            {
                    return;
            }
            
            if(this._options.colliderType == 3)
            {
                goto label_3;
            }
            
            if(this._options.colliderType == 2)
            {
                goto label_4;
            }
            
            if(this._options.colliderType != 1)
            {
                goto label_5;
            }
            
            ColliderModifier.BoxColliderStrategy val_1 = null;
            val_4 = val_1;
            val_1 = new ColliderModifier.BoxColliderStrategy();
            goto label_8;
            label_3:
            ColliderModifier.SphereColliderStrategy val_2 = null;
            val_4 = val_2;
            val_2 = new ColliderModifier.SphereColliderStrategy();
            goto label_8;
            label_4:
            ColliderModifier.MeshColliderStrategy val_3 = null;
            val_4 = val_3;
            val_3 = new ColliderModifier.MeshColliderStrategy();
            goto label_8;
            label_5:
            val_4 = 0;
            label_8:
            this._colliderStrategy = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            if(this._colliderStrategy == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._colliderStrategy.AddColliderTo(ve:  ve);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ColliderModifier()
        {
            mem[1152921519690344184] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
