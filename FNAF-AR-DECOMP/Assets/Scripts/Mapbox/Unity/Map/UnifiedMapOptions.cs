using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UnifiedMapOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapPresetType mapPreset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapOptions mapOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ImageryLayerProperties imageryLayerProperties;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ElevationLayerProperties elevationLayerProperties;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.VectorLayerProperties vectorLayerProperties;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnifiedMapOptions()
        {
            this.mapOptions = new Mapbox.Unity.Map.MapOptions();
            this.imageryLayerProperties = new Mapbox.Unity.Map.ImageryLayerProperties();
            this.elevationLayerProperties = new Mapbox.Unity.Map.ElevationLayerProperties();
            this.vectorLayerProperties = new Mapbox.Unity.Map.VectorLayerProperties();
        }
    
    }

}
