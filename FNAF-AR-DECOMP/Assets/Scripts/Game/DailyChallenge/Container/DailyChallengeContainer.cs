using UnityEngine;

namespace Game.DailyChallenge.Container
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengeContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Game.DailyChallenge.Data.DailyChallengeRewardsData> _rewards;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Game.DailyChallenge.Data.DailyChallengeData> _challengesLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.DailyChallenge.Data.DailyChallengeData> _activeChallenges;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <ExpirationTime>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <DailyChallengeCollected>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.DailyChallenge.Data.DailyChallengesState State;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.DailyChallenge.Data.DailyChallengeRewardsData> Rewards { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.DailyChallenge.Data.DailyChallengeData> ChallengesLookup { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.DailyChallenge.Data.DailyChallengeData> ActiveChallenges { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long ExpirationTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DailyChallengeCollected { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.DailyChallenge.Data.DailyChallengeRewardsData> get_Rewards()
        {
            return (System.Collections.Generic.Dictionary<System.String, Game.DailyChallenge.Data.DailyChallengeRewardsData>)this._rewards;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.DailyChallenge.Data.DailyChallengeData> get_ChallengesLookup()
        {
            return (System.Collections.Generic.Dictionary<System.String, Game.DailyChallenge.Data.DailyChallengeData>)this._challengesLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.DailyChallenge.Data.DailyChallengeData> get_ActiveChallenges()
        {
            return (System.Collections.Generic.Dictionary<System.String, Game.DailyChallenge.Data.DailyChallengeData>)this._activeChallenges;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_ExpirationTime()
        {
            return (long)this.<ExpirationTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ExpirationTime(long value)
        {
            this.<ExpirationTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_DailyChallengeCollected()
        {
            return (bool)this.<DailyChallengeCollected>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DailyChallengeCollected(bool value)
        {
            this.<DailyChallengeCollected>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeContainer(Master.EventExposer eventExposer)
        {
            this._eventExposer = eventExposer;
            this._challengesLookup = new System.Collections.Generic.Dictionary<System.String, Game.DailyChallenge.Data.DailyChallengeData>();
            this._activeChallenges = new System.Collections.Generic.Dictionary<System.String, Game.DailyChallenge.Data.DailyChallengeData>();
            this._rewards = new System.Collections.Generic.Dictionary<System.String, Game.DailyChallenge.Data.DailyChallengeRewardsData>();
            this._eventExposer.add_DailyChallengeListReceived(value:  new System.Action<Game.Server.DailyChallengeResponseData>(object:  this, method:  System.Void Game.DailyChallenge.Container.DailyChallengeContainer::OnDailyChallengeListLoaded(Game.Server.DailyChallengeResponseData responseData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadChallengeEntries(ProtoData.DAILY_CHALLENGE_DATA data)
        {
            var val_6;
            ENTRY val_7;
            val_6 = 0;
            goto label_1;
            label_8:
            val_7 = data.Entries.Item[0];
            Game.DailyChallenge.Data.DailyChallengeData val_3 = new Game.DailyChallenge.Data.DailyChallengeData(data:  val_7);
            if(val_3 != null)
            {
                    val_7 = this._challengesLookup;
                val_7.Add(key:  (Game.DailyChallenge.Data.DailyChallengeData)[1152921525395002976].Id, value:  val_3);
            }
            
            val_6 = 1;
            label_1:
            if(val_6 < data.Entries.Count)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetRewardsData(ProtoData.DAILY_CHALLENGE_REWARDS_DATA data)
        {
            var val_6;
            ENTRY val_7;
            val_6 = 0;
            goto label_1;
            label_8:
            val_7 = data.Entries.Item[0];
            Game.DailyChallenge.Data.DailyChallengeRewardsData val_3 = new Game.DailyChallenge.Data.DailyChallengeRewardsData(entry:  val_7);
            if(val_3 != null)
            {
                    val_7 = this._rewards;
                val_7.Add(key:  (Game.DailyChallenge.Data.DailyChallengeRewardsData)[1152921525395175392].Id, value:  val_3);
            }
            
            val_6 = 1;
            label_1:
            if(val_6 < data.Entries.Count)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.DailyChallenge.Data.DailyChallengeData LoadDailyChallengeInstance(Game.Server.DailyChallengeEntry entry)
        {
            int val_4;
            System.Collections.Generic.Dictionary<System.String, Game.DailyChallenge.Data.DailyChallengeData> val_5;
            var val_6;
            val_4 = entry;
            val_5 = this._challengesLookup;
            if((val_5.ContainsKey(key:  entry.Logical)) == false)
            {
                goto label_3;
            }
            
            Game.DailyChallenge.Data.DailyChallengeData val_3 = null;
            val_6 = val_3;
            val_3 = new Game.DailyChallenge.Data.DailyChallengeData(orig:  this._challengesLookup.Item[entry.Logical]);
            val_5 = entry.Completion;
            if(val_6 == null)
            {
                goto label_5;
            }
            
            .CurrentCompletion = val_5;
            val_4 = entry.MaxCompletion;
            goto label_6;
            label_3:
            val_6 = 0;
            return (Game.DailyChallenge.Data.DailyChallengeData)val_6;
            label_5:
            mem[80] = val_5;
            val_4 = entry.MaxCompletion;
            label_6:
            .MaxCompletion = val_4;
            return (Game.DailyChallenge.Data.DailyChallengeData)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDailyChallengeListLoaded(Game.Server.DailyChallengeResponseData responseData)
        {
            var val_6;
            if(responseData != null)
            {
                    this.<ExpirationTime>k__BackingField = responseData.ExpirationTime;
                this.<DailyChallengeCollected>k__BackingField = responseData.Complete;
            }
            else
            {
                    this.<ExpirationTime>k__BackingField = 15026800;
                this.<DailyChallengeCollected>k__BackingField = false;
            }
            
            bool val_2 = System.Enum.TryParse<Game.DailyChallenge.Data.DailyChallengesState>(value:  responseData.State, result: out  this.State);
            this._activeChallenges.Clear();
            val_6 = 0;
            goto label_6;
            label_11:
            this._activeChallenges.Add(key:  val_3.Logical, value:  this.LoadDailyChallengeInstance(entry:  responseData.Entries.Item[0]));
            val_6 = 1;
            label_6:
            if(val_6 < responseData.Entries.Count)
            {
                goto label_11;
            }
            
            this._eventExposer.OnActiveDailyChallengesUpdated();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.DailyChallenge.Data.DailyChallengeRewardsData GetReward(string logical)
        {
            var val_3;
            if((this._rewards.ContainsKey(key:  logical)) != false)
            {
                    Game.DailyChallenge.Data.DailyChallengeRewardsData val_2 = this._rewards.Item[logical];
                return (Game.DailyChallenge.Data.DailyChallengeRewardsData)val_3;
            }
            
            val_3 = 0;
            return (Game.DailyChallenge.Data.DailyChallengeRewardsData)val_3;
        }
    
    }

}
