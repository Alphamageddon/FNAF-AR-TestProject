using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextChangeAudioInvoker : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string eventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _lastText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _textMesh;
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
        private void RetrieveAndInvokeAudio()
        {
            if(this._audioPlayer != null)
            {
                    this.InvokeAudio();
                return;
            }
            
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.GameAudioDomain._audioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Game.Audio.TextChangeAudioInvoker::<RetrieveAndInvokeAudio>b__5_0(Game.Audio.IAudioPlayer audioPlayer)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if((System.String.op_Inequality(a:  this._lastText, b:  this._textMesh.text)) == false)
            {
                    return;
            }
            
            this._lastText = this._textMesh.text;
            this.RetrieveAndInvokeAudio();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            TMPro.TextMeshProUGUI val_1 = this.GetComponent<TMPro.TextMeshProUGUI>();
            this._textMesh = val_1;
            this._lastText = val_1.text;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextChangeAudioInvoker()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <RetrieveAndInvokeAudio>b__5_0(Game.Audio.IAudioPlayer audioPlayer)
        {
            this._audioPlayer = audioPlayer;
            this.InvokeAudio();
        }
    
    }

}
