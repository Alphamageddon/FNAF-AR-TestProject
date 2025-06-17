using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MODSDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.MODSDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static MODSDATAReflection()
        {
            System.Type val_26;
            System.Type val_27;
            var val_28;
            string[] val_1 = new string[15];
            val_1[0] = "Cg9NT0RTX0RBVEEucHJvdG8SCVByb3RvRGF0YSLmBAoJTU9EU19EQVRBEisK";
            val_1[1] = "B0VudHJpZXMYASADKAsyGi5Qcm90b0RhdGEuTU9EU19EQVRBLkVOVFJZGqsE";
            val_1[2] = "CgVFTlRSWRISCgpNb2RMb2dpY2FsGAEgASgJEg8KB01vZE5hbWUYAiABKAkS";
            val_1[3] = "DwoHTW9kRGVzYxgDIAEoCRIPCgdNb2RUeXBlGAQgASgJEjMKB0VmZmVjdHMY";
            val_1[4] = "BSABKAsyIi5Qcm90b0RhdGEuTU9EU19EQVRBLkVOVFJZLkVGRkVDVFMSFgoO";
            val_1[5] = "QnJlYWthZ2VDaGFuY2UYBiABKAESEgoKRHJvcFdlaWdodBgHIAEoARIUCgxQ";
            val_1[6] = "YXJ0c0J1eWJhY2sYCCABKAESNwoJQXJ0QXNzZXRzGAkgASgLMiQuUHJvdG9E";
            val_1[7] = "YXRhLk1PRFNfREFUQS5FTlRSWS5BUlRBU1NFVFMSDQoFU3RhcnMYCiABKAEa";
            val_1[8] = "zQEKB0VGRkVDVFMSFgoORWZmZWN0Q2F0ZWdvcnkYASABKAkSFAoMRWZmZWN0";
            val_1[9] = "VHlwZV8xGAIgASgJEhMKC0VmZmVjdE1hZ18xGAMgASgBEhQKDEVmZmVjdFR5";
            val_1[10] = "cGVfMhgEIAEoCRITCgtFZmZlY3RNYWdfMhgFIAEoARIUCgxFZmZlY3RUeXBl";
            val_1[11] = "XzMYBiABKAkSEwoLRWZmZWN0TWFnXzMYByABKAESFAoMRWZmZWN0VHlwZV80";
            val_1[12] = "GAggASgJEhMKC0VmZmVjdE1hZ180GAkgASgBGkwKCUFSVEFTU0VUUxIPCgdN";
            val_1[13] = "b2RJY29uGAEgASgJEhcKD01vZEljb25SZW5kZXJlZBgCIAEoCRIVCg1Nb2RJ";
            val_1[14] = "Y29uUmV3YXJkGAMgASgJYgZwcm90bzM=";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[10];
            val_12[0] = "ModLogical";
            val_12[1] = "ModName";
            val_12[2] = "ModDesc";
            val_12[3] = "ModType";
            val_12[4] = "Effects";
            val_12[5] = "BreakageChance";
            val_12[6] = "DropWeight";
            val_12[7] = "PartsBuyback";
            val_12[8] = "ArtAssets";
            val_12[9] = "Stars";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[2];
            string[] val_16 = new string[9];
            val_16[0] = "EffectCategory";
            val_16[1] = "EffectType1";
            val_16[2] = "EffectMag1";
            val_16[3] = "EffectType2";
            val_16[4] = "EffectMag2";
            val_16[5] = "EffectType3";
            val_16[6] = "EffectMag3";
            val_16[7] = "EffectType4";
            val_16[8] = "EffectMag4";
            val_13[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  MODS_DATA.Types.ENTRY.Types.EFFECTS.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_20 = new string[3];
            val_20[0] = "ModIcon";
            val_20[1] = "ModIconRendered";
            val_20[2] = "ModIconReward";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_21 = null;
            val_26 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_21 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_26, parser:  MODS_DATA.Types.ENTRY.Types.ARTASSETS.Parser, propertyNames:  val_20, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_21 != null) && (val_21 == null))
            {
                    val_26 = 0;
            }
            
            if(val_13.Length <= 1)
            {
                    val_26 = 0;
            }
            
            val_13[1] = val_21;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_22 = null;
            val_27 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_22 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_27, parser:  MODS_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_13);
            if(val_9 == null)
            {
                goto label_139;
            }
            
            if(val_22 != null)
            {
                goto label_140;
            }
            
            goto label_143;
            label_139:
            if(val_22 == null)
            {
                goto label_143;
            }
            
            label_140:
            if(val_22 == null)
            {
                    val_27 = 0;
            }
            
            label_143:
            if(val_9.Length == 0)
            {
                    val_27 = 0;
            }
            
            val_9[0] = val_22;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_23 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.MODS_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_145;
            }
            
            if(val_23 != null)
            {
                goto label_146;
            }
            
            goto label_149;
            label_145:
            if(val_23 == null)
            {
                goto label_149;
            }
            
            label_146:
            label_149:
            val_5[0] = val_23;
            val_28 = null;
            ProtoData.MODSDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
