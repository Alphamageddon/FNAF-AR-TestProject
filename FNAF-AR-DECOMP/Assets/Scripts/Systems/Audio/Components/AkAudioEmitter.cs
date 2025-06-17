using UnityEngine;

namespace Systems.Audio.Components
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AkAudioEmitter : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AkAudioListener _akAudioListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _volume;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isMuted;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMute(bool shouldMute)
        {
            float val_6;
            if(this._akAudioListener == 0)
            {
                    return;
            }
            
            this._isMuted = shouldMute;
            val_6 = 0f;
            if(this._isMuted != true)
            {
                    val_6 = this._volume;
            }
            
            AKRESULT val_5 = AkSoundEngine.SetGameObjectOutputBusVolume(in_emitterObjID:  this.gameObject, in_listenerObjID:  this._akAudioListener.gameObject, in_fControlValue:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetVolume(float level)
        {
            if(this._akAudioListener == 0)
            {
                    return;
            }
            
            this._volume = UnityEngine.Mathf.Clamp(value:  level, min:  0f, max:  1f);
            if(this._isMuted != false)
            {
                    return;
            }
            
            AKRESULT val_5 = AkSoundEngine.SetGameObjectOutputBusVolume(in_emitterObjID:  this.gameObject, in_listenerObjID:  this._akAudioListener.gameObject, in_fControlValue:  this._volume);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetListener(AkAudioListener akAudioListener)
        {
            this._akAudioListener = akAudioListener;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StopAllAudio()
        {
            AkSoundEngine.StopAll(in_gameObjectID:  this.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendEvent(string eventName)
        {
            if(this.gameObject == 0)
            {
                    return;
            }
            
            uint val_4 = AkSoundEngine.PostEvent(in_pszEventName:  eventName, in_gameObjectID:  this.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetRtpcValue(string rtpcName, float rtpcValue)
        {
            AKRESULT val_2 = AkSoundEngine.SetRTPCValue(in_pszRtpcName:  rtpcName, in_value:  rtpcValue, in_gameObjectID:  this.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSwitch(string switchName, string switchState)
        {
            AKRESULT val_2 = AkSoundEngine.SetSwitch(in_pszSwitchGroup:  switchName, in_pszSwitchState:  switchState, in_gameObjectID:  this.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.StopAllAudio();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AkAudioEmitter()
        {
            this._volume = 1f;
        }
    
    }

}
