using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StartEssenceEncounterRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StartEssenceEncounterRequester(Game.Server.LogEventHandler eventHandler)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartEssenceEncounter()
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "START_ESSENCE_ENCOUNTER_V3");
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
    
    }

}
