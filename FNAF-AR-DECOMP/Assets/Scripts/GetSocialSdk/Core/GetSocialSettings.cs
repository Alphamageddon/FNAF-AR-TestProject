using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GetSocialSettings : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string UnityDemoAppAppId = "LuDPp7W0J4";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SettingsAssetName = "GetSocialSettings";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SettingsAssetPath = "Resources/";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.GetSocialSettings _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _appId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isAutoRegisrationForPushesEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isForegroundNotificationsEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _autoInitEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disableFacebookReferralCheck;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useGetSocialUi;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _getSocialCustomConfigurationFilePath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _getSocialDefaultConfigurationFilePath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _iosPushEnvironment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _deeplinkingDomains;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isAndroidEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isIosEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isIosPushEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isAndroidPushEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isAppIdValid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isRichNotificationsEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _extensionBundleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _extensionProvisioningProfile;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.GetSocialSettings Instance { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string AppId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool UseGetSocialUi { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsAutoRegisrationForPushesEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsForegroundNotificationsEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsAutoInitEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsFacebookReferralCheckDisabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string IosPushEnvironment { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<string> DeeplinkingDomains { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsAndroidEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsIosEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string UiConfigurationCustomFilePath { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsIosPushEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsAndroidPushEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsAppIdValidated { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsRichPushNotificationsEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ExtensionBundleId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ExtensionProvisioningProfile { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.GetSocialSettings get_Instance()
        {
            GetSocialSdk.Core.GetSocialSettings val_8;
            var val_9;
            val_8 = GetSocialSdk.Core.GetSocialSettings._instance;
            if(val_8 != 0)
            {
                    return (GetSocialSdk.Core.GetSocialSettings)GetSocialSdk.Core.GetSocialSettings._instance;
            }
            
            UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "GetSocialSettings");
            val_9 = 0;
            GetSocialSdk.Core.GetSocialSettings._instance = ;
            if(GetSocialSdk.Core.GetSocialSettings._instance != 0)
            {
                    return (GetSocialSdk.Core.GetSocialSettings)GetSocialSdk.Core.GetSocialSettings._instance;
            }
            
            GetSocialSdk.Core.GetSocialSettings._instance = UnityEngine.ScriptableObject.CreateInstance<GetSocialSdk.Core.GetSocialSettings>();
            val_5._appId = "LuDPp7W0J4";
            val_8 = GetSocialSdk.Core.GetSocialSettings.GetPluginPath();
            string val_7 = System.IO.Path.Combine(path1:  val_8, path2:  "Resources/");
            return (GetSocialSdk.Core.GetSocialSettings)GetSocialSdk.Core.GetSocialSettings._instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_AppId()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (string)val_1._appId;
            }
            
            return (string)val_1._appId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_AppId(string value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._appId = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_UseGetSocialUi()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._useGetSocialUi;
            }
            
            return (bool)val_1._useGetSocialUi;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_UseGetSocialUi(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._useGetSocialUi = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsAutoRegisrationForPushesEnabled()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._isAutoRegisrationForPushesEnabled;
            }
            
            return (bool)val_1._isAutoRegisrationForPushesEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsAutoRegisrationForPushesEnabled(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._isAutoRegisrationForPushesEnabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsForegroundNotificationsEnabled()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._isForegroundNotificationsEnabled;
            }
            
            return (bool)val_1._isForegroundNotificationsEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsForegroundNotificationsEnabled(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._isForegroundNotificationsEnabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsAutoInitEnabled()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._autoInitEnabled;
            }
            
            return (bool)val_1._autoInitEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsAutoInitEnabled(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._autoInitEnabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsFacebookReferralCheckDisabled()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._disableFacebookReferralCheck;
            }
            
            return (bool)val_1._disableFacebookReferralCheck;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsFacebookReferralCheckDisabled(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._disableFacebookReferralCheck = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_IosPushEnvironment()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (string)val_1._iosPushEnvironment;
            }
            
            return (string)val_1._iosPushEnvironment;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IosPushEnvironment(string value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._iosPushEnvironment = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<string> get_DeeplinkingDomains()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (System.Collections.Generic.List<System.String>)val_1._deeplinkingDomains;
            }
            
            return (System.Collections.Generic.List<System.String>)val_1._deeplinkingDomains;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_DeeplinkingDomains(System.Collections.Generic.List<string> value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._deeplinkingDomains = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsAndroidEnabled()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._isAndroidEnabled;
            }
            
            return (bool)val_1._isAndroidEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsAndroidEnabled(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._isAndroidEnabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsIosEnabled()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._isIosEnabled;
            }
            
            return (bool)val_1._isIosEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsIosEnabled(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._isIosEnabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_UiConfigurationCustomFilePath()
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            if((System.String.IsNullOrEmpty(value:  val_1._getSocialCustomConfigurationFilePath)) != false)
            {
                    GetSocialSdk.Core.GetSocialSettings val_3 = GetSocialSdk.Core.GetSocialSettings.Instance;
                if((System.String.IsNullOrEmpty(value:  val_3._getSocialDefaultConfigurationFilePath)) != true)
            {
                    GetSocialSdk.Core.GetSocialSettings val_5 = GetSocialSdk.Core.GetSocialSettings.Instance;
                GetSocialSdk.Core.GetSocialSettings val_6 = GetSocialSdk.Core.GetSocialSettings.Instance;
                val_5._getSocialCustomConfigurationFilePath = val_6._getSocialDefaultConfigurationFilePath;
                GetSocialSdk.Core.GetSocialSettings val_7 = GetSocialSdk.Core.GetSocialSettings.Instance;
                val_7._getSocialDefaultConfigurationFilePath = System.String.alignConst;
            }
            
            }
            
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (string)val_8._getSocialCustomConfigurationFilePath;
            }
            
            return (string)val_8._getSocialCustomConfigurationFilePath;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_UiConfigurationCustomFilePath(string value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._getSocialCustomConfigurationFilePath = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsIosPushEnabled()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._isIosPushEnabled;
            }
            
            return (bool)val_1._isIosPushEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsIosPushEnabled(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._isIosPushEnabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsAndroidPushEnabled()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._isAndroidPushEnabled;
            }
            
            return (bool)val_1._isAndroidPushEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsAndroidPushEnabled(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._isAndroidPushEnabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsAppIdValidated()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._isAppIdValid;
            }
            
            return (bool)val_1._isAppIdValid;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsAppIdValidated(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._isAppIdValid = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsRichPushNotificationsEnabled()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (bool)val_1._isRichNotificationsEnabled;
            }
            
            return (bool)val_1._isRichNotificationsEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_IsRichPushNotificationsEnabled(bool value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._isRichNotificationsEnabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_ExtensionBundleId()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (string)val_1._extensionBundleId;
            }
            
            return (string)val_1._extensionBundleId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_ExtensionBundleId(string value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._extensionBundleId = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_ExtensionProvisioningProfile()
        {
            if(GetSocialSdk.Core.GetSocialSettings.Instance != null)
            {
                    return (string)val_1._extensionProvisioningProfile;
            }
            
            return (string)val_1._extensionProvisioningProfile;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_ExtensionProvisioningProfile(string value)
        {
            GetSocialSdk.Core.GetSocialSettings val_1 = GetSocialSdk.Core.GetSocialSettings.Instance;
            val_1._extensionProvisioningProfile = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetPluginPath()
        {
            string val_2 = GetSocialSdk.Core.GetSocialSettings.GetAbsolutePluginPath().Replace(oldValue:  "\\", newValue:  "/");
            if(val_2 != null)
            {
                    return val_2.Replace(oldValue:  UnityEngine.Application.dataPath, newValue:  "Assets");
            }
            
            return val_2.Replace(oldValue:  UnityEngine.Application.dataPath, newValue:  "Assets");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetAbsolutePluginPath()
        {
            return System.IO.Path.GetDirectoryName(path:  System.IO.Path.GetDirectoryName(path:  GetSocialSdk.Core.GetSocialSettings.FindEditor(path:  UnityEngine.Application.dataPath)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string FindEditor(string path)
        {
            var val_4;
            string val_5;
            val_4 = 0;
            label_11:
            if(val_4 >= val_1.Length)
            {
                goto label_2;
            }
            
            string val_4 = System.IO.Directory.GetDirectories(path:  path)[0];
            var val_5 = 0;
            label_8:
            if(val_5 >= val_2.Length)
            {
                goto label_5;
            }
            
            val_5 = System.IO.Directory.GetFiles(path:  val_4)[0];
            val_5 = val_5 + 1;
            if((val_5.Contains(value:  "GetSocialSettingsEditor.cs")) == false)
            {
                goto label_8;
            }
            
            return (string)val_5;
            label_5:
            val_5 = val_4;
            val_4 = val_4 + 1;
            if(val_5 == null)
            {
                goto label_11;
            }
            
            return (string)val_5;
            label_2:
            val_5 = 0;
            return (string)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SaveAsset(string directory, string name)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void MarkAssetDirty()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSettings()
        {
            this._isAutoRegisrationForPushesEnabled = true;
            this._autoInitEnabled = true;
            this._useGetSocialUi = true;
            this._appId = System.String.alignConst;
            this._getSocialCustomConfigurationFilePath = System.String.alignConst;
            this._getSocialDefaultConfigurationFilePath = System.String.alignConst;
            this._iosPushEnvironment = System.String.alignConst;
            this._deeplinkingDomains = new System.Collections.Generic.List<System.String>();
            this._isAppIdValid = true;
            this._isRichNotificationsEnabled = true;
            this._extensionBundleId = System.String.alignConst;
            this._extensionProvisioningProfile = System.String.alignConst;
        }
    
    }

}
