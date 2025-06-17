using UnityEngine;

namespace Game.AttackSequence.DisruptionMechanic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackDisruption
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _currentMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.DisruptionData _settings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DisruptionFxController _fxController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems _systems;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.DisruptionMechanic.ShakeDetector _shakeDetector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _timesActivated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _timesNotActivated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasReachedMaxStrength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _strength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _increasePerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _decreasePerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float MaxStrength = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isPaused;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _resumeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _cooldown;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsDisruptionFullyActive { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsDisruptionFullyActive()
        {
            if(this._isActive == false)
            {
                    return false;
            }
            
            return (bool)(this._hasReachedMaxStrength == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartDisruption(Game.ItemDefinition.Data.DataDefinitions.DisruptionData settings)
        {
            this._shakeDetector.SetConfigValues(settings:  settings);
            this._settings = settings;
            this._timesActivated = 0;
            this._timesNotActivated = 0;
            this.StartCooldownTimer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StopDisruption()
        {
            this._shakeDetector._magnitude = 2f;
            this._shakeDetector._graceTime = 7.346868E-41f;
            this.StopDisruptionEffect();
            this._settings = 0;
            this._isPaused = false;
            this._strength = 0f;
            this._fxController.SetStrength(strength:  0f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PauseDisruption()
        {
            this._resumeTime = this._cooldown.GetRemainingTime();
            this._cooldown.Reset();
            this._isPaused = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnPauseDisruption()
        {
            this._isPaused = false;
            if(this._isActive != false)
            {
                    return;
            }
            
            if(this._resumeTime > 0f)
            {
                    this._cooldown.StartTimer(time:  this._resumeTime);
                return;
            }
            
            this.StartCooldownTimer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._settings == null)
            {
                    return;
            }
            
            if(this._fxController == 0)
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
            
            this.UpdateActiveDisruption();
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
            
            if(this._isPaused != false)
            {
                    return;
            }
            
            if(this._settings.Seconds.Min == 0f)
            {
                    if(this._settings.Seconds.Max == 0f)
            {
                    return;
            }
            
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
            this._hasReachedMaxStrength = false;
            this._strength = 0f;
            if(this._settings.RampTime == 0f)
            {
                    val_2 = 1000f;
            }
            else
            {
                    val_2 = 1f / this._settings.RampTime;
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
            this._masterEventExposer.OnAttackDisruptionStateChanged(isDisruptionActive:  (this._isActive == true) ? 1 : 0, style:  this._settings.Style);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateActiveDisruption()
        {
            float val_10;
            if(this.IsCancelActionActive() != false)
            {
                    float val_2 = UnityEngine.Time.deltaTime;
                val_2 = this._decreasePerSecond * val_2;
                val_10 = this._strength - val_2;
            }
            else
            {
                    float val_3 = UnityEngine.Time.deltaTime;
                val_3 = this._increasePerSecond * val_3;
                val_10 = this._strength + val_3;
            }
            
            this._strength = val_10;
            bool val_4 = (this._hasReachedMaxStrength == true) ? 1 : 0;
            val_4 = ((val_10 >= 1f) ? 1 : 0) | val_4;
            this._hasReachedMaxStrength = val_4;
            this._strength = UnityEngine.Mathf.Clamp(value:  val_10, min:  0f, max:  1f);
            if((UnityEngine.Object.op_Implicit(exists:  this._fxController)) != false)
            {
                    this._fxController.useFrostDisruption = (this._settings.Style == 1) ? 1 : 0;
                val_10 = 0f;
                if(this._currentMode == 1)
            {
                    val_10 = this._strength;
            }
            
                this._fxController.SetStrength(strength:  val_10);
            }
            
            if(this._strength > 0f)
            {
                    return;
            }
            
            this.StopDisruptionEffect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsCancelActionActive()
        {
            Game.AttackSequence.DisruptionMechanic.ShakeDetector val_3;
            var val_4;
            val_3 = this;
            if(this._settings.CancelAction == 1)
            {
                goto label_2;
            }
            
            if(this._settings.CancelAction != 0)
            {
                goto label_3;
            }
            
            val_3 = this._shakeDetector;
            var val_1 = ((this._shakeDetector.<IsShaking>k__BackingField) == true) ? 1 : 0;
            return (bool)val_4;
            label_2:
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this._systems.Mask.IsMaskFullyOn();
            label_3:
            val_4 = 1;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StopDisruptionEffect()
        {
            this._isActive = false;
            this._hasReachedMaxStrength = false;
            this.StartCooldownTimer();
            if(this._isActive == false)
            {
                    return;
            }
            
            this._masterEventExposer.OnAttackDisruptionStateChanged(isDisruptionActive:  (this._isActive == true) ? 1 : 0, style:  this._settings.Style);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackDisruption(Master.EventExposer masterEventExposer, Game.AttackSequence.DisruptionMechanic.ShakeDetector shakeDetector)
        {
            this._cooldown = new SimpleTimer();
            val_2 = new System.Object();
            this._masterEventExposer = masterEventExposer;
            this._shakeDetector = val_2;
            masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.DisruptionMechanic.AttackDisruption::GameDisplayChanged(TheGame.GameDisplayData args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(DisruptionFxController fxController, Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems systems)
        {
            this._fxController = fxController;
            this._systems = systems;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.DisruptionMechanic.AttackDisruption::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._shakeDetector = 0;
            this._masterEventExposer = 0;
            this._settings = 0;
            this._fxController = 0;
        }
    
    }

}
