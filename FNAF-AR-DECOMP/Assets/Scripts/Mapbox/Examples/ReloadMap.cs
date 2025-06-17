using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ReloadMap : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _cameraStartPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.ForwardGeocodeUserInput _forwardGeocoder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Slider _zoomSlider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.HeroBuildingSelectionUserInput[] _heroBuildingSelectionUserInput;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Coroutine _reloadRoutine;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.WaitForSeconds _wait;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.Events.UnityAction<T0> val_13;
            Mapbox.Examples.HeroBuildingSelectionUserInput[] val_14;
            var val_15;
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            this._camera = val_1;
            UnityEngine.Vector3 val_3 = val_1.transform.position;
            this._cameraStartPos = val_3;
            mem[1152921519861890116] = val_3.y;
            mem[1152921519861890120] = val_3.z;
            this._map = UnityEngine.Object.FindObjectOfType<Mapbox.Unity.Map.AbstractMap>();
            if(this._zoomSlider != 0)
            {
                    UnityEngine.Events.UnityAction<System.Single> val_7 = null;
                val_13 = val_7;
                val_7 = new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void Mapbox.Examples.ReloadMap::Reload(float value));
                this._zoomSlider.onValueChanged.AddListener(call:  val_7);
            }
            
            if(this._forwardGeocoder != 0)
            {
                    System.Action<Mapbox.Geocoding.ForwardGeocodeResponse> val_9 = null;
                val_13 = val_9;
                val_9 = new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.ReloadMap::ForwardGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response));
                this._forwardGeocoder.add_OnGeocoderResponse(value:  val_9);
            }
            
            val_14 = this.GetComponentsInChildren<Mapbox.Examples.HeroBuildingSelectionUserInput>();
            this._heroBuildingSelectionUserInput = val_14;
            if(val_14 == null)
            {
                goto label_12;
            }
            
            val_15 = 0;
            goto label_13;
            label_18:
            System.Action<Mapbox.Geocoding.ForwardGeocodeResponse, System.Boolean> val_11 = null;
            val_13 = val_11;
            val_11 = new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse, System.Boolean>(object:  this, method:  System.Void Mapbox.Examples.ReloadMap::ForwardGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response, bool resetCamera));
            this._heroBuildingSelectionUserInput[0].add_OnGeocoderResponse(value:  val_11);
            val_14 = this._heroBuildingSelectionUserInput;
            val_15 = 1;
            label_13:
            if(val_15 < this._heroBuildingSelectionUserInput.Length)
            {
                goto label_18;
            }
            
            label_12:
            this._wait = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ForwardGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)
        {
            if(0 == 0)
            {
                    return;
            }
            
            if(0.Count < 1)
            {
                    return;
            }
            
            int val_2 = this._map.AbsoluteZoom;
            Mapbox.Geocoding.Feature val_3 = this._map.Item[0];
            response = ???;
            goto typeof(Mapbox.Unity.Map.AbstractMap).__il2cppRuntimeField_348;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ForwardGeocoder_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response, bool resetCamera)
        {
            if(response == null)
            {
                    return;
            }
            
            if(resetCamera != false)
            {
                    this._camera.transform.position = new UnityEngine.Vector3() {x = this._cameraStartPos, y = V9.16B, z = V10.16B};
            }
            
            this.ForwardGeocoder_OnGeocoderResponse(response:  response);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Reload(float value)
        {
            if(this._reloadRoutine != null)
            {
                    this.StopCoroutine(routine:  this._reloadRoutine);
                this._reloadRoutine = 0;
            }
            
            this._reloadRoutine = this.StartCoroutine(routine:  this.ReloadAfterDelay(zoom:  (int)value));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator ReloadAfterDelay(int zoom)
        {
            ReloadMap.<ReloadAfterDelay>d__12 val_1 = new ReloadMap.<ReloadAfterDelay>d__12();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .zoom = zoom;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReloadMap()
        {
        
        }
    
    }

}
