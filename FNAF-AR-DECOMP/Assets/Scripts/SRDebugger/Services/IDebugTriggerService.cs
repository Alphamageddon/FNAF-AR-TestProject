using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IDebugTriggerService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.PinAlignment Position { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsEnabled(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_IsEnabled(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.PinAlignment get_Position(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_Position(SRDebugger.PinAlignment value); // 0
    
    }

}
