using System;
using SRDebugger.Internal;
using SRDebugger.UI;
using SRF;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IDebugPanelService))]
	public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService
	{
		private DebugPanelRoot _debugPanelRootObject;

		private bool _isVisible;

		private bool? _cursorWasVisible;

		private CursorLockMode? _cursorLockMode;

		public DebugPanelRoot RootObject => _debugPanelRootObject;

		public bool IsLoaded => _debugPanelRootObject != null;

		public bool IsVisible
		{
			get
			{
				if (IsLoaded)
				{
					return _isVisible;
				}
				return false;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				if (value)
				{
					if (!IsLoaded)
					{
						Load();
					}
					SRDebuggerUtil.EnsureEventSystemExists();
					_debugPanelRootObject.CanvasGroup.alpha = 1f;
					_debugPanelRootObject.CanvasGroup.interactable = true;
					_debugPanelRootObject.CanvasGroup.blocksRaycasts = true;
					_cursorWasVisible = Cursor.visible;
					_cursorLockMode = Cursor.lockState;
					if (Settings.Instance.AutomaticallyShowCursor)
					{
						Cursor.visible = true;
						Cursor.lockState = CursorLockMode.None;
					}
				}
				else
				{
					if (IsLoaded)
					{
						_debugPanelRootObject.CanvasGroup.alpha = 0f;
						_debugPanelRootObject.CanvasGroup.interactable = false;
						_debugPanelRootObject.CanvasGroup.blocksRaycasts = false;
					}
					if (_cursorWasVisible.HasValue)
					{
						Cursor.visible = _cursorWasVisible.Value;
						_cursorWasVisible = null;
					}
					if (_cursorLockMode.HasValue)
					{
						Cursor.lockState = _cursorLockMode.Value;
						_cursorLockMode = null;
					}
				}
				_isVisible = value;
				if (this.VisibilityChanged != null)
				{
					this.VisibilityChanged(this, _isVisible);
				}
			}
		}

		public DefaultTabs? ActiveTab
		{
			get
			{
				if (_debugPanelRootObject == null)
				{
					return null;
				}
				return _debugPanelRootObject.TabController.ActiveTab;
			}
		}

		public event Action<IDebugPanelService, bool> VisibilityChanged;

		public void OpenTab(DefaultTabs tab)
		{
			if (!IsVisible)
			{
				IsVisible = true;
			}
			_debugPanelRootObject.TabController.OpenTab(tab);
		}

		public void Unload()
		{
			if (!(_debugPanelRootObject == null))
			{
				IsVisible = false;
				_debugPanelRootObject.CachedGameObject.SetActive(value: false);
				UnityEngine.Object.Destroy(_debugPanelRootObject.CachedGameObject);
				_debugPanelRootObject = null;
			}
		}

		private void Load()
		{
			DebugPanelRoot debugPanelRoot = Resources.Load<DebugPanelRoot>("SRDebugger/UI/Prefabs/DebugPanel");
			if (debugPanelRoot == null)
			{
				Debug.LogError("[SRDebugger] Error loading debug panel prefab");
				return;
			}
			_debugPanelRootObject = SRInstantiate.Instantiate(debugPanelRoot);
			_debugPanelRootObject.name = "Panel";
			UnityEngine.Object.DontDestroyOnLoad(_debugPanelRootObject);
			_debugPanelRootObject.CachedTransform.SetParent(Hierarchy.Get("SRDebugger"), worldPositionStays: true);
			SRDebuggerUtil.EnsureEventSystemExists();
		}
	}
}
