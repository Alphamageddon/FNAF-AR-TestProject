using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RasterTile : Tile
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private byte[] data;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] Data { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] get_Data()
        {
            return (System.Byte[])this.data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override Mapbox.Map.TileResource MakeTileResource(string styleUrl)
        {
            return Mapbox.Map.TileResource.MakeRaster(id:  new Mapbox.Map.CanonicalTileId() {Z = X8, X = X8, Y = X9}, styleUrl:  styleUrl);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override bool ParseTileData(byte[] data)
        {
            this.data = data;
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RasterTile()
        {
        
        }
    
    }

}
