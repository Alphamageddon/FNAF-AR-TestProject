using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScrollSettingsBehaviour : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float ScrollSensitivity = 40;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.UI.ScrollRect val_1 = this.GetComponent<UnityEngine.UI.ScrollRect>();
            val_1.scrollSensitivity = 40f;
            if(SRDebugger.Internal.SRDebuggerUtil.IsMobilePlatform != false)
            {
                    return;
            }
            
            if(val_1 != null)
            {
                    val_1.movementType = 2;
            }
            else
            {
                    val_1.movementType = 2;
            }
            
            val_1.inertia = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScrollSettingsBehaviour()
        {
        
        }
    
    }

}
