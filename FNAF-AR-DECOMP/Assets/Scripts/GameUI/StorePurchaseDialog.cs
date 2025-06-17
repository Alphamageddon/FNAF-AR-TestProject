using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StorePurchaseDialog : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CANCEL_TEXT = "ui_workshop_dialogs_cancel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _purchaseButtonFazTokensIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _purchaseButtonPartsIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _icon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.IAlertPlatformAdapter _adapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert _alert;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize()
        {
            this._adapter = this.gameObject.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>();
            PaperPlaneTools.Alert val_3 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this._alert = val_3;
            PaperPlaneTools.Alert val_4 = val_3.SetAdapter(adaper:  this._adapter);
            Game.Localization.LocalizationDomain val_5 = Game.Localization.LocalizationDomain.Instance;
            var val_9 = 0;
            val_9 = val_9 + 1;
            PaperPlaneTools.Alert val_8 = this._alert.SetNegativeButton(title:  val_5.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_cancel", originalString:  "ui_workshop_dialogs_cancel"), handler:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(UnityEngine.Sprite icon, Game.Store.Data.StoreDisplayData data, System.Action callback)
        {
            Game.StoreDomain.Data.DataDefinitions.StoreData val_10;
            string val_11;
            this._icon.sprite = icon;
            PaperPlaneTools.Alert val_1 = this._alert.SetTitle(title:  data.storeData.Name);
            Game.Localization.LocalizationDomain val_2 = Game.Localization.LocalizationDomain.Instance;
            val_10 = data.storeData;
            if(val_10 != null)
            {
                    val_11 = data.storeData.Description;
            }
            else
            {
                    val_11 = data.storeData.Description;
                if(data.storeData != null)
            {
                    val_10 = data.storeData;
            }
            else
            {
                    val_10 = 0;
            }
            
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            PaperPlaneTools.Alert val_6 = this._alert.SetMessage(message:  val_2.ILocalization.GetLocalizedString(localizedStringId:  val_11, originalString:  val_10.GenerateDescription()));
            PaperPlaneTools.Alert val_7 = this._alert.SetPositiveButton(title:  data.Price, handler:  callback);
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this._alert, backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.StorePurchaseDialog::<SetData>b__7_0()));
            this._purchaseButtonPartsIcon.SetActive(value:  (data.currency == 1) ? 1 : 0);
            this._purchaseButtonFazTokensIcon.SetActive(value:  (data.currency == 0) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            if(this._alert != null)
            {
                    this._alert.Dismiss();
            }
            
            this._alert = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StorePurchaseDialog()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <SetData>b__7_0()
        {
            this._alert.Dismiss();
        }
    
    }

}
