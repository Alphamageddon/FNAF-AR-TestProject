using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class INBOXDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.INBOXDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static INBOXDATAReflection()
        {
            var val_16;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_4 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_7 = new string[1];
            val_7[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_8 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_11 = new string[3];
            val_11[0] = "InboxLogical";
            val_11[1] = "Order";
            val_11[2] = "DisplayFolderText";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_12 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  INBOX_DATA.Types.ENTRY.Parser, propertyNames:  val_11, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_8 == null)
            {
                goto label_23;
            }
            
            if(val_12 != null)
            {
                goto label_24;
            }
            
            goto label_27;
            label_23:
            if(val_12 == null)
            {
                goto label_27;
            }
            
            label_24:
            label_27:
            val_8[0] = val_12;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.INBOX_DATA.Parser, propertyNames:  val_7, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_8);
            if(val_4 == null)
            {
                goto label_29;
            }
            
            if(val_13 != null)
            {
                goto label_30;
            }
            
            goto label_33;
            label_29:
            if(val_13 == null)
            {
                goto label_33;
            }
            
            label_30:
            label_33:
            val_4[0] = val_13;
            val_16 = null;
            ProtoData.INBOXDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  "ChBJTkJPWF9EQVRBLnByb3RvEglQcm90b0RhdGEigwEKCklOQk9YX0RBVEES" + "LAoHRW50cmllcxgBIAMoCzIbLlByb3RvRGF0YS5JTkJPWF9EQVRBLkVOVFJZ" + "GkcKBUVOVFJZEhQKDEluYm94TG9naWNhbBgBIAEoCRINCgVPcmRlchgCIAEo" + "ARIZChFEaXNwbGF5Rm9sZGVyVGV4dBgDIAEoCWIGcHJvdG8z"), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_4));
        }
    
    }

}
