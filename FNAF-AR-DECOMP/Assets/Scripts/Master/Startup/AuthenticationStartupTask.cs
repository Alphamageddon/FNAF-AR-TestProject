using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AuthenticationStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GO_TO_FAZPASS = "FazPass";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.LoginDomain _loginDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.StreakDataUpdater _streakDataUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _dialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _forcedUpdateUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.GetSocialInviteHandling.GetSocialDomain _getSocialDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private P7.CanvasFlow.CanvasController _authenticationCanvasController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _payload;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.AuthenticationStartupTask Setup(Master.EventExposer masterEvents, Server.LoginDomain loginDomain, Game.Server.ServerDomain serverDomain, Server.StreakDataUpdater streakDataUpdater, Systems.GetSocialInviteHandling.GetSocialDomain getSocialDomain)
        {
            this._serverDomain = serverDomain;
            this._getSocialDomain = getSocialDomain;
            this._masterEvents = masterEvents;
            this._loginDomain = loginDomain;
            this._streakDataUpdater = streakDataUpdater;
            masterEvents.add_PreloadEvent(value:  new System.Action<P7.CanvasFlow.CanvasController, System.String>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)));
            return (Master.Startup.AuthenticationStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            this._masterEvents.add_Authenticated(value:  new System.Action(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::OnAuthenticated()));
            this._masterEvents.add_ForcedUpdate(value:  new System.Action<System.String>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::OnForcedUpdate(string updateUrl)));
            GameUI.GenericDialogData val_3 = new GameUI.GenericDialogData();
            if(val_3 != null)
            {
                    .title = "";
                .message = "An new update is available in the app store";
            }
            else
            {
                    mem[16] = "";
                mem[24] = "An new update is available in the app store";
            }
            
            .positiveButtonText = "Update";
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::OnYes());
            this._dialog = val_3;
            this._loginDomain.SetupForAuthentication(authFunction:  new System.Action(object:  this._masterEvents, method:  public System.Void Master.EventExposer::OnAuthenticated()), forcedUpdateFunction:  new System.Action<System.String>(object:  this._masterEvents, method:  public System.Void Master.EventExposer::OnForcedUpdate(string url)), streakUpdater:  new System.Action<Systems.Server.ServerData>(object:  this._streakDataUpdater, method:  public System.Void Server.StreakDataUpdater::Update(Systems.Server.ServerData data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPreloadEvent(P7.CanvasFlow.CanvasController controller, string eventName)
        {
            var val_2;
            if(controller == null)
            {
                    return;
            }
            
            val_2 = "start";
            if("start" == null)
            {
                    val_2 = "start";
            }
            
            if((Equals(value:  eventName)) == false)
            {
                    return;
            }
            
            this._authenticationCanvasController = controller;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAuthenticated()
        {
            this._getSocialDomain.InviteReceiver.GetReferralWithCallbacks(successCallback:  new System.Action<System.String, System.String>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::GetSocial_SuccessCallback(string payload, string fazPass)), failureCallback:  new System.Action(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::GetSocial_FailureCallback()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetSocial_SuccessCallback(string payload, string fazPass)
        {
            this._payload = payload;
            if((System.String.op_Equality(a:  fazPass, b:  "")) != false)
            {
                    this.FazPassAuthentication();
                return;
            }
            
            this._masterEvents.add_CouponRedeemed(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::OnCouponRedeemed(bool didSucceed)));
            this._masterEvents.OnRedeemCoupon(couponId:  fazPass);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCouponRedeemed(bool didSucceed)
        {
            this._masterEvents.remove_CouponRedeemed(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::OnCouponRedeemed(bool didSucceed)));
            this.FazPassAuthentication();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetSocial_FailureCallback()
        {
            this.FazPassAuthentication();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FazPassAuthentication()
        {
            this._masterEvents.add_GetSocialValidated(value:  new System.Action<System.Boolean, System.Boolean, System.Int32>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::MasterEventsOnGetSocialValidated(bool fazPassInEffect, bool canContinue, int numInvites)));
            this._serverDomain.getSocialAuthenticationRequester.AuthenticatePayload(payload:  this._payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterEventsOnGetSocialValidated(bool fazPassInEffect, bool canContinue, int numInvites)
        {
            this._masterEvents.remove_GetSocialValidated(value:  new System.Action<System.Boolean, System.Boolean, System.Int32>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::MasterEventsOnGetSocialValidated(bool fazPassInEffect, bool canContinue, int numInvites)));
            if((fazPassInEffect != false) && (canContinue != true))
            {
                    this._authenticationCanvasController.PerformTransitionWithIdentifier(identifier:  "FazPass");
                this._masterEvents.add_CouponRedeemed(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::MasterEventsOnCouponRedeemed(bool didSucceed)));
                this._masterEvents.add_ReauthPayload(value:  new System.Action<System.String>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::MasterEventsOnReauthPayload(string payload)));
                return;
            }
            
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterEventsOnReauthPayload(string payload)
        {
            this._masterEvents.add_GetSocialValidated(value:  new System.Action<System.Boolean, System.Boolean, System.Int32>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::ReauthComplete(bool fazPassInEffect, bool canContinue, int numInvites)));
            this._serverDomain.getSocialAuthenticationRequester.AuthenticatePayload(payload:  payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReauthComplete(bool fazPassInEffect, bool canContinue, int numInvites)
        {
            this._masterEvents.remove_GetSocialValidated(value:  new System.Action<System.Boolean, System.Boolean, System.Int32>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::ReauthComplete(bool fazPassInEffect, bool canContinue, int numInvites)));
            if(canContinue == false)
            {
                    return;
            }
            
            this.ShowRedemptionDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterEventsOnCouponRedeemed(bool didSucceed)
        {
            if(didSucceed == false)
            {
                    return;
            }
            
            this.ShowRedemptionDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowRedemptionDialog()
        {
            var val_3;
            System.Action val_5;
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .title = "PASS REDEEMED!";
                .message = "Please restart the app to enter.";
            }
            else
            {
                    mem[16] = "PASS REDEEMED!";
                mem[24] = "Please restart the app to enter.";
            }
            
            .positiveButtonText = "Close Now";
            val_3 = null;
            val_3 = null;
            val_5 = AuthenticationStartupTask.<>c.<>9__23_0;
            if(val_5 == null)
            {
                    System.Action val_2 = null;
                val_5 = val_2;
                val_2 = new System.Action(object:  AuthenticationStartupTask.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AuthenticationStartupTask.<>c::<ShowRedemptionDialog>b__23_0());
                AuthenticationStartupTask.<>c.<>9__23_0 = val_5;
            }
            
            .positiveButtonAction = val_5;
            this._masterEvents.GenericDialogRequest(genericDialogData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents.remove_Authenticated(value:  new System.Action(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::OnAuthenticated()));
            this._masterEvents.remove_ForcedUpdate(value:  new System.Action<System.String>(object:  this, method:  System.Void Master.Startup.AuthenticationStartupTask::OnForcedUpdate(string updateUrl)));
            this._masterEvents = 0;
            mem[1152921523295032152] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "AuthenticationStartupTask";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnYes()
        {
            UnityEngine.Application.OpenURL(url:  this._forcedUpdateUrl);
            this._masterEvents.GenericDialogRequest(genericDialogData:  this._dialog);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnForcedUpdate(string updateUrl)
        {
            this._forcedUpdateUrl = updateUrl;
            this._masterEvents.GenericDialogRequest(genericDialogData:  this._dialog);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AuthenticationStartupTask()
        {
            this._payload = "";
        }
    
    }

}
