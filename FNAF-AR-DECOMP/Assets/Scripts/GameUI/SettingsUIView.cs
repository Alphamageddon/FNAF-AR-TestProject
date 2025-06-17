using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SettingsUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button vibrationButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI vibrationText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button facebookButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI facebookText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI aboutDialogVersionText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI aboutPlayerIdText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI serverVersionText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI dataVersionText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string vibrationOnString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string vibrationOffString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string facebookConnectedString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string facebookDisconnectedString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string vibrationNotSupportedString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string helpUrlString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string privacyPolicyUrlString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string termsOfUseUrlString;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAboutDialogText()
        {
            this.aboutDialogVersionText.text = UnityEngine.Application.version;
            Server.LoginDomain val_3 = this._masterDomain.theGameDomain.loginDomain;
            this.aboutPlayerIdText.text = val_3.playerProfile.userId;
            GameUI.Domain val_4 = this._masterDomain.gameUIDomain;
            this.dataVersionText.text = val_4.gameUIData.<buttonConfigs>k__BackingField.ToString();
            Server.LoginDomain val_7 = this._masterDomain.theGameDomain.loginDomain;
            var val_15 = 0;
            val_15 = val_15 + 1;
            this.serverVersionText.text = val_7.LoginController.GetServerVersion();
            Game.MasterData.GetAccessToData val_10 = this._masterDomain.MasterDataDomain.GetAccessToData;
            if(val_10.KeyValueAccess != null)
            {
                    this.helpUrlString = val_10.KeyValueAccess.GetString(key:  "kv_ui_settings_supportlink", fallback:  "https://www.fnafar.com/support");
            }
            else
            {
                    this.helpUrlString = 0.GetString(key:  "kv_ui_settings_supportlink", fallback:  "https://www.fnafar.com/support");
            }
            
            this.privacyPolicyUrlString = val_10.KeyValueAccess.GetString(key:  "kv_ui_settings_privacypolicylink", fallback:  "https://illumix.com/privacy-policy/");
            this.termsOfUseUrlString = val_10.KeyValueAccess.GetString(key:  "kv_ui_settings_toulink", fallback:  "https://illumix.com/tou/");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetHelpUrl()
        {
            return (string)this.helpUrlString;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetPrivacyPolicyUrl()
        {
            return (string)this.privacyPolicyUrlString;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetTermsOfUseUrl()
        {
            return (string)this.termsOfUseUrlString;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateButtonStates()
        {
            this.UpdateVibrationButtonText();
            this.UpdateFacebookConnectedText();
            this.UpdateFacebookInteractivity();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateFacebookInteractivity()
        {
            this.facebookButton.interactable = Facebook.Unity.FB.IsInitialized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateFacebookConnectedText()
        {
            if(Facebook.Unity.FB.IsLoggedIn == false)
            {
                goto label_3;
            }
            
            if(this.facebookText != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this.facebookText.text = this.facebookConnectedString;
            return;
            label_3:
            if(this.facebookText != null)
            {
                goto label_5;
            }
            
            goto label_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVibrationButtonText()
        {
            TMPro.TextMeshProUGUI val_3;
            string val_4;
            if(UnityEngine.SystemInfo.supportsVibration == false)
            {
                goto label_1;
            }
            
            val_3 = this.vibrationText;
            if(VibrationSettings.VibrationIsEnabled() == false)
            {
                goto label_4;
            }
            
            val_4 = this.vibrationOnString;
            if(val_3 != null)
            {
                goto label_8;
            }
            
            goto label_9;
            label_1:
            val_3 = this.vibrationText;
            val_4 = this.vibrationNotSupportedString;
            if(val_3 != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            val_3.text = val_4;
            return;
            label_4:
            if(val_3 != null)
            {
                goto label_8;
            }
            
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FetchLocalizedStrings()
        {
            this.SetVibrationButtonText();
            this.SetFacebookConnectedText();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetFacebookConnectedText()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.SettingsUIView::<SetFacebookConnectedText>b__26_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetVibrationButtonText()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.SettingsUIView::<SetVibrationButtonText>b__27_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            this.SetVibrationButtonText();
            this.SetFacebookConnectedText();
            this.CheckVibrationSupported();
            this.UpdateAboutDialogText();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckVibrationSupported()
        {
            this.vibrationButton.interactable = UnityEngine.SystemInfo.supportsVibration;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdateButtonStates();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SettingsUIView()
        {
            this.vibrationOnString = "ON";
            this.vibrationOffString = "OFF";
            this.facebookConnectedString = "CONNECTED";
            this.facebookDisconnectedString = "DISCONNECTED";
            this.vibrationNotSupportedString = "NOT SUPPORTED";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <SetFacebookConnectedText>b__26_0(Game.Localization.ILocalization localization)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.facebookConnectedString = localization.GetLocalizedString(localizedStringId:  "ui_settings_facebook_connected", originalString:  this.facebookConnectedString);
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.facebookDisconnectedString = localization.GetLocalizedString(localizedStringId:  "ui_settings_facebook_disconnected", originalString:  this.facebookDisconnectedString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <SetVibrationButtonText>b__27_0(Game.Localization.ILocalization localization)
        {
            var val_7 = 0;
            val_7 = val_7 + 1;
            this.vibrationOnString = localization.GetLocalizedString(localizedStringId:  "ui_settings_vibration_on", originalString:  this.vibrationOnString);
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.vibrationOffString = localization.GetLocalizedString(localizedStringId:  "ui_settings_vibration_off", originalString:  this.vibrationOffString);
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.vibrationNotSupportedString = localization.GetLocalizedString(localizedStringId:  "ui_settings_vibration_not_supported", originalString:  this.vibrationNotSupportedString);
        }
    
    }

}
