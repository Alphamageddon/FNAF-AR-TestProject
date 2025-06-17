public class PlushSuitAssemblyButtonHandler
{
	private readonly PlushSuitAssemblyButtonHandlerLoadData _data;

	private bool _dataSet;

	public PlushSuitAssemblyButtonHandler(PlushSuitAssemblyButtonHandlerLoadData data)
	{
		_dataSet = true;
		_data = data;
	}

	public void Update()
	{
		if (_dataSet && _data.WorkshopSlotDataModel != null)
		{
			WorkshopSlotData selectedSlotData = _data.WorkshopSlotDataModel.GetSelectedSlotData();
			if (selectedSlotData.endoskeleton != null && _data.ItemDefinitions.GetPlushSuitById(selectedSlotData.endoskeleton.plushSuit) != null)
			{
				_data.IconLookup.GetIcon(IconGroup.PlushSuit, _data.ItemDefinitions.GetPlushSuitById(selectedSlotData.endoskeleton.plushSuit).PortraitIconFlatName, _data.PlushAssemblyButton.SetSprite);
				SlotAssembleButtonLoadData data = new SlotAssembleButtonLoadData
				{
					SlotType = SlotDisplayButtonType.Plushsuit,
					SlotState = SlotState.Active
				};
				_data.PlushAssemblyButton.SetData(data);
			}
		}
	}
}
