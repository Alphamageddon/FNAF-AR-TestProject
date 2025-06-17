using UnityEngine;

namespace Mapbox.Unity.Telemetry
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class TelemetryFactory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly string EventQuery;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Telemetry.ITelemetryLibrary GetTelemetryInstance()
        {
            return Mapbox.Unity.Telemetry.TelemetryAndroid.Instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TelemetryFactory()
        {
            Mapbox.Unity.Telemetry.TelemetryFactory.EventQuery = "events=true";
        }
    
    }

}
