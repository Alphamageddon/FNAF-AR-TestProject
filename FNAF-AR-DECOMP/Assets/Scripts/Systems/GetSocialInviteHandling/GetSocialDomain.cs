using UnityEngine;

namespace Systems.GetSocialInviteHandling
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GetSocialDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldInitOnStartup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.LoginDomain _loginDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _initOnSetup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.GetSocialInviteHandling.InviteSender InviteSender;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.GetSocialInviteHandling.InviteReceiver InviteReceiver;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.GetSocialInviteHandling.FazPassData fazPassData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetGetSocialLocalization()
        {
            string val_5;
            if((Game.Localization.LocalizationDomain.Instance.CurrentLanguage - 1) <= 5)
            {
                    var val_5 = 52946252 + ((val_2 - 1)) << 2;
                val_5 = val_5 + 52946252;
            }
            else
            {
                    val_5 = "en";
                bool val_4 = GetSocialSdk.Core.GetSocial.SetLanguage(languageCode:  null);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeGetSocial()
        {
            GetSocialSdk.Core.GetSocialFBMessengerPluginHelper.RegisterFBMessengerPlugin();
            GetSocialSdk.Core.GetSocial.WhenInitialized(action:  new System.Action(object:  this, method:  System.Void Systems.GetSocialInviteHandling.GetSocialDomain::SetGetSocialLocalization()));
            GetSocialSdk.Core.GetSocial.Init();
            if(this._shouldInitOnStartup != false)
            {
                    return;
            }
            
            this._eventExposer.remove_ToSAccepted(value:  new System.Action(object:  this, method:  System.Void Systems.GetSocialInviteHandling.GetSocialDomain::InitializeGetSocial()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandlePause(bool paused)
        {
            if(paused == true)
            {
                    return;
            }
            
            if(this.InviteReceiver == null)
            {
                    return;
            }
            
            this.InviteReceiver.GetReferral();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetFazPassInfo(bool fazPassInEffect, bool canContinue, int numInvites)
        {
            .<NumInvites>k__BackingField = numInvites;
            .<IsFazPassInEffect>k__BackingField = fazPassInEffect;
            this.fazPassData = new Systems.GetSocialInviteHandling.FazPassData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialDomain(Game.Server.ServerDomain serverDomain, Server.LoginDomain loginDomain, Master.EventExposer eventExposer)
        {
            val_1 = new System.Object();
            this._serverDomain = serverDomain;
            this._loginDomain = val_1;
            this._eventExposer = eventExposer;
            this.InviteReceiver = new Systems.GetSocialInviteHandling.InviteReceiver();
            this.InviteSender = new Systems.GetSocialInviteHandling.InviteSender();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(bool shouldInitOnSetup)
        {
            this._shouldInitOnStartup = shouldInitOnSetup;
            if(shouldInitOnSetup != false)
            {
                    this.InitializeGetSocial();
            }
            else
            {
                    this._eventExposer.add_ToSAccepted(value:  new System.Action(object:  this, method:  System.Void Systems.GetSocialInviteHandling.GetSocialDomain::InitializeGetSocial()));
            }
            
            this.InviteReceiver.Setup(getSocialDomain:  this, serverDomain:  this._serverDomain, eventExposer:  this._eventExposer);
            this.InviteSender.Setup(serverDomain:  this._serverDomain, loginDomain:  this._loginDomain);
            this._eventExposer.add_LoadingDone(value:  new System.Action(object:  this, method:  System.Void Systems.GetSocialInviteHandling.GetSocialDomain::ReferralCheck()));
            this._eventExposer.add_GetSocialValidated(value:  new System.Action<System.Boolean, System.Boolean, System.Int32>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.GetSocialDomain::SetFazPassInfo(bool fazPassInEffect, bool canContinue, int numInvites)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReferralCheck()
        {
            if(this.InviteReceiver == null)
            {
                    return;
            }
            
            this.InviteReceiver.GetReferral();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.InviteSender.Teardown();
            this.InviteSender = 0;
            this.InviteReceiver._serverDomain = 0;
            this.InviteReceiver = 0;
            this._eventExposer = 0;
        }
    
    }

}
