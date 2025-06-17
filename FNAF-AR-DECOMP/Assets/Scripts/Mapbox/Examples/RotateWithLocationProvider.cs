using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RotateWithLocationProvider : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useDeviceOrientation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _subtractUserHeading;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _rotationFollowFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _rotateZ;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useNegativeAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useTransformLocationProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Quaternion _targetRotation;
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
                val_5 = System.Void Mapbox.Examples.RotateWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
                val_1 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_5);
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = 1;
                this._locationProvider.remove_OnLocationUpdated(value:  val_1);
            }
            
            this._locationProvider = value;
            System.Action<Mapbox.Unity.Location.Location> val_3 = null;
            val_7 = System.Void Mapbox.Examples.RotateWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_3 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_7);
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = 0;
            value.add_OnLocationUpdated(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            IntPtr val_4;
            System.Action<Mapbox.Unity.Location.Location> val_2 = null;
            val_4 = System.Void Mapbox.Examples.RotateWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_2 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_4);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0;
            this.LocationProvider.add_OnLocationUpdated(value:  val_2);
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
            val_5 = System.Void Mapbox.Examples.RotateWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_3 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_5);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = 1;
            this.LocationProvider.remove_OnLocationUpdated(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location)
        {
            float val_7;
            var val_8;
            float val_7 = (this._useDeviceOrientation == false) ? 1152921519865458912 : 1152921519865458916;
            val_7 = -val_7;
            val_7 = (this._useNegativeAngle == true) ? (val_7) : (val_7);
            if(this._useDeviceOrientation == false)
            {
                goto label_1;
            }
            
            if(this._subtractUserHeading == false)
            {
                goto label_4;
            }
            
            float val_4 = (val_7 > location.UserHeading) ? (-(val_7 - location.UserHeading)) : (location.UserHeading - val_7);
            val_4 = val_4 + 360f;
            val_7 = val_4 + 360f;
            val_4 = (val_4 < 0) ? (val_7) : (val_4);
            if(val_4 < 360f)
            {
                goto label_4;
            }
            
            val_7 = -360f;
            val_8 = val_4 + val_7;
            goto label_4;
            label_1:
            if(mem[1152921519865458992] == false)
            {
                    return;
            }
            
            label_4:
            UnityEngine.Vector3 val_5 = this.getNewEulerAngles(newAngle:  val_7);
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this._targetRotation = val_6;
            mem[1152921519865426936] = val_6.y;
            mem[1152921519865426940] = val_6.z;
            mem[1152921519865426944] = val_6.w;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 getNewEulerAngles(float newAngle)
        {
            UnityEngine.Quaternion val_2 = this.transform.localRotation;
            val_2.y = (this._rotateZ == true) ? val_2.y : (-newAngle);
            val_2.z = (this._rotateZ == true) ? (-newAngle) : val_2.z;
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            UnityEngine.Quaternion val_3 = this.transform.localRotation;
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = val_4 * this._rotationFollowFactor;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, b:  new UnityEngine.Quaternion() {x = this._targetRotation, y = V12.16B, z = V13.16B, w = V14.16B}, t:  val_4);
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RotateWithLocationProvider()
        {
            this._rotationFollowFactor = 1f;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            this._targetRotation = val_1;
            mem[1152921519865799848] = val_1.y;
            mem[1152921519865799852] = val_1.z;
            mem[1152921519865799856] = val_1.w;
        }
    
    }

}
