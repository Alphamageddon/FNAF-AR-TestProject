using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LayerStats
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string account;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string tilesetid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string layer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string geometry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AttributeStats[] attributes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerStats()
        {
        
        }
    
    }

}
