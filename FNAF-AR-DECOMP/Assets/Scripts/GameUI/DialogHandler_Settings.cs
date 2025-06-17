using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Settings : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject aboutDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert aboutAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string disconnectFacebookMessageString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string facebookConfirmString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string facebookCancelString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string termsAndServiceMessageString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string termsAndServiceConfirmString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string termsAndServiceCancelString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string privacyPolicyMessageString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string privacyPolicyConfirmString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string privacyPolicyCancelString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string helpMessageString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string helpConfirmString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string helpCancelString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string fbSyncTitleString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string fbSyncBodyString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string fbSyncPreviousString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string fbSyncNewString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string fbRestartTitleString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string fbRestartBodyString;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FetchLocalizationStrings()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_0(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_1(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_2(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_3(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_4(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_5(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_6(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_7(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_8(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_9(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_10(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_11(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_12(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_13(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_14(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_15(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_16(Game.Localization.ILocalization localization)));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Settings::<FetchLocalizationStrings>b__21_17(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAboutDialog()
        {
            this.aboutAlert.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowTermsDialog(System.Action openTermsOfService)
        {
            string val_2;
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .message = this.termsAndServiceMessageString;
                .positiveButtonAction = openTermsOfService;
                .positiveButtonText = this.termsAndServiceConfirmString;
                val_2 = this.termsAndServiceCancelString;
            }
            else
            {
                    mem[24] = this.termsAndServiceMessageString;
                mem[40] = openTermsOfService;
                mem[32] = this.termsAndServiceConfirmString;
                val_2 = this.termsAndServiceCancelString;
            }
            
            .negativeButtonText = val_2;
            this.masterEvents.GenericDialogRequest(genericDialogData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OpenHelpDialog(System.Action openHelpAndSupport)
        {
            string val_2;
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .message = this.helpMessageString;
                .positiveButtonAction = openHelpAndSupport;
                .positiveButtonText = this.helpConfirmString;
                val_2 = this.helpCancelString;
            }
            else
            {
                    mem[24] = this.helpMessageString;
                mem[40] = openHelpAndSupport;
                mem[32] = this.helpConfirmString;
                val_2 = this.helpCancelString;
            }
            
            .negativeButtonText = val_2;
            this.masterEvents.GenericDialogRequest(genericDialogData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowPrivacyDialog(System.Action openPrivacyPolicy)
        {
            string val_2;
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .message = this.privacyPolicyMessageString;
                .positiveButtonAction = openPrivacyPolicy;
                .positiveButtonText = this.privacyPolicyConfirmString;
                val_2 = this.privacyPolicyCancelString;
            }
            else
            {
                    mem[24] = this.privacyPolicyMessageString;
                mem[40] = openPrivacyPolicy;
                mem[32] = this.privacyPolicyConfirmString;
                val_2 = this.privacyPolicyCancelString;
            }
            
            .negativeButtonText = val_2;
            this.masterEvents.GenericDialogRequest(genericDialogData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowFacebookDisconnectConfirm(System.Action logoutOfFacebookConnect)
        {
            string val_2;
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .message = this.disconnectFacebookMessageString;
                .positiveButtonAction = logoutOfFacebookConnect;
                .positiveButtonText = this.facebookConfirmString;
                val_2 = this.facebookCancelString;
            }
            else
            {
                    mem[24] = this.disconnectFacebookMessageString;
                mem[40] = logoutOfFacebookConnect;
                mem[32] = this.facebookConfirmString;
                val_2 = this.facebookCancelString;
            }
            
            .negativeButtonText = val_2;
            this.masterEvents.GenericDialogRequest(genericDialogData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowFacebookAccountSyncDialog(System.Action syncPreviousPlayer, System.Action syncNewPlayer)
        {
            string val_2;
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .title = this.fbSyncTitleString;
                .positiveButtonAction = syncNewPlayer;
                .message = this.fbSyncBodyString;
                .negativeButtonAction = syncPreviousPlayer;
                .positiveButtonText = this.fbSyncNewString;
                val_2 = this.fbSyncPreviousString;
            }
            else
            {
                    mem[16] = this.fbSyncTitleString;
                mem[24] = this.fbSyncBodyString;
                mem[40] = syncNewPlayer;
                mem[32] = this.fbSyncNewString;
                mem[72] = syncPreviousPlayer;
                val_2 = this.fbSyncPreviousString;
            }
            
            .negativeButtonText = val_2;
            this.masterEvents.GenericDialogRequest(genericDialogData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRestartDialog()
        {
            string val_2;
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .title = this.fbRestartTitleString;
                val_2 = this.fbRestartBodyString;
            }
            else
            {
                    mem[16] = this.fbRestartTitleString;
                val_2 = this.fbRestartBodyString;
            }
            
            .message = val_2;
            this.masterEvents.GenericDialogRequest(genericDialogData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.FetchLocalizationStrings();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            PaperPlaneTools.Alert val_2 = this.aboutAlert.SetAdapter(adaper:  this.aboutDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            Master.MasterDomain val_3 = Master.MasterDomain.GetDomain();
            this.masterEvents = val_3.eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this.aboutAlert != null)
            {
                    this.aboutAlert.Dismiss();
            }
            
            this.aboutAlert = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Settings()
        {
            this.aboutAlert = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.disconnectFacebookMessageString = "Disconnect your FaceBook account?";
            this.facebookConfirmString = "Confirm";
            this.facebookCancelString = "Cancel";
            this.termsAndServiceMessageString = "This will leave FNaF AR Game and open your web browser. Are you sure?";
            this.termsAndServiceConfirmString = "Yes, leave game";
            this.termsAndServiceCancelString = "Cancel";
            this.helpConfirmString = "Yes, leave game";
            this.helpCancelString = "Cancel";
            this.privacyPolicyMessageString = "This will leave FNaF AR Game. Are you sure?";
            this.privacyPolicyConfirmString = "Yes, leave game";
            this.privacyPolicyCancelString = "Cancel";
            this.helpMessageString = "This will leave FNaF AR Game. Are you sure?";
            this.fbSyncTitleString = "fbSyncTitleString";
            this.fbSyncBodyString = "fbSyncBodyString";
            this.fbSyncPreviousString = "fbSyncPrevString";
            this.fbSyncNewString = "fbSyncNewString";
            this.fbRestartTitleString = "SYNC COMPLETE";
            this.fbRestartBodyString = "Please restart your app";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_0(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.disconnectFacebookMessageString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_disconnect_facebook_message", originalString:  this.disconnectFacebookMessageString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_1(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.facebookConfirmString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_disconnect_facebook_confirm", originalString:  this.facebookConfirmString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_2(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.facebookCancelString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_disconnect_facebook_cancel", originalString:  this.facebookCancelString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_3(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.termsAndServiceMessageString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_terms_and_service_message", originalString:  this.termsAndServiceMessageString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_4(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.termsAndServiceConfirmString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_terms_and_service_confirm", originalString:  this.termsAndServiceConfirmString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_5(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.termsAndServiceCancelString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_terms_and_service_cancel", originalString:  this.termsAndServiceCancelString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_6(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.privacyPolicyMessageString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_privacy_message", originalString:  this.privacyPolicyMessageString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_7(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.privacyPolicyConfirmString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_privacy_confirm", originalString:  this.privacyPolicyConfirmString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_8(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.privacyPolicyCancelString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_privacy_cancel", originalString:  this.privacyPolicyCancelString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_9(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.helpMessageString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_help_message", originalString:  this.helpMessageString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_10(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.helpConfirmString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_help_confirm", originalString:  this.helpConfirmString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_11(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.helpCancelString = localization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_help_cancel", originalString:  this.helpCancelString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_12(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.fbSyncTitleString = localization.GetLocalizedString(localizedStringId:  "ui_facebook_sync_flow_title", originalString:  this.fbSyncTitleString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_13(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.fbSyncBodyString = localization.GetLocalizedString(localizedStringId:  "ui_facebook_sync_flow_body", originalString:  this.fbSyncBodyString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_14(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.fbSyncPreviousString = localization.GetLocalizedString(localizedStringId:  "ui_facebook_sync_flow_syncprevious_button", originalString:  this.fbSyncPreviousString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_15(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.fbSyncNewString = localization.GetLocalizedString(localizedStringId:  "ui_facebook_sync_flow_syncnew_button", originalString:  this.fbSyncNewString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_16(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.fbRestartTitleString = localization.GetLocalizedString(localizedStringId:  "ui_facebook_sync_flow_restart_title", originalString:  this.fbRestartTitleString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalizationStrings>b__21_17(Game.Localization.ILocalization localization)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.fbRestartBodyString = localization.GetLocalizedString(localizedStringId:  "ui_facebook_sync_flow_restart_body", originalString:  this.fbRestartBodyString);
        }
    
    }

}
