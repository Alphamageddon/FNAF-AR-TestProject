using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public struct AssembleButtonsManagerLoadData
{
	public WorkshopSlotDataModel WorkshopSlotDataModel;

	public TextMeshProUGUI EssenceSlotTotalDisplayText;

	public GameAssetManagementDomain GameAssetManagementDomain;

	public ServerGameUIDataModel ServerGameUiDataModel;

	public ItemDefinitions ItemDefinitions;

	public List<SlotAssembleButton> ModAssembleButtons;

	public SlotAssembleButton CpuAssemblyButton;

	public SlotAssembleButton PlushAssemblyButton;

	public Button EssenceAssemblyButton;

	public EventExposer EventExposer;
}
