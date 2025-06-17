using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class STOREDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.STOREDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static STOREDATAReflection()
        {
            System.Type val_35;
            System.Type val_36;
            System.Type val_37;
            var val_38;
            string[] val_1 = new string[43];
            val_1[0] = "ChBTVE9SRV9EQVRBLnByb3RvEglQcm90b0RhdGEi0A4KClNUT1JFX0RBVEES";
            val_1[1] = "LAoHRW50cmllcxgBIAMoCzIbLlByb3RvRGF0YS5TVE9SRV9EQVRBLkVOVFJZ";
            val_1[2] = "GpMOCgVFTlRSWRIaChJQdXJjaGFzYWJsZUxvZ2ljYWwYASABKAkSFwoPUHVy";
            val_1[3] = "Y2hhc2FibGVOYW1lGAIgASgJEhoKElB1cmNoYXNhYmxlTmFtZVJlZhgDIAEo";
            val_1[4] = "CRIRCglMaXZlU3RhdGUYBCABKAkSEwoLRGVzY3JpcHRpb24YBSABKAkSFgoO";
            val_1[5] = "RGVzY3JpcHRpb25SZWYYBiABKAkSFAoMU3RvcmVTZWN0aW9uGAcgASgJEg0K";
            val_1[6] = "BU9yZGVyGAggASgBEhQKDERpc3BsYXlMb2dpYxgJIAEoCRIOCgZBcnRSZWYY";
            val_1[7] = "CiABKAkSEgoKUmVwZWF0YWJsZRgLIAEoCRIUCgxTdWJzY3JpcHRpb24YDCAB";
            val_1[8] = "KAkSLgoEQ29zdBgNIAEoCzIgLlByb3RvRGF0YS5TVE9SRV9EQVRBLkVOVFJZ";
            val_1[9] = "LkNPU1QSNgoIQ29udGVudHMYDiABKAsyJC5Qcm90b0RhdGEuU1RPUkVfREFU";
            val_1[10] = "QS5FTlRSWS5DT05URU5UUxIUCgxEaWFsb2dBcnRSZWYYDyABKAkSMAoFQmFk";
            val_1[11] = "Z2UYECABKAsyIS5Qcm90b0RhdGEuU1RPUkVfREFUQS5FTlRSWS5CQURHRRpN";
            val_1[12] = "CgRDT1NUEhQKDEhhcmRDdXJyZW5jeRgBIAEoARIUCgxTb2Z0Q3VycmVuY3kY";
            val_1[13] = "AiABKAESGQoRRGlzY291bnRDb25kaXRpb24YBCABKAka0QkKCENPTlRFTlRT";
            val_1[14] = "EjgKBUl0ZW0xGAEgASgLMikuUHJvdG9EYXRhLlNUT1JFX0RBVEEuRU5UUlku";
            val_1[15] = "Q09OVEVOVFMuSVRFTRI4CgVJdGVtMhgCIAEoCzIpLlByb3RvRGF0YS5TVE9S";
            val_1[16] = "RV9EQVRBLkVOVFJZLkNPTlRFTlRTLklURU0SOAoFSXRlbTMYAyABKAsyKS5Q";
            val_1[17] = "cm90b0RhdGEuU1RPUkVfREFUQS5FTlRSWS5DT05URU5UUy5JVEVNEjgKBUl0";
            val_1[18] = "ZW00GAQgASgLMikuUHJvdG9EYXRhLlNUT1JFX0RBVEEuRU5UUlkuQ09OVEVO";
            val_1[19] = "VFMuSVRFTRI4CgVJdGVtNRgFIAEoCzIpLlByb3RvRGF0YS5TVE9SRV9EQVRB";
            val_1[20] = "LkVOVFJZLkNPTlRFTlRTLklURU0SOAoFSXRlbTYYBiABKAsyKS5Qcm90b0Rh";
            val_1[21] = "dGEuU1RPUkVfREFUQS5FTlRSWS5DT05URU5UUy5JVEVNEjgKBUl0ZW03GAcg";
            val_1[22] = "ASgLMikuUHJvdG9EYXRhLlNUT1JFX0RBVEEuRU5UUlkuQ09OVEVOVFMuSVRF";
            val_1[23] = "TRI4CgVJdGVtOBgIIAEoCzIpLlByb3RvRGF0YS5TVE9SRV9EQVRBLkVOVFJZ";
            val_1[24] = "LkNPTlRFTlRTLklURU0SOAoFSXRlbTkYCSABKAsyKS5Qcm90b0RhdGEuU1RP";
            val_1[25] = "UkVfREFUQS5FTlRSWS5DT05URU5UUy5JVEVNEjkKBkl0ZW0xMBgKIAEoCzIp";
            val_1[26] = "LlByb3RvRGF0YS5TVE9SRV9EQVRBLkVOVFJZLkNPTlRFTlRTLklURU0SOQoG";
            val_1[27] = "SXRlbTExGAsgASgLMikuUHJvdG9EYXRhLlNUT1JFX0RBVEEuRU5UUlkuQ09O";
            val_1[28] = "VEVOVFMuSVRFTRI5CgZJdGVtMTIYDCABKAsyKS5Qcm90b0RhdGEuU1RPUkVf";
            val_1[29] = "REFUQS5FTlRSWS5DT05URU5UUy5JVEVNEjkKBkl0ZW0xMxgNIAEoCzIpLlBy";
            val_1[30] = "b3RvRGF0YS5TVE9SRV9EQVRBLkVOVFJZLkNPTlRFTlRTLklURU0SOQoGSXRl";
            val_1[31] = "bTE0GA4gASgLMikuUHJvdG9EYXRhLlNUT1JFX0RBVEEuRU5UUlkuQ09OVEVO";
            val_1[32] = "VFMuSVRFTRI5CgZJdGVtMTUYDyABKAsyKS5Qcm90b0RhdGEuU1RPUkVfREFU";
            val_1[33] = "QS5FTlRSWS5DT05URU5UUy5JVEVNEjkKBkl0ZW0xNhgQIAEoCzIpLlByb3Rv";
            val_1[34] = "RGF0YS5TVE9SRV9EQVRBLkVOVFJZLkNPTlRFTlRTLklURU0SOQoGSXRlbTE3";
            val_1[35] = "GBEgASgLMikuUHJvdG9EYXRhLlNUT1JFX0RBVEEuRU5UUlkuQ09OVEVOVFMu";
            val_1[36] = "SVRFTRI5CgZJdGVtMTgYEiABKAsyKS5Qcm90b0RhdGEuU1RPUkVfREFUQS5F";
            val_1[37] = "TlRSWS5DT05URU5UUy5JVEVNEjkKBkl0ZW0xORgTIAEoCzIpLlByb3RvRGF0";
            val_1[38] = "YS5TVE9SRV9EQVRBLkVOVFJZLkNPTlRFTlRTLklURU0SOQoGSXRlbTIwGBQg";
            val_1[39] = "ASgLMikuUHJvdG9EYXRhLlNUT1JFX0RBVEEuRU5UUlkuQ09OVEVOVFMuSVRF";
            val_1[40] = "TRoyCgRJVEVNEg8KB0xvZ2ljYWwYASABKAkSDAoEVHlwZRgCIAEoCRILCgNR";
            val_1[41] = "dHkYAyABKAEaMQoFQkFER0USEwoLQmFkZ2VBcnRSZWYYASABKAkSEwoLQmFk";
            val_1[42] = "Z2VMb2NSZWYYAiABKAliBnByb3RvMw==";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[16];
            val_12[0] = "PurchasableLogical";
            val_12[1] = "PurchasableName";
            val_12[2] = "PurchasableNameRef";
            val_12[3] = "LiveState";
            val_12[4] = "Description";
            val_12[5] = "DescriptionRef";
            val_12[6] = "StoreSection";
            val_12[7] = "Order";
            val_12[8] = "DisplayLogic";
            val_12[9] = "ArtRef";
            val_12[10] = "Repeatable";
            val_12[11] = "Subscription";
            val_12[12] = "Cost";
            val_12[13] = "Contents";
            val_12[14] = "DialogArtRef";
            val_12[15] = "Badge";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[3];
            string[] val_16 = new string[3];
            val_16[0] = "HardCurrency";
            val_16[1] = "SoftCurrency";
            val_16[2] = "DiscountCondition";
            val_13[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  STORE_DATA.Types.ENTRY.Types.COST.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_20 = new string[20];
            val_20[0] = "Item1";
            val_20[1] = "Item2";
            val_20[2] = "Item3";
            val_20[3] = "Item4";
            val_20[4] = "Item5";
            val_20[5] = "Item6";
            val_20[6] = "Item7";
            val_20[7] = "Item8";
            val_20[8] = "Item9";
            val_20[9] = "Item10";
            val_20[10] = "Item11";
            val_20[11] = "Item12";
            val_20[12] = "Item13";
            val_20[13] = "Item14";
            val_20[14] = "Item15";
            val_20[15] = "Item16";
            val_20[16] = "Item17";
            val_20[17] = "Item18";
            val_20[18] = "Item19";
            val_20[19] = "Item20";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_21 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_24 = new string[3];
            val_24[0] = "Logical";
            val_24[1] = "Type";
            val_24[2] = "Qty";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_25 = null;
            val_35 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_25 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_35, parser:  STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM.Parser, propertyNames:  val_24, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_25 != null) && (val_25 == null))
            {
                    val_35 = 0;
            }
            
            if(val_21.Length == 0)
            {
                    val_35 = 0;
            }
            
            val_21[0] = val_25;
            val_13[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  STORE_DATA.Types.ENTRY.Types.CONTENTS.Parser, propertyNames:  val_20, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_21);
            string[] val_29 = new string[2];
            val_29[0] = "BadgeArtRef";
            val_29[1] = "BadgeLocRef";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_30 = null;
            val_36 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_30 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_36, parser:  STORE_DATA.Types.ENTRY.Types.BADGE.Parser, propertyNames:  val_29, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_30 != null) && (val_30 == null))
            {
                    val_36 = 0;
            }
            
            if(val_13.Length <= 2)
            {
                    val_36 = 0;
            }
            
            val_13[2] = val_30;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_31 = null;
            val_37 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_31 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_37, parser:  STORE_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_13);
            if((val_31 != null) && (val_31 == null))
            {
                    val_37 = 0;
            }
            
            if(val_9.Length == 0)
            {
                    val_37 = 0;
            }
            
            val_9[0] = val_31;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_32 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.STORE_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == 0)
            {
                goto label_306;
            }
            
            if(val_32 != null)
            {
                goto label_307;
            }
            
            goto label_310;
            label_306:
            if(val_32 == null)
            {
                goto label_310;
            }
            
            label_307:
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_35 = val_5[4];
            label_310:
            mem[1152921524532628160] = val_32;
            val_38 = null;
            ProtoData.STOREDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
