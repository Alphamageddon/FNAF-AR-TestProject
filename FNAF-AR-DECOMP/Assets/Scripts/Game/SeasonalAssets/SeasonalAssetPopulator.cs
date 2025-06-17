using UnityEngine;

namespace Game.SeasonalAssets
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalAssetPopulator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalAssets.SeasonalAssetManifest _manifest;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.SeasonalAssets.SeasonalAssetManifest manifest, Master.EventExposer eventExposer)
        {
            this._eventExposer = eventExposer;
            this._manifest = manifest;
            eventExposer.add_PopulateSeasonalAssetsRequest(value:  new System.Action<System.String, UnityEngine.Transform>(object:  this, method:  System.Void Game.SeasonalAssets.SeasonalAssetPopulator::EventExposer_SeasonalAssetsRequest(string receiverId, UnityEngine.Transform target)));
            this._eventExposer.add_PopulateExistingSeasonalReceivers(value:  new System.Action(object:  this, method:  System.Void Game.SeasonalAssets.SeasonalAssetPopulator::EventExposer_RescanAllSeasonalAssets()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._eventExposer.remove_PopulateExistingSeasonalReceivers(value:  new System.Action(object:  this, method:  System.Void Game.SeasonalAssets.SeasonalAssetPopulator::EventExposer_RescanAllSeasonalAssets()));
            this._eventExposer.remove_PopulateSeasonalAssetsRequest(value:  new System.Action<System.String, UnityEngine.Transform>(object:  this, method:  System.Void Game.SeasonalAssets.SeasonalAssetPopulator::EventExposer_SeasonalAssetsRequest(string receiverId, UnityEngine.Transform target)));
            this._eventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_SeasonalAssetsRequest(string receiverId, UnityEngine.Transform target)
        {
            System.Collections.Generic.List<Entry> val_1 = 0;
            bool val_2 = this._manifest.TryGetEntriesForKey(key:  receiverId, result: out  val_1);
            if(val_2 == false)
            {
                    return;
            }
            
            val_2.PopulateTarget(target:  target, assetEntries:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_RescanAllSeasonalAssets()
        {
            var val_3;
            string val_4;
            val_3 = 0;
            goto label_3;
            label_8:
            T val_3 = UnityEngine.Object.FindObjectsOfType<Game.SeasonalAssets.SeasonalAssetReceiver>()[0];
            if(val_3 != 0)
            {
                    val_4 = mem[val_1[0x0][0] + 24];
                val_4 = val_1[0x0][0] + 24;
            }
            else
            {
                    val_4 = 15026800;
            }
            
            this.EventExposer_SeasonalAssetsRequest(receiverId:  val_4, target:  val_3.transform);
            val_3 = 1;
            label_3:
            if(val_3 < val_1.Length)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PopulateTarget(UnityEngine.Transform target, System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetManifest.Entry> assetEntries)
        {
            var val_8;
            string val_9;
            UnityEngine.Object val_10;
            val_8 = 0;
            goto label_1;
            label_31:
            val_9 = assetEntries.Item[0];
            if(val_1.asset != null)
            {
                    var val_2 = (null == null) ? val_1.asset : 0;
            }
            else
            {
                    val_10 = 0;
            }
            
            if(val_10 != 0)
            {
                    UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_10, parent:  target);
            }
            else
            {
                    string[] val_5 = new string[5];
                val_5[0] = "Attempt to populate seasonal asset (";
                val_5[1] = val_1.assetBundle;
                val_5[2] = ") ";
                val_5[3] = val_1.assetPath;
                val_9 = " which has not been pre-loaded";
                val_5[4] = val_9;
                ConsoleLogger.LogError(className:  "SeasonalAssetPopulator", functionName:  "PopulateTarget", logString:  +val_5);
            }
            
            val_8 = 1;
            label_1:
            if(val_8 < assetEntries.Count)
            {
                goto label_31;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalAssetPopulator()
        {
        
        }
    
    }

}
