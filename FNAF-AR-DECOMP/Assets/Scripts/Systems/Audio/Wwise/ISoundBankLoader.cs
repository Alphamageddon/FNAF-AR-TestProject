using UnityEngine;

namespace Systems.Audio.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ISoundBankLoader
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RequestSoundBank(Systems.Audio.Wwise.SoundBankRequest request); // 0
    
    }

}
