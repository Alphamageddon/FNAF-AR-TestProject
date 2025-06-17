using UnityEngine;

namespace SRDebugger.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DebugPanelRoot : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Canvas Canvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.CanvasGroup CanvasGroup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Scripts.DebuggerTabController TabController;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Close()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IDebugService>().HideDebugPanel();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CloseAndDestroy()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IDebugService>().DestroyDebugPanel();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DebugPanelRoot()
        {
        
        }
    
    }

}
