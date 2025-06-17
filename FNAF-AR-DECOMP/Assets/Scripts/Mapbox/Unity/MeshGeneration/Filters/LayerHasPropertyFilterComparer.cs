using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerHasPropertyFilterComparer : ILayerFeatureFilterComparer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Key;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Try(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            var val_3;
            if((feature.Properties.TryGetValue(key:  this.Key, value: out  0)) != false)
            {
                    val_3 = this;
            }
            else
            {
                    val_3 = 0;
            }
            
            val_3 = val_3 & 1;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual bool PropertyComparer(object property)
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerHasPropertyFilterComparer()
        {
        
        }
    
    }

}
