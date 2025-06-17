using UnityEngine;

namespace Game.CameraEquipment.Flashlight
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FlashlightState : IFlashlight
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsOn>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _currentMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Battery.BatteryState _battery;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Mask.IMask _mask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private FlashlightFxController _fxRoot;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _cooldownTotal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _cooldown;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsOn { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsOnCooldown { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsOn()
        {
            return (bool)this.<IsOn>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsOn(bool value)
        {
            this.<IsOn>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_IsOnCooldown()
        {
            SimpleTimer val_4;
            var val_5;
            val_4 = this;
            if(this._cooldown.Started() != false)
            {
                    val_4 = this._cooldown;
                val_5 = val_4.IsExpired() ^ 1;
                return (bool)val_5 & 1;
            }
            
            val_5 = 0;
            return (bool)val_5 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetCooldownPercent()
        {
            if(this._cooldownTotal <= 0f)
            {
                    return 1f;
            }
            
            float val_1 = this._cooldown.GetRemainingTime();
            val_1 = val_1 / this._cooldownTotal;
            float val_2 = UnityEngine.Mathf.Clamp(value:  val_1, min:  0f, max:  1f);
            val_2 = 1f - val_2;
            return 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanTurnOn()
        {
            var val_4;
            if(this.HasEnoughBatteryToActivate() != false)
            {
                    val_4 = this.IsOnCooldown ^ 1;
                return (bool)val_4 & 1;
            }
            
            val_4 = 0;
            return (bool)val_4 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasEnoughBatteryToActivate()
        {
            var val_3;
            if(this._battery._settings != null)
            {
                    if(this._battery._isEncounterInProgress == false)
            {
                    return (bool)((this._battery.<Charge>k__BackingField) >= 0f) ? 1 : 0;
            }
            
                float val_1 = this._battery.GetLargestDrain(type:  1);
                return (bool)((this._battery.<Charge>k__BackingField) >= 0f) ? 1 : 0;
            }
            
            val_3 = 0;
            return (bool)((this._battery.<Charge>k__BackingField) >= 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriedToTurnOn()
        {
            this._masterEventExposer.OnFlashlightTriedToActivate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFlashlightState(bool setOn, bool shouldPlayAudio)
        {
            var val_1 = ((this.<IsOn>k__BackingField) == true) ? 1 : 0;
            val_1 = val_1 ^ setOn;
            if(val_1 == false)
            {
                    return;
            }
            
            this.<IsOn>k__BackingField = setOn;
            this.DrainBatteryForActivation();
            this.SetFlashlightFx();
            shouldPlayAudio = shouldPlayAudio;
            this._masterEventExposer.OnFlashlightStateChanged(isFlashlightOn:  ((this.<IsOn>k__BackingField) == true) ? 1 : 0, shouldPlayAudio:  shouldPlayAudio);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFlashlightCooldown(float cooldown)
        {
            this._cooldownTotal = cooldown;
            this._cooldown.StartTimer(time:  cooldown);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if((this.<IsOn>k__BackingField) == false)
            {
                goto label_9;
            }
            
            if(this._battery.DrainForActiveFlashlight() == false)
            {
                goto label_3;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(this._mask.IsMaskFullyOff() == true)
            {
                goto label_9;
            }
            
            label_3:
            this.SetFlashlightState(setOn:  false, shouldPlayAudio:  true);
            label_9:
            if(this._cooldown.Started() == false)
            {
                    return;
            }
            
            if(this._cooldown.IsExpired() == false)
            {
                    return;
            }
            
            this._cooldown.Reset();
            if(this.HasEnoughBatteryToActivate() == false)
            {
                    return;
            }
            
            this._masterEventExposer.OnFlashlightCooldownComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameDisplayChanged(TheGame.GameDisplayData args)
        {
            DisplayType val_1 = args.currentDisplay;
            this._currentMode = val_1;
            if(val_1 == 1)
            {
                    return;
            }
            
            if((this.<IsOn>k__BackingField) == false)
            {
                    return;
            }
            
            this.SetFlashlightState(setOn:  false, shouldPlayAudio:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DrainBatteryForActivation()
        {
            if((this.<IsOn>k__BackingField) == false)
            {
                    return;
            }
            
            this._battery.DrainForFlashlightActivation();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetFlashlightFx()
        {
            if(this._fxRoot == 0)
            {
                    return;
            }
            
            this._fxRoot.ToggleFlashlight(status:  ((this.<IsOn>k__BackingField) == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FlashlightState(Master.EventExposer masterEventExposer, Game.CameraEquipment.Battery.BatteryState battery, Game.CameraEquipment.Mask.IMask mask)
        {
            this._cooldown = new SimpleTimer();
            val_2 = new System.Object();
            this._masterEventExposer = masterEventExposer;
            this._battery = val_2;
            this._mask = mask;
            masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.CameraEquipment.Flashlight.FlashlightState::GameDisplayChanged(TheGame.GameDisplayData args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFxRoot(FlashlightFxController fxRoot)
        {
            this._fxRoot = fxRoot;
            this.SetFlashlightFx();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.CameraEquipment.Flashlight.FlashlightState::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._fxRoot = 0;
            this._battery = 0;
            this._masterEventExposer = 0;
        }
    
    }

}
