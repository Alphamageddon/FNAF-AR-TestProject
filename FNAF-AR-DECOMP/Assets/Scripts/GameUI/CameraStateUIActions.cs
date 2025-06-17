using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraStateUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceDisplayDialog deviceDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _masterEvents_RewardDialogOpened()
        {
            this.deviceDialog.DismissAlert();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShockButtonTriggered()
        {
            this._masterDomain.AttackSequenceDomain.ShockerActivated();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FlashlightButtonTriggered()
        {
            var val_15;
            var val_16;
            var val_18;
            bool val_22;
            val_15 = this._masterDomain.CameraEquipmentDomain.Flashlight;
            var val_9 = 0;
            val_16 = 1152921505274400776;
            val_9 = val_9 + 1;
            val_16 = 1152921505274400792;
            val_18 = val_15.IsOn;
            if(val_18 == true)
            {
                goto label_8;
            }
            
            var val_10 = 0;
            val_16 = 1152921505274400776;
            val_10 = val_10 + 1;
            val_16 = 1152921505274400792;
            if(val_15.CanTurnOn() == false)
            {
                goto label_14;
            }
            
            label_8:
            if(this._masterDomain.AttackSequenceDomain.IsDisruptionFullyActive() == false)
            {
                goto label_17;
            }
            
            label_14:
            var val_11 = 0;
            val_16 = 1152921505274400776;
            val_11 = val_11 + 1;
            val_16 = 1152921505274400792;
            goto label_22;
            label_17:
            val_22 = val_18 ^ 1;
            var val_12 = 0;
            val_16 = 1152921505274400776;
            val_12 = val_12 + 1;
            goto label_27;
            label_22:
            val_22 = ???;
            val_15 = ???;
            val_18 = ???;
            val_15.TriedToTurnOn();
            return;
            label_27:
            val_15.SetFlashlightState(setOn:  val_22, shouldPlayAudio:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EmfMeterPressed()
        {
            this.deviceDialog.SetDataForSingleItem(data:  this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetDeviceById(id:  "EMFMeter"), icon:  this._masterDomain.DeviceConfigs.GetSpriteForDeviceCategory(category:  val_2.Type));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ExtraBatteryPressed()
        {
            this.deviceDialog.SetDataForSingleItem(data:  this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetDeviceById(id:  "ExtraBattery"), icon:  this._masterDomain.DeviceConfigs.GetSpriteForDeviceCategory(category:  val_2.Type));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            this._masterEvents = val_1.eventExposer;
            val_1.eventExposer.add_RewardDialogOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.CameraStateUIActions::_masterEvents_RewardDialogOpened()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.deviceDialog.Initialize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this._masterEvents.remove_RewardDialogOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.CameraStateUIActions::_masterEvents_RewardDialogOpened()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraStateUIActions()
        {
        
        }
    
    }

}
