using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class KEYVALUEDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.KEYVALUEDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static KEYVALUEDATAReflection()
        {
            var val_17;
            string[] val_1 = new string[5];
            val_1[0] = "ChRLRVlfVkFMVUVfREFUQS5wcm90bxIJUHJvdG9EYXRhIpwBCg5LRVlfVkFM";
            val_1[1] = "VUVfREFUQRIwCgdFbnRyaWVzGAEgAygLMh8uUHJvdG9EYXRhLktFWV9WQUxV";
            val_1[2] = "RV9EQVRBLkVOVFJZGlgKBUVOVFJZEg8KB0xvZ2ljYWwYASABKAkSEwoLU3Ry";
            val_1[3] = "aW5nVmFsdWUYAiABKAkSEwoLTnVtYmVyVmFsdWUYAyABKAESFAoMQm9vbGVh";
            val_1[4] = "blZhbHVlGAQgASgIYgZwcm90bzM=";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[4];
            val_12[0] = "Logical";
            val_12[1] = "StringValue";
            val_12[2] = "NumberValue";
            val_12[3] = "BooleanValue";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  KEY_VALUE_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_9 == null)
            {
                goto label_42;
            }
            
            if(val_13 != null)
            {
                goto label_43;
            }
            
            goto label_46;
            label_42:
            if(val_13 == null)
            {
                goto label_46;
            }
            
            label_43:
            label_46:
            val_9[0] = val_13;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_14 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.KEY_VALUE_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_48;
            }
            
            if(val_14 != null)
            {
                goto label_49;
            }
            
            goto label_52;
            label_48:
            if(val_14 == null)
            {
                goto label_52;
            }
            
            label_49:
            label_52:
            val_5[0] = val_14;
            val_17 = null;
            ProtoData.KEYVALUEDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
