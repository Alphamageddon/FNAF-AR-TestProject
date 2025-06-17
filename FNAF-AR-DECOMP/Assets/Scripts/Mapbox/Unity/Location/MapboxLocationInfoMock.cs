using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct MapboxLocationInfoMock : IMapboxLocationInfo
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.Location _location;
        
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
        public MapboxLocationInfoMock(Mapbox.Unity.Location.Location location)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_latitude()
        {
            return (float)(float)D0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_longitude()
        {
            return (float)(float)D0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_altitude()
        {
            return 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_horizontalAccuracy()
        {
            return (float)S0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_verticalAccuracy()
        {
            return 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_timestamp()
        {
            return (double)D0;
        }
    
    }

}
