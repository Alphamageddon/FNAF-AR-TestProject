using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class Directions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Mapbox.Platform.IFileSource fileSource;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Directions(Mapbox.Platform.IFileSource fileSource)
        {
            this.fileSource = fileSource;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest Query(Mapbox.Directions.DirectionResource direction, System.Action<Mapbox.Directions.DirectionsResponse> callback)
        {
            Directions.<>c__DisplayClass2_0 val_1 = new Directions.<>c__DisplayClass2_0();
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
            return this.fileSource.Request(uri:  direction, callback:  new System.Action<Mapbox.Platform.Response>(object:  val_1, method:  System.Void Directions.<>c__DisplayClass2_0::<Query>b__0(Mapbox.Platform.Response response)), timeout:  10, tileId:  new Mapbox.Map.CanonicalTileId(), mapId:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Directions.DirectionsResponse Deserialize(string str)
        {
            return Mapbox.Json.JsonConvert.DeserializeObject<Mapbox.Directions.DirectionsResponse>(value:  str, converters:  Mapbox.Utils.JsonConverters.JsonConverters.Converters);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Serialize(Mapbox.Directions.DirectionsResponse response)
        {
            return Mapbox.Json.JsonConvert.SerializeObject(value:  response, converters:  Mapbox.Utils.JsonConverters.JsonConverters.Converters);
        }
    
    }

}
