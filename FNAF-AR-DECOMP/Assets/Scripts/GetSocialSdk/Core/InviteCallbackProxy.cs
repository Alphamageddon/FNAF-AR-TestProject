using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class InviteCallbackProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action _onComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action _onCancel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InviteCallbackProxy(System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            this._onComplete = onComplete;
            this._onCancel = onCancel;
            this._onFailure = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onComplete()
        {
            UnityEngine.Debug.Log(message:  "Complete");
            GetSocialSdk.Core.JavaInterfaceProxy.ExecuteOnMainThread(action:  this._onComplete);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onCancel()
        {
            UnityEngine.Debug.Log(message:  "Cancel");
            GetSocialSdk.Core.JavaInterfaceProxy.ExecuteOnMainThread(action:  this._onCancel);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onError(UnityEngine.AndroidJavaObject throwable)
        {
            this.HandleError(throwable:  throwable, onFailure:  this._onFailure);
        }
    
    }

}
