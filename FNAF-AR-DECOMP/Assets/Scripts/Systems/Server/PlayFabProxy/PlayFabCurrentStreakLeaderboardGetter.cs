using UnityEngine;

namespace Systems.Server.PlayFabProxy
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabCurrentStreakLeaderboardGetter : CurrentStreakLeaderboardGetter
    {
        // Fields
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
            .StatisticName = "CurrentStreak";
            .MaxResultsCount = 0;
            PlayFab.ClientModels.PlayerProfileViewConstraints val_2 = new PlayFab.ClientModels.PlayerProfileViewConstraints();
            if(val_2 != null)
            {
                    .ShowAvatarUrl = true;
            }
            else
            {
                    mem[16] = 1;
            }
            
            .ShowDisplayName = true;
            .ProfileConstraints = val_2;
            PlayFab.PlayFabClientAPI.GetLeaderboard(request:  new PlayFab.ClientModels.GetLeaderboardRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.GetLeaderboardResult>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PlayFabCurrentStreakLeaderboardGetter::SuccessCallback(PlayFab.ClientModels.GetLeaderboardResult result)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PlayFabCurrentStreakLeaderboardGetter::ErrorCallback(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SuccessCallback(PlayFab.ClientModels.GetLeaderboardResult result)
        {
            var val_8;
            var val_9;
            var val_10;
            int val_11;
            System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> val_1 = new System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>();
            int val_2 = result.Leaderboard.Count;
            if(val_2 >= 1)
            {
                    val_8 = 1152921523192233584;
                var val_8 = 0;
                do
            {
                PlayFab.ClientModels.PlayerLeaderboardEntry val_3 = result.Leaderboard.Item[0];
                TheGame.Data.LeaderboardEntry val_4 = new TheGame.Data.LeaderboardEntry();
                if(val_3 != null)
            {
                    val_9 = val_3;
                val_10 = System.String.IsNullOrEmpty(value:  val_3.DisplayName);
            }
            else
            {
                    val_9 = val_3;
                val_10 = System.String.IsNullOrEmpty(value:  val_3.DisplayName);
            }
            
                string val_7 = (val_10 != true) ? val_3.PlayFabId : (val_3 + 16);
                if(val_4 != null)
            {
                    .name = val_7;
                .rank = val_3.Position;
                val_11 = val_3.StatValue;
            }
            else
            {
                    .name = val_7;
                mem[16] = val_3.Position;
                val_11 = val_3.StatValue;
            }
            
                .score = (long)val_11;
                .avatarId = val_3.Profile.AvatarUrl;
                .userId = mem[val_3.PlayFabId];
                val_1.Add(item:  val_4);
                val_8 = val_8 + 1;
            }
            while(val_2 != val_8);
            
            }
            
            if(mem[1152921523358219968] == 0)
            {
                    return;
            }
            
            mem[1152921523358219968].Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ErrorCallback(PlayFab.PlayFabError error)
        {
            ConsoleLogger.LogError(className:  "PlayFabBestStreakLeaderboardGetter", functionName:  "ErrorCallback", logString:  error.ErrorMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabCurrentStreakLeaderboardGetter()
        {
        
        }
    
    }

}
