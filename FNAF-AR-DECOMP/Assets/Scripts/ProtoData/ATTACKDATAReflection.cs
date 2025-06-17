using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ATTACKDATAReflection
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
            return (Google.Protobuf.Reflection.FileDescriptor)ProtoData.ATTACKDATAReflection.descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ATTACKDATAReflection()
        {
            System.Type val_157;
            var val_158;
            string[] val_1 = new string[144];
            val_1[0] = "ChFBVFRBQ0tfREFUQS5wcm90bxIJUHJvdG9EYXRhIooyCgtBVFRBQ0tfREFU";
            val_1[1] = "QRItCgdFbnRyaWVzGAEgAygLMhwuUHJvdG9EYXRhLkFUVEFDS19EQVRBLkVO";
            val_1[2] = "VFJZGiEKBVJBTkdFEgsKA01pbhgBIAEoARILCgNNYXgYAiABKAEaKgoGQ0hB";
            val_1[3] = "TkNFEg4KBkNoYW5jZRgBIAEoARIQCghNb2RpZmllchgCIAEoARqFAQoSVEVM";
            val_1[4] = "RVBPUlRSRVBPU0lUSU9OEjUKD0FuZ2xlRnJvbUNhbWVyYRgBIAEoCzIcLlBy";
            val_1[5] = "b3RvRGF0YS5BVFRBQ0tfREFUQS5SQU5HRRI4ChJEaXN0YW5jZUZyb21DYW1l";
            val_1[6] = "cmEYAiABKAsyHC5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuUkFOR0UaPQoMSU5J";
            val_1[7] = "VElBTFBBVVNFEi0KB1NlY29uZHMYASABKAsyHC5Qcm90b0RhdGEuQVRUQUNL";
            val_1[8] = "X0RBVEEuUkFOR0Ua6gMKBkNJUkNMRRItCgdTZWNvbmRzGAEgASgLMhwuUHJv";
            val_1[9] = "dG9EYXRhLkFUVEFDS19EQVRBLlJBTkdFEjYKEERlZ3JlZXNQZXJTZWNvbmQY";
            val_1[10] = "AiABKAsyHC5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuUkFOR0USOgoJTmV4dFBo";
            val_1[11] = "YXNlGAMgASgLMicuUHJvdG9EYXRhLkFUVEFDS19EQVRBLkNJUkNMRS5ORVhU";
            val_1[12] = "UEhBU0USOQoTRm9vdHN0ZXBTcGVlZFNjYWxhchgEIAEoCzIcLlByb3RvRGF0";
            val_1[13] = "YS5BVFRBQ0tfREFUQS5SQU5HRRIyCgtDaGFuZ2VTcGVlZBgFIAEoCzIdLlBy";
            val_1[14] = "b3RvRGF0YS5BVFRBQ0tfREFUQS5DSEFOQ0USNAoOVHJpZ2dlclBlcmNlbnQY";
            val_1[15] = "BiABKAsyHC5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuUkFOR0UalwEKCU5FWFRQ";
            val_1[16] = "SEFTRRItCgZDaXJjbGUYASABKAsyHS5Qcm90b0RhdGEuQVRUQUNLX0RBVEEu";
            val_1[17] = "Q0hBTkNFEi0KBkNoYXJnZRgCIAEoCzIdLlByb3RvRGF0YS5BVFRBQ0tfREFU";
            val_1[18] = "QS5DSEFOQ0USLAoFUGF1c2UYAyABKAsyHS5Qcm90b0RhdGEuQVRUQUNLX0RB";
            val_1[19] = "VEEuQ0hBTkNFGqECCgVQQVVTRRItCgdTZWNvbmRzGAEgASgLMhwuUHJvdG9E";
            val_1[20] = "YXRhLkFUVEFDS19EQVRBLlJBTkdFEjkKCU5leHRQaGFzZRgCIAEoCzImLlBy";
            val_1[21] = "b3RvRGF0YS5BVFRBQ0tfREFUQS5QQVVTRS5ORVhUUEhBU0USEgoKVXNlR2xp";
            val_1[22] = "bXBzZRgDIAEoCBqZAQoJTkVYVFBIQVNFEi0KBkNpcmNsZRgBIAEoCzIdLlBy";
            val_1[23] = "b3RvRGF0YS5BVFRBQ0tfREFUQS5DSEFOQ0USLQoGQ2hhcmdlGAIgASgLMh0u";
            val_1[24] = "UHJvdG9EYXRhLkFUVEFDS19EQVRBLkNIQU5DRRIuCgdHbGltcHNlGAMgASgL";
            val_1[25] = "Mh0uUHJvdG9EYXRhLkFUVEFDS19EQVRBLkNIQU5DRRqvAwoHR0xJTVBTRRIu";
            val_1[26] = "CghDb29sZG93bhgBIAEoCzIcLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5SQU5H";
            val_1[27] = "RRIuCghEaXN0YW5jZRgCIAEoCzIcLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5S";
            val_1[28] = "QU5HRRI0Cg5DbG9ha0RlbGF5VGltZRgDIAEoCzIcLlByb3RvRGF0YS5BVFRB";
            val_1[29] = "Q0tfREFUQS5SQU5HRRIwCgpFeHBpcmVUaW1lGAQgASgLMhwuUHJvdG9EYXRh";
            val_1[30] = "LkFUVEFDS19EQVRBLlJBTkdFEjcKEUhhbGZBbmdsZURlYWRab25lGAUgASgL";
            val_1[31] = "MhwuUHJvdG9EYXRhLkFUVEFDS19EQVRBLlJBTkdFEjcKEUhhbGZBbmdsZVRl";
            val_1[32] = "bGVwb3J0GAYgASgLMhwuUHJvdG9EYXRhLkFUVEFDS19EQVRBLlJBTkdFEjMK";
            val_1[33] = "DVBoYXNlRHVyYXRpb24YByABKAsyHC5Qcm90b0RhdGEuQVRUQUNLX0RBVEEu";
            val_1[34] = "UkFOR0USNQoPUmVwb3NpdGlvbkRlbGF5GAggASgLMhwuUHJvdG9EYXRhLkFU";
            val_1[35] = "VEFDS19EQVRBLlJBTkdFGuUECgZDSEFSR0USLQoHU2Vjb25kcxgBIAEoCzIc";
            val_1[36] = "LlByb3RvRGF0YS5BVFRBQ0tfREFUQS5SQU5HRRIxCgtTaG9ja1dpbmRvdxgC";
            val_1[37] = "IAEoCzIcLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5SQU5HRRI6CglOZXh0UGhh";
            val_1[38] = "c2UYAyABKAsyJy5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuQ0hBUkdFLk5FWFRQ";
            val_1[39] = "SEFTRRIVCg1Gb3JjZVNodXRkb3duGAQgASgIEhgKEFVzZUZlaW50RGlzdGFu";
            val_1[40] = "Y2UYBSABKAgSOwoUSnVtcHNjYXJlRGVsYXlDaGFuY2UYBiABKAsyHS5Qcm90";
            val_1[41] = "b0RhdGEuQVRUQUNLX0RBVEEuQ0hBTkNFEjgKEkp1bXBzY2FyZURlbGF5VGlt";
            val_1[42] = "ZRgHIAEoCzIcLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5SQU5HRRJBChpTa2lw";
            val_1[43] = "RGVsYXllZEp1bXBzY2FyZUNoYW5jZRgIIAEoCzIdLlByb3RvRGF0YS5BVFRB";
            val_1[44] = "Q0tfREFUQS5DSEFOQ0USFgoOTWF4U2hvY2tXaW5kb3cYCSABKAEauQEKCU5F";
            val_1[45] = "WFRQSEFTRRItCgZDaXJjbGUYASABKAsyHS5Qcm90b0RhdGEuQVRUQUNLX0RB";
            val_1[46] = "VEEuQ0hBTkNFEjAKCUp1bXBzY2FyZRgCIAEoCzIdLlByb3RvRGF0YS5BVFRB";
            val_1[47] = "Q0tfREFUQS5DSEFOQ0USLAoFUGF1c2UYAyABKAsyHS5Qcm90b0RhdGEuQVRU";
            val_1[48] = "QUNLX0RBVEEuQ0hBTkNFEh0KFUZvcmNlQ2lyY2xlQWZ0ZXJQYXVzZRgEIAEo";
            val_1[49] = "CBqFCgoHSEFZV0lSRRI5CghTZXR0aW5ncxgBIAEoCzInLlByb3RvRGF0YS5B";
            val_1[50] = "VFRBQ0tfREFUQS5IQVlXSVJFLlNFVFRJTkdTEjwKBkNpcmNsZRgCIAEoCzIs";
            val_1[51] = "LlByb3RvRGF0YS5BVFRBQ0tfREFUQS5IQVlXSVJFLlBIQVNFU0VUVElOR1MS";
            val_1[52] = "OwoFUGF1c2UYAyABKAsyLC5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuSEFZV0lS";
            val_1[53] = "RS5QSEFTRVNFVFRJTkdTEjwKBkNoYXJnZRgEIAEoCzIsLlByb3RvRGF0YS5B";
            val_1[54] = "VFRBQ0tfREFUQS5IQVlXSVJFLlBIQVNFU0VUVElOR1MSOwoJTXVsdGl3aXJl";
            val_1[55] = "GAUgASgLMiguUHJvdG9EYXRhLkFUVEFDS19EQVRBLkhBWVdJUkUuTVVMVElX";
            val_1[56] = "SVJFGqMDCghTRVRUSU5HUxItCgdTZWNvbmRzGAEgASgLMhwuUHJvdG9EYXRh";
            val_1[57] = "LkFUVEFDS19EQVRBLlJBTkdFEhwKFFNob2NrQ2F1c2VzSnVtcHNjYXJlGAIg";
            val_1[58] = "ASgIEhAKCExvb2tBd2F5GAMgASgIEhAKCExvb2tUaW1lGAQgASgBEhAKCE1h";
            val_1[59] = "eENvdW50GAUgASgBEjUKDlNob3VsZExvb2tBd2F5GAYgASgLMh0uUHJvdG9E";
            val_1[60] = "YXRhLkFUVEFDS19EQVRBLkNIQU5DRRIzCgxTaG91bGRMb29rQXQYByABKAsy";
            val_1[61] = "HS5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuQ0hBTkNFEjsKFFNob3VsZExvb2tB";
            val_1[62] = "dFRoZW5Bd2F5GAggASgLMh0uUHJvdG9EYXRhLkFUVEFDS19EQVRBLkNIQU5D";
            val_1[63] = "RRI+ChhMb29rQ2hhbmdlVHJpZ2dlclBlcmNlbnQYCSABKAsyHC5Qcm90b0Rh";
            val_1[64] = "dGEuQVRUQUNLX0RBVEEuUkFOR0USEAoIQ29vbGRvd24YCiABKAESGQoRUmVx";
            val_1[65] = "dWlyZWRNYXNrU3RhdGUYDCABKAkazQEKCU1VTFRJV0lSRRIrCgVDb3VudBgB";
            val_1[66] = "IAEoCzIcLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5SQU5HRRIvCglIYWxmQW5n";
            val_1[67] = "bGUYAiABKAsyHC5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuUkFOR0USMAoKTG9j";
            val_1[68] = "YXRlVGltZRgDIAEoCzIcLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5SQU5HRRIw";
            val_1[69] = "CgpIaWRkZW5UaW1lGAQgASgLMhwuUHJvdG9EYXRhLkFUVEFDS19EQVRBLlJB";
            val_1[70] = "TkdFGtICCg1QSEFTRVNFVFRJTkdTEjEKCkFjdGl2YXRpb24YASABKAsyHS5Q";
            val_1[71] = "cm90b0RhdGEuQVRUQUNLX0RBVEEuQ0hBTkNFEjQKDlRyaWdnZXJQZXJjZW50";
            val_1[72] = "GAIgASgLMhwuUHJvdG9EYXRhLkFUVEFDS19EQVRBLlJBTkdFEhAKCEFkZFRv";
            val_1[73] = "TWF4GAMgASgIEg4KBlVzZU1heBgEIAEoCBIxCgpHb1RvQ2lyY2xlGAUgASgL";
            val_1[74] = "Mh0uUHJvdG9EYXRhLkFUVEFDS19EQVRBLkNIQU5DRRIwCglHb1RvUGF1c2UY";
            val_1[75] = "BiABKAsyHS5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuQ0hBTkNFEhgKEFRlbGVw";
            val_1[76] = "b3J0VG9DYW1lcmEYByABKAgSGAoQQWxsb3dlZEhhbGZBbmdsZRgIIAEoARId";
            val_1[77] = "ChVGb3JjZUNpcmNsZUFmdGVyUGF1c2UYCSABKAga9gIKCkRJU1JVUFRJT04S";
            val_1[78] = "PAoIU2V0dGluZ3MYASABKAsyKi5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuRElT";
            val_1[79] = "UlVQVElPTi5TRVRUSU5HUxI2CgVTaGFrZRgCIAEoCzInLlByb3RvRGF0YS5B";
            val_1[80] = "VFRBQ0tfREFUQS5ESVNSVVBUSU9OLlNIQUtFGrgBCghTRVRUSU5HUxIuCghD";
            val_1[81] = "b29sZG93bhgBIAEoCzIcLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5SQU5HRRIx";
            val_1[82] = "CgpBY3RpdmF0aW9uGAIgASgLMh0uUHJvdG9EYXRhLkFUVEFDS19EQVRBLkNI";
            val_1[83] = "QU5DRRIQCghSYW1wVGltZRgDIAEoARINCgVTdHlsZRgEIAEoCRISCgpDYW5j";
            val_1[84] = "ZWxUaW1lGAUgASgBEhQKDENhbmNlbEFjdGlvbhgGIAEoCRo3CgVTSEFLRRIW";
            val_1[85] = "Cg5TaGFrZU1hZ25pdHVkZRgCIAEoARIWCg5TaGFrZUdyYWNlVGltZRgDIAEo";
            val_1[86] = "ARrdAgoFU1VSR0USNwoIU2V0dGluZ3MYASABKAsyJS5Qcm90b0RhdGEuQVRU";
            val_1[87] = "QUNLX0RBVEEuU1VSR0UuU0VUVElOR1MamgIKCFNFVFRJTkdTEi4KCENvb2xk";
            val_1[88] = "b3duGAEgASgLMhwuUHJvdG9EYXRhLkFUVEFDS19EQVRBLlJBTkdFEjEKCkFj";
            val_1[89] = "dGl2YXRpb24YAiABKAsyHS5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuQ0hBTkNF";
            val_1[90] = "EhIKCkNhbmNlbFRpbWUYAyABKAESFAoMQ2FuY2VsQWN0aW9uGAQgASgJEhwK";
            val_1[91] = "FEJhdHRlcnlEcmFpblJhdGVCYXNlGAUgASgBEh4KFkJhdHRlcnlEcmFpblJh";
            val_1[92] = "dGVDYW5jZWwYBiABKAESFQoNQmxpbmtEdXJhdGlvbhgHIAEoARIZChFNYXNr";
            val_1[93] = "TGlnaHRGYWRlVGltZRgIIAEoARIRCglIYXB0aWNDdWUYCSABKAkahwMKB0JB";
            val_1[94] = "VFRFUlkSMQoEQmFzZRgBIAEoCzIjLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5C";
            val_1[95] = "QVRURVJZLkJBU0USPQoKRmxhc2hsaWdodBgCIAEoCzIpLlByb3RvRGF0YS5B";
            val_1[96] = "VFRBQ0tfREFUQS5CQVRURVJZLkZMQVNITElHSFQSNwoHU2hvY2tlchgDIAEo";
            val_1[97] = "CzImLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5CQVRURVJZLlNIT0NLRVISNwoH";
            val_1[98] = "SGF5d2lyZRgEIAEoCzImLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5CQVRURVJZ";
            val_1[99] = "LkhBWVdJUkUaGQoEQkFTRRIRCglCYXNlRHJhaW4YASABKAEaOgoKRkxBU0hM";
            val_1[100] = "SUdIVBITCgtBY3RpdmVEcmFpbhgBIAEoARIXCg9BY3RpdmF0aW9uRHJhaW4Y";
            val_1[101] = "AiABKAEaIgoHU0hPQ0tFUhIXCg9BY3RpdmF0aW9uRHJhaW4YASABKAEaHQoH";
            val_1[102] = "SEFZV0lSRRISCgpTaG9ja0RyYWluGAEgASgBGkIKFEZMQVNITElHSFRSRVBP";
            val_1[103] = "U0lUSU9OEhQKDEluY3JlYXNlVGltZRgBIAEoARIUCgxEZWNyZWFzZVRpbWUY";
            val_1[104] = "AiABKAEaewoLUEhBTlRPTVdBTEsSNwoRRW5jb3VudGVyQnVyblRpbWUYASAB";
            val_1[105] = "KAsyHC5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuUkFOR0USMwoNUGhhc2VCdXJu";
            val_1[106] = "VGltZRgCIAEoCzIcLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5SQU5HRRqCAQoP";
            val_1[107] = "UEhBTlRPTU9WRVJMT0FEEjIKDFJlYWN0aW9uVGltZRgBIAEoCzIcLlByb3Rv";
            val_1[108] = "RGF0YS5BVFRBQ0tfREFUQS5SQU5HRRI7ChVGbGFzaGxpZ2h0RGlzYWJsZVRp";
            val_1[109] = "bWUYAiABKAsyHC5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuUkFOR0UaPQoMUEhB";
            val_1[110] = "TlRPTVBBVVNFEi0KB1NlY29uZHMYASABKAsyHC5Qcm90b0RhdGEuQVRUQUNL";
            val_1[111] = "X0RBVEEuUkFOR0UaVAoLQ0FNRVJBU0hBS0USEQoJTWFnbml0dWRlGAEgASgB";
            val_1[112] = "EhEKCVJvdWdobmVzcxgCIAEoARIOCgZGYWRlSW4YAyABKAESDwoHRmFkZU91";
            val_1[113] = "dBgEIAEoARr/AQoJRk9PVFNURVBTEj0KBFdhbGsYASABKAsyLy5Qcm90b0Rh";
            val_1[114] = "dGEuQVRUQUNLX0RBVEEuRk9PVFNURVBTLkZPT1RTVEVQQ09ORklHEjwKA1J1";
            val_1[115] = "bhgCIAEoCzIvLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5GT09UU1RFUFMuRk9P";
            val_1[116] = "VFNURVBDT05GSUcadQoORk9PVFNURVBDT05GSUcSEwoLRWZmZWN0RGVsYXkY";
            val_1[117] = "ASABKAESNwoLQ2FtZXJhU2hha2UYAiABKAsyIi5Qcm90b0RhdGEuQVRUQUNL";
            val_1[118] = "X0RBVEEuQ0FNRVJBU0hBS0USFQoNVmlicmF0aW9uVHlwZRgDIAEoCRoiCglK";
            val_1[119] = "VU1QU0NBUkUSFQoNVmlicmF0aW9uVHlwZRgBIAEoCRqeCAoFRU5UUlkSDwoH";
            val_1[120] = "TG9naWNhbBgBIAEoCRIZChFXYWl0Rm9yQ2FtZXJhVGltZRgCIAEoARJFChJU";
            val_1[121] = "ZWxlcG9ydFJlcG9zaXRpb24YAyABKAsyKS5Qcm90b0RhdGEuQVRUQUNLX0RB";
            val_1[122] = "VEEuVEVMRVBPUlRSRVBPU0lUSU9OEjkKDEluaXRpYWxQYXVzZRgEIAEoCzIj";
            val_1[123] = "LlByb3RvRGF0YS5BVFRBQ0tfREFUQS5JTklUSUFMUEFVU0USLQoGQ2lyY2xl";
            val_1[124] = "GAUgASgLMh0uUHJvdG9EYXRhLkFUVEFDS19EQVRBLkNJUkNMRRIrCgVQYXVz";
            val_1[125] = "ZRgGIAEoCzIcLlByb3RvRGF0YS5BVFRBQ0tfREFUQS5QQVVTRRItCgZDaGFy";
            val_1[126] = "Z2UYByABKAsyHS5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuQ0hBUkdFEi8KB0hh";
            val_1[127] = "eXdpcmUYCCABKAsyHi5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuSEFZV0lSRRI1";
            val_1[128] = "CgpEaXNydXB0aW9uGAkgASgLMiEuUHJvdG9EYXRhLkFUVEFDS19EQVRBLkRJ";
            val_1[129] = "U1JVUFRJT04SLwoHQmF0dGVyeRgKIAEoCzIeLlByb3RvRGF0YS5BVFRBQ0tf";
            val_1[130] = "REFUQS5CQVRURVJZEkkKFEZsYXNobGlnaHRSZXBvc2l0aW9uGAsgASgLMisu";
            val_1[131] = "UHJvdG9EYXRhLkFUVEFDS19EQVRBLkZMQVNITElHSFRSRVBPU0lUSU9OEhUK";
            val_1[132] = "DVN0YXRpY1Byb2ZpbGUYDCABKAkSGQoRTnVtU2hvY2tzVG9EZWZlYXQYDSAB";
            val_1[133] = "KAESNwoLUGhhbnRvbVdhbGsYDiABKAsyIi5Qcm90b0RhdGEuQVRUQUNLX0RB";
            val_1[134] = "VEEuUEhBTlRPTVdBTEsSPwoPUGhhbnRvbU92ZXJsb2FkGA8gASgLMiYuUHJv";
            val_1[135] = "dG9EYXRhLkFUVEFDS19EQVRBLlBIQU5UT01PVkVSTE9BRBI5CgxQaGFudG9t";
            val_1[136] = "UGF1c2UYECABKAsyIy5Qcm90b0RhdGEuQVRUQUNLX0RBVEEuUEhBTlRPTVBB";
            val_1[137] = "VVNFEhUKDUVuY291bnRlclR5cGUYESABKAkSMwoJRm9vdHN0ZXBzGBIgASgL";
            val_1[138] = "MiAuUHJvdG9EYXRhLkFUVEFDS19EQVRBLkZPT1RTVEVQUxIvCgdHbGltcHNl";
            val_1[139] = "GBMgASgLMh4uUHJvdG9EYXRhLkFUVEFDS19EQVRBLkdMSU1QU0USGQoRT2Zm";
            val_1[140] = "bGluZUV4cGlyZVRpbWUYFCABKAESMwoJSnVtcHNjYXJlGBUgASgLMiAuUHJv";
            val_1[141] = "dG9EYXRhLkFUVEFDS19EQVRBLkpVTVBTQ0FSRRIXCg9Jc01hc2tBdmFpbGFi";
            val_1[142] = "bGUYFiABKAgSKwoFU3VyZ2UYFyABKAsyHC5Qcm90b0RhdGEuQVRUQUNLX0RB";
            val_1[143] = "VEEuU1VSR0ViBnByb3RvMw==";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_5 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_8 = new string[1];
            val_8[0] = "Entries";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_9 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[20];
            string[] val_12 = new string[2];
            val_12[0] = "Min";
            val_12[1] = "Max";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_13 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.RANGE.Parser, propertyNames:  val_12, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_9 == null)
            {
                goto label_453;
            }
            
            if(val_13 != null)
            {
                goto label_454;
            }
            
            goto label_457;
            label_453:
            if(val_13 == null)
            {
                goto label_457;
            }
            
            label_454:
            label_457:
            val_9[0] = val_13;
            string[] val_16 = new string[2];
            val_16[0] = "Chance";
            val_16[1] = "Modifier";
            val_9[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.CHANCE.Parser, propertyNames:  val_16, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_20 = new string[2];
            val_20[0] = "AngleFromCamera";
            val_20[1] = "DistanceFromCamera";
            val_9[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.TELEPORTREPOSITION.Parser, propertyNames:  val_20, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_24 = new string[1];
            val_24[0] = "Seconds";
            val_9[3] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.INITIALPAUSE.Parser, propertyNames:  val_24, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_28 = new string[6];
            val_28[0] = "Seconds";
            val_28[1] = "DegreesPerSecond";
            val_28[2] = "NextPhase";
            val_28[3] = "FootstepSpeedScalar";
            val_28[4] = "ChangeSpeed";
            val_28[5] = "TriggerPercent";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_29 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_32 = new string[3];
            val_32[0] = "Circle";
            val_32[1] = "Charge";
            val_32[2] = "Pause";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_33 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.CIRCLE.Types.NEXTPHASE.Parser, propertyNames:  val_32, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_29 == null)
            {
                goto label_525;
            }
            
            if(val_33 != null)
            {
                goto label_526;
            }
            
            goto label_529;
            label_525:
            if(val_33 == null)
            {
                goto label_529;
            }
            
            label_526:
            label_529:
            val_29[0] = val_33;
            val_9[4] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.CIRCLE.Parser, propertyNames:  val_28, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_29);
            string[] val_37 = new string[3];
            val_37[0] = "Seconds";
            val_37[1] = "NextPhase";
            val_37[2] = "UseGlimpse";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_38 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_41 = new string[3];
            val_41[0] = "Circle";
            val_41[1] = "Charge";
            val_41[2] = "Glimpse";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_42 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.PAUSE.Types.NEXTPHASE.Parser, propertyNames:  val_41, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_38 == null)
            {
                goto label_558;
            }
            
            if(val_42 != null)
            {
                goto label_559;
            }
            
            goto label_562;
            label_558:
            if(val_42 == null)
            {
                goto label_562;
            }
            
            label_559:
            label_562:
            val_38[0] = val_42;
            val_9[5] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.PAUSE.Parser, propertyNames:  val_37, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_38);
            string[] val_46 = new string[8];
            val_46[0] = "Cooldown";
            val_46[1] = "Distance";
            val_46[2] = "CloakDelayTime";
            val_46[3] = "ExpireTime";
            val_46[4] = "HalfAngleDeadZone";
            val_46[5] = "HalfAngleTeleport";
            val_46[6] = "PhaseDuration";
            val_46[7] = "RepositionDelay";
            val_9[6] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.GLIMPSE.Parser, propertyNames:  val_46, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_50 = new string[9];
            val_50[0] = "Seconds";
            val_50[1] = "ShockWindow";
            val_50[2] = "NextPhase";
            val_50[3] = "ForceShutdown";
            val_50[4] = "UseFeintDistance";
            val_50[5] = "JumpscareDelayChance";
            val_50[6] = "JumpscareDelayTime";
            val_50[7] = "SkipDelayedJumpscareChance";
            val_50[8] = "MaxShockWindow";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_51 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_54 = new string[4];
            val_54[0] = "Circle";
            val_54[1] = "Jumpscare";
            val_54[2] = "Pause";
            val_54[3] = "ForceCircleAfterPause";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_55 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE.Parser, propertyNames:  val_54, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_51 == null)
            {
                goto label_642;
            }
            
            if(val_55 != null)
            {
                goto label_643;
            }
            
            goto label_646;
            label_642:
            if(val_55 == null)
            {
                goto label_646;
            }
            
            label_643:
            label_646:
            val_51[0] = val_55;
            val_9[7] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.CHARGE.Parser, propertyNames:  val_50, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_51);
            string[] val_59 = new string[5];
            val_59[0] = "Settings";
            val_59[1] = "Circle";
            val_59[2] = "Pause";
            val_59[3] = "Charge";
            val_59[4] = "Multiwire";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_60 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[3];
            string[] val_63 = new string[11];
            val_63[0] = "Seconds";
            val_63[1] = "ShockCausesJumpscare";
            val_63[2] = "LookAway";
            val_63[3] = "LookTime";
            val_63[4] = "MaxCount";
            val_63[5] = "ShouldLookAway";
            val_63[6] = "ShouldLookAt";
            val_63[7] = "ShouldLookAtThenAway";
            val_63[8] = "LookChangeTriggerPercent";
            val_63[9] = "Cooldown";
            val_63[10] = "RequiredMaskState";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_64 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.HAYWIRE.Types.SETTINGS.Parser, propertyNames:  val_63, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_60 == null)
            {
                goto label_705;
            }
            
            if(val_64 != null)
            {
                goto label_706;
            }
            
            goto label_709;
            label_705:
            if(val_64 == null)
            {
                goto label_709;
            }
            
            label_706:
            label_709:
            val_60[0] = val_64;
            string[] val_67 = new string[4];
            val_67[0] = "Count";
            val_67[1] = "HalfAngle";
            val_67[2] = "LocateTime";
            val_67[3] = "HiddenTime";
            val_60[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE.Parser, propertyNames:  val_67, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_71 = new string[9];
            val_71[0] = "Activation";
            val_71[1] = "TriggerPercent";
            val_71[2] = "AddToMax";
            val_71[3] = "UseMax";
            val_71[4] = "GoToCircle";
            val_71[5] = "GoToPause";
            val_71[6] = "TeleportToCamera";
            val_71[7] = "AllowedHalfAngle";
            val_71[8] = "ForceCircleAfterPause";
            val_60[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS.Parser, propertyNames:  val_71, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_9[8] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.HAYWIRE.Parser, propertyNames:  val_59, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_60);
            string[] val_76 = new string[2];
            val_76[0] = "Settings";
            val_76[1] = "Shake";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_77 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[2];
            string[] val_80 = new string[6];
            val_80[0] = "Cooldown";
            val_80[1] = "Activation";
            val_80[2] = "RampTime";
            val_80[3] = "Style";
            val_80[4] = "CancelTime";
            val_80[5] = "CancelAction";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_81 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.DISRUPTION.Types.SETTINGS.Parser, propertyNames:  val_80, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_77 == null)
            {
                goto label_795;
            }
            
            if(val_81 != null)
            {
                goto label_796;
            }
            
            goto label_799;
            label_795:
            if(val_81 == null)
            {
                goto label_799;
            }
            
            label_796:
            label_799:
            val_77[0] = val_81;
            string[] val_84 = new string[2];
            val_84[0] = "ShakeMagnitude";
            val_84[1] = "ShakeGraceTime";
            val_77[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.DISRUPTION.Types.SHAKE.Parser, propertyNames:  val_84, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_9[9] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.DISRUPTION.Parser, propertyNames:  val_76, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_77);
            string[] val_89 = new string[1];
            val_89[0] = "Settings";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_90 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_93 = new string[9];
            val_93[0] = "Cooldown";
            val_93[1] = "Activation";
            val_93[2] = "CancelTime";
            val_93[3] = "CancelAction";
            val_93[4] = "BatteryDrainRateBase";
            val_93[5] = "BatteryDrainRateCancel";
            val_93[6] = "BlinkDuration";
            val_93[7] = "MaskLightFadeTime";
            val_93[8] = "HapticCue";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_94 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.SURGE.Types.SETTINGS.Parser, propertyNames:  val_93, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_90 == null)
            {
                goto label_852;
            }
            
            if(val_94 != null)
            {
                goto label_853;
            }
            
            goto label_856;
            label_852:
            if(val_94 == null)
            {
                goto label_856;
            }
            
            label_853:
            label_856:
            val_90[0] = val_94;
            val_9[10] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.SURGE.Parser, propertyNames:  val_89, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_90);
            string[] val_98 = new string[4];
            val_98[0] = "Base";
            val_98[1] = "Flashlight";
            val_98[2] = "Shocker";
            val_98[3] = "Haywire";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_99 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[4];
            string[] val_102 = new string[1];
            val_102[0] = "BaseDrain";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_103 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.BATTERY.Types.BASE.Parser, propertyNames:  val_102, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_99 == null)
            {
                goto label_882;
            }
            
            if(val_103 != null)
            {
                goto label_883;
            }
            
            goto label_886;
            label_882:
            if(val_103 == null)
            {
                goto label_886;
            }
            
            label_883:
            label_886:
            val_99[0] = val_103;
            string[] val_106 = new string[2];
            val_106[0] = "ActiveDrain";
            val_106[1] = "ActivationDrain";
            val_99[1] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.BATTERY.Types.FLASHLIGHT.Parser, propertyNames:  val_106, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_110 = new string[1];
            val_110[0] = "ActivationDrain";
            val_99[2] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.BATTERY.Types.SHOCKER.Parser, propertyNames:  val_110, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_114 = new string[1];
            val_114[0] = "ShockDrain";
            val_99[3] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.BATTERY.Types.HAYWIRE.Parser, propertyNames:  val_114, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            val_9[11] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.BATTERY.Parser, propertyNames:  val_98, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_99);
            string[] val_119 = new string[2];
            val_119[0] = "IncreaseTime";
            val_119[1] = "DecreaseTime";
            val_9[12] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.FLASHLIGHTREPOSITION.Parser, propertyNames:  val_119, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_123 = new string[2];
            val_123[0] = "EncounterBurnTime";
            val_123[1] = "PhaseBurnTime";
            val_9[13] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.PHANTOMWALK.Parser, propertyNames:  val_123, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_127 = new string[2];
            val_127[0] = "ReactionTime";
            val_127[1] = "FlashlightDisableTime";
            val_9[14] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.PHANTOMOVERLOAD.Parser, propertyNames:  val_127, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_131 = new string[1];
            val_131[0] = "Seconds";
            val_9[15] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.PHANTOMPAUSE.Parser, propertyNames:  val_131, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_135 = new string[4];
            val_135[0] = "Magnitude";
            val_135[1] = "Roughness";
            val_135[2] = "FadeIn";
            val_135[3] = "FadeOut";
            val_9[16] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.CAMERASHAKE.Parser, propertyNames:  val_135, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_139 = new string[2];
            val_139[0] = "Walk";
            val_139[1] = "Run";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo[] val_140 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo[1];
            string[] val_143 = new string[3];
            val_143[0] = "EffectDelay";
            val_143[1] = "CameraShake";
            val_143[2] = "VibrationType";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_144 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG.Parser, propertyNames:  val_143, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if(val_140 == null)
            {
                goto label_1006;
            }
            
            if(val_144 != null)
            {
                goto label_1007;
            }
            
            goto label_1010;
            label_1006:
            if(val_144 == null)
            {
                goto label_1010;
            }
            
            label_1007:
            label_1010:
            val_140[0] = val_144;
            val_9[17] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.FOOTSTEPS.Parser, propertyNames:  val_139, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_140);
            string[] val_148 = new string[1];
            val_148[0] = "VibrationType";
            val_9[18] = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ATTACK_DATA.Types.JUMPSCARE.Parser, propertyNames:  val_148, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            string[] val_152 = new string[23];
            val_152[0] = "Logical";
            val_152[1] = "WaitForCameraTime";
            val_152[2] = "TeleportReposition";
            val_152[3] = "InitialPause";
            val_152[4] = "Circle";
            val_152[5] = "Pause";
            val_152[6] = "Charge";
            val_152[7] = "Haywire";
            val_152[8] = "Disruption";
            val_152[9] = "Battery";
            val_152[10] = "FlashlightReposition";
            val_152[11] = "StaticProfile";
            val_152[12] = "NumShocksToDefeat";
            val_152[13] = "PhantomWalk";
            val_152[14] = "PhantomOverload";
            val_152[15] = "PhantomPause";
            val_152[16] = "EncounterType";
            val_152[17] = "Footsteps";
            val_152[18] = "Glimpse";
            val_152[19] = "OfflineExpireTime";
            val_152[20] = "Jumpscare";
            val_152[21] = "IsMaskAvailable";
            val_152[22] = "Surge";
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_153 = null;
            val_157 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_153 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  val_157, parser:  ATTACK_DATA.Types.ENTRY.Parser, propertyNames:  val_152, oneofNames:  0, nestedEnums:  0, nestedTypes:  0);
            if((val_153 != null) && (val_153 == null))
            {
                    val_157 = 0;
            }
            
            if(val_9.Length <= 19)
            {
                    val_157 = 0;
            }
            
            val_9[19] = val_153;
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_154 = new Google.Protobuf.Reflection.GeneratedClrTypeInfo(clrType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), parser:  ProtoData.ATTACK_DATA.Parser, propertyNames:  val_8, oneofNames:  0, nestedEnums:  0, nestedTypes:  val_9);
            if(val_5 == 0)
            {
                goto label_1099;
            }
            
            if(val_154 != null)
            {
                goto label_1100;
            }
            
            goto label_1103;
            label_1099:
            if(val_154 == null)
            {
                goto label_1103;
            }
            
            label_1100:
            Google.Protobuf.Reflection.GeneratedClrTypeInfo val_157 = val_5[4];
            label_1103:
            mem[1152921523833037328] = val_154;
            val_158 = null;
            ProtoData.ATTACKDATAReflection.descriptor = Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(descriptorData:  System.Convert.FromBase64String(s:  +val_1), dependencies:  new Google.Protobuf.Reflection.FileDescriptor[0], generatedCodeInfo:  new Google.Protobuf.Reflection.GeneratedClrTypeInfo(nestedEnums:  0, nestedTypes:  val_5));
        }
    
    }

}
