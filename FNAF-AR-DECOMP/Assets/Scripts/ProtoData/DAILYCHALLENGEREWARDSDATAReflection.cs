using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class DAILYCHALLENGEREWARDSDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.DAILYCHALLENGEREWARDSDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static DAILYCHALLENGEREWARDSDATAReflection()
        {
            System.Type val_22;
            System.Type val_23;
            var val_24;
            string[] val_1 = new string[12];
            val_1[0] = "CiJEQUlMWV9DSEFMTEVOR0VfUkVXQVJEU19EQVRBLnByb3RvEglQcm90b0Rh";
            val_1[1] = "dGEizQMKHERBSUxZX0NIQUxMRU5HRV9SRVdBUkRTX0RBVEESPgoHRW50cmll";
            val_1[2] = "cxgBIAMoCzItLlByb3RvRGF0YS5EQUlMWV9DSEFMTEVOR0VfUkVXQVJEU19E";
            val_1[3] = "QVRBLkVOVFJZGuwCCgVFTlRSWRIPCgdMb2dpY2FsGAEgASgJEhMKC0xvb3RU";
            val_1[4] = "YWJsZUlkGAIgASgJEg4KBldlaWdodBgDIAEoARJBCgVJdGVtMRgEIAEoCzIy";
            val_1[5] = "LlByb3RvRGF0YS5EQUlMWV9DSEFMTEVOR0VfUkVXQVJEU19EQVRBLkVOVFJZ";
            val_1[6] = "LklURU0SQQoFSXRlbTIYBSABKAsyMi5Qcm90b0RhdGEuREFJTFlfQ0hBTExF";
            val_1[7] = "TkdFX1JFV0FSRFNfREFUQS5FTlRSWS5JVEVNEkEKBUl0ZW0zGAYgASgLMjIu";
            val_1[8] = "UHJvdG9EYXRhLkRBSUxZX0NIQUxMRU5HRV9SRVdBUkRTX0RBVEEuRU5UUlku";
            val_1[9] = "SVRFTRpkCgRJVEVNEhIKClJld2FyZFR5cGUYASABKAkSFQoNUmV3YXJkU3Vi";
            val_1[10] = "dHlwZRgCIAEoCRIQCghRdWFudGl0eRgDIAEoARIPCgdJY29uUmVmGAQgASgJ";
            val_1[11] = "Eg4KBkxvY1JlZhgFIAEoCWIGcHJvdG8z";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[6];
            val_12[0] = "Logical";
            val_12[1] = "LootTableId";
            val_12[2] = "Weight";
            val_12[3] = "Item1";
            val_12[4] = "Item2";
            val_12[5] = "Item3";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_16 = new string[5];
            val_16[0] = "RewardType";
            val_16[1] = "RewardSubtype";
            val_16[2] = "Quantity";
            val_16[3] = "IconRef";
            val_16[4] = "LocRef";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_17 = null;
            val_22 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_17 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_22, parser:  DAILY_CHALLENGE_REWARDS_DATA.Types.ENTRY.Types.ITEM.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_13 == null)
            {
                goto label_87;
            }
            
            if(val_17 != null)
            {
                goto label_88;
            }
            
            goto label_91;
            label_87:
            if(val_17 == null)
            {
                goto label_91;
            }
            
            label_88:
            if(val_17 == null)
            {
                    val_22 = 0;
            }
            
            label_91:
            if(val_13.Length == 0)
            {
                    val_22 = 0;
            }
            
            val_13[0] = val_17;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_18 = null;
            val_23 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_18 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_23, parser:  DAILY_CHALLENGE_REWARDS_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_13);
            if(val_9 == null)
            {
                goto label_93;
            }
            
            if(val_18 != null)
            {
                goto label_94;
            }
            
            goto label_97;
            label_93:
            if(val_18 == null)
            {
                goto label_97;
            }
            
            label_94:
            if(val_18 == null)
            {
                    val_23 = 0;
            }
            
            label_97:
            if(val_9.Length == 0)
            {
                    val_23 = 0;
            }
            
            val_9[0] = val_18;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_19 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.DAILY_CHALLENGE_REWARDS_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_99;
            }
            
            if(val_19 != null)
            {
                goto label_100;
            }
            
            goto label_103;
            label_99:
            if(val_19 == null)
            {
                goto label_103;
            }
            
            label_100:
            label_103:
            val_5[0] = val_19;
            val_24 = null;
            ProtoData.DAILYCHALLENGEREWARDSDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
