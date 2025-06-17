using System;

public struct WorkshopAnimatronicButtonData
{
	public WorkshopSlotData workshopSlotData;

	public int index;

	public Action<WorkshopAnimatronicButton> SelectButton;

	public double returnTime;

	public EventExposer eventExposer;
}
