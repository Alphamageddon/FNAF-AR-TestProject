using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AudioDispatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _cpuSoundBankName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _plushSuitSoundBankName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Audio.Components.AkAudioEmitter _akAudioEmitter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.AudioMode _audioMode;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseGameEventCamera(Game.Audio.AudioEventName eventName, bool useCpu)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.RaiseGameEventForModeWithOverride(name:  eventName, overridePrefix:  (useCpu != true) ? this._cpuSoundBankName : this._plushSuitSoundBankName, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseGameEventGlobal(Game.Audio.AudioEventName eventName, bool useCpu)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.RaiseGameEventForModeWithOverride(name:  eventName, overridePrefix:  (useCpu != true) ? this._cpuSoundBankName : this._plushSuitSoundBankName, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseEventFromCpu(Game.Audio.AudioEventName eventName)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForEmitterWithOverride(name:  eventName, overridePrefix:  this._cpuSoundBankName, emitter:  this._akAudioEmitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseEventFromPlushSuit(Game.Audio.AudioEventName eventName)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForEmitterWithOverride(name:  eventName, overridePrefix:  this._plushSuitSoundBankName, emitter:  this._akAudioEmitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetParameter(Game.Audio.AudioParameterName parameterName, float value)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.SetParameterForEmitter(name:  parameterName, value:  value, emitter:  this._akAudioEmitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMute(bool shouldMute)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.SetMute(emitter:  this._akAudioEmitter, shouldMute:  shouldMute);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SoundEventReceived(UnityEngine.AnimationEvent animationEvent)
        {
            Game.Audio.AudioEventName val_6;
            Game.Audio.AudioEventName val_3 = 0;
            if(animationEvent.intParameter != 3000)
            {
                    return;
            }
            
            if((System.Enum.TryParse<Game.Audio.AudioEventName>(value:  animationEvent.stringParameter, result: out  val_3)) == false)
            {
                    return;
            }
            
            val_6 = val_3;
            this = this._akAudioEmitter;
            var val_6 = 0;
            val_6 = val_6 + 1;
            this._audioPlayer.RaiseGameEventForEmitterWithOverride(name:  val_6, overridePrefix:  this._plushSuitSoundBankName, emitter:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(string cpuSoundBankName, string plushSuitSoundBankName, Game.Audio.IAudioPlayer audioPlayer, Systems.Audio.Components.AkAudioEmitter akAudioEmitter, Game.Audio.AudioMode audioMode)
        {
            this._cpuSoundBankName = cpuSoundBankName;
            this._plushSuitSoundBankName = plushSuitSoundBankName;
            this._audioPlayer = audioPlayer;
            this._akAudioEmitter = akAudioEmitter;
            this._audioMode = audioMode;
            var val_2 = 0;
            val_2 = val_2 + 1;
            audioPlayer.RegisterEmitter(emitter:  akAudioEmitter, mode:  audioMode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.DeregisterEmitter(emitter:  this._akAudioEmitter, mode:  this._audioMode);
            this._akAudioEmitter.Teardown();
            this._audioPlayer = 0;
            this._akAudioEmitter = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AudioDispatcher()
        {
        
        }
    
    }

}
