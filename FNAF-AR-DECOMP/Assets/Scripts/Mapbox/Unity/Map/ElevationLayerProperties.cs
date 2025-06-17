using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ElevationLayerProperties : LayerProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ElevationSourceType sourceType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LayerSourceOptions sourceOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ElevationLayerType elevationLayerType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ElevationRequiredOptions requiredOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ElevationModificationOptions modificationOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.UnityLayerOptions unityLayerOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.TerrainSideWallOptions sideWallOptions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ElevationLayerProperties()
        {
            Mapbox.Unity.Map.LayerSourceOptions val_1 = new Mapbox.Unity.Map.LayerSourceOptions();
            Mapbox.Unity.Map.Style val_2 = new Mapbox.Unity.Map.Style();
            .Id = "mapbox.terrain-rgb";
            if(val_1 != null)
            {
                    .layerSource = val_2;
            }
            else
            {
                    mem[24] = val_2;
            }
            
            .isActive = true;
            this.sourceOptions = val_1;
            Mapbox.Unity.Map.ElevationRequiredOptions val_3 = null;
            .exaggerationFactor = 1f;
            val_3 = new Mapbox.Unity.Map.ElevationRequiredOptions();
            this.requiredOptions = val_3;
            Mapbox.Unity.Map.ElevationModificationOptions val_4 = null;
            .sampleCount = 10;
            .earthRadius = 1000f;
            val_4 = new Mapbox.Unity.Map.ElevationModificationOptions();
            this.modificationOptions = val_4;
            this.unityLayerOptions = new Mapbox.Unity.Map.UnityLayerOptions();
            Mapbox.Unity.Map.TerrainSideWallOptions val_6 = null;
            .wallHeight = 10f;
            val_6 = new Mapbox.Unity.Map.TerrainSideWallOptions();
            this.sideWallOptions = val_6;
            this = new System.Object();
        }
    
    }

}
