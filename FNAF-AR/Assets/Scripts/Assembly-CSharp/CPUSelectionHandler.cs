using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CPUSelectionHandler
{
	private CPUSelectionHandlerLoadData _data;

	private readonly List<CPUCell> _cells;

	private IconLookup _iconLookup;

	private const string BareEndo = "BareEndo";

	public CPUSelectionHandler(CPUSelectionHandlerLoadData data)
	{
		_cells = new List<CPUCell>();
		_data = data;
		data.eventExposer.add_WorkshopModifyTabOpened(EventExposerOnWorkshopModifyTabOpened);
		data.gameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(b__4_0);
	}

	private void EventExposerOnWorkshopModifyTabOpened(SlotDisplayButtonType obj)
	{
		if (obj == SlotDisplayButtonType.Cpu)
		{
			GenerateCpuSelectionCells();
		}
	}

	private void GenerateCpuSelectionCells()
	{
		ClearAllCells();
		BuildSelectionButtons();
		SetStartSelection();
	}

	private void SetStartSelection()
	{
		CPUCell cpuCell = ((_cells == null) ? null : _cells.Find((CPUCell x) => x.cpuCellData.serverData.Id == _data.workshopSlotDataModel.GetSelectedSlotData().endoskeleton.cpu));
		SelectCpuCell(cpuCell, initialSelection: true);
	}

	private void ClearAllCells()
	{
		foreach (CPUCell cell in _cells)
		{
			if (cell.gameObject != null)
			{
				Object.Destroy(cell.gameObject);
			}
		}
		_cells.Clear();
	}

	private bool IsEquippedToDifferentSlot(string cpuKey)
	{
		foreach (WorkshopSlotData workshopSlotData in _data.workshopSlotDataModel.WorkshopSlotDatas)
		{
			if (workshopSlotData != _data.workshopSlotDataModel.GetSelectedSlotData() && workshopSlotData.endoskeleton.cpu == cpuKey)
			{
				return true;
			}
		}
		return false;
	}

	private void BuildSelectionButtons()
	{
		List<CPUData> list = new List<CPUData>(_data.itemDefinitions.CpuDictionary.Values);
		list.OrderBy((CPUData x) => x.Order);
		WorkshopSlotData selectedSlotData = _data.workshopSlotDataModel.GetSelectedSlotData();
		Debug.Log("CPUS: " + list.Count);
		foreach (CPUData item in list)
		{
			bool flag = false;
			if (_data.inventory != null && _data.inventory.CpuInventory != null && _data.inventory.CpuInventory.entries != null)
			{
				flag = _data.inventory.CpuInventory.entries.ContainsKey(item.Id) || item.Id == "BareEndo";
			}
			if (!flag && !item.PlayerAcquirable)
			{
				continue;
			}
			if (!IsEquippedToDifferentSlot(item.Id) || item.Id == "BareEndo")
			{
				if (item != null)
				{
					CPUCell.CPUCellData cPUCellData = new CPUCell.CPUCellData();
					cPUCellData.serverData = item;
					cPUCellData.SelectFunction = SelectCpuCell;
					cPUCellData.playerOwned = flag;
					cPUCellData.isValid = selectedSlotData.ValidatePlushtrapCpu(item.Id, selectedSlotData.endoskeleton.plushSuit);
					InstantiateAndSetButtonData(cPUCellData);
				}
			}
			else
			{
				Debug.Log("CPU " + item.Id + " is already Equipped to another slot.");
			}
		}
	}

	private void InstantiateAndSetButtonData(CPUCell.CPUCellData data)
	{
		CPUCell cPUCell = Object.Instantiate(_data.cpuCellPrefab, _data.cpuCellParent);
		cPUCell.SetData(data);
		_iconLookup.GetIcon(IconGroup.Cpu, GetCpuIconName(cPUCell), cPUCell.SetIcon);
		_cells.Add(cPUCell);
	}

	private string GetCpuIconName(CPUCell cpuCell)
	{
		if (cpuCell.cpuCellData == null)
		{
			return null;
		}
		if (!cpuCell.cpuCellData.playerOwned)
		{
			if (cpuCell.cpuCellData.serverData != null)
			{
				return cpuCell.cpuCellData.serverData.CpuSilhouetteIcon;
			}
			return null;
		}
		if (cpuCell.cpuCellData.serverData == null)
		{
			return null;
		}
		return cpuCell.cpuCellData.serverData.CpuIconName;
	}

	private void SelectCpuCell(CPUCell cpuCell, bool initialSelection)
	{
		if (!(cpuCell == null))
		{
			WorkshopSlotData selectedSlotData = _data.workshopSlotDataModel.GetSelectedSlotData();
			selectedSlotData.endoskeleton.cpu = cpuCell.cpuCellData.serverData.Id;
			selectedSlotData.UpdateIsDirty();
			HighlightCell(cpuCell);
			if (!initialSelection)
			{
				_data.eventExposer.OnWorkshopCpuChanged();
			}
		}
	}

	private void HighlightCell(CPUCell cpuCell)
	{
		foreach (CPUCell cell in _cells)
		{
			cell.SetSelected(cpuCell == cell);
		}
	}

	public void OnDestroy()
	{
		_data.eventExposer.remove_WorkshopModifyTabOpened(EventExposerOnWorkshopModifyTabOpened);
	}

	private void b__4_0(IconLookup iconLookup)
	{
		_iconLookup = iconLookup;
	}
}
