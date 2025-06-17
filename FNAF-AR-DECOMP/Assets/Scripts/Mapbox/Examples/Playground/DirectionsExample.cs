using UnityEngine;

namespace Mapbox.Examples.Playground
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DirectionsExample : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _resultsText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.ForwardGeocodeUserInput _startLocationGeocoder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.ForwardGeocodeUserInput _endLocationGeocoder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Directions.Directions _directions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d[] _coordinates;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Directions.DirectionResource _directionResource;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            var val_7;
            this._directions = Mapbox.Unity.MapboxAccess.Instance.Directions;
            this._startLocationGeocoder.add_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Playground.DirectionsExample::StartLocationGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
            this._endLocationGeocoder.add_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Playground.DirectionsExample::EndLocationGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
            Mapbox.Utils.Vector2d[] val_5 = new Mapbox.Utils.Vector2d[2];
            this._coordinates = val_5;
            val_7 = null;
            val_7 = null;
            Mapbox.Directions.DirectionResource val_6 = new Mapbox.Directions.DirectionResource(coordinates:  val_5, profile:  Mapbox.Directions.RoutingProfile.Driving);
            this._directionResource = val_6;
            val_6.Steps = new System.Nullable<System.Boolean>() {HasValue = false};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this._startLocationGeocoder != 0)
            {
                    this._startLocationGeocoder.remove_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Playground.DirectionsExample::StartLocationGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
            }
            
            if(this._startLocationGeocoder == 0)
            {
                    return;
            }
            
            this._startLocationGeocoder.remove_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Playground.DirectionsExample::EndLocationGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartLocationGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)
        {
            this._coordinates[0] = this._startLocationGeocoder._coordinate;
            this._coordinates[1] = this._startLocationGeocoder;
            if(this.ShouldRoute() == false)
            {
                    return;
            }
            
            this.Route();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EndLocationGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)
        {
            this._coordinates[2] = this._endLocationGeocoder._coordinate;
            this._coordinates[3] = this._endLocationGeocoder;
            if(this.ShouldRoute() == false)
            {
                    return;
            }
            
            this.Route();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldRoute()
        {
            Mapbox.Examples.ForwardGeocodeUserInput val_2;
            var val_3;
            val_2 = this;
            if(this._startLocationGeocoder._hasResponse != false)
            {
                    val_2 = this._endLocationGeocoder;
                var val_1 = (this._endLocationGeocoder._hasResponse == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Route()
        {
            this._directionResource.Coordinates = this._coordinates;
            Mapbox.Platform.IAsyncRequest val_2 = this._directions.Query(direction:  this._directionResource, callback:  new System.Action<Mapbox.Directions.DirectionsResponse>(object:  this, method:  System.Void Mapbox.Examples.Playground.DirectionsExample::HandleDirectionsResponse(Mapbox.Directions.DirectionsResponse res)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleDirectionsResponse(Mapbox.Directions.DirectionsResponse res)
        {
            int val_7;
            string val_2 = Mapbox.Json.JsonConvert.SerializeObject(value:  res, formatting:  1, converters:  Mapbox.Utils.JsonConverters.JsonConverters.Converters);
            val_7 = 5000;
            if(val_2.Length <= 5000)
            {
                    val_7 = val_2.Length;
            }
            
            string val_6 = val_2.Substring(startIndex:  0, length:  val_7)(val_2.Substring(startIndex:  0, length:  val_7)) + "\n. . . ";
            if(this._resultsText == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DirectionsExample()
        {
        
        }
    
    }

}
