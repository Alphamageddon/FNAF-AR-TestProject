using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ZoomMapData : IActionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float StartZoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float EndZoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MinZoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxZoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TimeElapsed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ZoomMapData()
        {
        
        }
    
    }

}
