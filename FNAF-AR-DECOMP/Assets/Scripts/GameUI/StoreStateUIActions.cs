using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreStateUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string PURCHASE_ERROR = "ui_store_transactionnotcompleted_message";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ERROR_TITLE = "ui_generic_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Store dialogHandler_Store;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InGamePurchaseRequest(GameUI.StoreCell cell)
        {
            bool val_1 = this._masterDomain.StoreDomain.CanAfford(data:  cell._storeCellData.displayData);
            if(this._masterDomain.eventExposer == null)
            {
                goto label_5;
            }
            
            if(val_1 == false)
            {
                goto label_6;
            }
            
            label_13:
            this._masterDomain.eventExposer.OnPurchaseRequestAudioInvoked(canAfford:  true);
            this._masterDomain.StoreDomain.InitiatePurchase(data:  cell._storeCellData.displayData);
            if(cell._storeCellData.displayData.storeData.Repeatable == false)
            {
                goto label_12;
            }
            
            return;
            label_5:
            if(val_1 == true)
            {
                goto label_13;
            }
            
            label_6:
            this._masterDomain.eventExposer.OnPurchaseRequestAudioInvoked(canAfford:  false);
            if(cell._storeCellData.displayData.currency == 0)
            {
                goto label_15;
            }
            
            this.ShowEarnPartsDialog();
            return;
            label_12:
            cell.Disable();
            return;
            label_15:
            this._masterDomain.eventExposer.OnBuyMoreCoinsDialogRequest();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowEarnPartsDialog()
        {
            StoreStateUIActions.<>c__DisplayClass5_0 val_1 = new StoreStateUIActions.<>c__DisplayClass5_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .errorMsg = "ui_store_notenough_parts";
            }
            else
            {
                    mem[32] = this;
                mem[16] = "ui_store_notenough_parts";
            }
            
            .errorTitleKey = "ui_store_notenough_parts_title";
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void StoreStateUIActions.<>c__DisplayClass5_0::<ShowEarnPartsDialog>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowPurchaseDialog(GameUI.StoreCell cell)
        {
            this.dialogHandler_Store.ShowPurchaseDialog(cell:  cell);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPurchaseError(string error)
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.StoreStateUIActions::<OnPurchaseError>b__9_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreStateUIActions()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <OnPurchaseError>b__9_0(Game.Localization.ILocalization localization)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.dialogHandler_Store.ShowErrorDialog(title:  localization.GetLocalizedString(localizedStringId:  "ui_generic_title", originalString:  "ui_generic_title"), error:  localization.GetLocalizedString(localizedStringId:  "ui_store_transactionnotcompleted_message", originalString:  "ui_store_transactionnotcompleted_message"));
        }
    
    }

}
