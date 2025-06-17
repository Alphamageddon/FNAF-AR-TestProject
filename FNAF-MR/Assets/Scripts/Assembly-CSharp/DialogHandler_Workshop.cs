using PaperPlaneTools;
using UnityEngine;

public class DialogHandler_Workshop : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public string error;

		public DialogHandler_Workshop __this;

		internal void _003CShowErrorDialog_003Eb__0(Localization localization)
		{
		}
	}

	[SerializeField]
	[Header("Hookups")]
	private WorkshopStateUIActions _workshopStateUIActions;

	[SerializeField]
	[Header("Dialog GameObjects")]
	private GameObject _sendSelectDialog;

	[SerializeField]
	private GameObject _deploySelectionDialog;

	[SerializeField]
	private GameObject _scavengeTimeSelectDialog;

	private MasterDomain _masterDomain;

	private EventExposer _eventExposer;

	private WorkshopSlotDataModel _workshopSlotDataModel;

	private ItemDefinitions _itemDefinitions;

	private Alert _sendSelectAlert;

	private Alert _deploySelectionAlert;

	private Alert _scavengeTimeSelectAlert;

	private const string CANCEL_TEXT = "ui_workshop_dialogs_cancel";

	private const string CONFIRM_TEXT = "ui_workshop_dialogs_confirm";

	private const string SELECT_TEXT = "ui_workshop_dialogs_select";

	private const string OK_TEXT = "ui_workshop_dialogs_ok";

	private const string SEND_TEXT = "ui_workshop_dialogs_send";

	private const string SCAVENGE_TEXT = "ui_workshop_dialogs_salvage";

	private const string REPAIR_TITLE_TEXT = "ui_workshop_dialogs_repair_title";

	private const string REPAIR_PREFIX_TEXT = "ui_workshop_dialogs_repair_prefix";

	private const string REPAIR_POSTFIX_TEXT = "ui_workshop_dialogs_repair_postfix";

	private const string GEN_ERROR_TITLE = "ui_generic_title";

	private const string GENERIC_OK = "ui_generic_ok";

	private const string GEN_ERROR_BUTTON_TEXT = "ui_generic_error_dialog_button_text";

	private const string REPAIR_ERROR_TITLE = "ui_workshop_repair_not_enough_title";

	private const string REPAIR_ERROR_TEXT = "ui_workshop_repair_not_enough_text";

	private void ShowScavengeTimeSelectDialog()
	{
		_scavengeTimeSelectAlert.Show();
	}

	public void ShowErrorDialog(string error)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_.error = error;
		_003C_003Ec__DisplayClass28_.__this = this;
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(_003C_003Ec__DisplayClass28_._003CShowErrorDialog_003Eb__0);
	}

	public void ShowRepairError()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(ShowRepairErrorb__29_0);
	}

	private void ShowRepairErrorb__29_0(Localization localization)
	{
		string localizedString = localization.GetLocalizedString("ui_workshop_repair_not_enough_text", "ui_workshop_repair_not_enough_text");
		string localizedString2 = localization.GetLocalizedString("ui_workshop_repair_not_enough_title", "ui_workshop_repair_not_enough_title");
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = localizedString2;
		genericDialogData.message = localizedString;
		genericDialogData.negativeButtonText = localization.GetLocalizedString("ui_generic_ok", "ui_generic_ok");
		_eventExposer.GenericDialogRequest(genericDialogData);
	}

	public void ShowRepairConfirm()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(ShowRepairConfirmb__30_0);
	}

	private void ShowRepairConfirmb__30_0(Localization localization)
	{
		Debug.LogError("repair has loc!");
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = localization.GetLocalizedString("ui_workshop_dialogs_repair_title", "ui_workshop_dialogs_repair_title");
		genericDialogData.message = localization.GetLocalizedString("ui_workshop_dialogs_repair_prefix", "ui_workshop_dialogs_repair_prefix") + "48" + localization.GetLocalizedString("ui_workshop_dialogs_repair_postfix", "ui_workshop_dialogs_repair_postfix");
		genericDialogData.positiveButtonText = localization.GetLocalizedString("ui_workshop_dialogs_confirm", "ui_workshop_dialogs_confirm");
		genericDialogData.positiveButtonAction = _workshopStateUIActions.PurchaseRepair;
		genericDialogData.negativeButtonText = localization.GetLocalizedString("ui_workshop_dialogs_cancel", "ui_workshop_dialogs_cancel");
		_eventExposer.GenericDialogRequest(genericDialogData);
	}

	public void ShowDeploySelectionDialog(string displayName)
	{
		_deploySelectionAlert.SetTitle(displayName);
		_deploySelectionAlert.Show();
	}

	public void DismissSendSelect()
	{
		_sendSelectAlert.Dismiss();
	}

	public void ShowSendSelect()
	{
		_sendSelectAlert.Show();
	}

	public void SelectScavengeTimeCell(string id)
	{
		_workshopStateUIActions.OrderSelectedScavenge(id);
		_scavengeTimeSelectAlert.Dismiss();
	}

	private void Start()
	{
		_masterDomain = MasterDomain.GetDomain();
		_eventExposer = _masterDomain.eventExposer;
		_workshopSlotDataModel = _masterDomain.GameUIDomain.GameUIData.workshopSlotDataModel;
		_itemDefinitions = _masterDomain.ItemDefinitionDomain.ItemDefinitions;
		_sendSelectAlert.SetAdapter(_sendSelectDialog.GetComponent<IAlertPlatformAdapter>());
		_sendSelectAlert.SetNegativeButton(null);
		_deploySelectionAlert.SetAdapter(_deploySelectionDialog.GetComponent<IAlertPlatformAdapter>());
		_deploySelectionAlert.SetNegativeButton(null);
		_scavengeTimeSelectAlert.SetAdapter(_scavengeTimeSelectDialog.GetComponent<IAlertPlatformAdapter>());
		_scavengeTimeSelectAlert.SetNegativeButton(null);
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(Startb__35_0);
	}

	private void Startb__35_0(Localization localization)
	{
		localization.GetLocalizedString("ui_workshop_dialogs_ok", "ui_workshop_dialogs_ok");
		localization.GetLocalizedString("ui_workshop_dialogs_cancel", "ui_workshop_dialogs_cancel");
		localization.GetLocalizedString("ui_workshop_dialogs_confirm", "ui_workshop_dialogs_confirm");
		localization.GetLocalizedString("ui_workshop_dialogs_select", "ui_workshop_dialogs_select");
		localization.GetLocalizedString("ui_workshop_dialogs_confirm", "ui_workshop_dialogs_confirm");
		_deploySelectionAlert.SetPositiveButton(localization.GetLocalizedString("ui_workshop_dialogs_send", "ui_workshop_dialogs_send"), _workshopStateUIActions.ShowSendSelectDialog);
		_deploySelectionAlert.SetNeutralButton(localization.GetLocalizedString("ui_workshop_dialogs_salvage", "ui_workshop_dialogs_salvage"), ShowScavengeTimeSelectDialog);
	}

	private void OnDestroy()
	{
		if (_sendSelectAlert != null)
		{
			_sendSelectAlert.Dismiss();
		}
		if (_deploySelectionAlert != null)
		{
			_deploySelectionAlert.Dismiss();
		}
		if (_scavengeTimeSelectAlert != null)
		{
			_scavengeTimeSelectAlert.Dismiss();
		}
		_masterDomain = null;
		_deploySelectionAlert = null;
		_scavengeTimeSelectAlert = null;
		_sendSelectAlert = null;
	}

	public DialogHandler_Workshop()
	{
		_sendSelectAlert = new Alert();
		_deploySelectionAlert = new Alert();
		_scavengeTimeSelectAlert = new Alert();
	}
}
