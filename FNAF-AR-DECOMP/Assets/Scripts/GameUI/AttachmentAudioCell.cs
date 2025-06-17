using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AttachmentAudioCell : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AudioSource audioSource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI nameOfFileText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI playText;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void SetData(GameUI.AudioItem audioItem, UnityEngine.AudioClip audioClip, string playString, System.Action<GameUI.AttachmentAudioCell> PlayAttachmentAudio)
        {
            AttachmentAudioCell.<>c__DisplayClass4_0 val_1 = new AttachmentAudioCell.<>c__DisplayClass4_0();
            if(val_1 != null)
            {
                    .PlayAttachmentAudio = PlayAttachmentAudio;
            }
            else
            {
                    mem[16] = PlayAttachmentAudio;
            }
            
            .<>4__this = this;
            this.audioSource.clip = audioClip;
            this.nameOfFileText.text = audioItem.fileName;
            this.playText.text = playString;
            this.button.onClick.RemoveAllListeners();
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void AttachmentAudioCell.<>c__DisplayClass4_0::<SetData>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void PlayAudioClip()
        {
            this.audioSource.Play();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttachmentAudioCell()
        {
        
        }
    
    }

}
