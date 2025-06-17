using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class TUTORIALDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.TUTORIALDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TUTORIALDATAReflection()
        {
            System.Type val_34;
            System.Type val_35;
            var val_36;
            string[] val_1 = new string[15];
            val_1[0] = "ChNUVVRPUklBTF9EQVRBLnByb3RvEglQcm90b0RhdGEi0wQKDVRVVE9SSUFM";
            val_1[1] = "X0RBVEESLwoHRW50cmllcxgBIAMoCzIeLlByb3RvRGF0YS5UVVRPUklBTF9E";
            val_1[2] = "QVRBLkVOVFJZGpAECgVFTlRSWRIPCgdMb2dpY2FsGAEgASgJEjsKCUV2ZW50";
            val_1[3] = "SW5mbxgCIAEoCzIoLlByb3RvRGF0YS5UVVRPUklBTF9EQVRBLkVOVFJZLkVW";
            val_1[4] = "RU5USU5GTxJDCg1Db25kaXRpb25JbmZvGAMgASgLMiwuUHJvdG9EYXRhLlRV";
            val_1[5] = "VE9SSUFMX0RBVEEuRU5UUlkuQ09ORElUSU9OSU5GTxI9CgpBY3Rpb25JbmZv";
            val_1[6] = "GAQgASgLMikuUHJvdG9EYXRhLlRVVE9SSUFMX0RBVEEuRU5UUlkuQUNUSU9O";
            val_1[7] = "SU5GTxJFCg5SZXNvbHV0aW9uSW5mbxgFIAEoCzItLlByb3RvRGF0YS5UVVRP";
            val_1[8] = "UklBTF9EQVRBLkVOVFJZLlJFU09MVVRJT05JTkZPGjMKCUVWRU5USU5GTxIT";
            val_1[9] = "CgtHdWlkZUV2ZW50cxgBIAEoCRIRCglFdmVudEFyZ3MYAiABKAkaPwoNQ09O";
            val_1[10] = "RElUSU9OSU5GTxIXCg9HdWlkZUNvbmRpdGlvbnMYASABKAkSFQoNQ29uZGl0";
            val_1[11] = "aW9uQXJncxgCIAEoCRo1CgpBQ1RJT05JTkZPEhMKC0d1aWRlQWN0aW9uGAEg";
            val_1[12] = "ASgJEhIKCkFjdGlvbkFyZ3MYAiABKAkaQQoOUkVTT0xVVElPTklORk8SFwoP";
            val_1[13] = "R3VpZGVSZXNvbHV0aW9uGAEgASgJEhYKDlJlc29sdXRpb25BcmdzGAIgASgJ";
            val_1[14] = "YgZwcm90bzM=";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[5];
            val_12[0] = "Logical";
            val_12[1] = "EventInfo";
            val_12[2] = "ConditionInfo";
            val_12[3] = "ActionInfo";
            val_12[4] = "ResolutionInfo";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[4];
            string[] val_16 = new string[2];
            val_16[0] = "GuideEvents";
            val_16[1] = "EventArgs";
            val_13[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_20 = new string[2];
            val_20[0] = "GuideConditions";
            val_20[1] = "ConditionArgs";
            val_13[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO.Parser, propertyNames:  val_20, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_24 = new string[2];
            val_24[0] = "GuideAction";
            val_24[1] = "ActionArgs";
            val_13[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO.Parser, propertyNames:  val_24, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_28 = new string[2];
            val_28[0] = "GuideResolution";
            val_28[1] = "ResolutionArgs";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_29 = null;
            val_34 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_29 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_34, parser:  TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO.Parser, propertyNames:  val_28, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_29 != null) && (val_29 == null))
            {
                    val_34 = 0;
            }
            
            if(val_13.Length <= 3)
            {
                    val_34 = 0;
            }
            
            val_13[3] = val_29;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_30 = null;
            val_35 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_30 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_35, parser:  TUTORIAL_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_13);
            if(val_9 == null)
            {
                goto label_124;
            }
            
            if(val_30 != null)
            {
                goto label_125;
            }
            
            goto label_128;
            label_124:
            if(val_30 == null)
            {
                goto label_128;
            }
            
            label_125:
            if(val_30 == null)
            {
                    val_35 = 0;
            }
            
            label_128:
            if(val_9.Length == 0)
            {
                    val_35 = 0;
            }
            
            val_9[0] = val_30;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_31 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.TUTORIAL_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == null)
            {
                goto label_130;
            }
            
            if(val_31 != null)
            {
                goto label_131;
            }
            
            goto label_134;
            label_130:
            if(val_31 == null)
            {
                goto label_134;
            }
            
            label_131:
            label_134:
            val_5[0] = val_31;
            val_36 = null;
            ProtoData.TUTORIALDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
