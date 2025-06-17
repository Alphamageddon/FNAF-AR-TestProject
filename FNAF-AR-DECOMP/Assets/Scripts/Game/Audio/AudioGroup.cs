using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AudioGroup
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Audio.Components.AkAudioEmitter <DefaultEmitter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.HashSet<Systems.Audio.Components.AkAudioEmitter> _emitters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _volume;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isMuted;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Components.AkAudioEmitter DefaultEmitter { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Components.AkAudioEmitter get_DefaultEmitter()
        {
            return (Systems.Audio.Components.AkAudioEmitter)this.<DefaultEmitter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DefaultEmitter(Systems.Audio.Components.AkAudioEmitter value)
        {
            this.<DefaultEmitter>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddEmitter(Systems.Audio.Components.AkAudioEmitter emitter)
        {
            if((this._emitters.Contains(item:  emitter)) != false)
            {
                    return;
            }
            
            bool val_2 = this._emitters.Add(item:  emitter);
            this.UpdateEmitterVolume(emitter:  emitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveEmitter(Systems.Audio.Components.AkAudioEmitter emitter)
        {
            if((this._emitters.Contains(item:  emitter)) == false)
            {
                    return;
            }
            
            bool val_2 = this._emitters.Remove(item:  emitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetVolume(float volume)
        {
            this._volume = UnityEngine.Mathf.Clamp(value:  volume, min:  0f, max:  1f);
            this.UpdateGroupVolume();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMuteState(bool isMuted)
        {
            this._isMuted = isMuted;
            this.UpdateGroupVolume();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateGroupVolume()
        {
            var val_4;
            var val_5;
            HashSet.Enumerator<T> val_1 = this._emitters.GetEnumerator();
            label_3:
            if(((-670018680) & 1) == 0)
            {
                goto label_2;
            }
            
            this.UpdateEmitterVolume(emitter:  0.emailUIDataHandler);
            goto label_3;
            label_2:
            val_4 = 0;
            val_5 = 1;
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525411664776});
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEmitterVolume(Systems.Audio.Components.AkAudioEmitter emitter)
        {
            emitter.SetVolume(level:  this._volume);
            emitter.SetMute(shouldMute:  (this._isMuted == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AudioGroup(Systems.Audio.Components.AkAudioEmitter defaultEmitter)
        {
            this._emitters = new System.Collections.Generic.HashSet<Systems.Audio.Components.AkAudioEmitter>();
            this._volume = 1f;
            this.<DefaultEmitter>k__BackingField = defaultEmitter;
            this.AddEmitter(emitter:  defaultEmitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._emitters.Clear();
            this.<DefaultEmitter>k__BackingField.Teardown();
            this.<DefaultEmitter>k__BackingField = 0;
        }
    
    }

}
