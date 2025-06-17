using UnityEngine;

namespace Game.Server.Inbox
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SendTestRewardMessageToSelfRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendTestMessage()
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "SEND_TEST_REWARD_INBOX_MESSAGE");
            var val_9 = 0;
            val_9 = val_9 + 1;
            GameSparks.Api.Requests.LogEventRequest val_6 = val_1.SetEventAttribute(key:  "to", value:  GameSparks.Core.GS.GSPlatform.UserId);
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SendTestRewardMessageToSelfRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525204559296] = eventHandler;
        }
    
    }

}
