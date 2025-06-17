using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ESSENCEDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.ESSENCEDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ESSENCEDATAReflection()
        {
            System.Type val_22;
            System.Type val_23;
            var val_24;
            string[] val_1 = new string[7];
            val_1[0] = "ChJFU1NFTkNFX0RBVEEucHJvdG8SCVByb3RvRGF0YSLyAQoMRVNTRU5DRV9E";
            val_1[1] = "QVRBEi4KB0VudHJpZXMYASADKAsyHS5Qcm90b0RhdGEuRVNTRU5DRV9EQVRB";
            val_1[2] = "LkVOVFJZGrEBCgVFTlRSWRJCCg1Fc3NlbmNlVmFsdWVzGAEgASgLMisuUHJv";
            val_1[3] = "dG9EYXRhLkVTU0VOQ0VfREFUQS5FTlRSWS5FU1NFTkNFVkFMVUVTGmQKDUVT";
            val_1[4] = "U0VOQ0VWQUxVRVMSDwoHRXNzZW5jZRgBIAEoARITCgtNYWxmdW5jdGlvbhgC";
            val_1[5] = "IAEoARITCgtCYXR0ZXJ5TXVsdBgDIAEoARIYChBSYXJlUmV3YXJkQ2hhbmNl";
            val_1[6] = "GAQgASgBYgZwcm90bzM=";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[1];
            val_12[0] = "EssenceValues";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_16 = new string[4];
            val_16[0] = "Essence";
            val_16[1] = "Malfunction";
            val_16[2] = "BatteryMult";
            val_16[3] = "RareRewardChance";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_17 = null;
            val_22 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_17 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_22, parser:  ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_13 == null)
            {
                goto label_54;
            }
            
            if(val_17 != null)
            {
                goto label_55;
            }
            
            goto label_58;
            label_54:
            if(val_17 == null)
            {
                goto label_58;
            }
            
            label_55:
            if(val_17 == null)
            {
                    val_22 = 0;
            }
            
            label_58:
            if(val_13.Length == 0)
            {
                    val_22 = 0;
            }
            
            val_13[0] = val_17;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_18 = null;
            val_23 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_18 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_23, parser:  ESSENCE_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_13);
            if(val_9 == null)
            {
                goto label_60;
            }
            
            if(val_18 != null)
            {
                goto label_61;
            }
            
            goto label_64;
            label_60:
            if(val_18 == null)
            {
                goto label_64;
            }
            
            label_61:
            if(val_18 == null)
            {
                    val_23 = 0;
            }
            
            label_64:
            if(val_9.Length == 0)
            {
                    val_23 = 0;
            }
            
            val_9[0] = val_18;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_19 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.ESSENCE_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_66;
            }
            
            if(val_19 != null)
            {
                goto label_67;
            }
            
            goto label_70;
            label_66:
            if(val_19 == null)
            {
                goto label_70;
            }
            
            label_67:
            label_70:
            val_5[0] = val_19;
            val_24 = null;
            ProtoData.ESSENCEDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
