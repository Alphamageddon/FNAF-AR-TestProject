using UnityEngine;

namespace SRDebugger.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRDebugStrings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly SRDebugger.Internal.SRDebugStrings Current;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Console_MessageTruncated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Console_NoStackTrace;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string PinEntryPrompt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Profiler_DisableProfilerInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Profiler_EnableProfilerInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Profiler_NoProInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Profiler_NotSupported;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string ProfilerCameraListenerHelp;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugStrings()
        {
            this.Console_MessageTruncated = "-- Message Truncated --";
            this.Console_NoStackTrace = "-- No Stack Trace Available --";
            this.PinEntryPrompt = "Enter code to open debug panel";
            this.Profiler_DisableProfilerInfo = "Unity profiler is currently <b>enabled</b>. Disable to improve performance.";
            this.Profiler_EnableProfilerInfo = "Unity profiler is currently <b>disabled</b>. Enable to show more information.";
            this.Profiler_NoProInfo = "Unity profiler is currently <b>disabled</b>. Unity Pro is required to enable it.";
            this.Profiler_NotSupported = "Unity profiler is <b>not supported</b> in this build.";
            this.ProfilerCameraListenerHelp = "This behaviour is attached by the SRDebugger profiler to calculate render times.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugStrings()
        {
            SRDebugger.Internal.SRDebugStrings.Current = new SRDebugger.Internal.SRDebugStrings();
        }
    
    }

}
