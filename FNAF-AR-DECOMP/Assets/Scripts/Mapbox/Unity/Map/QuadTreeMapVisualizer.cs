using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class QuadTreeMapVisualizer : AbstractMapVisualizer
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void PlaceTile(Mapbox.Map.UnwrappedTileId tileId, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Unity.Map.IMapReadable map)
        {
            var val_27 = 0;
            val_27 = val_27 + 1;
            Mapbox.Utils.Vector2d val_2 = map.CenterLatitudeLongitude;
            var val_28 = 0;
            val_28 = val_28 + 1;
            Mapbox.Map.UnwrappedTileId val_5 = Mapbox.Map.TileCover.CoordinateToTileId(coord:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, zoom:  map.AbsoluteZoom);
            int val_6 = val_5.Z >> 32;
            var val_29 = 0;
            val_29 = val_29 + 1;
            Mapbox.Utils.Vector2d val_9 = Mapbox.Unity.Utilities.Conversions.TileIdToCenterWebMercator(x:  val_6, y:  val_5.Y, zoom:  map.AbsoluteZoom);
            var val_30 = 0;
            val_30 = val_30 + 1;
            Mapbox.Utils.Vector2d val_11 = map.CenterMercator;
            Mapbox.Utils.Vector2d val_12 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_11.x, y = val_11.y}, b:  new Mapbox.Utils.Vector2d() {x = val_9.x, y = val_9.y});
            var val_31 = 0;
            val_31 = val_31 + 1;
            float val_14 = map.UnityTileSize;
            var val_32 = 0;
            val_32 = val_32 + 1;
            float val_34 = Mapbox.Unity.Utilities.Conversions.GetTileScaleInMeters(latitude:  0f, zoom:  map.AbsoluteZoom);
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_34 = val_34 * 256f;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_34 = val_34 / val_14;
            int val_22 = map.InitialZoom - map.AbsoluteZoom;
            int val_23 = tileId.Z >> 32;
            val_23 = val_23 - val_6;
            float val_36 = (float)val_12.x;
            float val_37 = (float)val_23;
            float val_38 = (float)val_12.y;
            val_36 = val_36 / val_34;
            float val_39 = (float)val_5.Y - tileId.Y;
            val_37 = val_14 * val_37;
            val_38 = val_38 / val_34;
            val_39 = val_14 * val_39;
            val_36 = val_37 - val_36;
            val_38 = val_39 - val_38;
            float val_25 = val_36 * 1f;
            val_38 = val_38 * 1f;
            tile.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public QuadTreeMapVisualizer()
        {
        
        }
    
    }

}
