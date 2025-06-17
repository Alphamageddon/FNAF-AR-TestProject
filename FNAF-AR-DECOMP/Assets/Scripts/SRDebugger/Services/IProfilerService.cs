using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IProfilerService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float AverageFrameTime { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float LastFrameTime { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> FrameBuffer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_AverageFrameTime(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract float get_LastFrameTime(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer(); // 0
    
    }

}
