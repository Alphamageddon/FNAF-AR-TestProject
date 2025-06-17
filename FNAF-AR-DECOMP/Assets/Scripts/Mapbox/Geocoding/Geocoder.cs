using UnityEngine;

namespace Mapbox.Geocoding
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class Geocoder
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Mapbox.Platform.IFileSource fileSource;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Geocoder(Mapbox.Platform.IFileSource fileSource)
        {
            this.fileSource = fileSource;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest Geocode<T>(Mapbox.Geocoding.GeocodeResource<T> geocode, System.Action<Mapbox.Geocoding.ReverseGeocodeResponse> callback)
        {
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                    mem2[0] = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            mem2[0] = callback;
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.fileSource.Request(uri:  geocode, callback:  new System.Action<Mapbox.Platform.Response>(object:  __RuntimeMethodHiddenParam + 48, method:  __RuntimeMethodHiddenParam + 48 + 16), timeout:  10, tileId:  new Mapbox.Map.CanonicalTileId(), mapId:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest Geocode<T>(Mapbox.Geocoding.GeocodeResource<T> geocode, System.Action<Mapbox.Geocoding.ForwardGeocodeResponse> callback)
        {
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                    mem2[0] = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            mem2[0] = callback;
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.fileSource.Request(uri:  geocode, callback:  new System.Action<Mapbox.Platform.Response>(object:  __RuntimeMethodHiddenParam + 48, method:  __RuntimeMethodHiddenParam + 48 + 16), timeout:  10, tileId:  new Mapbox.Map.CanonicalTileId(), mapId:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Deserialize<T>(string str)
        {
            Mapbox.Json.JsonConverter[] val_1 = Mapbox.Utils.JsonConverters.JsonConverters.Converters;
            goto __RuntimeMethodHiddenParam + 48;
        }
    
    }

}
