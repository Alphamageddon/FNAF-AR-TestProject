using UnityEngine;

namespace AK.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Event : BaseType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseEventReference WwiseObjectReference;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectReference ObjectReference { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectType WwiseObjectType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectReference get_ObjectReference()
        {
            return (WwiseObjectReference)this.WwiseObjectReference;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_ObjectReference(WwiseObjectReference value)
        {
            var val_2 = 0;
            this.WwiseObjectReference = ;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectType get_WwiseObjectType()
        {
            return 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void VerifyPlayingID(uint playingId)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint Post(UnityEngine.GameObject gameObject)
        {
            if(this.IsValid() == false)
            {
                    return 0;
            }
            
            return AkSoundEngine.PostEvent(in_eventID:  this.Id, in_gameObjectID:  gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint Post(UnityEngine.GameObject gameObject, AK.Wwise.CallbackFlags flags, AkCallbackManager.EventCallback callback, object cookie)
        {
            if(this.IsValid() == false)
            {
                    return 0;
            }
            
            return AkSoundEngine.PostEvent(in_eventID:  this.Id, in_gameObjectID:  gameObject, in_uFlags:  flags.value, in_pfnCallback:  callback, in_pCookie:  cookie);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint Post(UnityEngine.GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie)
        {
            if(this.IsValid() == false)
            {
                    return 0;
            }
            
            return AkSoundEngine.PostEvent(in_eventID:  this.Id, in_gameObjectID:  gameObject, in_uFlags:  flags, in_pfnCallback:  callback, in_pCookie:  cookie);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Stop(UnityEngine.GameObject gameObject, int transitionDuration = 0, AkCurveInterpolation curveInterpolation = 4)
        {
            this.ExecuteAction(gameObject:  gameObject, actionOnEventType:  0, transitionDuration:  transitionDuration, curveInterpolation:  curveInterpolation);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ExecuteAction(UnityEngine.GameObject gameObject, AkActionOnEventType actionOnEventType, int transitionDuration, AkCurveInterpolation curveInterpolation)
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            AKRESULT val_3 = AkSoundEngine.ExecuteActionOnEvent(in_eventID:  this.Id, in_ActionType:  actionOnEventType, in_gameObjectID:  gameObject, in_uTransitionDuration:  transitionDuration, in_eFadeCurve:  curveInterpolation);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PostMIDI(UnityEngine.GameObject gameObject, AkMIDIPostArray array)
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            array.PostOnEvent(in_eventID:  this.Id, gameObject:  gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PostMIDI(UnityEngine.GameObject gameObject, AkMIDIPostArray array, int count)
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            array.PostOnEvent(in_eventID:  this.Id, gameObject:  gameObject, count:  count);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StopMIDI(UnityEngine.GameObject gameObject)
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            AKRESULT val_3 = AkSoundEngine.StopMIDIOnEvent(in_eventID:  this.Id, in_gameObjectID:  gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StopMIDI()
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            AKRESULT val_3 = AkSoundEngine.StopMIDIOnEvent(in_eventID:  this.Id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Event()
        {
            val_1 = new System.Object();
        }
    
    }

}
