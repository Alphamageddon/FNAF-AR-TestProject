using UnityEngine;

namespace Mapbox.Platform
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class FileSource : IFileSource
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<Mapbox.Platform.IAsyncRequest, int> _requests;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _accessToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly object _lock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<int> XRateLimitInterval;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<long> XRateLimitLimit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<System.DateTime> XRateLimitReset;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FileSource(string acessToken)
        {
            string val_5 = acessToken;
            this._requests = new System.Collections.Generic.Dictionary<Mapbox.Platform.IAsyncRequest, System.Int32>();
            this._lock = new System.Object();
            if((System.String.IsNullOrEmpty(value:  val_5 = acessToken)) != false)
            {
                    val_5 = System.Environment.GetEnvironmentVariable(variable:  "MAPBOX_ACCESS_TOKEN");
            }
            
            this._accessToken = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest Request(string url, System.Action<Mapbox.Platform.Response> callback, int timeout = 10, Mapbox.Map.CanonicalTileId tileId, string mapId)
        {
            string val_10;
            string val_11;
            val_10 = url;
            if((System.String.IsNullOrEmpty(value:  this._accessToken)) != true)
            {
                    System.UriBuilder val_2 = new System.UriBuilder(uri:  val_10);
                val_11 = "access_token="("access_token=") + this._accessToken;
                if(val_2.Query != null)
            {
                    if(val_2.Query.Length >= 2)
            {
                    val_11 = val_2.Query.Substring(startIndex:  1)(val_2.Query.Substring(startIndex:  1)) + "&"("&") + val_11;
            }
            
            }
            
                val_2.Query = val_11;
                val_10 = val_2;
            }
            
            tileId.Y = tileId.Y & 4294967295;
            return this.proxyResponse(url:  val_2, callback:  callback, timeout:  timeout, tileId:  new Mapbox.Map.CanonicalTileId() {Z = tileId.Z, X = tileId.X, Y = tileId.Y}, mapId:  mapId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.IAsyncRequest proxyResponse(string url, System.Action<Mapbox.Platform.Response> callback, int timeout, Mapbox.Map.CanonicalTileId tileId, string mapId)
        {
            FileSource.<>c__DisplayClass8_0 val_1 = new FileSource.<>c__DisplayClass8_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .callback = callback;
            Mapbox.Platform.IAsyncRequest val_3 = Mapbox.Platform.IAsyncRequestFactory.CreateRequest(url:  url, callback:  new System.Action<Mapbox.Platform.Response>(object:  val_1, method:  System.Void FileSource.<>c__DisplayClass8_0::<proxyResponse>b__0(Mapbox.Platform.Response response)), timeout:  timeout, requestType:  0);
            bool val_4 = false;
            System.Threading.Monitor.Enter(obj:  this._lock, lockTaken: ref  val_4);
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(val_3.IsCompleted != true)
            {
                    this._requests.Add(key:  val_3, value:  0);
            }
            
            if(val_4 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lock);
            }
            
            if(91 == 91)
            {
                    return val_3;
            }
            
            if(0 == 0)
            {
                    return val_3;
            }
            
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerator WaitForAllRequests()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new FileSource.<WaitForAllRequests>d__9();
        }
    
    }

}
