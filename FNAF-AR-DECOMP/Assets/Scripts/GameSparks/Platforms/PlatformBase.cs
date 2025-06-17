using UnityEngine;

namespace GameSparks.Platforms
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class PlatformBase : MonoBehaviour, IGSPlatform
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string PLAYER_PREF_AUTHTOKEN_KEY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string PLAYER_PREF_USERID_KEY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string PLAYER_PREF_DEVICEID_KEY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Action> _actions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Action> _currentActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _allowQuitting;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <DeviceName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <DeviceType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSData <DeviceStats>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <DeviceId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Platform>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <ExtraDebug>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <PersistentDataPath>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string m_authToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string m_userId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Exception> <ExceptionReporter>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceOS { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameSparks.Core.GSData DeviceStats { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string DeviceId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Platform { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ExtraDebug { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ApiKey { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ApiSecret { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ApiCredential { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ApiStage { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ApiDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PersistentDataPath { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SDK { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AuthToken { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<System.Exception> ExceptionReporter { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Start()
        {
            var val_96;
            var val_97;
            var val_98;
            string val_99;
            var val_100;
            object val_101;
            object val_102;
            int val_103;
            string val_104;
            object val_105;
            string val_106;
            string val_107;
            string val_108;
            var val_109;
            var val_110;
            System.String[] val_111;
            string val_112;
            string val_113;
            var val_114;
            System.Action<System.Exception> val_115;
            int val_116;
            int val_117;
            this.<DeviceName>k__BackingField = UnityEngine.SystemInfo.deviceName;
            UnityEngine.DeviceType val_2 = UnityEngine.SystemInfo.deviceType;
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_2});
            this.<DeviceType>k__BackingField = val_2.ToString();
            val_96 = null;
            val_96 = null;
            this.<DeviceId>k__BackingField = UnityEngine.PlayerPrefs.GetString(key:  GameSparks.Platforms.PlatformBase.PLAYER_PREF_DEVICEID_KEY);
            val_97 = "";
            if((this.Equals(value:  "")) != false)
            {
                    System.Guid val_7 = System.Guid.NewGuid();
                this.<DeviceId>k__BackingField = val_7._a;
                val_98 = null;
                val_98 = null;
                UnityEngine.PlayerPrefs.SetString(key:  GameSparks.Platforms.PlatformBase.PLAYER_PREF_DEVICEID_KEY, value:  this);
                UnityEngine.PlayerPrefs.Save();
            }
            
            char[] val_8 = new char[8];
            string val_10 = UnityEngine.SystemInfo.deviceModel;
            string val_12 = UnityEngine.SystemInfo.systemMemorySize + " MB";
            string val_13 = UnityEngine.SystemInfo.operatingSystem;
            val_99 = UnityEngine.SystemInfo.operatingSystem;
            string val_15 = UnityEngine.SystemInfo.processorType;
            string val_18 = UnityEngine.Screen.width + "x" + UnityEngine.Screen.height;
            string val_19 = GameSparks.Core.GS.Version;
            string val_20 = UnityEngine.Application.unityVersion;
            string val_21 = val_20.DeviceOS;
            uint val_22 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_21);
            if(val_22 > (-1597045268))
            {
                goto label_13;
            }
            
            if(val_22 > 1874269580)
            {
                goto label_14;
            }
            
            if(val_22 == 63313862)
            {
                goto label_15;
            }
            
            if(val_22 == 920978609)
            {
                goto label_16;
            }
            
            if(val_22 != 1874269580)
            {
                goto label_111;
            }
            
            val_100 = 1152921505134800896;
            if((System.String.op_Equality(a:  val_21, b:  "ANDROID")) == false)
            {
                goto label_55;
            }
            
            val_101 = val_20;
            val_102 = val_19;
            string val_96 = UnityEngine.SystemInfo.deviceModel.Split(separator:  val_8)[0];
            string val_28 = UnityEngine.SystemInfo.deviceModel.Replace(oldValue:  val_96, newValue:  "").Substring(startIndex:  1);
            System.String[] val_30 = UnityEngine.SystemInfo.operatingSystem.Split(separator:  val_8);
            val_103 = val_30.Length;
            if(val_103 == 0)
            {
                    val_103 = val_30.Length;
            }
            
            val_97 = val_96;
            string val_31 = val_30[0] + " " + val_30[1];
            val_99 = val_30[7];
            object[] val_32 = new object[4];
            val_32[0] = val_15;
            val_32[1] = " ";
            val_32[2] = UnityEngine.SystemInfo.processorFrequency;
            val_32[3] = "MHz";
            val_104 = +val_32;
            val_105 = val_97;
            goto label_209;
            label_13:
            if(val_22 > (-828500631))
            {
                goto label_43;
            }
            
            if(val_22 == (-1073395550))
            {
                goto label_44;
            }
            
            val_100 = 1152921505134800896;
            if(val_22 == (-981489829))
            {
                goto label_45;
            }
            
            val_101 = val_20;
            if(val_22 != (-828500631))
            {
                goto label_94;
            }
            
            val_106 = val_21;
            bool val_35 = System.String.op_Equality(a:  val_106, b:  "TVOS");
            goto label_47;
            label_14:
            if(val_22 == (-1597045268))
            {
                goto label_48;
            }
            
            if(val_22 == 2062687802)
            {
                goto label_49;
            }
            
            val_100 = 1152921505134800896;
            if(val_22 != 2077565087)
            {
                goto label_55;
            }
            
            var val_37 = ((System.String.op_Equality(a:  val_21, b:  "TIZEN")) != true) ? "Tizen" : "Unknown";
            goto label_51;
            label_43:
            if(val_22 == (-772521206))
            {
                goto label_52;
            }
            
            if(val_22 == (-489135478))
            {
                goto label_53;
            }
            
            if(val_22 != (-97632736))
            {
                goto label_111;
            }
            
            val_97 = "PS4";
            val_100 = 1152921505134800896;
            if((System.String.op_Equality(a:  val_21, b:  "PS4")) == false)
            {
                goto label_55;
            }
            
            int val_39 = UnityEngine.SystemInfo.systemMemorySize;
            string val_40 = 0 + " MB";
            val_101 = val_20;
            System.String[] val_42 = UnityEngine.SystemInfo.operatingSystem.Split(separator:  val_8);
            val_102 = val_19;
            string val_99 = val_42[0];
            string[] val_43 = new string[5];
            val_43[0] = val_42[1];
            val_97 = ".";
            val_43[1] = ".";
            val_43[2] = val_42[2];
            val_43[3] = ".";
            val_43[4] = val_42[3];
            val_99 = +val_43;
            object[] val_45 = new object[4];
            val_45[0] = val_15;
            val_45[1] = " ";
            val_45[2] = UnityEngine.SystemInfo.processorFrequency;
            val_45[3] = "MHz";
            val_105 = "Sony";
            val_104 = +val_45;
            goto label_209;
            label_16:
            if((System.String.op_Equality(a:  val_21, b:  "SWITCH")) == false)
            {
                goto label_111;
            }
            
            val_99 = "Unknown";
            val_105 = "Nintendo";
            val_100 = 1152921505134800896;
            label_51:
            val_101 = val_20;
            goto label_93;
            label_45:
            val_101 = val_20;
            if((System.String.op_Equality(a:  val_21, b:  "WIIU")) == false)
            {
                goto label_94;
            }
            
            val_105 = "Nintendo";
            label_93:
            val_102 = val_19;
            goto label_211;
            label_49:
            val_107 = "WSA";
            goto label_97;
            label_53:
            val_107 = "WINDOWS";
            goto label_97;
            label_15:
            val_108 = "IOS";
            goto label_98;
            label_44:
            val_108 = "MACOS";
            label_98:
            val_106 = val_21;
            val_100 = 1152921505134800896;
            val_101 = val_20;
            label_47:
            val_102 = val_19;
            if((System.String.op_Equality(a:  val_106, b:  val_108)) == false)
            {
                goto label_99;
            }
            
            System.String[] val_52 = UnityEngine.SystemInfo.operatingSystem.Split(separator:  val_8);
            val_109 = val_52;
            if((val_52.DeviceOS.Equals(value:  "MACOS")) == false)
            {
                goto label_102;
            }
            
            val_110 = 1152921505343581488;
            val_111 = new string[5];
            val_112 = val_109[0];
            if(val_111 != null)
            {
                goto label_120;
            }
            
            goto label_106;
            label_48:
            val_107 = "XBOXONE";
            label_97:
            bool val_56 = System.String.op_Equality(a:  val_21, b:  val_107);
            if(val_56 == false)
            {
                goto label_111;
            }
            
            if((val_56.DeviceOS.Equals(value:  "XBOXONE")) == false)
            {
                goto label_109;
            }
            
            int val_59 = UnityEngine.SystemInfo.systemMemorySize;
            string val_60 = 0 + " MB";
            val_113 = val_15;
            goto label_110;
            label_52:
            if((System.String.op_Equality(a:  val_21, b:  "WEBGL")) == false)
            {
                goto label_111;
            }
            
            val_100 = 1152921505134800896;
            val_101 = val_20;
            val_102 = val_19;
            val_109 = UnityEngine.SystemInfo.operatingSystem.Split(separator:  val_8);
            string val_104 = val_109[0];
            if((val_104.Equals(value:  "Mac")) == false)
            {
                goto label_119;
            }
            
            val_110 = 1152921505343581488;
            val_112 = val_104;
            string[] val_67 = new string[5];
            val_111 = val_67;
            if(val_111 != null)
            {
                goto label_120;
            }
            
            label_106:
            label_120:
            val_111[0] = val_112;
            val_111[1] = " ";
            val_111[2] = val_109[1];
            val_111[3] = " ";
            val_104 = val_15;
            val_111[4] = val_109[2];
            string[] val_69 = new string[5];
            val_69[0] = val_109[3];
            val_97 = ".";
            val_69[1] = ".";
            val_69[2] = val_109[4];
            val_69[3] = ".";
            val_105 = "Microsoft";
            val_69[4] = val_109[5];
            val_99 = +val_69;
            goto label_209;
            label_111:
            val_100 = 1152921505134800896;
            label_55:
            val_101 = val_20;
            label_94:
            val_102 = val_19;
            label_99:
            val_105 = "Microsoft";
            label_211:
            val_104 = val_15;
            label_209:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_71 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_71 != null)
            {
                    val_71.Add(key:  "manufacturer", value:  val_105);
            }
            else
            {
                    val_71.Add(key:  "manufacturer", value:  val_105);
            }
            
            val_71.Add(key:  "model", value:  UnityEngine.SystemInfo.deviceModel.Split(separator:  val_8)[0]);
            if(val_71 != null)
            {
                    val_71.Add(key:  "memory", value:  val_60);
            }
            else
            {
                    val_71.Add(key:  "memory", value:  val_60);
            }
            
            val_71.Add(key:  "os.name", value:  +val_67);
            val_71.Add(key:  "os.version", value:  val_99);
            string val_72 = UnityEngine.SystemInfo.processorCount.ToString();
            if(val_71 != null)
            {
                    val_71.Add(key:  "cpu.cores", value:  val_72);
            }
            else
            {
                    val_71.Add(key:  "cpu.cores", value:  val_72);
            }
            
            val_71.Add(key:  "cpu.vendor", value:  val_104);
            if(val_71 != null)
            {
                    val_71.Add(key:  "resolution", value:  val_18);
            }
            else
            {
                    val_71.Add(key:  "resolution", value:  val_18);
            }
            
            val_71.Add(key:  "gssdk", value:  val_102);
            if(val_71 != null)
            {
                    val_71.Add(key:  "engine", value:  "Unity");
            }
            else
            {
                    val_71.Add(key:  "engine", value:  "Unity");
            }
            
            val_71.Add(key:  "engine.version", value:  val_101);
            this.<DeviceStats>k__BackingField = new GameSparks.Core.GSData(data:  val_71);
            val_114 = null;
            this.AuthToken = UnityEngine.PlayerPrefs.GetString(key:  GameSparks.Platforms.PlatformBase.PLAYER_PREF_AUTHTOKEN_KEY);
            this.UserId = UnityEngine.PlayerPrefs.GetString(key:  GameSparks.Platforms.PlatformBase.PLAYER_PREF_USERID_KEY);
            UnityEngine.RuntimePlatform val_76 = UnityEngine.Application.platform;
            long val_78 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_76});
            this.<Platform>k__BackingField = val_76.ToString();
            GameSparksUnity val_79 = this.GetComponent<GameSparksUnity>();
            GameSparksSettings.SetInstance(settings:  val_79.settings);
            this.<ExtraDebug>k__BackingField = GameSparksSettings.DebugBuild;
            this.<PersistentDataPath>k__BackingField = UnityEngine.Application.persistentDataPath;
            GameSparks.Core.GS.Initialise(gSPlatform:  this);
            UnityEngine.Object.DontDestroyOnLoad(target:  this);
            if(((System.Delegate.Combine(a:  this.<ExceptionReporter>k__BackingField, b:  new System.Action<System.Exception>(object:  0, method:  public static System.Void UnityEngine.Debug::LogException(System.Exception exception)))) != null) && (null != null))
            {
                    val_115 = 0;
            }
            
            this.<ExceptionReporter>k__BackingField = val_115;
            return;
            label_109:
            System.String[] val_86 = UnityEngine.SystemInfo.operatingSystem.Split(separator:  val_8, options:  1);
            val_116 = val_86.Length;
            if(val_116 == 0)
            {
                    val_116 = val_86.Length;
            }
            
            string val_87 = val_86[0] + " " + val_86[1];
            string[] val_88 = new string[5];
            val_113 = val_15;
            val_88[0] = val_86[2];
            val_88[1] = ".";
            val_88[2] = val_86[3];
            val_88[3] = ".";
            val_88[4] = val_86[4];
            string val_89 = +val_88;
            label_110:
            string val_94 = new System.Text.RegularExpressions.Regex(pattern:  "[ ]{2,}", options:  0).Replace(input:  val_113 + " " + UnityEngine.SystemInfo.processorFrequency.ToString() + "MHz", replacement:  " ");
            goto label_209;
            label_102:
            val_117 = val_52.Length;
            if(val_117 == 0)
            {
                    val_117 = val_52.Length;
            }
            
            string val_115 = val_109[0];
            if(val_117 <= 1)
            {
                    val_117 = val_52.Length;
            }
            
            string val_95 = val_109[1] + "." + val_109[2];
            goto label_209;
            label_119:
            string val_118 = val_109[1];
            goto label_211;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ExecuteOnMainThread(System.Action action)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._actions, lockTaken: ref  val_1);
            this._actions.Add(item:  action);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._actions);
            }
            
            if(41 == 41)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Update()
        {
            var val_5;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._actions, lockTaken: ref  val_1);
            if(this._actions.Count >= 1)
            {
                    this._currentActions.AddRange(collection:  this._actions);
                this._actions.Clear();
            }
            
            val_5 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._actions);
            }
            
            int val_3 = this._currentActions.Count;
            if(val_3 < 1)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_12;
            label_21:
            System.Action val_4 = 71.Item[0];
            if(val_4 != null)
            {
                    val_4.Invoke();
            }
            
            val_5 = 1;
            label_12:
            if(val_5 < val_3)
            {
                goto label_21;
            }
            
            this._currentActions.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnApplicationPause(bool paused)
        {
            if(paused == true)
            {
                    return;
            }
            
            GameSparks.Core.GS.Reconnect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnApplicationQuit()
        {
            GameSparks.Core.GS.ShutDown();
            UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "DelayedQuit");
            if(this._allowQuitting != false)
            {
                    return;
            }
            
            UnityEngine.Application.CancelQuit();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator DelayedQuit()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PlatformBase.<DelayedQuit>d__11();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_DeviceOS()
        {
            var val_2;
            if(UnityEngine.Application.platform <= 31)
            {
                    val_2 = mem[66464960 + (val_1) << 3];
                val_2 = 66464960 + (val_1) << 3;
                return (string)val_2;
            }
            
            val_2 = "UNKNOWN";
            return (string)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_DeviceName()
        {
            return (string)this.<DeviceName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DeviceName(string value)
        {
            this.<DeviceName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_DeviceType()
        {
            return (string)this.<DeviceType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DeviceType(string value)
        {
            this.<DeviceType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameSparks.Core.GSData get_DeviceStats()
        {
            return (GameSparks.Core.GSData)this.<DeviceStats>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DeviceStats(GameSparks.Core.GSData value)
        {
            this.<DeviceStats>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual string get_DeviceId()
        {
            return (string)this.<DeviceId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DeviceId(string value)
        {
            this.<DeviceId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Platform()
        {
            return (string)this.<Platform>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Platform(string value)
        {
            this.<Platform>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ExtraDebug()
        {
            return (bool)this.<ExtraDebug>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ExtraDebug(bool value)
        {
            this.<ExtraDebug>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ApiKey()
        {
            return GameSparksSettings.ApiKey;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ApiSecret()
        {
            return GameSparksSettings.ApiSecret;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ApiCredential()
        {
            return GameSparksSettings.Credential;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ApiStage()
        {
            return (string)(GameSparksSettings.PreviewBuild != true) ? "preview" : "live";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ApiDomain()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_PersistentDataPath()
        {
            return (string)this.<PersistentDataPath>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_PersistentDataPath(string value)
        {
            this.<PersistentDataPath>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DebugMsg(string message)
        {
            .message = message;
            this.ExecuteOnMainThread(action:  new System.Action(object:  new PlatformBase.<>c__DisplayClass52_0(), method:  System.Void PlatformBase.<>c__DisplayClass52_0::<DebugMsg>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_SDK()
        {
            return "Unity";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_AuthToken()
        {
            return (string)this.m_authToken;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AuthToken(string value)
        {
            var val_1;
            this.m_authToken = value;
            val_1 = null;
            val_1 = null;
            UnityEngine.PlayerPrefs.SetString(key:  GameSparks.Platforms.PlatformBase.PLAYER_PREF_AUTHTOKEN_KEY, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_UserId()
        {
            return (string)this.m_userId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_UserId(string value)
        {
            var val_1;
            this.m_userId = value;
            val_1 = null;
            val_1 = null;
            UnityEngine.PlayerPrefs.SetString(key:  GameSparks.Platforms.PlatformBase.PLAYER_PREF_USERID_KEY, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<System.Exception> get_ExceptionReporter()
        {
            return (System.Action<System.Exception>)this.<ExceptionReporter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ExceptionReporter(System.Action<System.Exception> value)
        {
            this.<ExceptionReporter>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract GameSparks.IGameSparksTimer GetTimer(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string MakeHmac(string stringToHmac, string secret); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract GameSparks.IGameSparksWebSocket GetSocket(string url, System.Action<string> messageReceived, System.Action closed, System.Action opened, System.Action<string> error); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected PlatformBase()
        {
            this._actions = new System.Collections.Generic.List<System.Action>();
            this._currentActions = new System.Collections.Generic.List<System.Action>();
            this.m_authToken = "0";
            this.m_userId = "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlatformBase()
        {
            GameSparks.Platforms.PlatformBase.PLAYER_PREF_AUTHTOKEN_KEY = "gamesparks.authtoken";
            GameSparks.Platforms.PlatformBase.PLAYER_PREF_USERID_KEY = "gamesparks.userid";
            GameSparks.Platforms.PlatformBase.PLAYER_PREF_DEVICEID_KEY = "gamesparks.deviceid";
        }
    
    }

}
