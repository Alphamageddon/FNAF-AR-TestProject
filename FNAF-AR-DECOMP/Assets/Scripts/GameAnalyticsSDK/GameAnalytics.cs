using UnityEngine;

namespace GameAnalyticsSDK
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameAnalytics : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GameAnalyticsSDK.Setup.Settings _settings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GameAnalyticsSDK.GameAnalytics _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _hasInitializeBeenCalled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Action OnRemoteConfigsUpdatedEvent;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GameAnalyticsSDK.Setup.Settings SettingsGA { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GameAnalyticsSDK.Setup.Settings get_SettingsGA()
        {
            if(GameAnalyticsSDK.GameAnalytics._settings != 0)
            {
                    return (GameAnalyticsSDK.Setup.Settings)GameAnalyticsSDK.GameAnalytics._settings;
            }
            
            GameAnalyticsSDK.GameAnalytics.InitAPI();
            return (GameAnalyticsSDK.Setup.Settings)GameAnalyticsSDK.GameAnalytics._settings;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void set_SettingsGA(GameAnalyticsSDK.Setup.Settings value)
        {
            GameAnalyticsSDK.GameAnalytics._settings = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            UnityEngine.Application.add_logMessageReceived(value:  new Application.LogCallback(object:  0, method:  public static System.Void GameAnalyticsSDK.Events.GA_Debug::HandleLog(string logString, string stackTrace, UnityEngine.LogType type)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            UnityEngine.Application.remove_logMessageReceived(value:  new Application.LogCallback(object:  0, method:  public static System.Void GameAnalyticsSDK.Events.GA_Debug::HandleLog(string logString, string stackTrace, UnityEngine.LogType type)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Awake()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(GameAnalyticsSDK.GameAnalytics._instance != 0)
            {
                    UnityEngine.Debug.LogWarning(message:  "Destroying duplicate GameAnalytics object - only one is allowed per scene!");
                UnityEngine.Object.Destroy(obj:  this.gameObject);
                return;
            }
            
            GameAnalyticsSDK.GameAnalytics._instance = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(GameAnalyticsSDK.GameAnalytics._instance != this)
            {
                    return;
            }
            
            GameAnalyticsSDK.GameAnalytics._instance = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationQuit()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void InitAPI()
        {
            GameAnalyticsSDK.Setup.Settings val_5;
            if((UnityEngine.Resources.Load(path:  "GameAnalytics/Settings", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != null)
            {
                    val_5 = 0;
            }
            
            GameAnalyticsSDK.GameAnalytics._settings = val_5;
            GameAnalyticsSDK.State.GAState.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void InternalInitialize()
        {
            var val_35;
            var val_36;
            var val_37;
            System.Collections.Generic.List<UnityEngine.RuntimePlatform> val_38;
            var val_39;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Setup.Settings val_2 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_2.InfoLogBuild != false)
            {
                    GameAnalyticsSDK.Events.GA_Setup.SetInfoLog(enabled:  true);
            }
            
            GameAnalyticsSDK.Setup.Settings val_3 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_3.VerboseLogBuild != false)
            {
                    val_36 = 1;
                GameAnalyticsSDK.Events.GA_Setup.SetVerboseLog(enabled:  true);
            }
            
            int val_4 = GameAnalyticsSDK.GameAnalytics.GetPlatformIndex();
            val_37 = null;
            val_37 = null;
            val_38 = "unity ";
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetUnitySdkVersion(unitySdkVersion:  "unity " + GameAnalyticsSDK.Setup.Settings.VERSION);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetUnityEngineVersion(unityEngineVersion:  "unity " + GameAnalyticsSDK.GameAnalytics.GetUnityVersion());
            if((val_4 & 2147483648) != 0)
            {
                goto label_10;
            }
            
            GameAnalyticsSDK.Setup.Settings val_8 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_8.UsePlayerSettingsBuildNumber == false)
            {
                goto label_12;
            }
            
            val_39 = 0;
            goto label_13;
            label_24:
            GameAnalyticsSDK.Setup.Settings val_9 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_9.Platforms.Item[0] == 11)
            {
                goto label_16;
            }
            
            GameAnalyticsSDK.Setup.Settings val_11 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_11.Platforms.Item[0] != 8)
            {
                goto label_19;
            }
            
            label_16:
            GameAnalyticsSDK.Setup.Settings val_13 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_13.Build.set_Item(index:  0, value:  UnityEngine.Application.version);
            label_19:
            val_39 = 1;
            label_13:
            GameAnalyticsSDK.Setup.Settings val_15 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_38 = val_15.Platforms;
            if(val_39 < val_38.Count)
            {
                goto label_24;
            }
            
            label_12:
            GameAnalyticsSDK.Setup.Settings val_17 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetBuild(build:  val_17.Build.Item[val_4]);
            label_10:
            GameAnalyticsSDK.Setup.Settings val_19 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_19.CustomDimensions01.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_21 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableCustomDimensions01(customDimensions:  val_21.CustomDimensions01);
            }
            
            GameAnalyticsSDK.Setup.Settings val_22 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_22.CustomDimensions02.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_24 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableCustomDimensions02(customDimensions:  val_24.CustomDimensions02);
            }
            
            GameAnalyticsSDK.Setup.Settings val_25 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_25.CustomDimensions03.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_27 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableCustomDimensions03(customDimensions:  val_27.CustomDimensions03);
            }
            
            GameAnalyticsSDK.Setup.Settings val_28 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_28.ResourceItemTypes.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_30 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableResourceItemTypes(resourceItemTypes:  val_30.ResourceItemTypes);
            }
            
            GameAnalyticsSDK.Setup.Settings val_31 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_31.ResourceCurrencies.Count >= 1)
            {
                    GameAnalyticsSDK.Setup.Settings val_33 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                GameAnalyticsSDK.Events.GA_Setup.SetAvailableResourceCurrencies(resourceCurrencies:  val_33.ResourceCurrencies);
            }
            
            val_35 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_34.UseManualSessionHandling == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.GameAnalytics.SetEnabledManualSessionHandling(enabled:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Initialize()
        {
            string val_8;
            GameAnalyticsSDK.GameAnalytics.InternalInitialize();
            int val_1 = GameAnalyticsSDK.GameAnalytics.GetPlatformIndex();
            if((val_1 & 2147483648) == 0)
            {
                    val_8 = GameAnalyticsSDK.GameAnalytics.SettingsGA.GetSecretKey(index:  val_1);
                GameAnalyticsSDK.Wrapper.GA_Wrapper.Initialize(gamekey:  GameAnalyticsSDK.GameAnalytics.SettingsGA.GetGameKey(index:  val_1), gamesecret:  val_8);
                GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled = true;
                return;
            }
            
            GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled = true;
            val_8 = "GameAnalytics: Unsupported platform (events will not be sent in editor; or missing platform in settings): "("GameAnalytics: Unsupported platform (events will not be sent in editor; or missing platform in settings): ") + UnityEngine.Application.platform;
            UnityEngine.Debug.LogWarning(message:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Business.NewEvent(currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, cartType:  cartType, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewBusinessEventGooglePlay(string currency, int amount, string itemType, string itemId, string cartType, string receipt, string signature)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Business.NewEventGooglePlay(currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, cartType:  cartType, receipt:  receipt, signature:  signature, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewDesignEvent(string eventName)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Design.CreateNewEvent(eventName:  eventName, eventValue:  new System.Nullable<System.Single>() {HasValue = false}, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewDesignEvent(string eventName, float eventValue)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Design.NewEvent(eventName:  eventName, eventValue:  eventValue, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  0, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, int score)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.NewEvent(progressionStatus:  progressionStatus, progression01:  progression01, score:  score, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, int score)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.NewEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, score:  score, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, int score)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Progression.NewEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  score, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewResourceEvent(GameAnalyticsSDK.GAResourceFlowType flowType, string currency, float amount, string itemType, string itemId)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Resource.NewEvent(flowType:  flowType, currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewErrorEvent(GameAnalyticsSDK.GAErrorSeverity severity, string message)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Error.CreateNewEvent(severity:  severity, message:  message, fields:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewAdEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, long duration)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Ads.NewEvent(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, duration:  duration);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewAdEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, GameAnalyticsSDK.GAAdError noAdReason)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Ads.NewEvent(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, noAdReason:  noAdReason);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewAdEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement)
        {
            if(GameAnalyticsSDK.GameAnalytics._hasInitializeBeenCalled != false)
            {
                    GameAnalyticsSDK.Events.GA_Ads.NewEvent(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "GameAnalytics: REMEMBER THE SDK NEEDS TO BE MANUALLY INITIALIZED NOW");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetFacebookId(string facebookId)
        {
            GameAnalyticsSDK.Events.GA_Setup.SetFacebookId(facebookId:  facebookId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetGender(GameAnalyticsSDK.GAGender gender)
        {
            GameAnalyticsSDK.Events.GA_Setup.SetGender(gender:  gender);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetBirthYear(int birthYear)
        {
            GameAnalyticsSDK.Events.GA_Setup.SetBirthYear(birthYear:  birthYear);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomId(string userId)
        {
            UnityEngine.Debug.Log(message:  "Initializing with custom id: "("Initializing with custom id: ") + userId);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetCustomUserId(userId:  userId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetEnabledManualSessionHandling(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetEnabledManualSessionHandling(enabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetEnabledEventSubmission(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetEnabledEventSubmission(enabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartSession()
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.StartSession();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void EndSession()
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.EndSession();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomDimension01(string customDimension)
        {
            GameAnalyticsSDK.Events.GA_Setup.SetCustomDimension01(customDimension:  customDimension);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomDimension02(string customDimension)
        {
            GameAnalyticsSDK.Events.GA_Setup.SetCustomDimension02(customDimension:  customDimension);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomDimension03(string customDimension)
        {
            GameAnalyticsSDK.Events.GA_Setup.SetCustomDimension03(customDimension:  customDimension);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_OnRemoteConfigsUpdatedEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent != 1152921505331183640);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_OnRemoteConfigsUpdatedEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent != 1152921505331183640);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRemoteConfigsUpdated()
        {
            if(GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent == null)
            {
                    return;
            }
            
            GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RemoteConfigsUpdated()
        {
            if(GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent == null)
            {
                    return;
            }
            
            GameAnalyticsSDK.GameAnalytics.OnRemoteConfigsUpdatedEvent.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetRemoteConfigsValueAsString(string key)
        {
            return GameAnalyticsSDK.GameAnalytics.GetRemoteConfigsValueAsString(key:  key, defaultValue:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetRemoteConfigsValueAsString(string key, string defaultValue)
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GetRemoteConfigsValueAsString(key:  key, defaultValue:  defaultValue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsRemoteConfigsReady()
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.IsRemoteConfigsReady();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetRemoteConfigsContentAsString()
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GetRemoteConfigsContentAsString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartTimer(string key)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.StartTimer(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PauseTimer(string key)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.PauseTimer(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ResumeTimer(string key)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.ResumeTimer(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long StopTimer(string key)
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.StopTimer(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string GetUnityVersion()
        {
            string val_9;
            System.Char[] val_10;
            var val_11;
            string val_12;
            int val_4 = 0;
            val_9 = "";
            char[] val_2 = new char[1];
            val_10 = val_2;
            val_10[0] = '.';
            val_11 = 0;
            goto label_4;
            label_19:
            if((System.Int32.TryParse(s:  UnityEngine.Application.unityVersion.Split(separator:  val_2)[0], result: out  val_4)) == false)
            {
                goto label_6;
            }
            
            val_12 = mem[val_3[0x0] + 32];
            val_12 = val_3[0x0] + 32;
            if(val_11 != 0)
            {
                goto label_8;
            }
            
            val_9 = val_12;
            goto label_16;
            label_6:
            val_10 = System.Text.RegularExpressions.Regex.Split(input:  val_3[0x0] + 32, pattern:  "[^\\d]+");
            if((val_6.Length == 0) || ((System.Int32.TryParse(s:  val_10[0], result: out  val_4)) == false))
            {
                goto label_16;
            }
            
            val_12 = val_10[0];
            label_8:
            val_9 = val_9 + "." + val_12;
            label_16:
            val_11 = 1;
            label_4:
            if(val_11 < val_3.Length)
            {
                goto label_19;
            }
            
            return (string)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int GetPlatformIndex()
        {
            System.Collections.Generic.List<UnityEngine.RuntimePlatform> val_11;
            var val_12;
            UnityEngine.RuntimePlatform val_13;
            System.Collections.Generic.List<UnityEngine.RuntimePlatform> val_14;
            var val_15;
            val_11 = UnityEngine.Application.platform;
            if((val_11 - 18) < 3)
            {
                    GameAnalyticsSDK.Setup.Settings val_3 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                val_11 = val_3.Platforms;
                val_12 = 1152921526114345616;
                val_13 = 20;
                return val_10.Platforms.IndexOf(item:  val_13 = val_11);
            }
            
            if(val_11 == 31)
            {
                goto label_5;
            }
            
            if(val_11 != 8)
            {
                goto label_6;
            }
            
            GameAnalyticsSDK.Setup.Settings val_4 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_11 = val_4.Platforms.Contains(item:  8);
            GameAnalyticsSDK.Setup.Settings val_6 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_14 = val_6.Platforms;
            val_15 = public System.Int32 System.Collections.Generic.List<UnityEngine.RuntimePlatform>::IndexOf(UnityEngine.RuntimePlatform item);
            if(val_11 == false)
            {
                goto label_11;
            }
            
            label_17:
            val_13 = 8;
            return val_10.Platforms.IndexOf(item:  val_13);
            label_5:
            GameAnalyticsSDK.Setup.Settings val_7 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_11 = val_7.Platforms.Contains(item:  31);
            GameAnalyticsSDK.Setup.Settings val_9 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_14 = val_9.Platforms;
            val_15 = public System.Int32 System.Collections.Generic.List<UnityEngine.RuntimePlatform>::IndexOf(UnityEngine.RuntimePlatform item);
            if(val_11 == false)
            {
                goto label_17;
            }
            
            label_11:
            val_13 = 31;
            return val_10.Platforms.IndexOf(item:  val_13);
            label_6:
            GameAnalyticsSDK.Setup.Settings val_10 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_12 = 1152921526114345616;
            return val_10.Platforms.IndexOf(item:  val_13);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetBuildAllPlatforms(string build)
        {
            goto label_1;
            label_6:
            GameAnalyticsSDK.Setup.Settings val_1 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            val_1.Build.set_Item(index:  0, value:  build);
            0 = 1;
            label_1:
            GameAnalyticsSDK.Setup.Settings val_2 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(0 < val_2.Build.Count)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameAnalytics()
        {
        
        }
    
    }

}
