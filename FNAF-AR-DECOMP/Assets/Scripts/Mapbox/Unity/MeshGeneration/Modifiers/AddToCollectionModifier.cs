using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AddToCollectionModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.FeatureCollectionBase _collection;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            if(this._collection == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            double[] val_1 = new double[2];
            UnityEngine.Vector3 val_2 = ve.Transform.position;
            val_1[0] = (double)val_2.x;
            UnityEngine.Vector3 val_3 = ve.Transform.position;
            val_1[1] = (double)val_3.z;
            if(this._collection == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddToCollectionModifier()
        {
            mem[1152921519689814232] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
