using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using UnityEngine;

namespace SRDebugger
{
	public class Settings : ScriptableObject
	{
		public enum ShortcutActions
		{
			None = 0,
			OpenSystemInfoTab = 1,
			OpenConsoleTab = 2,
			OpenOptionsTab = 3,
			OpenProfilerTab = 4,
			OpenBugReporterTab = 5,
			ClosePanel = 6,
			OpenPanel = 7,
			TogglePanel = 8,
			ShowBugReportPopover = 9,
			ToggleDockedConsole = 10,
			ToggleDockedProfiler = 11
		}

		public enum TriggerBehaviours
		{
			TripleTap = 0,
			TapAndHold = 1,
			DoubleTap = 2
		}

		public enum TriggerEnableModes
		{
			Enabled = 0,
			MobileOnly = 1,
			Off = 2,
			DevelopmentBuildsOnly = 3
		}

		[Serializable]
		public sealed class KeyboardShortcut
		{
			[SerializeField]
			public ShortcutActions Action;

			[SerializeField]
			public bool Alt;

			[SerializeField]
			public bool Control;

			[SerializeField]
			public KeyCode Key;

			[SerializeField]
			public bool Shift;
		}

		private const string ResourcesPath = "/usr/Resources/SRDebugger";

		private const string ResourcesName = "Settings";

		private static Settings _instance;

		[SerializeField]
		private bool _isEnabled = true;

		[SerializeField]
		private bool _autoLoad = true;

		[SerializeField]
		private DefaultTabs _defaultTab;

		[SerializeField]
		private TriggerEnableModes _triggerEnableMode;

		[SerializeField]
		private TriggerBehaviours _triggerBehaviour;

		[SerializeField]
		private bool _enableKeyboardShortcuts = true;

		[SerializeField]
		private KeyboardShortcut[] _keyboardShortcuts;

		[SerializeField]
		private KeyboardShortcut[] _newKeyboardShortcuts = GetDefaultKeyboardShortcuts();

		[SerializeField]
		private bool _keyboardModifierControl = true;

		[SerializeField]
		private bool _keyboardModifierAlt;

		[SerializeField]
		private bool _keyboardModifierShift = true;

		[SerializeField]
		private bool _keyboardEscapeClose = true;

		[SerializeField]
		private bool _enableBackgroundTransparency = true;

		[SerializeField]
		private bool _collapseDuplicateLogEntries = true;

		[SerializeField]
		private bool _richTextInConsole = true;

		[SerializeField]
		private bool _requireEntryCode;

		[SerializeField]
		private bool _requireEntryCodeEveryTime;

		[SerializeField]
		private int[] _entryCode = new int[4];

		[SerializeField]
		private bool _useDebugCamera;

		[SerializeField]
		private int _debugLayer = 5;

		[SerializeField]
		[Range(-100f, 100f)]
		private float _debugCameraDepth = 100f;

		[SerializeField]
		private string _apiKey = "";

		[SerializeField]
		private bool _enableBugReporter;

		[SerializeField]
		private DefaultTabs[] _disabledTabs = new DefaultTabs[0];

		[SerializeField]
		private PinAlignment _profilerAlignment = PinAlignment.BottomLeft;

		[SerializeField]
		private PinAlignment _optionsAlignment = PinAlignment.BottomRight;

		[SerializeField]
		private ConsoleAlignment _consoleAlignment;

		[SerializeField]
		private PinAlignment _triggerPosition;

		[SerializeField]
		private int _maximumConsoleEntries = 1500;

		[SerializeField]
		private bool _enableEventSystemCreation = true;

		[SerializeField]
		private bool _automaticShowCursor = true;

		[SerializeField]
		private float _uiScale = 1f;

		public static Settings Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = GetOrCreateInstance();
				}
				if (_instance._keyboardShortcuts != null && _instance._keyboardShortcuts.Length != 0)
				{
					_instance.UpgradeKeyboardShortcuts();
				}
				return _instance;
			}
		}

		public bool IsEnabled => _isEnabled;

		public bool AutoLoad => _autoLoad;

		public DefaultTabs DefaultTab => _defaultTab;

		public TriggerEnableModes EnableTrigger => _triggerEnableMode;

		public TriggerBehaviours TriggerBehaviour => _triggerBehaviour;

		public bool EnableKeyboardShortcuts => _enableKeyboardShortcuts;

		public IList<KeyboardShortcut> KeyboardShortcuts => _newKeyboardShortcuts;

		public bool KeyboardEscapeClose => _keyboardEscapeClose;

		public bool EnableBackgroundTransparency => _enableBackgroundTransparency;

		public bool RequireCode => _requireEntryCode;

		public bool RequireEntryCodeEveryTime => _requireEntryCodeEveryTime;

		public IList<int> EntryCode
		{
			get
			{
				return new ReadOnlyCollection<int>(_entryCode);
			}
			set
			{
				if (value.Count != 4)
				{
					throw new Exception("Entry code must be length 4");
				}
				if (value.Any((int p) => p > 9 || p < 0))
				{
					throw new Exception("All digits in entry code must be >= 0 and <= 9");
				}
				_entryCode = value.ToArray();
			}
		}

		public bool UseDebugCamera => _useDebugCamera;

		public int DebugLayer => _debugLayer;

		public float DebugCameraDepth => _debugCameraDepth;

		public bool CollapseDuplicateLogEntries => _collapseDuplicateLogEntries;

		public bool RichTextInConsole => _richTextInConsole;

		public string ApiKey => _apiKey;

		public bool EnableBugReporter => _enableBugReporter;

		public IList<DefaultTabs> DisabledTabs => _disabledTabs;

		public PinAlignment TriggerPosition => _triggerPosition;

		public PinAlignment ProfilerAlignment => _profilerAlignment;

		public PinAlignment OptionsAlignment => _optionsAlignment;

		public ConsoleAlignment ConsoleAlignment
		{
			get
			{
				return _consoleAlignment;
			}
			set
			{
				_consoleAlignment = value;
			}
		}

		public int MaximumConsoleEntries
		{
			get
			{
				return _maximumConsoleEntries;
			}
			set
			{
				_maximumConsoleEntries = value;
			}
		}

		public bool EnableEventSystemGeneration
		{
			get
			{
				return _enableEventSystemCreation;
			}
			set
			{
				_enableEventSystemCreation = value;
			}
		}

		public bool AutomaticallyShowCursor => _automaticShowCursor;

		public float UIScale
		{
			get
			{
				return _uiScale;
			}
			set
			{
				if (value != _uiScale)
				{
					_uiScale = value;
					OnPropertyChanged("UIScale");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private static KeyboardShortcut[] GetDefaultKeyboardShortcuts()
		{
			return new KeyboardShortcut[4]
			{
				new KeyboardShortcut
				{
					Control = true,
					Shift = true,
					Key = KeyCode.F1,
					Action = ShortcutActions.OpenSystemInfoTab
				},
				new KeyboardShortcut
				{
					Control = true,
					Shift = true,
					Key = KeyCode.F2,
					Action = ShortcutActions.OpenConsoleTab
				},
				new KeyboardShortcut
				{
					Control = true,
					Shift = true,
					Key = KeyCode.F3,
					Action = ShortcutActions.OpenOptionsTab
				},
				new KeyboardShortcut
				{
					Control = true,
					Shift = true,
					Key = KeyCode.F4,
					Action = ShortcutActions.OpenProfilerTab
				}
			};
		}

		private void UpgradeKeyboardShortcuts()
		{
			Debug.Log("[SRDebugger] Upgrading Settings format");
			List<KeyboardShortcut> list = new List<KeyboardShortcut>();
			for (int i = 0; i < _keyboardShortcuts.Length; i++)
			{
				KeyboardShortcut keyboardShortcut = _keyboardShortcuts[i];
				list.Add(new KeyboardShortcut
				{
					Action = keyboardShortcut.Action,
					Key = keyboardShortcut.Key,
					Alt = _keyboardModifierAlt,
					Shift = _keyboardModifierShift,
					Control = _keyboardModifierControl
				});
			}
			_keyboardShortcuts = new KeyboardShortcut[0];
			_newKeyboardShortcuts = list.ToArray();
		}

		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private static Settings GetOrCreateInstance()
		{
			Settings settings = Resources.Load<Settings>("SRDebugger/Settings");
			if (settings == null)
			{
				settings = ScriptableObject.CreateInstance<Settings>();
			}
			return settings;
		}
	}
}
