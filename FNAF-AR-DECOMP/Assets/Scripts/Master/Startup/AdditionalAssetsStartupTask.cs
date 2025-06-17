using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AdditionalAssetsStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string AdditionalResourcesWarningAcceptedKey = "AdditionalResourcesWarningAccepted";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_DOWNLOAD_TITLE_KEY = "ui_downloadsizewarningdialog_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_DOWNLOAD_BODY_KEY = "ui_downloadsizewarningdialog_body";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_DOWNLOAD_BUTTON_KEY = "ftue_freddy_intro_screen_confirmation";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_DOWNLOAD_CANCEL_KEY = "ui_start_up_cancel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float DELAY_BETWEEN_POPUPS = 0.6;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _dialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.AssetBundleRequirementModule _assetBundleRequirementModule;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.AdditionalAssetsStartupTask Setup(Master.EventExposer masterEvents, Game.Localization.ILocalization localLocalizer, TheGame.AssetBundleRequirementModule assetBundleRequirementModule)
        {
            this._masterEvents = masterEvents;
            var val_9 = 0;
            val_9 = val_9 + 1;
            .title = localLocalizer.GetLocalizedString(localizedStringId:  "ui_downloadsizewarningdialog_title", originalString:  "Additional Resources Needed");
            var val_10 = 0;
            val_10 = val_10 + 1;
            .message = localLocalizer.GetLocalizedString(localizedStringId:  "ui_downloadsizewarningdialog_body", originalString:  "Our game requires additional assets to work. The download size could be up to 500MB, we recommend being connected to Wi-Fi for this initial process.");
            var val_11 = 0;
            val_11 = val_11 + 1;
            .positiveButtonText = localLocalizer.GetLocalizedString(localizedStringId:  "ftue_freddy_intro_screen_confirmation", originalString:  "OK");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void Master.Startup.AdditionalAssetsStartupTask::OnYes());
            this._dialog = new GameUI.GenericDialogData();
            this._assetBundleRequirementModule = assetBundleRequirementModule;
            return (Master.Startup.AdditionalAssetsStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._parent = 0;
            this._dialog = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "AdditionalAssets";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            if(this.ShouldShow() != false)
            {
                    this._masterEvents.GenericDialogRequest(genericDialogData:  this._dialog);
                return;
            }
            
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldShow()
        {
            return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "AdditionalResourcesWarningAccepted", defaultValue:  0)) != 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnYes()
        {
            UnityEngine.PlayerPrefs.SetInt(key:  "AdditionalResourcesWarningAccepted", value:  1);
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AdditionalAssetsStartupTask()
        {
        
        }
    
    }

}
