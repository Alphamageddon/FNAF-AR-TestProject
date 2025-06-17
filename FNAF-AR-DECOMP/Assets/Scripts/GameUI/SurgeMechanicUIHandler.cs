using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SurgeMechanicUIHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SurgeMechanicUIHandlerData _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MoreMountains.NiceVibrations.HapticTypes _hapticCue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _batterySurgeBlinkDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _batterySurgeMaskLightFadeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _blinkState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _blinkStateLastFrame;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isSurgeActive;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool BlinkState { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BatterySurgeMaskLightFadeTime { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_BlinkState()
        {
            return (bool)this._blinkState;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_BatterySurgeMaskLightFadeTime()
        {
            return (float)this._batterySurgeMaskLightFadeTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SurgeMechanicUIHandler(GameUI.SurgeMechanicUIHandlerData surgeMechanicUIHandlerData)
        {
            this._data = surgeMechanicUIHandlerData;
            surgeMechanicUIHandlerData.eventExposer.add_AttackSurgeStateChanged(value:  new AttackSurge.StateChanged(object:  this, method:  System.Void GameUI.SurgeMechanicUIHandler::EventExposer_AttackSurgeStateChanged(bool state, Game.ItemDefinition.Data.DataDefinitions.SurgeData surgeSettings)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            bool val_3 = (this._isSurgeActive == true) ? 1 : 0;
            val_3 = ((UnityEngine.Time.time < 0) ? 1 : 0) & val_3;
            this._blinkState = val_3;
            if((val_3 == 1) && (this._blinkStateLastFrame != true))
            {
                    if(VibrationSettings.VibrationIsEnabled() != false)
            {
                    MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  this._hapticCue, defaultToRegularVibrate:  true);
            }
            
            }
            
            this._blinkStateLastFrame = this._blinkState;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._data.eventExposer.remove_AttackSurgeStateChanged(value:  new AttackSurge.StateChanged(object:  this, method:  System.Void GameUI.SurgeMechanicUIHandler::EventExposer_AttackSurgeStateChanged(bool state, Game.ItemDefinition.Data.DataDefinitions.SurgeData surgeSettings)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_AttackSurgeStateChanged(bool state, Game.ItemDefinition.Data.DataDefinitions.SurgeData surgeSettings)
        {
            this._isSurgeActive = state;
            if(surgeSettings != null)
            {
                    this._batterySurgeBlinkDuration = surgeSettings.BatterySurgeBlinkDuration;
                this._hapticCue = surgeSettings.HapticCue;
            }
            else
            {
                    this._batterySurgeBlinkDuration = 0f;
                this._hapticCue = 4194311;
            }
            
            this._batterySurgeMaskLightFadeTime = surgeSettings.BatterySurgeMaskLightFadeTime;
        }
    
    }

}
