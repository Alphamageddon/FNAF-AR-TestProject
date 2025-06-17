using System;
using System.Collections;
using SRDebugger.Internal;
using SRDebugger.Services;
using SRF;
using SRF.UI.Layout;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ConsoleLogControl : SRMonoBehaviourEx
	{
		[RequiredField]
		[SerializeField]
		private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup;

		[RequiredField]
		[SerializeField]
		private ScrollRect _consoleScrollRect;

		private bool _isDirty;

		private Vector2? _scrollPosition;

		private bool _showErrors = true;

		private bool _showInfo = true;

		private bool _showWarnings = true;

		public Action<ConsoleEntry> SelectedItemChanged;

		private string _filter;

		public bool ShowErrors
		{
			get
			{
				return _showErrors;
			}
			set
			{
				_showErrors = value;
				SetIsDirty();
			}
		}

		public bool ShowWarnings
		{
			get
			{
				return _showWarnings;
			}
			set
			{
				_showWarnings = value;
				SetIsDirty();
			}
		}

		public bool ShowInfo
		{
			get
			{
				return _showInfo;
			}
			set
			{
				_showInfo = value;
				SetIsDirty();
			}
		}

		public bool EnableSelection
		{
			get
			{
				return _consoleScrollLayoutGroup.EnableSelection;
			}
			set
			{
				_consoleScrollLayoutGroup.EnableSelection = value;
			}
		}

		public string Filter
		{
			get
			{
				return _filter;
			}
			set
			{
				if (_filter != value)
				{
					_filter = value;
					_isDirty = true;
				}
			}
		}

		protected override void Awake()
		{
			base.Awake();
			_consoleScrollLayoutGroup.SelectedItemChanged.AddListener(OnSelectedItemChanged);
			Service.Console.Updated += ConsoleOnUpdated;
		}

		protected override void Start()
		{
			base.Start();
			SetIsDirty();
			StartCoroutine(ScrollToBottom());
		}

		private IEnumerator ScrollToBottom()
		{
			yield return new WaitForEndOfFrame();
			yield return new WaitForEndOfFrame();
			yield return new WaitForEndOfFrame();
			_scrollPosition = new Vector2(0f, 0f);
		}

		protected override void OnDestroy()
		{
			if (Service.Console != null)
			{
				Service.Console.Updated -= ConsoleOnUpdated;
			}
			base.OnDestroy();
		}

		private void OnSelectedItemChanged(object arg0)
		{
			ConsoleEntry obj = arg0 as ConsoleEntry;
			if (SelectedItemChanged != null)
			{
				SelectedItemChanged(obj);
			}
		}

		protected override void Update()
		{
			base.Update();
			if (_scrollPosition.HasValue)
			{
				_consoleScrollRect.normalizedPosition = _scrollPosition.Value;
				_scrollPosition = null;
			}
			if (_isDirty)
			{
				Refresh();
			}
		}

		private void Refresh()
		{
			if (_consoleScrollRect.normalizedPosition.y.ApproxZero())
			{
				_scrollPosition = _consoleScrollRect.normalizedPosition;
			}
			_consoleScrollLayoutGroup.ClearItems();
			IReadOnlyList<ConsoleEntry> entries = Service.Console.Entries;
			for (int i = 0; i < entries.Count; i++)
			{
				ConsoleEntry consoleEntry = entries[i];
				if ((consoleEntry.LogType == LogType.Error || consoleEntry.LogType == LogType.Exception || consoleEntry.LogType == LogType.Assert) && !ShowErrors)
				{
					if (consoleEntry == _consoleScrollLayoutGroup.SelectedItem)
					{
						_consoleScrollLayoutGroup.SelectedItem = null;
					}
				}
				else if (consoleEntry.LogType == LogType.Warning && !ShowWarnings)
				{
					if (consoleEntry == _consoleScrollLayoutGroup.SelectedItem)
					{
						_consoleScrollLayoutGroup.SelectedItem = null;
					}
				}
				else if (consoleEntry.LogType == LogType.Log && !ShowInfo)
				{
					if (consoleEntry == _consoleScrollLayoutGroup.SelectedItem)
					{
						_consoleScrollLayoutGroup.SelectedItem = null;
					}
				}
				else if (!string.IsNullOrEmpty(Filter) && consoleEntry.Message.IndexOf(Filter, StringComparison.OrdinalIgnoreCase) < 0)
				{
					if (consoleEntry == _consoleScrollLayoutGroup.SelectedItem)
					{
						_consoleScrollLayoutGroup.SelectedItem = null;
					}
				}
				else
				{
					_consoleScrollLayoutGroup.AddItem(consoleEntry);
				}
			}
			_isDirty = false;
		}

		private void SetIsDirty()
		{
			_isDirty = true;
		}

		private void ConsoleOnUpdated(IConsoleService console)
		{
			SetIsDirty();
		}
	}
}
