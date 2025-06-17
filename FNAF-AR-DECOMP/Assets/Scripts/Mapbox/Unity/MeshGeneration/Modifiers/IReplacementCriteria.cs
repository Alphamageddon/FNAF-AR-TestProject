using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IReplacementCriteria
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool ShouldReplaceFeature(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature); // 0
    
    }

}
