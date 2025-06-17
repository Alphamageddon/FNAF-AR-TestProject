using UnityEngine;

namespace Microsoft.AppCenter.Unity.Crashes.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class CrashesInternal
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaClass _crashes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaClass _wrapperSdkExceptionManager;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddNativeType(System.Collections.Generic.List<IntPtr> nativeTypes)
        {
            nativeTypes.Add(item:  UnityEngine.AndroidJNI.FindClass(name:  "com/microsoft/appcenter/crashes/Crashes"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void TrackException(UnityEngine.AndroidJavaObject exception)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(exception != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(exception == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = exception;
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._wrapperSdkExceptionManager.CallStatic(methodName:  "trackException", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void TrackException(UnityEngine.AndroidJavaObject exception, System.Collections.Generic.IDictionary<string, string> properties)
        {
            var val_3 = null;
            object[] val_2 = new object[2];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(exception != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(exception == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = exception;
            val_2[1] = Microsoft.AppCenter.Unity.Internal.Utility.JavaStringMapHelper.ConvertToJava(properties:  properties);
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._wrapperSdkExceptionManager.CallStatic(methodName:  "trackException", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<bool> HasReceivedMemoryWarningInLastSessionAsync()
        {
            null = null;
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>)new Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>(javaFuture:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._crashes.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "hasReceivedMemoryWarningInLastSession", args:  System.Array.Empty<System.Object>()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask SetEnabledAsync(bool isEnabled)
        {
            var val_5;
            bool val_1 = isEnabled;
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
            return (Microsoft.AppCenter.Unity.AppCenterTask)new Microsoft.AppCenter.Unity.AppCenterTask(javaFuture:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._crashes.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "setEnabled", args:  val_2));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<bool> IsEnabledAsync()
        {
            null = null;
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>)new Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>(javaFuture:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._crashes.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "isEnabled", args:  System.Array.Empty<System.Object>()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GenerateTestCrash()
        {
            var val_4;
            System.Threading.ThreadStart val_6;
            if(UnityEngine.Debug.isDebugBuild == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = CrashesInternal.<>c.<>9__8_0;
            if(val_6 == null)
            {
                    System.Threading.ThreadStart val_2 = null;
                val_6 = val_2;
                val_2 = new System.Threading.ThreadStart(object:  CrashesInternal.<>c.__il2cppRuntimeField_static_fields, method:  System.Void CrashesInternal.<>c::<GenerateTestCrash>b__8_0());
                CrashesInternal.<>c.<>9__8_0 = val_6;
            }
            
            new System.Threading.Thread(start:  val_2).Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<bool> HasCrashedInLastSessionAsync()
        {
            null = null;
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>)new Microsoft.AppCenter.Unity.AppCenterTask<System.Boolean>(javaFuture:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._crashes.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "hasCrashedInLastSession", args:  System.Array.Empty<System.Object>()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<Microsoft.AppCenter.Unity.Crashes.ErrorReport> GetLastSessionCrashReportAsync()
        {
            var val_7 = null;
            .errorReportTask = new Microsoft.AppCenter.Unity.AppCenterTask<Microsoft.AppCenter.Unity.Crashes.ErrorReport>();
            new Microsoft.AppCenter.Unity.AppCenterTask<UnityEngine.AndroidJavaObject>(javaFuture:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._crashes.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getLastSessionCrashReport", args:  System.Array.Empty<System.Object>())).ContinueWith(continuationAction:  new System.Action<Microsoft.AppCenter.Unity.AppCenterTask<UnityEngine.AndroidJavaObject>>(object:  new CrashesInternal.<>c__DisplayClass10_0(), method:  System.Void CrashesInternal.<>c__DisplayClass10_0::<GetLastSessionCrashReportAsync>b__0(Microsoft.AppCenter.Unity.AppCenterTask<UnityEngine.AndroidJavaObject> t)));
            return (Microsoft.AppCenter.Unity.AppCenterTask<Microsoft.AppCenter.Unity.Crashes.ErrorReport>)(CrashesInternal.<>c__DisplayClass10_0)[1152921526230840304].errorReportTask;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DisableMachExceptionHandler()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetUserConfirmationHandler(Microsoft.AppCenter.Unity.Crashes.Crashes.UserConfirmationHandler handler)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SetShouldAwaitUserConfirmationHandler(handler:  handler);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NotifyWithUserConfirmation(Microsoft.AppCenter.Unity.Crashes.Crashes.ConfirmationResult answer)
        {
            null = null;
            object[] val_1 = new object[1];
            int val_2 = Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.ToJavaConfirmationResult(answer:  answer);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_2 != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = val_2;
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._crashes.CallStatic(methodName:  "notifyUserConfirmation", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<string> GetMinidumpDirectoryAsync()
        {
            null = null;
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.String>)new Microsoft.AppCenter.Unity.AppCenterTask<System.String>(javaFuture:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._crashes.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getMinidumpDirectory", args:  System.Array.Empty<System.Object>()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartCrashes()
        {
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal.Start(service:  Microsoft.AppCenter.Unity.AppCenter.Crashes);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int ToJavaConfirmationResult(Microsoft.AppCenter.Unity.Crashes.Crashes.ConfirmationResult answer)
        {
            var val_1;
            var val_2;
            string val_3;
            var val_4;
            var val_5;
            var val_6;
            val_1 = answer;
            if(val_1 == 1)
            {
                    val_1 = 1152921505335652352;
                val_2 = null;
                val_2 = null;
                val_3 = "SEND";
                return 0.GetStatic<System.Int32>(fieldName:  val_3 = "DONT_SEND");
            }
            
            val_4 = null;
            if(val_1 == 2)
            {
                    val_5 = null;
                val_3 = "ALWAYS_SEND";
                return 0.GetStatic<System.Int32>(fieldName:  val_3);
            }
            
            val_6 = null;
            return 0.GetStatic<System.Int32>(fieldName:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CrashesInternal()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static CrashesInternal()
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._crashes = new UnityEngine.AndroidJavaClass(className:  "com.microsoft.appcenter.crashes.Crashes");
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal._wrapperSdkExceptionManager = new UnityEngine.AndroidJavaClass(className:  "com.microsoft.appcenter.crashes.WrapperSdkExceptionManager");
        }
    
    }

}
