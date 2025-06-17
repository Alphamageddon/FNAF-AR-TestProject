using UnityEngine;

namespace AK.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class State : BaseGroupType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseStateReference WwiseObjectReference;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectReference ObjectReference { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectType WwiseObjectType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectType WwiseObjectGroupType { get; }
        
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
            return 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectType get_WwiseObjectGroupType()
        {
            return 9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetValue()
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            AKRESULT val_4 = AkSoundEngine.SetState(in_stateGroup:  this.GroupId, in_state:  this.Id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public State()
        {
            val_1 = new System.Object();
        }
    
    }

}
