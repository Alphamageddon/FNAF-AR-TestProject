using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapPlacementAtLocationCenterStrategy : IMapPlacementStrategy
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetUpPlacement(Mapbox.Unity.Map.AbstractMap map)
        {
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = map._centerLatitudeLongitude});
            map._centerMercator = val_1;
            mem2[0] = val_1.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapPlacementAtLocationCenterStrategy()
        {
        
        }
    
    }

}
