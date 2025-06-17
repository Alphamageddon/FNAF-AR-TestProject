using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IDebugService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.Settings Settings { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsDebugPanelVisible { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsTriggerEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.Services.IDockConsoleService DockConsole { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsProfilerDocked { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.Settings get_Settings(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsDebugPanelVisible(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsTriggerEnabled(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_IsTriggerEnabled(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SRDebugger.Services.IDockConsoleService get_DockConsole(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsProfilerDocked(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_IsProfilerDocked(bool value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default"); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ShowDebugPanel(bool requireEntryCode = True); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ShowDebugPanel(SRDebugger.DefaultTabs tab, bool requireEntryCode = True); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void HideDebugPanel(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void DestroyDebugPanel(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddOptionContainer(object container); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveOptionContainer(object container); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void PinAllOptions(string category); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UnpinAllOptions(string category); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void PinOption(string name); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UnpinOption(string name); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ClearPinnedOptions(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, bool takeScreenshot = True, string descriptionContent); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.RectTransform EnableWorldSpaceMode(); // 0
    
    }

}
