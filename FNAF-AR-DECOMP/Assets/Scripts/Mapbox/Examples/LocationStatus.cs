using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationStatus : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _statusText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.AbstractLocationProvider _locationProvider;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            var val_5;
            if(0 != this._locationProvider)
            {
                    return;
            }
            
            Mapbox.Unity.Location.ILocationProvider val_3 = Mapbox.Unity.Location.LocationProviderFactory.Instance.DefaultLocationProvider;
            val_5 = 0;
            this._locationProvider = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_2;
            var val_3;
            object val_5;
            Mapbox.Unity.Location.Location val_1 = this._locationProvider.CurrentLocation;
            if(val_2 != false)
            {
                    return;
            }
            
            if(val_3 == false)
            {
                goto label_4;
            }
            
            Mapbox.Utils.Vector2d val_4 = Mapbox.Utils.Vector2d.zero;
            if(((-1929740360) & 1) == 0)
            {
                goto label_5;
            }
            
            if(this._statusText != null)
            {
                    return;
            }
            
            return;
            label_4:
            if(this._statusText != null)
            {
                    return;
            }
            
            return;
            label_5:
            string val_7 = System.String.Format(format:  "{0}", arg0:  val_5);
            if(this._statusText != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationStatus()
        {
        
        }
    
    }

}
