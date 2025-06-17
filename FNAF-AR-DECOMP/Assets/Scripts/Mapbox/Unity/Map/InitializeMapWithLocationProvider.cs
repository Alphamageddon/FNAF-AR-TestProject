using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InitializeMapWithLocationProvider : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider _locationProvider;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._map._initializeOnStart = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual System.Collections.IEnumerator Start()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new InitializeMapWithLocationProvider.<Start>d__3();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location)
        {
            IntPtr val_5;
            var val_7;
            System.Action<Mapbox.Unity.Location.Location> val_1 = null;
            val_5 = System.Void Mapbox.Unity.Map.InitializeMapWithLocationProvider::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_1 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_5);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = 1;
            this._locationProvider.remove_OnLocationUpdated(value:  val_1);
            if(this._map != null)
            {
                    val_7 = this._map.AbsoluteZoom;
            }
            else
            {
                    val_7 = this._map.AbsoluteZoom;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InitializeMapWithLocationProvider()
        {
        
        }
    
    }

}
