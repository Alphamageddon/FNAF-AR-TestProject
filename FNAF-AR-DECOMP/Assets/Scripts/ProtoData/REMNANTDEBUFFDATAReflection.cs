using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class REMNANTDEBUFFDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.REMNANTDEBUFFDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static REMNANTDEBUFFDATAReflection()
        {
            var val_21;
            string[] val_1 = new string[7];
            val_1[0] = "ChlSRU1OQU5UX0RFQlVGRl9EQVRBLnByb3RvEglQcm90b0RhdGEi4gEKE1JF";
            val_1[1] = "TU5BTlRfREVCVUZGX0RBVEESNQoHRW50cmllcxgBIAMoCzIkLlByb3RvRGF0";
            val_1[2] = "YS5SRU1OQU5UX0RFQlVGRl9EQVRBLkVOVFJZGkYKDVJFTU5BTlRERUJVRkYS";
            val_1[3] = "GAoQUmVtbmFudENvbGxlY3RlZBgBIAEoARIbChNTaG9ja1dpbmRvd0luY3Jl";
            val_1[4] = "YXNlGAIgASgBGkwKBUVOVFJZEkMKDVJlbW5hbnREZWJ1ZmYYASABKAsyLC5Q";
            val_1[5] = "cm90b0RhdGEuUkVNTkFOVF9ERUJVRkZfREFUQS5SRU1OQU5UREVCVUZGYgZw";
            val_1[6] = "cm90bzM=";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[2];
            string[] val_12 = new string[2];
            val_12[0] = "RemnantCollected";
            val_12[1] = "ShockWindowIncrease";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_9 == null)
            {
                goto label_42;
            }
            
            if(val_13 != null)
            {
                goto label_43;
            }
            
            goto label_46;
            label_42:
            if(val_13 == null)
            {
                goto label_46;
            }
            
            label_43:
            label_46:
            val_9[0] = val_13;
            string[] val_16 = new string[1];
            val_16[0] = "RemnantDebuff";
            val_9[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  REMNANT_DEBUFF_DATA.Types.ENTRY.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_18 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.REMNANT_DEBUFF_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_57;
            }
            
            if(val_18 != null)
            {
                goto label_58;
            }
            
            goto label_61;
            label_57:
            if(val_18 == null)
            {
                goto label_61;
            }
            
            label_58:
            label_61:
            val_5[0] = val_18;
            val_21 = null;
            ProtoData.REMNANTDEBUFFDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
