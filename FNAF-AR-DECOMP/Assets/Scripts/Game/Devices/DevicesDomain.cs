using UnityEngine;

namespace Game.Devices
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DevicesDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.AllPlayerDevices AllPlayerDevices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Devices.PlayerDeviceUpdater Updater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.DEVICES_DATA Metadata;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Devices.DevicesSrOptions _debugOptions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer EventExposer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer get_EventExposer()
        {
            return (Master.EventExposer)this._eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DevicesDomain(Game.Server.ServerDomain serverDomain, Game.ItemDefinition.ItemDefinitionDomain itemDefinitionDomain, Master.EventExposer eventExposer)
        {
            val_1 = new System.Object();
            this._serverDomain = serverDomain;
            this._eventExposer = eventExposer;
            this.AllPlayerDevices = Game.TheGame.Data.AllPlayerDevices.ConstructEmpty(itemDefinitions:  val_1.ItemDefinitions);
            Game.Devices.PlayerDeviceUpdater val_4 = new Game.Devices.PlayerDeviceUpdater();
            this.Updater = val_4;
            val_4.Setup(domain:  this, events:  this._eventExposer);
            Master.MasterDomain val_5 = Master.MasterDomain.GetDomain();
            val_5.MasterDataDomain.GetAccessToData.GetDevicesDataAsync(returnDevicesDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.DEVICES_DATA>(object:  this, method:  System.Void Game.Devices.DevicesDomain::OnMetaDataRetrieved(ProtoData.DEVICES_DATA metadata)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMetaDataRetrieved(ProtoData.DEVICES_DATA metadata)
        {
            this.Metadata = metadata;
            this.CreateDebugMenuOptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateDebugMenuOptions()
        {
            Game.Devices.DevicesSrOptions val_1 = new Game.Devices.DevicesSrOptions(devicesDomain:  this, playerData:  this.AllPlayerDevices, api:  this._serverDomain.deviceRequester, metadata:  this.Metadata);
            this._debugOptions = val_1;
            DevTools.Runtime.DebugMenu.ShowHideSROptions.RegisterMenuSection(sectionName:  "Devices", sectionMenuObject:  val_1, defaultToOn:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetActiveDeviceName(int index)
        {
            if(this.AllPlayerDevices != null)
            {
                    return this.AllPlayerDevices.GetActiveDeviceName(index:  index);
            }
            
            return this.AllPlayerDevices.GetActiveDeviceName(index:  index);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumActive()
        {
            if(this.AllPlayerDevices != null)
            {
                    return this.AllPlayerDevices.NumActive();
            }
            
            return this.AllPlayerDevices.NumActive();
        }
    
    }

}
