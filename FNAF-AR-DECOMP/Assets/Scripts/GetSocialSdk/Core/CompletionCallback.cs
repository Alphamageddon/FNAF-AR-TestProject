using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class CompletionCallback : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action _onSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CompletionCallback(System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            this._onSuccess = onSuccess;
            this._onFailure = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onSuccess()
        {
            GetSocialSdk.Core.JavaInterfaceProxy.ExecuteOnMainThread(action:  this._onSuccess);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onFailure(UnityEngine.AndroidJavaObject throwable)
        {
            this.HandleError(throwable:  throwable, onFailure:  this._onFailure);
        }
    
    }

}
