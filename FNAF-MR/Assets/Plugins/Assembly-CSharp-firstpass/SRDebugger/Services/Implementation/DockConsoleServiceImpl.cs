using SRDebugger.Internal;
using SRDebugger.UI.Other;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IDockConsoleService))]
	public class DockConsoleServiceImpl : IDockConsoleService
	{
		private ConsoleAlignment _alignment;

		private DockConsoleController _consoleRoot;

		private bool _didSuspendTrigger;

		private bool _isExpanded = true;

		private bool _isVisible;

		public bool IsVisible
		{
			get
			{
				return _isVisible;
			}
			set
			{
				if (value != _isVisible)
				{
					_isVisible = value;
					if (_consoleRoot == null && value)
					{
						Load();
					}
					else
					{
						_consoleRoot.CachedGameObject.SetActive(value);
					}
					CheckTrigger();
				}
			}
		}

		public bool IsExpanded
		{
			get
			{
				return _isExpanded;
			}
			set
			{
				if (value != _isExpanded)
				{
					_isExpanded = value;
					if (_consoleRoot == null && value)
					{
						Load();
					}
					else
					{
						_consoleRoot.SetDropdownVisibility(value);
					}
					CheckTrigger();
				}
			}
		}

		public ConsoleAlignment Alignment
		{
			get
			{
				return _alignment;
			}
			set
			{
				_alignment = value;
				if (_consoleRoot != null)
				{
					_consoleRoot.SetAlignmentMode(value);
				}
				CheckTrigger();
			}
		}

		public DockConsoleServiceImpl()
		{
			_alignment = Settings.Instance.ConsoleAlignment;
		}

		private void Load()
		{
			IPinnedUIService service = SRServiceManager.GetService<IPinnedUIService>();
			if (service == null)
			{
				Debug.LogError("[DockConsoleService] PinnedUIService not found");
				return;
			}
			PinnedUIServiceImpl pinnedUIServiceImpl = service as PinnedUIServiceImpl;
			if (pinnedUIServiceImpl == null)
			{
				Debug.LogError("[DockConsoleService] Expected IPinnedUIService to be PinnedUIServiceImpl");
				return;
			}
			_consoleRoot = pinnedUIServiceImpl.DockConsoleController;
			_consoleRoot.SetDropdownVisibility(_isExpanded);
			_consoleRoot.IsVisible = _isVisible;
			_consoleRoot.SetAlignmentMode(_alignment);
			CheckTrigger();
		}

		private void CheckTrigger()
		{
			ConsoleAlignment? consoleAlignment = null;
			switch (Service.Trigger.Position)
			{
			case PinAlignment.TopLeft:
			case PinAlignment.TopRight:
			case PinAlignment.TopCenter:
				consoleAlignment = ConsoleAlignment.Top;
				break;
			case PinAlignment.BottomLeft:
			case PinAlignment.BottomRight:
			case PinAlignment.BottomCenter:
				consoleAlignment = ConsoleAlignment.Bottom;
				break;
			}
			bool flag = consoleAlignment.HasValue && IsVisible && Alignment == consoleAlignment.Value;
			if (_didSuspendTrigger && !flag)
			{
				Service.Trigger.IsEnabled = true;
				_didSuspendTrigger = false;
			}
			else if (Service.Trigger.IsEnabled && flag)
			{
				Service.Trigger.IsEnabled = false;
				_didSuspendTrigger = true;
			}
		}
	}
}
