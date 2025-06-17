using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ClassicRetinaRasterTile : ClassicRasterTile
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override Mapbox.Map.TileResource MakeTileResource(string mapId)
        {
            return Mapbox.Map.TileResource.MakeClassicRetinaRaster(id:  new Mapbox.Map.CanonicalTileId() {Z = X8, X = X8, Y = X9}, mapId:  mapId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ClassicRetinaRasterTile()
        {
            val_1 = new Mapbox.Map.Tile();
        }
    
    }

}
