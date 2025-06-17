using UnityEngine;

namespace Mapbox.ProbeExtractorCs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct TracePoint
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long Timestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Latitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Longitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Bearing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<float> Elevation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<float> HDop;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<float> VDop;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.ProbeExtractorCs.TracePoint FromLocation(Mapbox.Unity.Location.Location location)
        {
            Mapbox.ProbeExtractorCs.TracePoint val_0;
            val_0.Timestamp = (long)location.Timestamp;
            val_0.Latitude = location.LatitudeLongitude.x;
            val_0.Longitude = location.LatitudeLongitude.y;
            val_0.Bearing = (double)location.UserHeading;
            val_0.Elevation.HasValue = false;
            val_0.HDop.HasValue = false;
            val_0.VDop.HasValue = false;
            mem[1152921519878085187] = 0;
            mem[1152921519878085192] = 0;
            mem[1152921519878085200] = 0;
            return val_0;
        }
    
    }

}
