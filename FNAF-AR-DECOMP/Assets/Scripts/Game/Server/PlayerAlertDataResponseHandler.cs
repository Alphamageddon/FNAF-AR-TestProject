using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerAlertDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Alerts.Data.PlayerAlertData> PlayerAlertDataUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Alerts.Data.PlayerAlertData> callback)
        {
            this.PlayerAlertDataUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerAlertData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            this.PlayerAlertDataUpdated.Invoke(obj:  Alerts.Server.PlayerAlertDataGenerator.GeneratePlayerAlertData(data:  data));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerAlertDataResponseHandler()
        {
        
        }
    
    }

}
