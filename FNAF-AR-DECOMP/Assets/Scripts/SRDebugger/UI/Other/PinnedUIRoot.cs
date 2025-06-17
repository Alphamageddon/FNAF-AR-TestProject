using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PinnedUIRoot : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Canvas Canvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform Container;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.DockConsoleController DockConsoleController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.Layout.FlowLayoutGroup OptionsLayoutGroup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Profiler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Other.HandleManager ProfilerHandleManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.VerticalLayoutGroup ProfilerVerticalLayoutGroup;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PinnedUIRoot()
        {
        
        }
    
    }

}
