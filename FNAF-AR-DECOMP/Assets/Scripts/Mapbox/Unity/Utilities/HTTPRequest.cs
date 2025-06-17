using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal sealed class HTTPRequest : IAsyncRequest
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Networking.UnityWebRequest _request;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Utilities.HttpRequestType _requestType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _timeout;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<Mapbox.Platform.Response> _callback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsCompleted>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsCompleted { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Utilities.HttpRequestType RequestType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsCompleted()
        {
            return (bool)this.<IsCompleted>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsCompleted(bool value)
        {
            this.<IsCompleted>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Utilities.HttpRequestType get_RequestType()
        {
            return (Mapbox.Unity.Utilities.HttpRequestType)this._requestType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HTTPRequest(string url, System.Action<Mapbox.Platform.Response> callback, int timeout, Mapbox.Unity.Utilities.HttpRequestType requestType = 0)
        {
            this.<IsCompleted>k__BackingField = false;
            this._requestType = requestType;
            if(requestType != 1)
            {
                    UnityEngine.Networking.UnityWebRequest val_1 = UnityEngine.Networking.UnityWebRequest.Get(uri:  url);
            }
            else
            {
                    UnityEngine.Networking.UnityWebRequest val_2 = UnityEngine.Networking.UnityWebRequest.Head(uri:  url);
            }
            
            this._request = val_2;
            val_2.timeout = timeout;
            this._callback = callback;
            int val_4 = Mapbox.Unity.Utilities.Runnable.Run(routine:  this.DoRequest());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Cancel()
        {
            if(this._request == null)
            {
                    return;
            }
            
            this._request.Abort();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator DoRequest()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new HTTPRequest.<DoRequest>d__12();
        }
    
    }

}
