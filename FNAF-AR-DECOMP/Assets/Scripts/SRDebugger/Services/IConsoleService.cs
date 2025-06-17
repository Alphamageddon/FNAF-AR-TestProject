using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IConsoleService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int ErrorCount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int WarningCount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int InfoCount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> Entries { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> AllEntries { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_ErrorCount(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_WarningCount(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_InfoCount(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_Entries(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_AllEntries(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Clear(); // 0
    
    }

}
