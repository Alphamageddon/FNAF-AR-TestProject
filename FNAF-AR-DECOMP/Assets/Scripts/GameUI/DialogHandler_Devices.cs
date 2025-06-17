using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Devices : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HEADER = "ui_workshop_dialogs_confirm";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string YES = "ui_dialog_androidbackbutton_positivebutton";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string NO = "ui_dialog_androidbackbutton_negativebutton";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string BODY = "ui_dialog_devices_confirmation";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string okText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DevicesStateUIActions deviceStateUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _confirmDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert _confirmDialogAlert;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowConfirmDialog(string deviceId)
        {
            DialogHandler_Devices.<>c__DisplayClass8_0 val_1 = new DialogHandler_Devices.<>c__DisplayClass8_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .deviceId = deviceId;
            PaperPlaneTools.Alert val_3 = this._confirmDialogAlert.SetPositiveButton(title:  this.okText, handler:  new System.Action(object:  val_1, method:  System.Void DialogHandler_Devices.<>c__DisplayClass8_0::<ShowConfirmDialog>b__0()));
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this._confirmDialogAlert, backButtonAction:  new System.Action(object:  val_1, method:  System.Void DialogHandler_Devices.<>c__DisplayClass8_0::<ShowConfirmDialog>b__1()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            PaperPlaneTools.Alert val_1 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this._confirmDialogAlert = val_1;
            PaperPlaneTools.Alert val_3 = val_1.SetAdapter(adaper:  this._confirmDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            Game.Localization.LocalizationDomain val_4 = Game.Localization.LocalizationDomain.Instance;
            var val_19 = 0;
            val_19 = val_19 + 1;
            PaperPlaneTools.Alert val_7 = this._confirmDialogAlert.SetTitle(title:  val_4.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_confirm", originalString:  "ui_workshop_dialogs_confirm"));
            Game.Localization.LocalizationDomain val_8 = Game.Localization.LocalizationDomain.Instance;
            var val_20 = 0;
            val_20 = val_20 + 1;
            PaperPlaneTools.Alert val_11 = this._confirmDialogAlert.SetMessage(message:  val_8.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_devices_confirmation", originalString:  "ui_dialog_devices_confirmation"));
            Game.Localization.LocalizationDomain val_12 = Game.Localization.LocalizationDomain.Instance;
            var val_21 = 0;
            val_21 = val_21 + 1;
            PaperPlaneTools.Alert val_15 = this._confirmDialogAlert.SetNegativeButton(title:  val_12.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_androidbackbutton_negativebutton", originalString:  "ui_dialog_androidbackbutton_negativebutton"), handler:  0);
            Game.Localization.LocalizationDomain val_16 = Game.Localization.LocalizationDomain.Instance;
            var val_22 = 0;
            val_22 = val_22 + 1;
            this.okText = val_16.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_androidbackbutton_positivebutton", originalString:  "ui_dialog_androidbackbutton_positivebutton");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Devices()
        {
        
        }
    
    }

}
