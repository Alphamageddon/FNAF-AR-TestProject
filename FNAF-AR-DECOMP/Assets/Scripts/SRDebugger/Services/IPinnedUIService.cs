using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IPinnedUIService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsProfilerPinned { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OptionPinStateChanged(System.Action<SRDebugger.Internal.OptionDefinition, bool> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OptionPinStateChanged(System.Action<SRDebugger.Internal.OptionDefinition, bool> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsProfilerPinned(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_IsProfilerPinned(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Pin(SRDebugger.Internal.OptionDefinition option, int order = -1); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Unpin(SRDebugger.Internal.OptionDefinition option); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UnpinAll(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool HasPinned(SRDebugger.Internal.OptionDefinition option); // 0
    
    }

}
