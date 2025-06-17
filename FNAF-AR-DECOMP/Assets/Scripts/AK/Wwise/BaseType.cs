using UnityEngine;

namespace AK.Wwise
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public abstract class BaseType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int idInternal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private byte[] valueGuidInternal;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract WwiseObjectReference ObjectReference { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract WwiseObjectType WwiseObjectType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string Name { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint Id { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ID { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] valueGuid { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract WwiseObjectReference get_ObjectReference(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void set_ObjectReference(WwiseObjectReference value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract WwiseObjectType get_WwiseObjectType(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string get_Name()
        {
            var val_5 = this;
            if((val_5 & 1) == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            val_5 = ???;
            goto typeof(AK.Wwise.BaseType).__il2cppRuntimeField_168;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint get_Id()
        {
            if((this & 1) == 0)
            {
                    return 0;
            }
            
            if(this != null)
            {
                    return this.Id;
            }
            
            return this.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool IsValid()
        {
            return UnityEngine.Object.op_Inequality(x:  this, y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Validate()
        {
            object val_3;
            var val_4;
            val_3 = this;
            if((val_3 & 1) != 0)
            {
                    val_4 = 1;
                return (bool)val_4;
            }
            
            val_3 = "Wwise ID has not been resolved. Consider picking a new " + this.GetType() + ".";
            UnityEngine.Debug.LogWarning(message:  val_3);
            val_4 = 0;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void Verify(AKRESULT result)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            if((this & 1) != 0)
            {
                    if(this != null)
            {
                    return this.ObjectName;
            }
            
                return this.ObjectName;
            }
            
            System.Type val_1 = this.GetType();
            if(val_1 != null)
            {
                    return "Empty " + val_1;
            }
            
            return "Empty " + val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_ID()
        {
            return this.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] get_valueGuid()
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
        protected BaseType()
        {
        
        }
    
    }

}
