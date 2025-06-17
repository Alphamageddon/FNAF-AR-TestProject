using UnityEngine;

namespace Game.Devices
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DevicesSrOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Devices.DevicesDomain _devicesDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.AllPlayerDevices _playerData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.DeviceRequester _api;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.DEVICES_DATA _metadata;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _activeDevice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _activeDeviceIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _deviceIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _quantity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _deviceList;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int DeviceIndex { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Quantity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ActiveDevice { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DevicesSrOptions(Game.Devices.DevicesDomain devicesDomain, Game.TheGame.Data.AllPlayerDevices playerData, Game.Server.DeviceRequester api, ProtoData.DEVICES_DATA metadata)
        {
            var val_12;
            var val_13;
            this._quantity = 1;
            this._activeDevice = "";
            this._deviceList = new System.Collections.Generic.List<System.String>();
            val_2 = new System.Object();
            this._devicesDomain = devicesDomain;
            this._playerData = val_2;
            this._api = api;
            this._metadata = metadata;
            this._deviceList.Clear();
            System.Collections.Generic.IEnumerator<T> val_4 = metadata.Entries.GetEnumerator();
            label_17:
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            this._deviceList.Add(item:  val_4.Current.DeviceLogical);
            goto label_17;
            label_9:
            val_12 = 0;
            val_13 = 134;
            if(val_4 == null)
            {
                
            }
            else
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_4.Dispose();
            }
            
            this._devicesDomain._eventExposer.add_DeviceDataReceived(value:  new System.Action<Game.TheGame.Data.AllPlayerDevices>(object:  this, method:  public System.Void Game.Devices.DevicesSrOptions::OnDeviceDataReceived(Game.TheGame.Data.AllPlayerDevices data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDeviceDataReceived(Game.TheGame.Data.AllPlayerDevices data)
        {
            if(this._devicesDomain.NumActive() >= 1)
            {
                    this._activeDeviceIndex = 0;
                this.GetActiveDeviceName();
                return;
            }
            
            this._activeDevice = "";
            SROptions.Current.OnPropertyChanged(propertyName:  "ActiveDevice");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetActiveDeviceName()
        {
            this._activeDevice = this._devicesDomain.GetActiveDeviceName(index:  this._activeDeviceIndex);
            SROptions.Current.OnPropertyChanged(propertyName:  "ActiveDevice");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_DeviceId()
        {
            if(this._deviceList != null)
            {
                    return this._deviceList.Item[this._deviceIndex];
            }
            
            return this._deviceList.Item[this._deviceIndex];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_DeviceIndex()
        {
            return (int)this._deviceIndex;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DeviceIndex(int value)
        {
            System.Collections.Generic.List<System.String> val_5 = this._deviceList;
            int val_1 = val_5.Count;
            int val_2 = value / val_1;
            val_5 = value - (val_2 * val_1);
            this._deviceIndex = val_5;
            if((val_5 & 2147483648) != 0)
            {
                    val_2 = this._deviceList.Count + val_5;
                this._deviceIndex = val_2;
            }
            
            SROptions.Current.OnPropertyChanged(propertyName:  "DeviceToPurchase");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Quantity()
        {
            return (int)this._quantity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Quantity(int value)
        {
            this._quantity = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PurchaseDevice()
        {
            this._api.PurchaseDevice(deviceConfigId:  this.DeviceId, quantity:  this._quantity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ActivateDevice()
        {
            this._api.ActivateDevice(deviceConfigId:  this.DeviceId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ActiveDevice()
        {
            return (string)this._activeDevice;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetNextActiveDevice()
        {
            int val_1 = this._devicesDomain.NumActive();
            if(val_1 < 1)
            {
                    return;
            }
            
            int val_3 = this._activeDeviceIndex;
            val_3 = val_3 + 1;
            val_3 = val_3 - ((val_3 / val_1) * val_1);
            this._activeDeviceIndex = val_3;
            this.GetActiveDeviceName();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void KillActiveDevice()
        {
            if((System.String.op_Inequality(a:  this._activeDevice, b:  "")) == false)
            {
                    return;
            }
            
            this._api.ExpireDevice(activeDeviceId:  this._activeDevice);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CheatActiveDevice()
        {
            if((System.String.op_Inequality(a:  this._activeDevice, b:  "")) == false)
            {
                    return;
            }
            
            this._api.CheatDevice(activeDeviceId:  this._activeDevice);
        }
    
    }

}
