using UnityEngine;

namespace Mapbox.Platform.Cache
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CachingWebFileSource : IFileSource, IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disposed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Platform.Cache.ICache> _caches;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _accessToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _autoRefreshCache;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CachingWebFileSource(string accessToken, bool autoRefreshCache)
        {
            this._caches = new System.Collections.Generic.List<Mapbox.Platform.Cache.ICache>();
            this._accessToken = accessToken;
            this._autoRefreshCache = autoRefreshCache;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Finalize()
        {
            this.Finalize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
            System.GC.SuppressFinalize(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Dispose(bool disposeManagedResources)
        {
            System.Collections.Generic.List<Mapbox.Platform.Cache.ICache> val_4;
            var val_5;
            if(this._disposed == true)
            {
                    return;
            }
            
            if(disposeManagedResources == false)
            {
                goto label_2;
            }
            
            val_5 = 0;
            goto label_3;
            label_11:
            Mapbox.Platform.Cache.ICache val_1 = this._caches.Item[0];
            if(val_1 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_1.Dispose();
            }
            
            val_5 = 1;
            label_3:
            val_4 = this._caches;
            if(val_5 < val_4.Count)
            {
                goto label_11;
            }
            
            label_2:
            this._disposed = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.Cache.CachingWebFileSource AddCache(Mapbox.Platform.Cache.ICache cache)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            if(cache.MaxCacheSize == 0)
            {
                    return (Mapbox.Platform.Cache.CachingWebFileSource)this;
            }
            
            this._caches.Add(item:  cache);
            return (Mapbox.Platform.Cache.CachingWebFileSource)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            List.Enumerator<T> val_1 = this._caches.GetEnumerator();
            label_8:
            if(((-1823486920) & 1) == 0)
            {
                goto label_2;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            0.emailUIDataHandler.Clear();
            goto label_8;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519963229240});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReInit()
        {
            List.Enumerator<T> val_1 = this._caches.GetEnumerator();
            label_8:
            if(((-1823350312) & 1) == 0)
            {
                goto label_2;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            0.emailUIDataHandler.ReInit();
            goto label_8;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519963365848});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest Request(string uri, System.Action<Mapbox.Platform.Response> callback, int timeout = 10, Mapbox.Map.CanonicalTileId tileId, string mapId)
        {
            var val_5;
            Mapbox.Platform.Cache.CachingWebFileSource val_25;
            object val_26;
            var val_27;
            string val_28;
            var val_29;
            var val_30;
            string val_32;
            Mapbox.Platform.Cache.CachingWebFileSource val_33;
            var val_34;
            var val_35;
            string val_36;
            string val_37;
            string val_38;
            string val_39;
            Mapbox.Platform.Cache.CacheItem val_40;
            System.Action<Mapbox.Platform.Response> val_41;
            Mapbox.Platform.Response val_42;
            var val_43;
            string val_44;
            int val_45;
            val_25 = this;
            CachingWebFileSource.<>c__DisplayClass11_0 val_1 = null;
            val_26 = val_1;
            val_1 = new CachingWebFileSource.<>c__DisplayClass11_0();
            if(val_26 != null)
            {
                    val_27 = val_26;
                mem[1152921519963675728] = tileId.Y;
                val_28 = 1152921519963675728;
                mem[1152921519963675704] = val_25;
                val_29 = 1152921519963675728;
                val_30 = 1152921519963675728;
                mem[1152921519963675712] = mapId;
                mem[1152921519963675720] = tileId.Z;
                mem[1152921519963675724] = tileId.X;
                mem[1152921519963675744] = timeout;
                mem[1152921519963675752] = callback;
            }
            else
            {
                    mem[24] = val_25;
                val_28 = 32;
                mem[32] = mapId;
                val_27 = val_26;
                mem[1152921519963675728] = tileId.Y;
                mem[1152921519963675720] = tileId.Z;
                mem[1152921519963675724] = tileId.X;
                val_29 = 64;
                mem[64] = timeout;
                val_30 = 72;
                mem[72] = callback;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_28)) == true)
            {
                goto label_3;
            }
            
            .cachedItem = 0;
            List.Enumerator<T> val_3 = this._caches.GetEnumerator();
            val_25 = 1152921519963206032;
            label_15:
            if(((-1823096896) & 1) == 0)
            {
                goto label_14;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            Mapbox.Platform.Cache.CacheItem val_8 = val_5.emailUIDataHandler.Get(mapId:  mem[32], tileId:  new Mapbox.Map.CanonicalTileId() {Z = mem[1152921519963675720], X = tileId.X, Y = mem[1152921519963675728]});
            if(val_26 == null)
            {
                goto label_12;
            }
            
            .cachedItem = val_8;
            if(val_8 == null)
            {
                goto label_15;
            }
            
            goto label_14;
            label_12:
            .cachedItem = val_8;
            if(((CachingWebFileSource.<>c__DisplayClass11_0)[1152921519963675680].cachedItem) == null)
            {
                goto label_15;
            }
            
            label_14:
            val_33 = val_25;
            val_32 = uri;
            val_34 = 0;
            val_35 = 1;
            goto label_16;
            label_3:
            System.Exception val_9 = new System.Exception(message:  "Cannot cache without a map id");
            val_33 = val_25;
            val_32 = uri;
            if(0 != 1)
            {
                goto label_20;
            }
            
            val_35 = 0;
            label_16:
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519963619264});
            System.UriBuilder val_11 = new System.UriBuilder(uri:  val_32);
            val_36 = 0;
            if((System.String.IsNullOrEmpty(value:  mem[1152921519963631424])) != true)
            {
                    val_37 = "access_token="("access_token=") + mem[1152921519963631424];
                if(val_11.Query != null)
            {
                    if(val_11.Query.Length >= 2)
            {
                    val_37 = val_11.Query.Substring(startIndex:  1)(val_11.Query.Substring(startIndex:  1)) + "&"("&") + val_37;
            }
            
            }
            
                val_36 = val_37;
                val_11.Query = val_36;
            }
            
            val_38 = val_11;
            if(val_26 == null)
            {
                goto label_33;
            }
            
            val_39 = val_26;
            .finalUrl = val_38;
            val_40 = .cachedItem;
            if(val_40 == null)
            {
                goto label_34;
            }
            
            val_41 = mem[72];
            goto label_35;
            label_33:
            mem[56] = val_38;
            if(((CachingWebFileSource.<>c__DisplayClass11_0)[1152921519963675680].cachedItem) == null)
            {
                goto label_36;
            }
            
            val_41 = mem[72];
            val_40 = (CachingWebFileSource.<>c__DisplayClass11_0)[1152921519963675680].cachedItem;
            if(val_40 == null)
            {
                goto label_37;
            }
            
            val_39 = 56;
            label_35:
            val_42 = Mapbox.Platform.Response.FromCache(data:  (CachingWebFileSource.<>c__DisplayClass11_0)[1152921519963675680].cachedItem.Data);
            val_41.Invoke(obj:  val_42);
            if(mem[1152921519963631432] != false)
            {
                    Mapbox.Platform.IAsyncRequest val_22 = Mapbox.Platform.IAsyncRequestFactory.CreateRequest(url:  val_11, callback:  new System.Action<Mapbox.Platform.Response>(object:  val_1, method:  System.Void CachingWebFileSource.<>c__DisplayClass11_0::<Request>b__0(Mapbox.Platform.Response headerOnly)), timeout:  mem[64], requestType:  1);
            }
            
            CachingWebFileSource.MemoryCacheAsyncRequest val_23 = null;
            val_43 = val_23;
            val_23 = new CachingWebFileSource.MemoryCacheAsyncRequest();
            .<RequestUrl>k__BackingField = val_32;
            return (Mapbox.Platform.IAsyncRequest)val_43;
            label_34:
            val_44 = mem[32];
            val_42 = mem[1152921519963675728];
            val_26 = mem[tileId.Z];
            val_26 = mem[1152921519963675720];
            val_45 = mem[64];
            goto label_41;
            label_36:
            val_38 = mem[56];
            val_44 = mem[32];
            val_42 = mem[1152921519963675728];
            val_26 = mem[tileId.Z];
            val_26 = mem[1152921519963675720];
            val_45 = mem[64];
            label_41:
            val_43 = this.requestTileAndCache(url:  val_11, mapId:  val_44, tileId:  new Mapbox.Map.CanonicalTileId() {Z = val_26, X = tileId.X, Y = val_42}, timeout:  val_45, callback:  mem[72]);
            return (Mapbox.Platform.IAsyncRequest)val_43;
            label_20:
            label_37:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.IAsyncRequest requestTileAndCache(string url, string mapId, Mapbox.Map.CanonicalTileId tileId, int timeout, System.Action<Mapbox.Platform.Response> callback)
        {
            string val_3;
            CachingWebFileSource.<>c__DisplayClass12_0 val_1 = new CachingWebFileSource.<>c__DisplayClass12_0();
            if(val_1 != null)
            {
                    val_3 = val_1;
                .url = url;
                mem[1152921519963940296] = this;
                mem[1152921519963940304] = mapId;
                mem[1152921519963940312] = tileId.Z;
                mem[1152921519963940316] = tileId.X;
                mem[1152921519963940320] = tileId.Y;
                mem[1152921519963940328] = callback;
                return Mapbox.Platform.IAsyncRequestFactory.CreateRequest(url:  val_3 = 16, callback:  new System.Action<Mapbox.Platform.Response>(object:  val_1, method:  System.Void CachingWebFileSource.<>c__DisplayClass12_0::<requestTileAndCache>b__0(Mapbox.Platform.Response r)), timeout:  timeout, requestType:  0);
            }
            
            mem[16] = url;
            mem[24] = this;
            mem[32] = mapId;
            .tileId = tileId;
            mem[1152921519963940320] = tileId.Y;
            mem[56] = callback;
            return Mapbox.Platform.IAsyncRequestFactory.CreateRequest(url:  val_3, callback:  new System.Action<Mapbox.Platform.Response>(object:  val_1, method:  System.Void CachingWebFileSource.<>c__DisplayClass12_0::<requestTileAndCache>b__0(Mapbox.Platform.Response r)), timeout:  timeout, requestType:  0);
        }
    
    }

}
