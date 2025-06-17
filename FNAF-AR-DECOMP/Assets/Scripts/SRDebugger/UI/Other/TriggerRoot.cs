using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TriggerRoot : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Canvas Canvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.LongPressButton TapHoldButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform TriggerTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Controls.MultiTapButton TripleTapButton;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TriggerRoot()
        {
        
        }
    
    }

}
