using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class StyleRoot : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.StyleSheet _activeStyleSheet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.StyleSheet StyleSheet;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.Style GetStyle(string key)
        {
            if(this.StyleSheet == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  "[StyleRoot] StyleSheet is not set.", context:  this);
                return 0;
            }
            
            if(this.StyleSheet != null)
            {
                    return this.StyleSheet.GetStyle(key:  key, searchParent:  true);
            }
            
            return this.StyleSheet.GetStyle(key:  key, searchParent:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this._activeStyleSheet = 0;
            if(this.StyleSheet == 0)
            {
                    return;
            }
            
            this.OnStyleSheetChanged();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            this.OnStyleSheetChanged();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this._activeStyleSheet == this.StyleSheet)
            {
                    return;
            }
            
            this.OnStyleSheetChanged();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnStyleSheetChanged()
        {
            this._activeStyleSheet = this.StyleSheet;
            this.BroadcastMessage(methodName:  "SRStyleDirty", options:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDirty()
        {
            this._activeStyleSheet = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StyleRoot()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
