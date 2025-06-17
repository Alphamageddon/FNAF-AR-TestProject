using UnityEngine;

namespace Game.DailyChallenge.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MasterDataConnector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasRewardsDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasChallengeDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.DailyChallenge.Container.DailyChallengeContainer _dailyChallengeContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnDataLoaded;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasRewardsDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasChallengeDataLoaded { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasRewardsDataLoaded()
        {
            return (bool)this.<HasRewardsDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasRewardsDataLoaded(bool value)
        {
            this.<HasRewardsDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasChallengeDataLoaded()
        {
            return (bool)this.<HasChallengeDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasChallengeDataLoaded(bool value)
        {
            this.<HasChallengeDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnDataLoaded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataLoaded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataLoaded != 1152921525393263104);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnDataLoaded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataLoaded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataLoaded != 1152921525393399680);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MasterDataConnector(Game.MasterData.MasterDataDomain masterDataDomain, Game.DailyChallenge.Container.DailyChallengeContainer dailyChallengeContainer, System.Action callback)
        {
            val_1 = new System.Object();
            this._dailyChallengeContainer = val_1;
            masterDataDomain.GetAccessToData.GetDailyChallengeDataAsync(returnDailyChallengeData:  new GetAccessToData.ReturnAnyData<ProtoData.DAILY_CHALLENGE_DATA>(object:  this, method:  public System.Void Game.DailyChallenge.Data.MasterDataConnector::SetChallengeDataEntries(ProtoData.DAILY_CHALLENGE_DATA data)));
            masterDataDomain.GetAccessToData.GetDailyChallengeRewardsDataAsync(returnDailyChallengeRewardsData:  new GetAccessToData.ReturnAnyData<ProtoData.DAILY_CHALLENGE_REWARDS_DATA>(object:  this, method:  public System.Void Game.DailyChallenge.Data.MasterDataConnector::SetDailyChallengeRewardsData(ProtoData.DAILY_CHALLENGE_REWARDS_DATA data)));
            this.add_OnDataLoaded(value:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDailyChallengeRewardsData(ProtoData.DAILY_CHALLENGE_REWARDS_DATA data)
        {
            this._dailyChallengeContainer.SetRewardsData(data:  data);
            this.<HasRewardsDataLoaded>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetChallengeDataEntries(ProtoData.DAILY_CHALLENGE_DATA data)
        {
            this._dailyChallengeContainer.LoadChallengeEntries(data:  data);
            this.<HasChallengeDataLoaded>k__BackingField = true;
        }
    
    }

}
