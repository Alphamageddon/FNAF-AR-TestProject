using UnityEngine;

namespace Mapbox.Examples.Playground
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VectorTileExample : MonoBehaviour, IObserver<Mapbox.Map.VectorTile>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.ForwardGeocodeUserInput _searchLocation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _resultsText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.Map<Mapbox.Map.VectorTile> _map;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._searchLocation.add_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Playground.VectorTileExample::SearchLocation_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this._searchLocation == 0)
            {
                    return;
            }
            
            this._searchLocation.remove_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Playground.VectorTileExample::SearchLocation_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Mapbox.Unity.MapboxConfiguration val_2 = Mapbox.Unity.MapboxAccess.Instance.Configuration;
            Mapbox.Map.Map<Mapbox.Map.VectorTile> val_4 = new Mapbox.Map.Map<Mapbox.Map.VectorTile>(fs:  new Mapbox.Platform.FileSource(acessToken:  val_2.AccessToken));
            this._map = val_4;
            val_4.Zoom = 18;
            this._map.Subscribe(observer:  this);
            this._map.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SearchLocation_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)
        {
            this.Redraw();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Redraw()
        {
            if(this._searchLocation._hasResponse != false)
            {
                    this._map.Center = new Mapbox.Utils.Vector2d() {x = this._searchLocation._coordinate, y = V9.16B};
                this._map.Update();
                return;
            }
            
            if(this._resultsText == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNext(Mapbox.Map.VectorTile tile)
        {
            var val_8;
            if(true != 2)
            {
                    return;
            }
            
            if(tile.HasError != false)
            {
                    return;
            }
            
            val_8 = Mapbox.Json.JsonConvert.SerializeObject(value:  Mapbox.VectorTile.ExtensionMethods.VectorTileExtensions.ToGeoJson(tile:  tile.data, zoom:  1, tileColumn:  0, tileRow:  0, clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = false}), formatting:  1, converters:  Mapbox.Utils.JsonConverters.JsonConverters.Converters);
            if(val_8.Length >= 5000)
            {
                    val_8 = val_8.Substring(startIndex:  0, length:  136)(val_8.Substring(startIndex:  0, length:  136)) + "\n. . . ";
            }
            
            if(this._resultsText == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorTileExample()
        {
        
        }
    
    }

}
