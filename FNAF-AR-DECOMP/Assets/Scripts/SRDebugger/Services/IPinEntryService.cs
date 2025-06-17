using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IPinEntryService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsShowingKeypad { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsShowingKeypad(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ShowPinEntry(System.Collections.Generic.IList<int> requiredPin, string message, SRDebugger.Services.PinEntryCompleteCallback callback, bool allowCancel = True); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ShowPinEntry(System.Collections.Generic.IList<int> requiredPin, string message, SRDebugger.Services.PinEntryCompleteCallback callback, bool blockInput, bool allowCancel); // 0
    
    }

}
