using UnityEngine;

namespace Mapbox.Tokens
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapboxTokenApi
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.FileSource _fs;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapboxTokenApi()
        {
            this._fs = new Mapbox.Platform.FileSource(acessToken:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Retrieve(string accessToken, System.Action<Mapbox.Tokens.MapboxToken> callback)
        {
            .callback = callback;
            Mapbox.Platform.IAsyncRequest val_4 = this._fs.Request(url:  "https://api.mapbox.com/tokens/v2?access_token="("https://api.mapbox.com/tokens/v2?access_token=") + accessToken, callback:  new System.Action<Mapbox.Platform.Response>(object:  new MapboxTokenApi.<>c__DisplayClass2_0(), method:  System.Void MapboxTokenApi.<>c__DisplayClass2_0::<Retrieve>b__0(Mapbox.Platform.Response response)), timeout:  10, tileId:  new Mapbox.Map.CanonicalTileId(), mapId:  0);
        }
    
    }

}
