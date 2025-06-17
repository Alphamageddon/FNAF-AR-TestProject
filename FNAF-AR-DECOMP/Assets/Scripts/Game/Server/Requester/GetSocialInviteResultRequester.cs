using UnityEngine;

namespace Game.Server.Requester
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GetSocialInviteResultRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialInviteResultRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525208355232] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendInviteResult(bool wasComplete)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "INVITE_RESULT");
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "inviteSent", value:  wasComplete);
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
    
    }

}
