using UnityEngine;

namespace Game.CameraEquipment
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraEquipmentDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Battery.BatteryState _battery;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Flashlight.FlashlightState _flashlight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Mask.MaskState _mask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Shocker.ShockerState _shocker;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Battery.IBattery Battery { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Flashlight.IFlashlight Flashlight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Mask.IMask Mask { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Shocker.IShocker Shocker { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Battery.IBattery get_Battery()
        {
            return (Game.CameraEquipment.Battery.IBattery)this._battery;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Flashlight.IFlashlight get_Flashlight()
        {
            return (Game.CameraEquipment.Flashlight.IFlashlight)this._flashlight;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Mask.IMask get_Mask()
        {
            return (Game.CameraEquipment.Mask.IMask)this._mask;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Shocker.IShocker get_Shocker()
        {
            return (Game.CameraEquipment.Shocker.IShocker)this._shocker;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._shocker != null)
            {
                    this._shocker.Update();
            }
            
            if(this._flashlight != null)
            {
                    this._flashlight.Update();
            }
            
            if(this._battery == null)
            {
                    return;
            }
            
            this._battery.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraEquipmentDomain(Master.SceneLookupTableAccess sceneLookupTableAccess, Master.EventExposer masterEventExposer, Game.Devices.DevicesDomain devicesDomain, Game.MasterData.MasterDataDomain masterDataDomain, Game.Server.ServerDomain serverDomain)
        {
            val_1 = new System.Object();
            this._battery = new Game.CameraEquipment.Battery.BatteryState(masterEventExposer:  Master.EventExposer val_1 = masterEventExposer, devicesDomain:  devicesDomain, serverDomain:  serverDomain);
            Game.CameraEquipment.Mask.MaskState val_3 = new Game.CameraEquipment.Mask.MaskState();
            ._masterEventExposer = val_1;
            this._mask = val_3;
            this._flashlight = new Game.CameraEquipment.Flashlight.FlashlightState(masterEventExposer:  val_1, battery:  this._battery, mask:  val_3);
            this._shocker = new Game.CameraEquipment.Shocker.ShockerState(masterEventExposer:  val_1, devicesDomain:  devicesDomain, battery:  this._battery);
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.CameraEquipment.CameraEquipmentDomain::CameraSceneLookupTableReady(CameraSceneLookupTable cameraSceneLookupTable)));
            masterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void Game.CameraEquipment.CameraEquipmentDomain::ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)));
            masterDataDomain.GetAccessToData.GetDevicesDataAsync(returnDevicesDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.DEVICES_DATA>(object:  this, method:  System.Void Game.CameraEquipment.CameraEquipmentDomain::DevicesDataReady(ProtoData.DEVICES_DATA devicesData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CameraSceneLookupTableReady(CameraSceneLookupTable cameraSceneLookupTable)
        {
            this._flashlight._fxRoot = cameraSceneLookupTable.FlashlightFxController;
            this._flashlight.SetFlashlightFx();
            this._mask.SetFxController(maskController:  cameraSceneLookupTable.MaskController);
            this._shocker._fxRoot = cameraSceneLookupTable.ShockerFxController;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)
        {
            ENTRY val_3 = configDataEntry;
            if(val_3 == null)
            {
                goto label_0;
            }
            
            if(this._battery != null)
            {
                goto label_4;
            }
            
            label_5:
            label_4:
            this._battery.SetConfigData(rawSettings:  val_3.BatteryBehavior);
            if(val_3 != null)
            {
                    val_3 = val_3.ShockerBehavior;
            }
            
            this._shocker.SetConfigData(rawSettings:  val_3);
            return;
            label_0:
            if(this._battery != null)
            {
                goto label_4;
            }
            
            goto label_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DevicesDataReady(ProtoData.DEVICES_DATA devicesData)
        {
            this._battery.SetDevicesData(devicesData:  devicesData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._shocker.Teardown();
            this._shocker = 0;
            this._flashlight.Teardown();
            this._flashlight = 0;
            this._battery.Teardown();
            this._battery = 0;
        }
    
    }

}
