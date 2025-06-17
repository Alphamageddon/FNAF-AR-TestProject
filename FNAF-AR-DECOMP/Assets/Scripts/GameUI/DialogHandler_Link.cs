using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Link : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _confirmDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert _confirmLeaveAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CONFIRM_TEXT = "ui_spawn_url_dialog_Confirm";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CANCEL_TEXT = "ui_spawn_url_dialog_Cancel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string PROMPT_TEXT = "ui_spawn_url_dialog_Prompt";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _confirmText;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowConfirmDialog(string URL)
        {
            DialogHandler_Link.<>c__DisplayClass6_0 val_1 = new DialogHandler_Link.<>c__DisplayClass6_0();
            if(val_1 != null)
            {
                    .URL = URL;
            }
            else
            {
                    mem[16] = URL;
            }
            
            .<>4__this = this;
            PaperPlaneTools.Alert val_3 = this._confirmLeaveAlert.SetPositiveButton(title:  this._confirmText, handler:  new System.Action(object:  val_1, method:  System.Void DialogHandler_Link.<>c__DisplayClass6_0::<ShowConfirmDialog>b__0()));
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this._confirmLeaveAlert, backButtonAction:  new System.Action(object:  val_1, method:  System.Void DialogHandler_Link.<>c__DisplayClass6_0::<ShowConfirmDialog>b__1()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            PaperPlaneTools.Alert val_1 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this._confirmLeaveAlert = val_1;
            PaperPlaneTools.Alert val_3 = val_1.SetAdapter(adaper:  this._confirmDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Link::<Start>b__7_0(Game.Localization.ILocalization iLocalization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this._confirmLeaveAlert != null)
            {
                    this._confirmLeaveAlert.Dismiss();
            }
            
            this._confirmLeaveAlert = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Link()
        {
            this._confirmText = "CONFIRM";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Start>b__7_0(Game.Localization.ILocalization iLocalization)
        {
            var val_9 = 0;
            val_9 = val_9 + 1;
            var val_10 = 0;
            val_10 = val_10 + 1;
            var val_11 = 0;
            val_11 = val_11 + 1;
            this._confirmText = iLocalization.GetLocalizedString(localizedStringId:  "ui_spawn_url_dialog_Confirm", originalString:  "ui_spawn_url_dialog_Confirm");
            PaperPlaneTools.Alert val_7 = this._confirmLeaveAlert.SetMessage(message:  iLocalization.GetLocalizedString(localizedStringId:  "ui_spawn_url_dialog_Prompt", originalString:  "ui_spawn_url_dialog_Prompt"));
            PaperPlaneTools.Alert val_8 = this._confirmLeaveAlert.SetNegativeButton(title:  iLocalization.GetLocalizedString(localizedStringId:  "ui_spawn_url_dialog_Cancel", originalString:  "ui_spawn_url_dialog_Cancel"), handler:  0);
        }
    
    }

}
