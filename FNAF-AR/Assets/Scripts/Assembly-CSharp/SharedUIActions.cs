using UnityEngine;

public class SharedUIActions : MonoBehaviour
{
	[SerializeField]
	private SharedUIView sharedUIView;

	[SerializeField]
	private DialogHandler_Shared dialogHandler_Shared;

	private TheGameDomain _theGameDomain;

	private EventExposer _eventExposer;

	private AttackSequenceDomain _attackSequenceDomain;

	private WorkshopSlotDataModel _workshopSlotDataModel;

	private Localization _localization;

	private LootDomain _lootDomain;

	private const string CameraSureTitleId = "ui_camera_leave_confirm_title";

	private const string CameraSureMsgId = "ui_camera_leave_confirm_message";

	private const string CameraLeaveId = "ui_camera_leave_confirm_yes_button";

	private const string CameraStayId = "ui_camera_leave_confirm_no_button";

	private const string CameraSureTitle = "Encounter In Progress";

	private const string CameraSureMsg = "Are you sure you want to leave Camera Mode? You will lose this encounter";

	private const string CameraLeave = "Leave";

	private const string CameraStay = "Stay";

	private const string CameraEncounterTitleId = "ui_camera_leave_encounter_title";

	private const string CameraEncounterBody1Id = "ui_camera_leave_encounter_body1_text";

	private const string CameraEncounterBody2Id = "ui_camera_leave_encounter_body2_text";

	private const string CameraJammerId = "map_interaction_button_1";

	private const string CameraEncounterTitle = "ENCOUNTER IN PROGRESS";

	private const string CameraEncounterBody1 = "Use a Jammer to protect your streak";

	private const string CameraEncounterBody2 = "Leaving the Encounter will result in a loss";

	private const string CameraJammer = "Jammer";

	private void GoToCamera()
	{
		_attackSequenceDomain.IsInEncounter();
		_theGameDomain.gameDisplayChanger.RequestDisplayChange(GameDisplayData.DisplayType.camera);
	}

	private void TryToGoToMap()
	{
		if (IsAllowedToLeaveCurrentMode())
		{
			GoToMap();
		}
		else
		{
			AskForPermissionToLeaveCurrentMode();
		}
	}

	private void GoToMap()
	{
		_theGameDomain.gameDisplayChanger.RequestDisplayChange(GameDisplayData.DisplayType.map);
	}

	private bool IsAllowedToLeaveCurrentMode()
	{
		_theGameDomain.gameDisplayChanger.GetDisplayType();
		_ = 1;
		return false;
	}

	private void AskForPermissionToLeaveCurrentMode()
	{
		if (_theGameDomain.gameDisplayChanger.GetDisplayType() == GameDisplayData.DisplayType.camera || _theGameDomain.gameDisplayChanger.GetDisplayType() == GameDisplayData.DisplayType.scavengingui)
		{
			AskForPermissionToLeaveCamera();
		}
	}

	private void AskForPermissionToLeaveCamera()
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = _localization.GetLocalizedString("ui_camera_leave_confirm_title", "Encounter In Progress");
		genericDialogData.message = _localization.GetLocalizedString("ui_camera_leave_confirm_message", "Are you sure you want to leave Camera Mode? You will lose this encounter");
		genericDialogData.positiveButtonText = _localization.GetLocalizedString("ui_camera_leave_confirm_yes_button", "Leave");
		genericDialogData.positiveButtonAction = LeaveCameraConfirm;
		genericDialogData.negativeButtonText = _localization.GetLocalizedString("ui_camera_leave_confirm_no_button", "Stay");
		genericDialogData.negativeButtonAction = LeaveCameraCancel;
		dialogHandler_Shared.ShowGenericDialog(genericDialogData);
	}

	private void LeaveCameraConfirm()
	{
		GoToMap();
	}

	private void LeaveCameraCancel()
	{
	}

	private string GetExitEncounterBodyText(bool hasEnoughCurrency)
	{
		if (!hasEnoughCurrency)
		{
			return _localization.GetLocalizedString("ui_camera_leave_encounter_body2_text", "Leaving the Encounter will result in a loss");
		}
		return _localization.GetLocalizedString("ui_camera_leave_encounter_body1_text", "Use a Jammer to protect your streak");
	}

	public void SetCameraMainDisplay()
	{
		GoToCamera();
	}

	public void SetMapMainDisplay()
	{
		Awakeb__45_0(LocalizationDomain.Instance.Localization);
		if (MasterDomain.GetDomain().AttackSequenceDomain.IsInEncounter())
		{
			PopUpAttackSequenceExitDialog();
		}
		else
		{
			TryToGoToMap();
		}
	}

	public void PopUpAttackSequenceExitDialog()
	{
		ExitAttackSequenceDialogData data = new ExitAttackSequenceDialogData
		{
			titleText = _localization.GetLocalizedString("ui_camera_leave_encounter_title", "ENCOUNTER IN PROGRESS"),
			bodyText = GetExitEncounterBodyText(sharedUIView.ShouldJammerBeInteractable()),
			stayButtonText = _localization.GetLocalizedString("ui_camera_leave_confirm_no_button", "Stay"),
			leaveButtonText = _localization.GetLocalizedString("ui_camera_leave_confirm_yes_button", "Leave"),
			shouldJammerBeInteractable = sharedUIView.ShouldJammerBeInteractable(),
			jammerButtonText = _localization.GetLocalizedString("map_interaction_button_1", "Jammer"),
			jammerButtonCost = sharedUIView.GetJammerCost(),
			jammerCallback = OnJammerClicked,
			leaveCallback = OnLeaveClicked
		};
		MasterDomain.GetDomain().eventExposer.OnExitAttackSequenceReceived(data);
	}

	public void OnJammerClicked()
	{
		Debug.Log("JammerClicked!");
		if (sharedUIView.OnJammerClicked())
		{
			if (_attackSequenceDomain != null)
			{
				_attackSequenceDomain.UsedJammer();
			}
			GoToMap();
		}
	}

	private void OnLeaveClicked()
	{
		Debug.Log("LeaveClicked!");
		if (_attackSequenceDomain != null)
		{
			_attackSequenceDomain.LeaveEncounter();
		}
	}

	public void ClosePopDown()
	{
		sharedUIView.ClosePopDown();
	}

	private void Awake()
	{
		MasterDomain domain = MasterDomain.GetDomain();
		_theGameDomain = domain.TheGameDomain;
		_eventExposer = domain.eventExposer;
		_attackSequenceDomain = domain.AttackSequenceDomain;
		Awakeb__45_0(LocalizationDomain.Instance.Localization);
		_workshopSlotDataModel = domain.GameUIDomain.GameUIData.workshopSlotDataModel;
		_lootDomain = domain.LootDomain;
		RegisterEvents();
	}

	private void OnDestroy()
	{
		UnregisterEvents();
	}

	private void RegisterEvents()
	{
	}

	private void UnregisterEvents()
	{
	}

	private void RestartPhotoBoothEventHandler()
	{
	}

	private void Awakeb__45_0(Localization localization)
	{
		_localization = localization;
	}
}
