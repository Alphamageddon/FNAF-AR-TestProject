using UnityEngine;

namespace AK.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RTPC : BaseType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseRtpcReference WwiseObjectReference;
        
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
            return 13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetValue(UnityEngine.GameObject gameObject, float value)
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            AKRESULT val_3 = AkSoundEngine.SetRTPCValue(in_rtpcID:  this.Id, in_value:  value, in_gameObjectID:  gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetValue(UnityEngine.GameObject gameObject)
        {
            if(this.IsValid() == false)
            {
                    return 0f;
            }
            
            AKRESULT val_7 = AkSoundEngine.GetRTPCValue(in_rtpcID:  this.Id, in_gameObjectID:  gameObject, in_playingID:  0, out_rValue: out  float val_5 = 1.106289E+33f, io_rValueType: ref  ((UnityEngine.Object.op_Implicit(exists:  gameObject)) != true) ? (1 + 1) : 1);
            return 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetGlobalValue(float value)
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            AKRESULT val_3 = AkSoundEngine.SetRTPCValue(in_rtpcID:  this.Id, in_value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetGlobalValue()
        {
            return this.GetValue(gameObject:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RTPC()
        {
            val_1 = new System.Object();
        }
    
    }

}
