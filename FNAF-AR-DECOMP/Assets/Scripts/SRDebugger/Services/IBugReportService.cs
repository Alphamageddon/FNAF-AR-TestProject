using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IBugReportService
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SendBugReport(SRDebugger.Services.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, SRDebugger.Services.BugReportProgressCallback progressCallback); // 0
    
    }

}
