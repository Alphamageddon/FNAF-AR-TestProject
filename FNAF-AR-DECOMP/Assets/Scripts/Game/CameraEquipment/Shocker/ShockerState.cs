using UnityEngine;

namespace Game.CameraEquipment.Shocker
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ShockerState : IShocker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.AllPlayerDevices _allPlayerDevices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Shocker.ShockerSettings _settings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Battery.BatteryState _battery;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _cooldownTotal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _cooldownTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ShockerFxController _fxRoot;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _fxDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _encounterInProgress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.EncounterType _encounterType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetTotalMissCooldownTime()
        {
            if(this._settings == null)
            {
                    return 0.4f;
            }
            
            float val_1 = this._settings.ShockerCooldown;
            val_1 = val_1 + 0.4f;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetTotalHitCooldownTime()
        {
            if(this._settings == null)
            {
                    return 0.8f;
            }
            
            float val_1 = this._settings.ShockerCooldown;
            val_1 = val_1 + 0.8f;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.Shocker.ShockerStatus GetStatus()
        {
            if(this._encounterInProgress == false)
            {
                    return 3;
            }
            
            if(this._encounterType == 3)
            {
                    return 3;
            }
            
            if((this._battery.<Charge>k__BackingField) < (this._battery.GetLargestDrain(type:  3)))
            {
                    return 3;
            }
            
            var val_3 = (this.GetRemainingCooldownTime() > 0f) ? 1 : 0;
            return 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetRemainingCooldownTime()
        {
            if(this._cooldownTimer != null)
            {
                    return this._cooldownTimer.GetRemainingTime();
            }
            
            return this._cooldownTimer.GetRemainingTime();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetCooldownPercent()
        {
            if(this._cooldownTotal <= 0f)
            {
                    return 1f;
            }
            
            float val_1 = this.GetRemainingCooldownTime();
            val_1 = val_1 / this._cooldownTotal;
            float val_2 = UnityEngine.Mathf.Clamp(value:  val_1, min:  0f, max:  1f);
            val_2 = 1f - val_2;
            return 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Activate(bool didHitAnimatronic, bool isDisruptionFullyActive)
        {
            string val_5;
            var val_6;
            var val_7;
            val_5 = this;
            Game.CameraEquipment.Shocker.ShockerStatus val_1 = this.GetStatus();
            if(this._settings == null)
            {
                    return;
            }
            
            if((Game.CameraEquipment.Shocker.ShockerState.CanActivate(status:  val_1)) == false)
            {
                    return;
            }
            
            if((val_1 == 1) || (isDisruptionFullyActive == true))
            {
                goto label_4;
            }
            
            if(val_1 == 0)
            {
                goto label_5;
            }
            
            if(val_1 != 2)
            {
                goto label_6;
            }
            
            val_6 = 1;
            val_7 = 0;
            goto label_7;
            label_4:
            val_7 = 1;
            val_6 = 0;
            label_7:
            label_8:
            this.ActivateEffect(onCooldown:  true, noBattery:  false, didHit:  false);
            return;
            label_5:
            bool val_3 = didHitAnimatronic;
            goto label_8;
            label_6:
            val_5 = System.String.Format(format:  "Shocker was activated with unknown status: {0}", arg0:  val_1);
            ConsoleLogger.LogError(className:  "ShockerState", functionName:  "Activate", logString:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._fxDuration.Started() != false)
            {
                    if(this._fxDuration.IsExpired() != false)
            {
                    this._fxRoot.EndEffect();
                this._fxDuration.Reset();
            }
            
            }
            
            if(this._cooldownTimer.Started() == false)
            {
                    return;
            }
            
            if(this._cooldownTimer.IsExpired() == false)
            {
                    return;
            }
            
            this._cooldownTimer.Reset();
            if((this._battery.<Charge>k__BackingField) < (this._battery.GetLargestDrain(type:  3)))
            {
                    return;
            }
            
            this._masterEventExposer.OnShockerCooldownComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)
        {
            this._encounterInProgress = true;
            this._encounterType = type;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackEncounterEnded()
        {
            this._encounterInProgress = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool CanActivate(Game.CameraEquipment.Shocker.ShockerStatus status)
        {
            var val_2;
            if(status < 3)
            {
                goto label_1;
            }
            
            if(status != 3)
            {
                goto label_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
            label_1:
            val_2 = 1;
            return (bool)val_2;
            label_2:
            System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ActivateEffect(bool onCooldown, bool noBattery, bool didHit)
        {
            if(onCooldown != true)
            {
                    bool val_1 = noBattery;
                this.ShockVibrate(noBattery:  val_1, didHit:  didHit);
                if(val_1 != true)
            {
                    this._battery.DrainForShocker();
                this._fxRoot.StartEffect(didHit:  didHit);
                this._fxDuration.StartTimer(time:  this._fxRoot.duration);
                float val_10 = this._fxRoot.duration;
                val_10 = val_10 + this._settings.ShockerCooldown;
                this._cooldownTotal = val_10;
                this._cooldownTimer.StartTimer(time:  val_10);
            }
            
            }
            
            Game.CameraEquipment.Shocker.ShockerActivation val_4 = new Game.CameraEquipment.Shocker.ShockerActivation();
            if(val_4 != null)
            {
                    .OnCooldown = onCooldown;
                .NoBattery = noBattery;
            }
            else
            {
                    mem[16] = onCooldown;
                .NoBattery = noBattery;
            }
            
            .DidHit = didHit;
            this._masterEventExposer.OnShockerActivated(shockerActivation:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShockVibrate(bool noBattery, bool didHit)
        {
            var val_2;
            if(VibrationSettings.VibrationIsEnabled() == false)
            {
                    return;
            }
            
            if(noBattery != false)
            {
                    val_2 = 4;
            }
            else
            {
                    if(didHit != false)
            {
                    val_2 = 6;
            }
            else
            {
                    val_2 = 5;
            }
            
            }
            
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  5, defaultToRegularVibrate:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShockerState(Master.EventExposer masterEventExposer, Game.Devices.DevicesDomain devicesDomain, Game.CameraEquipment.Battery.BatteryState battery)
        {
            Master.EventExposer val_6 = masterEventExposer;
            this._cooldownTimer = new SimpleTimer();
            this._fxDuration = new SimpleTimer();
            val_3 = new System.Object();
            this._masterEventExposer = val_6;
            if(val_3 == null)
            {
                    val_6 = this._masterEventExposer;
            }
            
            this._battery = battery;
            this._allPlayerDevices = devicesDomain.AllPlayerDevices;
            val_6.add_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  System.Void Game.CameraEquipment.Shocker.ShockerState::AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)));
            this._masterEventExposer.add_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void Game.CameraEquipment.Shocker.ShockerState::AttackEncounterEnded()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetConfigData(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR rawSettings)
        {
            this._settings = new Game.CameraEquipment.Shocker.ShockerSettings(rawSettings:  rawSettings);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFxRoot(ShockerFxController fxRoot)
        {
            this._fxRoot = fxRoot;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void Game.CameraEquipment.Shocker.ShockerState::AttackEncounterEnded()));
            this._masterEventExposer.remove_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  System.Void Game.CameraEquipment.Shocker.ShockerState::AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)));
            this._fxRoot = 0;
            this._battery = 0;
            this._masterEventExposer = 0;
            mem[1152921525399523032] = 0;
        }
    
    }

}
