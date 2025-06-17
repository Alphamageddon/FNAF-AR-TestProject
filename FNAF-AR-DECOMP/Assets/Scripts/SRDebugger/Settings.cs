using UnityEngine;

namespace SRDebugger
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Settings : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ResourcesPath = "/usr/Resources/SRDebugger";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ResourcesOverridePath = "SRDebuggerOverride";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ResourcesName = "Settings";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Settings _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _autoLoad;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.DefaultTabs _defaultTab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Settings.TriggerEnableModes _triggerEnableMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Settings.TriggerBehaviours _triggerBehaviour;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _enableKeyboardShortcuts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Settings.KeyboardShortcut[] _keyboardShortcuts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Settings.KeyboardShortcut[] _newKeyboardShortcuts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _keyboardModifierControl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _keyboardModifierAlt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _keyboardModifierShift;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _keyboardEscapeClose;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _enableBackgroundTransparency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _collapseDuplicateLogEntries;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _richTextInConsole;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _requireEntryCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _requireEntryCodeEveryTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] _entryCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useDebugCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _debugLayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _debugCameraDepth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _apiKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _enableBugReporter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.DefaultTabs[] _disabledTabs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.PinAlignment _profilerAlignment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.PinAlignment _optionsAlignment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.ConsoleAlignment _consoleAlignment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.PinAlignment _triggerPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _maximumConsoleEntries;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _enableEventSystemCreation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _automaticShowCursor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _uiScale;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Settings Instance { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEnabled { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AutoLoad { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.DefaultTabs DefaultTab { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Settings.TriggerEnableModes EnableTrigger { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Settings.TriggerBehaviours TriggerBehaviour { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableKeyboardShortcuts { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<SRDebugger.Settings.KeyboardShortcut> KeyboardShortcuts { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool KeyboardEscapeClose { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableBackgroundTransparency { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RequireCode { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RequireEntryCodeEveryTime { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<int> EntryCode { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseDebugCamera { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int DebugLayer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DebugCameraDepth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CollapseDuplicateLogEntries { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RichTextInConsole { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ApiKey { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableBugReporter { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<SRDebugger.DefaultTabs> DisabledTabs { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.PinAlignment TriggerPosition { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.PinAlignment ProfilerAlignment { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.PinAlignment OptionsAlignment { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.ConsoleAlignment ConsoleAlignment { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaximumConsoleEntries { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableEventSystemGeneration { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AutomaticallyShowCursor { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float UIScale { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.Settings get_Instance()
        {
            SRDebugger.Settings val_3;
            if(SRDebugger.Settings._instance == 0)
            {
                    SRDebugger.Settings._instance = SRDebugger.Settings.GetOrCreateInstance();
            }
            
            val_3 = SRDebugger.Settings._instance;
            if(val_2._keyboardShortcuts == null)
            {
                    return (SRDebugger.Settings)SRDebugger.Settings._instance;
            }
            
            val_3 = mem[val_2 + 56];
            val_3 = val_2._keyboardShortcuts;
            if(val_2._keyboardShortcuts.Length == 0)
            {
                    return (SRDebugger.Settings)SRDebugger.Settings._instance;
            }
            
            val_3 = SRDebugger.Settings._instance;
            val_3.UpgradeKeyboardShortcuts();
            return (SRDebugger.Settings)SRDebugger.Settings._instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Settings.KeyboardShortcut[] GetDefaultKeyboardShortcuts()
        {
            bool val_6;
            KeyboardShortcut[] val_1 = new KeyboardShortcut[4];
            val_6 = 1152921505144012800;
            Settings.KeyboardShortcut val_2 = new Settings.KeyboardShortcut();
            if(val_2 != null)
            {
                    .Control = true;
                .Shift = true;
                .Key = 282;
            }
            else
            {
                    .Control = true;
                .Shift = true;
                mem[24] = 282;
            }
            
            .Action = 1;
            val_1[0] = val_2;
            Settings.KeyboardShortcut val_3 = new Settings.KeyboardShortcut();
            if(val_3 == null)
            {
                goto label_6;
            }
            
            .Control = true;
            .Shift = true;
            .Key = 283;
            .Action = 2;
            if(val_3 != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_6:
            .Control = true;
            .Shift = true;
            mem[24] = 283;
            mem[16] = 2;
            label_8:
            val_1[1] = val_3;
            Settings.KeyboardShortcut val_4 = new Settings.KeyboardShortcut();
            if(val_4 == null)
            {
                goto label_10;
            }
            
            .Control = true;
            .Shift = true;
            .Key = 284;
            .Action = 3;
            if(val_4 != null)
            {
                goto label_12;
            }
            
            goto label_12;
            label_10:
            .Control = true;
            .Shift = true;
            mem[24] = 284;
            mem[16] = 3;
            label_12:
            val_1[2] = val_4;
            Settings.KeyboardShortcut val_5 = new Settings.KeyboardShortcut();
            if(val_5 == null)
            {
                goto label_14;
            }
            
            .Control = true;
            .Shift = true;
            .Key = 285;
            .Action = 4;
            if(val_5 != null)
            {
                goto label_16;
            }
            
            goto label_16;
            label_14:
            val_6 = true;
            .Control = val_6;
            .Shift = val_6;
            mem[24] = 285;
            mem[16] = 4;
            label_16:
            val_1[3] = val_5;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpgradeKeyboardShortcuts()
        {
            var val_5;
            bool val_6;
            UnityEngine.Debug.Log(message:  "[SRDebugger] Upgrading Settings format");
            System.Collections.Generic.List<KeyboardShortcut> val_1 = new System.Collections.Generic.List<KeyboardShortcut>();
            val_5 = 0;
            goto label_3;
            label_11:
            KeyboardShortcut val_5 = this._keyboardShortcuts[0];
            Settings.KeyboardShortcut val_2 = new Settings.KeyboardShortcut();
            if(val_2 != null)
            {
                    .Action = this._keyboardShortcuts[0x0][0].Action;
                .Key = this._keyboardShortcuts[0x0][0].Key;
                .Alt = this._keyboardModifierAlt;
                .Shift = this._keyboardModifierShift;
                val_6 = this._keyboardModifierControl;
            }
            else
            {
                    mem[16] = this._keyboardShortcuts[0x0][0].Action;
                mem[24] = this._keyboardShortcuts[0x0][0].Key;
                .Alt = this._keyboardModifierAlt;
                .Shift = this._keyboardModifierShift;
                val_6 = this._keyboardModifierControl;
            }
            
            .Control = val_6;
            val_1.Add(item:  val_2);
            val_5 = 1;
            label_3:
            if(val_5 < this._keyboardShortcuts.Length)
            {
                goto label_11;
            }
            
            this._keyboardShortcuts = new KeyboardShortcut[0];
            this._newKeyboardShortcuts = val_1.ToArray();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PropertyChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PropertyChanged != 1152921522926111800);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PropertyChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PropertyChanged != 1152921522926248376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsEnabled()
        {
            return (bool)this._isEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_AutoLoad()
        {
            return (bool)this._autoLoad;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.DefaultTabs get_DefaultTab()
        {
            return (SRDebugger.DefaultTabs)this._defaultTab;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Settings.TriggerEnableModes get_EnableTrigger()
        {
            return (TriggerEnableModes)this._triggerEnableMode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.Settings.TriggerBehaviours get_TriggerBehaviour()
        {
            return (TriggerBehaviours)this._triggerBehaviour;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EnableKeyboardShortcuts()
        {
            return (bool)this._enableKeyboardShortcuts;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<SRDebugger.Settings.KeyboardShortcut> get_KeyboardShortcuts()
        {
            return (System.Collections.Generic.IList<KeyboardShortcut>)this._newKeyboardShortcuts;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_KeyboardEscapeClose()
        {
            return (bool)this._keyboardEscapeClose;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EnableBackgroundTransparency()
        {
            return (bool)this._enableBackgroundTransparency;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_RequireCode()
        {
            return (bool)this._requireEntryCode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_RequireEntryCodeEveryTime()
        {
            return (bool)this._requireEntryCodeEveryTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<int> get_EntryCode()
        {
            return (System.Collections.Generic.IList<System.Int32>)new System.Collections.ObjectModel.ReadOnlyCollection<System.Int32>(list:  this._entryCode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EntryCode(System.Collections.Generic.IList<int> value)
        {
            var val_7;
            System.Func<System.Int32, System.Boolean> val_9;
            string val_11;
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(value.Count != 4)
            {
                goto label_6;
            }
            
            val_7 = null;
            val_7 = null;
            val_9 = Settings.<>c.<>9__39_0;
            if(val_9 == null)
            {
                    System.Func<System.Int32, System.Boolean> val_3 = null;
                val_9 = val_3;
                val_3 = new System.Func<System.Int32, System.Boolean>(object:  Settings.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Settings.<>c::<set_EntryCode>b__39_0(int p));
                Settings.<>c.<>9__39_0 = val_9;
            }
            
            if((System.Linq.Enumerable.Any<System.Int32>(source:  value, predicate:  val_3)) == true)
            {
                goto label_12;
            }
            
            this._entryCode = System.Linq.Enumerable.ToArray<System.Int32>(source:  value);
            return;
            label_6:
            val_11 = "Entry code must be length 4";
            goto label_13;
            label_12:
            val_11 = "All digits in entry code must be >= 0 and <= 9";
            label_13:
            null = new System.Exception(message:  val_11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_UseDebugCamera()
        {
            return (bool)this._useDebugCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_DebugLayer()
        {
            return (int)this._debugLayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_DebugCameraDepth()
        {
            return (float)this._debugCameraDepth;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_CollapseDuplicateLogEntries()
        {
            return (bool)this._collapseDuplicateLogEntries;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_RichTextInConsole()
        {
            return (bool)this._richTextInConsole;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ApiKey()
        {
            return (string)this._apiKey;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EnableBugReporter()
        {
            return (bool)this._enableBugReporter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<SRDebugger.DefaultTabs> get_DisabledTabs()
        {
            return (System.Collections.Generic.IList<SRDebugger.DefaultTabs>)this._disabledTabs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.PinAlignment get_TriggerPosition()
        {
            return (SRDebugger.PinAlignment)this._triggerPosition;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.PinAlignment get_ProfilerAlignment()
        {
            return (SRDebugger.PinAlignment)this._profilerAlignment;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.PinAlignment get_OptionsAlignment()
        {
            return (SRDebugger.PinAlignment)this._optionsAlignment;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.ConsoleAlignment get_ConsoleAlignment()
        {
            return (SRDebugger.ConsoleAlignment)this._consoleAlignment;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ConsoleAlignment(SRDebugger.ConsoleAlignment value)
        {
            this._consoleAlignment = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MaximumConsoleEntries()
        {
            return (int)this._maximumConsoleEntries;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaximumConsoleEntries(int value)
        {
            this._maximumConsoleEntries = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EnableEventSystemGeneration()
        {
            return (bool)this._enableEventSystemCreation;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EnableEventSystemGeneration(bool value)
        {
            this._enableEventSystemCreation = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_AutomaticallyShowCursor()
        {
            return (bool)this._automaticShowCursor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_UIScale()
        {
            return (float)this._uiScale;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_UIScale(float value)
        {
            if(this._uiScale == value)
            {
                    return;
            }
            
            this._uiScale = value;
            this.OnPropertyChanged(propertyName:  "UIScale");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPropertyChanged(string propertyName)
        {
            if(this.PropertyChanged == null)
            {
                    return;
            }
            
            this.PropertyChanged.Invoke(sender:  this, e:  new System.ComponentModel.PropertyChangedEventArgs(propertyName:  propertyName));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.Settings GetOrCreateInstance()
        {
            SRDebugger.Settings val_6 = UnityEngine.Resources.Load<SRDebugger.Settings>(path:  System.IO.Path.Combine(path1:  "SRDebuggerOverride", path2:  "Settings"));
            if(val_6 != 0)
            {
                    return (SRDebugger.Settings)val_6;
            }
            
            val_6 = UnityEngine.Resources.Load<SRDebugger.Settings>(path:  "SRDebugger/Settings");
            if(val_6 != 0)
            {
                    return (SRDebugger.Settings)val_6;
            }
            
            return UnityEngine.ScriptableObject.CreateInstance<SRDebugger.Settings>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Settings()
        {
            this._isEnabled = true;
            this._autoLoad = true;
            this._enableKeyboardShortcuts = true;
            this._newKeyboardShortcuts = SRDebugger.Settings.GetDefaultKeyboardShortcuts();
            this._keyboardModifierControl = true;
            this._richTextInConsole = true;
            this._keyboardModifierShift = true;
            this._keyboardEscapeClose = true;
            this._enableBackgroundTransparency = true;
            this._collapseDuplicateLogEntries = true;
            this._entryCode = new int[4];
            this._debugLayer = 5;
            this._debugCameraDepth = 100f;
            this._apiKey = "";
            this._enableEventSystemCreation = true;
            this._automaticShowCursor = true;
            this._disabledTabs = new SRDebugger.DefaultTabs[0];
            this._profilerAlignment = 3;
            this._maximumConsoleEntries = 1500;
            this._uiScale = 1f;
        }
    
    }

}
