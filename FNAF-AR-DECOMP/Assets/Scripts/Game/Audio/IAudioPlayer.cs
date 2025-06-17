using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAudioPlayer
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Systems.Audio.Wwise.ISoundBankLoader SoundBankLoader { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Systems.Audio.Wwise.ISoundBankLoader get_SoundBankLoader(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RegisterEmitter(Systems.Audio.Components.AkAudioEmitter emitter, Game.Audio.AudioMode mode); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void DeregisterEmitter(Systems.Audio.Components.AkAudioEmitter emitter, Game.Audio.AudioMode mode); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetGlobalMute(bool shouldMute); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetMute(Systems.Audio.Components.AkAudioEmitter emitter, bool shouldMute); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetState(string group, string state); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseGameEventForEmitter(Game.Audio.AudioEventName name, Systems.Audio.Components.AkAudioEmitter emitter); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseGameEventForEmitterWithOverride(Game.Audio.AudioEventName name, string overridePrefix, Systems.Audio.Components.AkAudioEmitter emitter); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseGameEventForModeByName(string name, Game.Audio.AudioMode emitter); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseGameEventForModeWithOverride(Game.Audio.AudioEventName name, string overridePrefix, Game.Audio.AudioMode mode); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RaiseGameEventForModeWithOverrideByName(string name, string overridePrefix, Game.Audio.AudioMode mode); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetParameterForEmitter(Game.Audio.AudioParameterName name, float value, Systems.Audio.Components.AkAudioEmitter emitter); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetParameterForMode(Game.Audio.AudioParameterName name, float value, Game.Audio.AudioMode mode); // 0
    
    }

}
