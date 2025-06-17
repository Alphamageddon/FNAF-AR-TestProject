using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MODCATEGORIESDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.MODCATEGORIESDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static MODCATEGORIESDATAReflection()
        {
            var val_17;
            string[] val_1 = new string[7];
            val_1[0] = "ChhNT0RDQVRFR09SSUVTX0RBVEEucHJvdG8SCVByb3RvRGF0YSL2AQoSTU9E";
            val_1[1] = "Q0FURUdPUklFU19EQVRBEjQKB0VudHJpZXMYASADKAsyIy5Qcm90b0RhdGEu";
            val_1[2] = "TU9EQ0FURUdPUklFU19EQVRBLkVOVFJZGqkBCgVFTlRSWRIVCg1Nb2RDYXRM";
            val_1[3] = "b2dpY2FsGAEgASgJEhIKCk1vZENhdE5hbWUYAiABKAkSEQoJTW9kQ2F0UmVm";
            val_1[4] = "GAMgASgJEhIKCk1vZENhdERlc2MYBCABKAkSFQoNTW9kQ2F0RGVzY1JlZhgF";
            val_1[5] = "IAEoCRIRCglMaXZlU3RhdGUYBiABKAkSFQoNTW9kQ2F0SWNvblJlZhgHIAEo";
            val_1[6] = "CRINCgVPcmRlchgIIAEoAWIGcHJvdG8z";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[8];
            val_12[0] = "ModCatLogical";
            val_12[1] = "ModCatName";
            val_12[2] = "ModCatRef";
            val_12[3] = "ModCatDesc";
            val_12[4] = "ModCatDescRef";
            val_12[5] = "LiveState";
            val_12[6] = "ModCatIconRef";
            val_12[7] = "Order";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  MODCATEGORIES_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_9 == null)
            {
                goto label_60;
            }
            
            if(val_13 != null)
            {
                goto label_61;
            }
            
            goto label_64;
            label_60:
            if(val_13 == null)
            {
                goto label_64;
            }
            
            label_61:
            label_64:
            val_9[0] = val_13;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_14 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.MODCATEGORIES_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_66;
            }
            
            if(val_14 != null)
            {
                goto label_67;
            }
            
            goto label_70;
            label_66:
            if(val_14 == null)
            {
                goto label_70;
            }
            
            label_67:
            label_70:
            val_5[0] = val_14;
            val_17 = null;
            ProtoData.MODCATEGORIESDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
