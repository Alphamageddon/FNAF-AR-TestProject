using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SEASONALASSETSDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.SEASONALASSETSDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SEASONALASSETSDATAReflection()
        {
            var val_17;
            string[] val_1 = new string[5];
            val_1[0] = "ChpTRUFTT05BTF9BU1NFVFNfREFUQS5wcm90bxIJUHJvdG9EYXRhIp0BChRT";
            val_1[1] = "RUFTT05BTF9BU1NFVFNfREFUQRI2CgdFbnRyaWVzGAEgAygLMiUuUHJvdG9E";
            val_1[2] = "YXRhLlNFQVNPTkFMX0FTU0VUU19EQVRBLkVOVFJZGk0KBUVOVFJZEg0KBUdy";
            val_1[3] = "b3VwGAEgASgJEhAKCEJ1bmRsZUlkGAIgASgJEg8KB0Fzc2V0SWQYAyABKAkS";
            val_1[4] = "EgoKUmVjZWl2ZXJJZBgEIAEoCWIGcHJvdG8z";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[4];
            val_12[0] = "Group";
            val_12[1] = "BundleId";
            val_12[2] = "AssetId";
            val_12[3] = "ReceiverId";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  SEASONAL_ASSETS_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
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
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_14 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.SEASONAL_ASSETS_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
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
            ProtoData.SEASONALASSETSDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
