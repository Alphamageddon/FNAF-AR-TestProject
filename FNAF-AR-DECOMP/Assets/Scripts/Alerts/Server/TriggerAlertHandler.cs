using UnityEngine;

namespace Alerts.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TriggerAlertHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Alerts.Data.PlayerAlertData> PlayerAlertDataUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TriggerAlertHandler(System.Action<Alerts.Data.PlayerAlertData> callback)
        {
            this.PlayerAlertDataUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerAlert(string alertId, float debugValue)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "REQUEST_ALERT_REWARD");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "REQUEST_ALERT_REWARD");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "alertId", value:  alertId);
            GameSparks.Api.Requests.LogEventRequest val_6 = val_1.SetEventAttribute(key:  "debugAlertEvalSpeedup", value:  debugValue.ToString());
            val_1.Send(callback:  new System.Action<GameSparks.Api.Responses.LogEventResponse>(object:  this, method:  System.Void Alerts.Server.TriggerAlertHandler::OnTriggerAlertResponse(GameSparks.Api.Responses.LogEventResponse gsResponse)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnTriggerAlertResponse(GameSparks.Api.Responses.LogEventResponse gsResponse)
        {
            Systems.Server.ServerResponse val_1 = new Systems.Server.ServerResponse(gsResponse:  gsResponse, pfResponse:  0);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_1.HasErrors == false)
            {
                goto label_2;
            }
            
            label_6:
            ConsoleLogger.LogError(className:  "TriggerAlertHandler", functionName:  "OnTriggerAlertResponse", logString:  "Error: "("Error: ") + val_1.Errors.JSON);
            return;
            label_1:
            if(val_1.HasErrors == true)
            {
                goto label_6;
            }
            
            label_2:
            this.PlayerAlertDataUpdated.Invoke(obj:  Alerts.Server.PlayerAlertDataGenerator.GeneratePlayerAlertData(data:  val_1.ScriptData.GetServerData(key:  "AlertData")));
        }
    
    }

}
