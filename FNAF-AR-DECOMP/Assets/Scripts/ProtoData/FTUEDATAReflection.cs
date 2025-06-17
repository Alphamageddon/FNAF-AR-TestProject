using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class FTUEDATAReflection
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.Reflection.FileDescriptor Descriptor { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
        {
            null = null;
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.FTUEDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static FTUEDATAReflection()
        {
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_4 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_7 = new string[1];
            val_7[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_8 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_11 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  FTUE_DATA.Types.ENTRY.Parser, propertyNames:  0, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_8 == null)
            {
                goto label_13;
            }
            
            if(val_11 != null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            if(val_11 == null)
            {
                goto label_17;
            }
            
            label_14:
            label_17:
            val_8[0] = val_11;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_12 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.FTUE_DATA.Parser, propertyNames:  val_7, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_8);
            if(val_4 == null)
            {
                goto label_19;
            }
            
            if(val_12 != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_19:
            if(val_12 == null)
            {
                goto label_23;
            }
            
            label_20:
            label_23:
            val_4[0] = val_12;
            ProtoData.FTUEDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  "Cg9GVFVFX0RBVEEucHJvdG8SCVByb3RvRGF0YSJBCglGVFVFX0RBVEESKwoH" + "RW50cmllcxgBIAMoCzIaLlByb3RvRGF0YS5GVFVFX0RBVEEuRU5UUlkaBwoF" + "RU5UUlliBnByb3RvMw=="("RU5UUlliBnByb3RvMw==")), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_4));
        }
    
    }

}
