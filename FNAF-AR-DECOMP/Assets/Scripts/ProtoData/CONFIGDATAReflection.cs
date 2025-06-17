using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class CONFIGDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.CONFIGDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static CONFIGDATAReflection()
        {
            System.Type val_190;
            System.Type val_191;
            System.Type val_192;
            var val_193;
            string[] val_1 = new string[173];
            val_1[0] = "ChFDT05GSUdfREFUQS5wcm90bxIJUHJvdG9EYXRhIr48CgtDT05GSUdfREFU";
            val_1[1] = "QRItCgdFbnRyaWVzGAEgAygLMhwuUHJvdG9EYXRhLkNPTkZJR19EQVRBLkVO";
            val_1[2] = "VFJZGv87CgVFTlRSWRJJChFBbmltYXRyb25pY0FsZXJ0cxgBIAEoCzIuLlBy";
            val_1[3] = "b3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5BTklNQVRST05JQ0FMRVJUUxJB";
            val_1[4] = "Cg1QYXNzaXZlQWxlcnRzGAIgASgLMiouUHJvdG9EYXRhLkNPTkZJR19EQVRB";
            val_1[5] = "LkVOVFJZLlBBU1NJVkVBTEVSVFMSRQoPQmF0dGVyeUJlaGF2aW9yGAMgASgL";
            val_1[6] = "MiwuUHJvdG9EYXRhLkNPTkZJR19EQVRBLkVOVFJZLkJBVFRFUllCRUhBVklP";
            val_1[7] = "UhJFCg9OdW1BbmltYXRyb25pY3MYBCABKAsyLC5Qcm90b0RhdGEuQ09ORklH";
            val_1[8] = "X0RBVEEuRU5UUlkuTlVNQU5JTUFUUk9OSUNTEk0KE0FuaW1hdHJvbmljU3Bh";
            val_1[9] = "d25pbmcYBSABKAsyMC5Qcm90b0RhdGEuQ09ORklHX0RBVEEuRU5UUlkuQU5J";
            val_1[10] = "TUFUUk9OSUNTUEFXTklORxJJChFFc3NlbmNlQ29sbGVjdGlvbhgGIAEoCzIu";
            val_1[11] = "LlByb3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5FU1NFTkNFQ09MTEVDVElP";
            val_1[12] = "ThJFCg9TaG9ja2VyQmVoYXZpb3IYByABKAsyLC5Qcm90b0RhdGEuQ09ORklH";
            val_1[13] = "X0RBVEEuRU5UUlkuU0hPQ0tFUkJFSEFWSU9SEksKEkZsYXNobGlnaHRCZWhh";
            val_1[14] = "dmlvchgIIAEoCzIvLlByb3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5GTEFT";
            val_1[15] = "SExJR0hUQkVIQVZJT1ISQQoNTm9kZVBsYWNlbWVudBgJIAEoCzIqLlByb3Rv";
            val_1[16] = "RGF0YS5DT05GSUdfREFUQS5FTlRSWS5OT0RFUExBQ0VNRU5UEjsKClNjYXZl";
            val_1[17] = "bmdpbmcYCiABKAsyJy5Qcm90b0RhdGEuQ09ORklHX0RBVEEuRU5UUlkuU0NB";
            val_1[18] = "VkVOR0lORxI5CglHbGl0Y2hpbmcYCyABKAsyJi5Qcm90b0RhdGEuQ09ORklH";
            val_1[19] = "X0RBVEEuRU5UUlkuR0xJVENISU5HEi0KA1B2UBgMIAEoCzIgLlByb3RvRGF0";
            val_1[20] = "YS5DT05GSUdfREFUQS5FTlRSWS5QVlASNQoHUmFtcGFnZRgNIAEoCzIkLlBy";
            val_1[21] = "b3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5SQU1QQUdFEkcKEFBsYXllckZh";
            val_1[22] = "Y2luZ1RleHQYDiABKAsyLS5Qcm90b0RhdGEuQ09ORklHX0RBVEEuRU5UUlku";
            val_1[23] = "UExBWUVSRkFDSU5HVEVYVBI3CghXb3Jrc2hvcBgPIAEoCzIlLlByb3RvRGF0";
            val_1[24] = "YS5DT05GSUdfREFUQS5FTlRSWS5XT1JLU0hPUBI9CgtEYWlseUFsZXJ0cxgQ";
            val_1[25] = "IAEoCzIoLlByb3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5EQUlMWUFMRVJU";
            val_1[26] = "UxI5CglBcnRBc3NldHMYESABKAsyJi5Qcm90b0RhdGEuQ09ORklHX0RBVEEu";
            val_1[27] = "RU5UUlkuQVJUQVNTRVRTEkUKD0V4cHJlc3NEZWxpdmVyeRgSIAEoCzIsLlBy";
            val_1[28] = "b3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5FWFBSRVNTREVMSVZFUlkSRwoQ";
            val_1[29] = "SW5ib3hCYXRjaExpbWl0cxgTIAEoCzItLlByb3RvRGF0YS5DT05GSUdfREFU";
            val_1[30] = "QS5FTlRSWS5JTkJPWEJBVENITElNSVRTEkUKD0RhaWx5Q2hhbGxlbmdlcxgU";
            val_1[31] = "IAEoCzIsLlByb3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5EQUlMWUNIQUxM";
            val_1[32] = "RU5HRVMSLQoDQWRzGBUgASgLMiAuUHJvdG9EYXRhLkNPTkZJR19EQVRBLkVO";
            val_1[33] = "VFJZLkFEUxqAAQoRQU5JTUFUUk9OSUNBTEVSVFMSIQoZQW5pbWF0cm9uaWNB";
            val_1[34] = "bGVydFBlcmlvZFNlYxgBIAEoARIjChtBbmltYXRyb25pY0FsZXJ0Q2hlY2tD";
            val_1[35] = "aGFuY2UYAiABKAESIwobQW5pbWF0cm9uaWNBbGVydENvb2xkb3duU2VjGAMg";
            val_1[36] = "ASgBGnAKDVBBU1NJVkVBTEVSVFMSHQoVUGFzc2l2ZUFsZXJ0UGVyaW9kU2Vj";
            val_1[37] = "GAEgASgBEh8KF1Bhc3NpdmVBbGVydENoZWNrQ2hhbmNlGAIgASgBEh8KF1Bh";
            val_1[38] = "c3NpdmVBbGVydENvb2xkb3duU2VjGAMgASgBGkkKC0RBSUxZQUxFUlRTEhsK";
            val_1[39] = "E0RhaWx5QWxlcnRQZXJpb2RTZWMYASABKAESHQoVRGFpbHlBbGVydENoZWNr";
            val_1[40] = "Q2hhbmNlGAIgASgBGi8KD1NIT0NLRVJCRUhBVklPUhIcChRTaG9ja2VyQ29v";
            val_1[41] = "bGRvd25UaW1lchgBIAEoARqTAgoPQkFUVEVSWUJFSEFWSU9SEhgKEEJhdHRl";
            val_1[42] = "cnlTdHVuRHJhaW4YASABKAESGAoQQmF0dGVyeUJhc2VEcmFpbhgCIAEoARIb";
            val_1[43] = "ChNCYXR0ZXJ5QmFzZVJlY2hhcmdlGAMgASgBEh0KFUV4dHJhQmF0dGVyeVBh";
            val_1[44] = "Y2tCb29zdBgEIAEoARIZChFCYXR0ZXJ5U2hvY2tEcmFpbhgFIAEoARIXCg9G";
            val_1[45] = "bGFzaGxpZ2h0RHJhaW4YBiABKAESHQoVRXh0cmFCYXR0ZXJ5UGFja1RpbWVy";
            val_1[46] = "GAcgASgBEh4KFkVzc2VuY2VGbGFzaGxpZ2h0RHJhaW4YCCABKAESHQoVQWxs";
            val_1[47] = "b3dlZEV4dHJhQmF0dGVyaWVzGAkgASgBGugDChJGTEFTSExJR0hUQkVIQVZJ";
            val_1[48] = "T1ISXAoRRmxhc2hsaWdodE9uVGltZXIYASABKAsyQS5Qcm90b0RhdGEuQ09O";
            val_1[49] = "RklHX0RBVEEuRU5UUlkuRkxBU0hMSUdIVEJFSEFWSU9SLkZMQVNITElHSFRP";
            val_1[50] = "TlRJTUVSEmYKFkZsYXNobGlnaHRGbGlja2VyVGltZXIYAiABKAsyRi5Qcm90";
            val_1[51] = "b0RhdGEuQ09ORklHX0RBVEEuRU5UUlkuRkxBU0hMSUdIVEJFSEFWSU9SLkZM";
            val_1[52] = "QVNITElHSFRGTElDS0VSVElNRVISXgoSRmxhc2hsaWdodE9mZlRpbWVyGAMg";
            val_1[53] = "ASgLMkIuUHJvdG9EYXRhLkNPTkZJR19EQVRBLkVOVFJZLkZMQVNITElHSFRC";
            val_1[54] = "RUhBVklPUi5GTEFTSExJR0hUT0ZGVElNRVISGQoRRmxhc2hsaWdodE9mZk11";
            val_1[55] = "bHQYBCABKAEaLQoRRkxBU0hMSUdIVE9OVElNRVISCwoDTWluGAEgASgBEgsK";
            val_1[56] = "A01heBgCIAEoARoyChZGTEFTSExJR0hURkxJQ0tFUlRJTUVSEgsKA01pbhgB";
            val_1[57] = "IAEoARILCgNNYXgYAiABKAEaLgoSRkxBU0hMSUdIVE9GRlRJTUVSEgsKA01p";
            val_1[58] = "bhgBIAEoARILCgNNYXgYAiABKAEaoQEKDU5PREVQTEFDRU1FTlQSSwoLQ29u";
            val_1[59] = "bmVjdGlvbnMYASABKAsyNi5Qcm90b0RhdGEuQ09ORklHX0RBVEEuRU5UUlku";
            val_1[60] = "Tk9ERVBMQUNFTUVOVC5DT05ORUNUSU9OUxIaChJQcmVmTm9kZVRvTm9kZURp";
            val_1[61] = "c3QYAiABKAEaJwoLQ09OTkVDVElPTlMSCwoDTWluGAEgASgBEgsKA01heBgC";
            val_1[62] = "IAEoARqJAQoTQU5JTUFUUk9OSUNTUEFXTklORxITCgtTcGF3blBlcmlvZBgB";
            val_1[63] = "IAEoARITCgtTcGF3bkNoYW5jZRgCIAEoARIYChBTcGF3bk1heERlcGxveWVk";
            val_1[64] = "GAMgASgBEhYKDk1hcFNwYXduUGVyaW9kGAQgASgBEhYKDk1hcFNwYXduQ2hh";
            val_1[65] = "bmNlGAUgASgBGuQWChFFU1NFTkNFQ09MTEVDVElPThJFCgZEZXRlY3QYASAB";
            val_1[66] = "KAsyNS5Qcm90b0RhdGEuQ09ORklHX0RBVEEuRU5UUlkuRVNTRU5DRUNPTExF";
            val_1[67] = "Q1RJT04uREVURUNUEkkKCFBoYW50YXNtGAIgASgLMjcuUHJvdG9EYXRhLkNP";
            val_1[68] = "TkZJR19EQVRBLkVOVFJZLkVTU0VOQ0VDT0xMRUNUSU9OLlBIQU5UQVNNElMK";
            val_1[69] = "DUVzc2VuY2VSZXdhcmQYAyABKAsyPC5Qcm90b0RhdGEuQ09ORklHX0RBVEEu";
            val_1[70] = "RU5UUlkuRVNTRU5DRUNPTExFQ1RJT04uRVNTRU5DRVJFV0FSRBIYChBFc3Nl";
            val_1[71] = "bmNlTWluUmV3YXJkGAQgASgBElEKDENsb2FrRGVjbG9haxgFIAEoCzI7LlBy";
            val_1[72] = "b3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5FU1NFTkNFQ09MTEVDVElPTi5D";
            val_1[73] = "TE9BS0RFQ0xPQUsSUwoNR2VpZ2VyQ291bnRlchgGIAEoCzI8LlByb3RvRGF0";
            val_1[74] = "YS5DT05GSUdfREFUQS5FTlRSWS5FU1NFTkNFQ09MTEVDVElPTi5HRUlHRVJD";
            val_1[75] = "T1VOVEVSElUKDlBhcnRpY2xlVmFjdXVtGAcgASgLMj0uUHJvdG9EYXRhLkNP";
            val_1[76] = "TkZJR19EQVRBLkVOVFJZLkVTU0VOQ0VDT0xMRUNUSU9OLlBBUlRJQ0xFVkFD";
            val_1[77] = "VVVNEkMKBU1vdGVzGAggASgLMjQuUHJvdG9EYXRhLkNPTkZJR19EQVRBLkVO";
            val_1[78] = "VFJZLkVTU0VOQ0VDT0xMRUNUSU9OLk1PVEVTEk8KC1RocmVhdFBpbGxzGAkg";
            val_1[79] = "ASgLMjouUHJvdG9EYXRhLkNPTkZJR19EQVRBLkVOVFJZLkVTU0VOQ0VDT0xM";
            val_1[80] = "RUNUSU9OLlRIUkVBVFBJTExTElkKEFRocmVhdENvbGxlY3Rpb24YCiABKAsy";
            val_1[81] = "Py5Qcm90b0RhdGEuQ09ORklHX0RBVEEuRU5UUlkuRVNTRU5DRUNPTExFQ1RJ";
            val_1[82] = "T04uVEhSRUFUQ09MTEVDVElPThrbAgoGREVURUNUEh0KFU9iamVjdERldGVj";
            val_1[83] = "dGlvblBlcmlvZBgBIAEoARIXCg9Fc3NlbmNlVHJhaWxEdXIYAiABKAESGAoQ";
            val_1[84] = "RXNzZW5jZU9iamVjdER1chgDIAEoARIZChFCYXNlRGlzcGxheUNoYW5jZRgE";
            val_1[85] = "IAEoARISCgpIb3Jpem9uTW9kGAUgASgBEhUKDUhvcml6b25CdWZmZXIYBiAB";
            val_1[86] = "KAESEgoKQ29uZmlkZW5jZRgHIAEoARIWCg5HbG9iYWxDb29sZG93bhgIIAEo";
            val_1[87] = "ARIYChBDYXRlZ29yeUNvb2xkb3duGAkgASgBEh0KFUNhdGVnb3J5U3RyZWFr";
            val_1[88] = "YnJlYWtlchgKIAEoARIaChJEaXN0YW5jZUZyb21DYW1lcmEYCyABKAESHgoW";
            val_1[89] = "QVJPYmplY3RUb0Vzc2VuY2VEZWxheRgMIAEoARIYChBPdmVycmlkZUNvb2xk";
            val_1[90] = "b3duGA0gASgBGkEKCFBIQU5UQVNNEg4KBlBlcmlvZBgBIAEoARITCgtTcGF3";
            val_1[91] = "bkNoYW5jZRgCIAEoARIQCghDb29sZG93bhgDIAEoARqjAQoMQ0xPQUtERUNM";
            val_1[92] = "T0FLEiMKG0RlbGF5SW5TZWNvbmRzQmVmb3JlRGVjbG9haxgBIAEoARIaChJD";
            val_1[93] = "ZW50ZXJPZlNjcmVlbk1pblgYAiABKAESGgoSQ2VudGVyT2ZTY3JlZW5NYXhY";
            val_1[94] = "GAMgASgBEhoKEkNlbnRlck9mU2NyZWVuTWluWRgEIAEoARIaChJDZW50ZXJP";
            val_1[95] = "ZlNjcmVlbk1heFkYBSABKAEaWwoNR0VJR0VSQ09VTlRFUhIWCg5NYXhBbmds";
            val_1[96] = "ZURldGVjdBgBIAEoARIYChBNaW5UaWNrSW5TZWNvbmRzGAIgASgBEhgKEE1h";
            val_1[97] = "eFRpY2tJblNlY29uZHMYAyABKAEa1wEKDlBBUlRJQ0xFVkFDVVVNEhcKD0Rl";
            val_1[98] = "dGFjaEZyZXF1ZW5jeRgBIAEoARIXCg9NYXhpbXVtRGV0YWNoZWQYAiABKAES";
            val_1[99] = "FwoPQ29sbGVjdERpc3RhbmNlGAcgASgBEh4KFkNvbGxlY3Rpb25TY3JlZW5Q";
            val_1[100] = "b2ludFgYCCABKAESHgoWQ29sbGVjdGlvblNjcmVlblBvaW50WRgJIAEoARIb";
            val_1[101] = "ChNDb2xsZWN0RGlzdGFuY2VNb3RlGAogASgBEh0KFUNvbGxlY3REaXN0YW5j";
            val_1[102] = "ZVRocmVhdBgLIAEoARq4BAoFTU9URVMSFAoMTW90ZUxpZmV0aW1lGAEgASgB";
            val_1[103] = "EhYKDk1pbk9yYml0UmFkaXVzGAIgASgBEhYKDk1heE9yYml0UmFkaXVzGAMg";
            val_1[104] = "ASgBEhEKCVNwYXduVGltZRgEIAEoARIhChlNYXhWaXNpYmxlTW90ZXNQZXJF";
            val_1[105] = "c3NlbmNlGAUgASgBEhwKFE1pbkFuZ2xlU3BlZWREZWdyZWVzGAYgASgBEhwK";
            val_1[106] = "FE1heEFuZ2xlU3BlZWREZWdyZWVzGAcgASgBEhwKFE1heERlZ3JhZGVNdWx0";
            val_1[107] = "aXBsaWVyGAggASgBEhwKFE1pbkRlZ3JhZGVNdWx0aXBsaWVyGAkgASgBEhoK";
            val_1[108] = "Ek1pbkRlZ3JhZGVEaXN0YW5jZRgKIAEoARIaChJNYXhEZWdyYWRlRGlzdGFu";
            val_1[109] = "Y2UYCyABKAESHQoVU3RhcnRpbmdOdW1iZXJPZk1vdGVzGAwgASgBEhoKEk1h";
            val_1[110] = "eE1vdGVzUGVyRXNzZW5jZRgNIAEoARIcChRNaW5pbXVtRGV0YWNoZWRTcGVl";
            val_1[111] = "ZBgOIAEoARIcChRNYXhpbXVtRGV0YWNoZWRTcGVlZBgPIAEoARIcChREZXRh";
            val_1[112] = "Y2hlZEFjY2VsZXJhdGlvbhgQIAEoARIcChREZXRhY2hlZERlY2VsZXJhdGlv";
            val_1[113] = "bhgRIAEoARIdChVDb2xsZWN0Rmx1c2hCYXRjaFRpbWUYEiABKAESMQopQ29s";
            val_1[114] = "bGVjdFRpbWVUb1dhaXRUb1NlZUlmTW9yZU1vdGVzQ29taW5nSW4YEyABKAEa";
            val_1[115] = "hAQKC1RIUkVBVFBJTExTEhoKElRocmVhdFBpbGxMaWZldGltZRgBIAEoARIW";
            val_1[116] = "Cg5NaW5PcmJpdFJhZGl1cxgCIAEoARIWCg5NYXhPcmJpdFJhZGl1cxgDIAEo";
            val_1[117] = "ARIRCglTcGF3blRpbWUYBCABKAESJwofTWF4VmlzaWJsZVRocmVhdFBpbGxz";
            val_1[118] = "UGVyRXNzZW5jZRgFIAEoARIcChRNaW5BbmdsZVNwZWVkRGVncmVlcxgGIAEo";
            val_1[119] = "ARIcChRNYXhBbmdsZVNwZWVkRGVncmVlcxgHIAEoARIcChRNYXhEZWdyYWRl";
            val_1[120] = "TXVsdGlwbGllchgIIAEoARIcChRNaW5EZWdyYWRlTXVsdGlwbGllchgJIAEo";
            val_1[121] = "ARIaChJNaW5EZWdyYWRlRGlzdGFuY2UYCiABKAESGgoSTWF4RGVncmFkZURp";
            val_1[122] = "c3RhbmNlGAsgASgBEiMKG1N0YXJ0aW5nTnVtYmVyT2ZUaHJlYXRQaWxscxgM";
            val_1[123] = "IAEoARIgChhNYXhUaHJlYXRQaWxsc1BlckVzc2VuY2UYDSABKAESHAoUTWlu";
            val_1[124] = "aW11bURldGFjaGVkU3BlZWQYDiABKAESHAoUTWF4aW11bURldGFjaGVkU3Bl";
            val_1[125] = "ZWQYDyABKAESHAoURGV0YWNoZWRBY2NlbGVyYXRpb24YECABKAESHAoURGV0";
            val_1[126] = "YWNoZWREZWNlbGVyYXRpb24YESABKAEacwoQVEhSRUFUQ09MTEVDVElPThIi";
            val_1[127] = "ChpUaHJlYXRQZXJjZW50UGVyVGhyZWF0UGlsbBgBIAEoARIVCg1Ecm9wUGVy";
            val_1[128] = "U2Vjb25kGAIgASgBEiQKHENvbnNlY3V0aXZlVGhyZWF0UGVyY2VudE11bHQY";
            val_1[129] = "AyABKAEaKQoNRVNTRU5DRVJFV0FSRBILCgNNaW4YASABKAESCwoDTWF4GAIg";
            val_1[130] = "ASgBGpYDCgpTQ0FWRU5HSU5HEhMKC01heERlcGxveWVkGAEgASgBEg4KBlBl";
            val_1[131] = "cmlvZBgCIAEoARITCgtNYWxmdW5jdGlvbhgDIAEoARIZChFXZWFyQW5kVGVh";
            val_1[132] = "ckNoYW5jZRgEIAEoARJUChFXZWFyQW5kVGVhckRhbWFnZRgFIAEoCzI5LlBy";
            val_1[133] = "b3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5TQ0FWRU5HSU5HLldFQVJBTkRU";
            val_1[134] = "RUFSREFNQUdFEhgKEFJhcmVSZXdhcmRDaGFuY2UYBiABKAESFwoPUGx1c2hT";
            val_1[135] = "dWl0Q2hhbmNlGAcgASgBEhoKEkNvbW1vblJld2FyZENoYW5jZRgIIAEoARI8";
            val_1[136] = "CgVQYXJ0cxgJIAEoCzItLlByb3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5T";
            val_1[137] = "Q0FWRU5HSU5HLlBBUlRTGi0KEVdFQVJBTkRURUFSREFNQUdFEgsKA01pbhgB";
            val_1[138] = "IAEoARILCgNNYXgYAiABKAEaIQoFUEFSVFMSCwoDTWluGAEgASgBEgsKA01h";
            val_1[139] = "eBgCIAEoARp3CglHTElUQ0hJTkcSQwoJR2xpdGNoaW5nGAEgASgLMjAuUHJv";
            val_1[140] = "dG9EYXRhLkNPTkZJR19EQVRBLkVOVFJZLkdMSVRDSElORy5HTElUQ0hJTkca";
            val_1[141] = "JQoJR0xJVENISU5HEgsKA01pbhgBIAEoARILCgNNYXgYAiABKAEavQEKA1BW";
            val_1[142] = "UBJFCg1Ob3RpZmljYXRpb25zGAEgASgLMi4uUHJvdG9EYXRhLkNPTkZJR19E";
            val_1[143] = "QVRBLkVOVFJZLlBWUC5OT1RJRklDQVRJT05TGm8KDU5PVElGSUNBVElPTlMS";
            val_1[144] = "FgoOVG9UYXJnZXRPbkZhaWwYASABKAkSFgoOVG9UYXJnZXRPblN1Y2MYAiAB";
            val_1[145] = "KAkSFgoOVG9TZW5kZXJPbkZhaWwYAyABKAkSFgoOVG9TZW5kZXJPblN1Y2MY";
            val_1[146] = "BCABKAkaIwoHUkFNUEFHRRILCgNNaW4YASABKAESCwoDTWF4GAIgASgBGlcK";
            val_1[147] = "D05VTUFOSU1BVFJPTklDUxIdChVOdW1BbmltYXRyb25pY3NOb3JtYWwYASAB";
            val_1[148] = "KAESJQodTnVtQW5pbWF0cm9uaWNzTWFsZnVuY3Rpb25pbmcYAiABKAEaLAoQ";
            val_1[149] = "UExBWUVSRkFDSU5HVEVYVBIYChBQYXJ0c0Rlc2NyaXB0aW9uGAEgASgJGhwK";
            val_1[150] = "CFdPUktTSE9QEhAKCE1heFNsb3RzGAEgASgBGsMFCglBUlRBU1NFVFMSOwoF";
            val_1[151] = "QXVkaW8YASABKAsyLC5Qcm90b0RhdGEuQ09ORklHX0RBVEEuRU5UUlkuQVJU";
            val_1[152] = "QVNTRVRTLkFVRElPEjsKAlVJGAIgASgLMi8uUHJvdG9EYXRhLkNPTkZJR19E";
            val_1[153] = "QVRBLkVOVFJZLkFSVEFTU0VUUy5VSUFTU0VUUxqKAQoFQVVESU8SEwoLTXVz";
            val_1[154] = "aWNCdW5kbGUYASABKAkSFgoOTXVzaWNTb3VuZEJhbmsYAiABKAkSFAoMU2hh";
            val_1[155] = "cmVkQnVuZGxlGAMgASgJEhcKD1NoYXJlZFNvdW5kQmFuaxgEIAEoCRIQCghV";
            val_1[156] = "SUJ1bmRsZRgFIAEoCRITCgtVSVNvdW5kQmFuaxgGIAEoCRquAwoIVUlBU1NF";
            val_1[157] = "VFMSFgoOQ3B1SWNvbnNCdW5kbGUYASABKAkSFgoOTW9kSWNvbnNCdW5kbGUY";
            val_1[158] = "AiABKAkSHAoUUGx1c2hTdWl0SWNvbnNCdW5kbGUYAyABKAkSGwoTUG9ydHJh";
            val_1[159] = "aXRJY29uc0J1bmRsZRgEIAEoCRIZChFSZXdhcmRJY29uc0J1bmRsZRgFIAEo";
            val_1[160] = "CRIdChVFc3NlbmNlUmV3YXJkSWNvbk5hbWUYBiABKAkSGwoTUGFydHNSZXdh";
            val_1[161] = "cmRJY29uTmFtZRgHIAEoCRIeChZGYXpDb2luc1Jld2FyZEljb25OYW1lGAgg";
            val_1[162] = "ASgJEhgKEFN0b3JlSWNvbnNCdW5kbGUYCSABKAkSIQoZT25lT2ZmU2NyaXB0";
            val_1[163] = "ZWRJY29uc0J1bmRsZRgKIAEoCRImCh5FbmRvc2tlbGV0b25TbG90UmV3YXJk";
            val_1[164] = "SWNvbk5hbWUYCyABKAkSHQoVTW9kU2xvdFJld2FyZEljb25OYW1lGAwgASgJ";
            val_1[165] = "EhkKEVNob3BVSUljb25zQnVuZGxlGA0gASgJEiEKGURhaWx5Q2hhbGxlbmdl";
            val_1[166] = "c0ljb25CdW5kbGUYDiABKAkaJwoPRVhQUkVTU0RFTElWRVJZEhQKDENvc3RG";
            val_1[167] = "YXpDb2lucxgBIAEoARo7ChBJTkJPWEJBVENITElNSVRTEhEKCU1heERlbGV0";
            val_1[168] = "ZRgBIAEoARIUCgxNYXhTZXRUb1JlYWQYAiABKAEaIQoPREFJTFlDSEFMTEVO";
            val_1[169] = "R0VTEg4KBkVuYWJsZRgBIAEoCBqUAQoDQURTEjcKBlRhcGpveRgBIAEoCzIn";
            val_1[170] = "LlByb3RvRGF0YS5DT05GSUdfREFUQS5FTlRSWS5BRFMuVEFQSk9ZGlQKBlRB";
            val_1[171] = "UEpPWRIRCglJc0VuYWJsZWQYASABKAgSHAoUVXNlRmluYWxSZXdhcmREaWFs";
            val_1[172] = "b2cYAiABKAgSGQoRRW5hYmxlZFBsYWNlbWVudHMYAyABKAliBnByb3RvMw==";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_12 = new string[21];
            val_12[0] = "AnimatronicAlerts";
            val_12[1] = "PassiveAlerts";
            val_12[2] = "BatteryBehavior";
            val_12[3] = "NumAnimatronics";
            val_12[4] = "AnimatronicSpawning";
            val_12[5] = "EssenceCollection";
            val_12[6] = "ShockerBehavior";
            val_12[7] = "FlashlightBehavior";
            val_12[8] = "NodePlacement";
            val_12[9] = "Scavenging";
            val_12[10] = "Glitching";
            val_12[11] = "PvP";
            val_12[12] = "Rampage";
            val_12[13] = "PlayerFacingText";
            val_12[14] = "Workshop";
            val_12[15] = "DailyAlerts";
            val_12[16] = "ArtAssets";
            val_12[17] = "ExpressDelivery";
            val_12[18] = "InboxBatchLimits";
            val_12[19] = "DailyChallenges";
            val_12[20] = "Ads";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[21];
            string[] val_16 = new string[3];
            val_16[0] = "AnimatronicAlertPeriodSec";
            val_16[1] = "AnimatronicAlertCheckChance";
            val_16[2] = "AnimatronicAlertCooldownSec";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_17 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICALERTS.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_13 == null)
            {
                goto label_609;
            }
            
            if(val_17 != null)
            {
                goto label_610;
            }
            
            goto label_613;
            label_609:
            if(val_17 == null)
            {
                goto label_613;
            }
            
            label_610:
            label_613:
            val_13[0] = val_17;
            string[] val_20 = new string[3];
            val_20[0] = "PassiveAlertPeriodSec";
            val_20[1] = "PassiveAlertCheckChance";
            val_20[2] = "PassiveAlertCooldownSec";
            val_13[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS.Parser, propertyNames:  val_20, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_24 = new string[2];
            val_24[0] = "DailyAlertPeriodSec";
            val_24[1] = "DailyAlertCheckChance";
            val_13[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS.Parser, propertyNames:  val_24, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_28 = new string[1];
            val_28[0] = "ShockerCooldownTimer";
            val_13[3] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR.Parser, propertyNames:  val_28, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_32 = new string[9];
            val_32[0] = "BatteryStunDrain";
            val_32[1] = "BatteryBaseDrain";
            val_32[2] = "BatteryBaseRecharge";
            val_32[3] = "ExtraBatteryPackBoost";
            val_32[4] = "BatteryShockDrain";
            val_32[5] = "FlashlightDrain";
            val_32[6] = "ExtraBatteryPackTimer";
            val_32[7] = "EssenceFlashlightDrain";
            val_32[8] = "AllowedExtraBatteries";
            val_13[4] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR.Parser, propertyNames:  val_32, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_36 = new string[4];
            val_36[0] = "FlashlightOnTimer";
            val_36[1] = "FlashlightFlickerTimer";
            val_36[2] = "FlashlightOffTimer";
            val_36[3] = "FlashlightOffMult";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_37 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[3];
            string[] val_40 = new string[2];
            val_40[0] = "Min";
            val_40[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_41 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTONTIMER.Parser, propertyNames:  val_40, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_37 == null)
            {
                goto label_708;
            }
            
            if(val_41 != null)
            {
                goto label_709;
            }
            
            goto label_712;
            label_708:
            if(val_41 == null)
            {
                goto label_712;
            }
            
            label_709:
            label_712:
            val_37[0] = val_41;
            string[] val_44 = new string[2];
            val_44[0] = "Min";
            val_44[1] = "Max";
            val_37[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTFLICKERTIMER.Parser, propertyNames:  val_44, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_48 = new string[2];
            val_48[0] = "Min";
            val_48[1] = "Max";
            val_37[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTOFFTIMER.Parser, propertyNames:  val_48, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_13[5] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Parser, propertyNames:  val_36, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_37);
            string[] val_53 = new string[2];
            val_53[0] = "Connections";
            val_53[1] = "PrefNodeToNodeDist";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_54 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_57 = new string[2];
            val_57[0] = "Min";
            val_57[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_58 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Types.CONNECTIONS.Parser, propertyNames:  val_57, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_54 == null)
            {
                goto label_759;
            }
            
            if(val_58 != null)
            {
                goto label_760;
            }
            
            goto label_763;
            label_759:
            if(val_58 == null)
            {
                goto label_763;
            }
            
            label_760:
            label_763:
            val_54[0] = val_58;
            val_13[6] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Parser, propertyNames:  val_53, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_54);
            string[] val_62 = new string[5];
            val_62[0] = "SpawnPeriod";
            val_62[1] = "SpawnChance";
            val_62[2] = "SpawnMaxDeployed";
            val_62[3] = "MapSpawnPeriod";
            val_62[4] = "MapSpawnChance";
            val_13[7] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING.Parser, propertyNames:  val_62, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_66 = new string[10];
            val_66[0] = "Detect";
            val_66[1] = "Phantasm";
            val_66[2] = "EssenceReward";
            val_66[3] = "EssenceMinReward";
            val_66[4] = "CloakDecloak";
            val_66[5] = "GeigerCounter";
            val_66[6] = "ParticleVacuum";
            val_66[7] = "Motes";
            val_66[8] = "ThreatPills";
            val_66[9] = "ThreatCollection";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_67 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[9];
            string[] val_70 = new string[13];
            val_70[0] = "ObjectDetectionPeriod";
            val_70[1] = "EssenceTrailDur";
            val_70[2] = "EssenceObjectDur";
            val_70[3] = "BaseDisplayChance";
            val_70[4] = "HorizonMod";
            val_70[5] = "HorizonBuffer";
            val_70[6] = "Confidence";
            val_70[7] = "GlobalCooldown";
            val_70[8] = "CategoryCooldown";
            val_70[9] = "CategoryStreakbreaker";
            val_70[10] = "DistanceFromCamera";
            val_70[11] = "ARObjectToEssenceDelay";
            val_70[12] = "OverrideCooldown";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_71 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT.Parser, propertyNames:  val_70, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_67 == null)
            {
                goto label_864;
            }
            
            if(val_71 != null)
            {
                goto label_865;
            }
            
            goto label_868;
            label_864:
            if(val_71 == null)
            {
                goto label_868;
            }
            
            label_865:
            label_868:
            val_67[0] = val_71;
            string[] val_74 = new string[3];
            val_74[0] = "Period";
            val_74[1] = "SpawnChance";
            val_74[2] = "Cooldown";
            val_67[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM.Parser, propertyNames:  val_74, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_78 = new string[5];
            val_78[0] = "DelayInSecondsBeforeDecloak";
            val_78[1] = "CenterOfScreenMinX";
            val_78[2] = "CenterOfScreenMaxX";
            val_78[3] = "CenterOfScreenMinY";
            val_78[4] = "CenterOfScreenMaxY";
            val_67[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK.Parser, propertyNames:  val_78, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_82 = new string[3];
            val_82[0] = "MaxAngleDetect";
            val_82[1] = "MinTickInSeconds";
            val_82[2] = "MaxTickInSeconds";
            val_67[3] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.GEIGERCOUNTER.Parser, propertyNames:  val_82, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_86 = new string[7];
            val_86[0] = "DetachFrequency";
            val_86[1] = "MaximumDetached";
            val_86[2] = "CollectDistance";
            val_86[3] = "CollectionScreenPointX";
            val_86[4] = "CollectionScreenPointY";
            val_86[5] = "CollectDistanceMote";
            val_86[6] = "CollectDistanceThreat";
            val_67[4] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM.Parser, propertyNames:  val_86, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_90 = new string[19];
            val_90[0] = "MoteLifetime";
            val_90[1] = "MinOrbitRadius";
            val_90[2] = "MaxOrbitRadius";
            val_90[3] = "SpawnTime";
            val_90[4] = "MaxVisibleMotesPerEssence";
            val_90[5] = "MinAngleSpeedDegrees";
            val_90[6] = "MaxAngleSpeedDegrees";
            val_90[7] = "MaxDegradeMultiplier";
            val_90[8] = "MinDegradeMultiplier";
            val_90[9] = "MinDegradeDistance";
            val_90[10] = "MaxDegradeDistance";
            val_90[11] = "StartingNumberOfMotes";
            val_90[12] = "MaxMotesPerEssence";
            val_90[13] = "MinimumDetachedSpeed";
            val_90[14] = "MaximumDetachedSpeed";
            val_90[15] = "DetachedAcceleration";
            val_90[16] = "DetachedDeceleration";
            val_90[17] = "CollectFlushBatchTime";
            val_90[18] = "CollectTimeToWaitToSeeIfMoreMotesComingIn";
            val_67[5] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES.Parser, propertyNames:  val_90, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_94 = new string[17];
            val_94[0] = "ThreatPillLifetime";
            val_94[1] = "MinOrbitRadius";
            val_94[2] = "MaxOrbitRadius";
            val_94[3] = "SpawnTime";
            val_94[4] = "MaxVisibleThreatPillsPerEssence";
            val_94[5] = "MinAngleSpeedDegrees";
            val_94[6] = "MaxAngleSpeedDegrees";
            val_94[7] = "MaxDegradeMultiplier";
            val_94[8] = "MinDegradeMultiplier";
            val_94[9] = "MinDegradeDistance";
            val_94[10] = "MaxDegradeDistance";
            val_94[11] = "StartingNumberOfThreatPills";
            val_94[12] = "MaxThreatPillsPerEssence";
            val_94[13] = "MinimumDetachedSpeed";
            val_94[14] = "MaximumDetachedSpeed";
            val_94[15] = "DetachedAcceleration";
            val_94[16] = "DetachedDeceleration";
            val_67[6] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS.Parser, propertyNames:  val_94, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_98 = new string[3];
            val_98[0] = "ThreatPercentPerThreatPill";
            val_98[1] = "DropPerSecond";
            val_98[2] = "ConsecutiveThreatPercentMult";
            val_67[7] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION.Parser, propertyNames:  val_98, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_102 = new string[2];
            val_102[0] = "Min";
            val_102[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_103 = null;
            val_190 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_103 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_190, parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.ESSENCEREWARD.Parser, propertyNames:  val_102, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_103 != null) && (val_103 == null))
            {
                    val_190 = 0;
            }
            
            if(val_67.Length <= 8)
            {
                    val_190 = 0;
            }
            
            val_67[8] = val_103;
            val_13[8] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Parser, propertyNames:  val_66, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_67);
            string[] val_107 = new string[9];
            val_107[0] = "MaxDeployed";
            val_107[1] = "Period";
            val_107[2] = "Malfunction";
            val_107[3] = "WearAndTearChance";
            val_107[4] = "WearAndTearDamage";
            val_107[5] = "RareRewardChance";
            val_107[6] = "PlushSuitChance";
            val_107[7] = "CommonRewardChance";
            val_107[8] = "Parts";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_108 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[2];
            string[] val_111 = new string[2];
            val_111[0] = "Min";
            val_111[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_112 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.WEARANDTEARDAMAGE.Parser, propertyNames:  val_111, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_108 == null)
            {
                goto label_1138;
            }
            
            if(val_112 != null)
            {
                goto label_1139;
            }
            
            goto label_1142;
            label_1138:
            if(val_112 == null)
            {
                goto label_1142;
            }
            
            label_1139:
            label_1142:
            val_108[0] = val_112;
            string[] val_115 = new string[2];
            val_115[0] = "Min";
            val_115[1] = "Max";
            val_108[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.PARTS.Parser, propertyNames:  val_115, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_13[9] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Parser, propertyNames:  val_107, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_108);
            string[] val_120 = new string[1];
            val_120[0] = "Glitching";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_121 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_124 = new string[2];
            val_124[0] = "Min";
            val_124[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_125 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.GLITCHING.Types.GLITCHING.Parser, propertyNames:  val_124, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_121 == null)
            {
                goto label_1174;
            }
            
            if(val_125 != null)
            {
                goto label_1175;
            }
            
            goto label_1178;
            label_1174:
            if(val_125 == null)
            {
                goto label_1178;
            }
            
            label_1175:
            label_1178:
            val_121[0] = val_125;
            val_13[10] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.GLITCHING.Parser, propertyNames:  val_120, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_121);
            string[] val_129 = new string[1];
            val_129[0] = "Notifications";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_130 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_133 = new string[4];
            val_133[0] = "ToTargetOnFail";
            val_133[1] = "ToTargetOnSucc";
            val_133[2] = "ToSenderOnFail";
            val_133[3] = "ToSenderOnSucc";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_134 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS.Parser, propertyNames:  val_133, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_130 == null)
            {
                goto label_1204;
            }
            
            if(val_134 != null)
            {
                goto label_1205;
            }
            
            goto label_1208;
            label_1204:
            if(val_134 == null)
            {
                goto label_1208;
            }
            
            label_1205:
            label_1208:
            val_130[0] = val_134;
            val_13[11] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.PVP.Parser, propertyNames:  val_129, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_130);
            string[] val_138 = new string[2];
            val_138[0] = "Min";
            val_138[1] = "Max";
            val_13[12] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.RAMPAGE.Parser, propertyNames:  val_138, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_142 = new string[2];
            val_142[0] = "NumAnimatronicsNormal";
            val_142[1] = "NumAnimatronicsMalfunctioning";
            val_13[13] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS.Parser, propertyNames:  val_142, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_146 = new string[1];
            val_146[0] = "PartsDescription";
            val_13[14] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT.Parser, propertyNames:  val_146, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_150 = new string[1];
            val_150[0] = "MaxSlots";
            val_13[15] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.WORKSHOP.Parser, propertyNames:  val_150, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_154 = new string[2];
            val_154[0] = "Audio";
            val_154[1] = "UI";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_155 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[2];
            string[] val_158 = new string[6];
            val_158[0] = "MusicBundle";
            val_158[1] = "MusicSoundBank";
            val_158[2] = "SharedBundle";
            val_158[3] = "SharedSoundBank";
            val_158[4] = "UIBundle";
            val_158[5] = "UISoundBank";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_159 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ARTASSETS.Types.AUDIO.Parser, propertyNames:  val_158, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_155 == null)
            {
                goto label_1285;
            }
            
            if(val_159 != null)
            {
                goto label_1286;
            }
            
            goto label_1289;
            label_1285:
            if(val_159 == null)
            {
                goto label_1289;
            }
            
            label_1286:
            label_1289:
            val_155[0] = val_159;
            string[] val_162 = new string[14];
            val_162[0] = "CpuIconsBundle";
            val_162[1] = "ModIconsBundle";
            val_162[2] = "PlushSuitIconsBundle";
            val_162[3] = "PortraitIconsBundle";
            val_162[4] = "RewardIconsBundle";
            val_162[5] = "EssenceRewardIconName";
            val_162[6] = "PartsRewardIconName";
            val_162[7] = "FazCoinsRewardIconName";
            val_162[8] = "StoreIconsBundle";
            val_162[9] = "OneOffScriptedIconsBundle";
            val_162[10] = "EndoskeletonSlotRewardIconName";
            val_162[11] = "ModSlotRewardIconName";
            val_162[12] = "ShopUIIconsBundle";
            val_162[13] = "DailyChallengesIconBundle";
            val_155[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ARTASSETS.Types.UIASSETS.Parser, propertyNames:  val_162, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_13[16] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ARTASSETS.Parser, propertyNames:  val_154, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_155);
            string[] val_167 = new string[1];
            val_167[0] = "CostFazCoins";
            val_13[17] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY.Parser, propertyNames:  val_167, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_171 = new string[2];
            val_171[0] = "MaxDelete";
            val_171[1] = "MaxSetToRead";
            val_13[18] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS.Parser, propertyNames:  val_171, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_175 = new string[1];
            val_175[0] = "Enable";
            val_13[19] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES.Parser, propertyNames:  val_175, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_179 = new string[1];
            val_179[0] = "Tapjoy";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_180 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_183 = new string[3];
            val_183[0] = "IsEnabled";
            val_183[1] = "UseFinalRewardDialog";
            val_183[2] = "EnabledPlacements";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_184 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY.Parser, propertyNames:  val_183, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_180 == null)
            {
                goto label_1390;
            }
            
            if(val_184 != null)
            {
                goto label_1391;
            }
            
            goto label_1394;
            label_1390:
            if(val_184 == null)
            {
                goto label_1394;
            }
            
            label_1391:
            label_1394:
            val_180[0] = val_184;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_185 = null;
            val_191 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_185 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_191, parser:  CONFIG_DATA.Types.ENTRY.Types.ADS.Parser, propertyNames:  val_179, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_180);
            if((val_185 != null) && (val_185 == null))
            {
                    val_191 = 0;
            }
            
            if(val_13.Length <= 20)
            {
                    val_191 = 0;
            }
            
            val_13[20] = val_185;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_186 = null;
            val_192 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_186 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_192, parser:  CONFIG_DATA.Types.ENTRY.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_13);
            if(val_9 == 0)
            {
                goto label_1399;
            }
            
            if(val_186 != null)
            {
                goto label_1400;
            }
            
            goto label_1403;
            label_1399:
            if(val_186 == null)
            {
                goto label_1403;
            }
            
            label_1400:
            val_192 = val_9[4];
            if(val_186 == null)
            {
                    val_192 = 0;
            }
            
            label_1403:
            if(mem[1152921523971404264] == 0)
            {
                    val_192 = 0;
            }
            
            mem[1152921523971404272] = val_186;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_187 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.CONFIG_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == 0)
            {
                goto label_1405;
            }
            
            if(val_187 != null)
            {
                goto label_1406;
            }
            
            goto label_1409;
            label_1405:
            if(val_187 == null)
            {
                goto label_1409;
            }
            
            label_1406:
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_190 = val_5[4];
            label_1409:
            mem[1152921523971387856] = val_187;
            val_193 = null;
            ProtoData.CONFIGDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
