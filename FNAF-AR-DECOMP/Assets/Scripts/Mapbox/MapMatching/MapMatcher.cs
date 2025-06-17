using UnityEngine;

namespace Mapbox.MapMatching
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapMatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Mapbox.Platform.IFileSource _fileSource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _timeout;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMatcher(Mapbox.Platform.IFileSource fileSource, int timeout)
        {
            this._fileSource = fileSource;
            this._timeout = timeout;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest Match(Mapbox.MapMatching.MapMatchingResource match, System.Action<Mapbox.MapMatching.MapMatchingResponse> callback)
        {
            MapMatcher.<>c__DisplayClass3_0 val_1 = new MapMatcher.<>c__DisplayClass3_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .callback = callback;
            var val_4 = 0;
            val_4 = val_4 + 1;
            return this._fileSource.Request(uri:  match, callback:  new System.Action<Mapbox.Platform.Response>(object:  val_1, method:  System.Void MapMatcher.<>c__DisplayClass3_0::<Match>b__0(Mapbox.Platform.Response response)), timeout:  this._timeout, tileId:  new Mapbox.Map.CanonicalTileId(), mapId:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal T Deserialize<T>(string str)
        {
            Mapbox.Json.JsonConverter[] val_1 = Mapbox.Utils.JsonConverters.JsonConverters.Converters;
            goto __RuntimeMethodHiddenParam + 48;
        }
    
    }

}
