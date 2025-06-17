using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ImageryLayerProperties : LayerProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ImagerySourceType sourceType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LayerSourceOptions sourceOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ImageryRasterOptions rasterOptions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ImageryLayerProperties()
        {
            Mapbox.Unity.Map.Style val_6;
            Mapbox.Unity.Map.LayerSourceOptions val_1 = new Mapbox.Unity.Map.LayerSourceOptions();
            if(val_1 != null)
            {
                    .isActive = true;
                val_6 = Mapbox.Unity.Map.MapboxDefaultImagery.GetParameters(defaultImagery:  0);
            }
            else
            {
                    mem[16] = 1;
                val_6 = Mapbox.Unity.Map.MapboxDefaultImagery.GetParameters(defaultImagery:  0);
            }
            
            .layerSource = val_6;
            this.sourceOptions = val_1;
            this.rasterOptions = new Mapbox.Unity.Map.ImageryRasterOptions();
            this = new System.Object();
        }
    
    }

}
