using UnityEngine;

namespace Mapbox.Platform.Cache
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ICache
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract uint MaxCacheSize { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract uint get_MaxCacheSize(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Add(string mapId, Mapbox.Map.CanonicalTileId tileId, Mapbox.Platform.Cache.CacheItem item, bool replaceIfExists); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Platform.Cache.CacheItem Get(string mapId, Mapbox.Map.CanonicalTileId tileId); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Clear(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Clear(string mapId); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ReInit(); // 0
    
    }

}
