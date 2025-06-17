using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PositionWithLocationProvider : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _positionFollowFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useTransformLocationProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider _locationProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _targetPosition;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider LocationProvider { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider get_LocationProvider()
        {
            if(this._locationProvider != null)
            {
                    return val_3;
            }
            
            Mapbox.Unity.Location.LocationProviderFactory val_1 = Mapbox.Unity.Location.LocationProviderFactory.Instance;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this._useTransformLocationProvider == false)
            {
                goto label_2;
            }
            
            label_4:
            Mapbox.Unity.Location.ILocationProvider val_2 = val_1.TransformLocationProvider;
            goto label_3;
            label_1:
            if(this._useTransformLocationProvider == true)
            {
                goto label_4;
            }
            
            label_2:
            Mapbox.Unity.Location.ILocationProvider val_3 = val_1.DefaultLocationProvider;
            label_3:
            this._locationProvider = val_3;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LocationProvider(Mapbox.Unity.Location.ILocationProvider value)
        {
            IntPtr val_5;
            IntPtr val_7;
            if(this._locationProvider != null)
            {
                    System.Action<Mapbox.Unity.Location.Location> val_1 = null;
                val_5 = System.Void Mapbox.Examples.PositionWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
                val_1 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_5);
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = 1;
                this._locationProvider.remove_OnLocationUpdated(value:  val_1);
            }
            
            this._locationProvider = value;
            System.Action<Mapbox.Unity.Location.Location> val_3 = null;
            val_7 = System.Void Mapbox.Examples.PositionWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_3 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_7);
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = 0;
            value.add_OnLocationUpdated(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            IntPtr val_5;
            System.Action<Mapbox.Unity.Location.Location> val_2 = null;
            val_5 = System.Void Mapbox.Examples.PositionWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_2 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_5);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = 0;
            this.LocationProvider.add_OnLocationUpdated(value:  val_2);
            this._map.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Examples.PositionWithLocationProvider::<Start>b__9_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            IntPtr val_5;
            if(this.LocationProvider == null)
            {
                    return;
            }
            
            System.Action<Mapbox.Unity.Location.Location> val_3 = null;
            val_5 = System.Void Mapbox.Examples.PositionWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_3 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_5);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = 1;
            this.LocationProvider.remove_OnLocationUpdated(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location)
        {
            if(this._isInitialized == false)
            {
                    return;
            }
            
            if(location.IsLocationUpdated == false)
            {
                    return;
            }
            
            this._targetPosition = location.LatitudeLongitude.x;
            mem[1152921519859705444] = location.LatitudeLongitude.y;
            mem[1152921519859705448] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            UnityEngine.Vector3 val_3 = this.transform.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = this._targetPosition, y = V11.16B, z = V12.16B}, t:  UnityEngine.Time.deltaTime * this._positionFollowFactor);
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PositionWithLocationProvider()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Start>b__9_0()
        {
            this._isInitialized = true;
        }
    
    }

}
