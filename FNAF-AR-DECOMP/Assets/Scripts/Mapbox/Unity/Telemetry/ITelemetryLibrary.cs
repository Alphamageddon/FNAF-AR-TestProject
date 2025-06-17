using UnityEngine;

namespace Mapbox.Unity.Telemetry
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ITelemetryLibrary
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Initialize(string accessToken); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SendTurnstile(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetLocationCollectionState(bool enable); // 0
    
    }

}
