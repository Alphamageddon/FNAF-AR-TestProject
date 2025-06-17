using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CollectDailyChallengeRewardsRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EVENT_KEY = "COLLECT_DAILY_CHALLENGE_REWARDS";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CollectDailyChallengeRewardsRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525155153568] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestRewardCollection()
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "COLLECT_DAILY_CHALLENGE_REWARDS");
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
    
    }

}
