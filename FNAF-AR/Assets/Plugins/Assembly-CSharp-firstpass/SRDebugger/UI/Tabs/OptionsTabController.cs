using System;
using System.Collections.Generic;
using System.ComponentModel;
using SRDebugger.Internal;
using SRDebugger.Services;
using SRDebugger.UI.Controls;
using SRDebugger.UI.Controls.Data;
using SRDebugger.UI.Other;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Tabs
{
	public class OptionsTabController : SRMonoBehaviourEx
	{
		private class CategoryInstance
		{
			public readonly List<OptionsControlBase> Options = new List<OptionsControlBase>();

			public CategoryGroup CategoryGroup { get; private set; }

			public CategoryInstance(CategoryGroup group)
			{
				CategoryGroup = group;
			}
		}

		private readonly List<OptionsControlBase> _controls = new List<OptionsControlBase>();

		private readonly List<CategoryInstance> _categories = new List<CategoryInstance>();

		private readonly Dictionary<OptionDefinition, OptionsControlBase> _options = new Dictionary<OptionDefinition, OptionsControlBase>();

		private bool _queueRefresh;

		private bool _selectionModeEnabled;

		private Canvas _optionCanvas;

		[RequiredField]
		public ActionControl ActionControlPrefab;

		[RequiredField]
		public CategoryGroup CategoryGroupPrefab;

		[RequiredField]
		public RectTransform ContentContainer;

		[RequiredField]
		public GameObject NoOptionsNotice;

		[RequiredField]
		public Toggle PinButton;

		[RequiredField]
		public GameObject PinPromptSpacer;

		[RequiredField]
		public GameObject PinPromptText;

		private bool _isTogglingCategory;

		protected override void Start()
		{
			base.Start();
			PinButton.onValueChanged.AddListener(SetSelectionModeEnabled);
			PinPromptText.SetActive(value: false);
			Populate();
			_optionCanvas = GetComponent<Canvas>();
			Service.Options.OptionsUpdated += OnOptionsUpdated;
			Service.Options.OptionsValueUpdated += OnOptionsValueChanged;
			Service.PinnedUI.OptionPinStateChanged += OnOptionPinnedStateChanged;
		}

		private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned)
		{
			if (_options.ContainsKey(optionDefinition))
			{
				_options[optionDefinition].IsSelected = isPinned;
			}
		}

		private void OnOptionsUpdated(object sender, EventArgs eventArgs)
		{
			Clear();
			Populate();
		}

		private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			_queueRefresh = true;
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			Service.Panel.VisibilityChanged += PanelOnVisibilityChanged;
		}

		protected override void OnDisable()
		{
			SetSelectionModeEnabled(isEnabled: false);
			if (Service.Panel != null)
			{
				Service.Panel.VisibilityChanged -= PanelOnVisibilityChanged;
			}
			base.OnDisable();
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

		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
			if (!b)
			{
				SetSelectionModeEnabled(isEnabled: false);
				Refresh();
			}
			else if (b && base.CachedGameObject.activeInHierarchy)
			{
				Refresh();
			}
			if (_optionCanvas != null)
			{
				_optionCanvas.enabled = b;
			}
		}

		public void SetSelectionModeEnabled(bool isEnabled)
		{
			if (_selectionModeEnabled == isEnabled)
			{
				return;
			}
			_selectionModeEnabled = isEnabled;
			PinButton.isOn = isEnabled;
			PinPromptText.SetActive(isEnabled);
			foreach (KeyValuePair<OptionDefinition, OptionsControlBase> option in _options)
			{
				option.Value.SelectionModeEnabled = isEnabled;
				if (isEnabled)
				{
					option.Value.IsSelected = Service.PinnedUI.HasPinned(option.Key);
				}
			}
			foreach (CategoryInstance category in _categories)
			{
				category.CategoryGroup.SelectionModeEnabled = isEnabled;
			}
			RefreshCategorySelection();
		}

		private void Refresh()
		{
			for (int i = 0; i < _options.Count; i++)
			{
				_controls[i].Refresh();
				_controls[i].IsSelected = Service.PinnedUI.HasPinned(_controls[i].Option);
			}
		}

		private void CommitPinnedOptions()
		{
			foreach (KeyValuePair<OptionDefinition, OptionsControlBase> option in _options)
			{
				OptionsControlBase value = option.Value;
				if (value.IsSelected && !Service.PinnedUI.HasPinned(option.Key))
				{
					Service.PinnedUI.Pin(option.Key);
				}
				else if (!value.IsSelected && Service.PinnedUI.HasPinned(option.Key))
				{
					Service.PinnedUI.Unpin(option.Key);
				}
			}
		}

		private void RefreshCategorySelection()
		{
			_isTogglingCategory = true;
			foreach (CategoryInstance category in _categories)
			{
				bool isSelected = true;
				for (int i = 0; i < category.Options.Count; i++)
				{
					if (!category.Options[i].IsSelected)
					{
						isSelected = false;
						break;
					}
				}
				category.CategoryGroup.IsSelected = isSelected;
			}
			_isTogglingCategory = false;
		}

		private void OnOptionSelectionToggle(bool selected)
		{
			if (!_isTogglingCategory)
			{
				RefreshCategorySelection();
				CommitPinnedOptions();
			}
		}

		private void OnCategorySelectionToggle(CategoryInstance category, bool selected)
		{
			_isTogglingCategory = true;
			for (int i = 0; i < category.Options.Count; i++)
			{
				category.Options[i].IsSelected = selected;
			}
			_isTogglingCategory = false;
			CommitPinnedOptions();
		}

		protected void Populate()
		{
			Dictionary<string, List<OptionDefinition>> dictionary = new Dictionary<string, List<OptionDefinition>>();
			foreach (OptionDefinition option in Service.Options.Options)
			{
				if (!dictionary.TryGetValue(option.Category, out var value))
				{
					value = new List<OptionDefinition>();
					dictionary.Add(option.Category, value);
				}
				value.Add(option);
			}
			bool flag = false;
			foreach (KeyValuePair<string, List<OptionDefinition>> item in dictionary)
			{
				if (item.Value.Count != 0)
				{
					flag = true;
					CreateCategory(item.Key, item.Value);
				}
			}
			if (flag)
			{
				NoOptionsNotice.SetActive(value: false);
			}
		}

		protected void CreateCategory(string title, List<OptionDefinition> options)
		{
			options.Sort((OptionDefinition d1, OptionDefinition d2) => d1.SortPriority.CompareTo(d2.SortPriority));
			CategoryGroup categoryGroup = SRInstantiate.Instantiate(CategoryGroupPrefab);
			CategoryInstance categoryInstance = new CategoryInstance(categoryGroup);
			_categories.Add(categoryInstance);
			categoryGroup.CachedTransform.SetParent(ContentContainer, worldPositionStays: false);
			categoryGroup.Header.text = title;
			categoryGroup.SelectionModeEnabled = false;
			categoryInstance.CategoryGroup.SelectionToggle.onValueChanged.AddListener(delegate(bool b)
			{
				OnCategorySelectionToggle(categoryInstance, b);
			});
			foreach (OptionDefinition option in options)
			{
				OptionsControlBase optionsControlBase = OptionControlFactory.CreateControl(option, title);
				if (optionsControlBase == null)
				{
					Debug.LogError("[SRDebugger.OptionsTab] Failed to create option control for {0}".Fmt(option.Name));
					continue;
				}
				categoryInstance.Options.Add(optionsControlBase);
				optionsControlBase.CachedTransform.SetParent(categoryGroup.Container, worldPositionStays: false);
				optionsControlBase.IsSelected = Service.PinnedUI.HasPinned(option);
				optionsControlBase.SelectionModeEnabled = false;
				optionsControlBase.SelectionModeToggle.onValueChanged.AddListener(OnOptionSelectionToggle);
				_options.Add(option, optionsControlBase);
				_controls.Add(optionsControlBase);
			}
		}

		private void Clear()
		{
			foreach (CategoryInstance category in _categories)
			{
				UnityEngine.Object.Destroy(category.CategoryGroup.gameObject);
			}
			_categories.Clear();
			_controls.Clear();
			_options.Clear();
		}
	}
}
