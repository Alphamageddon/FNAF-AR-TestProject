using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct Location
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d LatitudeLongitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float UserHeading;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DeviceOrientation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Timestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double TimestampDevice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Accuracy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLocationServiceInitializing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLocationServiceEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLocationUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> HasGpsFix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> SatellitesInView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> SatellitesUsed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<float> SpeedMetersPerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Provider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProviderClass;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsUserHeadingUpdated;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<float> SpeedKmPerHour { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<float> get_SpeedKmPerHour()
        {
            return 52952223;
        }
    
    }

}
