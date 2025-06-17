using UnityEngine;

namespace Game.AttackSequence.SurgeMechanic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackSurge
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _currentMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.SurgeData _settings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems _systems;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _timesActivated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _timesNotActivated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _cancelingAccruedDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _increasePerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _decreasePerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float MaxCancelling = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _cooldown;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartSurge(Game.ItemDefinition.Data.DataDefinitions.SurgeData settings)
        {
            this._settings = settings;
            this._timesActivated = 0;
            this._timesNotActivated = 0;
            this._cancelingAccruedDuration = 0f;
            this.StartCooldownTimer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StopSurge()
        {
            this.StopSurgeEffect();
            this._settings = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._settings == null)
            {
                    return;
            }
            
            if(this._cooldown.Started() != false)
            {
                    if(this._cooldown.IsExpired() != false)
            {
                    this._cooldown.Reset();
                this.TryToActivate();
            }
            
            }
            
            if(this._isActive == false)
            {
                    return;
            }
            
            this.UpdateActiveSurge();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameDisplayChanged(TheGame.GameDisplayData args)
        {
            this._currentMode = args.currentDisplay;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartCooldownTimer()
        {
            if(this._settings == null)
            {
                    return;
            }
            
            if((this._settings.Seconds.Min == 0f) && (this._settings.Seconds.Max == 0f))
            {
                    return;
            }
            
            this._cooldown.StartTimer(time:  UnityEngine.Random.Range(min:  this._settings.Seconds.Min, max:  this._settings.Seconds.Max));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToActivate()
        {
            float val_4;
            float val_2 = this._settings.ActivationChance.Modifier;
            if(this._settings.ActivationChance.Modifier < 0f)
            {
                    val_2 = val_2 * (float)this._timesActivated;
                val_4 = this._settings.ActivationChance.Chance - val_2;
            }
            else
            {
                    val_2 = val_2 * (float)this._timesNotActivated;
                val_4 = this._settings.ActivationChance.Chance + val_2;
            }
            
            if((UnityEngine.Random.Range(min:  0.0001f, max:  1f)) > val_4)
            {
                    this.StartCooldownTimer();
                int val_3 = this._timesNotActivated;
                val_3 = val_3 + 1;
                this._timesNotActivated = val_3;
                return;
            }
            
            this.Activate();
            int val_4 = this._timesActivated;
            val_4 = val_4 + 1;
            this._timesActivated = val_4;
            this._timesNotActivated = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Activate()
        {
            float val_2;
            float val_3;
            this._isActive = true;
            this._cancelingAccruedDuration = 0f;
            if(this._settings.CancelTime == 0f)
            {
                    val_2 = 1000f;
            }
            else
            {
                    val_2 = 1f / this._settings.CancelTime;
            }
            
            this._increasePerSecond = val_2;
            if(this._settings.CancelTime == 0f)
            {
                    val_3 = 1000f;
            }
            else
            {
                    val_3 = 1f / this._settings.CancelTime;
            }
            
            this._decreasePerSecond = val_3;
            this._masterEventExposer.OnAttackSurgeStateChanged(isSurgeActive:  (this._isActive == true) ? 1 : 0, surgeSettings:  this._settings);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateActiveSurge()
        {
            Game.CameraEquipment.Battery.IBattery val_8;
            float val_11;
            var val_12;
            var val_13;
            if(this.IsCancelActionActive() != false)
            {
                    float val_2 = UnityEngine.Time.deltaTime;
                val_2 = this._increasePerSecond * val_2;
                val_2 = this._cancelingAccruedDuration + val_2;
                this._cancelingAccruedDuration = val_2;
                val_8 = this._systems.Battery;
                val_11 = UnityEngine.Time.deltaTime * this._settings.BatteryDrainRateCancel;
                val_12 = null;
                var val_8 = 0;
                val_13 = 1152921505274773512;
                val_8 = val_8 + 1;
            }
            else
            {
                    float val_4 = UnityEngine.Time.deltaTime;
                val_4 = this._decreasePerSecond * val_4;
                val_4 = this._cancelingAccruedDuration - val_4;
                this._cancelingAccruedDuration = val_4;
                val_8 = this._systems.Battery;
                val_11 = UnityEngine.Time.deltaTime * this._settings.BatteryDrainRateBase;
                val_12 = null;
                var val_9 = 0;
                val_13 = 1152921505274773512;
                val_9 = val_9 + 1;
            }
            
            val_8.DrainCharge(drainAmount:  val_11);
            float val_7 = UnityEngine.Mathf.Clamp(value:  this._cancelingAccruedDuration, min:  0f, max:  1f);
            this._cancelingAccruedDuration = val_7;
            if(val_7 < 1f)
            {
                    return;
            }
            
            this.StopSurgeEffect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsCancelActionActive()
        {
            if(this._settings.CancelAction != 0)
            {
                    return true;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this._systems.Mask.IsMaskFullyOn();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StopSurgeEffect()
        {
            this._isActive = false;
            this.StartCooldownTimer();
            if(this._isActive == false)
            {
                    return;
            }
            
            this._masterEventExposer.OnAttackSurgeStateChanged(isSurgeActive:  (this._isActive == true) ? 1 : 0, surgeSettings:  this._settings);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackSurge(Master.EventExposer masterEventExposer)
        {
            this._cooldown = new SimpleTimer();
            this._masterEventExposer = masterEventExposer;
            masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.SurgeMechanic.AttackSurge::GameDisplayChanged(TheGame.GameDisplayData args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems systems)
        {
            this._systems = systems;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.SurgeMechanic.AttackSurge::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._settings = 0;
            this._masterEventExposer = 0;
        }
    
    }

}
