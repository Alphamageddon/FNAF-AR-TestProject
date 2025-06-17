using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IDockConsoleService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsVisible { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsExpanded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.ConsoleAlignment Alignment { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsVisible(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_IsVisible(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsExpanded(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_IsExpanded(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.ConsoleAlignment get_Alignment(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_Alignment(SRDebugger.ConsoleAlignment value); // 0
    
    }

}
