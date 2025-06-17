using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RemoveEntityRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string REMOVE_ENTITY = "REMOVE_ENTITY_V3";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ENTITYID = "EntityId";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RemoveEntityRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525154604784] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveEntityRequest(string entityId)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "REMOVE_ENTITY_V3");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "REMOVE_ENTITY_V3");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "EntityId", value:  entityId);
            entityId.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  this, method:  System.Void Game.Server.RemoveEntityRequester::OnRemoveEntitySucceeded(Systems.Server.ServerResponse serverResponse)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  this, method:  System.Void Game.Server.RemoveEntityRequester::OnRemoveEntityError(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRemoveEntitySucceeded(Systems.Server.ServerResponse serverResponse)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRemoveEntityError(Systems.Server.ServerData serverData)
        {
            ConsoleLogger.LogError(className:  "Destroyer", functionName:  "OnDestroyEntityResponse", logString:  "Error: "("Error: ") + serverData.JSON);
        }
    
    }

}
