using UnityEngine;

namespace Mapbox.Unity.Telemetry
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TelemetryDummy : ITelemetryLibrary
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Unity.Telemetry.ITelemetryLibrary _instance;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Telemetry.ITelemetryLibrary Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Telemetry.ITelemetryLibrary get_Instance()
        {
            null = null;
            return (Mapbox.Unity.Telemetry.ITelemetryLibrary)Mapbox.Unity.Telemetry.TelemetryDummy._instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(string accessToken)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendTurnstile()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLocationCollectionState(bool enable)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TelemetryDummy()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TelemetryDummy()
        {
            Mapbox.Unity.Telemetry.TelemetryDummy._instance = new Mapbox.Unity.Telemetry.TelemetryDummy();
        }
    
    }

}
