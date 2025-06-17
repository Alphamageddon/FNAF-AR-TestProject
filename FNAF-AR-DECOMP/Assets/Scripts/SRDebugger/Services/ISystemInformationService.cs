using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ISystemInformationService
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.IEnumerable<string> GetCategories(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(string category); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Add(SRDebugger.InfoEntry info, string category = "Default"); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> CreateReport(bool includePrivate = False); // 0
    
    }

}
