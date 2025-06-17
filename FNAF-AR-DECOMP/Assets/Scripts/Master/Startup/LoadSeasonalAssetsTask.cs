using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LoadSeasonalAssetsTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MAP_FX_DATA_KEY = "MapFx";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STORE_FX_DATA_KEY = "StoreFx";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string PLAYER_ICON_FX_DATA_KEY = "PlayerIconFx";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalAssets.SeasonalAssetLoader _seasonalAssetLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.AssetBundleRequirementModule _assetBundleRequirementModule;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.LoadSeasonalAssetsTask Setup(Game.SeasonalAssets.SeasonalAssetLoader seasonalAssetLoader, TheGame.AssetBundleRequirementModule assetBundleRequirementModule)
        {
            this._seasonalAssetLoader = seasonalAssetLoader;
            this._assetBundleRequirementModule = assetBundleRequirementModule;
            return (Master.Startup.LoadSeasonalAssetsTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            LoadSeasonalAssetsTask.<>c__DisplayClass6_0 val_1 = new LoadSeasonalAssetsTask.<>c__DisplayClass6_0();
            .parent = parent;
            if(this._assetBundleRequirementModule.ShouldDownloadAssetBundles == false)
            {
                goto label_3;
            }
            
            LoadSeasonalAssetsTask.<>c__DisplayClass6_1 val_3 = new LoadSeasonalAssetsTask.<>c__DisplayClass6_1();
            if(val_3 == null)
            {
                goto label_4;
            }
            
            .CS$<>8__locals1 = val_1;
            goto label_5;
            label_3:
            (LoadSeasonalAssetsTask.<>c__DisplayClass6_0)[1152921523301846512].parent.CompleteTask(task:  this);
            return;
            label_4:
            mem[24] = val_1;
            label_5:
            .task = this;
            this._seasonalAssetLoader.TryLoadRequiredAssets(onComplete:  new System.Action(object:  val_3, method:  System.Void LoadSeasonalAssetsTask.<>c__DisplayClass6_1::<Execute>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._seasonalAssetLoader = 0;
            this._assetBundleRequirementModule = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "LoadSeasonalMapAssets";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoadSeasonalAssetsTask()
        {
        
        }
    
    }

}
