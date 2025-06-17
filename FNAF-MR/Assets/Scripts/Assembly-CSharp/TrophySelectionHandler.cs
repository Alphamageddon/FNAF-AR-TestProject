using System.Collections.Generic;
using UnityEngine;

public class TrophySelectionHandler
{
	private TrophySelectionHandlerLoadData _data;

	private readonly List<TrophyCell> _cells;

	private IconLookup _iconLookup;

	public TrophySelectionHandler(TrophySelectionHandlerLoadData data)
	{
		_cells = new List<TrophyCell>();
		_data = data;
		MasterDomain.GetDomain().eventExposer.add_TrophyInventoryUpdated(TrophyInventoryUpdated);
		_iconLookup = MasterDomain.GetDomain().GameAssetManagementDomain.IconLookupAccess;
	}

	private void TrophyInventoryUpdated(TrophyInventory inv)
	{
		GenerateTrophySelectionCells();
	}

	private void GenerateTrophySelectionCells()
	{
		ClearAllCells();
		BuildSelectionButtons();
		SetStartSelection();
	}

	private void ClearAllCells()
	{
		if (_cells == null)
		{
			return;
		}
		foreach (TrophyCell cell in _cells)
		{
			if (cell != null && cell.gameObject != null)
			{
				Object.Destroy(cell.gameObject);
			}
		}
		_cells.Clear();
	}

	private void BuildSelectionButtons()
	{
		List<TrophyData> list = new List<TrophyData>(_data.itemDefinitions.TrophyDictionary.Values);
		Debug.LogError("TROPHIES: " + list.Count);
		foreach (TrophyData item in list)
		{
			bool playerOwned = false;
			if (_data.inventory != null && _data.inventory.TrophyInventory != null && _data.inventory.TrophyInventory.entries != null)
			{
				playerOwned = (_data.inventory.TrophyInventory.entries.ContainsKey(item.Logical) ? true : false);
			}
			if (item != null)
			{
				TrophyCell.TrophyCellData trophyCellData = new TrophyCell.TrophyCellData();
				trophyCellData.serverData = item;
				trophyCellData.SelectFunction = SelectTrophyCell;
				trophyCellData.playerOwned = playerOwned;
				trophyCellData.isValid = true;
				InstantiateAndSetButtonData(trophyCellData);
			}
		}
	}

	private void InstantiateAndSetButtonData(TrophyCell.TrophyCellData data)
	{
		TrophyCell trophyCell = Object.Instantiate(_data.cellPrefab, _data.cellParent);
		trophyCell.SetData(data);
		_iconLookup.GetIcon(IconGroup.Trophy, GetTrophyIconName(trophyCell), trophyCell.SetIcon);
		_cells.Add(trophyCell);
	}

	private string GetTrophyIconName(TrophyCell trophyCell)
	{
		if (trophyCell.trophyCellData == null)
		{
			return null;
		}
		if (!trophyCell.trophyCellData.playerOwned)
		{
			return "alpine_ui_unknowntrophy";
		}
		if (trophyCell.trophyCellData.serverData == null)
		{
			return null;
		}
		return trophyCell.trophyCellData.serverData.IconRef;
	}

	private void SetStartSelection()
	{
		if (_cells.Count < 1)
		{
			return;
		}
		TrophyCell trophyCell = null;
		foreach (TrophyCell cell in _cells)
		{
			if (cell.trophyCellData.playerOwned)
			{
				trophyCell = cell;
				break;
			}
		}
		if (!(trophyCell == null))
		{
			SelectTrophyCell(trophyCell, initialSelection: true);
		}
	}

	private void SelectTrophyCell(TrophyCell trophyCell, bool initialSelection)
	{
		if (!(trophyCell == null))
		{
			HighlightCell(trophyCell);
			MasterDomain.GetDomain().eventExposer.OnTrophyChanged(trophyCell.trophyCellData.serverData);
		}
	}

	private void HighlightCell(TrophyCell trophyCell)
	{
		foreach (TrophyCell cell in _cells)
		{
			cell.SetSelected(trophyCell == cell);
		}
	}

	public void OnDestroy()
	{
		MasterDomain.GetDomain().eventExposer.remove_TrophyInventoryUpdated(TrophyInventoryUpdated);
	}
}
