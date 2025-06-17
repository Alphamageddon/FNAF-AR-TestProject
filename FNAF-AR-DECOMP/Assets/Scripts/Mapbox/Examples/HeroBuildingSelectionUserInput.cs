using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HeroBuildingSelectionUserInput : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string location;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _cameraPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _cameraRotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Geocoding.ForwardGeocodeResource _resource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasResponse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Geocoding.ForwardGeocodeResponse <Response>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Mapbox.Geocoding.ForwardGeocodeResponse, bool> OnGeocoderResponse;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasResponse { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Geocoding.ForwardGeocodeResponse Response { get; set; }
        
        // Methods
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
        public void add_OnGeocoderResponse(System.Action<Mapbox.Geocoding.ForwardGeocodeResponse, bool> value)
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
            while(this.OnGeocoderResponse != 1152921519853084336);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGeocoderResponse(System.Action<Mapbox.Geocoding.ForwardGeocodeResponse, bool> value)
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
            while(this.OnGeocoderResponse != 1152921519853220912);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
            this._button = val_1;
            val_1.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Mapbox.Examples.HeroBuildingSelectionUserInput::HandleUserInput()));
            this._resource = new Mapbox.Geocoding.ForwardGeocodeResource(query:  "");
            this._camera = UnityEngine.Camera.main;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TransformCamera()
        {
            this._camera.transform.position = new UnityEngine.Vector3() {x = this._cameraPosition, y = V9.16B, z = V10.16B};
            this._camera.transform.localEulerAngles = new UnityEngine.Vector3() {x = this._cameraRotation, y = V9.16B, z = V10.16B};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleUserInput()
        {
            this._hasResponse = false;
            if((System.String.IsNullOrEmpty(value:  this.location)) != false)
            {
                    return;
            }
            
            Mapbox.Platform.IAsyncRequest val_5 = Mapbox.Unity.MapboxAccess.Instance.Geocoder.Geocode<System.String>(geocode:  this._resource, callback:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.HeroBuildingSelectionUserInput::HandleGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse res)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse res)
        {
            this._hasResponse = true;
            this.<Response>k__BackingField = res;
            this.TransformCamera();
            this.OnGeocoderResponse.Invoke(arg1:  res, arg2:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BakeCameraTransform()
        {
            UnityEngine.Vector3 val_2 = this._camera.transform.position;
            this._cameraPosition = val_2;
            mem[1152921519853968244] = val_2.y;
            mem[1152921519853968248] = val_2.z;
            UnityEngine.Vector3 val_4 = this._camera.transform.localEulerAngles;
            this._cameraRotation = val_4;
            mem[1152921519853968256] = val_4.y;
            mem[1152921519853968260] = val_4.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HeroBuildingSelectionUserInput()
        {
            var val_2 = null;
            if((HeroBuildingSelectionUserInput.<>c.<>9__21_0) == null)
            {
                goto label_3;
            }
            
            label_8:
            this.OnGeocoderResponse = HeroBuildingSelectionUserInput.<>c.<>9__21_0;
            return;
            label_3:
            HeroBuildingSelectionUserInput.<>c.<>9__21_0 = new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse, System.Boolean>(object:  HeroBuildingSelectionUserInput.<>c.__il2cppRuntimeField_static_fields, method:  System.Void HeroBuildingSelectionUserInput.<>c::<.ctor>b__21_0(Mapbox.Geocoding.ForwardGeocodeResponse <p0>, bool <p1>));
            if(this != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
    
    }

}
