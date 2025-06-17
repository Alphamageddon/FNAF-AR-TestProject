using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameObjectAudioInvoker : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string enableEventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string disableEventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string modeName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isLoopingAudio;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isLoopPlaying;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            if(Master.MasterDomain.GetDomain() == 0)
            {
                    return;
            }
            
            val_1.GameAudioDomain._audioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Game.Audio.GameObjectAudioInvoker::PlayEnableEvent(Game.Audio.IAudioPlayer audioPlayer)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            if(Master.MasterDomain.GetDomain() == 0)
            {
                    return;
            }
            
            val_1.GameAudioDomain._audioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Game.Audio.GameObjectAudioInvoker::PlayDisableEvent(Game.Audio.IAudioPlayer audioPlayer)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlayEnableEvent(Game.Audio.IAudioPlayer audioPlayer)
        {
            Game.Audio.AudioMode val_6;
            string val_7;
            var val_9;
            var val_10;
            bool val_2 = System.Enum.TryParse<Game.Audio.AudioMode>(value:  this.modeName, ignoreCase:  true, result: out  0);
            val_6 = this.gameObject;
            if(val_6.activeInHierarchy == false)
            {
                    return;
            }
            
            if(this.isLoopingAudio != false)
            {
                    if(this._isLoopPlaying == true)
            {
                    return;
            }
            
                this._isLoopPlaying = true;
                val_7 = this.enableEventName;
                val_6 = 1;
                val_9 = null;
                var val_6 = 0;
                val_10 = 1152921505275252744;
                val_6 = val_6 + 1;
            }
            else
            {
                    val_7 = this.enableEventName;
                val_6 = 1;
                val_9 = null;
                var val_7 = 0;
                val_10 = 1152921505275252744;
                val_7 = val_7 + 1;
            }
            
            audioPlayer.RaiseGameEventForModeByName(name:  val_7, emitter:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlayDisableEvent(Game.Audio.IAudioPlayer audioPlayer)
        {
            Game.Audio.AudioMode val_4;
            Game.Audio.AudioMode val_1 = 0;
            val_4 = 1;
            if((System.Enum.TryParse<Game.Audio.AudioMode>(value:  this.modeName, ignoreCase:  true, result: out  val_1)) != false)
            {
                    val_4 = val_1;
            }
            
            this._isLoopPlaying = false;
            var val_4 = 0;
            val_4 = val_4 + 1;
            audioPlayer.RaiseGameEventForModeByName(name:  this.disableEventName, emitter:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameObjectAudioInvoker()
        {
        
        }
    
    }

}
