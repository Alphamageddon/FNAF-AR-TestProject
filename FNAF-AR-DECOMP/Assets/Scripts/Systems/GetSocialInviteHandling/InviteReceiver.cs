using UnityEngine;

namespace Systems.GetSocialInviteHandling
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InviteReceiver
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string, string> _callbackOnSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _callbackOnError;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.GetSocialInviteHandling.GetSocialDomain _getSocialDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool shouldAttemptToReauth;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Systems.GetSocialInviteHandling.GetSocialDomain getSocialDomain, Game.Server.ServerDomain serverDomain, Master.EventExposer eventExposer)
        {
            this._eventExposer = eventExposer;
            this._getSocialDomain = getSocialDomain;
            this._serverDomain = serverDomain;
            eventExposer.add_GetSocialValidated(value:  new System.Action<System.Boolean, System.Boolean, System.Int32>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteReceiver::OnGetSocialValidated(bool fazPassInEffect, bool canContinue, int numInvites)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGetSocialValidated(bool fazPassInEffect, bool canContinue, int numInvites)
        {
            this.shouldAttemptToReauth = fazPassInEffect & (~canContinue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._serverDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetReferral_CallbackOnSuccess(GetSocialSdk.Core.ReferralData referralData)
        {
            var val_7;
            if(referralData != null)
            {
                    val_7 = referralData.ReferralLinkParams;
                bool val_3 = val_7.TryGetValue(key:  "payload", value: out  0);
                bool val_6 = referralData.ReferralLinkParams.TryGetValue(key:  "ticket", value: out  0);
                if(this._callbackOnSuccess == null)
            {
                    return;
            }
            
                this._callbackOnSuccess.Invoke(arg1:  "", arg2:  "");
                return;
            }
            
            if(this._callbackOnError == null)
            {
                    return;
            }
            
            this._callbackOnError.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetReferral_CallbackOnError(GetSocialSdk.Core.GetSocialError error)
        {
            if(this._callbackOnError == null)
            {
                    return;
            }
            
            this._callbackOnError.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandlePayloadOnSuccess(GetSocialSdk.Core.ReferralData referralData)
        {
            var val_7;
            Master.EventExposer val_8;
            string val_9;
            val_8 = this;
            string val_5 = 0;
            string val_2 = 0;
            if(referralData == null)
            {
                    return;
            }
            
            val_7 = referralData.ReferralLinkParams;
            bool val_3 = val_7.TryGetValue(key:  "payload", value: out  val_2);
            if(this.shouldAttemptToReauth == false)
            {
                goto label_3;
            }
            
            bool val_6 = referralData.ReferralLinkParams.TryGetValue(key:  "ticket", value: out  val_5);
            if(val_5 == 0)
            {
                goto label_5;
            }
            
            val_8 = this._eventExposer;
            val_8.OnRedeemCoupon(couponId:  val_5);
            return;
            label_3:
            val_9 = val_2;
            if(val_9 == 0)
            {
                    return;
            }
            
            if(this._serverDomain == null)
            {
                    val_9 = val_2;
            }
            
            val_8 = this._serverDomain.getSocialInviteQueryPayloadRequester;
            val_8.QueryPayload(payload:  val_9);
            return;
            label_5:
            if(val_2 == 0)
            {
                    return;
            }
            
            val_8 = this._eventExposer;
            val_8.OnReauthPayload(payload:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DefaultFailure(GetSocialSdk.Core.GetSocialError error)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetReferral(System.Action<GetSocialSdk.Core.ReferralData> OnSuccess, System.Action<GetSocialSdk.Core.GetSocialError> OnError)
        {
            GetSocialSdk.Core.GetSocial.GetReferralData(onSuccess:  OnSuccess, onFailure:  OnError);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetReferralWithCallbacks(System.Action<string, string> successCallback, System.Action failureCallback)
        {
            this._callbackOnSuccess = successCallback;
            this._callbackOnError = failureCallback;
            System.Action<GetSocialSdk.Core.GetSocialError> val_2 = new System.Action<GetSocialSdk.Core.GetSocialError>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteReceiver::GetReferral_CallbackOnError(GetSocialSdk.Core.GetSocialError error));
            val_2.GetReferral(OnSuccess:  new System.Action<GetSocialSdk.Core.ReferralData>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteReceiver::GetReferral_CallbackOnSuccess(GetSocialSdk.Core.ReferralData referralData)), OnError:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetReferral()
        {
            System.Action<GetSocialSdk.Core.GetSocialError> val_2 = new System.Action<GetSocialSdk.Core.GetSocialError>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteReceiver::DefaultFailure(GetSocialSdk.Core.GetSocialError error));
            val_2.GetReferral(OnSuccess:  new System.Action<GetSocialSdk.Core.ReferralData>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteReceiver::HandlePayloadOnSuccess(GetSocialSdk.Core.ReferralData referralData)), OnError:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InviteReceiver()
        {
        
        }
    
    }

}
