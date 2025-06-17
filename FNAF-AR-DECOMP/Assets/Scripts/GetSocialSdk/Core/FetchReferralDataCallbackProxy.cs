using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class FetchReferralDataCallbackProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.ReferralData> _onSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FetchReferralDataCallbackProxy(System.Action<GetSocialSdk.Core.ReferralData> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            this._onSuccess = onSuccess;
            this._onFailure = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onSuccess(UnityEngine.AndroidJavaObject referralDataAJO)
        {
            this.HandleValue<GetSocialSdk.Core.ReferralData>(value:  new GetSocialSdk.Core.ReferralData().ParseFromAJO(ajo:  referralDataAJO), onSuccess:  this._onSuccess);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onFailure(UnityEngine.AndroidJavaObject throwable)
        {
            this.HandleError(throwable:  throwable, onFailure:  this._onFailure);
        }
    
    }

}
