using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AndroidQueryPermissionsAdapter : IQueryPermissionsAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer masterEvents)
        {
            this._masterEvents = masterEvents;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasCameraPermissions()
        {
            return UnityEngine.Android.Permission.HasUserAuthorizedPermission(permission:  "android.permission.CAMERA");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasGPSPermissions()
        {
            return UnityEngine.Android.Permission.HasUserAuthorizedPermission(permission:  "android.permission.ACCESS_COARSE_LOCATION");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OpenSettings()
        {
            var val_22;
            var val_23;
            var val_25;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
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
            val_23 = 250;
            if(new UnityEngine.AndroidJavaObject() != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                new UnityEngine.AndroidJavaObject().Dispose();
            }
            
            if((250 == 250) || (val_22 == 0))
            {
                goto label_39;
            }
            
            val_22 = 0;
            val_25 = 0;
            if(val_7 != null)
            {
                goto label_40;
            }
            
            goto label_65;
            label_39:
            val_25 = ;
            if(val_7 == null)
            {
                goto label_65;
            }
            
            label_40:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_7.Dispose();
            label_65:
            if(( != 250) && (val_25 != 0))
            {
                    val_22 = 0;
                val_25 = 0;
            }
            
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                new UnityEngine.AndroidJavaClass().Dispose();
            }
            
            var val_18 = ( == 0) ? 250 : ();
            if((val_18 != 250) && (val_25 != 0))
            {
                    val_22 = 0;
                val_25 = 0;
            }
            
            if(val_2 != null)
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_2.Dispose();
            }
            
            var val_20 = (val_18 == 0) ? 250 : (val_18);
            if((val_20 != 250) && (val_25 != 0))
            {
                    val_22 = 0;
                val_25 = 0;
            }
            
            if(val_1 != null)
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_1.Dispose();
            }
            
            if(val_25 == 0)
            {
                    return;
            }
            
            if(val_20 == 0)
            {
                    return;
            }
            
            if(val_20 == 250)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OpenLocationSettings()
        {
            var val_9;
            var val_10;
            var val_12;
            var val_13;
            var val_14;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            object[] val_3 = new object[1];
            val_3[0] = "android.settings.LOCATION_SOURCE_SETTINGS";
            new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "android.content.Intent", args:  val_3);
            object[] val_5 = new object[1];
            val_5[0] = new UnityEngine.AndroidJavaObject();
            val_2.Call(methodName:  "startActivity", args:  val_5);
            val_9 = 0;
            val_10 = 101;
            if(new UnityEngine.AndroidJavaObject() != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                new UnityEngine.AndroidJavaObject().Dispose();
            }
            
            if((101 == 101) || (val_9 == 0))
            {
                goto label_17;
            }
            
            val_9 = 0;
            val_12 = 0;
            if(val_2 != null)
            {
                goto label_18;
            }
            
            goto label_30;
            label_17:
            val_12 = ;
            if(val_2 == null)
            {
                goto label_30;
            }
            
            label_18:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_2.Dispose();
            label_30:
            if(( != 101) && (val_12 != 0))
            {
                    val_9 = 0;
                val_12 = 0;
            }
            
            if(val_1 == null)
            {
                goto label_49;
            }
            
            label_48:
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_1.Dispose();
            label_49:
            if(val_12 == 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
            
            if( == 101)
            {
                    return;
            }
            
            val_13 = 0;
            val_14 = val_9;
            if(val_13 != 1)
            {
                goto label_47;
            }
            
            if((???) != 0)
            {
                goto label_48;
            }
            
            goto label_49;
            label_47:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Close()
        {
            UnityEngine.Application.Quit();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AndroidQueryPermissionsAdapter()
        {
        
        }
    
    }

}
