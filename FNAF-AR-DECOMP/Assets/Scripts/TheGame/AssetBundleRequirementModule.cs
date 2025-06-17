using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AssetBundleRequirementModule
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ASSET_BUNDLE_TUTORIAL_KEY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldDownloadAssetBundles;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldDownloadAssetBundles { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShouldDownloadAssetBundles()
        {
            return (bool)this._shouldDownloadAssetBundles;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_TutorialDataRecieved(Game.TheGame.Data.TutorialData data)
        {
            var val_4;
            this._shouldDownloadAssetBundles = true;
            val_4 = 0;
            goto label_1;
            label_6:
            Game.TheGame.Data.TutorialEntry val_1 = data.Entries.Item[0];
            if((val_1.CheckForFirstStageTutorial(entry:  val_1)) != false)
            {
                    this._shouldDownloadAssetBundles = false;
            }
            
            val_4 = 1;
            label_1:
            if(val_4 < data.Entries.Count)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CheckForFirstStageTutorial(Game.TheGame.Data.TutorialEntry entry)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((System.String.op_Inequality(a:  entry.TutorialKey, b:  TheGame.AssetBundleRequirementModule.ASSET_BUNDLE_TUTORIAL_KEY)) != false)
            {
                    val_4 = 0;
                return (bool)val_4;
            }
            
            if((System.String.op_Equality(a:  entry.GuideNodeId, b:  "FTUE_start_from_server")) == false)
            {
                    return System.String.op_Equality(a:  entry.GuideNodeId, b:  "tut_ad_popup");
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer masterEvents)
        {
            this._eventExposer = masterEvents;
            masterEvents.add_TutorialStartupDataReceived(value:  new System.Action<Game.TheGame.Data.TutorialData>(object:  this, method:  System.Void TheGame.AssetBundleRequirementModule::EventExposer_TutorialDataRecieved(Game.TheGame.Data.TutorialData data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._eventExposer.remove_TutorialStartupDataReceived(value:  new System.Action<Game.TheGame.Data.TutorialData>(object:  this, method:  System.Void TheGame.AssetBundleRequirementModule::EventExposer_TutorialDataRecieved(Game.TheGame.Data.TutorialData data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssetBundleRequirementModule()
        {
            this._shouldDownloadAssetBundles = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AssetBundleRequirementModule()
        {
            TheGame.AssetBundleRequirementModule.ASSET_BUNDLE_TUTORIAL_KEY = "FTUE";
        }
    
    }

}
