using System;
using System.Collections.Generic;
using UnityEngine;

public class WorkshopSlotDataModel
{
	private WorkshopSlotData _selectedWorkshopSlotData;

	private int _selectedWorkshopSlotDataIndex;

	private WorkshopSlotDataModelLoadData _data;

	private IconLookup _iconLookup;

	private ItemDefinitions _itemDefinitions;

	public bool StageIsWaitingForSpawn;

	public List<WorkshopSlotData> WorkshopSlotDatas { get; set; }

	public Dictionary<string, string> MostRecentPlushSuitSelections { get; }

	public WorkshopSlotDataModel(WorkshopSlotDataModelLoadData data)
	{
		_selectedWorkshopSlotDataIndex = 0;
		WorkshopSlotDatas = new List<WorkshopSlotData>();
		MostRecentPlushSuitSelections = new Dictionary<string, string>();
		_data = data;
		MasterDomain.GetDomain().eventExposer.add_WorkshopDataV2Updated(BuildSlotDataFromWarehouseDataV2);
		MasterDomain.GetDomain().GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(IconCacheReady);
		ItemDefinitionsReady(MasterDomain.GetDomain().ItemDefinitionDomain);
	}

	private void IconCacheReady(IconLookup iconLookup)
	{
		_iconLookup = iconLookup;
		foreach (WorkshopSlotData workshopSlotData in WorkshopSlotDatas)
		{
			workshopSlotData.SetIconLookup(_iconLookup);
		}
	}

	private void ItemDefinitionsReady(ItemDefinitionDomain itemDefinitionDomain)
	{
		_itemDefinitions = itemDefinitionDomain.ItemDefinitions;
		foreach (WorkshopSlotData workshopSlotData in WorkshopSlotDatas)
		{
			workshopSlotData.SetItemDefinitions(_itemDefinitions);
		}
	}

	private void BuildSlotDataFromWarehouseDataV2(WorkshopData workshopData)
	{
		Debug.LogError("Resetting WorkshopSlotDatas.");
		WorkshopSlotDatas.Clear();
		foreach (WorkshopEntry entry in workshopData.Entries)
		{
			entry.status = UpdateEntryStatus(entry);
			Debug.Log("making slot data");
			WorkshopSlotData workshopSlotData = new WorkshopSlotData();
			workshopSlotData.SetIconLookup(_iconLookup);
			workshopSlotData.SetItemDefinitions(_itemDefinitions);
			workshopSlotData.UpdateServerWorkshopEntry(entry);
			WorkshopSlotDatas.Add(workshopSlotData);
		}
		Debug.Log("updated selected slot - making new slots");
		_data.EventExposer.OnWorkshopSlotDataUpdated(WorkshopSlotDatas);
		UpdateSelectedSlot();
	}

	private WorkshopEntry.Status UpdateEntryStatus(WorkshopEntry entry)
	{
		if (string.IsNullOrEmpty(entry.entityId))
		{
			return WorkshopEntry.Status.Available;
		}
		if (entry.status != WorkshopEntry.Status.Available)
		{
			return entry.status;
		}
		AnimatronicEntity entity = MasterDomain.GetDomain().AnimatronicEntityDomain.container.GetEntity(entry.entityId);
		if (entity == null)
		{
			return entry.status;
		}
		if (entity.stateData.animatronicState == StateData.AnimatronicState.Recall)
		{
			return WorkshopEntry.Status.Returning;
		}
		return entry.status;
	}

	private void UpdateSelectedSlot()
	{
		if (WorkshopSlotDatas.Count >= 1)
		{
			_selectedWorkshopSlotDataIndex = Math.Max(0, Math.Min(WorkshopSlotDatas.Count - 1, _selectedWorkshopSlotDataIndex));
			_selectedWorkshopSlotData = WorkshopSlotDatas[_selectedWorkshopSlotDataIndex];
		}
	}

	public void SetSelectedSlotData(WorkshopSlotData workshopSlotData)
	{
		_selectedWorkshopSlotData = workshopSlotData;
		Debug.Log("selected new slot data. does workshopslotdatas contain it? " + (WorkshopSlotDatas.Contains(workshopSlotData) ? "absolutely." : "no way."));
		_selectedWorkshopSlotDataIndex = WorkshopSlotDatas.IndexOf(workshopSlotData);
	}

	public int NumScavengers()
	{
		int num = 0;
		foreach (WorkshopSlotData workshopSlotData in WorkshopSlotDatas)
		{
			if (workshopSlotData.workshopEntry.status == WorkshopEntry.Status.Scavenging || workshopSlotData.workshopEntry.status == WorkshopEntry.Status.Returning)
			{
				num++;
			}
		}
		return num;
	}

	public int GetSelectedSlotDataIndex()
	{
		return _selectedWorkshopSlotDataIndex;
	}

	public WorkshopSlotData GetSelectedSlotData()
	{
		return _selectedWorkshopSlotData;
	}

	public WorkshopEntry.Status GetSelectedSlotDataStatus()
	{
		return _selectedWorkshopSlotData.workshopEntry.status;
	}

	public void OnDestroy()
	{
		_data.EventExposer.remove_WorkshopDataV2Updated(BuildSlotDataFromWarehouseDataV2);
		if (WorkshopSlotDatas != null)
		{
			WorkshopSlotDatas.Clear();
			WorkshopSlotDatas = null;
		}
	}

	public void RefreshIcons()
	{
		foreach (WorkshopSlotData workshopSlotData in WorkshopSlotDatas)
		{
			workshopSlotData.UpdateIcon();
		}
	}
}
