using UnityEngine;

public class WorkshopStateUIActions : MonoBehaviour
{
	public const string LOC_MAX_SCAVENGERS = "ui_workshop_too_many_scavengers";

	[SerializeField]
	private GameObject buttonPanel;

	[SerializeField]
	private DialogHandler_Workshop dialogHandler_Workshop;

	[SerializeField]
	private WorkshopStateUIView workshopStateUIView;

	private MasterDomain _masterDomain;

	private WorkshopSlotDataModel workshopSlotDataModel;

	private int _maxScavengers;

	private void RecallScavengingAnimatronic()
	{
		if (workshopSlotDataModel.GetSelectedSlotData() != null && workshopSlotDataModel.GetSelectedSlotData().workshopEntry != null && !string.IsNullOrWhiteSpace(workshopSlotDataModel.GetSelectedSlotData().workshopEntry.entityId) && workshopSlotDataModel.GetSelectedSlotData().workshopEntry.status == WorkshopEntry.Status.ScavengeAppointment)
		{
			workshopStateUIView.OverrideWorkshopSlotDataState(workshopSlotDataModel.GetSelectedSlotData(), WorkshopEntry.Status.Available);
		}
		_masterDomain.eventExposer.OnRecallButtonTapped();
	}

	private void RecallAttackingAnimatronic()
	{
		if (workshopSlotDataModel.GetSelectedSlotData().workshopEntry != null && !string.IsNullOrWhiteSpace(workshopSlotDataModel.GetSelectedSlotData().workshopEntry.entityId))
		{
			workshopStateUIView.OverrideWorkshopSlotDataState(workshopSlotDataModel.GetSelectedSlotData(), WorkshopEntry.Status.Returning);
			_masterDomain.ServerDomain.recallAttackingAnimatronicRequester.RecallAnimatronicAttack(workshopSlotDataModel.GetSelectedSlotDataIndex());
		}
		_masterDomain.eventExposer.OnRecallButtonTapped();
	}

	private void SendAnimatronic(string userId)
	{
		WorkshopSlotDataModel workshopSlotDataModel = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel;
		workshopStateUIView.OverrideWorkshopSlotDataState(workshopSlotDataModel.GetSelectedSlotData(), WorkshopEntry.Status.Sent);
		SendAnimatronicV2Params sendAnimatronicV2Params = new SendAnimatronicV2Params();
		sendAnimatronicV2Params.slotId = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel.GetSelectedSlotDataIndex();
		sendAnimatronicV2Params.userId = userId;
		_masterDomain.ServerDomain.sendAnimatronicV2Requester.SendAnimatronic(sendAnimatronicV2Params, new SendAnimatronicV2Callbacks(SendAnimatronicSuccess, SendAnimatronicFailed));
		_ = workshopSlotDataModel.GetSelectedSlotData().endoskeleton;
	}

	private void SendAnimatronicSuccess(SendAnimatronicV2ResponseData obj)
	{
		dialogHandler_Workshop.DismissSendSelect();
		workshopStateUIView.ReenableSendSelect();
	}

	private void SendAnimatronicFailed(string obj)
	{
		dialogHandler_Workshop.DismissSendSelect();
		workshopStateUIView.ReenableSendSelect();
	}

	private void OrderRepair()
	{
	}

	private void CheckIfHasEnoughParts(int cost, int parts)
	{
		if (cost > parts)
		{
			dialogHandler_Workshop.ShowRepairError();
		}
	}

	private bool MaxScavengersDeployed()
	{
		return _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel.NumScavengers() >= _maxScavengers;
	}

	private void OnConfigDataLoaded(CONFIG_DATA.Root configDataEntry)
	{
		_maxScavengers = configDataEntry.Entries[0].Scavenging.MaxDeployed;
	}

	public void ShowSendSelectDialog()
	{
		switch (_masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel.GetSelectedSlotData().workshopEntry.status)
		{
		case WorkshopEntry.Status.Attacking:
			RecallAttackingAnimatronic();
			break;
		case WorkshopEntry.Status.Scavenging:
			ShowRecallConfirmDialog();
			break;
		default:
			workshopStateUIView.SetupSendSelectDialog(SendSelectedSlotToUserId);
			dialogHandler_Workshop.ShowSendSelect();
			break;
		}
	}

	public void ShowRepairConfirmation()
	{
		Debug.LogError("repair button hit!");
		dialogHandler_Workshop.ShowRepairConfirm();
	}

	public void SelectDeployButton()
	{
		Debug.LogError("deploy button hit!");
		switch (_masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel.GetSelectedSlotData().workshopEntry.status)
		{
		case WorkshopEntry.Status.Attacking:
			RecallAttackingAnimatronic();
			break;
		case WorkshopEntry.Status.Scavenging:
			ShowRecallConfirmDialog();
			break;
		default:
			CustomDeployStart();
			break;
		}
	}

	private void ShowRecallConfirmDialog()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(ShowRecallConfirmDialogb__19_0);
	}

	private void ShowRecallConfirmDialogb__19_0(Localization localization)
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		_ = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel.GetSelectedSlotData().workshopEntry.status;
		genericDialogData.title = localization.GetLocalizedString("ui_scavenge_recall_title", "RECALL ANIMATRONIC?");
		genericDialogData.message = localization.GetLocalizedString("ui_scavenge_recall_message", "Rewards will be lost!");
		genericDialogData.negativeButtonText = localization.GetLocalizedString("ui_scavenge_recall_cancel", "CANCEL");
		genericDialogData.positiveButtonText = localization.GetLocalizedString("ui_scavenge_recall_confirm", "CONFIRM");
		genericDialogData.positiveButtonAction = RecallScavengingAnimatronic;
		_masterDomain.eventExposer.GenericDialogRequest(genericDialogData);
	}

	private void CustomDeployStart()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(ShowDeployDialog);
	}

	private void ShowDeployDialog(Localization localization)
	{
		WorkshopSlotDataModel workshopSlotDataModel = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel;
		string id = ((workshopSlotDataModel.GetSelectedSlotData() == null || workshopSlotDataModel.GetSelectedSlotData().endoskeleton == null) ? null : workshopSlotDataModel.GetSelectedSlotData().endoskeleton.plushSuit);
		PlushSuitData plushSuitById = _masterDomain.ItemDefinitionDomain.ItemDefinitions.GetPlushSuitById(id);
		string displayName = ((plushSuitById == null) ? null : localization.GetLocalizedString(plushSuitById.AnimatronicName, plushSuitById.AnimatronicName));
		dialogHandler_Workshop.ShowDeploySelectionDialog(displayName);
	}

	public void OrderSelectedScavenge(string id)
	{
		if (MaxScavengersDeployed())
		{
			ShowMaxScavengingDialog();
		}
		else
		{
			SendScavenging(id);
		}
	}

	private void SendScavenging(string id)
	{
		WorkshopSlotDataModel workshopSlotDataModel = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel;
		workshopStateUIView.OverrideWorkshopSlotDataState(workshopSlotDataModel.GetSelectedSlotData(), WorkshopEntry.Status.LoadScavenging);
		_ = workshopSlotDataModel.GetSelectedSlotData().endoskeleton;
	}

	private void ShowMaxScavengingDialog()
	{
		dialogHandler_Workshop.ShowErrorDialog(LocalizationDomain.Instance.ILocalization.GetLocalizedString("ui_workshop_too_many_scavengers", "ui_workshop_too_many_scavengers"));
	}

	public void PurchaseRepair()
	{
		OrderRepair();
	}

	public void SendSelectedSlotToUserId(string userId)
	{
		SendAnimatronic(userId);
	}

	private void Start()
	{
		_masterDomain = MasterDomain.GetDomain();
		_masterDomain.MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(OnConfigDataLoaded);
		workshopSlotDataModel = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel;
	}

	private void RepairSuccess(WorkshopData obj)
	{
		_masterDomain.eventExposer.OnWorkshopRepairSuccess();
		RemoveCallbacks();
	}

	private void RepairFailure()
	{
		RemoveCallbacks();
	}

	private void RemoveCallbacks()
	{
		_masterDomain.eventExposer.remove_WorkshopDataV2Updated(RepairSuccess);
	}
}
