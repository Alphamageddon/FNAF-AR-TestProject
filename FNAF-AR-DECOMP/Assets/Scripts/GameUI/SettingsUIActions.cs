using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SettingsUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SettingsUIView settingsUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Settings dialogHandler_Settings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Server.ILoginHandler loginController;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OpenTermsOfService()
        {
            UnityEngine.Application.OpenURL(url:  this.settingsUIView.termsOfUseUrlString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OpenPrivacyPolicy()
        {
            UnityEngine.Application.OpenURL(url:  this.settingsUIView.privacyPolicyUrlString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OpenHelpAndSupport()
        {
            UnityEngine.Application.OpenURL(url:  this.settingsUIView.helpUrlString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RunFaceBookLogic()
        {
            if(Facebook.Unity.FB.IsLoggedIn != false)
            {
                    this.LogoutOfFaceBookConfirm();
                return;
            }
            
            this.ConnectToFacebook();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConnectToFacebook()
        {
            IntPtr val_3;
            System.Action val_1 = null;
            val_3 = System.Void GameUI.SettingsUIActions::OnCanSyncCallback();
            val_1 = new System.Action(object:  this, method:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 10;
            this.loginController.FacebookTryToLink(determineSyncAccountCallback:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCanSyncCallback()
        {
            this.dialogHandler_Settings.ShowFacebookAccountSyncDialog(syncPreviousPlayer:  new System.Action(object:  this, method:  System.Void GameUI.SettingsUIActions::SyncPrevPlayer()), syncNewPlayer:  new System.Action(object:  this, method:  System.Void GameUI.SettingsUIActions::SyncNewPlayer()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SyncPrevPlayer()
        {
            IntPtr val_3;
            System.Action val_1 = null;
            val_3 = System.Void GameUI.SettingsUIActions::ShowRestartScreen();
            val_1 = new System.Action(object:  this, method:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 14;
            this.loginController.SyncPreviousPlayer(callback:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowRestartScreen()
        {
            this.dialogHandler_Settings.ShowRestartDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SyncNewPlayer()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.loginController.SyncCurrentPlayer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LogoutOfFaceBookConfirm()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            new System.Action() = new System.Action(object:  this.loginController, method:  public System.Void Systems.Server.ILoginHandler::LogoutOfFacebookConnect());
            this.dialogHandler_Settings.ShowFacebookDisconnectConfirm(logoutOfFacebookConnect:  new System.Action());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleVibration()
        {
            bool val_1 = VibrationSettings.VibrationIsEnabled();
            val_1 = (~val_1) & 1;
            VibrationSettings.VibrationEnable(value:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OpenAbout()
        {
            this.dialogHandler_Settings.ShowAboutDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectTermsAndService()
        {
            this.dialogHandler_Settings.ShowTermsDialog(openTermsOfService:  new System.Action(object:  this, method:  System.Void GameUI.SettingsUIActions::OpenTermsOfService()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectPrivacyPolicy()
        {
            this.dialogHandler_Settings.ShowPrivacyDialog(openPrivacyPolicy:  new System.Action(object:  this, method:  System.Void GameUI.SettingsUIActions::OpenPrivacyPolicy()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectHelpAndSupport()
        {
            this.dialogHandler_Settings.OpenHelpDialog(openHelpAndSupport:  new System.Action(object:  this, method:  System.Void GameUI.SettingsUIActions::OpenHelpAndSupport()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectFacebook()
        {
            this.RunFaceBookLogic();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Server.LoginDomain val_3 = Master.MasterDomain.GetDomain().theGameDomain.loginDomain;
            this.loginController = val_3.LoginController;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SettingsUIActions()
        {
        
        }
    
    }

}
