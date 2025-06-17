using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ViewStateListener : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _onOpen;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _onClose;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ViewStateListener(System.Action onOpen, System.Action onClose)
        {
            this._onOpen = onOpen;
            this._onClose = onClose;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onOpen()
        {
            if(this._onOpen == null)
            {
                    return;
            }
            
            this._onOpen.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onClose()
        {
            if(this._onClose == null)
            {
                    return;
            }
            
            this._onClose.Invoke();
        }
    
    }

}
