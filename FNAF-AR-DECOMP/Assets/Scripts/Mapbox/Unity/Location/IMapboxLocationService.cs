using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IMapboxLocationService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool isEnabledByUser { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.LocationServiceStatus status { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Location.IMapboxLocationInfo lastData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_isEnabledByUser(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.LocationServiceStatus get_status(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Location.IMapboxLocationInfo get_lastData(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Start(float desiredAccuracyInMeters, float updateDistanceInMeters); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Stop(); // 0
    
    }

}
