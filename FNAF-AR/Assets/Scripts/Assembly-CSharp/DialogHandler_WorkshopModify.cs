using System;
using PaperPlaneTools;
using UnityEngine;

public class DialogHandler_WorkshopModify : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public Action<ModCell> confirmSellMod;

		public ModCell modCell;

		internal void _003CShowSellModDialog_003Eb__0()
		{
			confirmSellMod(modCell);
		}
	}

	[SerializeField]
	[Header("Dialog GameObjects")]
	private GameObject sellDialog;

	[SerializeField]
	private GameObject moreInfoDialog;

	[SerializeField]
	private SellModDisplayHandler sellModDisplayHandler;

	private IconLookup _iconLookup;

	private Localization _localization;

	private EventExposer _eventExposer;

	private Alert _sellAlert;

	private Alert _moreInfoAlert;

	private string _moreInfoPlushTitle = "What is a Plush Suit?";

	private string _moreInfoCpuTitle = "What is a CPU?";

	private string _moreInfoRemnantTitle;

	private string _moreInfoRemnantMessage;

	private string _moreInfoPlushMessage = "Plush Suit Description Loading";

	private string _moreInfoCpuMessage;

	private string _cancelText;

	private string _confirmText = "Confirm";

	private string _invalidModTitle = "Invalid Mod";

	private string _invalidModMessageText = "Invalid Mod";

	private string _okText = "OK";

	private const string ConfirmText = "ui_workshop_modify_dialogs_confirm";

	private const string CancelText = "ui_workshop_dialogs_cancel";

	private const string InvalidModTitleText = "ui_workshop_modify_dialogs_invalidmod_title";

	private const string InvalidModMessageText = "ui_workshop_modify_dialogs_invalidmod_text";

	private const string OkText = "ui_workshop_modify_dialogs_ok";

	private const string MoreInfoCpuHeader = "ui_workshop_modify_dialog_more_info_cpu_header";

	private const string MoreInfoPlushHeader = "ui_workshop_modify_dialog_more_info_plush_header";

	private const string MoreInfoEssenceHeader = "ui_workshop_modify_dialog_more_info_remnant_header";

	private const string MoreInfoCpuMessage = "ui_workshop_modify_dialog_more_info_cpu_message";

	private const string MoreInfoPlushMessage = "ui_workshop_modify_dialog_more_info_plush_message";

	private const string MoreInfoEssenceMessage = "ui_workshop_modify_dialog_more_info_remnant_message";

	private void FetchLocalization(Localization localization)
	{
		_localization = localization;
		_moreInfoRemnantTitle = localization.GetLocalizedString("ui_workshop_modify_dialog_more_info_remnant_header", _moreInfoRemnantTitle);
		_moreInfoRemnantMessage = localization.GetLocalizedString("ui_workshop_modify_dialog_more_info_remnant_message", _moreInfoRemnantMessage);
		_moreInfoCpuTitle = localization.GetLocalizedString("ui_workshop_modify_dialog_more_info_cpu_header", _moreInfoCpuTitle);
		_moreInfoCpuMessage = localization.GetLocalizedString("ui_workshop_modify_dialog_more_info_cpu_message", _moreInfoCpuMessage);
		_moreInfoPlushTitle = localization.GetLocalizedString("ui_workshop_modify_dialog_more_info_plush_header", _moreInfoPlushTitle);
		_moreInfoPlushMessage = localization.GetLocalizedString("ui_workshop_modify_dialog_more_info_plush_message", _moreInfoPlushMessage);
		_cancelText = _localization.GetLocalizedString("ui_workshop_dialogs_cancel", "ui_workshop_dialogs_cancel");
		_confirmText = _localization.GetLocalizedString("ui_workshop_modify_dialogs_confirm", "ui_workshop_modify_dialogs_confirm");
		_invalidModTitle = _localization.GetLocalizedString("ui_workshop_modify_dialogs_invalidmod_title", "ui_workshop_modify_dialogs_invalidmod_title");
		_invalidModMessageText = _localization.GetLocalizedString("ui_workshop_modify_dialogs_invalidmod_text", "ui_workshop_modify_dialogs_invalidmod_text");
		_okText = _localization.GetLocalizedString("ui_workshop_modify_dialogs_ok", "ui_workshop_modify_dialogs_ok");
	}

	private void ShowMoreInfo(string title, string message)
	{
		_moreInfoAlert.SetTitle(title);
		_moreInfoAlert.SetMessage(message);
		AlertUtilities.ShowAlertWithAndroidBackButtonAction(_moreInfoAlert, _moreInfoAlert.Dismiss);
	}

	public void ShowSellModDialog(ModCell modCell, Action<ModCell> confirmSellMod)
	{
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
		_003C_003Ec__DisplayClass32_.modCell = modCell;
		_003C_003Ec__DisplayClass32_.confirmSellMod = confirmSellMod;
		sellModDisplayHandler.SetData(modCell);
		_iconLookup.GetIcon(IconGroup.Mod, modCell.modContext.Mod.ModIconRenderedName, sellModDisplayHandler.SetSprite);
		_sellAlert.SetPositiveButton(_confirmText, _003C_003Ec__DisplayClass32_._003CShowSellModDialog_003Eb__0);
		_sellAlert.SetNegativeButton(_cancelText);
		AlertUtilities.ShowAlertWithAndroidBackButtonAction(_sellAlert, _sellAlert.Dismiss);
	}

	public void ShowMoreInfoCpuDialog()
	{
		ShowMoreInfo(_moreInfoCpuTitle, _moreInfoCpuMessage);
	}

	public void ShowMoreInfoPlushDialog()
	{
		ShowMoreInfo(_moreInfoPlushTitle, _moreInfoPlushMessage);
	}

	public void ShowMoreInfoRemnantDialog()
	{
		ShowMoreInfo(_moreInfoRemnantTitle, _moreInfoRemnantMessage);
	}

	public void ShowInvalidModCategory()
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = _invalidModTitle;
		genericDialogData.message = _invalidModMessageText;
		genericDialogData.positiveButtonText = _okText;
		_eventExposer.GenericDialogRequest(genericDialogData);
	}

	private void Start()
	{
		_sellAlert = new Alert();
		_moreInfoAlert = new Alert();
		_sellAlert.SetAdapter(sellDialog.GetComponent<IAlertPlatformAdapter>());
		_moreInfoAlert.SetAdapter(moreInfoDialog.GetComponent<IAlertPlatformAdapter>());
		Debug.LogWarning("Adapter set!");
		MasterDomain domain = MasterDomain.GetDomain();
		_eventExposer = domain.eventExposer;
		domain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(IconCacheReady);
		FetchLocalization(domain.LocalizationDomain.Localization);
	}

	private void IconCacheReady(IconLookup obj)
	{
		_iconLookup = obj;
	}

	private void OnDestroy()
	{
		if (_sellAlert != null)
		{
			_sellAlert.Dismiss();
		}
		if (_moreInfoAlert != null)
		{
			_moreInfoAlert.Dismiss();
		}
		_sellAlert = null;
		_moreInfoAlert = null;
	}
}
