using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Movement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Footsteps
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Movement.Footsteps.FootstepEffectTriggered OnFootstepEffectTriggered;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Audio.AudioDispatcher _audioDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData _walkConfigData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData _runConfigData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _mode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _distanceFromCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isWalking;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _nextEffect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData _nextConfigData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnFootstepEffectTriggered(Animatronics.Animatronic3d.Model.Movement.Footsteps.FootstepEffectTriggered value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnFootstepEffectTriggered, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnFootstepEffectTriggered != 1152921525076826704);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnFootstepEffectTriggered(Animatronics.Animatronic3d.Model.Movement.Footsteps.FootstepEffectTriggered value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnFootstepEffectTriggered, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnFootstepEffectTriggered != 1152921525076963280);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFootstepConfig(Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData walkConfigData, Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData runConfigData)
        {
            this._walkConfigData = walkConfigData;
            this._runConfigData = runConfigData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMovementMode(bool isWalking)
        {
            this._isWalking = isWalking;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerFootstep()
        {
            this._audioDispatcher.RaiseEventFromPlushSuit(eventName:  (this._isWalking == true) ? (7 + 1) : 7);
            Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData val_2 = (this._isWalking == true) ? this._walkConfigData : this._runConfigData;
            this._nextConfigData = val_2;
            if(val_2 == 0)
            {
                goto label_1;
            }
            
            if(this._nextEffect != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            this._nextEffect.StartTimer(time:  this._isWalking == true ? this._walkConfigData : this._runConfigData + 16);
            return;
            label_1:
            if(this._nextEffect != null)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(float distanceFromCamera)
        {
            this._distanceFromCamera = distanceFromCamera;
            this.UpdateFootstepEffects();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterEventExposerOnGameDisplayChange(TheGame.GameDisplayData args)
        {
            this._mode = args.currentDisplay;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateFootstepEffects()
        {
            MoreMountains.NiceVibrations.HapticTypes val_10;
            Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData val_11;
            float val_12;
            var val_14;
            Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData val_15;
            float val_16;
            Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData val_17;
            float val_18;
            Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData val_19;
            float val_20;
            Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData val_21;
            float val_22;
            if(this._nextEffect.Started() == false)
            {
                    return;
            }
            
            if(this._nextEffect.IsExpired() == false)
            {
                    return;
            }
            
            this._nextEffect.Reset();
            if(this.OnFootstepEffectTriggered != null)
            {
                    this.OnFootstepEffectTriggered.Invoke(isWalking:  this._isWalking);
            }
            
            if(this._mode != 1)
            {
                    return;
            }
            
            if(VibrationSettings.VibrationIsEnabled() != false)
            {
                    if(this._nextConfigData != null)
            {
                    val_10 = this._nextConfigData.VibrationType;
            }
            else
            {
                    val_10 = 7;
            }
            
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  val_10, defaultToRegularVibrate:  true);
            }
            
            val_11 = this._nextConfigData;
            if(val_11 != null)
            {
                    val_11 = this._nextConfigData.CameraShake;
                if(val_11 != null)
            {
                    val_12 = this._nextConfigData.CameraShake.FadeOut;
                val_11 = 0;
            }
            
            }
            
            if(((-1003925112) & 1) == 0)
            {
                    return;
            }
            
            if(val_11.distance <= 0f)
            {
                    return;
            }
            
            val_14 = null;
            val_14 = null;
            val_15 = this._nextConfigData;
            if(val_15 != null)
            {
                    val_15 = this._nextConfigData.CameraShake;
                if(val_15 != null)
            {
                    val_12 = this._nextConfigData.CameraShake.Magnitude;
                val_15 = 0;
            }
            
            }
            
            val_16 = 0f;
            if(((-1003925112) & 1) != 0)
            {
                    val_16 = val_15.distance;
            }
            
            val_17 = this._nextConfigData;
            if(val_17 != null)
            {
                    val_17 = this._nextConfigData.CameraShake;
                if(val_17 != null)
            {
                    val_12 = this._nextConfigData.CameraShake.Roughness;
                val_17 = 0;
            }
            
            }
            
            val_18 = 0f;
            if(((-1003925112) & 1) != 0)
            {
                    val_18 = val_17.distance;
            }
            
            val_19 = this._nextConfigData;
            if(val_19 != null)
            {
                    val_19 = this._nextConfigData.CameraShake;
                if(val_19 != null)
            {
                    val_12 = this._nextConfigData.CameraShake.FadeIn;
                val_19 = 0;
            }
            
            }
            
            val_20 = 0f;
            if(((-1003925112) & 1) != 0)
            {
                    val_20 = val_19.distance;
            }
            
            val_21 = this._nextConfigData;
            if(val_21 != null)
            {
                    val_21 = this._nextConfigData.CameraShake;
                if(val_21 != null)
            {
                    val_12 = this._nextConfigData.CameraShake.FadeOut;
                val_21 = 0;
            }
            
            }
            
            val_22 = 0f;
            if(((-1003925112) & 1) != 0)
            {
                    val_22 = val_21.distance;
            }
            
            EZCameraShake.CameraShakeInstance val_9 = EZCameraShake.CameraShaker.Instance.ShakeOnce(magnitude:  val_16, roughness:  val_18, fadeInTime:  val_20, fadeOutTime:  val_22);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Footsteps(Master.EventExposer masterEventExposer, Animatronics.Animatronic3d.Model.Audio.AudioDispatcher audioDispatcher, TheGame.GameDisplayData.DisplayType mode)
        {
            this._nextEffect = new SimpleTimer();
            val_2 = new System.Object();
            this._masterEventExposer = masterEventExposer;
            this._audioDispatcher = val_2;
            this._mode = mode;
            if(masterEventExposer == null)
            {
                    return;
            }
            
            masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Movement.Footsteps::MasterEventExposerOnGameDisplayChange(TheGame.GameDisplayData args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this._masterEventExposer != null)
            {
                    this._masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Animatronics.Animatronic3d.Model.Movement.Footsteps::MasterEventExposerOnGameDisplayChange(TheGame.GameDisplayData args)));
            }
            
            this._masterEventExposer = 0;
            this._audioDispatcher = 0;
            this.OnFootstepEffectTriggered = 0;
        }
    
    }

}
