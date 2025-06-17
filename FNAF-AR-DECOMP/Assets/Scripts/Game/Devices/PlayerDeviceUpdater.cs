using UnityEngine;

namespace Game.Devices
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerDeviceUpdater
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Devices.DevicesDomain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _events;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.Devices.DevicesDomain domain, Master.EventExposer events)
        {
            this._domain = domain;
            this._events = events;
            events.add_DeviceDataReceived(value:  new System.Action<Game.TheGame.Data.AllPlayerDevices>(object:  this, method:  public System.Void Game.Devices.PlayerDeviceUpdater::UpdateDeviceData(Game.TheGame.Data.AllPlayerDevices newData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateDeviceData(Game.TheGame.Data.AllPlayerDevices newData)
        {
            this._domain.AllPlayerDevices.StompValues(newData:  newData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerDeviceUpdater()
        {
        
        }
    
    }

}
