using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class DAILYCHALLENGEDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.DAILYCHALLENGEDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static DAILYCHALLENGEDATAReflection()
        {
            System.Type val_34;
            System.Type val_35;
            var val_36;
            string[] val_1 = new string[16];
            val_1[0] = "ChpEQUlMWV9DSEFMTEVOR0VfREFUQS5wcm90bxIJUHJvdG9EYXRhIvgEChRE";
            val_1[1] = "QUlMWV9DSEFMTEVOR0VfREFUQRI2CgdFbnRyaWVzGAEgAygLMiUuUHJvdG9E";
            val_1[2] = "YXRhLkRBSUxZX0NIQUxMRU5HRV9EQVRBLkVOVFJZGqcECgVFTlRSWRIPCgdM";
            val_1[3] = "b2dpY2FsGAEgASgJEhoKEkRhaWx5Q2hhbGxlbmdlTmFtZRgCIAEoCRIgChhE";
            val_1[4] = "YWlseUNoYWxsZW5nZU5hbWVMb2NSZWYYAyABKAkSIQoZRGFpbHlDaGFsbGVu";
            val_1[5] = "Z2VEZXNjcmlwdGlvbhgEIAEoCRInCh9EYWlseUNoYWxsZW5nZURlc2NyaXB0";
            val_1[6] = "aW9uTG9jUmVmGAUgASgJEkgKDENvbmRpdGlvbmFscxgGIAEoCzIyLlByb3Rv";
            val_1[7] = "RGF0YS5EQUlMWV9DSEFMTEVOR0VfREFUQS5FTlRSWS5DT05ESVRJT05BTFMS";
            val_1[8] = "EgoKQWN0aW9uVHlwZRgHIAEoCRIPCgdTdWJUeXBlGAggASgJEkQKClRhc2tO";
            val_1[9] = "dW1iZXIYCSABKAsyMC5Qcm90b0RhdGEuREFJTFlfQ0hBTExFTkdFX0RBVEEu";
            val_1[10] = "RU5UUlkuVEFTS05VTUJFUhIVCg1BY3Rpb25JY29uUmVmGAogASgJEhYKDlN1";
            val_1[11] = "YlR5cGVJY29uUmVmGAsgASgJEh8KF0RhaWx5Q2hhbGxlbmdlQXJ0TG9jUmVm";
            val_1[12] = "GAwgASgJGjYKDENPTkRJVElPTkFMUxomCgpCRVNUU1RSRUFLEgsKA01pbhgB";
            val_1[13] = "IAEoARILCgNNYXgYAiABKAEaJgoKVEFTS05VTUJFUhILCgNNaW4YASABKAES";
            val_1[14] = "CwoDTWF4GAIgASgBGh4KB1JFV0FSRFMSEwoLTG9vdFRhYmxlSWQYASABKAli";
            val_1[15] = "BnByb3RvMw==";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[12];
            val_12[0] = "Logical";
            val_12[1] = "DailyChallengeName";
            val_12[2] = "DailyChallengeNameLocRef";
            val_12[3] = "DailyChallengeDescription";
            val_12[4] = "DailyChallengeDescriptionLocRef";
            val_12[5] = "Conditionals";
            val_12[6] = "ActionType";
            val_12[7] = "SubType";
            val_12[8] = "TaskNumber";
            val_12[9] = "ActionIconRef";
            val_12[10] = "SubTypeIconRef";
            val_12[11] = "DailyChallengeArtLocRef";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[3];
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_16 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_19 = new string[2];
            val_19[0] = "Min";
            val_19[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_20 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS.Types.BESTSTREAK.Parser, propertyNames:  val_19, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_16 == null)
            {
                goto label_110;
            }
            
            if(val_20 != null)
            {
                goto label_111;
            }
            
            goto label_114;
            label_110:
            if(val_20 == null)
            {
                goto label_114;
            }
            
            label_111:
            label_114:
            val_16[0] = val_20;
            val_13[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS.Parser, propertyNames:  0, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_16);
            string[] val_24 = new string[2];
            val_24[0] = "Min";
            val_24[1] = "Max";
            val_13[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DAILY_CHALLENGE_DATA.Types.ENTRY.Types.TASKNUMBER.Parser, propertyNames:  val_24, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_28 = new string[1];
            val_28[0] = "LootTableId";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_29 = null;
            val_34 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_29 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_34, parser:  DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS.Parser, propertyNames:  val_28, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_29 != null) && (val_29 == null))
            {
                    val_34 = 0;
            }
            
            if(val_13.Length <= 2)
            {
                    val_34 = 0;
            }
            
            val_13[2] = val_29;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_30 = null;
            val_35 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_30 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_35, parser:  DAILY_CHALLENGE_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_13);
            if(val_9 == 0)
            {
                goto label_141;
            }
            
            if(val_30 != null)
            {
                goto label_142;
            }
            
            goto label_145;
            label_141:
            if(val_30 == null)
            {
                goto label_145;
            }
            
            label_142:
            val_35 = val_9[4];
            if(val_30 == null)
            {
                    val_35 = 0;
            }
            
            label_145:
            if(mem[1152921524246747192] == 0)
            {
                    val_35 = 0;
            }
            
            mem[1152921524246747200] = val_30;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_31 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.DAILY_CHALLENGE_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == 0)
            {
                goto label_147;
            }
            
            if(val_31 != null)
            {
                goto label_148;
            }
            
            goto label_151;
            label_147:
            if(val_31 == null)
            {
                goto label_151;
            }
            
            label_148:
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_34 = val_5[4];
            label_151:
            mem[1152921524246730784] = val_31;
            val_36 = null;
            ProtoData.DAILYCHALLENGEDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
