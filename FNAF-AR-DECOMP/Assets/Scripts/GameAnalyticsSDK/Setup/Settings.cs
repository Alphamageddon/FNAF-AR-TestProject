using UnityEngine;

namespace GameAnalyticsSDK.Setup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Settings : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string VERSION;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CheckingForUpdates;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TotalMessagesSubmitted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TotalMessagesFailed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int DesignMessagesSubmitted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int DesignMessagesFailed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int QualityMessagesSubmitted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int QualityMessagesFailed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ErrorMessagesSubmitted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ErrorMessagesFailed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BusinessMessagesSubmitted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BusinessMessagesFailed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int UserMessagesSubmitted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int UserMessagesFailed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CustomArea;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> gameKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> secretKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Build;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> SelectedPlatformStudio;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> SelectedPlatformGame;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> SelectedPlatformGameID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> SelectedStudio;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> SelectedGame;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string NewVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Changes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SignUpOpen;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StudioName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GameName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EmailGA;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PasswordGA;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TokenGA;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ExpireTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LoginStatus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool JustSignedUp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HideSignupWarning;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IntroScreen;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameAnalyticsSDK.Setup.Studio> Studios;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool InfoLogEditor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool InfoLogBuild;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool VerboseLogBuild;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseManualSessionHandling;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SendExampleGameDataToMyGame;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseIMEI;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool InternetConnectivity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> CustomDimensions01;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> CustomDimensions02;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> CustomDimensions03;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> ResourceItemTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> ResourceCurrencies;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RuntimePlatform LastCreatedGamePlatform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.RuntimePlatform> Platforms;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameAnalyticsSDK.Setup.Settings.InspectorStates CurrentInspectorState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameAnalyticsSDK.Setup.Settings.HelpTypes> ClosedHints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DisplayHints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 DisplayHintsScrollState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D Logo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D UpdateIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D InfoIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D DeleteIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D GameIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D HomeIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D InstrumentIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D QuestionIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D UserIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D AmazonIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D GooglePlayIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D iosIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D macIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D windowsPhoneIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GUIStyle SignupButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UsePlayerSettingsBuildNumber;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SubmitErrors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxErrorCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SubmitFpsAverage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SubmitFpsCritical;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IncludeGooglePlay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int FpsCriticalThreshold;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int FpsCirticalSubmitInterval;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<bool> PlatformFoldOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CustomDimensions01FoldOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CustomDimensions02FoldOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CustomDimensions03FoldOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ResourceItemTypesFoldOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ResourceCurrenciesFoldOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly UnityEngine.RuntimePlatform[] AvailablePlatforms;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCustomUserID(string customID)
        {
            bool val_1 = System.String.op_Inequality(a:  customID, b:  System.String.alignConst);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemovePlatformAtIndex(int index)
        {
            System.Collections.Generic.List<UnityEngine.RuntimePlatform> val_2;
            if((index & 2147483648) != 0)
            {
                    return;
            }
            
            val_2 = this.Platforms;
            if(val_2.Count <= index)
            {
                    return;
            }
            
            this.gameKey.RemoveAt(index:  index);
            this.secretKey.RemoveAt(index:  index);
            this.Build.RemoveAt(index:  index);
            this.SelectedPlatformStudio.RemoveAt(index:  index);
            this.SelectedPlatformGame.RemoveAt(index:  index);
            this.SelectedPlatformGameID.RemoveAt(index:  index);
            this.SelectedStudio.RemoveAt(index:  index);
            this.SelectedGame.RemoveAt(index:  index);
            this.PlatformFoldOut.RemoveAt(index:  index);
            this.Platforms.RemoveAt(index:  index);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddPlatform(UnityEngine.RuntimePlatform platform)
        {
            this.gameKey.Add(item:  "");
            this.secretKey.Add(item:  "");
            this.Build.Add(item:  "0.1");
            this.SelectedPlatformStudio.Add(item:  "");
            this.SelectedPlatformGame.Add(item:  "");
            this.SelectedPlatformGameID.Add(item:  0);
            this.SelectedStudio.Add(item:  0);
            this.SelectedGame.Add(item:  0);
            this.PlatformFoldOut.Add(item:  true);
            this.Platforms.Add(item:  platform);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] GetAvailablePlatforms()
        {
            var val_9;
            var val_10;
            System.Collections.Generic.List<UnityEngine.RuntimePlatform> val_11;
            var val_12;
            UnityEngine.RuntimePlatform val_13;
            var val_14;
            string val_15;
            var val_16;
            var val_17;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_9 = 0;
            goto label_1;
            label_28:
            val_10 = null;
            val_10 = null;
            if((GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32) == 31)
            {
                goto label_6;
            }
            
            if((GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32) != 8)
            {
                goto label_7;
            }
            
            val_11 = this.Platforms;
            val_12 = public System.Boolean System.Collections.Generic.List<UnityEngine.RuntimePlatform>::Contains(UnityEngine.RuntimePlatform item);
            val_13 = 31;
            goto label_9;
            label_6:
            val_11 = this.Platforms;
            val_12 = public System.Boolean System.Collections.Generic.List<UnityEngine.RuntimePlatform>::Contains(UnityEngine.RuntimePlatform item);
            val_13 = 8;
            label_9:
            if((val_11.Contains(item:  val_13)) != true)
            {
                    if((this.Platforms.Contains(item:  GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32)) == false)
            {
                goto label_13;
            }
            
            }
            
            val_14 = this.Platforms;
            goto label_17;
            label_7:
            val_14 = this.Platforms;
            if((GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32) != 20)
            {
                goto label_17;
            }
            
            if((val_14.Contains(item:  GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32)) == true)
            {
                goto label_21;
            }
            
            val_15 = "WSA";
            val_16 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            goto label_20;
            label_17:
            if((val_14.Contains(item:  GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32)) == true)
            {
                goto label_21;
            }
            
            label_13:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32});
            val_16 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            val_15 = GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length + 32.ToString();
            label_20:
            val_1.Add(item:  val_15);
            label_21:
            val_9 = 1;
            label_1:
            val_17 = null;
            val_17 = null;
            if(val_9 < GameAnalyticsSDK.Setup.Settings.AvailablePlatforms.Length)
            {
                goto label_28;
            }
            
            return (System.String[])val_1.ToArray();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsGameKeyValid(int index, string value)
        {
            var val_4;
            string val_5;
            var val_6;
            val_4 = 0;
            goto label_1;
            label_7:
            if(index == val_4)
            {
                goto label_2;
            }
            
            val_5 = this.gameKey.Item[0];
            if((value.Equals(value:  val_5)) == true)
            {
                goto label_5;
            }
            
            label_2:
            val_4 = 1;
            label_1:
            val_5 = this.Platforms;
            if(val_4 < val_5.Count)
            {
                goto label_7;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_5:
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsSecretKeyValid(int index, string value)
        {
            var val_4;
            string val_5;
            var val_6;
            val_4 = 0;
            goto label_1;
            label_7:
            if(index == val_4)
            {
                goto label_2;
            }
            
            val_5 = this.secretKey.Item[0];
            if((value.Equals(value:  val_5)) == true)
            {
                goto label_5;
            }
            
            label_2:
            val_4 = 1;
            label_1:
            val_5 = this.Platforms;
            if(val_4 < val_5.Count)
            {
                goto label_7;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_5:
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateGameKey(int index, string value)
        {
            System.Collections.Generic.List<System.String> val_5;
            var val_6;
            val_5 = this;
            if((System.String.IsNullOrEmpty(value:  value)) == false)
            {
                goto label_1;
            }
            
            val_5 = this.gameKey;
            val_6 = 1152921523173587056;
            goto label_3;
            label_1:
            bool val_2 = this.IsGameKeyValid(index:  index, value:  value);
            if(this.gameKey == null)
            {
                goto label_4;
            }
            
            if(val_2 == false)
            {
                goto label_5;
            }
            
            label_6:
            val_6 = 1152921523173587056;
            label_3:
            label_10:
            this.gameKey.set_Item(index:  index, value:  value);
            return;
            label_4:
            if(val_2 == true)
            {
                goto label_6;
            }
            
            label_5:
            if((this.gameKey.Item[index].Equals(value:  value)) == false)
            {
                    return;
            }
            
            if(this.gameKey != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateSecretKey(int index, string value)
        {
            System.Collections.Generic.List<System.String> val_5;
            var val_6;
            val_5 = this;
            if((System.String.IsNullOrEmpty(value:  value)) == false)
            {
                goto label_1;
            }
            
            val_5 = this.secretKey;
            val_6 = 1152921523173587056;
            goto label_3;
            label_1:
            bool val_2 = this.IsSecretKeyValid(index:  index, value:  value);
            if(this.secretKey == null)
            {
                goto label_4;
            }
            
            if(val_2 == false)
            {
                goto label_5;
            }
            
            label_6:
            val_6 = 1152921523173587056;
            label_3:
            label_10:
            this.secretKey.set_Item(index:  index, value:  value);
            return;
            label_4:
            if(val_2 == true)
            {
                goto label_6;
            }
            
            label_5:
            if((this.secretKey.Item[index].Equals(value:  value)) == false)
            {
                    return;
            }
            
            if(this.secretKey != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetGameKey(int index)
        {
            if(this.gameKey != null)
            {
                    return this.gameKey.Item[index];
            }
            
            return this.gameKey.Item[index];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetSecretKey(int index)
        {
            if(this.secretKey != null)
            {
                    return this.secretKey.Item[index];
            }
            
            return this.secretKey.Item[index];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCustomArea(string customArea)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetKeys(string gamekey, string secretkey)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Settings()
        {
            this.CustomArea = System.String.alignConst;
            this.gameKey = new System.Collections.Generic.List<System.String>();
            this.secretKey = new System.Collections.Generic.List<System.String>();
            this.Build = new System.Collections.Generic.List<System.String>();
            this.SelectedPlatformStudio = new System.Collections.Generic.List<System.String>();
            this.SelectedPlatformGame = new System.Collections.Generic.List<System.String>();
            this.SelectedPlatformGameID = new System.Collections.Generic.List<System.Int32>();
            this.SelectedStudio = new System.Collections.Generic.List<System.Int32>();
            this.SelectedGame = new System.Collections.Generic.List<System.Int32>();
            this.NewVersion = "";
            this.Changes = "";
            this.StudioName = "";
            this.GameName = "";
            this.EmailGA = "";
            this.PasswordGA = "";
            this.TokenGA = "";
            this.ExpireTime = "";
            this.SignUpOpen = true;
            this.IntroScreen = true;
            this.InfoLogEditor = true;
            this.InfoLogBuild = true;
            this.LoginStatus = "Not logged in.";
            this.CustomDimensions01 = new System.Collections.Generic.List<System.String>();
            this.CustomDimensions02 = new System.Collections.Generic.List<System.String>();
            this.CustomDimensions03 = new System.Collections.Generic.List<System.String>();
            this.ResourceItemTypes = new System.Collections.Generic.List<System.String>();
            this.ResourceCurrencies = new System.Collections.Generic.List<System.String>();
            this.Platforms = new System.Collections.Generic.List<UnityEngine.RuntimePlatform>();
            this.ClosedHints = new System.Collections.Generic.List<HelpTypes>();
            this.SubmitErrors = true;
            this.SubmitFpsAverage = true;
            this.SubmitFpsCritical = true;
            this.IncludeGooglePlay = true;
            this.FpsCirticalSubmitInterval = true;
            this.MaxErrorCount = 10;
            this.FpsCriticalThreshold = 20;
            this.PlatformFoldOut = new System.Collections.Generic.List<System.Boolean>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Settings()
        {
            GameAnalyticsSDK.Setup.Settings.VERSION = "6.0.9";
            GameAnalyticsSDK.Setup.Settings.CheckingForUpdates = false;
            GameAnalyticsSDK.Setup.Settings.AvailablePlatforms = new UnityEngine.RuntimePlatform[8];
        }
    
    }

}
