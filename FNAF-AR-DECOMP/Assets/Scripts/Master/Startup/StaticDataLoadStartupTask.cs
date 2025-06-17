using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StaticDataLoadStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _completeFlags;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain _masterDataDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Animatronic3DDomain _animatronic3DDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.ItemDefinitionDomain _itemDefinitionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.GameAssetManagementDomain _gameAssetManagementDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.AssetBundleRequirementModule _assetBundleRequirementModule;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TotalSize = 85;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int AssetSize = 50;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _progress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _assetProgress;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.StaticDataLoadStartupTask Setup(Master.EventExposer masterEventExposer, Game.MasterData.MasterDataDomain masterDataDomain, Animatronics.Animatronic3d.Animatronic3DDomain animatronic3DDomain, Game.ItemDefinition.ItemDefinitionDomain itemDefinitionDomain, Game.AssetManagement.GameAssetManagementDomain gameAssetManagementDomain, TheGame.AssetBundleRequirementModule assetBundleRequirementModule)
        {
            this._masterEventExposer = masterEventExposer;
            this._masterDataDomain = masterDataDomain;
            this._animatronic3DDomain = animatronic3DDomain;
            this._itemDefinitionDomain = itemDefinitionDomain;
            this._gameAssetManagementDomain = gameAssetManagementDomain;
            this._assetBundleRequirementModule = assetBundleRequirementModule;
            return (Master.Startup.StaticDataLoadStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._animatronic3DDomain = 0;
            this._gameAssetManagementDomain = 0;
            this._masterEventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 85;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "StaticDataLoad";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            int val_2 = UnityEngine.Mathf.RoundToInt(f:  this._assetProgress);
            val_2 = val_2 + (UnityEngine.Mathf.RoundToInt(f:  this._progress));
            return UnityEngine.Mathf.Min(a:  val_2, b:  84);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            this._masterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void Master.Startup.StaticDataLoadStartupTask::OnMasterDataConfigEntryLoaded(ProtoData.CONFIG_DATA.Types.ENTRY e)));
            this._masterDataDomain.GetAccessToData.GetAlertDataAsync(returnAlertDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.ALERT_DATA>(object:  this, method:  System.Void Master.Startup.StaticDataLoadStartupTask::OnMasterDataAlertLoaded(ProtoData.ALERT_DATA e)));
            this._animatronic3DDomain.GetInterfaceAsync(callback:  new System.Action<Animatronics.Animatronic3d.IAnimatronic3DDomain>(object:  this, method:  System.Void Master.Startup.StaticDataLoadStartupTask::OnAnimatronic3DDomainReady(Animatronics.Animatronic3d.IAnimatronic3DDomain e)));
            this._itemDefinitionDomain.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void Master.Startup.StaticDataLoadStartupTask::OnItemDefinitionsDomainReady(Game.ItemDefinition.IItemDefinitionDomain e)));
            this._masterEventExposer.add_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Master.Startup.StaticDataLoadStartupTask::OnGameAssetsReady(int failedAssetCount)));
            this._gameAssetManagementDomain.SetupForStandardAssets();
            this._masterEventExposer.add_AssetBundleDownloadProgressUpdated(value:  new System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData>(object:  this, method:  System.Void Master.Startup.StaticDataLoadStartupTask::AssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData data)
        {
            if(data.Total < 1)
            {
                    return;
            }
            
            float val_1 = (float)data.Complete;
            val_1 = val_1 / (float)data.Total;
            val_1 = val_1 * 50f;
            this._assetProgress = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMasterDataConfigEntryLoaded(ProtoData.CONFIG_DATA.Types.ENTRY e)
        {
            this.CallIfDone(flag:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMasterDataAlertLoaded(ProtoData.ALERT_DATA e)
        {
            this.CallIfDone(flag:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAnimatronic3DDomainReady(Animatronics.Animatronic3d.IAnimatronic3DDomain e)
        {
            this.CallIfDone(flag:  4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnItemDefinitionsDomainReady(Game.ItemDefinition.IItemDefinitionDomain e)
        {
            this.CallIfDone(flag:  8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGameAssetsReady(int failedAssetCount)
        {
            this._masterEventExposer.remove_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Master.Startup.StaticDataLoadStartupTask::OnGameAssetsReady(int failedAssetCount)));
            this._masterEventExposer.remove_AssetBundleDownloadProgressUpdated(value:  new System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData>(object:  this, method:  System.Void Master.Startup.StaticDataLoadStartupTask::AssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData data)));
            this._masterEventExposer.remove_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Master.Startup.StaticDataLoadStartupTask::OnGameAssetsReady(int failedAssetCount)));
            this._progress = 85f;
            this.CallIfDone(flag:  16);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CallIfDone(int flag)
        {
            int val_1 = this._completeFlags;
            val_1 = val_1 | flag;
            this._completeFlags = val_1;
            if(val_1 != 31)
            {
                    return;
            }
            
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StaticDataLoadStartupTask()
        {
            this._progress = 35f;
        }
    
    }

}
