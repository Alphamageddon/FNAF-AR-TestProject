using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerAnimatronicEntityClearer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CLEAR_ENTITIES = "CLEAR_ENTITIES";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "CLEAR_ENTITIES");
            val_1.Send(callback:  new System.Action<GameSparks.Api.Responses.LogEventResponse>(object:  this, method:  System.Void TheGame.PlayerAnimatronicEntityClearer::OnEventResponse(GameSparks.Api.Responses.LogEventResponse gsResponse)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEventResponse(GameSparks.Api.Responses.LogEventResponse gsResponse)
        {
            Systems.Server.ServerResponse val_1 = new Systems.Server.ServerResponse(gsResponse:  gsResponse, pfResponse:  0);
            if(val_1.HasErrors == false)
            {
                    return;
            }
            
            ConsoleLogger.LogError(className:  "Server", functionName:  "OnRequestNewAnimatronicFromServer", logString:  "Error: "("Error: ") + val_1.Errors.JSON);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerAnimatronicEntityClearer()
        {
        
        }
    
    }

}
