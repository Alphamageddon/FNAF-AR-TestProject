using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.AllPlayerDevices> DeviceDataReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.TheGame.Data.AllPlayerDevices> callback)
        {
            this.DeviceDataReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerDeviceData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.ProcessDeviceData(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessDeviceData(Systems.Server.ServerData data)
        {
            Game.TheGame.Data.DeviceActiveData val_1 = this.ProcessActiveDeviceData(data:  data);
            Game.TheGame.Data.AllPlayerDevices val_3 = new Game.TheGame.Data.AllPlayerDevices();
            if(val_3 != null)
            {
                    .active = val_1;
            }
            else
            {
                    mem[16] = val_1;
            }
            
            .purchased = val_1.ProcessPurchasedDeviceData(data:  data);
            this.DeviceDataReceived.Invoke(obj:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, int> ProcessPurchasedDeviceData(Systems.Server.ServerData data)
        {
            var val_14;
            var val_15;
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "purchased");
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_7 = val_1.BaseData.Keys.GetEnumerator();
            label_26:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            T val_11 = val_7.Current;
            System.Nullable<System.Int32> val_12 = val_1.GetInt(key:  val_11);
            val_2.Add(key:  val_11, value:  -904784552);
            goto label_26;
            label_18:
            val_14 = 0;
            val_15 = 87;
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_7.Dispose();
            }
            
            if( == 87)
            {
                    return val_2;
            }
            
            if( == false)
            {
                    return val_2;
            }
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.DeviceActiveData ProcessActiveDeviceData(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_2 = data.GetServerData(key:  "active");
            .Lure = this.ProcessTypedDeviceEntries(type:  "Lure", data:  val_2);
            .Battery = this.ProcessTypedDeviceEntries(type:  "ExtraBattery", data:  val_2);
            .Shocker = this.ProcessTypedDeviceEntries(type:  "SuperShocker", data:  val_2);
            .Transponder = this.ProcessTypedDeviceEntries(type:  "FriendOrFoeTransponder", data:  val_2);
            .Scanner = this.ProcessTypedDeviceEntries(type:  "SalvageScanner", data:  val_2);
            .Jammer = this.ProcessTypedDeviceEntries(type:  "RadioJammer", data:  val_2);
            .Meter = this.ProcessTypedDeviceEntries(type:  "EMFMeter", data:  val_2);
            .HomeInvasion = this.ProcessTypedDeviceEntries(type:  "HomeInvasion", data:  val_2);
            return (Game.TheGame.Data.DeviceActiveData)new Game.TheGame.Data.DeviceActiveData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> ProcessTypedDeviceEntries(string type, Systems.Server.ServerData data)
        {
            var val_15;
            var val_16;
            Systems.Server.ServerData val_1 = data.GetServerData(key:  type);
            System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry> val_2 = new System.Collections.Generic.Dictionary<System.String, Game.TheGame.Data.DeviceEntry>();
            var val_15 = 0;
            val_15 = val_15 + 1;
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.Generic.IEnumerator<T> val_7 = val_1.BaseData.Keys.GetEnumerator();
            label_26:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            T val_11 = val_7.Current;
            val_2.Add(key:  val_11, value:  this.ProcessDeviceEntry(data:  val_1.GetServerData(key:  val_11)));
            goto label_26;
            label_18:
            val_15 = 0;
            val_16 = 84;
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_7.Dispose();
            }
            
            if( == 84)
            {
                    return val_2;
            }
            
            if( == false)
            {
                    return val_2;
            }
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.DeviceEntry ProcessDeviceEntry(Systems.Server.ServerData data)
        {
            string val_10;
            string val_11;
            string val_12;
            if(data != null)
            {
                    val_10 = data.GetString(key:  "deviceId");
                val_11 = data.GetString(key:  "deviceConfigId");
                val_12 = data.GetString(key:  "deviceType");
            }
            else
            {
                    val_10 = 0.GetString(key:  "deviceId");
                val_11 = 0.GetString(key:  "deviceConfigId");
                val_12 = 0.GetString(key:  "deviceType");
            }
            
            Systems.Server.ServerData val_7 = data.GetServerData(key:  "deviceState");
            Game.TheGame.Data.DeviceState val_8 = val_7.ProcessDeviceState(data:  val_7);
            Game.TheGame.Data.DeviceEntry val_9 = new Game.TheGame.Data.DeviceEntry();
            if(val_9 != null)
            {
                    .deviceId = val_10;
                .deviceConfigId = val_11;
                .deviceState = val_8;
            }
            else
            {
                    mem[32] = val_11;
                mem[16] = val_10;
                mem[40] = val_8;
            }
            
            .deviceType = val_12;
            return val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.DeviceState ProcessDeviceState(Systems.Server.ServerData data)
        {
            System.Nullable<System.Single> val_1 = data.GetFloat(key:  "scalar");
            System.Nullable<System.Double> val_2 = data.GetDouble(key:  "expirationTimeStamp");
            Game.TheGame.Data.DeviceState val_3 = new Game.TheGame.Data.DeviceState();
            if(val_3 != null)
            {
                    .scalar = V0.16B;
            }
            else
            {
                    mem[16] = V0.16B;
            }
            
            .expirationTimeStamp = V0.16B;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceDataResponseHandler()
        {
        
        }
    
    }

}
