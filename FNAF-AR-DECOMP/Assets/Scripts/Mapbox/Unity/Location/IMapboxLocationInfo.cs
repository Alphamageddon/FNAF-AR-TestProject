using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IMapboxLocationInfo
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float latitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float longitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float altitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float horizontalAccuracy { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float verticalAccuracy { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract double timestamp { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_latitude(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_longitude(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_altitude(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_horizontalAccuracy(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_verticalAccuracy(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract double get_timestamp(); // 0
    
    }

}
