using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class InvitesViewBuilder : ViewBuilder<GetSocialSdk.Ui.InvitesViewBuilder>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.LinkParams _linkParams;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.InviteContent _inviteContent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _onInviteComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _onInviteCancel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string, GetSocialSdk.Core.GetSocialError> _onInviteFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.InvitesViewBuilder SetCustomInviteContent(GetSocialSdk.Core.InviteContent inviteContent)
        {
            this._inviteContent = inviteContent;
            return (GetSocialSdk.Ui.InvitesViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.InvitesViewBuilder SetCustomReferralData(GetSocialSdk.Core.CustomReferralData customReferralData)
        {
            this._linkParams = new GetSocialSdk.Core.LinkParams(data:  customReferralData);
            return (GetSocialSdk.Ui.InvitesViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.InvitesViewBuilder SetLinkParams(GetSocialSdk.Core.LinkParams linkParams)
        {
            this._linkParams = linkParams;
            return (GetSocialSdk.Ui.InvitesViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.InvitesViewBuilder SetInviteCallbacks(System.Action<string> onComplete, System.Action<string> onCancel, System.Action<string, GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onComplete, argumentName:  "onComplete", message:  0);
            Check.Argument.IsNotNull(argument:  onCancel, argumentName:  "onCancel", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            this._onInviteComplete = onComplete;
            this._onInviteCancel = onCancel;
            this._onInviteFailure = onFailure;
            return (GetSocialSdk.Ui.InvitesViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override bool ShowInternal()
        {
            return this.ShowBuilder(builder:  this.ToAJO());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject ToAJO()
        {
            T[] val_12 = System.Array.Empty<System.Object>();
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.ui.invites.InvitesViewBuilder", args:  val_12 = System.Array.Empty<System.Object>());
            if(this._linkParams != null)
            {
                    object[] val_3 = new object[1];
                val_12 = val_3;
                val_12[0] = this._linkParams.ToAjo();
                UnityEngine.AndroidJavaObject val_5 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setLinkParams", args:  val_3);
            }
            
            if(this._inviteContent != null)
            {
                    val_12 = this._inviteContent.ToAjo();
                object[] val_7 = new object[1];
                val_7[0] = val_12;
                UnityEngine.AndroidJavaObject val_8 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setCustomInviteContent", args:  val_7);
            }
            
            if(this._onInviteComplete == null)
            {
                    return val_2;
            }
            
            object[] val_9 = new object[1];
            GetSocialSdk.Ui.InviteUiCallbackProxy val_10 = null;
            val_12 = val_10;
            val_10 = new GetSocialSdk.Ui.InviteUiCallbackProxy(onComplete:  this._onInviteComplete, onCancel:  this._onInviteCancel, onFailure:  this._onInviteFailure);
            val_9[0] = val_12;
            UnityEngine.AndroidJavaObject val_11 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setInviteCallback", args:  val_9);
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InvitesViewBuilder()
        {
        
        }
    
    }

}
