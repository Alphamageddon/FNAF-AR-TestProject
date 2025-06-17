using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IDebugPanelService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsLoaded { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsVisible { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Nullable<SRDebugger.DefaultTabs> ActiveTab { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsLoaded(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsVisible(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_IsVisible(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService, bool> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService, bool> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Unload(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OpenTab(SRDebugger.DefaultTabs tab); // 0
    
    }

}
