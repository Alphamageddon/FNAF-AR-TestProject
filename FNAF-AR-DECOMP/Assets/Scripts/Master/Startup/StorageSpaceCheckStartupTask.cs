using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StorageSpaceCheckStartupTask : IStartupTask
    {
        // Fields
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
        public Master.Startup.StorageSpaceCheckStartupTask Setup(Master.EventExposer masterEvents, TheGame.AssetBundleRequirementModule assetBundleRequirementModule)
        {
            this._masterEvents = masterEvents;
            var val_20 = 0;
            val_20 = val_20 + 1;
            .title = Game.Localization.LocalizationDomain.Instance.ILocalLocalization.GetLocalizedString(localizedStringId:  "alert_not_enough_storage_title", originalString:  "Insufficient Storage Space");
            var val_21 = 0;
            val_21 = val_21 + 1;
            .message = Game.Localization.LocalizationDomain.Instance.ILocalLocalization.GetLocalizedString(localizedStringId:  "alert_not_enough_storage_body", originalString:  "You need to have at least 500MB free to continue.");
            var val_22 = 0;
            val_22 = val_22 + 1;
            .neutralButtonText = Game.Localization.LocalizationDomain.Instance.ILocalLocalization.GetLocalizedString(localizedStringId:  "alert_not_enough_storage_retry", originalString:  "Retry");
            .neutralButtonAction = new System.Action(object:  this, method:  System.Void Master.Startup.StorageSpaceCheckStartupTask::OnRetry());
            var val_23 = 0;
            val_23 = val_23 + 1;
            .positiveButtonText = Game.Localization.LocalizationDomain.Instance.ILocalLocalization.GetLocalizedString(localizedStringId:  "alert_not_enough_storage_settings", originalString:  "Settings");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void Master.Startup.StorageSpaceCheckStartupTask::OnClick());
            this._dialog = new GameUI.GenericDialogData();
            this._assetBundleRequirementModule = assetBundleRequirementModule;
            return (Master.Startup.StorageSpaceCheckStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRetry()
        {
            this.RunSpaceAvailableCheck();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnClick()
        {
            this.GoToDeviceSettings();
            this.ShowBlockingDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GoToDeviceSettings()
        {
            var val_22;
            var val_23;
            var val_25;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "android.net.Uri");
            object[] val_6 = new object[3];
            val_6[0] = "package";
            val_6[1] = val_2.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>());
            UnityEngine.AndroidJavaObject val_7 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "fromParts", args:  val_6);
            object[] val_8 = new object[2];
            val_8[0] = "android.settings.APPLICATION_DETAILS_SETTINGS";
            val_8[1] = val_7;
            new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  val_8);
            object[] val_10 = new object[1];
            val_10[0] = "android.intent.category.DEFAULT";
            UnityEngine.AndroidJavaObject val_11 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "addCategory", args:  val_10);
            object[] val_12 = new object[1];
            val_12[0] = 268435456;
            UnityEngine.AndroidJavaObject val_13 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "setFlags", args:  val_12);
            object[] val_14 = new object[1];
            val_14[0] = new UnityEngine.AndroidJavaObject();
            val_2.Call(methodName:  "startActivity", args:  val_14);
            val_22 = 0;
            val_23 = 250;
            if(new UnityEngine.AndroidJavaObject() != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                new UnityEngine.AndroidJavaObject().Dispose();
            }
            
            if((250 == 250) || (val_22 == 0))
            {
                goto label_39;
            }
            
            val_22 = 0;
            val_25 = 0;
            if(val_7 != null)
            {
                goto label_40;
            }
            
            goto label_65;
            label_39:
            val_25 = ;
            if(val_7 == null)
            {
                goto label_65;
            }
            
            label_40:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_7.Dispose();
            label_65:
            if(( != 250) && (val_25 != 0))
            {
                    val_22 = 0;
                val_25 = 0;
            }
            
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                new UnityEngine.AndroidJavaClass().Dispose();
            }
            
            var val_18 = ( == 0) ? 250 : ();
            if((val_18 != 250) && (val_25 != 0))
            {
                    val_22 = 0;
                val_25 = 0;
            }
            
            if(val_2 != null)
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_2.Dispose();
            }
            
            var val_20 = (val_18 == 0) ? 250 : (val_18);
            if((val_20 != 250) && (val_25 != 0))
            {
                    val_22 = 0;
                val_25 = 0;
            }
            
            if(val_1 != null)
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_1.Dispose();
            }
            
            if(val_25 == 0)
            {
                    return;
            }
            
            if(val_20 == 0)
            {
                    return;
            }
            
            if(val_20 == 250)
            {
                    return;
            }
        
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
            return "StorageSpaceCheck";
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
            this.RunSpaceAvailableCheck();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RunSpaceAvailableCheck()
        {
            if((SimpleDiskUtils.DiskUtils.CheckAvailableSpace(isExternalStorage:  true)) <= 499)
            {
                    this.ShowBlockingDialog();
                return;
            }
            
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowBlockingDialog()
        {
            this._masterEvents.GenericDialogRequest(genericDialogData:  this._dialog);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StorageSpaceCheckStartupTask()
        {
        
        }
    
    }

}
