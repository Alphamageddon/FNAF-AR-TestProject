using UnityEngine;

namespace Game.AssetManagement.Icons
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IconLookup : AsyncInterfaceAccess<Game.AssetManagement.Icons.IIconLookup>, IIconLookup
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DefaultIconResourcesPath = "Icons/alpine_ui_icon_default";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain _masterDataDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.IBundleCache _bundleCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Sprite _defaultIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, string> _bundleNames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, Game.AssetManagement.Icons.IconGroupData> _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IconLoader _iconLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _storeSkinOverride;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AssetManagement.Icons.IIconLookup GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            return (bool)(this._iconLoader == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AssetManagement.Icons.IIconLookup get_GetPublicInterface()
        {
            return (Game.AssetManagement.Icons.IIconLookup)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite GetDefaultIcon()
        {
            return (UnityEngine.Sprite)this._defaultIcon;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite GetIcon(Game.AssetManagement.Icons.IconGroup group, string name)
        {
            Game.AssetManagement.Icons.IconGroup val_6;
            UnityEngine.Object val_7;
            val_6 = group;
            if(((System.String.IsNullOrWhiteSpace(value:  name)) != true) && (this._iconLookup != null))
            {
                    if((this._iconLookup.ContainsKey(key:  val_6)) != false)
            {
                    val_6 = this._iconLookup.Item[val_6];
                val_7 = val_6.GetIcon(name:  name);
                if(val_7 != 0)
            {
                    return val_7;
            }
            
            }
            
            }
            
            val_7 = this._defaultIcon;
            return val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IconLookup(Master.EventExposer masterEventExposer, Game.MasterData.MasterDataDomain masterDataDomain, Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache> assetCacheAccess, Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Bundles.IBundleCache> bundleCacheAccess)
        {
            val_1 = new Utilities.AsyncInterfaceAccess<Game.AssetManagement.Icons.IIconLookup>();
            this._masterEventExposer = masterEventExposer;
            this._masterDataDomain = masterDataDomain;
            this._defaultIcon = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Icons/alpine_ui_icon_default");
            this._iconLoader = new Game.AssetManagement.Icons.IconLoader();
            this._masterEventExposer.add_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::LocalGameplayAssetsReady(int failedAssetCount)));
            this._masterEventExposer.add_LocalGameplayEnded(value:  new System.Action(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::LocalGameplayEnded()));
            this._masterEventExposer.add_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
            this._masterEventExposer.add_ActiveSeasonalEventsUpdated(value:  new System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<System.String>>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::SeasonalDataLoaded(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> skins)));
            val_1.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Assets.IAssetCache>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::AssetCacheReady(Systems.AssetManagement.Assets.IAssetCache assetCache)));
            bundleCacheAccess.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Bundles.IBundleCache>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::BundleCacheReady(Systems.AssetManagement.Bundles.IBundleCache bundleCache)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<System.String>> val_10;
            this._masterEventExposer.remove_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
            this._masterEventExposer.remove_LocalGameplayEnded(value:  new System.Action(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::LocalGameplayEnded()));
            this._masterEventExposer.remove_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::LocalGameplayAssetsReady(int failedAssetCount)));
            System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<System.String>> val_4 = null;
            val_10 = val_4;
            val_4 = new System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<System.String>>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::SeasonalDataLoaded(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> skins));
            this._masterEventExposer.remove_ActiveSeasonalEventsUpdated(value:  val_4);
            if(this._iconLoader != null)
            {
                    this._iconLoader._bundleCache = 0;
            }
            
            this._iconLoader = 0;
            if(this._iconLookup == null)
            {
                goto label_6;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_6 = this._iconLookup.Values.GetEnumerator();
            val_10 = 1152921525498815216;
            label_10:
            if(((-580718760) & 1) == 0)
            {
                goto label_8;
            }
            
            0.emailUIDataHandler.Teardown();
            goto label_10;
            label_8:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525500964696});
            this._iconLookup.Clear();
            this._iconLookup = 0;
            label_6:
            this._bundleNames = 0;
            UnityEngine.Resources.UnloadAsset(assetToUnload:  this._defaultIcon);
            this._masterEventExposer = 0;
            this._bundleCache = 0;
            this._defaultIcon = 0;
            this._assetCache = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalGameplayAssetsReady(int failedAssetCount)
        {
            System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, Game.AssetManagement.Icons.IconGroupData> val_1 = new System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, Game.AssetManagement.Icons.IconGroupData>();
            val_1.Add(key:  6, value:  new Game.AssetManagement.Icons.IconGroupData());
            this._iconLookup = val_1;
            this.TryToStartLoadingIcons();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalGameplayEnded()
        {
            if(this._iconLoader != null)
            {
                    this._iconLoader._bundleCache = 0;
            }
            
            this._iconLoader = new Game.AssetManagement.Icons.IconLoader();
            if(this._iconLookup == null)
            {
                goto label_2;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = this._iconLookup.Values.GetEnumerator();
            label_6:
            if(((-580386200) & 1) == 0)
            {
                goto label_4;
            }
            
            0.emailUIDataHandler.Teardown();
            goto label_6;
            label_4:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525501297256});
            this._iconLookup.Clear();
            this._iconLookup = 0;
            label_2:
            this._iconLookup = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)
        {
            System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, Game.AssetManagement.Icons.IconGroupData> val_1 = new System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, Game.AssetManagement.Icons.IconGroupData>();
            val_1.Add(key:  0, value:  new Game.AssetManagement.Icons.IconGroupData());
            val_1.Add(key:  1, value:  new Game.AssetManagement.Icons.IconGroupData());
            val_1.Add(key:  2, value:  new Game.AssetManagement.Icons.IconGroupData());
            val_1.Add(key:  3, value:  new Game.AssetManagement.Icons.IconGroupData());
            val_1.Add(key:  4, value:  new Game.AssetManagement.Icons.IconGroupData());
            val_1.Add(key:  5, value:  new Game.AssetManagement.Icons.IconGroupData());
            val_1.Add(key:  6, value:  new Game.AssetManagement.Icons.IconGroupData());
            val_1.Add(key:  7, value:  new Game.AssetManagement.Icons.IconGroupData());
            val_1.Add(key:  8, value:  new Game.AssetManagement.Icons.IconGroupData());
            this._iconLookup = val_1;
            this.TryToStartLoadingIcons();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SeasonalDataLoaded(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> skins)
        {
            if(tag != 4)
            {
                    return;
            }
            
            this._masterEventExposer.remove_ActiveSeasonalEventsUpdated(value:  new System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<System.String>>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::SeasonalDataLoaded(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> skins)));
            if(skins.Count >= 1)
            {
                    this._storeSkinOverride = skins.Item[0];
            }
            
            this._masterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY data)
        {
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            string val_55;
            var val_56;
            ENTRY val_46 = data;
            System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, System.String> val_1 = new System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, System.String>();
            var val_3 = (val_46 != 0) ? (val_1) : 0;
            if(val_46 == null)
            {
                goto label_3;
            }
            
            ARTASSETS val_4 = val_46.ArtAssets;
            if(val_4 == null)
            {
                goto label_3;
            }
            
            UIASSETS val_5 = val_4.UI;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            string val_6 = val_5.CpuIconsBundle;
            if(val_6 == null)
            {
                goto label_4;
            }
            
            label_50:
            val_3.set_Item(key:  0, value:  val_6);
            var val_7 = (val_46 != 0) ? ((val_46 != 0) ? (this) : 0) : 0;
            var val_8 = (val_46 != 0) ? (val_3) : 0;
            if(val_46 == null)
            {
                goto label_8;
            }
            
            ARTASSETS val_9 = val_46.ArtAssets;
            if(val_9 == null)
            {
                goto label_8;
            }
            
            UIASSETS val_11 = val_9.UI;
            if(val_11 == null)
            {
                goto label_8;
            }
            
            string val_12 = val_11.ModIconsBundle;
            val_47 = val_8;
            if(val_12 == null)
            {
                goto label_9;
            }
            
            label_52:
            val_47.set_Item(key:  (val_9 != 0) ? 1 : 0, value:  val_12);
            Game.AssetManagement.Icons.IconGroup val_13 = (val_46 != 0) ? 1 : 0;
            val_7 = (val_46 != 0) ? (val_7) : 0;
            val_8 = (val_46 != 0) ? (val_47) : 0;
            if(val_46 == null)
            {
                goto label_13;
            }
            
            ARTASSETS val_14 = val_46.ArtAssets;
            if(val_14 == null)
            {
                goto label_13;
            }
            
            UIASSETS val_15 = val_14.UI;
            if(val_15 == null)
            {
                goto label_13;
            }
            
            val_13 = val_13 << 1;
            string val_16 = val_15.PlushSuitIconsBundle;
            val_48 = val_8;
            if(val_16 == null)
            {
                goto label_14;
            }
            
            label_54:
            val_48.set_Item(key:  val_13, value:  val_16);
            var val_18 = (val_46 != 0) ? (val_48) : 0;
            var val_19 = (val_46 != 0) ? (val_7) : 0;
            if(val_46 == null)
            {
                goto label_18;
            }
            
            ARTASSETS val_20 = val_46.ArtAssets;
            if(val_20 == null)
            {
                goto label_18;
            }
            
            UIASSETS val_21 = val_20.UI;
            if(val_21 == null)
            {
                goto label_18;
            }
            
            string val_22 = val_21.PortraitIconsBundle;
            val_49 = val_18;
            if(val_22 == null)
            {
                goto label_19;
            }
            
            label_56:
            val_49.set_Item(key:  (val_46 != 0) ? 3 : 0, value:  val_22);
            Game.AssetManagement.Icons.IconGroup val_23 = (val_46 != 0) ? 1 : 0;
            val_18 = (val_46 != 0) ? (val_49) : 0;
            val_19 = (val_46 != 0) ? (val_19) : 0;
            if(val_46 == null)
            {
                goto label_23;
            }
            
            ARTASSETS val_24 = val_46.ArtAssets;
            if(val_24 == null)
            {
                goto label_23;
            }
            
            UIASSETS val_25 = val_24.UI;
            if(val_25 == null)
            {
                goto label_23;
            }
            
            val_23 = val_23 << 2;
            string val_26 = val_25.RewardIconsBundle;
            val_50 = val_18;
            if(val_26 == null)
            {
                goto label_24;
            }
            
            label_58:
            val_50.set_Item(key:  val_23, value:  val_26);
            val_18 = (val_46 != 0) ? (val_50) : 0;
            val_19 = (val_46 != 0) ? (val_19) : 0;
            if(val_46 == null)
            {
                goto label_28;
            }
            
            ARTASSETS val_28 = val_46.ArtAssets;
            if(val_28 == null)
            {
                goto label_28;
            }
            
            UIASSETS val_29 = val_28.UI;
            if(val_29 == null)
            {
                goto label_28;
            }
            
            string val_30 = val_29.StoreIconsBundle;
            val_51 = val_18;
            if(val_30 == null)
            {
                goto label_29;
            }
            
            label_60:
            val_51.set_Item(key:  (val_46 != 0) ? 5 : 0, value:  val_30);
            val_18 = (val_46 != 0) ? (val_51) : 0;
            val_19 = (val_46 != 0) ? (val_19) : 0;
            if(val_46 == null)
            {
                goto label_33;
            }
            
            ARTASSETS val_32 = val_46.ArtAssets;
            if(val_32 == null)
            {
                goto label_33;
            }
            
            UIASSETS val_33 = val_32.UI;
            if(val_33 == null)
            {
                goto label_33;
            }
            
            string val_34 = val_33.OneOffScriptedIconsBundle;
            val_52 = val_18;
            if(val_34 == null)
            {
                goto label_34;
            }
            
            label_62:
            val_52.set_Item(key:  (val_46 != 0) ? 6 : 0, value:  val_34);
            val_18 = (val_46 != 0) ? (val_52) : 0;
            val_19 = (val_46 != 0) ? (val_19) : 0;
            if(val_46 == null)
            {
                goto label_38;
            }
            
            ARTASSETS val_36 = val_46.ArtAssets;
            if(val_36 == null)
            {
                goto label_38;
            }
            
            UIASSETS val_37 = val_36.UI;
            if(val_37 == null)
            {
                goto label_38;
            }
            
            string val_38 = val_37.ShopUIIconsBundle;
            val_53 = val_18;
            if(val_38 == null)
            {
                goto label_39;
            }
            
            label_64:
            val_53.set_Item(key:  (val_46 != 0) ? 7 : 0, value:  val_38);
            var val_41 = (val_46 != 0) ? (val_19) : 0;
            if(val_46 == null)
            {
                goto label_43;
            }
            
            ARTASSETS val_42 = val_46.ArtAssets;
            if(val_42 == null)
            {
                goto label_43;
            }
            
            UIASSETS val_43 = val_42.UI;
            if(val_43 == null)
            {
                goto label_43;
            }
            
            val_46 = ((val_46 != 0) ? 1 : 0) << 3;
            string val_44 = val_43.DailyChallengesIconBundle;
            val_54 = (val_46 != 0) ? (val_53) : 0;
            if(val_44 == null)
            {
                goto label_44;
            }
            
            label_66:
            val_54.set_Item(key:  val_46, value:  val_44);
            mem2[0] = val_54;
            if((System.String.IsNullOrEmpty(value:  this._storeSkinOverride)) != true)
            {
                    val_55 = this._storeSkinOverride;
                this._bundleNames.set_Item(key:  7, value:  val_55);
            }
            
            this.TryToStartLoadingIcons();
            return;
            label_3:
            val_56 = val_1;
            label_4:
            if(val_56 != null)
            {
                goto label_50;
            }
            
            goto label_50;
            label_8:
            label_9:
            if(val_3 != 0)
            {
                goto label_52;
            }
            
            goto label_52;
            label_13:
            label_14:
            if(val_47 != 0)
            {
                goto label_54;
            }
            
            goto label_54;
            label_18:
            label_19:
            if(val_48 != 0)
            {
                goto label_56;
            }
            
            goto label_56;
            label_23:
            label_24:
            if(val_49 != 0)
            {
                goto label_58;
            }
            
            goto label_58;
            label_28:
            label_29:
            if(val_50 != 0)
            {
                goto label_60;
            }
            
            goto label_60;
            label_33:
            label_34:
            if(val_51 != 0)
            {
                goto label_62;
            }
            
            goto label_62;
            label_38:
            label_39:
            if(val_52 != 0)
            {
                goto label_64;
            }
            
            goto label_64;
            label_43:
            label_44:
            if(val_53 != 0)
            {
                goto label_66;
            }
            
            goto label_66;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetCacheReady(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            this._assetCache = assetCache;
            this.TryToStartLoadingIcons();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BundleCacheReady(Systems.AssetManagement.Bundles.IBundleCache bundleCache)
        {
            this._bundleCache = bundleCache;
            this.TryToStartLoadingIcons();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToStartLoadingIcons()
        {
            var val_4;
            System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, System.String> val_13;
            int val_14;
            if(this._bundleNames == null)
            {
                    return;
            }
            
            if(this._assetCache == null)
            {
                    return;
            }
            
            if(this._bundleCache == null)
            {
                    return;
            }
            
            if(this._iconLookup == null)
            {
                    return;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this._iconLookup.Keys.GetEnumerator();
            goto label_6;
            label_13:
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_5 = val_4.region;
            Game.AssetManagement.Icons.IconGroupData val_6 = this._iconLookup.Item[val_5];
            val_6._assetCache = this._assetCache;
            val_13 = this._bundleNames;
            if((val_13.ContainsKey(key:  val_5)) != false)
            {
                    val_13 = this._bundleNames;
                string val_8 = val_13.Item[val_5];
            }
            else
            {
                    val_14 = System.String.alignConst;
            }
            
            val_6.BundleName = val_14;
            label_6:
            if(((-579178704) & 1) != 0)
            {
                goto label_13;
            }
            
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525502504752});
            this._iconLoader.StartLoadingBundles(bundleCache:  this._bundleCache, iconLookups:  this._iconLookup, completeCallback:  new System.Action(object:  this, method:  System.Void Game.AssetManagement.Icons.IconLookup::LoadingIconsComplete()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadingIconsComplete()
        {
            if(this._iconLoader != null)
            {
                    this._iconLoader._bundleCache = 0;
            }
            
            this._iconLoader = 0;
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static IconLookup()
        {
            Game.AssetManagement.Icons.IconLookup.DefaultIconResourcesPath = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
