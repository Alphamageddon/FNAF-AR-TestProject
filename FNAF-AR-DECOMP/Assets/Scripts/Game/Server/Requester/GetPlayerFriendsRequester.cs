using UnityEngine;

namespace Game.Server.Requester
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GetPlayerFriendsRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayerFriendsRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525204944560] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetPlayerFriends()
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "GET_PLAYER_FRIENDS");
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
    
    }

}
