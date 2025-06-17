using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class AbstractLocationProvider : MonoBehaviour, ILocationProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Location.Location _currentLocation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Mapbox.Unity.Location.Location> OnLocationUpdated;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.Location CurrentLocation { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.Location get_CurrentLocation()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLocationUpdated(System.Action<Mapbox.Unity.Location.Location> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLocationUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLocationUpdated != 1152921519775067344);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLocationUpdated(System.Action<Mapbox.Unity.Location.Location> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLocationUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLocationUpdated != 1152921519775203920);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void SendLocation(Mapbox.Unity.Location.Location location)
        {
            this.OnLocationUpdated.Invoke(obj:  new Mapbox.Unity.Location.Location() {LatitudeLongitude = new Mapbox.Utils.Vector2d(), IsLocationServiceInitializing = false, IsLocationServiceEnabled = false, IsLocationUpdated = false, HasGpsFix = new System.Nullable<System.Boolean>() {HasValue = false}, SatellitesInView = new System.Nullable<System.Int32>() {HasValue = false}, SatellitesUsed = new System.Nullable<System.Int32>() {HasValue = false}, SpeedMetersPerSecond = new System.Nullable<System.Single>() {HasValue = false}, IsUserHeadingUpdated = false});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AbstractLocationProvider()
        {
            var val_2 = null;
            if((AbstractLocationProvider.<>c.<>9__7_0) == null)
            {
                goto label_3;
            }
            
            label_8:
            this.OnLocationUpdated = AbstractLocationProvider.<>c.<>9__7_0;
            return;
            label_3:
            AbstractLocationProvider.<>c.<>9__7_0 = new System.Action<Mapbox.Unity.Location.Location>(object:  AbstractLocationProvider.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AbstractLocationProvider.<>c::<.ctor>b__7_0(Mapbox.Unity.Location.Location <p0>));
            if(this != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
    
    }

}
