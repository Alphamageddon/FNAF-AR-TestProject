using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SERVERBLOCKINGERRORDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.SERVERBLOCKINGERRORDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SERVERBLOCKINGERRORDATAReflection()
        {
            System.Type val_20;
            string[] val_1 = new string[8];
            val_1[0] = "Ch5TRVJWRVJCTE9DS0lOR0VSUk9SX0RBVEEucHJvdG8SCVByb3RvRGF0YRof";
            val_1[1] = "Z29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKLAgoYU0VSVkVSQkxP";
            val_1[2] = "Q0tJTkdFUlJPUl9EQVRBEjoKB0VudHJpZXMYASADKAsyKS5Qcm90b0RhdGEu";
            val_1[3] = "U0VSVkVSQkxPQ0tJTkdFUlJPUl9EQVRBLkVOVFJZGrIBCgVFTlRSWRINCgVF";
            val_1[4] = "dmVudBgBIAEoCRIVCg1FcnJvclJldHVybmVkGAIgASgJEkgKCkJsb2NrQWxs";
            val_1[5] = "b3cYAyABKA4yNC5Qcm90b0RhdGEuU0VSVkVSQkxPQ0tJTkdFUlJPUl9EQVRB";
            val_1[6] = "LkVOVFJZLkJMT0NLQUxMT1ciOQoKQkxPQ0tBTExPVxIJCgVCTE9DSxAAEgkK";
            val_1[7] = "BUFMTE9XEAESFQoRQkxPQ0tfT05MWV9PTl9NQVAQAmIGcHJvdG8z";
            Google.Protobuf.Reflection.FileDescriptor[] val_4 = new Google.Protobuf.Reflection.FileDescriptor[1];
            Google.Protobuf.Reflection.FileDescriptor val_5 = Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor;
            if(val_4 == null)
            {
                goto label_30;
            }
            
            if(val_5 != null)
            {
                goto label_31;
            }
            
            goto label_34;
            label_30:
            if(val_5 == null)
            {
                goto label_34;
            }
            
            label_31:
            label_34:
            val_4[0] = val_5;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_6 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_9 = new string[1];
            val_9[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_10 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_13 = new string[3];
            val_13[0] = "Event";
            val_13[1] = "ErrorReturned";
            val_13[2] = "BlockAllow";
            System.Type[] val_14 = new System.Type[1];
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_14 == null)
            {
                goto label_56;
            }
            
            if(val_15 != null)
            {
                goto label_57;
            }
            
            goto label_60;
            label_56:
            if(val_15 == null)
            {
                goto label_60;
            }
            
            label_57:
            label_60:
            val_14[0] = val_15;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_16 = null;
            val_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_16 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_20, parser:  SERVERBLOCKINGERROR_DATA.Types.ENTRY.Parser, propertyNames:  val_13, oneofNames:  0, nestedEnums:  val_14, nestedTypes:  0);
            if(val_10 == null)
            {
                goto label_62;
            }
            
            if(val_16 != null)
            {
                goto label_63;
            }
            
            goto label_66;
            label_62:
            if(val_16 == null)
            {
                goto label_66;
            }
            
            label_63:
            if(val_16 == null)
            {
                    val_20 = 0;
            }
            
            label_66:
            if(val_10.Length == 0)
            {
                    val_20 = 0;
            }
            
            val_10[0] = val_16;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_17 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.SERVERBLOCKINGERROR_DATA.Parser, propertyNames:  val_9, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_10);
            if(val_6 == null)
            {
                goto label_68;
            }
            
            if(val_17 != null)
            {
                goto label_69;
            }
            
            goto label_72;
            label_68:
            if(val_17 == null)
            {
                goto label_72;
            }
            
            label_69:
            label_72:
            val_6[0] = val_17;
            ProtoData.SERVERBLOCKINGERRORDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  val_4, generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_6));
        }
    
    }

}
