using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ReverseGeocodeUserInput : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.InputField _inputField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Geocoding.ReverseGeocodeResource _resource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Geocoding.Geocoder _geocoder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _coordinate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasResponse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Geocoding.ReverseGeocodeResponse <Response>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.EventHandler<System.EventArgs> OnGeocoderResponse;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasResponse { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Geocoding.ReverseGeocodeResponse Response { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasResponse()
        {
            return (bool)this._hasResponse;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Geocoding.ReverseGeocodeResponse get_Response()
        {
            return (Mapbox.Geocoding.ReverseGeocodeResponse)this.<Response>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Response(Mapbox.Geocoding.ReverseGeocodeResponse value)
        {
            this.<Response>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGeocoderResponse(System.EventHandler<System.EventArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGeocoderResponse, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGeocoderResponse != 1152921519863919344);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGeocoderResponse(System.EventHandler<System.EventArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGeocoderResponse, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGeocoderResponse != 1152921519864055920);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.UI.InputField val_1 = this.GetComponent<UnityEngine.UI.InputField>();
            this._inputField = val_1;
            val_1.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void Mapbox.Examples.ReverseGeocodeUserInput::HandleUserInput(string searchString)));
            this._resource = new Mapbox.Geocoding.ReverseGeocodeResource(query:  new Mapbox.Utils.Vector2d() {x = this._coordinate, y = V9.16B});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._geocoder = Mapbox.Unity.MapboxAccess.Instance.Geocoder;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleUserInput(string searchString)
        {
            this._hasResponse = false;
            if((System.String.IsNullOrEmpty(value:  searchString)) != false)
            {
                    return;
            }
            
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  searchString);
            this._coordinate = val_2;
            mem[1152921519864482008] = val_2.y;
            Mapbox.Platform.IAsyncRequest val_4 = this._geocoder.Geocode<Mapbox.Utils.Vector2d>(geocode:  this._resource, callback:  new System.Action<Mapbox.Geocoding.ReverseGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.ReverseGeocodeUserInput::HandleGeocoderResponse(Mapbox.Geocoding.ReverseGeocodeResponse res)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleGeocoderResponse(Mapbox.Geocoding.ReverseGeocodeResponse res)
        {
            var val_1;
            this._hasResponse = true;
            this.<Response>k__BackingField = res;
            if(this.OnGeocoderResponse == null)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.OnGeocoderResponse.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReverseGeocodeUserInput()
        {
        
        }
    
    }

}
