using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MapboxDefaultImagery
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.Style GetParameters(Mapbox.Unity.Map.ImagerySourceType defaultImagery)
        {
            var val_8;
            Mapbox.Unity.Map.Style val_1 = null;
            val_8 = val_1;
            val_1 = new Mapbox.Unity.Map.Style();
            if(defaultImagery > 7)
            {
                    return (Mapbox.Unity.Map.Style);
            }
            
            var val_8 = 52951964 + (defaultImagery) << 2;
            val_8 = val_8 + 52951964;
            goto (52951964 + (defaultImagery) << 2 + 52951964);
        }
    
    }

}
