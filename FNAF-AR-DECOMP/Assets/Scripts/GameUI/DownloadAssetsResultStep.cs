using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DownloadAssetsResultStep : BaseResultStep
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string AdditionalResourcesWarningAcceptedKey = "AdditionalResourcesWarningAccepted";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_DOWNLOAD_TITLE_KEY = "ui_downloadsizewarningdialog_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_DOWNLOAD_BODY_KEY = "ui_downloadsizewarningdialog_body";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_DOWNLOAD_BUTTON_KEY = "ftue_freddy_intro_screen_confirmation";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_DOWNLOAD_CANCEL_KEY = "ui_start_up_cancel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string BODY = "Our game requires additional assets to work. The download size could be up to 500MB, we recommend being connected to Wi-Fi for this initial process.";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string TITLE = "Additional Resources Needed";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string OK = "OK";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CANCEL = "CANCEL";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_NOT_ENOUGH_SPACE_TITLE = "alert_not_enough_storage_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_NOT_ENOUGH_SPACE_BODY = "alert_not_enough_storage_body";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_NOT_ENOUGH_SPACE_NEG_BUTTON_TEXT = "alert_not_enough_storage_retry";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_NOT_ENOUGH_SPACE_POS_BUTTON_TEXT = "alert_not_enough_storage_settings";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string NOT_ENOUGH_TITLE = "Insufficient Storage Space";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string NOT_ENOUGH_BODY = "You need to have at least 500MB free to continue.";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string RETRY = "Retry";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SETTINGS = "Settings";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int SPACE_NEEDED = 500;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TRUE = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AssetManagement.GameAssetManagementDomain _gameAssetManagementDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly TheGame.AssetBundleRequirementModule _assetBundleRequirementModule;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _dialogDownloadAssets;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _dialogNotEnoughSpace;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _complete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _total;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isComplete;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DownloadAssetsResultStep(GameUI.ResultStepConfig config)
        {
            if(config != null)
            {
                    this._masterEventExposer = config.masterEventExposer;
                this._gameAssetManagementDomain = config.gameAssetManagementDomain;
            }
            else
            {
                    this._masterEventExposer = 0;
                this._gameAssetManagementDomain = 62590012;
            }
            
            this._assetBundleRequirementModule = config.assetBundleRequirementModule;
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.DownloadAssetsResultStep::<.ctor>b__27_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RunSpaceAvailableCheck()
        {
            if(((SimpleDiskUtils.DiskUtils.CheckAvailableSpace(isExternalStorage:  true)) <= 499) && (this._assetBundleRequirementModule.ShouldDownloadAssetBundles != false))
            {
                    this.ShowBlockingDialog();
                return;
            }
            
            this.StartDownload();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartDownload()
        {
            this._masterEventExposer.add_AssetBundleDownloadProgressUpdated(value:  new System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData>(object:  this, method:  System.Void GameUI.DownloadAssetsResultStep::AssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData data)));
            this._masterEventExposer.add_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void GameUI.DownloadAssetsResultStep::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
            this._gameAssetManagementDomain.SetupForStandardAssets();
            UnityEngine.PlayerPrefs.SetInt(key:  "AdditionalResourcesWarningAccepted", value:  1);
            this._gameAssetManagementDomain._bundleDownloadConfig.SetSliderPercent(value:  0f);
            this._isComplete.ShowSlider();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowBlockingDialog()
        {
            X20 + 80.SetData(genericDialogData:  this._dialogNotEnoughSpace);
            this._isComplete.ShowDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRetry()
        {
            X20 + 80.HideDialog();
            this.RunSpaceAvailableCheck();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnClick()
        {
            this.GoToDeviceSettings();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnYes()
        {
            X20 + 80.HideDialog();
            this.RunSpaceAvailableCheck();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData data)
        {
            float val_2;
            if(data.Total >= 1)
            {
                    float val_2 = (float)data.Complete;
                val_2 = val_2 / (float)data.Total;
                val_2 = UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  1f);
            }
            else
            {
                    val_2 = 0f;
            }
            
            this._isComplete.SetSliderPercent(value:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)
        {
            this._masterEventExposer.remove_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void GameUI.DownloadAssetsResultStep::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
            this._masterEventExposer.remove_AssetBundleDownloadProgressUpdated(value:  new System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData>(object:  this, method:  System.Void GameUI.DownloadAssetsResultStep::AssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData data)));
            this._masterEventExposer.EntityMovedEvent.SetSliderPercent(value:  1f);
            this._isComplete = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowDownloadAssets()
        {
            X20 + 80.SetData(genericDialogData:  this._dialogDownloadAssets);
            this._isComplete.ShowDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GoToDeviceSettings()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.add_SettingsURLFoundEvent(value:  new IxQuerier_iOS.URLFound(object:  this, method:  System.Void GameUI.DownloadAssetsResultStep::OnSettingsURLFound(string settingsURL)));
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.QueryGoToSettingsURL();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSettingsURLFound(string settingsURL)
        {
            UnityEngine.Application.OpenURL(url:  settingsURL);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool IsComplete()
        {
            var val_2;
            if(this._isComplete != false)
            {
                    X20 + 80.HideDialog();
                X20 + 80 + 80.HideSlider();
                var val_1 = (this._isComplete == true) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void StartStep()
        {
            this._isComplete = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <.ctor>b__27_0(Game.Localization.ILocalization localization)
        {
            var val_20 = 0;
            val_20 = val_20 + 1;
            .title = localization.GetLocalizedString(localizedStringId:  "ui_downloadsizewarningdialog_title", originalString:  "Additional Resources Needed");
            var val_21 = 0;
            val_21 = val_21 + 1;
            .message = localization.GetLocalizedString(localizedStringId:  "ui_downloadsizewarningdialog_body", originalString:  "Our game requires additional assets to work. The download size could be up to 500MB, we recommend being connected to Wi-Fi for this initial process.");
            var val_22 = 0;
            val_22 = val_22 + 1;
            .positiveButtonText = localization.GetLocalizedString(localizedStringId:  "ftue_freddy_intro_screen_confirmation", originalString:  "OK");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void GameUI.DownloadAssetsResultStep::OnYes());
            this._dialogDownloadAssets = new GameUI.GenericDialogData();
            var val_23 = 0;
            val_23 = val_23 + 1;
            .title = localization.GetLocalizedString(localizedStringId:  "alert_not_enough_storage_title", originalString:  "Insufficient Storage Space");
            var val_24 = 0;
            val_24 = val_24 + 1;
            .message = localization.GetLocalizedString(localizedStringId:  "alert_not_enough_storage_body", originalString:  "You need to have at least 500MB free to continue.");
            var val_25 = 0;
            val_25 = val_25 + 1;
            .negativeButtonText = localization.GetLocalizedString(localizedStringId:  "alert_not_enough_storage_retry", originalString:  "Retry");
            .negativeButtonAction = new System.Action(object:  this, method:  System.Void GameUI.DownloadAssetsResultStep::OnRetry());
            var val_26 = 0;
            val_26 = val_26 + 1;
            .positiveButtonText = localization.GetLocalizedString(localizedStringId:  "alert_not_enough_storage_settings", originalString:  "Settings");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void GameUI.DownloadAssetsResultStep::OnClick());
            this._dialogNotEnoughSpace = new GameUI.GenericDialogData();
        }
    
    }

}
