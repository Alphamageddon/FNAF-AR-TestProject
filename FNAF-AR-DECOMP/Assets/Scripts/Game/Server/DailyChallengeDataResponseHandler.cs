using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengeDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ACTIVE_DAILY_CHALLENGE = "PlayerDailyChallengeData";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CHALLENGES = "dailyChallenges";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string LOGICAL = "dailyChallengeLogical";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CURRENTCOMPLETION = "progress";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MAXCOMPLETION = "completionGoal";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STATE = "state";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STATE_COLLECTED = "COLLECTED";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EXPIRATION_TIME = "expirationTime";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<Game.Server.DailyChallengeResponseData> ChallengeDataReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.Server.DailyChallengeResponseData> callback)
        {
            this.ChallengeDataReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerDailyChallengeData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.ProcessChallengeData(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ProcessChallengeData(Systems.Server.ServerData data)
        {
            .State = data.GetString(key:  "state");
            if(data != null)
            {
                    .Complete = System.String.op_Equality(a:  data.GetString(key:  "state"), b:  "COLLECTED");
            }
            else
            {
                    .Complete = System.String.op_Equality(a:  0.GetString(key:  "state"), b:  "COLLECTED");
            }
            
            System.Nullable<System.Int64> val_10 = data.GetLong(key:  "expirationTime");
            .ExpirationTime = ;
            .Entries = val_10.HasValue.GetChallengeEntries(entries:  data.GetServerDataList(key:  "dailyChallenges"));
            if(this.ChallengeDataReceived == null)
            {
                    return;
            }
            
            this.ChallengeDataReceived.Invoke(obj:  new Game.Server.DailyChallengeResponseData());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.Server.DailyChallengeEntry> GetChallengeEntries(System.Collections.Generic.List<Systems.Server.ServerData> entries)
        {
            System.Collections.Generic.List<Game.Server.DailyChallengeEntry> val_1 = new System.Collections.Generic.List<Game.Server.DailyChallengeEntry>();
            if(entries == null)
            {
                    return val_1;
            }
            
            int val_2 = entries.Count;
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            var val_9 = 0;
            do
            {
                Systems.Server.ServerData val_3 = entries.Item[0];
                .Logical = val_3.GetString(key:  "dailyChallengeLogical");
                if(val_3 != null)
            {
                    System.Nullable<System.Int32> val_6 = val_3.GetInt(key:  "progress");
                .Completion = val_6.HasValue;
            }
            else
            {
                    System.Nullable<System.Int32> val_7 = val_3.GetInt(key:  "progress");
                .Completion = val_7.HasValue;
            }
            
                System.Nullable<System.Int32> val_8 = val_3.GetInt(key:  "completionGoal");
                .MaxCompletion = val_8.HasValue;
                val_1.Add(item:  new Game.Server.DailyChallengeEntry());
                val_9 = val_9 + 1;
            }
            while(val_2 != val_9);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeDataResponseHandler()
        {
        
        }
    
    }

}
