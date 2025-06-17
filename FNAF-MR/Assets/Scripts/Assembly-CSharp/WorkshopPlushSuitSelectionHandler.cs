using UnityEngine;

public class WorkshopPlushSuitSelectionHandler : IPlushSuitSelectionRules
{
	private WorkshopSlotDataModel _slotDataModel;

	public WorkshopPlushSuitSelectionHandler(WorkshopSlotDataModel slotDataModel)
	{
		_slotDataModel = slotDataModel;
	}

	public bool IsValid(string plushSuitId)
	{
		Debug.Log("Checking valid for " + plushSuitId);
		if (plushSuitId == "BareEndo")
		{
			return true;
		}
		foreach (WorkshopSlotData workshopSlotData in _slotDataModel.WorkshopSlotDatas)
		{
			if (workshopSlotData != _slotDataModel.GetSelectedSlotData() && workshopSlotData.endoskeleton.plushSuit == plushSuitId)
			{
				return false;
			}
		}
		return true;
	}

	public string GetInitialSelectionId()
	{
		if (_slotDataModel.GetSelectedSlotData().endoskeleton != null)
		{
			return _slotDataModel.GetSelectedSlotData().endoskeleton.plushSuit;
		}
		return null;
	}
}
