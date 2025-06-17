public class CpuAssemblyButtonHandler
{
	private readonly CpuAssemblyButtonHandlerLoadData _data;

	private bool _dataSet;

	public CpuAssemblyButtonHandler(CpuAssemblyButtonHandlerLoadData data)
	{
		_dataSet = true;
		_data = data;
	}

	public void Update()
	{
		if (_dataSet)
		{
			WorkshopSlotData selectedSlotData = _data.WorkshopSlotDataModel.GetSelectedSlotData();
			if (selectedSlotData != null && selectedSlotData.endoskeleton != null && selectedSlotData.endoskeleton.cpu != null && _data.ItemDefinitions != null && _data.ItemDefinitions.GetCPUById(selectedSlotData.endoskeleton.cpu) != null)
			{
				_data.IconLookup.GetIcon(IconGroup.Cpu, _data.ItemDefinitions.GetCPUById(selectedSlotData.endoskeleton.cpu).CpuIconNameFlat, _data.CpuAssemblyButton.SetSprite);
				SlotAssembleButtonLoadData data = new SlotAssembleButtonLoadData
				{
					SlotType = SlotDisplayButtonType.Cpu,
					SlotState = SlotState.Active
				};
				_data.CpuAssemblyButton.SetData(data);
			}
		}
	}
}
