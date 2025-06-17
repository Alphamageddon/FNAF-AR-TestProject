using UnityEngine;

namespace AK.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AuxBus : BaseType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseAuxBusReference WwiseObjectReference;
        
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
            return 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AuxBus()
        {
            val_1 = new System.Object();
        }
    
    }

}
