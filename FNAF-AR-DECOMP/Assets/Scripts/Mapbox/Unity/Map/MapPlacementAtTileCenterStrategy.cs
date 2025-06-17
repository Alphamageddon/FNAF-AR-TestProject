using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapPlacementAtTileCenterStrategy : IMapPlacementStrategy
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetUpPlacement(Mapbox.Unity.Map.AbstractMap map)
        {
            var val_6;
            Mapbox.Utils.Vector2d val_9;
            double val_10;
            if(map != null)
            {
                    val_9 = map._centerLatitudeLongitude;
            }
            else
            {
                    val_9 = 3.23790861658519E-319;
                val_10 = 1.27319747462857E-313;
            }
            
            Mapbox.Map.UnwrappedTileId val_2 = Mapbox.Map.TileCover.CoordinateToTileId(coord:  new Mapbox.Utils.Vector2d() {x = val_9, y = val_10}, zoom:  map.AbsoluteZoom);
            val_2.Y = val_2.Y & 4294967295;
            Mapbox.Utils.RectD val_3 = Mapbox.Unity.Utilities.Conversions.TileBounds(unwrappedTileId:  new Mapbox.Map.UnwrappedTileId() {Z = val_2.Z, X = val_2.X, Y = val_2.Y});
            Mapbox.Utils.Vector2d val_8 = val_6.Size;
            map._centerMercator = val_8;
            mem2[0] = val_8.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapPlacementAtTileCenterStrategy()
        {
        
        }
    
    }

}
