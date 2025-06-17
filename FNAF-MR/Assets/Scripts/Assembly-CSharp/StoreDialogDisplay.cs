using UnityEngine;

public class StoreDialogDisplay
{
	private const string KEY_PURCHASE_SUCCESS_TITLE = "ui_store_purchase_thank_you_title";

	private const string KEY_PURCHASE_SUCCESS_MESSAGE = "ui_store_purchase_thank_you_message";

	private const string KEY_PURCHASE_SUCCESS_POSITIVE_BUTTON = "ui_store_purchase_thank_you_button_text";

	private const string KEY_PURCHASE_DISABLED_TITLE = "store_disable_IAP_dialog_heading";

	private const string KEY_PURCHASE_DISABLED_MESSAGE = "store_disabled_IAP_dialog_body";

	private const string KEY_PURCHASE_DISABLED_POSITIVE_BUTTON = "ui_generic_ok";

	private const string KEY_PURCHASE_INFLIGHT_TITLE = "store_disable_IAP_dialog_heading";

	private const string KEY_PURCHASE_INFLIGHT_MESSAGE = "store_disabled_IAP_dialog_body";

	private const string KEY_PURCHASE_INFLIGHT_POSITIVE_BUTTON = "ui_generic_ok";

	private const string KEY_STORE_LOAD_ERROR_TITLE = "ui_dialog_seasonal_restart_title";

	private const string KEY_STORE_LOAD_ERROR_MESSAGE = "ui_dialog_seasonal_restart_text";

	private const string KEY_STORE_LOAD_ERROR_BUTTON = "ui_generic_ok";

	private EventExposer _eventExposer;

	public StoreDialogDisplay(EventExposer eventExposer)
	{
		_eventExposer = eventExposer;
	}

	public void GeneratePurchaseDisabledDialog()
	{
		GeneratePurchaseDisabledDialogb__14_0(LocalizationDomain.Instance.Localization);
	}

	public void GeneratePurchaseSuccessDialog()
	{
		GeneratePurchaseSuccessDialogb__15_0(LocalizationDomain.Instance.Localization);
	}

	public void GenerateInFlightPurchaseDialog()
	{
		GenerateInFlightPurchaseDialogb__16_0(LocalizationDomain.Instance.Localization);
	}

	public void GenerateStoreLoadErrorDialog()
	{
		GenerateStoreLoadErrorDialogb__17_0(LocalizationDomain.Instance.Localization);
	}

	private void TriggerRestart()
	{
		Application.Quit();
	}

	private void GeneratePurchaseDisabledDialogb__14_0(Localization localization)
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = localization.GetLocalizedString("store_disable_IAP_dialog_heading", "In-app Purchases Disabled");
		genericDialogData.message = localization.GetLocalizedString("store_disabled_IAP_dialog_body", "In-app purchases have been disabled in your device settings. Please enable them to allow purchases.");
		genericDialogData.negativeButtonText = localization.GetLocalizedString("ui_generic_ok", "OK");
		_eventExposer.GenericDialogRequest(genericDialogData);
	}

	private void GeneratePurchaseSuccessDialogb__15_0(Localization localization)
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = localization.GetLocalizedString("ui_store_purchase_thank_you_title", "THANK YOU!");
		genericDialogData.message = localization.GetLocalizedString("ui_store_purchase_thank_you_message", "We hope you enjoy your purchased items.");
		genericDialogData.negativeButtonText = localization.GetLocalizedString("ui_store_purchase_thank_you_button_text", "OK");
		_eventExposer.GenericDialogRequest(genericDialogData);
	}

	private void GenerateInFlightPurchaseDialogb__16_0(Localization localization)
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = localization.GetLocalizedString("store_disable_IAP_dialog_heading", "Purchase Already Pending");
		genericDialogData.message = localization.GetLocalizedString("store_disabled_IAP_dialog_body", "You have a transaction in progress already and cannot beging new transactions until it is resolved.");
		genericDialogData.negativeButtonText = localization.GetLocalizedString("ui_generic_ok", "OK");
		_eventExposer.GenericDialogRequest(genericDialogData);
	}

	private void GenerateStoreLoadErrorDialogb__17_0(Localization localization)
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = localization.GetLocalizedString("ui_dialog_seasonal_restart_title", "SPECIAL DELIVERY");
		genericDialogData.message = localization.GetLocalizedString("ui_dialog_seasonal_restart_text", "Get latest shipping information");
		genericDialogData.positiveButtonText = localization.GetLocalizedString("ui_generic_ok", "OK");
		genericDialogData.positiveButtonAction = TriggerRestart;
		_eventExposer.GenericDialogRequest(genericDialogData);
	}
}
