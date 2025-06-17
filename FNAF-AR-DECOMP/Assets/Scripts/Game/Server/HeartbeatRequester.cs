using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HeartbeatRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HeartbeatRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525156478976] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendHeartbeat(int index)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "CLIENT_HEARTBEAT");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "CLIENT_HEARTBEAT");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "index", value:  index);
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
    
    }

}
