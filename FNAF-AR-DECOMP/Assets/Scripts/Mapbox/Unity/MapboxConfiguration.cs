using UnityEngine;

namespace Mapbox.Unity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapboxConfiguration
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AccessToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint MemoryCacheSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint FileCacheSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int DefaultTimeout;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AutoRefreshCache;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapboxConfiguration()
        {
            this.MemoryCacheSize = 500;
            this.FileCacheSize = 2500;
            this.DefaultTimeout = 30;
        }
    
    }

}
