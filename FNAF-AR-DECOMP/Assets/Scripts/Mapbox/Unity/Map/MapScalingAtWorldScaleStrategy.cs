using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapScalingAtWorldScaleStrategy : IMapScalingStrategy
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetUpScaling(Mapbox.Unity.Map.AbstractMap map)
        {
            var val_4;
            if(map != null)
            {
                    val_4 = map.AbsoluteZoom;
            }
            else
            {
                    val_4 = 0.AbsoluteZoom;
            }
            
            int val_3 = val_4 - map._initialZoom;
            float val_4 = (float)map._centerLatitudeLongitude;
            val_4 = val_4 * 0.01745329f;
            val_4 = 1f * val_4;
            map._worldRelativeScale = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapScalingAtWorldScaleStrategy()
        {
        
        }
    
    }

}
