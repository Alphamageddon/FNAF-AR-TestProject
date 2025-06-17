using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ImmediatePositionWithLocationProvider : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider _locationProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _targetPosition;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider LocationProvider { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider get_LocationProvider()
        {
            if(this._locationProvider != null)
            {
                    return val_2;
            }
            
            Mapbox.Unity.Location.ILocationProvider val_2 = Mapbox.Unity.Location.LocationProviderFactory.Instance.DefaultLocationProvider;
            this._locationProvider = val_2;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Mapbox.Unity.Location.LocationProviderFactory val_1 = Mapbox.Unity.Location.LocationProviderFactory.Instance;
            val_1.mapManager.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Examples.ImmediatePositionWithLocationProvider::<Start>b__5_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            float val_6;
            float val_7;
            var val_7;
            if(this._isInitialized == false)
            {
                    return;
            }
            
            Mapbox.Unity.Location.LocationProviderFactory val_1 = Mapbox.Unity.Location.LocationProviderFactory.Instance;
            val_7 = this.transform;
            var val_8 = 0;
            val_8 = val_8 + 1;
            Mapbox.Unity.Location.Location val_5 = this.LocationProvider.CurrentLocation;
            val_7.localPosition = new UnityEngine.Vector3() {x = val_6, y = val_7, z = V2.16B};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ImmediatePositionWithLocationProvider()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Start>b__5_0()
        {
            this._isInitialized = true;
        }
    
    }

}
