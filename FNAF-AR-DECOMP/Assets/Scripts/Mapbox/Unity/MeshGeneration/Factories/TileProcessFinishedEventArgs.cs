using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TileProcessFinishedEventArgs : EventArgs
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory Factory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.UnityTile Tile;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileProcessFinishedEventArgs(Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory vectorTileFactory, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            this.Factory = vectorTileFactory;
            this.Tile = tile;
        }
    
    }

}
