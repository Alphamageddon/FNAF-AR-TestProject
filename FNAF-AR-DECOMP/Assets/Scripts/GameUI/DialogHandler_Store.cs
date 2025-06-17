using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Store : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string OK_BUTTON = "ui_generic_ok";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreStateUIActions storeStateUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StorePurchaseDialog _purchaseDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _errorDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert _errorDialogAlert;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowPurchaseDialog(GameUI.StoreCell cell)
        {
            GameUI.StoreCell val_6 = cell;
            DialogHandler_Store.<>c__DisplayClass6_0 val_1 = new DialogHandler_Store.<>c__DisplayClass6_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .cell = val_6;
            if(this._masterDomain == null)
            {
                    val_6 = (DialogHandler_Store.<>c__DisplayClass6_0)[1152921524804008736].cell;
            }
            
            Game.Store.Data.StoreDisplayData val_2 = val_6.Data;
            this._purchaseDialog.SetData(icon:  this._masterDomain.StoreDomain.GetStoreIcon(iconName:  val_2.storeData.DialogArtRef), data:  (DialogHandler_Store.<>c__DisplayClass6_0)[1152921524804008736].cell.Data, callback:  new System.Action(object:  val_1, method:  System.Void DialogHandler_Store.<>c__DisplayClass6_0::<ShowPurchaseDialog>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowErrorDialog(string title, string error)
        {
            PaperPlaneTools.Alert val_1 = this._errorDialogAlert.SetTitle(title:  title);
            PaperPlaneTools.Alert val_2 = this._errorDialogAlert.SetMessage(message:  error);
            Game.Localization.LocalizationDomain val_3 = Game.Localization.LocalizationDomain.Instance;
            var val_8 = 0;
            val_8 = val_8 + 1;
            PaperPlaneTools.Alert val_6 = this._errorDialogAlert.SetNeutralButton(title:  val_3.ILocalization.GetLocalizedString(localizedStringId:  "ui_generic_ok", originalString:  "ui_generic_ok"), handler:  0);
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this._errorDialogAlert, backButtonAction:  new System.Action(object:  this._errorDialogAlert, method:  public System.Void PaperPlaneTools.Alert::Dismiss()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            this._purchaseDialog.Initialize();
            PaperPlaneTools.Alert val_2 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this._errorDialogAlert = val_2;
            PaperPlaneTools.Alert val_4 = val_2.SetAdapter(adaper:  this._errorDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Store()
        {
        
        }
    
    }

}
