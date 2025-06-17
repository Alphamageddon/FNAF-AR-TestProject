using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceDisplayDialog : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string HEADER_TEXT = "device_dialog_lure_header";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject LureContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform LureScrollParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI LureText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceCell DeviceCell;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button Button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.DeviceDisplay> _deviceList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.IAlertPlatformAdapter _adapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert _alert;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Reset()
        {
            goto label_1;
            label_7:
            UnityEngine.Object.Destroy(obj:  X21.Item[0].gameObject);
            0 = 1;
            label_1:
            if(0 < this._deviceList.Count)
            {
                goto label_7;
            }
            
            this._deviceList.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Sprite GetLureImage(Game.ItemDefinition.Data.DataDefinitions.DeviceData data)
        {
            string val_12;
            Game.AssetManagement.Icons.IIconLookup val_13;
            var val_15;
            if(data.LureData == null)
            {
                    return 0;
            }
            
            if((System.String.IsNullOrEmpty(value:  data.LureData.AnimatronicLured)) != false)
            {
                    return 0;
            }
            
            if((this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetPlushSuitById(id:  data.LureData.AnimatronicLured)) == null)
            {
                goto label_8;
            }
            
            val_12 = val_3.PortraitIconName;
            if(val_12 != null)
            {
                goto label_9;
            }
            
            label_8:
            val_12 = System.String.alignConst;
            label_9:
            val_13 = this._iconLookup;
            if((System.String.IsNullOrWhiteSpace(value:  val_12)) != false)
            {
                    var val_6 = 0;
                val_15 = 1152921505280790536;
                val_6 = val_6 + 1;
                val_15 = 1152921505280790552;
            }
            else
            {
                    var val_7 = 0;
                val_15 = 1152921505280790536;
                val_7 = val_7 + 1;
                return val_13.GetIcon(group:  3, name:  val_12);
            }
            
            val_12 = ???;
            val_13 = ???;
            return val_13.GetDefaultIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            val_1.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.DeviceDisplayDialog::<Initialize>b__13_0(Game.AssetManagement.Icons.IIconLookup lookup)));
            this._adapter = this.gameObject.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>();
            PaperPlaneTools.Alert val_6 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this._alert = val_6;
            PaperPlaneTools.Alert val_7 = val_6.SetAdapter(adaper:  this._adapter);
            this._deviceList = new System.Collections.Generic.List<GameUI.DeviceDisplay>();
            this.Button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this._alert, method:  public System.Void PaperPlaneTools.Alert::Dismiss()));
            Game.Localization.LocalizationDomain val_11 = Game.Localization.LocalizationDomain.Instance;
            var val_14 = 0;
            val_14 = val_14 + 1;
            this.LureText.text = val_11.ILocalization.GetLocalizedString(localizedStringId:  "device_dialog_lure_header", originalString:  "device_dialog_lure_header");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDataForSingleItem(Game.ItemDefinition.Data.DataDefinitions.DeviceData data, UnityEngine.Sprite icon)
        {
            this.DeviceCell.SetData(data:  data, num:  0, icon:  icon, subicon:  this.GetLureImage(data:  data), onClicked:  0, shouldHaveCancelPanel:  true, onDeactivateClicked:  new System.Action(object:  this, method:  public System.Void GameUI.DeviceDisplayDialog::OnDeactiveRadioJammer()));
            this.DeviceCell.gameObject.SetActive(value:  true);
            this.LureContainer.SetActive(value:  false);
            this.ShowAlert();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDataForMultipleItems(System.Collections.Generic.List<GameUI.DeviceDisplay> displays)
        {
            var val_5;
            this.Reset();
            val_5 = 0;
            goto label_1;
            label_6:
            displays.Item[0].transform.SetParent(parent:  this.LureScrollParent, worldPositionStays:  false);
            val_5 = 1;
            label_1:
            if(val_5 < displays.Count)
            {
                goto label_6;
            }
            
            this.DeviceCell.gameObject.SetActive(value:  false);
            this.LureContainer.SetActive(value:  true);
            this._deviceList = displays;
            this.ShowAlert();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAlert()
        {
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this._alert, backButtonAction:  new System.Action(object:  this._alert, method:  public System.Void PaperPlaneTools.Alert::Dismiss()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DismissAlert()
        {
            this._alert.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Expire(GameUI.DeviceDisplay deviceDisplay)
        {
            if((this._deviceList.Contains(item:  deviceDisplay)) != false)
            {
                    bool val_2 = this._deviceList.Remove(item:  deviceDisplay);
                UnityEngine.Object.Destroy(obj:  deviceDisplay.gameObject);
            }
            
            if(this._deviceList.Count != 0)
            {
                    return;
            }
            
            this._alert.Dismiss();
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
        public void OnDeactiveRadioJammer()
        {
            this.DismissAlert();
            this.ShowConfirmDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowConfirmDialog()
        {
            DeviceDisplayDialog.<>c__DisplayClass21_0 val_1 = new DeviceDisplayDialog.<>c__DisplayClass21_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .deactivateDialogTitle = "ui_devices_deactivate_confirm_title";
                .deactivateDialogMessage = "ui_devices_deactivate_confirm_body";
                .deactivateDialogCancel = "ui_devices_dialogs_cancel";
            }
            else
            {
                    mem[48] = this;
                mem[24] = "ui_devices_deactivate_confirm_title";
                mem[16] = "ui_devices_deactivate_confirm_body";
                mem[32] = "ui_devices_dialogs_cancel";
            }
            
            .deactivateDialogConfirm = "ui_devices_dialogs_confirm";
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void DeviceDisplayDialog.<>c__DisplayClass21_0::<ShowConfirmDialog>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnConfirmDeactiveRadioJammer()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            System.Collections.Generic.List<Game.TheGame.Data.DeviceEntry> val_2 = val_1.devicesDomain.AllPlayerDevices.GetEntriesForType(type:  5);
            if(val_2.Count < 1)
            {
                    return;
            }
            
            Game.TheGame.Data.DeviceEntry val_4 = val_2.Item[0];
            this._masterDomain.serverDomain.deviceRequester.ExpireDevice(activeDeviceId:  val_4.deviceId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceDisplayDialog()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Initialize>b__13_0(Game.AssetManagement.Icons.IIconLookup lookup)
        {
            this._iconLookup = lookup;
        }
    
    }

}
