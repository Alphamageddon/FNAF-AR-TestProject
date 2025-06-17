using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AUDIODATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.AUDIODATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AUDIODATAReflection()
        {
            System.Type val_27;
            System.Type val_28;
            System.Type val_29;
            var val_30;
            string[] val_1 = new string[16];
            val_1[0] = "ChBBVURJT19EQVRBLnByb3RvEglQcm90b0RhdGEi/wQKCkFVRElPX0RBVEES";
            val_1[1] = "LAoHRW50cmllcxgBIAMoCzIbLlByb3RvRGF0YS5BVURJT19EQVRBLkVOVFJZ";
            val_1[2] = "GsIECgVFTlRSWRIWCg5HYW1lQXVkaW9FdmVudBgBIAEoCRJGChBXd2lzZUF1";
            val_1[3] = "ZGlvRXZlbnRzGAIgASgLMiwuUHJvdG9EYXRhLkFVRElPX0RBVEEuRU5UUlku";
            val_1[4] = "V1dJU0VBVURJT0VWRU5UUxIjChtBbmltYXRyb25pY1NwZWNpZmljQmVoYXZp";
            val_1[5] = "b3IYAyABKAkaswMKEFdXSVNFQVVESU9FVkVOVFMSSwoGRXZlbnQxGAEgASgL";
            val_1[6] = "MjsuUHJvdG9EYXRhLkFVRElPX0RBVEEuRU5UUlkuV1dJU0VBVURJT0VWRU5U";
            val_1[7] = "Uy5XV0lTRUVWRU5USU5GTxJLCgZFdmVudDIYAiABKAsyOy5Qcm90b0RhdGEu";
            val_1[8] = "QVVESU9fREFUQS5FTlRSWS5XV0lTRUFVRElPRVZFTlRTLldXSVNFRVZFTlRJ";
            val_1[9] = "TkZPEksKBkV2ZW50MxgDIAEoCzI7LlByb3RvRGF0YS5BVURJT19EQVRBLkVO";
            val_1[10] = "VFJZLldXSVNFQVVESU9FVkVOVFMuV1dJU0VFVkVOVElORk8SSwoGRXZlbnQ0";
            val_1[11] = "GAQgASgLMjsuUHJvdG9EYXRhLkFVRElPX0RBVEEuRU5UUlkuV1dJU0VBVURJ";
            val_1[12] = "T0VWRU5UUy5XV0lTRUVWRU5USU5GTxJLCgZFdmVudDUYBSABKAsyOy5Qcm90";
            val_1[13] = "b0RhdGEuQVVESU9fREFUQS5FTlRSWS5XV0lTRUFVRElPRVZFTlRTLldXSVNF";
            val_1[14] = "RVZFTlRJTkZPGh4KDldXSVNFRVZFTlRJTkZPEgwKBE5hbWUYASABKAliBnBy";
            val_1[15] = "b3RvMw==";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[3];
            val_12[0] = "GameAudioEvent";
            val_12[1] = "WwiseAudioEvents";
            val_12[2] = "AnimatronicSpecificBehavior";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_16 = new string[5];
            val_16[0] = "Event1";
            val_16[1] = "Event2";
            val_16[2] = "Event3";
            val_16[3] = "Event4";
            val_16[4] = "Event5";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_17 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_20 = new string[1];
            val_20[0] = "Name";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_21 = null;
            val_27 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_21 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_27, parser:  AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO.Parser, propertyNames:  val_20, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_21 != null) && (val_21 == null))
            {
                    val_27 = 0;
            }
            
            if(val_17.Length == 0)
            {
                    val_27 = 0;
            }
            
            val_17[0] = val_21;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_22 = null;
            val_28 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_22 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_28, parser:  AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_17);
            if(val_13 == null)
            {
                goto label_100;
            }
            
            if(val_22 != null)
            {
                goto label_101;
            }
            
            goto label_104;
            label_100:
            if(val_22 == null)
            {
                goto label_104;
            }
            
            label_101:
            if(val_22 == null)
            {
                    val_28 = 0;
            }
            
            label_104:
            if(val_13.Length == 0)
            {
                    val_28 = 0;
            }
            
            val_13[0] = val_22;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_23 = null;
            val_29 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_23 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_29, parser:  AUDIO_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_13);
            if(val_9 == null)
            {
                goto label_106;
            }
            
            if(val_23 != null)
            {
                goto label_107;
            }
            
            goto label_110;
            label_106:
            if(val_23 == null)
            {
                goto label_110;
            }
            
            label_107:
            if(val_23 == null)
            {
                    val_29 = 0;
            }
            
            label_110:
            if(val_9.Length == 0)
            {
                    val_29 = 0;
            }
            
            val_9[0] = val_23;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_24 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.AUDIO_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == 0)
            {
                goto label_112;
            }
            
            if(val_24 != null)
            {
                goto label_113;
            }
            
            goto label_116;
            label_112:
            if(val_24 == null)
            {
                goto label_116;
            }
            
            label_113:
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_27 = val_5[4];
            label_116:
            mem[1152921523957774704] = val_24;
            val_30 = null;
            ProtoData.AUDIODATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
