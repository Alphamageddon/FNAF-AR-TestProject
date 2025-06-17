using UnityEngine;

namespace Game.CameraEquipment.Battery
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BatteryState : IBattery
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ChargeKey = "BatteryLevel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string TimestampKey = "BatteryTimestamp";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float MinCharge = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float MaxCharge = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <Charge>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Devices.DevicesDomain _devicesDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.DeviceRequester _deviceRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Battery.BatterySettings _settings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Battery.ExtraBatterySettings _extraBatterySettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.BatteryData> _drainSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasOfflineCatchUpCompleted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _lastTimestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _mode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isEncounterInProgress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _batteryDrainedLastFrame;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _extraBatteryBlocked;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numExtraBatteriesUsed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _extraBatteryRechargePerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _extraBatteryDelay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _extraBatteryTimer;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Charge { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumExtraBatteriesUsed { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Charge()
        {
            return (float)this.<Charge>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Charge(float value)
        {
            this.<Charge>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumExtraBatteriesUsed()
        {
            return (int)this._numExtraBatteriesUsed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsExtraBatteryAvailableForUse()
        {
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_5;
            var val_6;
            val_5 = this;
            if(((this._settings != null) && (this._extraBatterySettings != null)) && (this._numExtraBatteriesUsed < ((this._settings.AllowedExtraBatteries >= 0) ? this._settings.AllowedExtraBatteries : 2147483647)))
            {
                    if((this._devicesDomain.AllPlayerDevices.purchased.ContainsKey(key:  "ExtraBattery")) != false)
            {
                    val_5 = this._devicesDomain.AllPlayerDevices.purchased;
                var val_4 = (val_5.Item["ExtraBattery"] > 0) ? 1 : 0;
                return (bool)val_6;
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsExtraBatteryActive()
        {
            return (bool)(this._extraBatteryTimer.GetRemainingTime() > 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetExtraBatteryBlocker(bool isBlocked)
        {
            this._extraBatteryBlocked = isBlocked;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetBatteryDrain(string id, Game.ItemDefinition.Data.DataDefinitions.BatteryData drainSettings)
        {
            if((this._drainSettings.ContainsKey(key:  id)) != false)
            {
                    return;
            }
            
            this._drainSettings.Add(key:  id, value:  drainSettings);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveBatteryDrain(string id)
        {
            if((this._drainSettings.ContainsKey(key:  id)) != false)
            {
                    return;
            }
            
            bool val_2 = this._drainSettings.Remove(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DrainCharge(float drainAmount)
        {
            drainAmount = (this.<Charge>k__BackingField) - drainAmount;
            this.SetCharge(newChargeValue:  drainAmount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RestoreCharge(float restoreAmount)
        {
            restoreAmount = (this.<Charge>k__BackingField) + restoreAmount;
            this.SetCharge(newChargeValue:  restoreAmount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEnoughChargeToActivateFlashlight()
        {
            if(this._settings == null)
            {
                    return false;
            }
            
            if(this._isEncounterInProgress != false)
            {
                    float val_1 = this.GetLargestDrain(type:  1);
                return (bool)((this.<Charge>k__BackingField) >= 0f) ? 1 : 0;
            }
            
            return (bool)((this.<Charge>k__BackingField) >= 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DrainForFlashlightActivation()
        {
            if(this._isEncounterInProgress != false)
            {
                    float val_1 = this.GetLargestDrain(type:  1);
            }
            else
            {
                    float val_2 = 0f;
            }
            
            val_2 = (this.<Charge>k__BackingField) - val_2;
            this.SetCharge(newChargeValue:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DrainForActiveFlashlight()
        {
            float val_4;
            var val_5;
            if(this._settings != null)
            {
                    if(this._mode != 1)
            {
                    if(this._mode != 7)
            {
                goto label_2;
            }
            
            }
            
                float val_2 = this.GetFlashlightActiveDrain();
                val_4 = this;
                val_2 = UnityEngine.Time.deltaTime * val_2;
                val_2 = (this.<Charge>k__BackingField) - val_2;
                this.SetCharge(newChargeValue:  val_2);
                this._batteryDrainedLastFrame = true;
                return (bool)(val_4 > 0f) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)(val_4 > 0f) ? 1 : 0;
            label_2:
            val_4 = this.<Charge>k__BackingField;
            return (bool)(val_4 > 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEnoughChargeToActivateShocker()
        {
            return (bool)((this.<Charge>k__BackingField) >= (this.GetLargestDrain(type:  3))) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DrainForShocker()
        {
            float val_1 = this.GetLargestDrain(type:  3);
            val_1 = (this.<Charge>k__BackingField) - val_1;
            this.SetCharge(newChargeValue:  val_1);
            this._extraBatteryDelay.StartTimer(time:  0.01f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._settings == null)
            {
                    return;
            }
            
            if(this._hasOfflineCatchUpCompleted == false)
            {
                    return;
            }
            
            this.UpdateStandardBattery();
            this.UpdateExtraBattery();
            this.SaveCharge();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateStandardBattery()
        {
            var val_4;
            if(this._isEncounterInProgress != false)
            {
                    float val_2 = UnityEngine.Time.deltaTime;
                val_2 = (this.GetLargestDrain(type:  0)) * val_2;
                val_2 = (this.<Charge>k__BackingField) - val_2;
                this.SetCharge(newChargeValue:  val_2);
                this._batteryDrainedLastFrame = true;
                val_4 = 1152921525406302269;
            }
            else
            {
                    val_4 = this;
                if(this._batteryDrainedLastFrame != true)
            {
                    float val_4 = this._settings.BaseRecharge;
                val_4 = UnityEngine.Time.deltaTime * val_4;
                val_4 = (this.<Charge>k__BackingField) + val_4;
                this.SetCharge(newChargeValue:  val_4);
            }
            
            }
            
            this._batteryDrainedLastFrame = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateExtraBattery()
        {
            Game.CameraEquipment.Battery.ExtraBatteryStateChange val_14;
            var val_15;
            var val_16;
            float val_17;
            Game.CameraEquipment.Battery.ExtraBatterySettings val_18;
            Master.EventExposer val_19;
            if(this._isEncounterInProgress != false)
            {
                    var val_1 = (this._mode == 1) ? 1 : 0;
            }
            else
            {
                    val_14 = 0;
            }
            
            if(this._extraBatterySettings != null)
            {
                    var val_2 = ((this.<Charge>k__BackingField) < 0) ? 1 : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            if(this._extraBatteryBlocked != false)
            {
                    val_16 = 0;
            }
            else
            {
                    val_16 = this.IsExtraBatteryAvailableForUse();
            }
            
            if(this._extraBatteryTimer.Started() == false)
            {
                goto label_8;
            }
            
            if(this._extraBatteryTimer.IsExpired() == false)
            {
                goto label_21;
            }
            
            this._extraBatteryRechargePerSecond = 0f;
            this._extraBatteryTimer.Reset();
            Game.CameraEquipment.Battery.ExtraBatteryStateChange val_6 = null;
            val_14 = val_6;
            val_6 = new Game.CameraEquipment.Battery.ExtraBatteryStateChange();
            .IsExtraBatteryRunning = false;
            this._masterEventExposer.OnExtraBatteryStateChanged(extraBatteryStateChange:  val_6);
            goto label_21;
            label_8:
            if(this._extraBatteryDelay.Started() == false)
            {
                goto label_16;
            }
            
            if(this._extraBatteryDelay.IsExpired() == false)
            {
                goto label_21;
            }
            
            this._extraBatteryDelay.Reset();
            goto label_21;
            label_16:
            var val_9 = val_15 & val_14;
            val_9 = val_9 & val_16;
            if(val_9 == false)
            {
                goto label_21;
            }
            
            if(this._extraBatterySettings == null)
            {
                goto label_22;
            }
            
            val_17 = this._extraBatterySettings.TotalRecharge;
            if(this._extraBatterySettings.Duration <= 0f)
            {
                goto label_23;
            }
            
            label_31:
            val_18 = this._extraBatterySettings;
            if(this._extraBatterySettings == null)
            {
                    val_18 = this._extraBatterySettings;
            }
            
            float val_14 = this._extraBatterySettings.Duration;
            val_14 = val_17 / val_14;
            this._extraBatteryRechargePerSecond = val_14;
            val_17 = this._extraBatterySettings.Duration;
            this._extraBatteryTimer.StartTimer(time:  val_17);
            val_19 = this._masterEventExposer;
            Game.CameraEquipment.Battery.ExtraBatteryStateChange val_10 = null;
            val_14 = val_10;
            val_10 = new Game.CameraEquipment.Battery.ExtraBatteryStateChange();
            .IsExtraBatteryRunning = true;
            if(val_19 != null)
            {
                goto label_35;
            }
            
            goto label_29;
            label_22:
            val_17 = this._extraBatterySettings.TotalRecharge;
            if(this._extraBatterySettings.Duration > 0f)
            {
                goto label_31;
            }
            
            label_23:
            float val_15 = this.<Charge>k__BackingField;
            val_15 = val_17 + val_15;
            this.SetCharge(newChargeValue:  val_15);
            .IsExtraBatteryRunning = true;
            this._masterEventExposer.OnExtraBatteryStateChanged(extraBatteryStateChange:  new Game.CameraEquipment.Battery.ExtraBatteryStateChange());
            val_19 = this._masterEventExposer;
            Game.CameraEquipment.Battery.ExtraBatteryStateChange val_12 = null;
            val_14 = val_12;
            val_12 = new Game.CameraEquipment.Battery.ExtraBatteryStateChange();
            .IsExtraBatteryRunning = false;
            if(val_19 != null)
            {
                goto label_35;
            }
            
            label_29:
            label_35:
            val_19.OnExtraBatteryStateChanged(extraBatteryStateChange:  val_12);
            this._deviceRequester.ActivateDevice(deviceConfigId:  "ExtraBattery");
            int val_16 = this._numExtraBatteriesUsed;
            val_16 = val_16 + 1;
            this._numExtraBatteriesUsed = val_16;
            label_21:
            if(this._extraBatteryRechargePerSecond <= 0f)
            {
                    return;
            }
            
            float val_13 = UnityEngine.Time.deltaTime;
            val_13 = val_13 * this._extraBatteryRechargePerSecond;
            val_13 = (this.<Charge>k__BackingField) + val_13;
            this.SetCharge(newChargeValue:  val_13);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SaveCharge()
        {
            long val_1 = TheGame.ServerTime.GetCurrentTime();
            if(val_1 == this._lastTimestamp)
            {
                    return;
            }
            
            this._lastTimestamp = val_1;
            UnityEngine.PlayerPrefs.SetFloat(key:  "BatteryLevel", value:  this.<Charge>k__BackingField);
            UnityEngine.PlayerPrefs.SetString(key:  "BatteryTimestamp", value:  this._lastTimestamp.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameDisplayChanged(TheGame.GameDisplayData args)
        {
            this._mode = args.currentDisplay;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)
        {
            this._extraBatteryBlocked = false;
            this._isEncounterInProgress = true;
            this._numExtraBatteriesUsed = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackEncounterEnded()
        {
            this._isEncounterInProgress = false;
            this._extraBatteryBlocked = false;
            this._numExtraBatteriesUsed = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EntityFastForwardComplete(AnimatronicEntity.FastForwardCompleteArgs args)
        {
            float val_10;
            Game.CameraEquipment.Battery.BatterySettings val_12;
            var val_13;
            this.<Charge>k__BackingField = UnityEngine.PlayerPrefs.GetFloat(key:  "BatteryLevel", defaultValue:  0f);
            long val_2 = TheGame.ServerTime.GetCurrentTime();
            long val_5 = System.Convert.ToInt64(value:  UnityEngine.PlayerPrefs.GetString(key:  "BatteryTimestamp", defaultValue:  val_2.ToString()));
            this._lastTimestamp = val_5;
            if((this.<Charge>k__BackingField) > 0f)
            {
                    val_10 = ((float)val_2 - val_5) - args.TimeSpentInCombat;
                val_12 = this._settings;
                if(val_12 != null)
            {
                    val_10 = this._settings.BaseRecharge;
                val_12 = 0;
            }
            
                if(((-674487680) & 1) != 0)
            {
                    float val_8 = val_12.distance;
                val_8 = (UnityEngine.Mathf.Max(a:  val_10, b:  0f)) * val_8;
                val_13 = 0;
            }
            else
            {
                    val_13 = 0;
            }
            
                if(((-674487672) & 1) != 0)
            {
                    float val_9 = val_13.distance;
            }
            
                val_9 = val_9 + (this.<Charge>k__BackingField);
                this.SetCharge(newChargeValue:  val_9);
            }
            
            this._hasOfflineCatchUpCompleted = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCharge(float newChargeValue)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  newChargeValue, min:  0f, max:  1f);
            if((this.<Charge>k__BackingField) == val_1)
            {
                    return;
            }
            
            this.<Charge>k__BackingField = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetFlashlightActivationDrain()
        {
            if(this._isEncounterInProgress == false)
            {
                    return 0f;
            }
            
            return this.GetLargestDrain(type:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetFlashlightActiveDrain()
        {
            if(this._isEncounterInProgress != false)
            {
                    return this.GetLargestDrain(type:  2);
            }
            
            if(this._settings != null)
            {
                    return (float)this._settings.EssenceFlashlightDrain;
            }
            
            return (float)this._settings.EssenceFlashlightDrain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetLargestDrain(Game.CameraEquipment.Battery.DrainType type)
        {
            var val_4;
            var val_9;
            Master.MasterDomain val_10;
            val_9 = type;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._drainSettings.Values.GetEnumerator();
            label_17:
            if(((-673977264) & 1) == 0)
            {
                    return 0f;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            if(val_9 > 4)
            {
                goto label_4;
            }
            
            var val_9 = 52947292 + (type) << 2;
            val_9 = val_9 + 52947292;
            goto (52947292 + (type) << 2 + 52947292);
            label_4:
            val_10 = 0f;
            float val_6 = UnityEngine.Mathf.Max(a:  0f, b:  null);
            goto label_17;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BatteryState(Master.EventExposer masterEventExposer, Game.Devices.DevicesDomain devicesDomain, Game.Server.ServerDomain serverDomain)
        {
            this._mode = 6;
            this._extraBatteryDelay = new SimpleTimer();
            this._extraBatteryTimer = new SimpleTimer();
            val_3 = new System.Object();
            this.<Charge>k__BackingField = 0f;
            this._masterEventExposer = masterEventExposer;
            this._devicesDomain = val_3;
            this._deviceRequester = serverDomain.deviceRequester;
            this._drainSettings = new System.Collections.Generic.Dictionary<System.String, Game.ItemDefinition.Data.DataDefinitions.BatteryData>();
            this._masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.CameraEquipment.Battery.BatteryState::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._masterEventExposer.add_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  System.Void Game.CameraEquipment.Battery.BatteryState::AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)));
            this._masterEventExposer.add_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void Game.CameraEquipment.Battery.BatteryState::AttackEncounterEnded()));
            this._masterEventExposer.add_EntityFastForwardComplete(value:  new System.Action<AnimatronicEntity.FastForwardCompleteArgs>(object:  this, method:  System.Void Game.CameraEquipment.Battery.BatteryState::EntityFastForwardComplete(AnimatronicEntity.FastForwardCompleteArgs args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetConfigData(ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR rawSettings)
        {
            this._settings = new Game.CameraEquipment.Battery.BatterySettings(rawSettings:  rawSettings);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDevicesData(ProtoData.DEVICES_DATA devicesData)
        {
            string val_17;
            var val_18;
            var val_19;
            System.Collections.Generic.IEnumerator<T> val_2 = devicesData.Entries.GetEnumerator();
            label_20:
            label_16:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            T val_6 = val_2.Current;
            if(val_6 != 0)
            {
                    string val_7 = val_6.DeviceLogical;
            }
            else
            {
                    val_17 = 0;
            }
            
            if((System.String.IsNullOrWhiteSpace(value:  val_17)) == true)
            {
                goto label_16;
            }
            
            bool val_10 = System.String.op_Equality(a:  val_6.DeviceLogical, b:  "ExtraBattery");
            var val_11 = (val_6 != 0) ? 1 : 0;
            val_11 = val_11 & val_10;
            var val_12 = (val_10 != true) ? 0 : 0;
            if(val_11 == false)
            {
                goto label_20;
            }
            
            EFFECTS val_13 = val_6.Effects;
            if(val_13 == null)
            {
                goto label_20;
            }
            
            EXTRABATTERY val_14 = val_13.ExtraBattery;
            goto label_20;
            label_8:
            val_18 = 0;
            val_19 = 105;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_2.Dispose();
            }
            
            this._extraBatterySettings = new Game.CameraEquipment.Battery.ExtraBatterySettings(rawSettings:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_EntityFastForwardComplete(value:  new System.Action<AnimatronicEntity.FastForwardCompleteArgs>(object:  this, method:  System.Void Game.CameraEquipment.Battery.BatteryState::EntityFastForwardComplete(AnimatronicEntity.FastForwardCompleteArgs args)));
            this._masterEventExposer.remove_AttackEncounterEnded(value:  new System.Action(object:  this, method:  System.Void Game.CameraEquipment.Battery.BatteryState::AttackEncounterEnded()));
            this._masterEventExposer.remove_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  System.Void Game.CameraEquipment.Battery.BatteryState::AttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)));
            this._masterEventExposer.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.CameraEquipment.Battery.BatteryState::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._drainSettings.Clear();
            mem[1152921525408451120] = 0;
            mem[1152921525408451128] = 0;
            this._masterEventExposer = 0;
            this._extraBatterySettings = 0;
            this._drainSettings = 0;
        }
    
    }

}
