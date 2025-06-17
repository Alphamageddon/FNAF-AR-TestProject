using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action OnDeviceDataUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceRequester(Game.Server.LogEventHandler eventHandler, System.Action callback)
        {
            val_1 = new System.Object();
            mem[1152921525157029600] = eventHandler;
            this.OnDeviceDataUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestDeviceData()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PurchaseDevice(string deviceConfigId, int quantity)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ActivateDevice(string deviceConfigId)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "ACTIVATE_DEVICE");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "ACTIVATE_DEVICE");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "deviceConfigId", value:  deviceConfigId);
            deviceConfigId.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  this, method:  System.Void Game.Server.DeviceRequester::OnEventResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ExpireDevice(string activeDeviceId)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "EXPIRE_DEVICE");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "EXPIRE_DEVICE");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "activeDeviceId", value:  activeDeviceId);
            activeDeviceId.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  this, method:  System.Void Game.Server.DeviceRequester::OnEventResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CheatDevice(string activeDeviceId)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEventResponse(Systems.Server.ServerResponse response)
        {
            this.OnDeviceDataUpdated.Invoke();
        }
    
    }

}
