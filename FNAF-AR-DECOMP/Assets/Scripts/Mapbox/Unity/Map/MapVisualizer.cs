using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapVisualizer : AbstractMapVisualizer
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void PlaceTile(Mapbox.Map.UnwrappedTileId tileId, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Unity.Map.IMapReadable map)
        {
            var val_4;
            Mapbox.Utils.RectD val_1 = tile.Rect;
            float val_6 = tile.TileScale;
            var val_21 = 0;
            val_21 = val_21 + 1;
            var val_22 = 0;
            val_22 = val_22 + 1;
            int val_11 = map.InitialZoom - map.AbsoluteZoom;
            Mapbox.Utils.Vector2d val_12 = val_4.Size;
            var val_23 = 0;
            val_23 = val_23 + 1;
            Mapbox.Utils.Vector2d val_14 = map.CenterMercator;
            Mapbox.Utils.Vector2d val_15 = val_4.Size;
            var val_24 = 0;
            val_24 = val_24 + 1;
            Mapbox.Utils.Vector2d val_17 = map.CenterMercator;
            val_17.y = val_15.y - val_17.y;
            float val_25 = (float)val_12.x - val_14.x;
            float val_26 = (float)val_17.y;
            val_25 = val_6 * val_25;
            val_26 = val_6 * val_26;
            val_25 = 1f * val_25;
            float val_19 = 1f * val_26;
            tile.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapVisualizer()
        {
        
        }
    
    }

}
