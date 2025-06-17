using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PrivacyPolicyTermsOfServiceStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PrivacyPolicyTermsOfServiceAcceptedKey = "PrivacyPolicyTermsOfServiceAcceptedKey";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string TOSTitleKey = "ui_start_up_terms_of_service_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string TOSMessageKey = "ui_start_up_terms_of_service_message";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string TOSAcceptButtonKey = "ui_start_up_terms_of_service_accept_button";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string TOSPrivacyButtonKey = "ui_start_up_terms_of_service_privacy_button";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string TOSTermsButtonKey = "ui_start_up_terms_of_service_terms_button";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string termsTitleString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string termsMessageString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string termsAcceptButtonString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string termsPrivacyButtonString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string termsTOSButtonString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _dialog;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.PrivacyPolicyTermsOfServiceStartupTask Setup(Master.EventExposer masterEvents, Game.Localization.ILocalization localLocalization)
        {
            string val_5;
            string val_6;
            string val_7;
            this._masterEvents = masterEvents;
            this.FetchLocalization(localLocalization:  localLocalization);
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .title = this.termsTitleString;
                .message = this.termsMessageString;
                val_5 = this.termsAcceptButtonString;
            }
            else
            {
                    mem[16] = this.termsTitleString;
                mem[24] = this.termsMessageString;
                val_5 = this.termsAcceptButtonString;
            }
            
            .positiveButtonText = val_5;
            System.Action val_2 = new System.Action(object:  this, method:  System.Void Master.Startup.PrivacyPolicyTermsOfServiceStartupTask::OnYes());
            if(val_1 != null)
            {
                    .positiveButtonAction = val_2;
                val_6 = this.termsPrivacyButtonString;
            }
            else
            {
                    mem[40] = val_2;
                val_6 = this.termsPrivacyButtonString;
            }
            
            .negativeButtonText = val_6;
            System.Action val_3 = new System.Action(object:  this, method:  System.Void Master.Startup.PrivacyPolicyTermsOfServiceStartupTask::OnViewPrivacy());
            if(val_1 != null)
            {
                    .negativeButtonAction = val_3;
                val_7 = this.termsTOSButtonString;
            }
            else
            {
                    mem[72] = val_3;
                val_7 = this.termsTOSButtonString;
            }
            
            .neutralButtonText = val_7;
            .neutralButtonAction = new System.Action(object:  this, method:  System.Void Master.Startup.PrivacyPolicyTermsOfServiceStartupTask::OnViewTermsOfUse());
            this._dialog = val_1;
            return (Master.Startup.PrivacyPolicyTermsOfServiceStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FetchLocalization(Game.Localization.ILocalization localLocalization)
        {
            var val_11 = 0;
            val_11 = val_11 + 1;
            this.termsTitleString = localLocalization.GetLocalizedString(localizedStringId:  "ui_start_up_terms_of_service_title", originalString:  this.termsTitleString);
            var val_12 = 0;
            val_12 = val_12 + 1;
            this.termsMessageString = localLocalization.GetLocalizedString(localizedStringId:  "ui_start_up_terms_of_service_message", originalString:  this.termsMessageString);
            var val_13 = 0;
            val_13 = val_13 + 1;
            this.termsAcceptButtonString = localLocalization.GetLocalizedString(localizedStringId:  "ui_start_up_terms_of_service_accept_button", originalString:  this.termsAcceptButtonString);
            var val_14 = 0;
            val_14 = val_14 + 1;
            this.termsPrivacyButtonString = localLocalization.GetLocalizedString(localizedStringId:  "ui_start_up_terms_of_service_privacy_button", originalString:  this.termsPrivacyButtonString);
            var val_15 = 0;
            val_15 = val_15 + 1;
            this.termsTOSButtonString = localLocalization.GetLocalizedString(localizedStringId:  "ui_start_up_terms_of_service_terms_button", originalString:  this.termsTOSButtonString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents = 0;
            this._dialog = 0;
            this._parent = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "Legal Stuff";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            if(this.ShouldShow() != false)
            {
                    this._masterEvents.GenericDialogRequest(genericDialogData:  this._dialog);
                return;
            }
            
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldShow()
        {
            return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "PrivacyPolicyTermsOfServiceAcceptedKey", defaultValue:  0)) != 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnYes()
        {
            UnityEngine.PlayerPrefs.SetInt(key:  "PrivacyPolicyTermsOfServiceAcceptedKey", value:  1);
            this._masterEvents.OnToSAccepted();
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnViewPrivacy()
        {
            UnityEngine.Application.OpenURL(url:  "https://illumix.com/privacy-policy/");
            this._masterEvents.GenericDialogRequest(genericDialogData:  this._dialog);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnViewTermsOfUse()
        {
            UnityEngine.Application.OpenURL(url:  "https://illumix.com/tou/");
            this._masterEvents.GenericDialogRequest(genericDialogData:  this._dialog);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PrivacyPolicyTermsOfServiceStartupTask()
        {
            this.termsTitleString = "Important Notice";
            this.termsMessageString = "To provide this experience and improve our services, data is processed and collected from your device by Illumix and our partners. You can limit collection of some of this data in the Settings menu. FNAF AR: Special Delivery is a free to play game with in-app purchases. The purchasing function can be disabled in your device settings. By continuing, you confirm you have read and agree to the Privacy Policy & Terms of Use.";
            this.termsAcceptButtonString = "ACCEPT";
            this.termsPrivacyButtonString = "Privacy Policy";
            this.termsTOSButtonString = "Terms of Use";
        }
    
    }

}
