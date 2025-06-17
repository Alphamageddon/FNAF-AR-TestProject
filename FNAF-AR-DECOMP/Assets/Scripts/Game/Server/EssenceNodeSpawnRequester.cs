using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceNodeSpawnRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceNodeSpawnRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525160599408] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Spawn(System.Collections.Generic.List<string> objectTypes, System.Action<System.Collections.Generic.List<Game.Server.EssenceNodeEntry>> newCallback)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            .callback = newCallback;
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "ESSENCE_NODE_SPAWN_V2");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventKey(eventKey:  "ESSENCE_NODE_SPAWN_V2");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_5 = val_1.SetEventAttribute(key:  "objectTypes", value:  objectTypes);
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  new Game.Server.EssenceNodeCustomReponse(), method:  public System.Void Game.Server.EssenceNodeCustomReponse::OnResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
    
    }

}
