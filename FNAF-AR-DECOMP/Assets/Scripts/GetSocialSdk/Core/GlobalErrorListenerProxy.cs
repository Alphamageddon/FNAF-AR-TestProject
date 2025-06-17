using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class GlobalErrorListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onError;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GlobalErrorListenerProxy(System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            this._onError = onError;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onError(UnityEngine.AndroidJavaObject throwable)
        {
            this.HandleError(throwable:  throwable, onFailure:  this._onError);
        }
    
    }

}
