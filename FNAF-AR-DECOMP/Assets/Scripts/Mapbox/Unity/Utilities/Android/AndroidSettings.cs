using UnityEngine;

namespace Mapbox.Unity.Utilities.Android
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AndroidSettings
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Open()
        {
            var val_22;
            var val_24;
            var val_25;
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaClass().GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "android.net.Uri");
            object[] val_6 = new object[3];
            val_6[0] = "package";
            val_6[1] = val_2.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>());
            UnityEngine.AndroidJavaObject val_7 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "fromParts", args:  val_6);
            object[] val_8 = new object[2];
            val_8[0] = "android.settings.APPLICATION_DETAILS_SETTINGS";
            val_8[1] = val_7;
            new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  val_8);
            object[] val_10 = new object[1];
            val_10[0] = "android.intent.category.DEFAULT";
            UnityEngine.AndroidJavaObject val_11 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "addCategory", args:  val_10);
            object[] val_12 = new object[1];
            val_12[0] = 268435456;
            UnityEngine.AndroidJavaObject val_13 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "setFlags", args:  val_12);
            object[] val_14 = new object[1];
            val_14[0] = new UnityEngine.AndroidJavaObject();
            val_2.Call(methodName:  "startActivity", args:  val_14);
            val_22 = 0;
            if(new UnityEngine.AndroidJavaObject() != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                new UnityEngine.AndroidJavaObject().Dispose();
            }
            
            if((208 == 208) || (val_22 == 0))
            {
                goto label_39;
            }
            
            val_22 = 0;
            val_24 = 0;
            val_25 = 222;
            if(val_7 != null)
            {
                goto label_40;
            }
            
            goto label_42;
            label_39:
            val_25 = 222;
            val_24 = val_22;
            if(val_7 == null)
            {
                goto label_42;
            }
            
            label_40:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_7.Dispose();
            label_42:
            if((222 != 222) && (val_24 != 0))
            {
                    val_22 = 0;
                val_24 = 0;
            }
            
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                new UnityEngine.AndroidJavaClass().Dispose();
            }
            
            if((((234 == 0) ? 234 : 234) != 234) && (val_24 != 0))
            {
                    val_22 = 0;
                val_24 = 0;
            }
            
            if(val_2 != null)
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_2.Dispose();
            }
            
            if((((246 == 0) ? 246 : 246) != 246) && (val_24 != 0))
            {
                    val_22 = 0;
                val_24 = 0;
            }
            
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                new UnityEngine.AndroidJavaClass().Dispose();
            }
            
            if(val_24 == 0)
            {
                    return;
            }
            
            if(258 == 0)
            {
                    return;
            }
            
            if(258 == 258)
            {
                    return;
            }
        
        }
    
    }

}
