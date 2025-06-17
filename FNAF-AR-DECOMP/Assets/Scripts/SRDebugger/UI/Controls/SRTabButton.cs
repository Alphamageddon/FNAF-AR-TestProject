using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRTabButton : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Behaviour ActiveToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button Button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform ExtraContentContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.StyleComponent IconStyleComponent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text TitleText;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsActive { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsActive()
        {
            if(this.ActiveToggle != null)
            {
                    return this.ActiveToggle.enabled;
            }
            
            return this.ActiveToggle.enabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsActive(bool value)
        {
            value = value;
            this.ActiveToggle.enabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRTabButton()
        {
        
        }
    
    }

}
