using UnityEngine;

namespace Mapbox.Platform
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class IAsyncRequestFactory
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Platform.IAsyncRequest CreateRequest(string url, System.Action<Mapbox.Platform.Response> callback, int timeout, Mapbox.Unity.Utilities.HttpRequestType requestType = 0)
        {
            return (Mapbox.Platform.IAsyncRequest)new Mapbox.Unity.Utilities.HTTPRequest(url:  url, callback:  callback, timeout:  timeout, requestType:  requestType);
        }
    
    }

}
