using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class CPUDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.CPUDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static CPUDATAReflection()
        {
            System.Type val_183;
            System.Type val_184;
            string[] val_1 = new string[117];
            val_1[0] = "Cg5DUFVfREFUQS5wcm90bxIJUHJvdG9EYXRhGh9nb29nbGUvcHJvdG9idWYv";
            val_1[1] = "dGltZXN0YW1wLnByb3RvIqgoCghDUFVfREFUQRIqCgdFbnRyaWVzGAEgAygL";
            val_1[2] = "MhkuUHJvdG9EYXRhLkNQVV9EQVRBLkVOVFJZGiMKEEFOSU1BVFJPTklDTkFN";
            val_1[3] = "RVMSDwoHRGVmYXVsdBgBIAEoCRqnAQoGU1RBVFVTEjcKCUxpdmVTdGF0ZRgB";
            val_1[4] = "IAEoDjIkLlByb3RvRGF0YS5DUFVfREFUQS5TVEFUVVMuTElWRVNUQVRFEjEK";
            val_1[5] = "DUF2YWlsYWJsZURhdGUYAiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0";
            val_1[6] = "YW1wIjEKCUxJVkVTVEFURRISCg5TdGF0ZV9JbmFjdGl2ZRAAEhAKDFN0YXRl";
            val_1[7] = "X0FjdGl2ZRABGq4CCg1TUEFXTkJZU1RSRUFLElYKFVJhbmtSYW5nZUJ5QmVz";
            val_1[8] = "dFN0cmVhaxgBIAEoCzI3LlByb3RvRGF0YS5DUFVfREFUQS5TUEFXTkJZU1RS";
            val_1[9] = "RUFLLlJBTktSQU5HRUJZQkVTVFNUUkVBSxJcChhSYW5rUmFuZ2VCeUN1cnJl";
            val_1[10] = "bnRTdHJlYWsYAiABKAsyOi5Qcm90b0RhdGEuQ1BVX0RBVEEuU1BBV05CWVNU";
            val_1[11] = "UkVBSy5SQU5LUkFOR0VCWUNVUlJFTlRTVFJFQUsaMQoVUkFOS1JBTkdFQllC";
            val_1[12] = "RVNUU1RSRUFLEgsKA01pbhgBIAEoARILCgNNYXgYAiABKAEaNAoYUkFOS1JB";
            val_1[13] = "TkdFQllDVVJSRU5UU1RSRUFLEgsKA01pbhgBIAEoARILCgNNYXgYAiABKAEa";
            val_1[14] = "hQEKCFNQRUVETVBIEj0KC01hcFNwZWVkTVBIGAEgASgLMiguUHJvdG9EYXRh";
            val_1[15] = "LkNQVV9EQVRBLlNQRUVETVBILk1BUFNQRUVETVBIEhYKDlRyYXZlbFNwZWVk";
            val_1[16] = "TVBIGAIgASgBGiIKC01BUFNQRUVETVBIEhMKC05vdFVwZ3JhZGVkGAEgASgB";
            val_1[17] = "GuMBCghNQVBOT0RFUxJDCg5Ob2RlVHJhdmVsVGltZRgBIAEoCzIrLlByb3Rv";
            val_1[18] = "RGF0YS5DUFVfREFUQS5NQVBOT0RFUy5OT0RFVFJBVkVMVElNRRI9CgtOb2Rl";
            val_1[19] = "UGF0aE1pbhgCIAEoCzIoLlByb3RvRGF0YS5DUFVfREFUQS5NQVBOT0RFUy5O";
            val_1[20] = "T0RFUEFUSE1JThoqCg5OT0RFVFJBVkVMVElNRRILCgNNaW4YASABKAESCwoD";
            val_1[21] = "TWF4GAIgASgBGicKC05PREVQQVRITUlOEgsKA01pbhgBIAEoARILCgNNYXgY";
            val_1[22] = "AiABKAEafgoOU1RBTEtJTkdUSU1FUlMSQwoLRnVuY3Rpb25pbmcYASABKAsy";
            val_1[23] = "Li5Qcm90b0RhdGEuQ1BVX0RBVEEuU1RBTEtJTkdUSU1FUlMuRlVOQ1RJT05J";
            val_1[24] = "TkcaJwoLRlVOQ1RJT05JTkcSCwoDTWluGAEgASgBEgsKA01heBgCIAEoARqc";
            val_1[25] = "AwoTU1RBTEtJTkdFWElUUkVRQU5JTRIeChZTdGFsa2luZ0V4aXRSZXFBbmlt";
            val_1[26] = "T2JqGAEgASgJEmIKGFN0YWxraW5nRXhpdFJlcUFuaW1QaGFzZRgCIAEoDjJA";
            val_1[27] = "LlByb3RvRGF0YS5DUFVfREFUQS5TVEFMS0lOR0VYSVRSRVFBTklNLlNUQUxL";
            val_1[28] = "SU5HRVhJVFJFUUFOSU1QSEFTRRI/ChpTdGFsa2luZ0V4aXRSZXFBbmltTG9n";
            val_1[29] = "aWNhbBgDIAEoDjIbLlByb3RvRGF0YS5DUFVfREFUQS5MT0dJQ0FMIr8BChhT";
            val_1[30] = "VEFMS0lOR0VYSVRSRVFBTklNUEhBU0USEgoOU3RhbGtFeGl0X05vbmUQABIU";
            val_1[31] = "ChBTdGFsa0V4aXRfQWN0aXZlEAESFwoTU3RhbGtFeGl0X1RyYXZlbGluZxAC";
            val_1[32] = "EhYKElN0YWxrRXhpdF9TdGFsa2luZxADEhYKElN0YWxrRXhpdF9BcHByb2Fj";
            val_1[33] = "aBAEEhgKFFN0YWxrRXhpdF9OZWFyUGxheWVyEAUSFgoSU3RhbGtFeGl0X1Nh";
            val_1[34] = "bWVSb29tEAYaog8KB1JFV0FSRFMSUAoVV2FuZGVyaW5nQW5pbWF0cm9uaWNz";
            val_1[35] = "GAEgASgLMjEuUHJvdG9EYXRhLkNQVV9EQVRBLlJFV0FSRFMuV0FOREVSSU5H";
            val_1[36] = "QU5JTUFUUk9OSUNTElAKFVB2UEFuaW1hdHJvbmljc1ZpY3RpbRgCIAEoCzIx";
            val_1[37] = "LlByb3RvRGF0YS5DUFVfREFUQS5SRVdBUkRTLlBWUEFOSU1BVFJPTklDU1ZJ";
            val_1[38] = "Q1RJTRJWChhQdlBBbmltYXRyb25pY3NBZ2dyZXNzb3IYAyABKAsyNC5Qcm90";
            val_1[39] = "b0RhdGEuQ1BVX0RBVEEuUkVXQVJEUy5QVlBBTklNQVRST05JQ1NBR0dSRVNT";
            val_1[40] = "T1ISUAoVUmFtcGFnaW5nQW5pbWF0cm9uaWNzGAQgASgLMjEuUHJvdG9EYXRh";
            val_1[41] = "LkNQVV9EQVRBLlJFV0FSRFMuUkFNUEFHSU5HQU5JTUFUUk9OSUNTGsEDChVX";
            val_1[42] = "QU5ERVJJTkdBTklNQVRST05JQ1MSRgoFUGFydHMYASABKAsyNy5Qcm90b0Rh";
            val_1[43] = "dGEuQ1BVX0RBVEEuUkVXQVJEUy5XQU5ERVJJTkdBTklNQVRST05JQ1MuUEFS";
            val_1[44] = "VFMSSgoHRXNzZW5jZRgCIAEoCzI5LlByb3RvRGF0YS5DUFVfREFUQS5SRVdB";
            val_1[45] = "UkRTLldBTkRFUklOR0FOSU1BVFJPTklDUy5FU1NFTkNFEhsKE1BsdXNoU3Vp";
            val_1[46] = "dERyb3BDaGFuY2UYAyABKAESFQoNQ1BVRHJvcENoYW5jZRgEIAEoARIVCg1N";
            val_1[47] = "b2REcm9wQ2hhbmNlGAUgASgBElYKDUVzc2VuY2VPbkxvc2UYBiABKAsyPy5Q";
            val_1[48] = "cm90b0RhdGEuQ1BVX0RBVEEuUkVXQVJEUy5XQU5ERVJJTkdBTklNQVRST05J";
            val_1[49] = "Q1MuRVNTRU5DRU9OTE9TRRohCgVQQVJUUxILCgNNaW4YASABKAESCwoDTWF4";
            val_1[50] = "GAIgASgBGiMKB0VTU0VOQ0USCwoDTWluGAEgASgBEgsKA01heBgCIAEoARop";
            val_1[51] = "Cg1FU1NFTkNFT05MT1NFEgsKA01pbhgBIAEoARILCgNNYXgYAiABKAEawQMK";
            val_1[52] = "FVBWUEFOSU1BVFJPTklDU1ZJQ1RJTRJGCgVQYXJ0cxgBIAEoCzI3LlByb3Rv";
            val_1[53] = "RGF0YS5DUFVfREFUQS5SRVdBUkRTLlBWUEFOSU1BVFJPTklDU1ZJQ1RJTS5Q";
            val_1[54] = "QVJUUxJKCgdFc3NlbmNlGAIgASgLMjkuUHJvdG9EYXRhLkNQVV9EQVRBLlJF";
            val_1[55] = "V0FSRFMuUFZQQU5JTUFUUk9OSUNTVklDVElNLkVTU0VOQ0USGwoTUGx1c2hT";
            val_1[56] = "dWl0RHJvcENoYW5jZRgDIAEoARIVCg1DUFVEcm9wQ2hhbmNlGAQgASgBEhUK";
            val_1[57] = "DU1vZERyb3BDaGFuY2UYBSABKAESVgoNRXNzZW5jZU9uTG9zZRgGIAEoCzI/";
            val_1[58] = "LlByb3RvRGF0YS5DUFVfREFUQS5SRVdBUkRTLlBWUEFOSU1BVFJPTklDU1ZJ";
            val_1[59] = "Q1RJTS5FU1NFTkNFT05MT1NFGiEKBVBBUlRTEgsKA01pbhgBIAEoARILCgNN";
            val_1[60] = "YXgYAiABKAEaIwoHRVNTRU5DRRILCgNNaW4YASABKAESCwoDTWF4GAIgASgB";
            val_1[61] = "GikKDUVTU0VOQ0VPTkxPU0USCwoDTWluGAEgASgBEgsKA01heBgCIAEoARr8";
            val_1[62] = "AQoYUFZQQU5JTUFUUk9OSUNTQUdHUkVTU09SEkkKBVBhcnRzGAEgASgLMjou";
            val_1[63] = "UHJvdG9EYXRhLkNQVV9EQVRBLlJFV0FSRFMuUFZQQU5JTUFUUk9OSUNTQUdH";
            val_1[64] = "UkVTU09SLlBBUlRTEk0KB0Vzc2VuY2UYAiABKAsyPC5Qcm90b0RhdGEuQ1BV";
            val_1[65] = "X0RBVEEuUkVXQVJEUy5QVlBBTklNQVRST05JQ1NBR0dSRVNTT1IuRVNTRU5D";
            val_1[66] = "RRohCgVQQVJUUxILCgNNaW4YASABKAESCwoDTWF4GAIgASgBGiMKB0VTU0VO";
            val_1[67] = "Q0USCwoDTWluGAEgASgBEgsKA01heBgCIAEoARrBAwoVUkFNUEFHSU5HQU5J";
            val_1[68] = "TUFUUk9OSUNTEkYKBVBhcnRzGAEgASgLMjcuUHJvdG9EYXRhLkNQVV9EQVRB";
            val_1[69] = "LlJFV0FSRFMuUkFNUEFHSU5HQU5JTUFUUk9OSUNTLlBBUlRTEkoKB0Vzc2Vu";
            val_1[70] = "Y2UYAiABKAsyOS5Qcm90b0RhdGEuQ1BVX0RBVEEuUkVXQVJEUy5SQU1QQUdJ";
            val_1[71] = "TkdBTklNQVRST05JQ1MuRVNTRU5DRRIbChNQbHVzaFN1aXREcm9wQ2hhbmNl";
            val_1[72] = "GAMgASgBEhUKDUNQVURyb3BDaGFuY2UYBCABKAESFQoNTW9kRHJvcENoYW5j";
            val_1[73] = "ZRgFIAEoARJWCg1Fc3NlbmNlT25Mb3NlGAYgASgLMj8uUHJvdG9EYXRhLkNQ";
            val_1[74] = "VV9EQVRBLlJFV0FSRFMuUkFNUEFHSU5HQU5JTUFUUk9OSUNTLkVTU0VOQ0VP";
            val_1[75] = "TkxPU0UaIQoFUEFSVFMSCwoDTWluGAEgASgBEgsKA01heBgCIAEoARojCgdF";
            val_1[76] = "U1NFTkNFEgsKA01pbhgBIAEoARILCgNNYXgYAiABKAEaKQoNRVNTRU5DRU9O";
            val_1[77] = "TE9TRRILCgNNaW4YASABKAESCwoDTWF4GAIgASgBGi4KFEFOSU1QTEFZRVJG";
            val_1[78] = "QUNJTkdURVhUEhYKDkNQVURlc2NyaXB0aW9uGAEgASgJGiYKEkFUVEFDS0xP";
            val_1[79] = "Q0FMSVpBVElPThIQCghMb3NzVGV4dBgBIAEoCRqNAgoJQVJUQVNTRVRTEjIK";
            val_1[80] = "BUF1ZGlvGAEgASgLMiMuUHJvdG9EYXRhLkNQVV9EQVRBLkFSVEFTU0VUUy5B";
            val_1[81] = "VURJTxIfChdBbmltYXRyb25pY0NvbmZpZ0xvb2t1cBgCIAEoCRIyCgJVSRgD";
            val_1[82] = "IAEoCzImLlByb3RvRGF0YS5DUFVfREFUQS5BUlRBU1NFVFMuVUlBU1NFVFMa";
            val_1[83] = "KgoFQVVESU8SEQoJU291bmRCYW5rGAEgASgJEg4KBkJ1bmRsZRgCIAEoCRpL";
            val_1[84] = "CghVSUFTU0VUUxIPCgdDcHVJY29uGAEgASgJEhMKC0NwdUljb25GbGF0GAIg";
            val_1[85] = "ASgJEhkKEUNwdVNpbGhvdWV0dGVJY29uGAMgASgJGi8KCEhFTExFWUVTEhEK";
            val_1[86] = "CUludGVuc2l0eRgBIAEoARIQCghIZXhDb2xvchgCIAEoCRqZAgoOVklTVUFM";
            val_1[87] = "U0VUVElOR1MSEQoJQ29uZGl0aW9uGAEgASgBEj8KCkF0dGFja0V5ZXMYAiAB";
            val_1[88] = "KAsyKy5Qcm90b0RhdGEuQ1BVX0RBVEEuVklTVUFMU0VUVElOR1MuRVlFQ09M";
            val_1[89] = "T1ISPwoKTG9va0F0RXllcxgDIAEoCzIrLlByb3RvRGF0YS5DUFVfREFUQS5W";
            val_1[90] = "SVNVQUxTRVRUSU5HUy5FWUVDT0xPUhJBCgxMb29rQXdheUV5ZXMYBCABKAsy";
            val_1[91] = "Ky5Qcm90b0RhdGEuQ1BVX0RBVEEuVklTVUFMU0VUVElOR1MuRVlFQ09MT1Ia";
            val_1[92] = "LwoIRVlFQ09MT1ISEQoJSW50ZW5zaXR5GAEgASgBEhAKCEhleENvbG9yGAIg";
            val_1[93] = "ASgJGugHCgVFTlRSWRIPCgdMb2dpY2FsGAEgASgJEj4KEEFuaW1hdHJvbmlj";
            val_1[94] = "TmFtZXMYAiABKAsyJC5Qcm90b0RhdGEuQ1BVX0RBVEEuQU5JTUFUUk9OSUNO";
            val_1[95] = "QU1FUxINCgVPcmRlchgDIAEoARIqCgZTdGF0dXMYBCABKAsyGi5Qcm90b0Rh";
            val_1[96] = "dGEuQ1BVX0RBVEEuU1RBVFVTEgwKBFJhbmsYBSABKAESFgoORWZmZWN0aXZl";
            val_1[97] = "UG93ZXIYBiABKAESEAoIUGhhbnRhc20YByABKAESGwoTQ2hhbmNlVG9NYWxm";
            val_1[98] = "dW5jdGlvbhgIIAEoARIuCghTcGVlZE1QSBgJIAEoCzIcLlByb3RvRGF0YS5D";
            val_1[99] = "UFVfREFUQS5TUEVFRE1QSBIuCghNYXBOb2RlcxgKIAEoCzIcLlByb3RvRGF0";
            val_1[100] = "YS5DUFVfREFUQS5NQVBOT0RFUxI6Cg5TdGFsa2luZ1RpbWVycxgLIAEoCzIi";
            val_1[101] = "LlByb3RvRGF0YS5DUFVfREFUQS5TVEFMS0lOR1RJTUVSUxJEChNTdGFsa2lu";
            val_1[102] = "Z0V4aXRSZXFBbmltGAwgASgLMicuUHJvdG9EYXRhLkNQVV9EQVRBLlNUQUxL";
            val_1[103] = "SU5HRVhJVFJFUUFOSU0SFQoNQXR0YWNrUHJvZmlsZRgNIAEoCRIsCgdSZXdh";
            val_1[104] = "cmRzGA4gASgLMhsuUHJvdG9EYXRhLkNQVV9EQVRBLlJFV0FSRFMSRgoUQW5p";
            val_1[105] = "bVBsYXllckZhY2luZ1RleHQYDyABKAsyKC5Qcm90b0RhdGEuQ1BVX0RBVEEu";
            val_1[106] = "QU5JTVBMQVlFUkZBQ0lOR1RFWFQSMAoJQXJ0QXNzZXRzGBAgASgLMh0uUHJv";
            val_1[107] = "dG9EYXRhLkNQVV9EQVRBLkFSVEFTU0VUUxI4Cg1TcGF3bkJ5U3RyZWFrGBEg";
            val_1[108] = "ASgLMiEuUHJvdG9EYXRhLkNQVV9EQVRBLlNQQVdOQllTVFJFQUsSFAoMUGx1";
            val_1[109] = "c2hTdWl0UmVmGBIgASgJEhEKCUNvbmRpdGlvbhgTIAEoARIuCghIZWxsRXll";
            val_1[110] = "cxgUIAEoCzIcLlByb3RvRGF0YS5DUFVfREFUQS5IRUxMRVlFUxJCChJBdHRh";
            val_1[111] = "Y2tMb2NhbGl6YXRpb24YFSABKAsyJi5Qcm90b0RhdGEuQ1BVX0RBVEEuQVRU";
            val_1[112] = "QUNLTE9DQUxJWkFUSU9OEhYKDkFsd2F5c1Nob3dJY29uGBYgASgJEhgKEFNh";
            val_1[113] = "bHZhZ2VyU3BlZWRNUEgYFyABKAESGAoQUGxheWVyQWNxdWlyYWJsZRgYIAEo";
            val_1[114] = "CBI6Cg5WaXN1YWxTZXR0aW5ncxgZIAEoCzIiLlByb3RvRGF0YS5DUFVfREFU";
            val_1[115] = "QS5WSVNVQUxTRVRUSU5HUyIeCgdMT0dJQ0FMEggKBFRSVUUQABIJCgVGQUxT";
            val_1[116] = "RRABYgZwcm90bzM=";
            Google.Protobuf.Reflection.FileDescriptor[] val_4 = new Google.Protobuf.Reflection.FileDescriptor[1];
            Google.Protobuf.Reflection.FileDescriptor val_5 = Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor;
            if(val_4 == null)
            {
                goto label_357;
            }
            
            if(val_5 != null)
            {
                goto label_358;
            }
            
            goto label_361;
            label_357:
            if(val_5 == null)
            {
                goto label_361;
            }
            
            label_358:
            label_361:
            val_4[0] = val_5;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_6 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_9 = new string[1];
            val_9[0] = "Entries";
            System.Type[] val_10 = new System.Type[1];
            System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_10 == null)
            {
                goto label_371;
            }
            
            if(val_11 != null)
            {
                goto label_372;
            }
            
            goto label_375;
            label_371:
            if(val_11 == null)
            {
                goto label_375;
            }
            
            label_372:
            label_375:
            val_10[0] = val_11;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_12 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[14];
            string[] val_15 = new string[1];
            val_15[0] = "Default";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_16 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.ANIMATRONICNAMES.Parser, propertyNames:  val_15, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_12 == null)
            {
                goto label_383;
            }
            
            if(val_16 != null)
            {
                goto label_384;
            }
            
            goto label_387;
            label_383:
            if(val_16 == null)
            {
                goto label_387;
            }
            
            label_384:
            label_387:
            val_12[0] = val_16;
            string[] val_19 = new string[2];
            val_19[0] = "LiveState";
            val_19[1] = "AvailableDate";
            System.Type[] val_20 = new System.Type[1];
            System.Type val_21 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_20 == null)
            {
                goto label_398;
            }
            
            if(val_21 != null)
            {
                goto label_399;
            }
            
            goto label_402;
            label_398:
            if(val_21 == null)
            {
                goto label_402;
            }
            
            label_399:
            label_402:
            val_20[0] = val_21;
            val_12[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.STATUS.Parser, propertyNames:  val_19, oneofNames:  0, nestedEnums:  val_20, nestedTypes:  0);
            string[] val_25 = new string[2];
            val_25[0] = "RankRangeByBestStreak";
            val_25[1] = "RankRangeByCurrentStreak";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_26 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[2];
            string[] val_29 = new string[2];
            val_29[0] = "Min";
            val_29[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_30 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYBESTSTREAK.Parser, propertyNames:  val_29, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_26 == null)
            {
                goto label_425;
            }
            
            if(val_30 != null)
            {
                goto label_426;
            }
            
            goto label_429;
            label_425:
            if(val_30 == null)
            {
                goto label_429;
            }
            
            label_426:
            label_429:
            val_26[0] = val_30;
            string[] val_33 = new string[2];
            val_33[0] = "Min";
            val_33[1] = "Max";
            val_26[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYCURRENTSTREAK.Parser, propertyNames:  val_33, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_12[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.SPAWNBYSTREAK.Parser, propertyNames:  val_25, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_26);
            string[] val_38 = new string[2];
            val_38[0] = "MapSpeedMPH";
            val_38[1] = "TravelSpeedMPH";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_39 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_42 = new string[1];
            val_42[0] = "NotUpgraded";
            val_39[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH.Parser, propertyNames:  val_42, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_12[3] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.SPEEDMPH.Parser, propertyNames:  val_38, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_39);
            string[] val_47 = new string[2];
            val_47[0] = "NodeTravelTime";
            val_47[1] = "NodePathMin";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_48 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[2];
            string[] val_51 = new string[2];
            val_51[0] = "Min";
            val_51[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_52 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.MAPNODES.Types.NODETRAVELTIME.Parser, propertyNames:  val_51, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_48 == null)
            {
                goto label_486;
            }
            
            if(val_52 != null)
            {
                goto label_487;
            }
            
            goto label_490;
            label_486:
            if(val_52 == null)
            {
                goto label_490;
            }
            
            label_487:
            label_490:
            val_48[0] = val_52;
            string[] val_55 = new string[2];
            val_55[0] = "Min";
            val_55[1] = "Max";
            val_48[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.MAPNODES.Types.NODEPATHMIN.Parser, propertyNames:  val_55, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_12[4] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.MAPNODES.Parser, propertyNames:  val_47, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_48);
            string[] val_60 = new string[1];
            val_60[0] = "Functioning";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_61 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_64 = new string[2];
            val_64[0] = "Min";
            val_64[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_65 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.STALKINGTIMERS.Types.FUNCTIONING.Parser, propertyNames:  val_64, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_61 == null)
            {
                goto label_522;
            }
            
            if(val_65 != null)
            {
                goto label_523;
            }
            
            goto label_526;
            label_522:
            if(val_65 == null)
            {
                goto label_526;
            }
            
            label_523:
            label_526:
            val_61[0] = val_65;
            val_12[5] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.STALKINGTIMERS.Parser, propertyNames:  val_60, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_61);
            string[] val_69 = new string[3];
            val_69[0] = "StalkingExitReqAnimObj";
            val_69[1] = "StalkingExitReqAnimPhase";
            val_69[2] = "StalkingExitReqAnimLogical";
            System.Type[] val_70 = new System.Type[1];
            System.Type val_71 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_70 == null)
            {
                goto label_543;
            }
            
            if(val_71 != null)
            {
                goto label_544;
            }
            
            goto label_547;
            label_543:
            if(val_71 == null)
            {
                goto label_547;
            }
            
            label_544:
            label_547:
            val_70[0] = val_71;
            val_12[6] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.STALKINGEXITREQANIM.Parser, propertyNames:  val_69, oneofNames:  0, nestedEnums:  val_70, nestedTypes:  0);
            string[] val_75 = new string[4];
            val_75[0] = "WanderingAnimatronics";
            val_75[1] = "PvPAnimatronicsVictim";
            val_75[2] = "PvPAnimatronicsAggressor";
            val_75[3] = "RampagingAnimatronics";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_76 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[4];
            string[] val_79 = new string[6];
            val_79[0] = "Parts";
            val_79[1] = "Essence";
            val_79[2] = "PlushSuitDropChance";
            val_79[3] = "CPUDropChance";
            val_79[4] = "ModDropChance";
            val_79[5] = "EssenceOnLose";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_80 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[3];
            string[] val_83 = new string[2];
            val_83[0] = "Min";
            val_83[1] = "Max";
            val_80[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.WANDERINGANIMATRONICS.Types.PARTS.Parser, propertyNames:  val_83, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_87 = new string[2];
            val_87[0] = "Min";
            val_87[1] = "Max";
            val_80[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.WANDERINGANIMATRONICS.Types.ESSENCE.Parser, propertyNames:  val_87, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_91 = new string[2];
            val_91[0] = "Min";
            val_91[1] = "Max";
            val_80[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.WANDERINGANIMATRONICS.Types.ESSENCEONLOSE.Parser, propertyNames:  val_91, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_76[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.WANDERINGANIMATRONICS.Parser, propertyNames:  val_79, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_80);
            string[] val_96 = new string[6];
            val_96[0] = "Parts";
            val_96[1] = "Essence";
            val_96[2] = "PlushSuitDropChance";
            val_96[3] = "CPUDropChance";
            val_96[4] = "ModDropChance";
            val_96[5] = "EssenceOnLose";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_97 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[3];
            string[] val_100 = new string[2];
            val_100[0] = "Min";
            val_100[1] = "Max";
            val_97[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSVICTIM.Types.PARTS.Parser, propertyNames:  val_100, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_104 = new string[2];
            val_104[0] = "Min";
            val_104[1] = "Max";
            val_97[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSVICTIM.Types.ESSENCE.Parser, propertyNames:  val_104, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_108 = new string[2];
            val_108[0] = "Min";
            val_108[1] = "Max";
            val_97[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSVICTIM.Types.ESSENCEONLOSE.Parser, propertyNames:  val_108, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_76[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSVICTIM.Parser, propertyNames:  val_96, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_97);
            string[] val_113 = new string[2];
            val_113[0] = "Parts";
            val_113[1] = "Essence";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_114 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[2];
            string[] val_117 = new string[2];
            val_117[0] = "Min";
            val_117[1] = "Max";
            val_114[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.PARTS.Parser, propertyNames:  val_117, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_121 = new string[2];
            val_121[0] = "Min";
            val_121[1] = "Max";
            val_114[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.ESSENCE.Parser, propertyNames:  val_121, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_76[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Parser, propertyNames:  val_113, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_114);
            string[] val_126 = new string[6];
            val_126[0] = "Parts";
            val_126[1] = "Essence";
            val_126[2] = "PlushSuitDropChance";
            val_126[3] = "CPUDropChance";
            val_126[4] = "ModDropChance";
            val_126[5] = "EssenceOnLose";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_127 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[3];
            string[] val_130 = new string[2];
            val_130[0] = "Min";
            val_130[1] = "Max";
            val_127[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.PARTS.Parser, propertyNames:  val_130, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_134 = new string[2];
            val_134[0] = "Min";
            val_134[1] = "Max";
            val_127[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCE.Parser, propertyNames:  val_134, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_138 = new string[2];
            val_138[0] = "Min";
            val_138[1] = "Max";
            val_127[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCEONLOSE.Parser, propertyNames:  val_138, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_140 = null;
            val_183 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_140 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_183, parser:  CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Parser, propertyNames:  val_126, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_127);
            if((val_140 != null) && (val_140 == null))
            {
                    val_183 = 0;
            }
            
            if(val_76.Length <= 3)
            {
                    val_183 = 0;
            }
            
            val_76[3] = val_140;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_141 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.REWARDS.Parser, propertyNames:  val_75, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_76);
            if(val_12 == null)
            {
                goto label_788;
            }
            
            if(val_141 != null)
            {
                goto label_789;
            }
            
            goto label_792;
            label_788:
            if(val_141 == null)
            {
                goto label_792;
            }
            
            label_789:
            label_792:
            val_12[7] = val_141;
            string[] val_144 = new string[1];
            val_144[0] = "CPUDescription";
            val_12[8] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.ANIMPLAYERFACINGTEXT.Parser, propertyNames:  val_144, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_148 = new string[1];
            val_148[0] = "LossText";
            val_12[9] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.ATTACKLOCALIZATION.Parser, propertyNames:  val_148, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_152 = new string[3];
            val_152[0] = "Audio";
            val_152[1] = "AnimatronicConfigLookup";
            val_152[2] = "UI";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_153 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[2];
            string[] val_156 = new string[2];
            val_156[0] = "SoundBank";
            val_156[1] = "Bundle";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_157 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.ARTASSETS.Types.AUDIO.Parser, propertyNames:  val_156, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_153 == null)
            {
                goto label_833;
            }
            
            if(val_157 != null)
            {
                goto label_834;
            }
            
            goto label_837;
            label_833:
            if(val_157 == null)
            {
                goto label_837;
            }
            
            label_834:
            label_837:
            val_153[0] = val_157;
            string[] val_160 = new string[3];
            val_160[0] = "CpuIcon";
            val_160[1] = "CpuIconFlat";
            val_160[2] = "CpuSilhouetteIcon";
            val_153[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.ARTASSETS.Types.UIASSETS.Parser, propertyNames:  val_160, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_12[10] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.ARTASSETS.Parser, propertyNames:  val_152, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_153);
            string[] val_165 = new string[2];
            val_165[0] = "Intensity";
            val_165[1] = "HexColor";
            val_12[11] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.HELLEYES.Parser, propertyNames:  val_165, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_169 = new string[4];
            val_169[0] = "Condition";
            val_169[1] = "AttackEyes";
            val_169[2] = "LookAtEyes";
            val_169[3] = "LookAwayEyes";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_170 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_173 = new string[2];
            val_173[0] = "Intensity";
            val_173[1] = "HexColor";
            val_170[0] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR.Parser, propertyNames:  val_173, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_12[12] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  CPU_DATA.Types.VISUALSETTINGS.Parser, propertyNames:  val_169, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_170);
            string[] val_178 = new string[25];
            val_178[0] = "Logical";
            val_178[1] = "AnimatronicNames";
            val_178[2] = "Order";
            val_178[3] = "Status";
            val_178[4] = "Rank";
            val_178[5] = "EffectivePower";
            val_178[6] = "Phantasm";
            val_178[7] = "ChanceToMalfunction";
            val_178[8] = "SpeedMPH";
            val_178[9] = "MapNodes";
            val_178[10] = "StalkingTimers";
            val_178[11] = "StalkingExitReqAnim";
            val_178[12] = "AttackProfile";
            val_178[13] = "Rewards";
            val_178[14] = "AnimPlayerFacingText";
            val_178[15] = "ArtAssets";
            val_178[16] = "SpawnByStreak";
            val_178[17] = "PlushSuitRef";
            val_178[18] = "Condition";
            val_178[19] = "HellEyes";
            val_178[20] = "AttackLocalization";
            val_178[21] = "AlwaysShowIcon";
            val_178[22] = "SalvagerSpeedMPH";
            val_178[23] = "PlayerAcquirable";
            val_178[24] = "VisualSettings";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_179 = null;
            val_184 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_179 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_184, parser:  CPU_DATA.Types.ENTRY.Parser, propertyNames:  val_178, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_179 != null) && (val_179 == null))
            {
                    val_184 = 0;
            }
            
            if(val_12.Length <= 13)
            {
                    val_184 = 0;
            }
            
            val_12[13] = val_179;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_180 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.CPU_DATA.Parser, propertyNames:  val_9, oneofNames:  0, nestedEnums:  val_10, nestedTypes:  val_12);
            if(val_180 != null)
            {
                    Google.Protobuf.Reflection.GeneratedClrTypeInfo val_183 = val_6[4];
            }
            
            mem[1152921524124411536] = val_180;
            ProtoData.CPUDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  val_4, generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_6));
        }
    
    }

}
