using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RetinaRasterTile : RasterTile
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override Mapbox.Map.TileResource MakeTileResource(string mapId)
        {
            return Mapbox.Map.TileResource.MakeRetinaRaster(id:  new Mapbox.Map.CanonicalTileId() {Z = X8, X = X8, Y = X9}, styleUrl:  mapId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RetinaRasterTile()
        {
            val_1 = new Mapbox.Map.Tile();
        }
    
    }

}
