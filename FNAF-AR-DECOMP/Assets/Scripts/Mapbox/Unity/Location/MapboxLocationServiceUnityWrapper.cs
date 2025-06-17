using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapboxLocationServiceUnityWrapper : IMapboxLocationService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isEnabledByUser { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LocationServiceStatus status { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.IMapboxLocationInfo lastData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_isEnabledByUser()
        {
            UnityEngine.LocationService val_1 = UnityEngine.Input.location;
            if(val_1 != null)
            {
                    return val_1.isEnabledByUser;
            }
            
            return val_1.isEnabledByUser;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LocationServiceStatus get_status()
        {
            UnityEngine.LocationService val_1 = UnityEngine.Input.location;
            if(val_1 != null)
            {
                    return val_1.status;
            }
            
            return val_1.status;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.IMapboxLocationInfo get_lastData()
        {
            var val_3;
            UnityEngine.LocationInfo val_2 = UnityEngine.Input.location.lastData;
            return (Mapbox.Unity.Location.IMapboxLocationInfo)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters)
        {
            UnityEngine.Input.location.Start(desiredAccuracyInMeters:  desiredAccuracyInMeters, updateDistanceInMeters:  updateDistanceInMeters);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Stop()
        {
            UnityEngine.Input.location.Stop();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapboxLocationServiceUnityWrapper()
        {
        
        }
    
    }

}
