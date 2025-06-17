using UnityEngine;

namespace Microsoft.AppCenter.Unity.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class CustomPropertiesInternal
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject Create()
        {
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "com.microsoft.appcenter.CustomProperties", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetString(UnityEngine.AndroidJavaObject properties, string key, string val)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = val;
            UnityEngine.AndroidJavaObject val_2 = properties.Call<UnityEngine.AndroidJavaObject>(methodName:  "set", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetNumber(UnityEngine.AndroidJavaObject properties, string key, int val)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = Microsoft.AppCenter.Unity.Internal.Utility.JavaNumberHelper.Convert(val:  val);
            UnityEngine.AndroidJavaObject val_3 = properties.Call<UnityEngine.AndroidJavaObject>(methodName:  "set", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetNumber(UnityEngine.AndroidJavaObject properties, string key, long val)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = Microsoft.AppCenter.Unity.Internal.Utility.JavaNumberHelper.Convert(val:  val);
            UnityEngine.AndroidJavaObject val_3 = properties.Call<UnityEngine.AndroidJavaObject>(methodName:  "set", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetNumber(UnityEngine.AndroidJavaObject properties, string key, float val)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = Microsoft.AppCenter.Unity.Internal.Utility.JavaNumberHelper.Convert(val:  val);
            UnityEngine.AndroidJavaObject val_3 = properties.Call<UnityEngine.AndroidJavaObject>(methodName:  "set", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetNumber(UnityEngine.AndroidJavaObject properties, string key, double val)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = Microsoft.AppCenter.Unity.Internal.Utility.JavaNumberHelper.Convert(val:  val);
            UnityEngine.AndroidJavaObject val_3 = properties.Call<UnityEngine.AndroidJavaObject>(methodName:  "set", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetBool(UnityEngine.AndroidJavaObject properties, string key, bool val)
        {
            object[] val_1 = new object[2];
            val_1[0] = key;
            val_1[1] = val;
            UnityEngine.AndroidJavaObject val_3 = properties.Call<UnityEngine.AndroidJavaObject>(methodName:  "set", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetDate(UnityEngine.AndroidJavaObject properties, string key, System.DateTime val)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = Microsoft.AppCenter.Unity.Internal.Utility.JavaDateHelper.DateTimeConvert(date:  new System.DateTime() {dateData = val.dateData});
            UnityEngine.AndroidJavaObject val_3 = properties.Call<UnityEngine.AndroidJavaObject>(methodName:  "set", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Clear(UnityEngine.AndroidJavaObject properties, string key)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            UnityEngine.AndroidJavaObject val_2 = properties.Call<UnityEngine.AndroidJavaObject>(methodName:  "clear", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CustomPropertiesInternal()
        {
        
        }
    
    }

}
