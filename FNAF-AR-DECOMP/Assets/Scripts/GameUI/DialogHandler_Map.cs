using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Map : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DELIVERY_TITLE = "ui_map_dialog_expressdelivery_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DELIVERY_BODY = "ui_map_dialog_expressdelivery_msg";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CANCEL = "ui_settings_dialog_help_cancel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ERROR_TITLE = "ui_generic_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ERRROR_CANTAFFORD = "ui_store_notenough_fazcoins";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ERROR_TOOFAR = "ui_map_dialog_expressdelivery_toofar";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ERROR_GENERIC = "ui_dialog_generic_error";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string OK = "ui_generic_ok";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _expressDeliveryTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _expressDeliveryBody;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _cancelString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _errorTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _cantAffordMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _tooFarMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _genericError;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _okString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.MapStateUIActions mapStateUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject expressDeliveryDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject sequentialRewardsDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert expressDeliveryAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert sequentialRewardsAlert;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowGenericError()
        {
            PaperPlaneTools.Alert val_1 = this.expressDeliveryAlert.SetTitle(title:  this._errorTitle);
            PaperPlaneTools.Alert val_2 = this.expressDeliveryAlert.SetMessage(message:  this._genericError);
            PaperPlaneTools.Alert val_3 = this.expressDeliveryAlert.SetNegativeButton(title:  this._okString, handler:  0);
            this.expressDeliveryAlert.ClearPositiveButton();
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.expressDeliveryAlert, backButtonAction:  new System.Action(object:  this.expressDeliveryAlert, method:  public System.Void PaperPlaneTools.Alert::Dismiss()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowTooFarError()
        {
            PaperPlaneTools.Alert val_1 = this.expressDeliveryAlert.SetTitle(title:  this._errorTitle);
            PaperPlaneTools.Alert val_2 = this.expressDeliveryAlert.SetMessage(message:  this._tooFarMessage);
            PaperPlaneTools.Alert val_3 = this.expressDeliveryAlert.SetNegativeButton(title:  this._okString, handler:  0);
            this.expressDeliveryAlert.ClearPositiveButton();
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.expressDeliveryAlert, backButtonAction:  new System.Action(object:  this.expressDeliveryAlert, method:  public System.Void PaperPlaneTools.Alert::Dismiss()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowSequentialRewardsDialog(string title, string message, string buttonText)
        {
            PaperPlaneTools.Alert val_1 = this.sequentialRewardsAlert.SetTitle(title:  title);
            PaperPlaneTools.Alert val_2 = this.sequentialRewardsAlert.SetMessage(message:  message);
            PaperPlaneTools.Alert val_3 = this.sequentialRewardsAlert.SetPositiveButton(title:  buttonText, handler:  0);
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.sequentialRewardsAlert, backButtonAction:  new System.Action(object:  this.sequentialRewardsAlert, method:  public System.Void PaperPlaneTools.Alert::Dismiss()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowCantAffordError()
        {
            PaperPlaneTools.Alert val_1 = this.expressDeliveryAlert.SetTitle(title:  this._errorTitle);
            PaperPlaneTools.Alert val_2 = this.expressDeliveryAlert.SetMessage(message:  this._cantAffordMessage);
            PaperPlaneTools.Alert val_3 = this.expressDeliveryAlert.SetNegativeButton(title:  this._okString, handler:  0);
            this.expressDeliveryAlert.ClearPositiveButton();
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.expressDeliveryAlert, backButtonAction:  new System.Action(object:  this.expressDeliveryAlert, method:  public System.Void PaperPlaneTools.Alert::Dismiss()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowExpressDelivery(MapMode.GeoPositionObject.MapAnimatronic animatronic, int cost)
        {
            DialogHandler_Map.<>c__DisplayClass25_0 val_1 = new DialogHandler_Map.<>c__DisplayClass25_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .animatronic = animatronic;
            PaperPlaneTools.Alert val_2 = this.expressDeliveryAlert.SetTitle(title:  this._expressDeliveryTitle);
            PaperPlaneTools.Alert val_3 = this.expressDeliveryAlert.SetMessage(message:  this._expressDeliveryBody);
            PaperPlaneTools.Alert val_4 = this.expressDeliveryAlert.SetNegativeButton(title:  this._cancelString, handler:  0);
            PaperPlaneTools.Alert val_7 = this.expressDeliveryAlert.SetPositiveButton(title:  cost.ToString(), handler:  new System.Action(object:  val_1, method:  System.Void DialogHandler_Map.<>c__DisplayClass25_0::<ShowExpressDelivery>b__0()));
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.expressDeliveryAlert, backButtonAction:  new System.Action(object:  this.expressDeliveryAlert, method:  public System.Void PaperPlaneTools.Alert::Dismiss()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            PaperPlaneTools.Alert val_1 = new PaperPlaneTools.Alert(title:  "", message:  "");
            this.expressDeliveryAlert = val_1;
            PaperPlaneTools.Alert val_3 = val_1.SetAdapter(adaper:  this.expressDeliveryDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_4 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.sequentialRewardsAlert = val_4;
            PaperPlaneTools.Alert val_6 = val_4.SetAdapter(adaper:  this.sequentialRewardsDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            this.GetLocStrings();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetLocStrings()
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_18 = 0;
            val_18 = val_18 + 1;
            this._expressDeliveryTitle = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_map_dialog_expressdelivery_title", originalString:  "ui_map_dialog_expressdelivery_title");
            var val_19 = 0;
            val_19 = val_19 + 1;
            this._expressDeliveryBody = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_map_dialog_expressdelivery_msg", originalString:  "ui_map_dialog_expressdelivery_msg");
            var val_20 = 0;
            val_20 = val_20 + 1;
            this._cancelString = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_settings_dialog_help_cancel", originalString:  "ui_settings_dialog_help_cancel");
            var val_21 = 0;
            val_21 = val_21 + 1;
            this._errorTitle = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_generic_title", originalString:  "ui_generic_title");
            var val_22 = 0;
            val_22 = val_22 + 1;
            this._cantAffordMessage = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_store_notenough_fazcoins", originalString:  "ui_store_notenough_fazcoins");
            var val_23 = 0;
            val_23 = val_23 + 1;
            this._tooFarMessage = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_map_dialog_expressdelivery_toofar", originalString:  "ui_map_dialog_expressdelivery_toofar");
            var val_24 = 0;
            val_24 = val_24 + 1;
            this._genericError = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_generic_error", originalString:  "ui_dialog_generic_error");
            var val_25 = 0;
            val_25 = val_25 + 1;
            this._okString = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_generic_ok", originalString:  "ui_generic_ok");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this.expressDeliveryAlert != null)
            {
                    this.expressDeliveryAlert.Dismiss();
            }
            
            this.expressDeliveryAlert = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Map()
        {
        
        }
    
    }

}
