public class WorkshopModifyPageDisplayHandler
{
	private WorkshopModifyPageDisplayHandlerLoadData _data;

	private string _animatronicStatusRecalling;

	private string _animatronicStatusAvailable;

	private string _animatronicStatusUnavailable;

	private string _animatronicStatusScavenging;

	private string _animatronicStatusDelivering;

	private string _animatronicStatusAttacking;

	private string _animatronicStatusBroken;

	private string _mod1String;

	private string _mod2String;

	private string _mod3String;

	private string _mod4String;

	private Localization locOrton;

	public WorkshopModifyPageDisplayHandler(WorkshopModifyPageDisplayHandlerLoadData data)
	{
		_animatronicStatusRecalling = "Recalling";
		_animatronicStatusAvailable = "Available";
		_animatronicStatusUnavailable = "Unavailable";
		_animatronicStatusScavenging = "Scavenging";
		_animatronicStatusDelivering = "Delivering";
		_animatronicStatusAttacking = "Attacking";
		_animatronicStatusBroken = "Broken";
		_mod1String = "MOD 1";
		_mod2String = "MOD 2";
		_mod3String = "MOD 3";
		_mod4String = "MOD 4";
		_data = data;
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(FetchTextLocalization);
		_data.EventExposer.add_WorkshopModifyAssemblyButtonPressed(OnWorkshopModifyAssemblyButtonPressed);
	}

	private void OnWorkshopModifyAssemblyButtonPressed(AssemblyButtonPressedPayload payload)
	{
		if (payload.ButtonType == SlotDisplayButtonType.Mod)
		{
			UpdateModDropDownModDisplayNumber(payload.Index);
		}
	}

	private void UpdateTopBarDisplay()
	{
		WorkshopSlotData selectedSlotData = _data.WorkshopSlotDataModel.GetSelectedSlotData();
		if (selectedSlotData != null)
		{
			EndoskeletonData endoskeleton = selectedSlotData.endoskeleton;
			PlushSuitData plushSuitById = _data.ItemDefinitions.GetPlushSuitById(endoskeleton.plushSuit);
			if (plushSuitById != null && plushSuitById.AnimatronicName != null && locOrton != null)
			{
				_data.TopBarAnimatronicNameText.text = locOrton.GetLocalizedString(plushSuitById.AnimatronicName, _data.TopBarAnimatronicNameText.text);
			}
			if (selectedSlotData.workshopEntry.health == 0)
			{
				_data.TopBarAnimatronicStatusText.text = _animatronicStatusBroken;
				return;
			}
			string text = selectedSlotData.workshopEntry.status switch
			{
				WorkshopEntry.Status.Available => _animatronicStatusAvailable, 
				WorkshopEntry.Status.Scavenging => _animatronicStatusScavenging, 
				WorkshopEntry.Status.Sent => _animatronicStatusDelivering, 
				WorkshopEntry.Status.Returning => _animatronicStatusRecalling, 
				WorkshopEntry.Status.Attacking => _animatronicStatusAttacking, 
				WorkshopEntry.Status.ScavengeAppointment => _animatronicStatusScavenging, 
				WorkshopEntry.Status.LoadScavenging => _animatronicStatusScavenging, 
				_ => _animatronicStatusUnavailable, 
			};
			_data.TopBarAnimatronicStatusText.text = text;
		}
	}

	private void FetchTextLocalization(Localization localization)
	{
		locOrton = localization;
		_animatronicStatusRecalling = localization.GetLocalizedString("ui_workshop_main_page_interface_status_recalling_text", _animatronicStatusRecalling);
		_animatronicStatusAvailable = localization.GetLocalizedString("ui_workshop_main_page_interface_status_available_text", _animatronicStatusAvailable);
		_animatronicStatusUnavailable = localization.GetLocalizedString("ui_workshop_main_page_interface_status_unavailable_text", _animatronicStatusUnavailable);
		_animatronicStatusScavenging = localization.GetLocalizedString("ui_workshop_main_page_interface_status_scavenging_text", _animatronicStatusScavenging);
		_animatronicStatusDelivering = localization.GetLocalizedString("ui_workshop_main_page_interface_status_delivering_text", _animatronicStatusDelivering);
		_animatronicStatusAttacking = localization.GetLocalizedString("ui_workshop_main_page_interface_status_attacking_text", _animatronicStatusAttacking);
		_animatronicStatusBroken = localization.GetLocalizedString("ui_workshop_main_page_interface_status_broken_text", _animatronicStatusBroken);
		_mod1String = localization.GetLocalizedString("ui_workshop_modify_label_mod1", _mod1String);
		_mod2String = localization.GetLocalizedString("ui_workshop_modify_label_mod2", _mod2String);
		_mod3String = localization.GetLocalizedString("ui_workshop_modify_label_mod3", _mod3String);
		_mod4String = localization.GetLocalizedString("ui_workshop_modify_label_mod4", _mod4String);
	}

	private void UpdateModDropDownModDisplayNumber(int index)
	{
		switch (index)
		{
		case 0:
			_data.ModSlotNumberDisplayText.text = _mod1String;
			break;
		case 1:
			_data.ModSlotNumberDisplayText.text = _mod2String;
			break;
		case 2:
			_data.ModSlotNumberDisplayText.text = _mod3String;
			break;
		case 3:
			_data.ModSlotNumberDisplayText.text = _mod4String;
			break;
		}
	}

	public void Update()
	{
		UpdateTopBarDisplay();
	}

	public void OnDestroy()
	{
		_data.EventExposer.remove_WorkshopModifyAssemblyButtonPressed(OnWorkshopModifyAssemblyButtonPressed);
	}
}
