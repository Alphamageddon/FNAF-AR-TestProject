using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct MapboxLocationInfoUnityWrapper : IMapboxLocationInfo
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.LocationInfo _locationInfo;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float latitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float longitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float altitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float horizontalAccuracy { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float verticalAccuracy { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double timestamp { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapboxLocationInfoUnityWrapper(UnityEngine.LocationInfo locationInfo)
        {
            mem[1152921519793247648] = locationInfo.m_Timestamp;
            mem[1152921519793247664] = locationInfo.m_Altitude;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_latitude()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_longitude()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_altitude()
        {
            return distance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_horizontalAccuracy()
        {
            return y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_verticalAccuracy()
        {
            return startValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_timestamp()
        {
            return South;
        }
    
    }

}
