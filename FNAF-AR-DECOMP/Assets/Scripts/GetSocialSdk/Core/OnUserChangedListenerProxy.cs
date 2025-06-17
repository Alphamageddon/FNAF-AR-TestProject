using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class OnUserChangedListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action _onUserChanged;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OnUserChangedListenerProxy(System.Action onUserChanged)
        {
            this._onUserChanged = onUserChanged;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onUserChanged()
        {
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  this._onUserChanged);
        }
    
    }

}
