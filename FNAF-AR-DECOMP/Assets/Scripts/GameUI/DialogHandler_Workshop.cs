using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Workshop : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopStateUIActions workshopStateUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject sendSelectDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject deploySelectionDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _errorDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StorePurchaseDialog purchaseDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions itemDefinitions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Store.StoreDomain _storeDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert sendSelectAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert deploySelectionAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert _errorDialogAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CANCEL_TEXT = "ui_workshop_dialogs_cancel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CONFIRM_TEXT = "ui_workshop_dialogs_confirm";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SELECT_TEXT = "ui_workshop_dialogs_select";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string OK_TEXT = "ui_workshop_dialogs_ok";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SEND_TEXT = "ui_workshop_dialogs_send";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SCAVENGE_TEXT = "ui_workshop_dialogs_salvage";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string REPAIR_TITLE_TEXT = "ui_workshop_dialogs_repair_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string REPAIR_PREFIX_TEXT = "ui_workshop_dialogs_repair_prefix";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string REPAIR_POSTFIX_TEXT = "ui_workshop_dialogs_repair_postfix";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GEN_ERROR_TITLE = "ui_generic_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GEN_ERROR_BUTTON_TEXT = "ui_generic_error_dialog_button_text";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string REPAIR_ERROR_TITLE = "ui_workshop_repair_not_enough_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string REPAIR_ERROR_TEXT = "ui_workshop_repair_not_enough_text";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowPurchaseDialog(Game.Store.Data.StoreDisplayData data)
        {
            DialogHandler_Workshop.<>c__DisplayClass25_0 val_1 = new DialogHandler_Workshop.<>c__DisplayClass25_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .data = data;
            mem[1152921524804952144] = this;
            if(data != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            this.purchaseDialog.SetData(icon:  this._storeDomain.GetStoreIcon(iconName:  data.storeData.DialogArtRef), data:  .data, callback:  new System.Action(object:  val_1, method:  System.Void DialogHandler_Workshop.<>c__DisplayClass25_0::<ShowPurchaseDialog>b__0()));
            return;
            label_1:
            mem[16] = this;
            mem[24] = data;
            if(mem[24] != 0)
            {
                goto label_7;
            }
            
            goto label_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowErrorDialog(string error)
        {
            DialogHandler_Workshop.<>c__DisplayClass26_0 val_1 = new DialogHandler_Workshop.<>c__DisplayClass26_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .error = error;
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void DialogHandler_Workshop.<>c__DisplayClass26_0::<ShowErrorDialog>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRepairError()
        {
            DialogHandler_Workshop.<>c__DisplayClass27_0 val_1 = new DialogHandler_Workshop.<>c__DisplayClass27_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .errorTextKey = "ui_workshop_repair_not_enough_text";
            }
            else
            {
                    mem[32] = this;
                mem[16] = "ui_workshop_repair_not_enough_text";
            }
            
            .errorTitleKey = "ui_workshop_repair_not_enough_title";
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void DialogHandler_Workshop.<>c__DisplayClass27_0::<ShowRepairError>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRepairConfirm()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Workshop::<ShowRepairConfirm>b__28_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowDeploySelectionDialog(string displayName)
        {
            PaperPlaneTools.Alert val_1 = this.deploySelectionAlert.SetTitle(title:  displayName);
            this.deploySelectionAlert.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DismissSendSelect()
        {
            this.sendSelectAlert.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowSendSelect()
        {
            this.sendSelectAlert.Show();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            if(val_1 != null)
            {
                    this.masterEvents = val_1.eventExposer;
            }
            else
            {
                    this.masterEvents = 456;
            }
            
            GameUI.Domain val_2 = val_1.gameUIDomain;
            this.workshopSlotDataModel = 456;
            this.itemDefinitions = val_1.ItemDefinitionDomain.ItemDefinitions;
            this._storeDomain = val_1.StoreDomain;
            this.purchaseDialog.Initialize();
            this.sendSelectAlert = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.deploySelectionAlert = new PaperPlaneTools.Alert(title:  0, message:  0);
            this._errorDialogAlert = new PaperPlaneTools.Alert(title:  0, message:  0);
            PaperPlaneTools.Alert val_8 = this.sendSelectAlert.SetAdapter(adaper:  this.sendSelectDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_9 = this.sendSelectAlert.SetNegativeButton(title:  0, handler:  0);
            PaperPlaneTools.Alert val_11 = this.deploySelectionAlert.SetAdapter(adaper:  this.deploySelectionDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_12 = this.deploySelectionAlert.SetNegativeButton(title:  0, handler:  0);
            PaperPlaneTools.Alert val_14 = this._errorDialogAlert.SetAdapter(adaper:  this._errorDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_Workshop::<Start>b__32_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this.sendSelectAlert != null)
            {
                    this.sendSelectAlert.Dismiss();
            }
            
            if(this.deploySelectionAlert != null)
            {
                    this.deploySelectionAlert.Dismiss();
            }
            
            this.sendSelectAlert = 0;
            this.deploySelectionAlert = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Workshop()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowRepairConfirm>b__28_0(Game.Localization.ILocalization localization)
        {
            var val_18 = 0;
            val_18 = val_18 + 1;
            var val_19 = 0;
            val_19 = val_19 + 1;
            var val_20 = 0;
            val_20 = val_20 + 1;
            string val_6 = localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_repair_title", originalString:  "ui_workshop_dialogs_repair_title");
            var val_21 = 0;
            val_21 = val_21 + 1;
            var val_22 = 0;
            val_22 = val_22 + 1;
            AnimatronicEntity.Data.WorkshopEntry val_12 = this.workshopSlotDataModel.GetSelectedSlotData().ServerEntry;
            Game.ItemDefinition.Data.DataDefinitions.WearAndTearData val_13 = this.itemDefinitions.GetWearAndTearData(index:  val_12.health);
            string val_15 = localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_repair_prefix", originalString:  "ui_workshop_dialogs_repair_prefix")(localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_repair_prefix", originalString:  "ui_workshop_dialogs_repair_prefix")) + val_13.RepairParts.ToString() + localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_repair_postfix", originalString:  "ui_workshop_dialogs_repair_postfix")(localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_repair_postfix", originalString:  "ui_workshop_dialogs_repair_postfix"));
            GameUI.GenericDialogData val_16 = new GameUI.GenericDialogData();
            if(val_16 != null)
            {
                    .title = val_6;
                .message = val_15;
            }
            else
            {
                    mem[16] = val_6;
                mem[24] = val_15;
            }
            
            .positiveButtonText = localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_confirm", originalString:  "ui_workshop_dialogs_confirm");
            System.Action val_17 = new System.Action(object:  this.workshopStateUIActions, method:  public System.Void GameUI.WorkshopStateUIActions::PurchaseRepair());
            if(val_16 != null)
            {
                    .positiveButtonAction = val_17;
            }
            else
            {
                    mem[40] = val_17;
            }
            
            .negativeButtonText = localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_cancel", originalString:  "ui_workshop_dialogs_cancel");
            this.masterEvents.GenericDialogRequest(genericDialogData:  val_16);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Start>b__32_0(Game.Localization.ILocalization localization)
        {
            var val_17 = 0;
            val_17 = val_17 + 1;
            string val_2 = localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_ok", originalString:  "ui_workshop_dialogs_ok");
            var val_18 = 0;
            val_18 = val_18 + 1;
            string val_4 = localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_cancel", originalString:  "ui_workshop_dialogs_cancel");
            var val_19 = 0;
            val_19 = val_19 + 1;
            string val_6 = localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_confirm", originalString:  "ui_workshop_dialogs_confirm");
            var val_20 = 0;
            val_20 = val_20 + 1;
            string val_8 = localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_select", originalString:  "ui_workshop_dialogs_select");
            var val_21 = 0;
            val_21 = val_21 + 1;
            var val_22 = 0;
            val_22 = val_22 + 1;
            PaperPlaneTools.Alert val_14 = this.deploySelectionAlert.SetPositiveButton(title:  localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_send", originalString:  "ui_workshop_dialogs_send"), handler:  new System.Action(object:  this.workshopStateUIActions, method:  public System.Void GameUI.WorkshopStateUIActions::ShowSendSelectDialog()));
            PaperPlaneTools.Alert val_16 = this.deploySelectionAlert.SetNeutralButton(title:  localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_salvage", originalString:  "ui_workshop_dialogs_salvage"), handler:  new System.Action(object:  this.workshopStateUIActions, method:  public System.Void GameUI.WorkshopStateUIActions::ShowScavengeDialog()));
        }
    
    }

}
