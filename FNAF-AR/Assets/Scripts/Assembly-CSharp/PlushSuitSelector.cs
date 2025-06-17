using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlushSuitSelector : IxSceneDisplay
{
	private const string LOCKED_LEVEL_LOC = "ui_loot_reward_screen_level_text";

	private ItemDefinitions _itemDefinitions;

	private PlayerInventory _playerInventory;

	private GridLayoutGroup _categoryContentContainer;

	private GridLayoutGroup _skinContentContainer;

	private TextMeshProUGUI _skinSelectorNumText;

	private EventExposer _eventExposer;

	private List<SkinCategoryData> _skinCategoryData;

	private IxTableDisplay<PlushSuitSelectorCategoryCellDisplay, SkinCategoryData> _categoryTable;

	private IxTableDisplay<PlushSuitSelectorSkinCellDisplay, OwnedPlushSuitData> _skinTable;

	private PlushSuitSelectorCategoryCellDisplay _currentCategoryCell;

	private PlushSuitSelectorSkinCellDisplay _currentSkinCell;

	private IPlushSuitSelectionRules _rules;

	private string _lockedLevelText;

	private bool _animatronicLoading;

	public Action<string> NewSkinSelected;

	public PlushSuitSelector(GameObject mainCanvas, IPlushSuitSelectionRules rules)
		: base(mainCanvas)
	{
		_skinCategoryData = new List<SkinCategoryData>();
		MasterDomain domain = MasterDomain.GetDomain();
		_eventExposer = domain.eventExposer;
		_itemDefinitions = domain.ItemDefinitionDomain.ItemDefinitions;
		_playerInventory = domain.TheGameDomain.playerInventory;
		domain.LocalizationDomain.Localization.GetInterfaceAsync(b__17_0);
		_rules = rules;
	}

	public override void Teardown()
	{
		if (_categoryTable != null)
		{
			_categoryTable.Teardown();
		}
		_categoryTable = null;
		if (_skinTable != null)
		{
			_skinTable.Teardown();
		}
		_skinTable = null;
		_currentCategoryCell = null;
		_currentSkinCell = null;
		_skinCategoryData.Clear();
		_skinContentContainer = null;
		_skinSelectorNumText = null;
		_categoryContentContainer = null;
		base.Teardown();
	}

	public void SetDiplay(bool show)
	{
		if (show)
		{
			base.Show();
		}
		else
		{
			Hide();
		}
	}

	public void Setup(Action<string> skinSelectedCallback)
	{
		_animatronicLoading = false;
		_eventExposer.add_AnimatronicCreationRequestStarted(LoadAnimatronic);
		_eventExposer.add_AnimatronicCreationRequestComplete(AnimatronicLoaded);
		NewSkinSelected = skinSelectedCallback;
		CreateAllSkinCategoryData();
		if (_categoryTable == null)
		{
			Debug.LogError("Making tables.");
			_categoryTable = new IxTableDisplay<PlushSuitSelectorCategoryCellDisplay, SkinCategoryData>(_categoryContentContainer);
			_skinTable = new IxTableDisplay<PlushSuitSelectorSkinCellDisplay, OwnedPlushSuitData>(_skinContentContainer);
		}
		SetupCategorySelection();
	}

	public List<PlushSuitSelectorCategoryCellDisplay> GetCells()
	{
		if (_categoryTable != null)
		{
			return _categoryTable.DisplayItems;
		}
		return null;
	}

	protected override void CacheAndPopulateComponents()
	{
		_components = new ComponentContainer();
		Type[] onlyCacheTypes = new Type[2]
		{
			typeof(GridLayoutGroup),
			typeof(TextMeshProUGUI)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_categoryContentContainer = _components.TryGetComponent<GridLayoutGroup>("CategorySelectorContentContainer");
		_skinContentContainer = _components.TryGetComponent<GridLayoutGroup>("SkinSelectorContentContainer");
		_skinSelectorNumText = _components.TryGetComponent<TextMeshProUGUI>("SkinSelectorNumText");
	}

	private void CreateAllSkinCategoryData()
	{
		_skinCategoryData.Clear();
		Debug.Log("Is item definitions null? - " + (_itemDefinitions == null) + " Is sorted plushsuits null? - " + (_itemDefinitions.SortedPlushSuits == null));
		foreach (List<PlushSuitData> sortedPlushSuit in _itemDefinitions.SortedPlushSuits)
		{
			_skinCategoryData.Add(CreateDataForCategory(sortedPlushSuit, _playerInventory.GetPlushSuits()));
		}
	}

	private SkinCategoryData CreateDataForCategory(List<PlushSuitData> skins, List<string> owned)
	{
		Debug.LogWarning("Creating data for skin category and owned amount is " + owned.Count);
		foreach (string item in owned)
		{
			Debug.LogWarning(item + " OWNED");
		}
		SkinCategoryData skinCategoryData = new SkinCategoryData();
		foreach (PlushSuitData skin in skins)
		{
			OwnedPlushSuitData ownedPlushSuitData = new OwnedPlushSuitData();
			ownedPlushSuitData.Data = skin;
			if (owned != null)
			{
				ownedPlushSuitData.Owned = owned.Contains(skin.Id);
			}
			else
			{
				ownedPlushSuitData.Owned = false;
			}
			ownedPlushSuitData.IsLocked = false;
			ownedPlushSuitData.LockedLevelText = _lockedLevelText;
			skinCategoryData.Data.Add(ownedPlushSuitData);
		}
		return skinCategoryData;
	}

	private void SetupCategorySelection()
	{
		_currentCategoryCell = null;
		_categoryTable.Clear();
		_categoryTable.SetItems(_skinCategoryData);
		foreach (PlushSuitSelectorCategoryCellDisplay displayItem in _categoryTable.DisplayItems)
		{
			displayItem.InitializeContents(_rules, CategoryCellPressed);
		}
		ScrollToInitialSelection(_rules.GetInitialSelectionId());
	}

	private void ScrollToInitialSelection(string selectionId)
	{
		float num = 0f;
		foreach (PlushSuitSelectorCategoryCellDisplay displayItem in _categoryTable.DisplayItems)
		{
			string animatronicId = displayItem.GetAnimatronicId();
			if (!string.IsNullOrEmpty(animatronicId))
			{
				if (GetSkinCategoryForSkin(animatronicId) == GetSkinCategoryForSkin(selectionId))
				{
					SetInitialSelection(displayItem, selectionId);
					_categoryContentContainer.transform.localPosition = new Vector3
					{
						x = 0f - num,
						y = _categoryContentContainer.transform.localPosition.y,
						z = _categoryContentContainer.transform.localPosition.z
					};
					return;
				}
				num += _categoryContentContainer.cellSize.x + _categoryContentContainer.spacing.x;
			}
		}
		_categoryTable.DisplayItems[0].OnButtonClicked();
	}

	private void SetInitialSelection(PlushSuitSelectorCategoryCellDisplay cell, string selectionId)
	{
		if (_currentCategoryCell != null)
		{
			_currentCategoryCell.SetSelected(selected: false);
		}
		_currentCategoryCell = cell;
		cell.SetSelected(selected: true);
		ReloadSkinSelector(cell.GetData(), cell.GetNumOwned(), 0);
		foreach (PlushSuitSelectorSkinCellDisplay displayItem in _skinTable.DisplayItems)
		{
			if (displayItem.Valid && selectionId == displayItem.GetSkinId())
			{
				_currentSkinCell.SetSelected(selected: false);
				_currentSkinCell = displayItem;
				_currentSkinCell.SetSelected(selected: true);
				_currentCategoryCell.UpdateCategoryIcon(selectionId);
				break;
			}
		}
	}

	private string GetSkinCategoryForSkin(string skin)
	{
		if (_itemDefinitions.GetPlushSuitById(skin) != null)
		{
			return _itemDefinitions.GetPlushSuitById(skin).SkinCategory;
		}
		return null;
	}

	private void ReloadSkinSelector(SkinCategoryData data, int numOwned, int index)
	{
		if (_skinTable != null)
		{
			_skinTable.Clear();
		}
		if (data == null)
		{
			return;
		}
		Debug.LogError("DATA LENGTH - " + data.Data.Count);
		_skinTable.SetItems(data.Data);
		if (_skinTable.DisplayItems == null)
		{
			return;
		}
		foreach (PlushSuitSelectorSkinCellDisplay displayItem in _skinTable.DisplayItems)
		{
			displayItem.InitializeContents(_rules, SkinCellPressed);
		}
		_currentSkinCell = _skinTable.DisplayItems[_skinTable.DisplayItems[index].Valid ? index : 0];
		_skinSelectorNumText.text = numOwned.ToString();
		_currentSkinCell.SetSelected(selected: true);
	}

	private void CategoryCellPressed(PlushSuitSelectorCategoryCellDisplay cell)
	{
		SkinCategoryData data = cell.GetData();
		if (!_animatronicLoading && _currentCategoryCell != cell)
		{
			if (_currentCategoryCell != null)
			{
				_currentCategoryCell.SetSelected(selected: false);
			}
			_currentCategoryCell = cell;
			cell.SetSelected(selected: true);
			Debug.LogError("NUMOWNED - " + cell.GetNumOwned());
			ReloadSkinSelector(data, cell.GetNumOwned(), _currentCategoryCell.GetCurrentIndex());
			if (NewSkinSelected != null)
			{
				NewSkinSelected(cell.GetAnimatronicId());
			}
		}
	}

	private void SkinCellPressed(PlushSuitSelectorSkinCellDisplay cell)
	{
		if (!_animatronicLoading && _currentSkinCell != cell)
		{
			if (_currentSkinCell != null)
			{
				_currentSkinCell.SetSelected(selected: false);
			}
			_currentSkinCell = cell;
			_currentSkinCell.SetSelected(selected: true);
			_currentCategoryCell.UpdateCategoryIcon(cell.GetSkinId());
			if (NewSkinSelected != null)
			{
				NewSkinSelected(cell.GetSkinId());
			}
		}
	}

	private void LoadAnimatronic()
	{
		_animatronicLoading = true;
	}

	private void AnimatronicLoaded()
	{
		_animatronicLoading = false;
	}

	private void b__17_0(Localization localization)
	{
		_lockedLevelText = localization.GetLocalizedString("ui_loot_reward_screen_level_text", "Level:");
	}
}
