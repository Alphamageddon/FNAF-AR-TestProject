using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TileStateChangedEventArgs : EventArgs
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId TileId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileStateChangedEventArgs()
        {
        
        }
    
    }

}
