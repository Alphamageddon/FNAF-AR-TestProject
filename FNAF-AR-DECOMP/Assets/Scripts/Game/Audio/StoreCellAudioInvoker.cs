using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreCellAudioInvoker : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreCell cell;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InvokeAudio()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.RaiseGameEventForModeByName(name:  this.cell.GetAudioEventName(), emitter:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RetrieveAndInvokeAudio()
        {
            if(this._audioPlayer != null)
            {
                    this.InvokeAudio();
                return;
            }
            
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.GameAudioDomain._audioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Game.Audio.StoreCellAudioInvoker::<RetrieveAndInvokeAudio>b__3_0(Game.Audio.IAudioPlayer audioPlayer)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreCellAudioInvoker()
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
