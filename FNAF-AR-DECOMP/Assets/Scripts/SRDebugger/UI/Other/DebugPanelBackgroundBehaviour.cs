using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DebugPanelBackgroundBehaviour : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _defaultKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isTransparent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.StyleComponent _styleComponent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TransparentStyleKey;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            SRF.UI.StyleComponent val_1 = this.GetComponent<SRF.UI.StyleComponent>();
            this._styleComponent = val_1;
            this._defaultKey = val_1.StyleKey;
            this.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this._isTransparent == false)
            {
                goto label_0;
            }
            
            label_8:
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if(val_1._enableBackgroundTransparency == true)
            {
                    return;
            }
            
            this._styleComponent.StyleKey = this._defaultKey;
            this._isTransparent = false;
            return;
            label_0:
            SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
            if(val_2._enableBackgroundTransparency != false)
            {
                    this._styleComponent.StyleKey = this.TransparentStyleKey;
                this._isTransparent = true;
                return;
            }
            
            if(this._isTransparent == true)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DebugPanelBackgroundBehaviour()
        {
            this.TransparentStyleKey = "";
        }
    
    }

}
