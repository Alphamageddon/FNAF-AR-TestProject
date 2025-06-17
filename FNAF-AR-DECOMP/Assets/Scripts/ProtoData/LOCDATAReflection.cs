using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class LOCDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.LOCDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LOCDATAReflection()
        {
            var val_17;
            string[] val_1 = new string[6];
            val_1[0] = "Cg5MT0NfREFUQS5wcm90bxIJUHJvdG9EYXRhItEBCghMT0NfREFUQRIqCgdF";
            val_1[1] = "bnRyaWVzGAEgAygLMhkuUHJvdG9EYXRhLkxPQ19EQVRBLkVOVFJZGpgBCgVF";
            val_1[2] = "TlRSWRIKCgJJRBgBIAEoCRIPCgdFbmdsaXNoGAIgASgJEg4KBkZyZW5jaBgD";
            val_1[3] = "IAEoCRIPCgdJdGFsaWFuGAQgASgJEg4KBkdlcm1hbhgFIAEoCRIVCg1TcGFu";
            val_1[4] = "aXNoX1NwYWluGAYgASgJEhkKEVBvcnR1Z3Vlc2VfQnJhemlsGAcgASgJEg8K";
            val_1[5] = "B1J1c3NpYW4YCCABKAliBnByb3RvMw==";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[8];
            val_12[0] = "ID";
            val_12[1] = "English";
            val_12[2] = "French";
            val_12[3] = "Italian";
            val_12[4] = "German";
            val_12[5] = "SpanishSpain";
            val_12[6] = "PortugueseBrazil";
            val_12[7] = "Russian";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  LOC_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_9 == null)
            {
                goto label_57;
            }
            
            if(val_13 != null)
            {
                goto label_58;
            }
            
            goto label_61;
            label_57:
            if(val_13 == null)
            {
                goto label_61;
            }
            
            label_58:
            label_61:
            val_9[0] = val_13;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_14 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.LOC_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_63;
            }
            
            if(val_14 != null)
            {
                goto label_64;
            }
            
            goto label_67;
            label_63:
            if(val_14 == null)
            {
                goto label_67;
            }
            
            label_64:
            label_67:
            val_5[0] = val_14;
            val_17 = null;
            ProtoData.LOCDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
