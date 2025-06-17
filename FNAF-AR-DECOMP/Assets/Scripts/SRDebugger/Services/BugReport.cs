using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BugReport
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<SRDebugger.Services.ConsoleEntry> ConsoleLog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Email;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] ScreenshotData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> SystemInformation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserDescription;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BugReport()
        {
        
        }
    
    }

}
