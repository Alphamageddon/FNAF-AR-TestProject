using UnityEngine;

namespace SRDebugger.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SRDebugApiUtil
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ParseErrorException(System.Net.WebException ex)
        {
            var val_7;
            string val_9;
            var val_11;
            val_9 = 0;
            if(ex.Response != null)
            {
                    return (string)SRDebugger.Internal.SRDebugApiUtil.ParseErrorResponse(response:  SRDebugger.Internal.SRDebugApiUtil.ReadResponseStream(stream:  ex.Response), fallback:  "Unexpected Response");
            }
            
            val_11 = val_7;
            goto ??? + 376;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ParseErrorResponse(string response, string fallback = "Unexpected Response")
        {
            var val_16;
            string val_17;
            var val_18;
            var val_19;
            var val_22;
            var val_25;
            object val_6 = 0;
            object val_1 = SRF.Json.Deserialize(json:  response);
            val_16 = 1;
            val_17 = "" + 0.Item["errorMessage"];
            if((0.TryGetValue(key:  "errors", value: out  val_6)) == false)
            {
                    return (string)((response.Contains(value:  "<html>")) != true) ? fallback : response;
            }
            
            if(val_6 == 0)
            {
                    return (string)((response.Contains(value:  "<html>")) != true) ? fallback : response;
            }
            
            val_18 = null;
            var val_19 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_8;
            }
            
            var val_17 = mem[282584257676847];
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_10:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < mem[282584257676957])
            {
                goto label_10;
            }
            
            label_8:
            val_18 = null;
            goto label_11;
            label_9:
            val_19 = val_19 + (((mem[282584257676847] + 8)) << 4);
            val_19 = val_19 + 296;
            label_11:
            System.Collections.Generic.IEnumerator<T> val_8 = val_6.GetEnumerator();
            label_24:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_8.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            string val_14 = val_17 + "\n"(val_17 + "\n") + val_8.Current;
            goto label_24;
            label_18:
            val_16 = 0;
            val_22 = 122;
            if(val_8 != null)
            {
                goto label_25;
            }
            
            goto label_40;
            label_25:
            var val_24 = ;
            if((X0 + 286) == 0)
            {
                goto label_44;
            }
            
            var val_22 = X0 + 176;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_43:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_42;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (X0 + 286))
            {
                goto label_43;
            }
            
            goto label_44;
            label_42:
            val_24 = val_24 + (((X0 + 176 + 8)) << 4);
            val_25 = val_24 + 296;
            label_44:
            Dispose();
            label_40:
            if( == 122)
            {
                    return (string)((response.Contains(value:  "<html>")) != true) ? fallback : response;
            }
            
            if( == false)
            {
                    return (string)((response.Contains(value:  "<html>")) != true) ? fallback : response;
            }
            
            return (string)((response.Contains(value:  "<html>")) != true) ? fallback : response;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ReadResponse(System.Net.HttpWebRequest request, out string result)
        {
            result = SRDebugger.Internal.SRDebugApiUtil.ReadResponseStream(stream:  request);
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ReadResponseStream(System.Net.WebResponse stream)
        {
            var val_4;
            new System.IO.StreamReader() = new System.IO.StreamReader(stream:  stream);
            val_4 = 0;
            var val_4 = 0;
            val_4 = val_4 + 1;
            new System.IO.StreamReader().Dispose();
            if((val_4 != 0) && (43 != 43))
            {
                    val_4 = 0;
            }
            
            if(stream != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                stream.Dispose();
            }
            
            if(43 == 43)
            {
                    return (string)new System.IO.StreamReader();
            }
            
            if(val_4 == 0)
            {
                    return (string)new System.IO.StreamReader();
            }
            
            return (string)new System.IO.StreamReader();
        }
    
    }

}
