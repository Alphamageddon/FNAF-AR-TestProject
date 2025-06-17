using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class STORESECTIONSDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.STORESECTIONSDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static STORESECTIONSDATAReflection()
        {
            var val_17;
            string[] val_1 = new string[6];
            val_1[0] = "ChhTVE9SRVNFQ1RJT05TX0RBVEEucHJvdG8SCVByb3RvRGF0YSK/AQoSU1RP";
            val_1[1] = "UkVTRUNUSU9OU19EQVRBEjQKB0VudHJpZXMYASADKAsyIy5Qcm90b0RhdGEu";
            val_1[2] = "U1RPUkVTRUNUSU9OU19EQVRBLkVOVFJZGnMKBUVOVFJZEg8KB0xvZ2ljYWwY";
            val_1[3] = "ASABKAkSGAoQU3RvcmVTZWN0aW9uTmFtZRgCIAEoCRIbChNTdG9yZVNlY3Rp";
            val_1[4] = "b25OYW1lUmVmGAMgASgJEhMKC0Rpc3BsYXlUeXBlGAQgASgJEg0KBU9yZGVy";
            val_1[5] = "GAUgASgBYgZwcm90bzM=";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[5];
            val_12[0] = "Logical";
            val_12[1] = "StoreSectionName";
            val_12[2] = "StoreSectionNameRef";
            val_12[3] = "DisplayType";
            val_12[4] = "Order";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  STORESECTIONS_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_9 == null)
            {
                goto label_48;
            }
            
            if(val_13 != null)
            {
                goto label_49;
            }
            
            goto label_52;
            label_48:
            if(val_13 == null)
            {
                goto label_52;
            }
            
            label_49:
            label_52:
            val_9[0] = val_13;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_14 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.STORESECTIONS_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_54;
            }
            
            if(val_14 != null)
            {
                goto label_55;
            }
            
            goto label_58;
            label_54:
            if(val_14 == null)
            {
                goto label_58;
            }
            
            label_55:
            label_58:
            val_5[0] = val_14;
            val_17 = null;
            ProtoData.STORESECTIONSDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
