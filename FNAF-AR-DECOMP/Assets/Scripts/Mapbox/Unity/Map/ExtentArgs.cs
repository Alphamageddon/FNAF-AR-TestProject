using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ExtentArgs : EventArgs
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> activeTiles;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ExtentArgs()
        {
        
        }
    
    }

}
