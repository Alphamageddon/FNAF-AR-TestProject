using UnityEngine;

namespace Microsoft.AppCenter.Unity.Internal.Utility
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JavaStringMapHelper
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.Dictionary<string, string> ConvertFromJava(UnityEngine.AndroidJavaObject map)
        {
            var val_10;
            System.Collections.Generic.Dictionary<System.String, System.String> val_7 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_10 = 0;
            goto label_4;
            label_15:
            string val_10 = UnityEngine.AndroidJNIHelper.ConvertFromJNIArray<System.String[]>(array:  map.Call<UnityEngine.AndroidJavaObject>(methodName:  "keySet", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "toArray", args:  System.Array.Empty<System.Object>()).GetRawObject())[0];
            object[] val_8 = new object[1];
            if(val_8 == null)
            {
                goto label_6;
            }
            
            if(val_10 != null)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            if(val_10 == null)
            {
                goto label_10;
            }
            
            label_7:
            label_10:
            val_8[0] = val_10;
            val_7.set_Item(key:  val_10, value:  map.Call<System.String>(methodName:  "get", args:  val_8));
            val_10 = 1;
            label_4:
            if(val_10 < val_6.Length)
            {
                goto label_15;
            }
            
            return val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject ConvertToJava(System.Collections.Generic.IDictionary<string, string> properties)
        {
            var val_10;
            var val_11;
            System.Object[] val_15;
            val_11 = properties;
            if(val_11 == null)
            {
                    return (UnityEngine.AndroidJavaObject)val_11;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_10 = System.Linq.Enumerable.ToArray<System.String>(source:  val_11.Keys);
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            int val_8 = val_11.Count;
            val_15 = System.Array.Empty<System.Object>();
            UnityEngine.AndroidJavaObject val_10 = null;
            val_11 = val_10;
            val_10 = new UnityEngine.AndroidJavaObject(className:  "java.util.HashMap", args:  val_15);
            if(val_8 < 1)
            {
                    return (UnityEngine.AndroidJavaObject)val_11;
            }
            
            var val_16 = 0;
            label_29:
            object[] val_11 = new object[2];
            if(val_11 == null)
            {
                goto label_17;
            }
            
            if(null != null)
            {
                goto label_18;
            }
            
            goto label_21;
            label_17:
            if(null == null)
            {
                goto label_21;
            }
            
            label_18:
            label_21:
            val_11[0] = null;
            val_11[1] = null;
            UnityEngine.AndroidJavaObject val_12 = val_10.Call<UnityEngine.AndroidJavaObject>(methodName:  "put", args:  val_11);
            val_16 = val_16 + 1;
            if(val_8 != val_16)
            {
                goto label_29;
            }
            
            return (UnityEngine.AndroidJavaObject)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JavaStringMapHelper()
        {
        
        }
    
    }

}
