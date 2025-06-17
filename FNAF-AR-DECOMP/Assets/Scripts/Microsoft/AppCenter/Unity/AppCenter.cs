using UnityEngine;

namespace Microsoft.AppCenter.Unity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AppCenter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.AppCenterTask<string> _secretTask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.AppCenterTask<string> _logUrlTask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.AppCenterTask<long> _storageSizeTask;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.LogLevel LogLevel { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Configured { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type Analytics { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type Crashes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type Distribute { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type Push { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Reflection.Assembly AppCenterAssembly { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.LogLevel get_LogLevel()
        {
            return Microsoft.AppCenter.Unity.Internal.AppCenterInternal.GetLogLevel();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_LogLevel(Microsoft.AppCenter.Unity.LogLevel value)
        {
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal.SetLogLevel(logLevel:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask SetEnabledAsync(bool enabled)
        {
            return Microsoft.AppCenter.Unity.Internal.AppCenterInternal.SetEnabledAsync(enabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartFromLibrary(System.Type[] servicesArray)
        {
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal.StartFromLibrary(servicesArray:  Microsoft.AppCenter.Unity.Internal.AppCenterInternal.ServicesToNativeTypes(services:  servicesArray));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<bool> IsEnabledAsync()
        {
            return Microsoft.AppCenter.Unity.Internal.AppCenterInternal.IsEnabledAsync();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<System.Nullable<System.Guid>> GetInstallIdAsync()
        {
            .guidTask = new Microsoft.AppCenter.Unity.AppCenterTask<System.Nullable<System.Guid>>();
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal.GetInstallIdAsync().ContinueWith(continuationAction:  new System.Action<Microsoft.AppCenter.Unity.AppCenterTask<System.String>>(object:  new AppCenter.<>c__DisplayClass9_0(), method:  System.Void AppCenter.<>c__DisplayClass9_0::<GetInstallIdAsync>b__0(Microsoft.AppCenter.Unity.AppCenterTask<string> t)));
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.Nullable<System.Guid>>)(AppCenter.<>c__DisplayClass9_0)[1152921526202837008].guidTask;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetSdkVersion()
        {
            return Microsoft.AppCenter.Unity.Internal.AppCenterInternal.GetSdkVersion();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<string> GetLogUrlAsync()
        {
            Microsoft.AppCenter.Unity.AppCenterTask<TResult> val_2;
            var val_3 = null;
            if(Microsoft.AppCenter.Unity.AppCenter._logUrlTask == null)
            {
                    Microsoft.AppCenter.Unity.AppCenterTask<System.String> val_1 = null;
                val_2 = val_1;
                val_1 = new Microsoft.AppCenter.Unity.AppCenterTask<System.String>();
                val_3 = null;
                val_3 = null;
                Microsoft.AppCenter.Unity.AppCenter._logUrlTask = val_2;
            }
            
            val_3 = null;
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.String>)Microsoft.AppCenter.Unity.AppCenter._logUrlTask;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<long> GetStorageSizeAsync()
        {
            Microsoft.AppCenter.Unity.AppCenterTask<TResult> val_2;
            var val_3 = null;
            if(Microsoft.AppCenter.Unity.AppCenter._storageSizeTask == null)
            {
                    Microsoft.AppCenter.Unity.AppCenterTask<System.Int64> val_1 = null;
                val_2 = val_1;
                val_1 = new Microsoft.AppCenter.Unity.AppCenterTask<System.Int64>();
                val_3 = null;
                val_3 = null;
                Microsoft.AppCenter.Unity.AppCenter._storageSizeTask = val_2;
            }
            
            val_3 = null;
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.Int64>)Microsoft.AppCenter.Unity.AppCenter._storageSizeTask;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetLogUrl(string logUrl)
        {
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal.SetLogUrl(logUrl:  logUrl);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CacheStorageSize(long storageSize)
        {
            var val_1;
            Microsoft.AppCenter.Unity.AppCenterTask<System.Int64> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Microsoft.AppCenter.Unity.AppCenter._storageSizeTask;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Microsoft.AppCenter.Unity.AppCenter._storageSizeTask;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.SetResult(result:  storageSize);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CacheLogUrl(string logUrl)
        {
            var val_1;
            Microsoft.AppCenter.Unity.AppCenterTask<System.String> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Microsoft.AppCenter.Unity.AppCenter._logUrlTask;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Microsoft.AppCenter.Unity.AppCenter._logUrlTask;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.SetResult(result:  logUrl);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_Configured()
        {
            return Microsoft.AppCenter.Unity.Internal.AppCenterInternal.IsConfigured();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomProperties(Microsoft.AppCenter.Unity.CustomProperties customProperties)
        {
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal.SetCustomProperties(properties:  customProperties.GetRawObject());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetWrapperSdk()
        {
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal.SetWrapperSdk(wrapperSdkVersion:  "2.3.0", wrapperSdkName:  "appcenter.unity", wrapperRuntimeVersion:  Microsoft.AppCenter.Unity.WrapperSdk.WrapperRuntimeVersion, liveUpdateReleaseLabel:  0, liveUpdateDeploymentKey:  0, liveUpdatePackageHash:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<string> GetSecretForPlatformAsync()
        {
            Microsoft.AppCenter.Unity.AppCenterTask<TResult> val_2;
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(Microsoft.AppCenter.Unity.AppCenter._secretTask == null)
            {
                    Microsoft.AppCenter.Unity.AppCenterTask<System.String> val_1 = null;
                val_2 = val_1;
                val_1 = new Microsoft.AppCenter.Unity.AppCenterTask<System.String>();
                val_4 = null;
                val_4 = null;
                Microsoft.AppCenter.Unity.AppCenter._secretTask = val_2;
                val_3 = null;
            }
            
            val_3 = null;
            return (Microsoft.AppCenter.Unity.AppCenterTask<System.String>)Microsoft.AppCenter.Unity.AppCenter._secretTask;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ParseAndSaveSecretForPlatform(string secrets)
        {
            int val_9;
            int val_10;
            var val_11;
            Microsoft.AppCenter.Unity.AppCenterTask<System.String> val_12;
            if(secrets == null)
            {
                goto label_7;
            }
            
            val_9 = "=";
            if((secrets.Contains(value:  "=")) == false)
            {
                goto label_7;
            }
            
            string val_2 = "android" + "="("=");
            val_9 = secrets.IndexOf(value:  val_2, comparisonType:  4);
            if(val_9 == 1)
            {
                goto label_7;
            }
            
            val_9 = val_2.Length + val_9;
            val_10 = System.String.alignConst;
            goto label_9;
            label_11:
            char val_5 = secrets.Chars[val_9];
            if((val_5 & 65535) == ';')
            {
                goto label_10;
            }
            
            val_9 = val_9 + 1;
            val_10 = val_10 + val_5;
            label_9:
            if(val_9 < secrets.Length)
            {
                goto label_11;
            }
            
            label_10:
            val_11 = null;
            val_11 = null;
            val_12 = Microsoft.AppCenter.Unity.AppCenter._secretTask;
            if(val_12 == null)
            {
                    return (string)val_10;
            }
            
            val_12 = Microsoft.AppCenter.Unity.AppCenter._secretTask;
            if(val_12 == null)
            {
                    val_12 = 0;
            }
            
            val_12.SetResult(result:  val_10);
            return (string)val_10;
            label_7:
            val_10 = secrets;
            return (string)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetUserId(string userId)
        {
            Microsoft.AppCenter.Unity.Internal.AppCenterInternal.SetUserId(userId:  userId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string GetPlatformIdentifier()
        {
            return "android";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type get_Analytics()
        {
            if(Microsoft.AppCenter.Unity.AppCenter.AppCenterAssembly == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type get_Crashes()
        {
            if(Microsoft.AppCenter.Unity.AppCenter.AppCenterAssembly == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type get_Distribute()
        {
            if(Microsoft.AppCenter.Unity.AppCenter.AppCenterAssembly == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type get_Push()
        {
            if(Microsoft.AppCenter.Unity.AppCenter.AppCenterAssembly == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Reflection.Assembly get_AppCenterAssembly()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppCenter()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AppCenter()
        {
            Microsoft.AppCenter.Unity.AppCenter._secretTask = new Microsoft.AppCenter.Unity.AppCenterTask<System.String>();
            Microsoft.AppCenter.Unity.AppCenter._logUrlTask = new Microsoft.AppCenter.Unity.AppCenterTask<System.String>();
            Microsoft.AppCenter.Unity.AppCenter._storageSizeTask = new Microsoft.AppCenter.Unity.AppCenterTask<System.Int64>();
        }
    
    }

}
