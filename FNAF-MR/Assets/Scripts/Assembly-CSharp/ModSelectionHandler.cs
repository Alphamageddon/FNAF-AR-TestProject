using System.Collections.Generic;
using UnityEngine;

public class ModSelectionHandler
{
	private readonly ModSelectionHandlerLoadData _data;

	private readonly List<ModCell> _modCells;

	private List<GatherModsForEquipping.ModContext> _modContexts;

	private readonly GatherModsForEquipping.GatherMods _gatherMods;

	private IconLookup _iconLookup;

	private WorkshopSlotData _selectedSlot;

	private int _selectedModSlotIndex;

	public ModSelectionHandler(ModSelectionHandlerLoadData data)
	{
		_data = data;
		_gatherMods = new GatherModsForEquipping.GatherMods();
		_selectedModSlotIndex = 0;
		_modCells = new List<ModCell>();
		IconCacheReady(data.gameAssetManagementDomain.IconLookupAccess);
		data.eventExposer.add_WorkshopModifyAssemblyButtonPressed(OnWorkshopModifyAssemblyButtonPressed);
	}

	private void OnWorkshopModifyAssemblyButtonPressed(AssemblyButtonPressedPayload obj)
	{
		if (obj.ButtonType == SlotDisplayButtonType.Mod && _data.ServerGameUiDataModel.modSlotUnlocks > 0)
		{
			_selectedModSlotIndex = obj.Index;
			GenerateModCells();
		}
	}

	private void GenerateModCells()
	{
		WorkshopSlotData currentSlot = (_selectedSlot = _data.workshopSlotDataModel.GetSelectedSlotData());
		_modContexts = _gatherMods.GatherAllModsForSlot(currentSlot, _selectedModSlotIndex, _data.workshopSlotDataModel.WorkshopSlotDatas);
		RefreshCellsFromLocalData();
	}

	private void IconCacheReady(IconLookup iconLookup)
	{
		_iconLookup = iconLookup;
	}

	private void SetSelectedModIndex(int selectedModIndex)
	{
		_selectedModSlotIndex = selectedModIndex;
	}

	private void RefreshCellsFromLocalData()
	{
		_modContexts.Sort(SortModFunction);
		BuildSelectionButtons();
		SetSelected();
		UpdateNoModImage();
		UpdateModCountHeaderText();
	}

	private void UpdateModCountHeaderText()
	{
		_data.modCountText.text = _modCells.FindAll((ModCell x) => x.modContext.modEquippable).Count.ToString();
		_data.modsTotalCountText.text = _modCells.Count.ToString();
	}

	private void SetCellData(GatherModsForEquipping.ModContext modContext, ModCell modCell)
	{
		ModSelectionCellData modSelectionCellData = new ModSelectionCellData();
		modSelectionCellData.context = modContext;
		modSelectionCellData.SelectModCell = SelectModCell;
		modSelectionCellData.DisplaySellDialog = _data.SellDialog;
		modCell.SetData(modSelectionCellData);
		SetIconForCell(modContext.Mod, modCell);
	}

	private void SetIconForCell(ModData modData, ModCell modCell)
	{
		_iconLookup.GetIcon(IconGroup.Mod, modData.ModIconRenderedName, modCell.SetSprite);
	}

	private void AddCell()
	{
		_modCells.Add(Object.Instantiate(_data.cellPrefab, _data.plushSuitCellParent));
	}

	private void BuildSelectionButtons()
	{
		AddCellsAndSetData();
		RemoveExcessCells();
	}

	private void RemoveExcessCells()
	{
		if (_modCells.Count - _modContexts.Count >= 1)
		{
			int num = _modContexts.Count;
			int num2 = 0;
			while (num < _modCells.Count)
			{
				Object.Destroy(_modCells[num].gameObject);
				num++;
				num2++;
			}
			_modCells.RemoveRange(_modContexts.Count, num2);
		}
	}

	private void AddCellsAndSetData()
	{
		foreach (GatherModsForEquipping.ModContext modContext in _modContexts)
		{
			int num = _modContexts.IndexOf(modContext);
			if (num >= _modCells.Count)
			{
				AddCell();
			}
			SetCellData(_modContexts[num], _modCells[num]);
		}
	}

	private void SelectModCell(ModCell modCell)
	{
		if (modCell.modContext.isEquipped)
		{
			UnequipMod();
			RefreshCellsFromLocalData();
		}
		else if (!modCell.modContext.modEquippable)
		{
			if (_data.InvalidModCategoryDialog != null)
			{
				_data.InvalidModCategoryDialog();
			}
		}
		else
		{
			UnequipMod();
			EquipMod(modCell.modContext.Mod.Id);
			RefreshCellsFromLocalData();
		}
	}

	private void SetSelected()
	{
		ModCell modCell = _modCells.Find((ModCell x) => x.modContext.isEquipped);
		if (modCell != null)
		{
			modCell.SetSelected(value: true);
		}
		else if (_modCells.Count >= 1)
		{
			modCell = _modCells[0];
			if (!(modCell == null))
			{
				modCell.SetSelected(value: false);
			}
		}
	}

	private void UnequipMod()
	{
		GatherModsForEquipping.ModContext equippedModContext = GetEquippedModContext();
		if (equippedModContext != null)
		{
			equippedModContext.isEquipped = false;
		}
		ClearCurrentEquippedModSlot();
	}

	private void ClearCurrentEquippedModSlot()
	{
		if (!string.IsNullOrEmpty(_selectedSlot.endoskeleton.GetModAtIndex(_selectedModSlotIndex)))
		{
			_selectedSlot.endoskeleton.SetModAtIndex("", _selectedModSlotIndex);
			_selectedSlot.UpdateIsDirty();
		}
	}

	private void SetCurrentModSlot(string id)
	{
		if (!(id == _selectedSlot.endoskeleton.GetModAtIndex(_selectedModSlotIndex)))
		{
			_selectedSlot.endoskeleton.SetModAtIndex(id, _selectedModSlotIndex);
			_selectedSlot.UpdateIsDirty();
		}
	}

	private void EquipMod(string modId)
	{
		_modContexts.Find((GatherModsForEquipping.ModContext x) => x.Mod.Id == modId).isEquipped = true;
		SetCurrentModSlot(modId);
	}

	private void DecrementModFromContextList(string modId)
	{
		GatherModsForEquipping.ModContext modContext = _modContexts.Find((GatherModsForEquipping.ModContext x) => x.Mod.Id == modId);
		if (modContext == null)
		{
			return;
		}
		Debug.Log("Removing 1 from quantity for mod. Quantity before is: " + modContext.quantity);
		modContext.quantity--;
		if (modContext.quantity <= 0)
		{
			if (modContext.isEquipped)
			{
				ClearCurrentEquippedModSlot();
			}
			_modContexts.Remove(modContext);
		}
	}

	private GatherModsForEquipping.ModContext GetEquippedModContext()
	{
		return _modContexts.Find((GatherModsForEquipping.ModContext x) => x.isEquipped);
	}

	private int SortModFunction(GatherModsForEquipping.ModContext mod1, GatherModsForEquipping.ModContext mod2)
	{
		if (mod1.modEquippable != mod2.modEquippable)
		{
			if (!mod1.modEquippable)
			{
				return 1;
			}
			return -1;
		}
		if (mod1.Mod.Category != mod2.Mod.Category)
		{
			return _data.dataConnector.ModCategorySortWeights[mod1.Mod.Category] - _data.dataConnector.ModCategorySortWeights[mod2.Mod.Category];
		}
		if (mod1.Mod.Stars != mod2.Mod.Stars)
		{
			return mod1.Mod.Stars - mod2.Mod.Stars;
		}
		if (mod1.Mod.Id != mod2.Mod.Id)
		{
			return string.Compare(mod1.Mod.Id, mod2.Mod.Id);
		}
		if (!mod1.modEquippable)
		{
			return 1;
		}
		return -1;
	}

	private void UpdateNoModImage()
	{
		if (_modCells != null)
		{
			_data.noModsLabel.SetActive(_modCells.Count == 0);
		}
		else
		{
			_data.noModsLabel.SetActive(value: true);
		}
	}

	public void SellModAndUpdateLocalData(GatherModsForEquipping.ModContext modContext)
	{
		DecrementModFromContextList(modContext.Mod.Id);
		RefreshCellsFromLocalData();
		Dictionary<ModData, int> dictionary = new Dictionary<ModData, int>();
		dictionary.Add(modContext.Mod, 1);
		_data.modInventory.RemoveMod(modContext.Mod, 1);
		_data.sellModsRequester.SellMods(dictionary);
	}

	public void TearDown()
	{
		_data.eventExposer.remove_WorkshopModifyAssemblyButtonPressed(OnWorkshopModifyAssemblyButtonPressed);
	}
}
