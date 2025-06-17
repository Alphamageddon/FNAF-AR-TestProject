using UnityEngine;

namespace Mapbox.Platform.TilesetTileJSON
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TileJSON
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.IFileSource _fileSource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _timeout;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IFileSource FileSource { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IFileSource get_FileSource()
        {
            return (Mapbox.Platform.IFileSource)this._fileSource;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileJSON(Mapbox.Platform.IFileSource fileSource, int timeout)
        {
            this._fileSource = fileSource;
            this._timeout = timeout;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest Get(string tilesetName, System.Action<Mapbox.Platform.TilesetTileJSON.TileJSONResponse> callback)
        {
            string val_5 = tilesetName;
            TileJSON.<>c__DisplayClass5_0 val_1 = new TileJSON.<>c__DisplayClass5_0();
            if(val_1 != null)
            {
                    .tilesetName = val_5;
                .callback = callback;
            }
            else
            {
                    mem[16] = val_5;
                mem[24] = callback;
                val_5 = mem[16];
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            return this._fileSource.Request(uri:  System.String.Format(format:  "{0}v4/{1}.json?secure", arg0:  "https://api.mapbox.com/", arg1:  val_5), callback:  new System.Action<Mapbox.Platform.Response>(object:  val_1, method:  System.Void TileJSON.<>c__DisplayClass5_0::<Get>b__0(Mapbox.Platform.Response response)), timeout:  this._timeout, tileId:  new Mapbox.Map.CanonicalTileId(), mapId:  0);
        }
    
    }

}
