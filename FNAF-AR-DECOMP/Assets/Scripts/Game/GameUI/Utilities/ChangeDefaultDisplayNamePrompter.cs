using UnityEngine;

namespace Game.GameUI.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ChangeDefaultDisplayNamePrompter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ProfileUIActions _profileUiActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string TITLE_TEXT = "ui_profile_changeDisplayUsername_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string PROMPT_TEXT = "ui_profile_changeDisplayUsername_text";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CANCEL_TEXT = "ui_profile_changeDisplayUsername_no";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CONFIRM_TEXT = "ui_profile_changeDisplayUsername_yes";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HasAlreadyPromptedUsernameChange = "HasAlreadyPromptedUsernameChange";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(GameUI.ProfileUIActions profileUiActions, Master.MasterDomain masterDomain)
        {
            this._profileUiActions = profileUiActions;
            this._masterDomain = masterDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleInvite()
        {
            if(this.ShouldShowDialog() != false)
            {
                    Game.Localization.LocalizationDomain val_2 = Game.Localization.LocalizationDomain.Instance;
                var val_14 = 0;
                val_14 = val_14 + 1;
            }
            else
            {
                    this.StartInvite();
                return;
            }
            
            .title = val_2.ILocalization.GetLocalizedString(localizedStringId:  "ui_profile_changeDisplayUsername_title", originalString:  "ui_profile_changeDisplayUsername_title");
            var val_15 = 0;
            val_15 = val_15 + 1;
            .message = val_2.ILocalization.GetLocalizedString(localizedStringId:  "ui_profile_changeDisplayUsername_text", originalString:  "ui_profile_changeDisplayUsername_text");
            var val_16 = 0;
            val_16 = val_16 + 1;
            .positiveButtonText = val_2.ILocalization.GetLocalizedString(localizedStringId:  "ui_profile_changeDisplayUsername_yes", originalString:  "ui_profile_changeDisplayUsername_yes");
            .positiveButtonAction = new System.Action(object:  this, method:  public System.Void Game.GameUI.Utilities.ChangeDefaultDisplayNamePrompter::OnYes());
            var val_17 = 0;
            val_17 = val_17 + 1;
            .negativeButtonText = val_2.ILocalization.GetLocalizedString(localizedStringId:  "ui_profile_changeDisplayUsername_no", originalString:  "ui_profile_changeDisplayUsername_no");
            .negativeButtonAction = new System.Action(object:  this, method:  public System.Void Game.GameUI.Utilities.ChangeDefaultDisplayNamePrompter::OnNo());
            this._masterDomain.eventExposer.GenericDialogRequest(genericDialogData:  new GameUI.GenericDialogData());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool HasDisplayNameChanged()
        {
            Server.LoginDomain val_3 = this._masterDomain.theGameDomain.loginDomain;
            if(val_3.playerProfile != null)
            {
                    return System.String.op_Inequality(a:  UnityEngine.PlayerPrefs.GetString(key:  "InitialPlayerNameKey"), b:  val_3.playerProfile.displayName);
            }
            
            return System.String.op_Inequality(a:  UnityEngine.PlayerPrefs.GetString(key:  "InitialPlayerNameKey"), b:  val_3.playerProfile.displayName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool HasAlreadyAsked()
        {
            return UnityEngine.PlayerPrefs.HasKey(key:  "HasAlreadyPromptedUsernameChange");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldShowDialog()
        {
            var val_4;
            bool val_1 = this.HasDisplayNameChanged();
            if(val_1 != false)
            {
                    val_4 = 0;
            }
            else
            {
                    bool val_2 = val_1.HasAlreadyAsked();
                val_4 = val_2 ^ 1;
            }
            
            val_2 = val_4;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnYes()
        {
            UnityEngine.PlayerPrefs.SetString(key:  "HasAlreadyPromptedUsernameChange", value:  "1");
            this._profileUiActions.ShowProfile();
            this._profileUiActions.ChangeTopPanel(tab:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNo()
        {
            UnityEngine.PlayerPrefs.SetString(key:  "HasAlreadyPromptedUsernameChange", value:  "1");
            this.StartInvite();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartInvite()
        {
            this._profileUiActions.DecrementNumInvites();
            this._masterDomain.getSocialDomain.InviteSender.RetrievePayload();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ChangeDefaultDisplayNamePrompter()
        {
        
        }
    
    }

}
