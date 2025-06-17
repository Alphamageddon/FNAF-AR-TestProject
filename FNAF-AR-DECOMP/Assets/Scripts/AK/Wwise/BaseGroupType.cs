using UnityEngine;

namespace AK.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public abstract class BaseGroupType : BaseType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int groupIdInternal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private byte[] groupGuidInternal;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseObjectReference GroupWwiseObjectReference { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract WwiseObjectType WwiseObjectGroupType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint GroupId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int groupID { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] groupGuid { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WwiseObjectReference get_GroupWwiseObjectReference()
        {
            var val_6;
            UnityEngine.Object val_6 = this;
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                    return 0;
            }
            
            val_6 = ???;
            goto (AK.Wwise.BaseGroupType.__il2cppRuntimeField_typeHierarchy + (WwiseGroupValueObjectReference.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? this : 0 + 392;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract WwiseObjectType get_WwiseObjectGroupType(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint get_GroupId()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.GroupWwiseObjectReference)) == false)
            {
                    return 0;
            }
            
            WwiseObjectReference val_3 = this.GroupWwiseObjectReference;
            if(val_3 != null)
            {
                    return val_3.Id;
            }
            
            return val_3.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool IsValid()
        {
            if(this.IsValid() == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  this.GroupWwiseObjectReference, y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_groupID()
        {
            return this.GroupId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] get_groupGuid()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this)) == false)
            {
                    return (System.Byte[])0;
            }
            
            System.Guid val_2 = this.Guid;
            0;
            return (System.Byte[])0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BaseGroupType()
        {
            val_1 = new System.Object();
        }
    
    }

}
