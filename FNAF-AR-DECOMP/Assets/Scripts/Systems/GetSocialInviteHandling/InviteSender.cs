using UnityEngine;

namespace Systems.GetSocialInviteHandling
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InviteSender
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.LoginDomain _loginDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.Server.ServerDomain serverDomain, Server.LoginDomain loginDomain)
        {
            this._serverDomain = serverDomain;
            this._loginDomain = loginDomain;
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this._eventExposer = val_1.eventExposer;
            val_1.eventExposer.add_GetSocialInvitePayloadReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::MakeInviteJsonPayload(string payload)));
            this._eventExposer.add_GetSocialInviteExplicitContent(value:  new System.Action<GetSocialInviteContent>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::MakeInviteExplicit(Systems.GetSocialInviteHandling.InviteSender.GetSocialInviteContent payload)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this._eventExposer != null)
            {
                    this._eventExposer.remove_GetSocialInvitePayloadReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::MakeInviteJsonPayload(string payload)));
                this._eventExposer.remove_GetSocialInviteExplicitContent(value:  new System.Action<GetSocialInviteContent>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::MakeInviteExplicit(Systems.GetSocialInviteHandling.InviteSender.GetSocialInviteContent payload)));
            }
            
            this._loginDomain = 0;
            this._eventExposer = 0;
            this._serverDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RetrievePayload()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_InviteFriend();
            this._serverDomain.getSocialInviteSendPayloadRequester.GetPayload();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnComplete(string channelId)
        {
            this._serverDomain.getSocialInviteResultRequester.SendInviteResult(wasComplete:  true);
            if((UnityEngine.PlayerPrefs.GetInt(key:  "PushNotificationPermissionAsked", defaultValue:  0)) > 0)
            {
                    return;
            }
            
            this._loginDomain.pushNotificationsInitializer.ShowPushRationaleDialogBeforeEnable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCancel(string channelId)
        {
            this._serverDomain.getSocialInviteResultRequester.SendInviteResult(wasComplete:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnFailure(string channelId, GetSocialSdk.Core.GetSocialError error)
        {
            this._serverDomain.getSocialInviteResultRequester.SendInviteResult(wasComplete:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MakeInviteJsonPayload(string payload)
        {
            GetSocialSdk.Core.LinkParams val_1 = new GetSocialSdk.Core.LinkParams();
            val_1.Add(key:  "payload", value:  payload);
            bool val_8 = GetSocialSdk.Ui.GetSocialUi.CreateInvitesView().SetLinkParams(linkParams:  val_1).SetInviteCallbacks(onComplete:  new System.Action<System.String>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::OnComplete(string channelId)), onCancel:  new System.Action<System.String>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::OnCancel(string channelId)), onFailure:  new System.Action<System.String, GetSocialSdk.Core.GetSocialError>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::OnFailure(string channelId, GetSocialSdk.Core.GetSocialError error))).Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MakeInviteExplicit(Systems.GetSocialInviteHandling.InviteSender.GetSocialInviteContent payload)
        {
            bool val_11 = GetSocialSdk.Ui.GetSocialUi.CreateInvitesView().SetCustomInviteContent(inviteContent:  GetSocialSdk.Core.InviteContent.CreateBuilder().WithText(text:  payload.Description).WithSubject(subject:  payload.Title).Build()).SetInviteCallbacks(onComplete:  new System.Action<System.String>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::OnComplete(string channelId)), onCancel:  new System.Action<System.String>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::OnCancel(string channelId)), onFailure:  new System.Action<System.String, GetSocialSdk.Core.GetSocialError>(object:  this, method:  System.Void Systems.GetSocialInviteHandling.InviteSender::OnFailure(string channelId, GetSocialSdk.Core.GetSocialError error))).Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InviteSender()
        {
        
        }
    
    }

}
