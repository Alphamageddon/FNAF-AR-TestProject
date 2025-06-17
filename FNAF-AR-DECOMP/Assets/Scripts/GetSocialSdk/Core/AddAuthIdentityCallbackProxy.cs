using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AddAuthIdentityCallbackProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action _onComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.GetSocialError> _onFailure;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GetSocialSdk.Core.ConflictUser> _onConflict;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddAuthIdentityCallbackProxy(System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure, System.Action<GetSocialSdk.Core.ConflictUser> onConflict)
        {
            this._onComplete = onComplete;
            this._onFailure = onFailure;
            this._onConflict = onConflict;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onComplete()
        {
            GetSocialSdk.Core.JavaInterfaceProxy.ExecuteOnMainThread(action:  this._onComplete);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onFailure(UnityEngine.AndroidJavaObject throwableAJO)
        {
            this.HandleError(throwable:  throwableAJO, onFailure:  this._onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onConflict(UnityEngine.AndroidJavaObject conflictUserAJO)
        {
            GetSocialSdk.Core.ConflictUser val_1 = new GetSocialSdk.Core.ConflictUser();
            GetSocialSdk.Core.ConflictUser val_2 = val_1.ParseFromAJO(ajo:  conflictUserAJO);
            this.HandleValue<GetSocialSdk.Core.ConflictUser>(value:  val_1, onSuccess:  this._onConflict);
        }
    
    }

}
