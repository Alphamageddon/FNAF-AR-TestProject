using UnityEngine;

namespace Systems.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAudioDomain
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Systems.Audio.Wwise.ISoundBankLoader SoundBankLoader { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Systems.Audio.Wwise.ISoundBankLoader get_SoundBankLoader(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Systems.Audio.Components.AkAudioEmitter MakeNewEmitter(string name); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetEmittersListener(Systems.Audio.Components.AkAudioEmitter emitter); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetListenerParent(UnityEngine.Transform parent); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetState(string group, string state); // 0
    
    }

}
