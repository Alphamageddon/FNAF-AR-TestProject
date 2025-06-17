using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Interfaces
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VectorLayerVisualizerProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.FeatureProcessingStage featureProcessingStage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool buildingsWithUniqueIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTileLayer vectorTileLayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer[] layerFeatureFilters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer layerFeatureFilterCombiner;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorLayerVisualizerProperties()
        {
        
        }
    
    }

}
