using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SRDebugger.Internal;
using SRDebugger.UI.Controls;
using SRDebugger.UI.Other;
using SRF;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IPinnedUIService))]
	public class PinnedUIServiceImpl : SRServiceBase<IPinnedUIService>, IPinnedUIService
	{
		private readonly List<OptionsControlBase> _controlList = new List<OptionsControlBase>();

		private readonly Dictionary<OptionDefinition, OptionsControlBase> _pinnedObjects = new Dictionary<OptionDefinition, OptionsControlBase>();

		private bool _queueRefresh;

		private PinnedUIRoot _uiRoot;

		public DockConsoleController DockConsoleController
		{
			get
			{
				if (_uiRoot == null)
				{
					Load();
				}
				return _uiRoot.DockConsoleController;
			}
		}

		public bool IsProfilerPinned
		{
			get
			{
				if (_uiRoot == null)
				{
					return false;
				}
				return _uiRoot.Profiler.activeSelf;
			}
			set
			{
				if (_uiRoot == null)
				{
					Load();
				}
				_uiRoot.Profiler.SetActive(value);
			}
		}

		public event Action<OptionDefinition, bool> OptionPinStateChanged;

		public void Pin(OptionDefinition obj, int order = -1)
		{
			if (_uiRoot == null)
			{
				Load();
			}
			if (!_pinnedObjects.ContainsKey(obj))
			{
				OptionsControlBase optionsControlBase = OptionControlFactory.CreateControl(obj);
				optionsControlBase.CachedTransform.SetParent(_uiRoot.Container, worldPositionStays: false);
				if (order >= 0)
				{
					optionsControlBase.CachedTransform.SetSiblingIndex(order);
				}
				_pinnedObjects.Add(obj, optionsControlBase);
				_controlList.Add(optionsControlBase);
				OnPinnedStateChanged(obj, isPinned: true);
			}
		}

		public void Unpin(OptionDefinition obj)
		{
			if (_pinnedObjects.ContainsKey(obj))
			{
				OptionsControlBase optionsControlBase = _pinnedObjects[obj];
				_pinnedObjects.Remove(obj);
				_controlList.Remove(optionsControlBase);
				UnityEngine.Object.Destroy(optionsControlBase.CachedGameObject);
				OnPinnedStateChanged(obj, isPinned: false);
			}
		}

		private void OnPinnedStateChanged(OptionDefinition option, bool isPinned)
		{
			if (this.OptionPinStateChanged != null)
			{
				this.OptionPinStateChanged(option, isPinned);
			}
		}

		public void UnpinAll()
		{
			foreach (KeyValuePair<OptionDefinition, OptionsControlBase> pinnedObject in _pinnedObjects)
			{
				UnityEngine.Object.Destroy(pinnedObject.Value.CachedGameObject);
			}
			_pinnedObjects.Clear();
			_controlList.Clear();
		}

		public bool HasPinned(OptionDefinition option)
		{
			return _pinnedObjects.ContainsKey(option);
		}

		protected override void Awake()
		{
			base.Awake();
			base.CachedTransform.SetParent(Hierarchy.Get("SRDebugger"));
		}

		private void Load()
		{
			PinnedUIRoot pinnedUIRoot = Resources.Load<PinnedUIRoot>("SRDebugger/UI/Prefabs/PinnedUI");
			if (pinnedUIRoot == null)
			{
				Debug.LogError("[SRDebugger.PinnedUI] Error loading ui prefab");
				return;
			}
			PinnedUIRoot pinnedUIRoot2 = SRInstantiate.Instantiate(pinnedUIRoot);
			pinnedUIRoot2.CachedTransform.SetParent(base.CachedTransform, worldPositionStays: false);
			_uiRoot = pinnedUIRoot2;
			UpdateAnchors();
			SRDebug.Instance.PanelVisibilityChanged += OnDebugPanelVisibilityChanged;
			Service.Options.OptionsUpdated += OnOptionsUpdated;
			Service.Options.OptionsValueUpdated += OptionsOnPropertyChanged;
		}

		private void UpdateAnchors()
		{
			switch (Settings.Instance.ProfilerAlignment)
			{
			case PinAlignment.TopLeft:
			case PinAlignment.BottomLeft:
			case PinAlignment.CenterLeft:
				_uiRoot.Profiler.transform.SetSiblingIndex(0);
				break;
			case PinAlignment.TopRight:
			case PinAlignment.BottomRight:
			case PinAlignment.CenterRight:
				_uiRoot.Profiler.transform.SetSiblingIndex(1);
				break;
			}
			switch (Settings.Instance.ProfilerAlignment)
			{
			case PinAlignment.TopLeft:
			case PinAlignment.TopRight:
				_uiRoot.ProfilerVerticalLayoutGroup.childAlignment = TextAnchor.UpperCenter;
				break;
			case PinAlignment.BottomLeft:
			case PinAlignment.BottomRight:
				_uiRoot.ProfilerVerticalLayoutGroup.childAlignment = TextAnchor.LowerCenter;
				break;
			case PinAlignment.CenterLeft:
			case PinAlignment.CenterRight:
				_uiRoot.ProfilerVerticalLayoutGroup.childAlignment = TextAnchor.MiddleCenter;
				break;
			}
			_uiRoot.ProfilerHandleManager.SetAlignment(Settings.Instance.ProfilerAlignment);
			switch (Settings.Instance.OptionsAlignment)
			{
			case PinAlignment.BottomLeft:
				_uiRoot.OptionsLayoutGroup.childAlignment = TextAnchor.LowerLeft;
				break;
			case PinAlignment.TopLeft:
				_uiRoot.OptionsLayoutGroup.childAlignment = TextAnchor.UpperLeft;
				break;
			case PinAlignment.BottomRight:
				_uiRoot.OptionsLayoutGroup.childAlignment = TextAnchor.LowerRight;
				break;
			case PinAlignment.TopRight:
				_uiRoot.OptionsLayoutGroup.childAlignment = TextAnchor.UpperRight;
				break;
			case PinAlignment.BottomCenter:
				_uiRoot.OptionsLayoutGroup.childAlignment = TextAnchor.LowerCenter;
				break;
			case PinAlignment.TopCenter:
				_uiRoot.OptionsLayoutGroup.childAlignment = TextAnchor.UpperCenter;
				break;
			case PinAlignment.CenterLeft:
				_uiRoot.OptionsLayoutGroup.childAlignment = TextAnchor.MiddleLeft;
				break;
			case PinAlignment.CenterRight:
				_uiRoot.OptionsLayoutGroup.childAlignment = TextAnchor.MiddleRight;
				break;
			}
		}

		protected override void Update()
		{
			base.Update();
			if (_queueRefresh)
			{
				_queueRefresh = false;
				Refresh();
			}
		}

		private void OnOptionsUpdated(object sender, EventArgs eventArgs)
		{
			foreach (OptionDefinition item in _pinnedObjects.Keys.ToList())
			{
				if (!Service.Options.Options.Contains(item))
				{
					Unpin(item);
				}
			}
		}

		private void OptionsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			_queueRefresh = true;
		}

		private void OnDebugPanelVisibilityChanged(bool isVisible)
		{
			if (!isVisible)
			{
				_queueRefresh = true;
			}
		}

		private void Refresh()
		{
			for (int i = 0; i < _controlList.Count; i++)
			{
				_controlList[i].Refresh();
			}
		}
	}
}
