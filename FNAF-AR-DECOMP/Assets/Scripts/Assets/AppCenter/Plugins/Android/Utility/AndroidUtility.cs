using UnityEngine;

namespace Assets.AppCenter.Plugins.Android.Utility
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AndroidUtility
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject _context;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string PREFS_NAME = "AppCenterUserPrefs";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject GetAndroidContext()
        {
            var val_5;
            string val_6 = Assets.AppCenter.Plugins.Android.Utility.AndroidUtility.PREFS_NAME;
            if(val_6 != null)
            {
                    return val_6;
            }
            
            val_5 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            Assets.AppCenter.Plugins.Android.Utility.AndroidUtility.PREFS_NAME = val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplicationContext", args:  System.Array.Empty<System.Object>());
            val_6 = Assets.AppCenter.Plugins.Android.Utility.AndroidUtility.PREFS_NAME;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetPreferenceInt(string prefKey, int prefValue)
        {
            object[] val_2 = new object[2];
            val_2[0] = "AppCenterUserPrefs";
            val_2[1] = 0;
            object[] val_6 = new object[2];
            if(val_6 == null)
            {
                goto label_10;
            }
            
            if(prefKey != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(prefKey == null)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            val_6[0] = prefKey;
            val_6[1] = prefValue;
            Assets.AppCenter.Plugins.Android.Utility.AndroidUtility.GetAndroidContext().Call<UnityEngine.AndroidJavaObject>(methodName:  "getSharedPreferences", args:  val_2).Call<UnityEngine.AndroidJavaObject>(methodName:  "edit", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "putInt", args:  val_6).Call(methodName:  "apply", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetPreferenceString(string prefKey, string prefValue)
        {
            object[] val_2 = new object[2];
            val_2[0] = "AppCenterUserPrefs";
            val_2[1] = 0;
            object[] val_6 = new object[2];
            if(val_6 == null)
            {
                goto label_10;
            }
            
            if(prefKey != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(prefKey == null)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            val_6[0] = prefKey;
            val_6[1] = prefValue;
            Assets.AppCenter.Plugins.Android.Utility.AndroidUtility.GetAndroidContext().Call<UnityEngine.AndroidJavaObject>(methodName:  "getSharedPreferences", args:  val_2).Call<UnityEngine.AndroidJavaObject>(methodName:  "edit", args:  System.Array.Empty<System.Object>()).Call<UnityEngine.AndroidJavaObject>(methodName:  "putString", args:  val_6).Call(methodName:  "apply", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AndroidUtility()
        {
        
        }
    
    }

}
