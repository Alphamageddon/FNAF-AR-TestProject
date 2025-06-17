using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FriendCodeRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GENERATE_NEW_FRIENDCODE = "GENERATE_NEW_FRIENDCODE";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string LOOKUP_FRIENDCODE = "LOOKUP_FRIENDCODE";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string FRIEND_CODE_ID = "friendCode";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action RefreshErrorReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshCode(System.Action errorCallback)
        {
            this.RefreshErrorReceived = errorCallback;
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "GENERATE_NEW_FRIENDCODE");
            Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  this, method:  System.Void Game.Server.FriendCodeRequester::RefreshErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestFriendByCode(string friendCode)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "LOOKUP_FRIENDCODE");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "LOOKUP_FRIENDCODE");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "friendCode", value:  friendCode);
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FriendCodeRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525164579424] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshErrorResponse(Systems.Server.ServerData serverData)
        {
            if(this.RefreshErrorReceived == null)
            {
                    return;
            }
            
            this.RefreshErrorReceived.Invoke();
        }
    
    }

}
