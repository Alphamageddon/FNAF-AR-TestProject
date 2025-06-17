using UnityEngine;

namespace AK.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Trigger : BaseType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseTriggerReference WwiseObjectReference;
        
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
            return 14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Post(UnityEngine.GameObject gameObject)
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            AKRESULT val_3 = AkSoundEngine.PostTrigger(in_triggerID:  this.Id, in_gameObjectID:  gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Trigger()
        {
            val_1 = new System.Object();
        }
    
    }

}
