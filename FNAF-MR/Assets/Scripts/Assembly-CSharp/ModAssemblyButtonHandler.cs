public class ModAssemblyButtonHandler
{
	private const string UnlockLocRef = "ui_workshop_modify_mod_button_max_streak_unlock_format";

	private const string ModLocRef = "ui_workshop_modify_label_mod_format";

	private readonly ModAssemblyButtonHandlerLoadData _data;

	private bool _dataSet;

	public ModAssemblyButtonHandler(ModAssemblyButtonHandlerLoadData data)
	{
		_data = data;
		_dataSet = true;
	}

	public void Update()
	{
		if (!_dataSet)
		{
			return;
		}
		WorkshopSlotData selectedSlotData = _data.WorkshopSlotDataModel.GetSelectedSlotData();
		if (selectedSlotData == null || selectedSlotData.endoskeleton == null)
		{
			return;
		}
		foreach (SlotAssembleButton modAssembleButton in _data.ModAssembleButtons)
		{
			SlotAssembleButtonLoadData data = default(SlotAssembleButtonLoadData);
			int num = _data.ModAssembleButtons.IndexOf(modAssembleButton);
			data.StreakText = string.Format(_data.Localization.GetLocalizedString("ui_workshop_modify_mod_button_max_streak_unlock_format", "ui_workshop_modify_mod_button_max_streak_unlock_format"), "0");
			data.EmptyText = string.Format(_data.Localization.GetLocalizedString("ui_workshop_modify_label_mod_format", "ui_workshop_modify_label_mod_format"), (num + 1).ToString());
			data.LockedText = string.Format(_data.Localization.GetLocalizedString("ui_workshop_modify_label_mod_format", "ui_workshop_modify_label_mod_format"), (num + 1).ToString());
			ModData modById = _data.ItemDefinitions.GetModById(selectedSlotData.endoskeleton.GetModAtIndex(num));
			if (modById != null)
			{
				data.NumStars = modById.Stars;
			}
			else
			{
				data.NumStars = 0;
			}
			data.SlotType = SlotDisplayButtonType.Mod;
			data.SlotState = ((num >= _data.ServerGameUiDataModel.modSlotUnlocks) ? SlotState.Locked : ((modById != null) ? SlotState.Active : SlotState.Empty));
			data.Index = num;
			modAssembleButton.SetData(data);
			if (modById != null)
			{
				_data.IconLookup.GetIcon(IconGroup.Mod, modById.ModIconName, modAssembleButton.SetSprite);
			}
			else
			{
				modAssembleButton.SetSprite(null);
			}
		}
	}
}
