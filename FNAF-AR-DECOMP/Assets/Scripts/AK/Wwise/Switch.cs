using UnityEngine;

namespace AK.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Switch : BaseGroupType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseSwitchReference WwiseObjectReference;
        
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
            return 10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override WwiseObjectType get_WwiseObjectGroupType()
        {
            return 11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetValue(UnityEngine.GameObject gameObject)
        {
            if(this.IsValid() == false)
            {
                    return;
            }
            
            AKRESULT val_4 = AkSoundEngine.SetSwitch(in_switchGroup:  this.GroupId, in_switchState:  this.Id, in_gameObjectID:  gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Switch()
        {
            val_1 = new System.Object();
        }
    
    }

}
