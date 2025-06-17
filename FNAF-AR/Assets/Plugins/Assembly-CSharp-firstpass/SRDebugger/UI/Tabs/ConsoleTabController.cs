using System;
using SRDebugger.Internal;
using SRDebugger.Services;
using SRDebugger.UI.Controls;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Tabs
{
	public class ConsoleTabController : SRMonoBehaviourEx
	{
		private const int MaxLength = 2600;

		private Canvas _consoleCanvas;

		private bool _isDirty;

		[RequiredField]
		public ConsoleLogControl ConsoleLogControl;

		[RequiredField]
		public Toggle PinToggle;

		[RequiredField]
		public ScrollRect StackTraceScrollRect;

		[RequiredField]
		public Text StackTraceText;

		[RequiredField]
		public Toggle ToggleErrors;

		[RequiredField]
		public Text ToggleErrorsText;

		[RequiredField]
		public Toggle ToggleInfo;

		[RequiredField]
		public Text ToggleInfoText;

		[RequiredField]
		public Toggle ToggleWarnings;

		[RequiredField]
		public Text ToggleWarningsText;

		[RequiredField]
		public Toggle FilterToggle;

		[RequiredField]
		public InputField FilterField;

		[RequiredField]
		public GameObject FilterBarContainer;

		protected override void Start()
		{
			base.Start();
			_consoleCanvas = GetComponent<Canvas>();
			ToggleErrors.onValueChanged.AddListener(delegate
			{
				_isDirty = true;
			});
			ToggleWarnings.onValueChanged.AddListener(delegate
			{
				_isDirty = true;
			});
			ToggleInfo.onValueChanged.AddListener(delegate
			{
				_isDirty = true;
			});
			PinToggle.onValueChanged.AddListener(PinToggleValueChanged);
			FilterToggle.onValueChanged.AddListener(FilterToggleValueChanged);
			FilterBarContainer.SetActive(FilterToggle.isOn);
			FilterField.onValueChanged.AddListener(FilterValueChanged);
			ConsoleLogControl.SelectedItemChanged = ConsoleLogSelectedItemChanged;
			Service.Console.Updated += ConsoleOnUpdated;
			Service.Panel.VisibilityChanged += PanelOnVisibilityChanged;
			StackTraceText.supportRichText = Settings.Instance.RichTextInConsole;
			PopulateStackTraceArea(null);
			Refresh();
		}

		private void FilterToggleValueChanged(bool isOn)
		{
			if (isOn)
			{
				FilterBarContainer.SetActive(value: true);
				ConsoleLogControl.Filter = FilterField.text;
			}
			else
			{
				ConsoleLogControl.Filter = null;
				FilterBarContainer.SetActive(value: false);
			}
		}

		private void FilterValueChanged(string filterText)
		{
			if (FilterToggle.isOn && !string.IsNullOrEmpty(filterText) && filterText.Trim().Length != 0)
			{
				ConsoleLogControl.Filter = filterText;
			}
			else
			{
				ConsoleLogControl.Filter = null;
			}
		}

		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
			if (!(_consoleCanvas == null))
			{
				if (b)
				{
					_consoleCanvas.enabled = true;
				}
				else
				{
					_consoleCanvas.enabled = false;
				}
			}
		}

		private void PinToggleValueChanged(bool isOn)
		{
			Service.DockConsole.IsVisible = isOn;
		}

		protected override void OnDestroy()
		{
			if (Service.Console != null)
			{
				Service.Console.Updated -= ConsoleOnUpdated;
			}
			base.OnDestroy();
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			_isDirty = true;
		}

		private void ConsoleLogSelectedItemChanged(object item)
		{
			ConsoleEntry entry = item as ConsoleEntry;
			PopulateStackTraceArea(entry);
		}

		protected override void Update()
		{
			base.Update();
			if (_isDirty)
			{
				Refresh();
			}
		}

		private void PopulateStackTraceArea(ConsoleEntry entry)
		{
			if (entry == null)
			{
				StackTraceText.text = "";
			}
			else
			{
				string text = entry.Message + Environment.NewLine + ((!string.IsNullOrEmpty(entry.StackTrace)) ? entry.StackTrace : SRDebugStrings.Current.Console_NoStackTrace);
				if (text.Length > 2600)
				{
					text = text.Substring(0, 2600);
					text = text + "\n" + SRDebugStrings.Current.Console_MessageTruncated;
				}
				StackTraceText.text = text;
			}
			StackTraceScrollRect.normalizedPosition = new Vector2(0f, 1f);
		}

		private void Refresh()
		{
			ToggleInfoText.text = SRDebuggerUtil.GetNumberString(Service.Console.InfoCount, 999, "999+");
			ToggleWarningsText.text = SRDebuggerUtil.GetNumberString(Service.Console.WarningCount, 999, "999+");
			ToggleErrorsText.text = SRDebuggerUtil.GetNumberString(Service.Console.ErrorCount, 999, "999+");
			ConsoleLogControl.ShowErrors = ToggleErrors.isOn;
			ConsoleLogControl.ShowWarnings = ToggleWarnings.isOn;
			ConsoleLogControl.ShowInfo = ToggleInfo.isOn;
			PinToggle.isOn = Service.DockConsole.IsVisible;
			_isDirty = false;
		}

		private void ConsoleOnUpdated(IConsoleService console)
		{
			_isDirty = true;
		}

		public void Clear()
		{
			Service.Console.Clear();
			_isDirty = true;
		}
	}
}
