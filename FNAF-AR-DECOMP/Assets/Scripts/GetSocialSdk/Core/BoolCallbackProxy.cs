using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class BoolCallbackProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<bool> _onSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BoolCallbackProxy(System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            this._onSuccess = onSuccess;
            this._onFailure = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onSuccess(bool value)
        {
            value = value;
            this.HandleValue<System.Boolean>(value:  value, onSuccess:  this._onSuccess);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onFailure(UnityEngine.AndroidJavaObject throwable)
        {
            this.HandleError(throwable:  throwable, onFailure:  this._onFailure);
        }
    
    }

}
