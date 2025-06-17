using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PROGRESSIONDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.PROGRESSIONDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PROGRESSIONDATAReflection()
        {
            var val_17;
            string[] val_1 = new string[6];
            val_1[0] = "ChZQUk9HUkVTU0lPTl9EQVRBLnByb3RvEglQcm90b0RhdGEi0QEKEFBST0dS";
            val_1[1] = "RVNTSU9OX0RBVEESMgoHRW50cmllcxgBIAMoCzIhLlByb3RvRGF0YS5QUk9H";
            val_1[2] = "UkVTU0lPTl9EQVRBLkVOVFJZGogBCgVFTlRSWRIRCglNYXhTdHJlYWsYASAB";
            val_1[3] = "KAESFQoNTW9kU2xvdFVubG9jaxgCIAEoCRIaChJFbmRvc2tlbGV0b25Vbmxv";
            val_1[4] = "Y2sYAyABKAkSDwoHTWF4UmFuaxgEIAEoARISCgpCb251c1BhcnRzGAUgASgB";
            val_1[5] = "EhQKDEJvbnVzRXNzZW5jZRgGIAEoAWIGcHJvdG8z";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[6];
            val_12[0] = "MaxStreak";
            val_12[1] = "ModSlotUnlock";
            val_12[2] = "EndoskeletonUnlock";
            val_12[3] = "MaxRank";
            val_12[4] = "BonusParts";
            val_12[5] = "BonusEssence";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  PROGRESSION_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_9 == null)
            {
                goto label_51;
            }
            
            if(val_13 != null)
            {
                goto label_52;
            }
            
            goto label_55;
            label_51:
            if(val_13 == null)
            {
                goto label_55;
            }
            
            label_52:
            label_55:
            val_9[0] = val_13;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_14 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.PROGRESSION_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_57;
            }
            
            if(val_14 != null)
            {
                goto label_58;
            }
            
            goto label_61;
            label_57:
            if(val_14 == null)
            {
                goto label_61;
            }
            
            label_58:
            label_61:
            val_5[0] = val_14;
            val_17 = null;
            ProtoData.PROGRESSIONDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
