using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UpdateMapWithLocationProvider : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider _locationProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _targetPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isMapInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float timeTakenDuringLerp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isLerping;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _startPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _endPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _startLatLong;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _endLatlong;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _timeStartedLerping;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._map.InitializeOnStart = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator Start()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new UpdateMapWithLocationProvider.<Start>d__12();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocationProvider_OnFirstLocationUpdate(Mapbox.Unity.Location.Location location)
        {
            IntPtr val_6;
            var val_8;
            System.Action<Mapbox.Unity.Location.Location> val_1 = null;
            val_6 = System.Void Mapbox.Unity.Map.UpdateMapWithLocationProvider::LocationProvider_OnFirstLocationUpdate(Mapbox.Unity.Location.Location location);
            val_1 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_6);
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 1;
            this._locationProvider.remove_OnLocationUpdated(value:  val_1);
            this._map.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Unity.Map.UpdateMapWithLocationProvider::<LocationProvider_OnFirstLocationUpdate>b__13_0()));
            if(this._map != null)
            {
                    val_8 = this._map.AbsoluteZoom;
            }
            else
            {
                    val_8 = this._map.AbsoluteZoom;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location)
        {
            if(this._isMapInitialized == false)
            {
                    return;
            }
            
            if(location.IsLocationUpdated == false)
            {
                    return;
            }
            
            this.StartLerping(location:  new Mapbox.Unity.Location.Location() {LatitudeLongitude = new Mapbox.Utils.Vector2d(), IsLocationServiceInitializing = false, IsLocationServiceEnabled = false, IsLocationUpdated = false, HasGpsFix = new System.Nullable<System.Boolean>() {HasValue = false}, SatellitesInView = new System.Nullable<System.Int32>() {HasValue = false}, SatellitesUsed = new System.Nullable<System.Int32>() {HasValue = false}, SpeedMetersPerSecond = new System.Nullable<System.Single>() {HasValue = false}, IsUserHeadingUpdated = false});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartLerping(Mapbox.Unity.Location.Location location)
        {
            this._isLerping = true;
            this._timeStartedLerping = UnityEngine.Time.time;
            this.timeTakenDuringLerp = UnityEngine.Time.deltaTime;
            Mapbox.Utils.Vector2d val_3 = this._map.CenterLatitudeLongitude;
            this._startLatLong = val_3;
            mem[1152921519796486784] = val_3.y;
            this._endLatlong = location.LatitudeLongitude.x;
            mem[1152921519796486800] = location.LatitudeLongitude.y;
            this._startPosition = val_3.x;
            mem[1152921519796486756] = val_3.y;
            mem[1152921519796486760] = ???;
            this._endPosition = this._endLatlong;
            mem[1152921519796486768] = val_3.y;
            mem[1152921519796486772] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            var val_6;
            if(this._isMapInitialized == false)
            {
                    return;
            }
            
            if(this._isLerping == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.time;
            float val_6 = this._timeStartedLerping;
            val_6 = val_1 - val_6;
            this._startPosition = this._startLatLong;
            mem[1152921519796639764] = V9.16B;
            mem[1152921519796639768] = ???;
            float val_2 = val_6 / this.timeTakenDuringLerp;
            this._endPosition = this._endLatlong;
            mem[1152921519796639776] = val_1;
            mem[1152921519796639780] = V2.16B;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this._startPosition, y = val_6, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this._endLatlong, y = val_1, z = V2.16B}, t:  val_2);
            if(this._map != null)
            {
                    val_6 = this._map.Zoom;
            }
            else
            {
                    val_6 = 0.Zoom;
            }
            
            if(val_2 < 1f)
            {
                    return;
            }
            
            this._isLerping = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateMapWithLocationProvider()
        {
            this.timeTakenDuringLerp = 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <LocationProvider_OnFirstLocationUpdate>b__13_0()
        {
            IntPtr val_3;
            this._isMapInitialized = true;
            System.Action<Mapbox.Unity.Location.Location> val_1 = null;
            val_3 = System.Void Mapbox.Unity.Map.UpdateMapWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_1 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            this._locationProvider.add_OnLocationUpdated(value:  val_1);
        }
    
    }

}
