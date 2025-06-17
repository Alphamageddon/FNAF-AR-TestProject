using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Filters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ILayerFeatureFilterComparer
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool Try(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature); // 0
    
    }

}
