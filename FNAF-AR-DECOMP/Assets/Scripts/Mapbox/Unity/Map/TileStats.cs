using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TileStats
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string account;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string tilesetid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LayerStats[] layers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileStats()
        {
        
        }
    
    }

}
