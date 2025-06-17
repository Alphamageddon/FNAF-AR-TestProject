using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_WorkshopModify : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject sellDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject moreInfoDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject genericConfirmDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SellModDisplayHandler sellModDisplayHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert sellAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert moreInfoAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert genericConfirmAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string moreInfoPlushTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string moreInfoCPUTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string moreInfoRemnantTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string moreInfoRemnentMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string moreInfoPlushMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string moreInfoCPUMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CONFIRM_TEXT = "ui_workshop_modify_dialogs_confirm";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CANCEL_TEXT = "ui_workshop_dialogs_cancel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string INVALID_MOD_TITLE_TEXT = "ui_workshop_modify_dialogs_invalidmod_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string INVALID_MOD_MESSAGE_TEXT = "ui_workshop_modify_dialogs_invalidmod_text";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string OK_TEXT = "ui_workshop_modify_dialogs_ok";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MORE_INFO_CPU_HEADER = "ui_workshop_modify_dialog_more_info_cpu_header";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MORE_INFO_PLUSH_HEADER = "ui_workshop_modify_dialog_more_info_plush_header";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MORE_INFO_ESSENCE_HEADER = "ui_workshop_modify_dialog_more_info_remnant_header";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MORE_INFO_CPU_MESSAGE = "ui_workshop_modify_dialog_more_info_cpu_message";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MORE_INFO_PLUSH_MESSAGE = "ui_workshop_modify_dialog_more_info_plush_message";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MORE_INFO_ESSENCE_MESSAGE = "ui_workshop_modify_dialog_more_info_remnant_message";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FetchLocalization()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_WorkshopModify::<FetchLocalization>b__25_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowMoreInfo(string title, string message)
        {
            PaperPlaneTools.Alert val_1 = this.moreInfoAlert.SetTitle(title:  title);
            PaperPlaneTools.Alert val_2 = this.moreInfoAlert.SetMessage(message:  message);
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.moreInfoAlert, backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.DialogHandler_WorkshopModify::<ShowMoreInfo>b__26_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowSellModDialog(GameUI.ModCell modCell, System.Action<GameUI.ModCell> ConfirmSellMod)
        {
            GameUI.ModCell val_8;
            string val_9;
            var val_12;
            val_8 = modCell;
            DialogHandler_WorkshopModify.<>c__DisplayClass27_0 val_1 = new DialogHandler_WorkshopModify.<>c__DisplayClass27_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .modCell = val_8;
            mem[1152921524808220192] = this;
            mem[1152921524808220200] = ConfirmSellMod;
            if(this.sellModDisplayHandler != null)
            {
                goto label_19;
            }
            
            label_20:
            label_19:
            this.sellModDisplayHandler.SetData(modCell:  val_8);
            if(.modCell == null)
            {
                goto label_6;
            }
            
            val_8 = mem[modCell + 176];
            val_8 = modCell.modCellPayload;
            if(modCell.modCellPayload.context == null)
            {
                goto label_6;
            }
            
            val_8 = mem[modCell.modCellPayload.context + 16];
            val_8 = modCell.modCellPayload.context.Mod;
            val_9 = mem[modCell.modCellPayload.context.Mod + 104];
            val_9 = modCell.modCellPayload.context.Mod.ModIconRenderedName;
            if(val_9 != null)
            {
                goto label_8;
            }
            
            label_6:
            val_9 = System.String.alignConst;
            label_8:
            if((System.String.IsNullOrWhiteSpace(value:  val_9)) == false)
            {
                goto label_10;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_14;
            label_10:
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_18;
            label_1:
            mem[16] = this;
            mem[24] = ConfirmSellMod;
            mem[32] = val_8;
            if(this.sellModDisplayHandler != null)
            {
                goto label_19;
            }
            
            goto label_20;
            label_14:
            val_12 = this._iconLookup;
            UnityEngine.Sprite val_4 = val_12.GetDefaultIcon();
            goto label_21;
            label_18:
            val_12 = this._iconLookup;
            label_21:
            this.sellModDisplayHandler.SetSprite(sprite:  val_12.GetIcon(group:  1, name:  val_9));
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void DialogHandler_WorkshopModify.<>c__DisplayClass27_0::<ShowSellModDialog>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowMoreInfoCPUDialog()
        {
            this.ShowMoreInfo(title:  this.moreInfoCPUTitle, message:  this.moreInfoCPUMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowMoreInfoPlushDialog()
        {
            this.ShowMoreInfo(title:  this.moreInfoPlushTitle, message:  this.moreInfoPlushMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowMoreInfoRemnantDialog()
        {
            this.ShowMoreInfo(title:  this.moreInfoRemnantTitle, message:  this.moreInfoRemnentMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowInvalidModCategory()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DialogHandler_WorkshopModify::<ShowInvalidModCategory>b__31_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.sellAlert = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.moreInfoAlert = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.genericConfirmAlert = new PaperPlaneTools.Alert(title:  0, message:  0);
            PaperPlaneTools.Alert val_5 = this.sellAlert.SetAdapter(adaper:  this.sellDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_7 = this.moreInfoAlert.SetAdapter(adaper:  this.moreInfoDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_9 = this.genericConfirmAlert.SetAdapter(adaper:  this.genericConfirmDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            this.FetchLocalization();
            Master.MasterDomain val_10 = Master.MasterDomain.GetDomain();
            val_10.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.DialogHandler_WorkshopModify::IconCacheReady(Game.AssetManagement.Icons.IIconLookup obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup obj)
        {
            this._iconLookup = obj;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this.sellAlert != null)
            {
                    this.sellAlert.Dismiss();
            }
            
            if(this.moreInfoAlert != null)
            {
                    this.moreInfoAlert.Dismiss();
            }
            
            if(this.genericConfirmAlert != null)
            {
                    this.genericConfirmAlert.Dismiss();
            }
            
            this.moreInfoAlert = 0;
            this.genericConfirmAlert = 0;
            this.sellAlert = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_WorkshopModify()
        {
            this.moreInfoPlushTitle = "What is a Plush Suit?";
            this.moreInfoCPUTitle = "What is a CPU?";
            this.moreInfoRemnantTitle = "What is Remnant?";
            this.moreInfoRemnentMessage = "Remnant Description Loading";
            this.moreInfoPlushMessage = "Plush Suit Description Loading";
            this.moreInfoCPUMessage = "CPU Description Loading";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchLocalization>b__25_0(Game.Localization.ILocalization localization)
        {
            var val_13 = 0;
            val_13 = val_13 + 1;
            this.moreInfoRemnantTitle = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialog_more_info_remnant_header", originalString:  this.moreInfoRemnantTitle);
            var val_14 = 0;
            val_14 = val_14 + 1;
            this.moreInfoRemnentMessage = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialog_more_info_remnant_message", originalString:  this.moreInfoRemnentMessage);
            var val_15 = 0;
            val_15 = val_15 + 1;
            this.moreInfoCPUTitle = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialog_more_info_cpu_header", originalString:  this.moreInfoCPUTitle);
            var val_16 = 0;
            val_16 = val_16 + 1;
            this.moreInfoCPUMessage = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialog_more_info_cpu_message", originalString:  this.moreInfoCPUMessage);
            var val_17 = 0;
            val_17 = val_17 + 1;
            this.moreInfoPlushTitle = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialog_more_info_plush_header", originalString:  this.moreInfoPlushTitle);
            var val_18 = 0;
            val_18 = val_18 + 1;
            this.moreInfoPlushMessage = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialog_more_info_plush_message", originalString:  this.moreInfoPlushMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowMoreInfo>b__26_0()
        {
            this.moreInfoAlert.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowInvalidModCategory>b__31_0(Game.Localization.ILocalization localization)
        {
            var val_11 = 0;
            val_11 = val_11 + 1;
            var val_12 = 0;
            val_12 = val_12 + 1;
            var val_13 = 0;
            val_13 = val_13 + 1;
            PaperPlaneTools.Alert val_7 = this.genericConfirmAlert.SetTitle(title:  localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialogs_invalidmod_title", originalString:  "ui_workshop_modify_dialogs_invalidmod_title"));
            PaperPlaneTools.Alert val_8 = this.genericConfirmAlert.SetMessage(message:  localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialogs_invalidmod_text", originalString:  "ui_workshop_modify_dialogs_invalidmod_text"));
            PaperPlaneTools.Alert val_9 = this.genericConfirmAlert.SetPositiveButton(title:  localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialogs_ok", originalString:  "ui_workshop_modify_dialogs_ok"), handler:  0);
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.genericConfirmAlert, backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.DialogHandler_WorkshopModify::<ShowInvalidModCategory>b__31_1()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowInvalidModCategory>b__31_1()
        {
            this.genericConfirmAlert.Dismiss();
        }
    
    }

}
