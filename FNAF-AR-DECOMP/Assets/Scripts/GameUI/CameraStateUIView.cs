using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraStateUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameProject_Alpine_CanvasController_Camera gameProject_Alpine_CanvasController_Camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject cameraParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject flashlightParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject flashlightOnState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button flashlightButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image flashlightCooldown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject maskParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.HoldableButton maskButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject shockerParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button shockerButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image shockerCooldown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject remnantParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI remnantText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject emfParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image emfIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI emfText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject batteryParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Slider batterySlider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image batteryBG;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI batteryNumberText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image batteryColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.BatteryColorToValue> batteryColorToValues;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Color batterySurgeColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject extraBatteryParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image extraBatteryIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI extraBatteryText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject Debug_EssenceStatsParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text Debug_EssenceText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text Debug_ThreatText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.Debug_EssenceStats debug_EssenceStats;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BatteryColorHandler batteryColorHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BatteryMaskLightHandler batteryMaskLightHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SurgeMechanicUIHandler surgeMechanicUIHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool emfIconSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool extraBatteryIconSet;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVisibility()
        {
            var val_33;
            var val_34;
            var val_35;
            var val_37;
            var val_38;
            val_33 = this;
            bool val_1 = this._masterDomain.AttackSequenceDomain.IsEncounterPlayingOutro();
            val_34 = 0;
            this.cameraParent.SetActive(value:  val_1 ^ 1);
            val_35 = this._masterDomain.CameraEquipmentDomain.Mask;
            val_37 = null;
            if(val_1 == false)
            {
                goto label_7;
            }
            
            var val_27 = 0;
            val_38 = 1152921505274241032;
            val_27 = val_27 + 1;
            val_38 = 1152921505274241048;
            val_34 = 5;
            goto label_11;
            label_7:
            var val_28 = 0;
            val_38 = 1152921505274241032;
            val_28 = val_28 + 1;
            goto label_15;
            label_11:
            val_35 = ???;
            val_33 = ???;
            val_37 = 0;
            val_35.SetDesiredMaskState(desiredMaskState:  false);
            return;
            label_15:
            bool val_6 = val_35.IsMaskFullyOff();
            this.batteryParent.SetActive(value:  val_6 & this.ShouldBatteryBeVisible());
            this.emfParent.SetActive(value:  val_6 & this.ShouldEmfBeVisible());
            this.extraBatteryParent.SetActive(value:  val_6 & this.ShouldExtraBatteryBeVisible());
            this.flashlightParent.SetActive(value:  val_6 & this.ShouldFlashlightBeVisible());
            this.maskParent.SetActive(value:  this.ShouldMaskBeVisible());
            this.remnantParent.SetActive(value:  val_6 & this.ShouldRemnantBeVisible());
            this.shockerParent.SetActive(value:  val_6 & this.ShouldShockerBeVisible());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldBatteryBeVisible()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if(val_1 != null)
            {
                    return (bool)val_1;
            }
            
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldEmfBeVisible()
        {
            var val_5;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if(true != 0)
            {
                    val_5 = 0;
                if(this._masterDomain.devicesDomain.AllPlayerDevices.active.Meter == null)
            {
                    return (bool)val_5;
            }
            
                if(this.ShouldRemnantBeVisible() == false)
            {
                    return (bool)val_5;
            }
            
                var val_4 = (this._masterDomain.devicesDomain.AllPlayerDevices.active.Meter.Count > 0) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldExtraBatteryBeVisible()
        {
            var val_5;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if(true != 0)
            {
                    if((this._masterDomain.devicesDomain.AllPlayerDevices.purchased.ContainsKey(key:  "ExtraBattery")) != false)
            {
                    var val_4 = (this._masterDomain.devicesDomain.AllPlayerDevices.purchased.Item["ExtraBattery"] > 0) ? 1 : 0;
                return (bool)val_5;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldFlashlightBeVisible()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if(val_1 != null)
            {
                    return (bool)val_1;
            }
            
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldMaskBeVisible()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if(true == 0)
            {
                    return false;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            return this._masterDomain.CameraEquipmentDomain.Mask.IsMaskAvailable;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldRemnantBeVisible()
        {
            Game.AttackSequence.AttackSequenceDomain val_4;
            var val_5;
            val_4 = this;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if(W8 != 0)
            {
                    val_4 = this._masterDomain.AttackSequenceDomain;
                bool val_2 = val_4.IsInShockableEncounter();
                val_5 = val_2 ^ 1;
            }
            
            val_2 = val_5;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldShockerBeVisible()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if(W8 == 0)
            {
                    return false;
            }
            
            if(this._masterDomain.AttackSequenceDomain != null)
            {
                    return this._masterDomain.AttackSequenceDomain.IsInShockableEncounter();
            }
            
            return this._masterDomain.AttackSequenceDomain.IsInShockableEncounter();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateValues()
        {
            if(this.cameraParent.activeSelf == false)
            {
                    return;
            }
            
            if(this.batteryParent.activeSelf != false)
            {
                    this.UpdateBattery();
            }
            
            if(this.emfParent.activeSelf != false)
            {
                    this.UpdateEmf();
            }
            
            if(this.extraBatteryParent.activeSelf != false)
            {
                    this.UpdateExtraBattery();
            }
            
            if(this.flashlightParent.activeSelf != false)
            {
                    this.UpdateFlashlight();
            }
            
            if(this.maskParent.activeSelf != false)
            {
                    this.UpdateMask();
            }
            
            if(this.remnantParent.activeSelf != false)
            {
                    this.UpdateRemnant();
            }
            
            if(this.shockerParent.activeSelf == false)
            {
                    return;
            }
            
            this.UpdateShocker();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBattery()
        {
            this.UpdateBatteryChargeNumber();
            this.UpdateBatteryChargeSlider();
            this.batteryColorHandler.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBatteryChargeNumber()
        {
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.batteryNumberText.text = UnityEngine.Mathf.FloorToInt(f:  this._masterDomain.CameraEquipmentDomain.Battery.Charge * 100f).ToString()(UnityEngine.Mathf.FloorToInt(f:  this._masterDomain.CameraEquipmentDomain.Battery.Charge * 100f).ToString()) + "%"("%");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBatteryChargeSlider()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            float val_3 = this._masterDomain.CameraEquipmentDomain.Battery.Charge;
            if(this.batterySlider == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEmf()
        {
            System.Collections.Generic.List<Game.TheGame.Data.DeviceEntry> val_1 = this._masterDomain.devicesDomain.AllPlayerDevices.GetEntriesForType(type:  6);
            if(val_1 != null)
            {
                    if(val_1.Count > 0)
            {
                    GameUI.DeviceDisplay.DisplayCharges(deviceEntry:  val_1.Item[0], timer:  this.emfText);
                if(this.emfIconSet == true)
            {
                    return;
            }
            
                Game.ItemDefinition.Data.DataDefinitions.DeviceData val_5 = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetDeviceById(id:  "EMFMeter");
                this.emfIcon.sprite = this._masterDomain.DeviceConfigs.GetSpriteForDeviceCategory(category:  val_5.Type);
                this.emfIconSet = true;
                return;
            }
            
            }
            
            this.emfParent.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateExtraBattery()
        {
            var val_8;
            string val_9;
            if((this._masterDomain.devicesDomain.AllPlayerDevices.purchased.ContainsKey(key:  "ExtraBattery")) != false)
            {
                    val_8 = this._masterDomain.devicesDomain.AllPlayerDevices.purchased;
                int val_2 = val_8.Item["ExtraBattery"];
            }
            else
            {
                    val_8 = 0;
            }
            
            val_9 = val_8.ToString();
            this.extraBatteryText.text = val_9;
            if(this.extraBatteryIconSet == true)
            {
                    return;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.DeviceData val_5 = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetDeviceById(id:  "ExtraBattery");
            val_9 = this._masterDomain.DeviceConfigs.GetSpriteForDeviceCategory(category:  val_5.Type);
            this.extraBatteryIcon.sprite = val_9;
            this.extraBatteryIconSet = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateFlashlight()
        {
            var val_14;
            float val_16;
            Game.CameraEquipment.Flashlight.IFlashlight val_1 = this._masterDomain.CameraEquipmentDomain.Flashlight;
            var val_15 = 0;
            val_15 = val_15 + 1;
            this.flashlightOnState.SetActive(value:  val_1.IsOn);
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_1.IsOn == true)
            {
                goto label_14;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_1.CanTurnOn() == false)
            {
                goto label_20;
            }
            
            label_14:
            Game.AttackSequence.AttackSequenceDomain val_18 = this._masterDomain.AttackSequenceDomain;
            val_18 = (~val_18.IsDisruptionFullyActive()) & 1;
            if(this.flashlightButton != null)
            {
                goto label_37;
            }
            
            label_38:
            label_37:
            this.flashlightButton.interactable = val_18;
            var val_19 = 0;
            val_19 = val_19 + 1;
            bool val_11 = val_1.HasEnoughBatteryToActivate();
            var val_12 = (val_11 != true) ? this.flashlightCooldown : 0;
            if(val_11 == false)
            {
                goto label_29;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_34;
            label_29:
            val_16 = 0f;
            val_14 = this.flashlightCooldown;
            if(val_14 != null)
            {
                goto label_39;
            }
            
            goto label_36;
            label_20:
            if(this.flashlightButton != null)
            {
                goto label_37;
            }
            
            goto label_38;
            label_34:
            val_16 = val_1.GetCooldownPercent();
            if(val_12 != 0)
            {
                goto label_39;
            }
            
            label_36:
            label_39:
            val_12.fillAmount = val_16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateMask()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._masterDomain.CameraEquipmentDomain.Mask.SetDesiredMaskState(desiredMaskState:  this.maskButton.IsPressed);
            this.batteryMaskLightHandler.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateRemnant()
        {
            this.remnantText.text = this._masterDomain.WorkshopDomain.Inventory.CurrencyContainer.Essence.ToString(format:  "n0");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateShocker()
        {
            var val_9;
            float val_10;
            Game.CameraEquipment.Shocker.IShocker val_1 = this._masterDomain.CameraEquipmentDomain.Shocker;
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_1.GetStatus() == 0)
            {
                goto label_8;
            }
            
            if(this.shockerButton != null)
            {
                goto label_17;
            }
            
            label_18:
            label_17:
            this.shockerButton.interactable = false;
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_14;
            label_8:
            Game.AttackSequence.AttackSequenceDomain val_12 = this._masterDomain.AttackSequenceDomain;
            val_12 = (~val_12.IsDisruptionFullyActive()) & 1;
            if(this.shockerButton != null)
            {
                goto label_17;
            }
            
            goto label_18;
            label_14:
            Game.CameraEquipment.Shocker.ShockerStatus val_6 = val_1.GetStatus();
            var val_7 = (val_6 == 2) ? 0 : this.shockerCooldown;
            if(val_6 != 2)
            {
                goto label_19;
            }
            
            val_10 = 0f;
            val_9 = this.shockerCooldown;
            if(val_9 != null)
            {
                goto label_27;
            }
            
            goto label_21;
            label_19:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_10 = val_1.GetCooldownPercent();
            if(val_7 != 0)
            {
                goto label_27;
            }
            
            label_21:
            label_27:
            val_7.fillAmount = val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAttackEncounterEnded(Game.AttackSequence.Encounters.EncounterResult result)
        {
            this._masterDomain.theGameDomain.gameDisplayChanger.RequestDisplayChange(displayType:  7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            this._masterEventExposer = val_1.eventExposer;
            val_1.eventExposer.add_AttackSequenceReadyForUi(value:  new System.Action<Game.AttackSequence.Encounters.EncounterResult>(object:  this, method:  System.Void GameUI.CameraStateUIView::OnAttackEncounterEnded(Game.AttackSequence.Encounters.EncounterResult result)));
            GameUI.SurgeMechanicUIHandler val_4 = new GameUI.SurgeMechanicUIHandler(surgeMechanicUIHandlerData:  new GameUI.SurgeMechanicUIHandlerData(eventExposer:  this._masterEventExposer));
            this.surgeMechanicUIHandler = val_4;
            .surgeMechanicUIHandler = val_4;
            .batterySlider = this.batterySlider;
            .batteryColor = this.batteryColor;
            .batteryBG = this.batteryBG;
            .batteryText = this.batteryNumberText;
            .batteryColorToValues = this.batteryColorToValues;
            .batterySurgeColor = this.batterySurgeColor;
            mem[1152921524923802676] = ???;
            mem[1152921524923802684] = 1152921505238953984;
            this.batteryColorHandler = new GameUI.BatteryColorHandler(batteryColorHandlerData:  new GameUI.BatteryColorHandlerData());
            .surgeMechanicUIHandler = this.surgeMechanicUIHandler;
            ._data = new GameUI.BatteryMaskLightHandlerData();
            this.batteryMaskLightHandler = new GameUI.BatteryMaskLightHandler();
            ._masterDomain = this._masterDomain;
            .debug_EssenceStatsParent = this.Debug_EssenceStatsParent;
            .debug_EssenceText = this.Debug_EssenceText;
            .debug_ThreatText = this.Debug_ThreatText;
            this.debug_EssenceStats = new GameUI.Debug_EssenceStats();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this._masterEventExposer.remove_AttackSequenceReadyForUi(value:  new System.Action<Game.AttackSequence.Encounters.EncounterResult>(object:  this, method:  System.Void GameUI.CameraStateUIView::OnAttackEncounterEnded(Game.AttackSequence.Encounters.EncounterResult result)));
            this._masterDomain = 0;
            this._masterEventExposer = 0;
            this.batteryColorHandler = 0;
            this.batteryMaskLightHandler = 0;
            this.surgeMechanicUIHandler.Teardown();
            this.surgeMechanicUIHandler = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdateVisibility();
            this.UpdateValues();
            this.surgeMechanicUIHandler.Update();
            this.debug_EssenceStats.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraStateUIView()
        {
        
        }
    
    }

}
