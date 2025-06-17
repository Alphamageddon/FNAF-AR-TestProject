using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SequentialRewardDataModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>> OnSequentialRewardsModelUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> seasonalEventData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.SequentialRewardsButtonDisplay sequentialRewardsButtonDisplay;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_SeasonalPlayerDataDataReceived(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> obj)
        {
            this.seasonalEventData = obj;
            if(this.OnSequentialRewardsModelUpdated == null)
            {
                    return;
            }
            
            this.OnSequentialRewardsModelUpdated.Invoke(obj:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_SequentialRewardsButtonReady(GameUI.SequentialRewardsButtonDisplay obj)
        {
            this.sequentialRewardsButtonDisplay = obj;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SequentialRewardDataModel(Master.MasterDomain masterDomain)
        {
            this.seasonalEventData = new System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>();
            this.OnSequentialRewardsModelUpdated = new System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnSequentialRewardsModelUpdated(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> packages));
            masterDomain.eventExposer.add_SeasonalEventDataReceived(value:  new System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>>(object:  this, method:  System.Void GameUI.SequentialRewardDataModel::EventExposer_SeasonalPlayerDataDataReceived(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> obj)));
            masterDomain.eventExposer.add_SequentialRewardsButtonReady(value:  new System.Action<GameUI.SequentialRewardsButtonDisplay>(object:  this, method:  System.Void GameUI.SequentialRewardDataModel::EventExposer_SequentialRewardsButtonReady(GameUI.SequentialRewardsButtonDisplay obj)));
        }
    
    }

}
