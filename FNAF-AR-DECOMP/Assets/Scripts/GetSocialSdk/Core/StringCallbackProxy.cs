using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class StringCallbackProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<string> _onSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StringCallbackProxy(System.Action<string> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            this._onSuccess = onSuccess;
            this._onFailure = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onSuccess(string value)
        {
            this.HandleValue<System.String>(value:  value, onSuccess:  this._onSuccess);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onFailure(UnityEngine.AndroidJavaObject throwable)
        {
            this.HandleError(throwable:  throwable, onFailure:  this._onFailure);
        }
    
    }

}
