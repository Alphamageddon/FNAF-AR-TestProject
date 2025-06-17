using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ButtonAudioInvoker : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string eventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InvokeAudio()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForModeByName(name:  this.eventName, emitter:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RetrieveAndInvokeAudio()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            if(val_1.GameAudioDomain._audioPlayerIsReady == false)
            {
                    return;
            }
            
            if(this._audioPlayer != null)
            {
                    this.InvokeAudio();
                return;
            }
            
            Master.MasterDomain val_2 = Master.MasterDomain.GetDomain();
            val_2.GameAudioDomain._audioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Game.Audio.ButtonAudioInvoker::<RetrieveAndInvokeAudio>b__3_0(Game.Audio.IAudioPlayer audioPlayer)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ButtonAudioInvoker()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <RetrieveAndInvokeAudio>b__3_0(Game.Audio.IAudioPlayer audioPlayer)
        {
            this._audioPlayer = audioPlayer;
            this.InvokeAudio();
        }
    
    }

}
