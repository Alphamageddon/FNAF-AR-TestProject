using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class RawPngRasterTile : RasterTile
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override Mapbox.Map.TileResource MakeTileResource(string mapId)
        {
            return Mapbox.Map.TileResource.MakeRawPngRaster(id:  new Mapbox.Map.CanonicalTileId() {Z = X8, X = X8, Y = X9}, mapId:  mapId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RawPngRasterTile()
        {
            val_1 = new Mapbox.Map.Tile();
        }
    
    }

}
