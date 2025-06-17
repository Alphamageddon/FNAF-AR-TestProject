using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IEnableTab
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsEnabled { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsEnabled(); // 0
    
    }

}
