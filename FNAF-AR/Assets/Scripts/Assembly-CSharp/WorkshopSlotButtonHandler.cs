using System.Collections.Generic;
using UnityEngine;

public class WorkshopSlotButtonHandler
{
	private WorkshopSlotButtonHandlerData _data;

	private List<IWorkshopSlotButton> _workshopAnimatronicButtons;

	private WorkshopAnimatronicButton_Locked _endoSkeletonButton;

	private Localization _localization;

	private bool _waitingForReward;

	public WorkshopSlotButtonHandler(WorkshopSlotButtonHandlerData data)
	{
		_data = data;
		if (_data.masterDomain == null)
		{
			Debug.LogError("MasterDomain is null while constructing WorkshopSlotButtonHandler");
			return;
		}
		if (_data.masterDomain.GameUIDomain == null)
		{
			Debug.LogError("GameUIDomain is null while constructing WorkshopSlotButtonHandler");
			return;
		}
		if (_data.eventExposer == null)
		{
			Debug.LogError("Master EventExposer is null while constructing WorkshopSlotButtonHandler");
			return;
		}
		if (_data.workshopSlotDataModel == null)
		{
			Debug.LogError("Extracted workshopSlotDataModel was null while constructing WorkshopSlotButtonHandler");
			return;
		}
		if (_data.masterDomain.StoreDomain == null || _data.masterDomain.StoreDomain.StoreContainer == null)
		{
			Debug.LogError("StoreDomain.StoreContainer was null while constructing WorkshopSlotButtonHandler");
			return;
		}
		_data.masterDomain.eventExposer.add_WorkshopSlotDataUpdated(GenerateWorkshopAnimatronicButtons);
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(LocalizationReady);
	}

	private void LocalizationReady(Localization localization)
	{
		_localization = localization;
	}

	private void EventExposer_RewardsV2Received()
	{
		_waitingForReward = false;
	}

	private void CreateAndAddButtonToTable(WorkshopSlotData slotData, int index)
	{
		_workshopAnimatronicButtons.Add(CreateButtonWithData(slotData, index));
	}

	private WorkshopAnimatronicButton CreateButtonWithData(WorkshopSlotData data, int index)
	{
		WorkshopAnimatronicButton workshopAnimatronicButton = Object.Instantiate(_data.prefab, _data.parentTransform);
		workshopAnimatronicButton.transform.SetSiblingIndex(index);
		workshopAnimatronicButton.Initialize(new WorkshopAnimatronicButtonData
		{
			workshopSlotData = data,
			index = index,
			SelectButton = SelectWorkshopAnimatronicButton,
			returnTime = GetReturnTime(data.workshopEntry),
			eventExposer = _data.eventExposer
		});
		return workshopAnimatronicButton;
	}

	private double GetReturnTime(WorkshopEntry entry)
	{
		if (entry.status != WorkshopEntry.Status.ScavengeAppointment)
		{
			return -1.0;
		}
		return CalculateReturnTime(entry);
	}

	private double CalculateReturnTime(WorkshopEntry entry)
	{
		return entry.lastCommand;
	}

	private float CalculateScavengePeriodModifier(List<string> modList)
	{
		if (modList.Count >= 1)
		{
			int num = 0;
			float result;
			do
			{
				result = 1f * CalculateScavengingPeriodModifierFromModId(modList[num]);
				num++;
			}
			while (num != modList.Count);
			return result;
		}
		return 1f;
	}

	private float CalculateScavengingPeriodModifierFromModId(string modId)
	{
		return 1f;
	}

	private void UpdateSelectedWorkshopAnimatronicButtonFromData()
	{
		if (_workshopAnimatronicButtons != null && _workshopAnimatronicButtons.Count >= 1)
		{
			IWorkshopSlotButton workshopSlotButton = _workshopAnimatronicButtons[(_data.workshopSlotDataModel.GetSelectedSlotDataIndex() < _workshopAnimatronicButtons.Count) ? _data.workshopSlotDataModel.GetSelectedSlotDataIndex() : 0];
			if (workshopSlotButton != null)
			{
				SetWorkshopAnimatronicButtonSelected(workshopSlotButton);
			}
		}
	}

	private void ClearAllWorkshopAnimatronicButtons()
	{
		if (_workshopAnimatronicButtons != null)
		{
			foreach (IWorkshopSlotButton workshopAnimatronicButton in _workshopAnimatronicButtons)
			{
				workshopAnimatronicButton?.TearDown();
			}
			_workshopAnimatronicButtons.Clear();
			_workshopAnimatronicButtons = null;
		}
		_endoSkeletonButton = null;
	}

	private void CreateWorkshopAnimatronicButtons(List<WorkshopSlotData> datas)
	{
		_workshopAnimatronicButtons = new List<IWorkshopSlotButton>();
		GenerateWorkshopAnimatronicButtonsFromData(datas);
		UpdateLockedWorkshopAnimatronicButtonPurchasable();
		GenerateLockedWorkshopAnimatronicButtonsLevel();
		UpdateSelectedWorkshopAnimatronicButtonFromData();
	}

	private void GenerateWorkshopAnimatronicButtonsFromData(List<WorkshopSlotData> datas)
	{
		foreach (WorkshopSlotData data in datas)
		{
			CreateAndAddButtonToTable(data, datas.IndexOf(data));
		}
	}

	private void UpdateLockedWorkshopAnimatronicButtonPurchasable()
	{
	}

	private void GenerateLockedWorkshopAnimatronicButtonsLevel()
	{
	}

	private void CollectScavengeReward(IWorkshopSlotButton workshopAnimatronicButton)
	{
		_waitingForReward = true;
	}

	private void OnLootRewardReceived()
	{
		_waitingForReward = false;
	}

	private void SetWorkshopAnimatronicButtonSelected(IWorkshopSlotButton workshopAnimatronicButton)
	{
		_data.workshopSlotDataModel.SetSelectedSlotData(workshopAnimatronicButton.GetWorkshopSlotData());
		workshopAnimatronicButton.SetSelectedUI(value: true);
	}

	private void SelectWorkshopAnimatronicButton(IWorkshopSlotButton workshopAnimatronicButton)
	{
		SetWorkshopAnimatronicButtonSelected(workshopAnimatronicButton);
		if (!_waitingForReward && workshopAnimatronicButton.IsReadyToCollect())
		{
			CollectScavengeReward(workshopAnimatronicButton);
		}
	}

	private void SortWorkshopAnimatronicButtons()
	{
		_workshopAnimatronicButtons.Sort(SortButtons);
		foreach (IWorkshopSlotButton workshopAnimatronicButton in _workshopAnimatronicButtons)
		{
			workshopAnimatronicButton.gameObject.transform.SetSiblingIndex(_workshopAnimatronicButtons.IndexOf(workshopAnimatronicButton));
		}
	}

	private int SortButtons(IWorkshopSlotButton x, IWorkshopSlotButton y)
	{
		if (x == null)
		{
			return 0;
		}
		if (y == null)
		{
			return 0;
		}
		return x.GetSortWeight() - y.GetSortWeight();
	}

	public void OverrideWorkshopSlotDataState(WorkshopSlotData workshopSlotData, WorkshopEntry.Status status)
	{
		foreach (IWorkshopSlotButton workshopAnimatronicButton in _workshopAnimatronicButtons)
		{
			if (workshopAnimatronicButton.GetWorkshopSlotData().workshopEntry.entityId == workshopSlotData.workshopEntry.entityId)
			{
				workshopAnimatronicButton.OverrideSlotDataState(status);
			}
		}
	}

	public void GenerateWorkshopAnimatronicButtons(List<WorkshopSlotData> datas)
	{
		ClearAllWorkshopAnimatronicButtons();
		CreateWorkshopAnimatronicButtons(datas);
		SortWorkshopAnimatronicButtons();
	}

	public void OnDestroy()
	{
		ClearAllWorkshopAnimatronicButtons();
		_data.eventExposer.remove_WorkshopSlotDataUpdated(GenerateWorkshopAnimatronicButtons);
	}
}
