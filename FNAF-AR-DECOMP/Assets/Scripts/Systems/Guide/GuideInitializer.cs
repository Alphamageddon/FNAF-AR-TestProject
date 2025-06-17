using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideInitializer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideNodeDriver _driver;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain _masterData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.TutorialData _cachedStartupData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer masterEvents, Systems.Guide.GuideNodeDriver driver, Game.MasterData.MasterDataDomain masterData)
        {
            this._masterEvents = masterEvents;
            this._driver = driver;
            this._masterData = masterData;
            masterEvents.add_TutorialStartupDataReceived(value:  new System.Action<Game.TheGame.Data.TutorialData>(object:  this, method:  System.Void Systems.Guide.GuideInitializer::EventExposer_TutorialDataReceived(Game.TheGame.Data.TutorialData startupData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterData = 0;
            this._masterEvents.remove_TutorialStartupDataReceived(value:  new System.Action<Game.TheGame.Data.TutorialData>(object:  this, method:  System.Void Systems.Guide.GuideInitializer::EventExposer_TutorialDataReceived(Game.TheGame.Data.TutorialData startupData)));
            this._masterEvents = 0;
            mem[1152921523377929080] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_TutorialDataReceived(Game.TheGame.Data.TutorialData startupData)
        {
            this._masterEvents.remove_TutorialStartupDataReceived(value:  new System.Action<Game.TheGame.Data.TutorialData>(object:  this, method:  System.Void Systems.Guide.GuideInitializer::EventExposer_TutorialDataReceived(Game.TheGame.Data.TutorialData startupData)));
            this._cachedStartupData = startupData;
            this._masterData.GetAccessToData.GetTutorialDataAsync(returnTutorialDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.TUTORIAL_DATA>(object:  this, method:  System.Void Systems.Guide.GuideInitializer::OnMetadataReady(ProtoData.TUTORIAL_DATA metaData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMetadataReady(ProtoData.TUTORIAL_DATA metaData)
        {
            Systems.Guide.GuideFactory.LoadTutorialDataFromProtobuf(data:  metaData);
            this.ActivateNodes(data:  this._cachedStartupData);
            this._cachedStartupData = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ActivateNodes(Game.TheGame.Data.TutorialData data)
        {
            goto label_1;
            label_15:
            Game.TheGame.Data.TutorialEntry val_1 = data.Entries.Item[0];
            if((System.String.IsNullOrEmpty(value:  val_1.TutorialKey)) != true)
            {
                    Game.TheGame.Data.TutorialEntry val_3 = data.Entries.Item[0];
                if((System.String.IsNullOrEmpty(value:  val_3.GuideNodeId)) != true)
            {
                    Game.TheGame.Data.TutorialEntry val_5 = data.Entries.Item[0];
                this._driver.LoadNode(node:  Systems.Guide.GuideFactory.GenerateNode(uid:  val_5.GuideNodeId));
            }
            
            }
            
            0 = 1;
            label_1:
            if(0 < data.Entries.Count)
            {
                goto label_15;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideInitializer()
        {
        
        }
    
    }

}
