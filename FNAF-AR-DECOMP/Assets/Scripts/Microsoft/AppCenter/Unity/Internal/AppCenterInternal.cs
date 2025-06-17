using UnityEngine;

namespace Microsoft.AppCenter.Unity.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AppCenterInternal
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaClass _appCenter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetLogLevel(int logLevel)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(logLevel != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(logLevel == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = logLevel;
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic(methodName:  "setLogLevel", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetLogLevel()
        {
            null = null;
            if(Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter != null)
            {
                    return Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<System.Int32>(methodName:  "getLogLevel", args:  System.Array.Empty<System.Object>());
            }
            
            return Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<System.Int32>(methodName:  "getLogLevel", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsConfigured()
        {
            null = null;
            if(Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter != null)
            {
                    return Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<System.Boolean>(methodName:  "isConfigured", args:  System.Array.Empty<System.Object>());
            }
            
            return Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<System.Boolean>(methodName:  "isConfigured", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetLogUrl(string logUrl)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(logUrl != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(logUrl == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = logUrl;
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic(methodName:  "setLogUrl", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetUserId(string userId)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(userId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(userId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = userId;
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic(methodName:  "setUserId", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetSdkVersion()
        {
            null = null;
            if(Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter != null)
            {
                    return Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<System.String>(methodName:  "getSdkVersion", args:  System.Array.Empty<System.Object>());
            }
            
            return Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<System.String>(methodName:  "getSdkVersion", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask SetEnabledAsync(bool enabled)
        {
            var val_5;
            bool val_1 = enabled;
            val_5 = null;
            val_5 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            return (Microsoft.AppCenter.Unity.AppCenterTask)new Microsoft.AppCenter.Unity.AppCenterTask(javaFuture:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "setEnabled", args:  val_2));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<bool> IsEnabledAsync()
        {
            null = null;
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>)new Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>(javaFuture:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "isEnabled", args:  System.Array.Empty<System.Object>()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<string> GetInstallIdAsync()
        {
            var val_7 = null;
            .stringTask = new Microsoft.AppCenter.Unity.AppCenterTask<System.String>();
            new Microsoft.AppCenter.Unity.AppCenterTask<UnityEngine.AndroidJavaObject>(javaFuture:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstallId", args:  System.Array.Empty<System.Object>())).ContinueWith(continuationAction:  new System.Action<Microsoft.AppCenter.Unity.AppCenterTask<UnityEngine.AndroidJavaObject>>(object:  new AppCenterInternal.<>c__DisplayClass9_0(), method:  System.Void AppCenterInternal.<>c__DisplayClass9_0::<GetInstallIdAsync>b__0(Microsoft.AppCenter.Unity.AppCenterTask<UnityEngine.AndroidJavaObject> t)));
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.String>)(AppCenterInternal.<>c__DisplayClass9_0)[1152921526235103296].stringTask;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomProperties(UnityEngine.AndroidJavaObject properties)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(properties != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(properties == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = properties;
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic(methodName:  "setCustomProperties", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject GetAndroidApplication()
        {
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            if(val_2 != null)
            {
                    return val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplication", args:  System.Array.Empty<System.Object>());
            }
            
            return val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplication", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetWrapperSdk(string wrapperSdkVersion, string wrapperSdkName, string wrapperRuntimeVersion, string liveUpdateReleaseLabel, string liveUpdateDeploymentKey, string liveUpdatePackageHash)
        {
            var val_10;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "com.microsoft.appcenter.ingestion.models.WrapperSdk", args:  System.Array.Empty<System.Object>());
            object[] val_3 = new object[1];
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if(wrapperSdkVersion != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(wrapperSdkVersion == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3[0] = wrapperSdkVersion;
            val_2.Call(methodName:  "setWrapperSdkVersion", args:  val_3);
            object[] val_4 = new object[1];
            if(val_4 == null)
            {
                goto label_8;
            }
            
            if(wrapperSdkName != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(wrapperSdkName == null)
            {
                goto label_12;
            }
            
            label_9:
            label_12:
            val_4[0] = wrapperSdkName;
            val_2.Call(methodName:  "setWrapperSdkName", args:  val_4);
            object[] val_5 = new object[1];
            if(val_5 == null)
            {
                goto label_15;
            }
            
            if(wrapperRuntimeVersion != null)
            {
                goto label_16;
            }
            
            goto label_19;
            label_15:
            if(wrapperRuntimeVersion == null)
            {
                goto label_19;
            }
            
            label_16:
            label_19:
            val_5[0] = wrapperRuntimeVersion;
            val_2.Call(methodName:  "setWrapperRuntimeVersion", args:  val_5);
            object[] val_6 = new object[1];
            if(val_6 == null)
            {
                goto label_22;
            }
            
            if(liveUpdateReleaseLabel != null)
            {
                goto label_23;
            }
            
            goto label_26;
            label_22:
            if(liveUpdateReleaseLabel == null)
            {
                goto label_26;
            }
            
            label_23:
            label_26:
            val_6[0] = liveUpdateReleaseLabel;
            val_2.Call(methodName:  "setLiveUpdateReleaseLabel", args:  val_6);
            object[] val_7 = new object[1];
            if(val_7 == null)
            {
                goto label_29;
            }
            
            if(liveUpdateDeploymentKey != null)
            {
                goto label_30;
            }
            
            goto label_33;
            label_29:
            if(liveUpdateDeploymentKey == null)
            {
                goto label_33;
            }
            
            label_30:
            label_33:
            val_7[0] = liveUpdateDeploymentKey;
            val_2.Call(methodName:  "setLiveUpdateDeploymentKey", args:  val_7);
            object[] val_8 = new object[1];
            if(val_8 == null)
            {
                goto label_36;
            }
            
            if(liveUpdatePackageHash != null)
            {
                goto label_37;
            }
            
            goto label_40;
            label_36:
            if(liveUpdatePackageHash == null)
            {
                goto label_40;
            }
            
            label_37:
            label_40:
            val_8[0] = liveUpdatePackageHash;
            val_2.Call(methodName:  "setLiveUpdatePackageHash", args:  val_8);
            val_10 = null;
            val_10 = null;
            object[] val_9 = new object[1];
            if(val_9 == null)
            {
                goto label_45;
            }
            
            if(val_2 != null)
            {
                goto label_46;
            }
            
            goto label_49;
            label_45:
            if(val_2 == null)
            {
                goto label_49;
            }
            
            label_46:
            label_49:
            val_9[0] = val_2;
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic(methodName:  "setWrapperSdk", args:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Start(string appSecret, System.Type[] services)
        {
            int val_9;
            UnityEngine.jvalue[] val_6 = new UnityEngine.jvalue[3];
            val_9 = val_6.Length;
            if(val_9 == 0)
            {
                    val_9 = val_6.Length;
            }
            
            val_6[0] = Microsoft.AppCenter.Unity.Internal.AppCenterInternal.GetAndroidApplication().GetRawObject();
            if(val_9 <= 1)
            {
                    val_9 = val_6.Length;
            }
            
            val_6[1] = UnityEngine.AndroidJNI.NewStringUTF(bytes:  appSecret);
            val_6[2] = Microsoft.AppCenter.Unity.Internal.AppCenterInternal.ServicesToNativeTypes(services:  services);
            UnityEngine.AndroidJNI.CallStaticVoidMethod(clazz:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.GetRawClass(), methodID:  UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.GetRawClass(), name:  "start", sig:  "(Landroid/app/Application;Ljava/lang/String;[Ljava/lang/Class;)V"), args:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Start(System.Type[] services)
        {
            int val_8;
            UnityEngine.jvalue[] val_5 = new UnityEngine.jvalue[2];
            val_8 = val_5.Length;
            if(val_8 == 0)
            {
                    val_8 = val_5.Length;
            }
            
            val_5[0] = Microsoft.AppCenter.Unity.Internal.AppCenterInternal.GetAndroidApplication().GetRawObject();
            val_5[1] = Microsoft.AppCenter.Unity.Internal.AppCenterInternal.ServicesToNativeTypes(services:  services);
            UnityEngine.AndroidJNI.CallStaticVoidMethod(clazz:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.GetRawClass(), methodID:  UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.GetRawClass(), name:  "start", sig:  "(Landroid/app/Application;[Ljava/lang/Class;)V"), args:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Start(System.Type service)
        {
            System.Type[] val_1 = new System.Type[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(service != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(service == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = service;
            UnityEngine.jvalue[] val_6 = new UnityEngine.jvalue[1];
            val_6[0] = Microsoft.AppCenter.Unity.Internal.AppCenterInternal.ServicesToNativeTypes(services:  val_1);
            UnityEngine.AndroidJNI.CallStaticVoidMethod(clazz:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.GetRawClass(), methodID:  UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.GetRawClass(), name:  "start", sig:  "([Ljava/lang/Class;)V"), args:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartFromLibrary(IntPtr servicesArray)
        {
            var val_7;
            int val_8;
            val_7 = null;
            val_7 = null;
            UnityEngine.jvalue[] val_4 = new UnityEngine.jvalue[2];
            val_8 = val_4.Length;
            if(val_8 == 0)
            {
                    val_8 = val_4.Length;
            }
            
            val_4[0] = Assets.AppCenter.Plugins.Android.Utility.AndroidUtility.GetAndroidContext().GetRawObject();
            val_4[1] = servicesArray;
            UnityEngine.AndroidJNI.CallStaticVoidMethod(clazz:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.GetRawClass(), methodID:  UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.GetRawClass(), name:  "startFromLibrary", sig:  "(Landroid/content/Context;[Ljava/lang/Class;)V"), args:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static IntPtr ServicesToNativeTypes(System.Type[] services)
        {
            var val_10;
            var val_11;
            System.Collections.Generic.List<System.IntPtr> val_1 = new System.Collections.Generic.List<System.IntPtr>();
            val_10 = 0;
            goto label_1;
            label_12:
            object[] val_3 = new object[1];
            if(val_3 == null)
            {
                goto label_4;
            }
            
            if(val_1 != null)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(val_1 == null)
            {
                goto label_8;
            }
            
            label_5:
            label_8:
            val_3[0] = val_1;
            object val_4 = services[0].GetMethod(name:  "AddNativeType").Invoke(obj:  0, parameters:  val_3);
            val_10 = 1;
            label_1:
            if(val_10 < services.Length)
            {
                goto label_12;
            }
            
            IntPtr val_5 = UnityEngine.AndroidJNI.FindClass(name:  "java/lang/Class");
            IntPtr val_7 = UnityEngine.AndroidJNI.NewObjectArray(size:  val_1.Count, clazz:  val_5, obj:  val_5);
            val_11 = 0;
            goto label_14;
            label_17:
            UnityEngine.AndroidJNI.SetObjectArrayElement(array:  val_7, index:  0, obj:  val_1.Item[0]);
            val_11 = 1;
            label_14:
            if(val_11 < val_1.Count)
            {
                goto label_17;
            }
            
            return val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetMaxStorageSize(long size)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            object[] val_1 = new object[1];
            val_1[0] = size;
            Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean> val_3 = new Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>(javaFuture:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "setMaxStorageSize", args:  val_1));
            val_6 = null;
            val_6 = null;
            if((AppCenterInternal.<>c.<>9__18_0) == null)
            {
                goto label_10;
            }
            
            label_15:
            val_3.ContinueWith(continuationAction:  AppCenterInternal.<>c.<>9__18_0);
            return;
            label_10:
            AppCenterInternal.<>c.<>9__18_0 = new System.Action<Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>>(object:  AppCenterInternal.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AppCenterInternal.<>c::<SetMaxStorageSize>b__18_0(Microsoft.AppCenter.Unity.AppCenterTask<bool> task));
            if(val_3 != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppCenterInternal()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AppCenterInternal()
        {
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal._appCenter = new UnityEngine.AndroidJavaClass(className:  "com.microsoft.appcenter.AppCenter");
        }
    
    }

}
