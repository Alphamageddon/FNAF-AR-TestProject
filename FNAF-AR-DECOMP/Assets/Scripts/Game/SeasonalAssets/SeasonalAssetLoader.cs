using UnityEngine;

namespace Game.SeasonalAssets
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalAssetLoader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetLoader.LoaderInstance> _activeLoaders;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetLoader.LoaderInstance> _queuedLoaders;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalAssets.SeasonalAssetManifest _manifest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.SeasonalAssets.SeasonalAssetManifest manifest, Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache> assetCacheAccess)
        {
            this._activeLoaders = new System.Collections.Generic.List<LoaderInstance>();
            this._queuedLoaders = new System.Collections.Generic.List<LoaderInstance>();
            this._manifest = manifest;
            this._assetCache = 0;
            assetCacheAccess.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Assets.IAssetCache>(object:  this, method:  System.Void Game.SeasonalAssets.SeasonalAssetLoader::AssetCacheReady(Systems.AssetManagement.Assets.IAssetCache assetCache)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._manifest = 0;
            this._assetCache = 0;
            this._activeLoaders.Clear();
            this._activeLoaders = 0;
            this._queuedLoaders.Clear();
            this._queuedLoaders = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryLoadRequiredAssets(System.Action onComplete)
        {
            var val_6;
            var val_14;
            var val_15;
            var val_16;
            Game.SeasonalAssets.SeasonalAssetLoader val_17;
            System.Collections.Generic.List<Entry> val_1 = new System.Collections.Generic.List<Entry>();
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = this._manifest.AssetEntriesByKey.Values.GetEnumerator();
            val_14 = 0;
            label_14:
            if(((-854391360) & 1) == 0)
            {
                goto label_4;
            }
            
            List.Enumerator<T> val_8 = val_6.emailUIDataHandler.GetEnumerator();
            label_8:
            if(((-854391392) & 1) == 0)
            {
                goto label_6;
            }
            
            val_1.Add(item:  val_6.emailUIDataHandler);
            goto label_8;
            label_6:
            val_15 = val_14;
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525227292064});
            if((((85 == 0) ? 85 : 85) == 85) || ( == 0))
            {
                goto label_14;
            }
            
            goto label_14;
            label_4:
            val_16 = 110;
            val_17 = this;
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525227292096});
            if(val_1.Count >= 1)
            {
                    this.LoadEntriesAsync(entries:  val_1, onComplete:  onComplete);
                return;
            }
            
            val_17 = onComplete;
            val_17.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetCacheReady(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            var val_3;
            this._assetCache = assetCache;
            val_3 = 0;
            goto label_1;
            label_6:
            LoaderInstance val_1 = assetCache.Item[0];
            val_1.LoadAsync(assetCache:  this._assetCache);
            this._activeLoaders.Add(item:  val_1);
            val_3 = 1;
            label_1:
            if(val_3 < this._queuedLoaders.Count)
            {
                goto label_6;
            }
            
            this._queuedLoaders.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadEntriesAsync(System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetManifest.Entry> entries, System.Action onComplete)
        {
            System.Collections.Generic.List<LoaderInstance> val_5;
            .<>4__this = this;
            if(entries.Count == 0)
            {
                goto label_3;
            }
            
            SeasonalAssetLoader.LoaderInstance val_3 = new SeasonalAssetLoader.LoaderInstance();
            ._entries = entries;
            ._remaining = 0;
            .loader = val_3;
            val_3.add__onCompletion(value:  onComplete);
            (SeasonalAssetLoader.<>c__DisplayClass9_0)[1152921525227695392].loader.add__onCompletion(value:  new System.Action(object:  new SeasonalAssetLoader.<>c__DisplayClass9_0(), method:  System.Void SeasonalAssetLoader.<>c__DisplayClass9_0::<LoadEntriesAsync>b__0()));
            if(this._assetCache == null)
            {
                goto label_6;
            }
            
            (SeasonalAssetLoader.<>c__DisplayClass9_0)[1152921525227695392].loader.LoadAsync(assetCache:  this._assetCache);
            val_5 = this._activeLoaders;
            goto label_8;
            label_3:
            onComplete.Invoke();
            return;
            label_6:
            val_5 = this._queuedLoaders;
            label_8:
            val_5.Add(item:  (SeasonalAssetLoader.<>c__DisplayClass9_0)[1152921525227695392].loader);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalAssetLoader()
        {
        
        }
    
    }

}
