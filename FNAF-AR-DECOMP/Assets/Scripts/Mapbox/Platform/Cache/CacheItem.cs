using UnityEngine;

namespace Mapbox.Platform.Cache
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CacheItem
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] Data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long AddedToCacheTicksUtc;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ETag;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> LastModified;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CacheItem()
        {
        
        }
    
    }

}
