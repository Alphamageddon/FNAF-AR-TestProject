using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ExpressDeliveryRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string EXPRESS_DELIVERY = "EXPRESS_DELIVERY";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ENTITY_ID = "entityId";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action ErrorReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendExpressDeliveryRequest(string id, System.Action errorCallback)
        {
            this.ErrorReceived = errorCallback;
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "EXPRESS_DELIVERY");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "EXPRESS_DELIVERY");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "entityId", value:  id);
            id.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  this, method:  public System.Void Game.Server.ExpressDeliveryRequester::ErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ExpressDeliveryRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525153954304] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ErrorResponse(Systems.Server.ServerData serverData)
        {
            if(this.ErrorReceived == null)
            {
                    return;
            }
            
            this.ErrorReceived.Invoke();
        }
    
    }

}
