using UnityEngine;

namespace SRDebugger.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Service
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Services.IConsoleService _consoleService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Services.IDebugPanelService _debugPanelService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Services.IDebugTriggerService _debugTriggerService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Services.IPinnedUIService _pinnedUiService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Services.IDebugCameraService _debugCameraService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Services.IOptionsService _optionsService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Services.IDockConsoleService _dockConsoleService;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IConsoleService Console { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IDockConsoleService DockConsole { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IDebugPanelService Panel { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IDebugTriggerService Trigger { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IPinnedUIService PinnedUI { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IDebugCameraService DebugCamera { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IOptionsService Options { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IConsoleService get_Console()
        {
            SRDebugger.Services.IConsoleService val_2 = SRDebugger.Internal.Service._consoleService;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            SRDebugger.Internal.Service._consoleService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IConsoleService>();
            val_2 = SRDebugger.Internal.Service._consoleService;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IDockConsoleService get_DockConsole()
        {
            SRDebugger.Services.IDockConsoleService val_2 = SRDebugger.Internal.Service._dockConsoleService;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            SRDebugger.Internal.Service._dockConsoleService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IDockConsoleService>();
            val_2 = SRDebugger.Internal.Service._dockConsoleService;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IDebugPanelService get_Panel()
        {
            SRDebugger.Services.IDebugPanelService val_2 = SRDebugger.Internal.Service._debugPanelService;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            SRDebugger.Internal.Service._debugPanelService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IDebugPanelService>();
            val_2 = SRDebugger.Internal.Service._debugPanelService;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IDebugTriggerService get_Trigger()
        {
            SRDebugger.Services.IDebugTriggerService val_2 = SRDebugger.Internal.Service._debugTriggerService;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            SRDebugger.Internal.Service._debugTriggerService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IDebugTriggerService>();
            val_2 = SRDebugger.Internal.Service._debugTriggerService;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IPinnedUIService get_PinnedUI()
        {
            SRDebugger.Services.IPinnedUIService val_2 = SRDebugger.Internal.Service._pinnedUiService;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            SRDebugger.Internal.Service._pinnedUiService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IPinnedUIService>();
            val_2 = SRDebugger.Internal.Service._pinnedUiService;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IDebugCameraService get_DebugCamera()
        {
            SRDebugger.Services.IDebugCameraService val_2 = SRDebugger.Internal.Service._debugCameraService;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            SRDebugger.Internal.Service._debugCameraService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IDebugCameraService>();
            val_2 = SRDebugger.Internal.Service._debugCameraService;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Services.IOptionsService get_Options()
        {
            SRDebugger.Services.IOptionsService val_2 = SRDebugger.Internal.Service._optionsService;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            SRDebugger.Internal.Service._optionsService = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IOptionsService>();
            val_2 = SRDebugger.Internal.Service._optionsService;
            return val_2;
        }
    
    }

}
