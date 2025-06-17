using UnityEngine;

namespace Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameSparksCurrentStreakLeaderboardGetter : CurrentStreakLeaderboardGetter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ClassName = "GameSparksCurrentStreakLeaderboardGetter";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> CurrentStreakLeaderboardUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> callback)
        {
            this.CurrentStreakLeaderboardUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetLeaderboard()
        {
            GameSparks.Api.Requests.LeaderboardDataRequest val_1 = new GameSparks.Api.Requests.LeaderboardDataRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LeaderboardDataRequest val_2 = val_1.SetLeaderboardShortCode(leaderboardShortCode:  "CURRENT_STREAK_LB");
            }
            else
            {
                    GameSparks.Api.Requests.LeaderboardDataRequest val_3 = val_1.SetLeaderboardShortCode(leaderboardShortCode:  "CURRENT_STREAK_LB");
            }
            
            GameSparks.Api.Requests.LeaderboardDataRequest val_4 = val_1.SetEntryCount(entryCount:  100);
            val_1.Send(callback:  new System.Action<GameSparks.Api.Responses.LeaderboardDataResponse>(object:  this, method:  System.Void Server.GameSparksCurrentStreakLeaderboardGetter::OnLeaderboardDataResponse(GameSparks.Api.Responses.LeaderboardDataResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLeaderboardDataResponse(GameSparks.Api.Responses.LeaderboardDataResponse response)
        {
            var val_18;
            string val_19;
            string val_21;
            val_18 = response;
            if(val_18.HasErrors != false)
            {
                    val_19 = "ERROR: "("ERROR: ") + val_18.Errors.JSON;
                ConsoleLogger.LogError(className:  "GameSparksCurrentStreakLeaderboardGetter", functionName:  "OnLeaderboardDataResponse", logString:  val_19);
                return;
            }
            
            System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> val_5 = new System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>();
            val_19 = 1152921517576098192;
            val_18 = val_18.Data.GetEnumerator();
            goto label_10;
            label_31:
            var val_20 = 0;
            val_20 = val_20 + 1;
            T val_9 = val_18.Current;
            System.Nullable<System.Int64> val_10 = val_9.Rank;
            string val_11 = val_9.UserName;
            val_21 = val_11;
            if((System.String.IsNullOrEmpty(value:  val_11)) != false)
            {
                    val_21 = val_9.UserId;
            }
            
            System.Nullable<System.Int64> val_14 = val_9.GetNumberValue(key:  "currentStreak");
            TheGame.Data.LeaderboardEntry val_16 = new TheGame.Data.LeaderboardEntry();
            if(val_16 != null)
            {
                    .rank = ;
                .name = val_21;
            }
            else
            {
                    mem[16] = ;
                mem[24] = val_21;
            }
            
            .score = ;
            .userId = val_9.UserId;
            .avatarId = val_9.GetStringValue(key:  "avatarId");
            val_5.Add(item:  val_16);
            label_10:
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(val_18.MoveNext() == true)
            {
                goto label_31;
            }
            
            if(mem[1152921523192856576] == 0)
            {
                    return;
            }
            
            mem[1152921523192856576].Invoke(obj:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameSparksCurrentStreakLeaderboardGetter()
        {
        
        }
    
    }

}
