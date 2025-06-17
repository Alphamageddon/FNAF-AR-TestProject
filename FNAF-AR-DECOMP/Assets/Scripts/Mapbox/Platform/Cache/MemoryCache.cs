using UnityEngine;

namespace Mapbox.Platform.Cache
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MemoryCache : ICache
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint _maxCacheSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _lock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Mapbox.Platform.Cache.CacheItem> _cachedResponses;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint MaxCacheSize { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MemoryCache(uint maxCacheSize)
        {
            this._lock = new System.Object();
            this._maxCacheSize = maxCacheSize;
            this._cachedResponses = new System.Collections.Generic.Dictionary<System.String, Mapbox.Platform.Cache.CacheItem>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint get_MaxCacheSize()
        {
            return (uint)this._maxCacheSize;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReInit()
        {
            this._cachedResponses = new System.Collections.Generic.Dictionary<System.String, Mapbox.Platform.Cache.CacheItem>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(string mapdId, Mapbox.Map.CanonicalTileId tileId, Mapbox.Platform.Cache.CacheItem item, bool forceInsert)
        {
            var val_12;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, Mapbox.Platform.Cache.CacheItem>, System.Int64> val_14;
            System.Collections.Generic.Dictionary<System.String, Mapbox.Platform.Cache.CacheItem> val_15;
            string val_1 = mapdId + "||"("||") + tileId;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  this._lock, lockTaken: ref  val_2);
            if((long)this._cachedResponses.Count >= this._maxCacheSize)
            {
                    val_12 = null;
                val_12 = null;
                val_14 = MemoryCache.<>c.<>9__7_0;
                if(val_14 == null)
            {
                    val_14 = null;
                val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, Mapbox.Platform.Cache.CacheItem>, System.Int64>(object:  MemoryCache.<>c.__il2cppRuntimeField_static_fields, method:  System.Int64 MemoryCache.<>c::<Add>b__7_0(System.Collections.Generic.KeyValuePair<string, Mapbox.Platform.Cache.CacheItem> c));
                MemoryCache.<>c.<>9__7_0 = val_14;
            }
            
                System.Collections.Generic.KeyValuePair<System.String, Mapbox.Platform.Cache.CacheItem> val_6 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, Mapbox.Platform.Cache.CacheItem>>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.String, Mapbox.Platform.Cache.CacheItem>, System.Int64>(source:  this._cachedResponses, keySelector:  null));
                bool val_8 = this._cachedResponses.Remove(key:  val_6.Value.emailUIDataHandler);
            }
            
            val_15 = this._cachedResponses;
            if((val_15.ContainsKey(key:  val_1)) != true)
            {
                    System.DateTime val_10 = System.DateTime.UtcNow;
                val_15 = val_10.dateData.Ticks;
                item.AddedToCacheTicksUtc = val_15;
                this._cachedResponses.Add(key:  val_1, value:  item);
            }
            
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lock);
            }
            
            if(182 == 182)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.Cache.CacheItem Get(string mapId, Mapbox.Map.CanonicalTileId tileId)
        {
            var val_5;
            var val_6;
            string val_1 = mapId + "||"("||") + tileId;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  this._lock, lockTaken: ref  val_2);
            if((this._cachedResponses.ContainsKey(key:  val_1)) != false)
            {
                    val_5 = this._cachedResponses.Item[val_1];
                val_6 = 0;
            }
            else
            {
                    val_6 = 0;
                val_5 = 0;
            }
            
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lock);
            }
            
            if(78 == 78)
            {
                    return (Mapbox.Platform.Cache.CacheItem)val_5;
            }
            
            if(val_6 == 0)
            {
                    return (Mapbox.Platform.Cache.CacheItem)val_5;
            }
            
            return (Mapbox.Platform.Cache.CacheItem)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._lock, lockTaken: ref  val_1);
            this._cachedResponses.Clear();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lock);
            }
            
            if(40 == 40)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear(string mapId)
        {
            var val_10;
            var val_14;
            var val_15;
            var val_16;
            .mapId = mapId;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  this._lock, lockTaken: ref  val_2);
            .mapId = (MemoryCache.<>c__DisplayClass10_0)[1152921519966654064].mapId((MemoryCache.<>c__DisplayClass10_0)[1152921519966654064].mapId) + "||"("||");
            System.Func<System.String, System.Boolean> val_5 = new System.Func<System.String, System.Boolean>(object:  new MemoryCache.<>c__DisplayClass10_0(), method:  System.Boolean MemoryCache.<>c__DisplayClass10_0::<Clear>b__0(string k));
            List.Enumerator<T> val_8 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  this._cachedResponses.Keys, predicate:  null)).GetEnumerator();
            label_6:
            if(((-1820110304) & 1) == 0)
            {
                goto label_4;
            }
            
            bool val_12 = this._cachedResponses.Remove(key:  val_10.emailUIDataHandler);
            goto label_6;
            label_4:
            val_14 = 0;
            val_15 = 151;
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519966605856});
            if(( != 151) && ( != 0))
            {
                    val_14 = 0;
                val_16 = 0;
            }
            else
            {
                    val_16 = ;
            }
            
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lock);
            }
            
            if( == 151)
            {
                    return;
            }
            
            if(val_16 == 0)
            {
                    return;
            }
        
        }
    
    }

}
