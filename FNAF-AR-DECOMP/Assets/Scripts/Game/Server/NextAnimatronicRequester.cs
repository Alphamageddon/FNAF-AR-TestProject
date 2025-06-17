using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NextAnimatronicRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestNextAnimatronic(Game.Server.NextAnimatronicRequester.DisplayState currentDisplayState)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "REQUEST_ENTITIES_V8");
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "uiLocation", value:  (currentDisplayState == 1) ? "nonmap" : "map");
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NextAnimatronicRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525154364400] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string GetDisplayStateString(Game.Server.NextAnimatronicRequester.DisplayState displayState)
        {
            return (string)(displayState == 1) ? "nonmap" : "map";
        }
    
    }

}
