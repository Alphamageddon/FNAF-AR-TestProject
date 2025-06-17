using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SEASONALDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.SEASONALDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SEASONALDATAReflection()
        {
            System.Type val_23;
            System.Type val_24;
            var val_25;
            string[] val_1 = new string[10];
            val_1[0] = "ChNTRUFTT05BTF9EQVRBLnByb3RvEglQcm90b0RhdGEaH2dvb2dsZS9wcm90";
            val_1[1] = "b2J1Zi90aW1lc3RhbXAucHJvdG8i8AIKDVNFQVNPTkFMX0RBVEESLwoHRW50";
            val_1[2] = "cmllcxgBIAMoCzIeLlByb3RvRGF0YS5TRUFTT05BTF9EQVRBLkVOVFJZGq0C";
            val_1[3] = "CgVFTlRSWRIPCgdMb2dpY2FsGAEgASgJEi0KCVN0YXJ0VGltZRgCIAEoCzIa";
            val_1[4] = "Lmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASKwoHRW5kVGltZRgDIAEoCzIa";
            val_1[5] = "Lmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASOwoJTWVjaGFuaWNzGAQgASgL";
            val_1[6] = "MiguUHJvdG9EYXRhLlNFQVNPTkFMX0RBVEEuRU5UUlkuTUVDSEFOSUNTGnoK";
            val_1[7] = "CU1FQ0hBTklDUxIZChFTZXF1ZW50aWFsUmV3YXJkcxgBIAEoCRIRCglTdG9y";
            val_1[8] = "ZVNhbGUYAiABKAkSEQoJU3RvcmVTa2luGAUgASgJEg8KB1N0b3JlSWQYBiAB";
            val_1[9] = "KAkSGwoTU2Vhc29uYWxBc3NldHNHcm91cBgHIAEoCWIGcHJvdG8z";
            Google.Protobuf.Reflection.FileDescriptor[] val_4 = new Google.Protobuf.Reflection.FileDescriptor[1];
            Google.Protobuf.Reflection.FileDescriptor val_5 = Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor;
            if(val_4 == null)
            {
                goto label_36;
            }
            
            if(val_5 != null)
            {
                goto label_37;
            }
            
            goto label_40;
            label_36:
            if(val_5 == null)
            {
                goto label_40;
            }
            
            label_37:
            label_40:
            val_4[0] = val_5;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_6 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_9 = new string[1];
            val_9[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_10 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_13 = new string[4];
            val_13[0] = "Logical";
            val_13[1] = "StartTime";
            val_13[2] = "EndTime";
            val_13[3] = "Mechanics";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_14 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_17 = new string[5];
            val_17[0] = "SequentialRewards";
            val_17[1] = "StoreSale";
            val_17[2] = "StoreSkin";
            val_17[3] = "StoreId";
            val_17[4] = "SeasonalAssetsGroup";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_18 = null;
            val_23 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_18 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_23, parser:  SEASONAL_DATA.Types.ENTRY.Types.MECHANICS.Parser, propertyNames:  val_17, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_14 == null)
            {
                goto label_83;
            }
            
            if(val_18 != null)
            {
                goto label_84;
            }
            
            goto label_87;
            label_83:
            if(val_18 == null)
            {
                goto label_87;
            }
            
            label_84:
            if(val_18 == null)
            {
                    val_23 = 0;
            }
            
            label_87:
            if(val_14.Length == 0)
            {
                    val_23 = 0;
            }
            
            val_14[0] = val_18;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_19 = null;
            val_24 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_19 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_24, parser:  SEASONAL_DATA.Types.ENTRY.Parser, propertyNames:  val_13, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_14);
            if(val_10 == null)
            {
                goto label_89;
            }
            
            if(val_19 != null)
            {
                goto label_90;
            }
            
            goto label_93;
            label_89:
            if(val_19 == null)
            {
                goto label_93;
            }
            
            label_90:
            if(val_19 == null)
            {
                    val_24 = 0;
            }
            
            label_93:
            if(val_10.Length == 0)
            {
                    val_24 = 0;
            }
            
            val_10[0] = val_19;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_20 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.SEASONAL_DATA.Parser, propertyNames:  val_9, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_10);
            if(val_6 == null)
            {
                goto label_95;
            }
            
            if(val_20 != null)
            {
                goto label_96;
            }
            
            goto label_99;
            label_95:
            if(val_20 == null)
            {
                goto label_99;
            }
            
            label_96:
            label_99:
            val_6[0] = val_20;
            val_25 = null;
            ProtoData.SEASONALDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  val_4, generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_6));
        }
    
    }

}
