using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AudioSourceWatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AudioSource[] audioSources;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AudioSourceWatcher(UnityEngine.GameObject gameObject)
        {
            this.audioSources = gameObject.GetComponentsInChildren<UnityEngine.AudioSource>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AllAudioSourcesFinished()
        {
            var val_2;
            var val_3 = 0;
            label_4:
            if(val_3 >= this.audioSources.Length)
            {
                goto label_1;
            }
            
            val_3 = val_3 + 1;
            if(this.audioSources[0].isPlaying == false)
            {
                goto label_4;
            }
            
            val_2 = 0;
            return (bool)val_2;
            label_1:
            val_2 = 1;
            return (bool)val_2;
        }
    
    }

}
