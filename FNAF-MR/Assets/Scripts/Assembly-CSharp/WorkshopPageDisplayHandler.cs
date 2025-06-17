public class WorkshopPageDisplayHandler
{
	private const int WORN_OUT = 0;

	private const int FULL_HEALTH = 100;

	private WorkshopPageHandlerData _data;

	private string _recallButtonName;

	private string _deployButtonName;

	private string _brokenButtonName;

	private string _animatronicStatus_Recalling;

	private string _animatronicStatus_Available;

	private string _animatronicStatus_Scavenging;

	private string _animatronicStatus_Delivering;

	private string _animatronicStatus_Attacking;

	private string _animatronicStatus_Broken;

	private Localization theLocalization;

	public WorkshopPageDisplayHandler(WorkshopPageHandlerData data)
	{
		_recallButtonName = "RECALL";
		_deployButtonName = "DEPLOY";
		_brokenButtonName = "BROKEN";
		_animatronicStatus_Recalling = "Recalling";
		_animatronicStatus_Available = "Available";
		_animatronicStatus_Scavenging = "Scavenging";
		_animatronicStatus_Delivering = "Delivering";
		_animatronicStatus_Attacking = "Attacking";
		_animatronicStatus_Broken = "Broken";
		_data = data;
		_data.eventExposer.add_EntityAddedEvent(EventExposer_OnEntityAddedEvent);
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(LocalizationReady);
	}

	private void LocalizationReady(Localization localization)
	{
		_brokenButtonName = localization.GetLocalizedString("ui_workshop_main_page_interface_broken_button_text", _brokenButtonName);
		_recallButtonName = localization.GetLocalizedString("ui_workshop_main_page_interface_recall_button_text", _recallButtonName);
		_deployButtonName = localization.GetLocalizedString("ui_workshop_main_page_interface_deploy_button_text", _deployButtonName);
		_animatronicStatus_Recalling = localization.GetLocalizedString("ui_workshop_main_page_interface_status_recalling_text", _animatronicStatus_Recalling);
		_animatronicStatus_Available = localization.GetLocalizedString("ui_workshop_main_page_interface_status_available_text", _animatronicStatus_Available);
		_animatronicStatus_Scavenging = localization.GetLocalizedString("ui_workshop_main_page_interface_status_scavenging_text", _animatronicStatus_Scavenging);
		_animatronicStatus_Delivering = localization.GetLocalizedString("ui_workshop_main_page_interface_status_delivering_text", _animatronicStatus_Delivering);
		_animatronicStatus_Attacking = localization.GetLocalizedString("ui_workshop_main_page_interface_status_attacking_text", _animatronicStatus_Attacking);
		_animatronicStatus_Broken = localization.GetLocalizedString("ui_workshop_main_page_interface_status_broken_text", _animatronicStatus_Broken);
		theLocalization = localization;
		UpdateScreenState();
	}

	private void EventExposer_OnEntityAddedEvent(Container.EntityAddedRemovedArgs e)
	{
		UpdateScreenState();
	}

	private void EventExposer_OnEntityStateChangedEvent(StateChooser.EntityStateChangedArgs e)
	{
		UpdateScreenState();
	}

	private void UpdateAnimatronicWearAndTearPanelText()
	{
		_data.conditionWordDisplay.SetActive(_data.workshopSlotDataModel.WorkshopSlotDatas != null);
		if (_data.workshopSlotDataModel.WorkshopSlotDatas != null)
		{
			string text = _data.workshopSlotDataModel.GetSelectedSlotData().workshopEntry.health + "%";
			if (_data.wearTearPercentText != null)
			{
				_data.wearTearPercentText.text = text;
			}
		}
	}

	private void UpdateAnimatronicSelectedNameDisplayText()
	{
		PlushSuitData plushSuitById = _data.itemDefinitions.GetPlushSuitById(_data.workshopSlotDataModel.GetSelectedSlotData().endoskeleton.plushSuit);
		if (plushSuitById != null && !string.IsNullOrEmpty(plushSuitById.AnimatronicName))
		{
			if (theLocalization == null)
			{
				_data.animatronicNameDisplay.text = plushSuitById.AnimatronicName;
			}
			else
			{
				_data.animatronicNameDisplay.text = theLocalization.GetLocalizedString(plushSuitById.AnimatronicName, "ANIMATRONIC NAME");
			}
		}
		else
		{
			_data.animatronicNameDisplay.text = "ANIMATRONIC NAME";
		}
	}

	private void UpdateActionButtons()
	{
		if (_data.workshopSlotDataModel.WorkshopSlotDatas == null)
		{
			_data.modifyButton.interactable = false;
			_data.wearTearButton.interactable = false;
			_data.deployButton.interactable = false;
		}
		else if (_data.workshopSlotDataModel.GetSelectedSlotData() != null && _data.workshopSlotDataModel.GetSelectedSlotData().workshopEntry != null)
		{
			_data.modifyButton.interactable = _data.workshopSlotDataModel.GetSelectedSlotData().workshopEntry.health != 0 && _data.workshopSlotDataModel.GetSelectedSlotDataStatus() == WorkshopEntry.Status.Available;
			_data.wearTearButton.interactable = _data.workshopSlotDataModel.GetSelectedSlotData().workshopEntry.health != 100;
			_data.deployButton.interactable = _data.workshopSlotDataModel.GetSelectedSlotDataStatus() != WorkshopEntry.Status.Returning && _data.workshopSlotDataModel.GetSelectedSlotData().workshopEntry.health != 0;
			if (_data.workshopSlotDataModel.GetSelectedSlotData().workshopEntry.health == 0)
			{
				_data.deployButtonText.text = _brokenButtonName;
			}
			else
			{
				_data.deployButtonText.text = ((_data.workshopSlotDataModel.GetSelectedSlotDataStatus() == WorkshopEntry.Status.Available) ? _deployButtonName : _recallButtonName);
			}
		}
	}

	private void UpdateAvailableDisplayText()
	{
		string text = " ";
		if (_data.workshopSlotDataModel.GetSelectedSlotData().workshopEntry.health <= 0)
		{
			text = _animatronicStatus_Broken;
			_data.availableText.text = text;
			return;
		}
		text = _data.workshopSlotDataModel.GetSelectedSlotDataStatus() switch
		{
			WorkshopEntry.Status.Available => _animatronicStatus_Available, 
			WorkshopEntry.Status.Scavenging => _animatronicStatus_Scavenging, 
			WorkshopEntry.Status.Sent => _animatronicStatus_Delivering, 
			WorkshopEntry.Status.Returning => _animatronicStatus_Recalling, 
			WorkshopEntry.Status.Attacking => _animatronicStatus_Attacking, 
			WorkshopEntry.Status.ScavengeAppointment => _animatronicStatus_Scavenging, 
			WorkshopEntry.Status.LoadScavenging => _animatronicStatus_Scavenging, 
			_ => _animatronicStatus_Delivering, 
		};
		_data.availableText.text = text;
	}

	private void UpdateScreenState()
	{
		UpdateActionButtons();
		UpdateAvailableDisplayText();
		UpdateAnimatronicSelectedNameDisplayText();
		UpdateAnimatronicWearAndTearPanelText();
	}

	public void Update()
	{
		UpdateScreenState();
	}

	public void OnDestroy()
	{
		_data.eventExposer.remove_EntityAddedEvent(EventExposer_OnEntityAddedEvent);
	}
}
