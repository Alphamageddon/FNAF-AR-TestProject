using System;
using UnityEngine;

public struct WorkshopSlotButtonHandlerData
{
	public MasterDomain masterDomain;

	public EventExposer eventExposer;

	public WorkshopSlotDataModel workshopSlotDataModel;

	public WorkshopAnimatronicButton prefab;

	public WorkshopAnimatronicButton_Locked prefabLocked;

	public Transform parentTransform;

	public Action<IWorkshopSlotButton> UISelectLockedButton;

	public ItemDefinitions itemDefinitions;
}
