using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InviteUiCallbackProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<string> _onComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<string> _onCancel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<string, GetSocialSdk.Core.GetSocialError> _onFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InviteUiCallbackProxy(System.Action<string> onComplete, System.Action<string> onCancel, System.Action<string, GetSocialSdk.Core.GetSocialError> onFailure)
        {
            this._onComplete = onComplete;
            this._onCancel = onCancel;
            this._onFailure = onFailure;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onComplete(string channelId)
        {
            InviteUiCallbackProxy.<>c__DisplayClass4_0 val_1 = new InviteUiCallbackProxy.<>c__DisplayClass4_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .channelId = channelId;
            UnityEngine.Debug.Log(message:  "Complete");
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  new System.Action(object:  val_1, method:  System.Void InviteUiCallbackProxy.<>c__DisplayClass4_0::<onComplete>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onCancel(string channelId)
        {
            InviteUiCallbackProxy.<>c__DisplayClass5_0 val_1 = new InviteUiCallbackProxy.<>c__DisplayClass5_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .channelId = channelId;
            UnityEngine.Debug.Log(message:  "Cancel");
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  new System.Action(object:  val_1, method:  System.Void InviteUiCallbackProxy.<>c__DisplayClass5_0::<onCancel>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onError(string channelId, UnityEngine.AndroidJavaObject throwable)
        {
            InviteUiCallbackProxy.<>c__DisplayClass6_0 val_1 = new InviteUiCallbackProxy.<>c__DisplayClass6_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .channelId = channelId;
            }
            else
            {
                    mem[16] = this;
                mem[24] = channelId;
            }
            
            .throwable = throwable;
            UnityEngine.Debug.Log(message:  "Failure");
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  new System.Action(object:  val_1, method:  System.Void InviteUiCallbackProxy.<>c__DisplayClass6_0::<onError>b__0()));
        }
    
    }

}
