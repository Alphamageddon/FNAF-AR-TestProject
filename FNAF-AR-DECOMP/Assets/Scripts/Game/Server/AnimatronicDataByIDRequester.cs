using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicDataByIDRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicDataByIDRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525152034528] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestData(string cpuId, string plushSuitId)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "GET_ANIMATRONIC_DATA_BY_ID");
                GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventAttribute(key:  "cpuId", value:  cpuId);
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventKey(eventKey:  "GET_ANIMATRONIC_DATA_BY_ID");
                GameSparks.Api.Requests.LogEventRequest val_5 = val_1.SetEventAttribute(key:  "cpuId", value:  cpuId);
            }
            
            GameSparks.Api.Requests.LogEventRequest val_6 = val_1.SetEventAttribute(key:  "plushSuitId", value:  plushSuitId);
            plushSuitId.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
    
    }

}
