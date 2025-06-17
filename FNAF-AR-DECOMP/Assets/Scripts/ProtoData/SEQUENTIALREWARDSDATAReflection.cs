using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SEQUENTIALREWARDSDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.SEQUENTIALREWARDSDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SEQUENTIALREWARDSDATAReflection()
        {
            var val_17;
            string[] val_1 = new string[7];
            val_1[0] = "Ch1TRVFVRU5USUFMX1JFV0FSRFNfREFUQS5wcm90bxIJUHJvdG9EYXRhIoEC";
            val_1[1] = "ChdTRVFVRU5USUFMX1JFV0FSRFNfREFUQRI5CgdFbnRyaWVzGAEgAygLMigu";
            val_1[2] = "UHJvdG9EYXRhLlNFUVVFTlRJQUxfUkVXQVJEU19EQVRBLkVOVFJZGqoBCgVF";
            val_1[3] = "TlRSWRIOCgZTZWFzb24YASABKAkSEAoIU2VxdWVuY2UYAiABKAESDwoHTG9n";
            val_1[4] = "aWNhbBgDIAEoCRIQCghDb29sZG93bhgEIAEoARISCgpSZXdhcmRUeXBlGAUg";
            val_1[5] = "ASgJEhUKDVJld2FyZFN1YnR5cGUYBiABKAkSEAoIUXVhbnRpdHkYByABKAES";
            val_1[6] = "DwoHSWNvblJlZhgIIAEoCRIOCgZMb2NSZWYYCSABKAliBnByb3RvMw==";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[9];
            val_12[0] = "Season";
            val_12[1] = "Sequence";
            val_12[2] = "Logical";
            val_12[3] = "Cooldown";
            val_12[4] = "RewardType";
            val_12[5] = "RewardSubtype";
            val_12[6] = "Quantity";
            val_12[7] = "IconRef";
            val_12[8] = "LocRef";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  SEQUENTIAL_REWARDS_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_9 == null)
            {
                goto label_63;
            }
            
            if(val_13 != null)
            {
                goto label_64;
            }
            
            goto label_67;
            label_63:
            if(val_13 == null)
            {
                goto label_67;
            }
            
            label_64:
            label_67:
            val_9[0] = val_13;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_14 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.SEQUENTIAL_REWARDS_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_69;
            }
            
            if(val_14 != null)
            {
                goto label_70;
            }
            
            goto label_73;
            label_69:
            if(val_14 == null)
            {
                goto label_73;
            }
            
            label_70:
            label_73:
            val_5[0] = val_14;
            val_17 = null;
            ProtoData.SEQUENTIALREWARDSDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
