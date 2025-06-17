using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MapOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapLocationOptions locationOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapExtentOptions extentOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapPlacementOptions placementOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapScalingOptions scalingOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D loadingTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Material tileMaterial;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapOptions()
        {
            this.locationOptions = new Mapbox.Unity.Map.MapLocationOptions();
            this.extentOptions = new Mapbox.Unity.Map.MapExtentOptions(type:  1);
            Mapbox.Unity.Map.MapPlacementOptions val_3 = null;
            .placementType = 1;
            val_3 = new Mapbox.Unity.Map.MapPlacementOptions();
            this.placementOptions = val_3;
            Mapbox.Unity.Map.MapScalingOptions val_4 = null;
            .scalingType = 1;
            val_4 = new Mapbox.Unity.Map.MapScalingOptions();
            this.scalingOptions = val_4;
        }
    
    }

}
