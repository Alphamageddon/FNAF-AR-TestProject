using UnityEngine;

namespace Mapbox.Platform
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IFileSource
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Platform.IAsyncRequest Request(string uri, System.Action<Mapbox.Platform.Response> callback, int timeout = 10, Mapbox.Map.CanonicalTileId tileId, string mapId); // 0
    
    }

}
