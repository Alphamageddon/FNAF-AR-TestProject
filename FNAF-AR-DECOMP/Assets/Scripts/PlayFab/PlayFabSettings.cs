using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayFabSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabSharedSettings _playFabShared;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly PlayFab.PlayFabApiSettings staticSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly PlayFab.PlayFabAuthenticationContext staticPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SdkVersion = "2.75.191001";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string BuildIdentifier = "jbuild_unitysdk__sdk-unity-3-slave_0";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string VersionString = "UnitySDK-2.75.191001";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string AD_TYPE_IDFA = "Idfa";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string AD_TYPE_ANDROID_ID = "Adid";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal const string DefaultPlayFabApiUrl = "playfabapi.com";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string _localApiServer;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabSharedSettings PlayFabSharedPrivate { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string DeviceUniqueIdentifier { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string TitleId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static string VerticalName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool DisableAdvertising { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool DisableDeviceInfo { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool DisableFocusTimeCollection { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.PlayFabLogLevel LogLevel { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.WebRequestType RequestType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int RequestTimeout { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool RequestKeepAlive { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CompressApiData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string LoggerHost { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int LoggerPort { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool EnableRealTimeLogging { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int LogCapLimit { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string LocalApiServer { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabSettings()
        {
            var val_4;
            PlayFab.PlayFabSettings.DefaultPlayFabApiUrl = 0;
            val_4 = null;
            val_4 = null;
            .GetSO = new System.Func<PlayFabSharedSettings>(object:  PlayFabSettings.<>c.<>9, method:  PlayFabSharedSettings PlayFabSettings.<>c::<.cctor>b__0_0());
            PlayFab.PlayFabSettings.staticSettings = new PlayFab.PlayFabSettingsRedirect();
            PlayFab.PlayFabSettings.staticPlayer = new PlayFab.PlayFabAuthenticationContext();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabSharedSettings get_PlayFabSharedPrivate()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(PlayFab.PlayFabSettings.DefaultPlayFabApiUrl == 0)
            {
                    PlayFab.PlayFabSettings.DefaultPlayFabApiUrl = PlayFab.PlayFabSettings.GetSharedSettingsObjectPrivate();
            }
            
            val_4 = null;
            val_4 = null;
            return (PlayFabSharedSettings)PlayFab.PlayFabSettings.DefaultPlayFabApiUrl;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabSharedSettings GetSharedSettingsObjectPrivate()
        {
            int val_3 = val_1.Length;
            if(val_3 == 1)
            {
                    return (PlayFabSharedSettings)UnityEngine.Resources.LoadAll<PlayFabSharedSettings>(path:  "PlayFabSharedSettings")[0];
            }
            
            UnityEngine.Debug.LogWarning(message:  "The number of PlayFabSharedSettings objects should be 1: "("The number of PlayFabSharedSettings objects should be 1: ") + val_3);
            UnityEngine.Debug.LogWarning(message:  "If you are upgrading your SDK, you can ignore this warning as PlayFabSharedSettings will be imported soon. If you are not upgrading your SDK and you see this message, you should re-download the latest PlayFab source code.");
            val_3 = val_1.Length;
            return (PlayFabSharedSettings)UnityEngine.Resources.LoadAll<PlayFabSharedSettings>(path:  "PlayFabSharedSettings")[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_DeviceUniqueIdentifier()
        {
            UnityEngine.AndroidJavaObject val_4 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call<UnityEngine.AndroidJavaObject>(methodName:  "getContentResolver", args:  System.Array.Empty<System.Object>());
            UnityEngine.AndroidJavaClass val_5 = new UnityEngine.AndroidJavaClass(className:  "android.provider.Settings$Secure");
            object[] val_6 = new object[2];
            if(val_6 == null)
            {
                goto label_3;
            }
            
            if(val_4 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_4 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_6[0] = val_4;
            val_6[1] = "android_id";
            if(val_5 != null)
            {
                    return val_5.CallStatic<System.String>(methodName:  "getString", args:  val_6);
            }
            
            return val_5.CallStatic<System.String>(methodName:  "getString", args:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_TitleId()
        {
            null = null;
            if(PlayFab.PlayFabSettings.staticSettings == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_TitleId(string value)
        {
            null = null;
            if(PlayFab.PlayFabSettings.staticSettings == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static string get_VerticalName()
        {
            null = null;
            if(PlayFab.PlayFabSettings.staticSettings == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static void set_VerticalName(string value)
        {
            null = null;
            if(PlayFab.PlayFabSettings.staticSettings == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_DisableAdvertising()
        {
            null = null;
            if(PlayFab.PlayFabSettings.staticSettings == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_DisableAdvertising(bool value)
        {
            null = null;
            bool val_1 = value;
            goto typeof(PlayFab.PlayFabApiSettings).__il2cppRuntimeField_228;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_DisableDeviceInfo()
        {
            null = null;
            if(PlayFab.PlayFabSettings.staticSettings == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_DisableDeviceInfo(bool value)
        {
            null = null;
            bool val_1 = value;
            goto typeof(PlayFab.PlayFabApiSettings).__il2cppRuntimeField_248;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_DisableFocusTimeCollection()
        {
            null = null;
            if(PlayFab.PlayFabSettings.staticSettings == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_DisableFocusTimeCollection(bool value)
        {
            null = null;
            bool val_1 = value;
            goto typeof(PlayFab.PlayFabApiSettings).__il2cppRuntimeField_268;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.PlayFabLogLevel get_LogLevel()
        {
            if(PlayFab.PlayFabSettings.PlayFabSharedPrivate != null)
            {
                    return (PlayFab.PlayFabLogLevel)val_1.LogLevel;
            }
            
            return (PlayFab.PlayFabLogLevel)val_1.LogLevel;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_LogLevel(PlayFab.PlayFabLogLevel value)
        {
            PlayFabSharedSettings val_1 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            val_1.LogLevel = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.WebRequestType get_RequestType()
        {
            if(PlayFab.PlayFabSettings.PlayFabSharedPrivate != null)
            {
                    return (PlayFab.WebRequestType)val_1.RequestType;
            }
            
            return (PlayFab.WebRequestType)val_1.RequestType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_RequestType(PlayFab.WebRequestType value)
        {
            PlayFabSharedSettings val_1 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            val_1.RequestType = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int get_RequestTimeout()
        {
            if(PlayFab.PlayFabSettings.PlayFabSharedPrivate != null)
            {
                    return (int)val_1.RequestTimeout;
            }
            
            return (int)val_1.RequestTimeout;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_RequestTimeout(int value)
        {
            PlayFabSharedSettings val_1 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            val_1.RequestTimeout = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_RequestKeepAlive()
        {
            if(PlayFab.PlayFabSettings.PlayFabSharedPrivate != null)
            {
                    return (bool)val_1.RequestKeepAlive;
            }
            
            return (bool)val_1.RequestKeepAlive;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_RequestKeepAlive(bool value)
        {
            PlayFabSharedSettings val_1 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            val_1.RequestKeepAlive = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_CompressApiData()
        {
            if(PlayFab.PlayFabSettings.PlayFabSharedPrivate != null)
            {
                    return (bool)val_1.CompressApiData;
            }
            
            return (bool)val_1.CompressApiData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_CompressApiData(bool value)
        {
            PlayFabSharedSettings val_1 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            val_1.CompressApiData = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_LoggerHost()
        {
            if(PlayFab.PlayFabSettings.PlayFabSharedPrivate != null)
            {
                    return (string)val_1.LoggerHost;
            }
            
            return (string)val_1.LoggerHost;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_LoggerHost(string value)
        {
            PlayFabSharedSettings val_1 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            val_1.LoggerHost = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int get_LoggerPort()
        {
            if(PlayFab.PlayFabSettings.PlayFabSharedPrivate != null)
            {
                    return (int)val_1.LoggerPort;
            }
            
            return (int)val_1.LoggerPort;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_LoggerPort(int value)
        {
            PlayFabSharedSettings val_1 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            val_1.LoggerPort = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_EnableRealTimeLogging()
        {
            if(PlayFab.PlayFabSettings.PlayFabSharedPrivate != null)
            {
                    return (bool)val_1.EnableRealTimeLogging;
            }
            
            return (bool)val_1.EnableRealTimeLogging;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_EnableRealTimeLogging(bool value)
        {
            PlayFabSharedSettings val_1 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            val_1.EnableRealTimeLogging = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int get_LogCapLimit()
        {
            if(PlayFab.PlayFabSettings.PlayFabSharedPrivate != null)
            {
                    return (int)val_1.LogCapLimit;
            }
            
            return (int)val_1.LogCapLimit;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_LogCapLimit(int value)
        {
            PlayFabSharedSettings val_1 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            val_1.LogCapLimit = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_LocalApiServer()
        {
            null = null;
            if(PlayFab.PlayFabSettings._localApiServer == null)
            {
                    return PlayFab.Internal.PlayFabUtil.GetLocalSettingsFileProperty(propertyKey:  "LocalApiServer");
            }
            
            return (string)PlayFab.PlayFabSettings._localApiServer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_LocalApiServer(string value)
        {
            null = null;
            PlayFab.PlayFabSettings._localApiServer = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetFullUrl(string apiCall, System.Collections.Generic.Dictionary<string, string> getParams, PlayFab.PlayFabApiSettings apiSettings)
        {
            var val_21;
            var val_34;
            string val_35;
            var val_36;
            string val_37;
            string val_38;
            string val_39;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(capacity:  232);
            if(apiSettings == null)
            {
                goto label_1;
            }
            
            val_34 = 0;
            val_35 = 0;
            if((System.String.IsNullOrEmpty(value:  apiSettings)) != true)
            {
                    val_35 = apiSettings;
            }
            
            val_36 = 0;
            val_37 = 0;
            if((System.String.IsNullOrEmpty(value:  apiSettings)) != true)
            {
                    val_37 = apiSettings;
            }
            
            val_38 = 0;
            if((System.String.IsNullOrEmpty(value:  apiSettings)) == false)
            {
                goto label_4;
            }
            
            if(val_35 == null)
            {
                goto label_12;
            }
            
            label_13:
            if(val_37 != null)
            {
                goto label_50;
            }
            
            label_49:
            if(apiSettings == null)
            {
                goto label_50;
            }
            
            val_37 = 0;
            if((System.String.IsNullOrEmpty(value:  apiSettings)) == true)
            {
                goto label_50;
            }
            
            val_37 = apiSettings;
            if(val_38 != 0)
            {
                goto label_10;
            }
            
            goto label_19;
            label_1:
            val_37 = 0;
            val_38 = 0;
            goto label_12;
            label_4:
            val_38 = apiSettings;
            if(val_35 != null)
            {
                goto label_13;
            }
            
            label_12:
            PlayFabSharedSettings val_6 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            if((System.String.IsNullOrEmpty(value:  val_6.ProductionEnvironmentUrl)) == false)
            {
                goto label_17;
            }
            
            val_35 = "playfabapi.com";
            if(val_37 == null)
            {
                goto label_49;
            }
            
            label_50:
            if(val_38 == null)
            {
                goto label_19;
            }
            
            label_10:
            label_45:
            if((StartsWith(value:  "http")) != true)
            {
                    System.Text.StringBuilder val_9 = val_1.Append(value:  "https://");
                if((System.String.IsNullOrEmpty(value:  val_38)) != true)
            {
                    System.Text.StringBuilder val_12 = val_1.Append(value:  val_38).Append(value:  ".");
            }
            
                if((System.String.IsNullOrEmpty(value:  val_37)) != true)
            {
                    val_37 = val_1.Append(value:  val_37);
                System.Text.StringBuilder val_15 = val_37.Append(value:  ".");
            }
            
            }
            
            val_39 = apiCall;
            System.Text.StringBuilder val_17 = val_1.Append(value:  val_35).Append(value:  val_39);
            if(getParams == null)
            {
                goto label_61;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_18 = getParams.GetEnumerator();
            val_37 = 1152921515881768560;
            val_38 = 1152921515881769584;
            label_40:
            if(((-378677888) & 1) == 0)
            {
                goto label_32;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_22 = val_21.trackableId;
            if((1 & 1) != 0)
            {
                    System.Text.StringBuilder val_23 = val_1.Append(value:  "?");
            }
            else
            {
                    System.Text.StringBuilder val_24 = val_1.Append(value:  "&");
            }
            
            System.Text.StringBuilder val_28 = val_1.Append(value:  val_22.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key())).Append(value:  "=").Append(value:  val_22.m_SubId1);
            goto label_40;
            label_19:
            PlayFabSharedSettings val_29 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            if(val_35 != null)
            {
                goto label_45;
            }
            
            goto label_45;
            label_17:
            PlayFabSharedSettings val_30 = PlayFab.PlayFabSettings.PlayFabSharedPrivate;
            if(val_37 == null)
            {
                goto label_49;
            }
            
            goto label_50;
            label_32:
            val_39 = public System.Void Dictionary.Enumerator<System.String, System.String>::Dispose();
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
            label_61:
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
        }
    
    }

}
