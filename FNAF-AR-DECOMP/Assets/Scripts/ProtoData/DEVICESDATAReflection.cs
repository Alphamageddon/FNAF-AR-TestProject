using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class DEVICESDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.DEVICESDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static DEVICESDATAReflection()
        {
            System.Type val_55;
            System.Type val_56;
            System.Type val_57;
            var val_58;
            string[] val_1 = new string[34];
            val_1[0] = "ChJERVZJQ0VTX0RBVEEucHJvdG8SCVByb3RvRGF0YSKqCwoMREVWSUNFU19E";
            val_1[1] = "QVRBEi4KB0VudHJpZXMYASADKAsyHS5Qcm90b0RhdGEuREVWSUNFU19EQVRB";
            val_1[2] = "LkVOVFJZGukKCgVFTlRSWRIVCg1EZXZpY2VMb2dpY2FsGAEgASgJEhIKCkRl";
            val_1[3] = "dmljZU5hbWUYAiABKAkSEwoLRGVzY3JpcHRpb24YAyABKAkSEQoJTGl2ZVN0";
            val_1[4] = "YXRlGAQgASgJEjUKA01UWBgFIAEoCzIoLlByb3RvRGF0YS5ERVZJQ0VTX0RB";
            val_1[5] = "VEEuRU5UUlkuTVRYU0VDVElPThI8CgpFeHBpcmF0aW9uGAYgASgLMiguUHJv";
            val_1[6] = "dG9EYXRhLkRFVklDRVNfREFUQS5FTlRSWS5FWFBJUkFUSU9OEjYKB0VmZmVj";
            val_1[7] = "dHMYByABKAsyJS5Qcm90b0RhdGEuREVWSUNFU19EQVRBLkVOVFJZLkVGRkVD";
            val_1[8] = "VFMSDQoFT3JkZXIYCCABKAEaTAoKTVRYU0VDVElPThIYChBIYXJkQ3VycmVu";
            val_1[9] = "Y3lDb3N0GAEgASgBEhEKCVN0YWNrYWJsZRgCIAEoCBIRCglNaW5TdHJlYWsY";
            val_1[10] = "AyABKAEaPQoKRVhQSVJBVElPThIPCgdTZWNvbmRzGAEgASgBEg8KB1N1c3Bl";
            val_1[11] = "bmQYAiABKAkSDQoFQ291bnQYAyABKAEawwcKB0VGRkVDVFMSDAoEVHlwZRgB";
            val_1[12] = "IAEoCRI4CgRMdXJlGAIgASgLMiouUHJvdG9EYXRhLkRFVklDRVNfREFUQS5F";
            val_1[13] = "TlRSWS5FRkZFQ1RTLkxVUkUSSAoMRXh0cmFCYXR0ZXJ5GAMgASgLMjIuUHJv";
            val_1[14] = "dG9EYXRhLkRFVklDRVNfREFUQS5FTlRSWS5FRkZFQ1RTLkVYVFJBQkFUVEVS";
            val_1[15] = "WRJICgxTdXBlclNob2NrZXIYBCABKAsyMi5Qcm90b0RhdGEuREVWSUNFU19E";
            val_1[16] = "QVRBLkVOVFJZLkVGRkVDVFMuU1VQRVJTSE9DS0VSEkwKDlNhbHZhZ2VTY2Fu";
            val_1[17] = "bmVyGAUgASgLMjQuUHJvdG9EYXRhLkRFVklDRVNfREFUQS5FTlRSWS5FRkZF";
            val_1[18] = "Q1RTLlNBTFZBR0VTQ0FOTkVSEkAKCEVNRk1ldGVyGAYgASgLMi4uUHJvdG9E";
            val_1[19] = "YXRhLkRFVklDRVNfREFUQS5FTlRSWS5FRkZFQ1RTLkVNRk1FVEVSEkgKDEhv";
            val_1[20] = "bWVJbnZhc2lvbhgHIAEoCzIyLlByb3RvRGF0YS5ERVZJQ0VTX0RBVEEuRU5U";
            val_1[21] = "UlkuRUZGRUNUUy5IT01FSU5WQVNJT04aOgoETFVSRRILCgNNaW4YASABKAES";
            val_1[22] = "CwoDTWF4GAIgASgBEhgKEEFuaW1hdHJvbmljTHVyZWQYAyABKAkaUQoMRVhU";
            val_1[23] = "UkFCQVRURVJZEhQKDEJhdHRlcnlCb251cxgBIAEoARISCgpCYXR0ZXJ5RHVy";
            val_1[24] = "GAIgASgBEhcKD0JhdHRlcnlBY3RpdmF0ZRgDIAEoARojCgxTVVBFUlNIT0NL";
            val_1[25] = "RVISEwoLU2V0UmVjaGFyZ2UYASABKAEaUgoOU0FMVkFHRVNDQU5ORVISEgoK";
            val_1[26] = "UGFydHNCb251cxgBIAEoARISCgpTdHVmZkJvbnVzGAIgASgBEhgKEE1hbGZ1";
            val_1[27] = "bmN0aW9uQm9udXMYAyABKAEaHwoIRU1GTUVURVISEwoLUmFyaXR5Qm9udXMY";
            val_1[28] = "ASABKAEa2AEKDEhPTUVJTlZBU0lPThILCgNNaW4YASABKAESCwoDTWF4GAIg";
            val_1[29] = "ASgBEhQKDEFuaW1hdHJvbmljMRgDIAEoCRIUCgxBbmltYXRyb25pYzIYBCAB";
            val_1[30] = "KAkSFAoMQW5pbWF0cm9uaWMzGAUgASgJEhQKDEFuaW1hdHJvbmljNBgGIAEo";
            val_1[31] = "CRIUCgxBbmltYXRyb25pYzUYByABKAkSFAoMQW5pbWF0cm9uaWM2GAggASgJ";
            val_1[32] = "EhQKDEFuaW1hdHJvbmljNxgJIAEoCRIUCgxBbmltYXRyb25pYzgYCiABKAli";
            val_1[33] = "BnByb3RvMw==";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[8];
            val_12[0] = "DeviceLogical";
            val_12[1] = "DeviceName";
            val_12[2] = "Description";
            val_12[3] = "LiveState";
            val_12[4] = "MTX";
            val_12[5] = "Expiration";
            val_12[6] = "Effects";
            val_12[7] = "Order";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[3];
            string[] val_16 = new string[3];
            val_16[0] = "HardCurrencyCost";
            val_16[1] = "Stackable";
            val_16[2] = "MinStreak";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_17 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DEVICES_DATA.Types.ENTRY.Types.MTXSECTION.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_13 == null)
            {
                goto label_153;
            }
            
            if(val_17 != null)
            {
                goto label_154;
            }
            
            goto label_157;
            label_153:
            if(val_17 == null)
            {
                goto label_157;
            }
            
            label_154:
            label_157:
            val_13[0] = val_17;
            string[] val_20 = new string[3];
            val_20[0] = "Seconds";
            val_20[1] = "Suspend";
            val_20[2] = "Count";
            val_13[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DEVICES_DATA.Types.ENTRY.Types.EXPIRATION.Parser, propertyNames:  val_20, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_24 = new string[7];
            val_24[0] = "Type";
            val_24[1] = "Lure";
            val_24[2] = "ExtraBattery";
            val_24[3] = "SuperShocker";
            val_24[4] = "SalvageScanner";
            val_24[5] = "EMFMeter";
            val_24[6] = "HomeInvasion";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_25 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[6];
            string[] val_28 = new string[3];
            val_28[0] = "Min";
            val_28[1] = "Max";
            val_28[2] = "AnimatronicLured";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_29 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE.Parser, propertyNames:  val_28, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_25 == null)
            {
                goto label_210;
            }
            
            if(val_29 != null)
            {
                goto label_211;
            }
            
            goto label_214;
            label_210:
            if(val_29 == null)
            {
                goto label_214;
            }
            
            label_211:
            label_214:
            val_25[0] = val_29;
            string[] val_32 = new string[3];
            val_32[0] = "BatteryBonus";
            val_32[1] = "BatteryDur";
            val_32[2] = "BatteryActivate";
            val_25[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY.Parser, propertyNames:  val_32, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_36 = new string[1];
            val_36[0] = "SetRecharge";
            val_25[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER.Parser, propertyNames:  val_36, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_40 = new string[3];
            val_40[0] = "PartsBonus";
            val_40[1] = "StuffBonus";
            val_40[2] = "MalfunctionBonus";
            val_25[3] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER.Parser, propertyNames:  val_40, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_44 = new string[1];
            val_44[0] = "RarityBonus";
            val_25[4] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER.Parser, propertyNames:  val_44, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_48 = new string[10];
            val_48[0] = "Min";
            val_48[1] = "Max";
            val_48[2] = "Animatronic1";
            val_48[3] = "Animatronic2";
            val_48[4] = "Animatronic3";
            val_48[5] = "Animatronic4";
            val_48[6] = "Animatronic5";
            val_48[7] = "Animatronic6";
            val_48[8] = "Animatronic7";
            val_48[9] = "Animatronic8";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_49 = null;
            val_55 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_49 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_55, parser:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION.Parser, propertyNames:  val_48, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_49 != null) && (val_49 == null))
            {
                    val_55 = 0;
            }
            
            if(val_25.Length <= 5)
            {
                    val_55 = 0;
            }
            
            val_25[5] = val_49;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_50 = null;
            val_56 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_50 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_56, parser:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Parser, propertyNames:  val_24, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_25);
            if((val_50 != null) && (val_50 == null))
            {
                    val_56 = 0;
            }
            
            if(val_13.Length <= 2)
            {
                    val_56 = 0;
            }
            
            val_13[2] = val_50;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_51 = null;
            val_57 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_51 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_57, parser:  DEVICES_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_13);
            if(val_9 == 0)
            {
                goto label_303;
            }
            
            if(val_51 != null)
            {
                goto label_304;
            }
            
            goto label_307;
            label_303:
            if(val_51 == null)
            {
                goto label_307;
            }
            
            label_304:
            val_57 = val_9[4];
            if(val_51 == null)
            {
                    val_57 = 0;
            }
            
            label_307:
            if(mem[1152921524277697672] == 0)
            {
                    val_57 = 0;
            }
            
            mem[1152921524277697680] = val_51;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_52 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.DEVICES_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == 0)
            {
                goto label_309;
            }
            
            if(val_52 != null)
            {
                goto label_310;
            }
            
            goto label_313;
            label_309:
            if(val_52 == null)
            {
                goto label_313;
            }
            
            label_310:
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_55 = val_5[4];
            label_313:
            mem[1152921524277681264] = val_52;
            val_58 = null;
            ProtoData.DEVICESDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
