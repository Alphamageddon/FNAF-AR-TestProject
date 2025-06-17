using UnityEngine;

namespace Game.SeasonalAssets
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalAssetDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalAssets.SeasonalAssetManifest _manifest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalAssets.SeasonalAssetPopulator _populator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalAssets.SeasonalAssetLoader _loader;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.SeasonalAssets.SeasonalAssetLoader Loader { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.SeasonalAssets.SeasonalAssetLoader get_Loader()
        {
            return (Game.SeasonalAssets.SeasonalAssetLoader)this._loader;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalAssetDomain(Game.MasterData.GetAccessToData getAccessToData, Master.EventExposer eventExposer)
        {
            val_1 = new System.Object();
            this._manifest = new Game.SeasonalAssets.SeasonalAssetManifest(getAccessToData:  getAccessToData, eventExposer:  Master.EventExposer val_1 = eventExposer);
            this._populator = new Game.SeasonalAssets.SeasonalAssetPopulator();
            this._loader = new Game.SeasonalAssets.SeasonalAssetLoader();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer, Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache> assetCacheAccess)
        {
            this._populator.Setup(manifest:  this._manifest, eventExposer:  eventExposer);
            this._loader.Setup(manifest:  this._manifest, assetCacheAccess:  assetCacheAccess);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._manifest.Teardown();
            this._manifest = 0;
            this._populator.Teardown();
            this._populator = 0;
            this._loader.Teardown();
            this._loader = 0;
        }
    
    }

}
