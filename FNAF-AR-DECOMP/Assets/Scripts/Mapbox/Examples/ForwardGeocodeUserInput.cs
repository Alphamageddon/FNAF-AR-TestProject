using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ForwardGeocodeUserInput : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.InputField _inputField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Geocoding.ForwardGeocodeResource _resource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _coordinate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasResponse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Geocoding.ForwardGeocodeResponse <Response>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Mapbox.Geocoding.ForwardGeocodeResponse> OnGeocoderResponse;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Coordinate { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasResponse { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Geocoding.ForwardGeocodeResponse Response { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Coordinate()
        {
            return new Mapbox.Utils.Vector2d() {x = this._coordinate};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasResponse()
        {
            return (bool)this._hasResponse;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Geocoding.ForwardGeocodeResponse get_Response()
        {
            return (Mapbox.Geocoding.ForwardGeocodeResponse)this.<Response>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Response(Mapbox.Geocoding.ForwardGeocodeResponse value)
        {
            this.<Response>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGeocoderResponse(System.Action<Mapbox.Geocoding.ForwardGeocodeResponse> value)
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
            while(this.OnGeocoderResponse != 1152921519851509800);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGeocoderResponse(System.Action<Mapbox.Geocoding.ForwardGeocodeResponse> value)
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
            while(this.OnGeocoderResponse != 1152921519851646376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.UI.InputField val_1 = this.GetComponent<UnityEngine.UI.InputField>();
            this._inputField = val_1;
            val_1.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void Mapbox.Examples.ForwardGeocodeUserInput::HandleUserInput(string searchString)));
            this._resource = new Mapbox.Geocoding.ForwardGeocodeResource(query:  "");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleUserInput(string searchString)
        {
            this._hasResponse = false;
            if((System.String.IsNullOrEmpty(value:  searchString)) != false)
            {
                    return;
            }
            
            Mapbox.Platform.IAsyncRequest val_5 = Mapbox.Unity.MapboxAccess.Instance.Geocoder.Geocode<System.String>(geocode:  this._resource, callback:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.ForwardGeocodeUserInput::HandleGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse res)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse res)
        {
            this._hasResponse = true;
            if(res == null)
            {
                goto label_1;
            }
            
            if((23431 == 0) || (23431.Count < 1))
            {
                goto label_8;
            }
            
            Mapbox.Geocoding.Feature val_2 = Item[0];
            Mapbox.Geocoding.Feature val_3 = Item[0];
            this._coordinate = val_3.<Center>k__BackingField;
            mem[1152921519852113536] = ???;
            goto label_8;
            label_1:
            this._inputField.text = "no geocode response";
            label_8:
            this.<Response>k__BackingField = res;
            this.OnGeocoderResponse.Invoke(obj:  res);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ForwardGeocodeUserInput()
        {
            var val_2 = null;
            if((ForwardGeocodeUserInput.<>c.<>9__18_0) == null)
            {
                goto label_3;
            }
            
            label_8:
            this.OnGeocoderResponse = ForwardGeocodeUserInput.<>c.<>9__18_0;
            return;
            label_3:
            ForwardGeocodeUserInput.<>c.<>9__18_0 = new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  ForwardGeocodeUserInput.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ForwardGeocodeUserInput.<>c::<.ctor>b__18_0(Mapbox.Geocoding.ForwardGeocodeResponse <p0>));
            if(this != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
    
    }

}
