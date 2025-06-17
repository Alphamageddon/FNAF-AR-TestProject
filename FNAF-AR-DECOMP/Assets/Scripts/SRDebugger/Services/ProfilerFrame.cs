using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct ProfilerFrame
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double FrameTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double OtherTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double RenderTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double UpdateTime;
        
    
    }

}
