using UnityEngine;

namespace Game.SeasonalAssets
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalAssetManifest
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.GetAccessToData _getAccessToData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _activeSeasonalAssetsGroups;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetManifest.Entry>> _assetEntriesByKey;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetManifest.Entry>> AssetEntriesByKey { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetManifest.Entry>> get_AssetEntriesByKey()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Entry>>)this._assetEntriesByKey;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TryGetEntriesForKey(string key, out System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetManifest.Entry> result)
        {
            if(this._assetEntriesByKey != null)
            {
                    return this._assetEntriesByKey.TryGetValue(key:  key, value: out  System.Collections.Generic.List<Entry> val_1 = result);
            }
            
            return this._assetEntriesByKey.TryGetValue(key:  key, value: out  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalAssetManifest(Game.MasterData.GetAccessToData getAccessToData, Master.EventExposer eventExposer)
        {
            val_1 = new System.Object();
            this._activeSeasonalAssetsGroups = 0;
            this._assetEntriesByKey = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Entry>>();
            this._eventExposer = val_1;
            this._getAccessToData = getAccessToData;
            val_1.add_ActiveSeasonalEventsUpdated(value:  new System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<System.String>>(object:  this, method:  System.Void Game.SeasonalAssets.SeasonalAssetManifest::EventDomain_ActiveSeasonalEventsUpdated(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> list)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            mem[1152921525229899680] = 0;
            if(this._eventExposer != null)
            {
                    this._eventExposer.remove_ActiveSeasonalEventsUpdated(value:  new System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<System.String>>(object:  this, method:  System.Void Game.SeasonalAssets.SeasonalAssetManifest::EventDomain_ActiveSeasonalEventsUpdated(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> list)));
            }
            
            this._eventExposer = 0;
            mem[1152921525229899672] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventDomain_ActiveSeasonalEventsUpdated(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> list)
        {
            if(tag != 2)
            {
                    return;
            }
            
            this._activeSeasonalAssetsGroups = list;
            this._getAccessToData.GetSeasonalAssetsDataAsync(returnSeasonalAssetsDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.SEASONAL_ASSETS_DATA>(object:  this, method:  System.Void Game.SeasonalAssets.SeasonalAssetManifest::ParseSeasonalAssetsData(ProtoData.SEASONAL_ASSETS_DATA eventData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ParseSeasonalAssetsData(ProtoData.SEASONAL_ASSETS_DATA eventData)
        {
            var val_19;
            var val_20;
            var val_23;
            var val_24;
            val_19 = 1152921504689487872;
            val_20 = eventData.Entries.GetEnumerator();
            label_18:
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(val_20.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            T val_6 = val_20.Current;
            bool val_8 = this._activeSeasonalAssetsGroups.Contains(item:  val_6.Group);
            if((val_8 == false) || ((val_8.ValidateAssetEntry(entry:  val_6)) == false))
            {
                goto label_18;
            }
            
            this.AddAsset(source:  val_6);
            goto label_18;
            label_8:
            val_23 = 0;
            val_24 = 78;
            if(val_20 == null)
            {
                
            }
            else
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_20.Dispose();
            }
            
            if( == 78)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_20 = ???;
            val_24 = ???;
            val_19 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddAsset(ProtoData.SEASONAL_ASSETS_DATA.Types.ENTRY source)
        {
            string val_1 = source.ReceiverId;
            if((this._assetEntriesByKey.ContainsKey(key:  val_1)) != true)
            {
                    this._assetEntriesByKey.set_Item(key:  val_1, value:  new System.Collections.Generic.List<Entry>());
            }
            
            .assetBundle = source.BundleId;
            .assetPath = source.AssetId;
            .asset = 0;
            this._assetEntriesByKey.Item[val_1].Add(item:  new SeasonalAssetManifest.Entry());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ValidateAssetEntry(ProtoData.SEASONAL_ASSETS_DATA.Types.ENTRY entry)
        {
            string val_8;
            string val_10;
            var val_11;
            val_8 = entry;
            bool val_2 = System.String.IsNullOrEmpty(value:  val_8.BundleId);
            if(val_8 == null)
            {
                goto label_2;
            }
            
            if(val_2 == false)
            {
                goto label_3;
            }
            
            label_5:
            string val_3 = val_8.BundleId;
            val_10 = "Invalid seasonal asset data specified empty asset bundle: \"";
            goto label_4;
            label_2:
            if(val_2 == true)
            {
                goto label_5;
            }
            
            label_3:
            if((System.String.IsNullOrEmpty(value:  val_8.AssetId)) == false)
            {
                goto label_6;
            }
            
            val_10 = "Invalid seasonal asset data specified empty asset path: \"";
            label_4:
            val_8 = val_10 + val_8.AssetId + "\"";
            ConsoleLogger.LogError(className:  "SeasonalAssetManifest", functionName:  "ValidateAssetEntry", logString:  val_8);
            val_11 = 0;
            return (bool)val_11;
            label_6:
            val_11 = 1;
            return (bool)val_11;
        }
    
    }

}
