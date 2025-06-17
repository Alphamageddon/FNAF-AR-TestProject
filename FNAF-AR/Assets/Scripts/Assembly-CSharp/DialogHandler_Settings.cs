using System;
using PaperPlaneTools;
using UnityEngine;

public class DialogHandler_Settings : MonoBehaviour
{
	[SerializeField]
	private GameObject aboutDialog;

	private EventExposer masterEvents;

	private Alert aboutAlert;

	private string disconnectFacebookMessageString;

	private string facebookConfirmString;

	private string facebookCancelString;

	private string termsAndServiceMessageString;

	private string termsAndServiceConfirmString;

	private string termsAndServiceCancelString;

	private string privacyPolicyMessageString;

	private string privacyPolicyConfirmString;

	private string privacyPolicyCancelString;

	private string helpMessageString;

	private string helpConfirmString;

	private string helpCancelString;

	private string fbSyncTitleString;

	private string fbSyncBodyString;

	private string fbSyncPreviousString;

	private string fbSyncNewString;

	private string goToSettingsIOSTitle;

	private string goToSettingsIOSMessage;

	private string goToSettingsIOSPositiveButton;

	private string goToSettingsIOSNegativeButton;

	private string registerForPushNotifsTitle;

	private string registerForPushNotifsMessage;

	private string registerForPushNotifsButton;

	private string _okButtonText;

	private string _linkExistsTitleString;

	private string _linkBodyTitleString;

	private string _linkButtonText;

	private string _switchButtonText;

	private string _cancelButtonText;

	private string _failLinkByForceTitleString;

	private string _failLinkByForceBodyString;

	private string _failLinkTitleString;

	private string _failLinkBodyString;

	private string _unLinkAccountWarningTitleText;

	private string _unLinkAccountWarningBodyText;

	private string _restartTitleText;

	private string _restartBodyText;

	private string _loginByOSFailureTitleText;

	private string _loginByOSFailureBodyText;

	private string _occlusionWarningTitleString;

	private string _occlusionWarningBodyString;

	private void FetchLocalizationStrings()
	{
		Localization localization = LocalizationDomain.Instance.Localization;
		_occlusionWarningTitleString = localization.GetLocalizedString("ui_settings_depth_api_unsupported_device_warning_title", _occlusionWarningTitleString);
		_occlusionWarningBodyString = localization.GetLocalizedString("ui_settings_depth_api_unsupported_device_warning_text", _occlusionWarningBodyString);
		_loginByOSFailureTitleText = localization.GetLocalizedString("ui_settings_login_failure_title_text", _loginByOSFailureTitleText);
		_loginByOSFailureBodyText = localization.GetLocalizedString("ui_settings_login_failure_body_text", _loginByOSFailureBodyText);
		_restartTitleText = localization.GetLocalizedString("ui_settings_unlink_warning_title_text", _restartTitleText);
		_restartBodyText = localization.GetLocalizedString("ui_settings_unlink_warning_body_text", _restartBodyText);
		_unLinkAccountWarningTitleText = localization.GetLocalizedString("ui_settings_unlink_warning_title_text", _unLinkAccountWarningTitleText);
		_unLinkAccountWarningBodyText = localization.GetLocalizedString("ui_settings_unlink_warning_body_text", _unLinkAccountWarningBodyText);
		_failLinkTitleString = localization.GetLocalizedString("ui_settings_link_failed_title_text", _failLinkTitleString);
		_failLinkBodyString = localization.GetLocalizedString("ui_settings_link_failed_body_text", _failLinkBodyString);
		_okButtonText = localization.GetLocalizedString("ui_generic_ok", _okButtonText);
		_failLinkByForceTitleString = localization.GetLocalizedString("ui_settings_force_link_failed_title_text", _failLinkByForceTitleString);
		_failLinkByForceBodyString = localization.GetLocalizedString("ui_settings_force_link_failed_body_text", _failLinkByForceBodyString);
		_linkExistsTitleString = localization.GetLocalizedString("ui_settings_link_exists_title_text", _linkExistsTitleString);
		_linkBodyTitleString = localization.GetLocalizedString("ui_settings_link_exists_body_text", _linkBodyTitleString);
		_linkButtonText = localization.GetLocalizedString("ui_settings_link", _linkButtonText);
		_switchButtonText = localization.GetLocalizedString("ui_settings_switch", _switchButtonText);
		_cancelButtonText = localization.GetLocalizedString("ui_generic_cancel", _cancelButtonText);
		disconnectFacebookMessageString = localization.GetLocalizedString("ui_settings_dialog_disconnect_facebook_message", disconnectFacebookMessageString);
		facebookConfirmString = localization.GetLocalizedString("ui_settings_dialog_disconnect_facebook_confirm", facebookConfirmString);
		facebookCancelString = localization.GetLocalizedString("ui_settings_dialog_disconnect_facebook_cancel", facebookCancelString);
		termsAndServiceMessageString = localization.GetLocalizedString("ui_settings_dialog_terms_and_service_message", termsAndServiceMessageString);
		termsAndServiceConfirmString = localization.GetLocalizedString("ui_settings_dialog_terms_and_service_confirm", termsAndServiceConfirmString);
		termsAndServiceCancelString = localization.GetLocalizedString("ui_settings_dialog_terms_and_service_cancel", termsAndServiceCancelString);
		privacyPolicyMessageString = localization.GetLocalizedString("ui_settings_dialog_privacy_message", privacyPolicyMessageString);
		privacyPolicyConfirmString = localization.GetLocalizedString("ui_settings_dialog_privacy_confirm", privacyPolicyConfirmString);
		privacyPolicyCancelString = localization.GetLocalizedString("ui_settings_dialog_privacy_cancel", privacyPolicyCancelString);
		helpMessageString = localization.GetLocalizedString("ui_settings_dialog_help_message", helpMessageString);
		helpConfirmString = localization.GetLocalizedString("ui_settings_dialog_help_confirm", helpConfirmString);
		helpCancelString = localization.GetLocalizedString("ui_settings_dialog_help_cancel", helpCancelString);
		fbSyncTitleString = localization.GetLocalizedString("ui_facebook_sync_flow_title", fbSyncTitleString);
		fbSyncBodyString = localization.GetLocalizedString("ui_facebook_sync_flow_body", fbSyncBodyString);
		fbSyncPreviousString = localization.GetLocalizedString("ui_facebook_sync_flow_syncprevious_button", fbSyncPreviousString);
		fbSyncNewString = localization.GetLocalizedString("ui_facebook_sync_flow_syncnew_button", fbSyncNewString);
		goToSettingsIOSTitle = localization.GetLocalizedString("ui_settings_push_notifications_ios_title", goToSettingsIOSTitle);
		goToSettingsIOSMessage = localization.GetLocalizedString("ui_settings_push_notifications_ios_message", goToSettingsIOSMessage);
		goToSettingsIOSPositiveButton = localization.GetLocalizedString("ui_settings_push_notifications_ios_positive", goToSettingsIOSPositiveButton);
		goToSettingsIOSNegativeButton = localization.GetLocalizedString("ui_settings_push_notifications_ios_negative", goToSettingsIOSNegativeButton);
		registerForPushNotifsTitle = localization.GetLocalizedString("ui_pushNotificationRationale_dialog_title", registerForPushNotifsTitle);
		registerForPushNotifsMessage = localization.GetLocalizedString("ui_pushNotificationRationale_dialog_text", registerForPushNotifsMessage);
		registerForPushNotifsButton = localization.GetLocalizedString("ui_pushNotificationRationale_dialog_ok", registerForPushNotifsButton);
	}

	public void ShowAboutDialog()
	{
		aboutAlert.Show();
	}

	public void ShowOcclusionWarningDialog()
	{
	}

	public void ShowLoginToAccountByOSFailure()
	{
	}

	public void ShowRestartGameDialog(Action restartAction)
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = _restartTitleText;
		genericDialogData.message = _restartBodyText;
		genericDialogData.positiveButtonText = _okButtonText;
		genericDialogData.positiveButtonAction = restartAction;
		masterEvents.GenericDialogRequest(genericDialogData);
	}

	public void ShowUnLinkWarningDialog(Action unLinkAction)
	{
	}

	public void ShowLinkFailureDialog()
	{
	}

	public void ShowForceLinkFailureDialog()
	{
	}

	public void ShowForceLinkDialog(Action switchAction, Action forceLinkAction)
	{
	}

	public void ShowTermsDialog(Action openTermsOfService)
	{
	}

	public void OpenHelpDialog(Action openHelpAndSupport)
	{
	}

	public void ShowPrivacyDialog(Action openPrivacyPolicy)
	{
	}

	public void ShowFacebookDisconnectConfirm(Action logoutOfFacebookConnect)
	{
	}

	public void ShowFacebookAccountSyncDialog(Action syncPreviousPlayer, Action syncNewPlayer)
	{
	}

	public void ShowRegisterForPushNotifsDialog(Action registerForPushNotifsDeligate)
	{
	}

	public void ShowGoToSettingsDialog(Action openPhoneSettings)
	{
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = goToSettingsIOSTitle;
		genericDialogData.positiveButtonAction = openPhoneSettings;
		genericDialogData.message = goToSettingsIOSMessage;
		genericDialogData.positiveButtonText = goToSettingsIOSPositiveButton;
		genericDialogData.negativeButtonText = goToSettingsIOSNegativeButton;
		masterEvents.GenericDialogRequest(genericDialogData);
	}

	private void Awake()
	{
		FetchLocalizationStrings();
	}

	private void Start()
	{
		aboutAlert.SetAdapter(aboutDialog.GetComponent<IAlertPlatformAdapter>());
		masterEvents = MasterDomain.GetDomain().eventExposer;
	}

	private void OnDestroy()
	{
		if (aboutAlert != null)
		{
			aboutAlert.Dismiss();
		}
		aboutAlert = null;
	}

	public DialogHandler_Settings()
	{
		aboutAlert = new Alert();
		disconnectFacebookMessageString = "Disconnect your FaceBook account?";
		facebookConfirmString = "Confirm";
		facebookCancelString = "Cancel";
		termsAndServiceMessageString = "This will leave FNaF AR Game and open your web browser. Are you sure?";
		termsAndServiceConfirmString = "Yes, leave game";
		termsAndServiceCancelString = "Cancel";
		helpConfirmString = "Yes, leave game";
		helpCancelString = "Cancel";
		privacyPolicyMessageString = "This will leave FNaF AR Game. Are you sure?";
		privacyPolicyConfirmString = "Yes, leave game";
		privacyPolicyCancelString = "Cancel";
		helpMessageString = "This will leave FNaF AR Game. Are you sure?";
		fbSyncTitleString = "Account Sync";
		fbSyncBodyString = "You have a previously synced account attached to this Facebook.";
		fbSyncPreviousString = "Load previous account";
		fbSyncNewString = "Sync this new account";
		goToSettingsIOSTitle = "Adjust Push Notifications";
		goToSettingsIOSMessage = "Open your device's Settings to adjust your push notifications settings?";
		goToSettingsIOSPositiveButton = "Open Settings";
		goToSettingsIOSNegativeButton = "Cancel";
		registerForPushNotifsTitle = "Push Notification Explanation";
		registerForPushNotifsMessage = "We use this to notify you about animatronics sent between you and your friends.";
		registerForPushNotifsButton = "OK";
		_okButtonText = "OK";
		_linkExistsTitleString = "Link Exists!";
		_linkBodyTitleString = "The account you are trying to link to is already linked to another account, would you like to forcefully link to this account, or switch to the other account? This cannot be undone";
		_linkButtonText = "LINK";
		_switchButtonText = "SWITCH";
		_cancelButtonText = "CANCEL";
		_failLinkByForceTitleString = "Failed to force link";
		_failLinkByForceBodyString = "Failed to force a link to account";
		_failLinkTitleString = "Failed to link";
		_failLinkBodyString = "Failed to link account";
		_unLinkAccountWarningTitleText = "Warning";
		_unLinkAccountWarningBodyText = "Are you sure you want to unlink this account? Make sure you have another recovery method";
		_restartTitleText = "Restarting";
		_restartBodyText = "Restarting game to sync account";
		_loginByOSFailureTitleText = "Failure";
		_loginByOSFailureBodyText = "Failed to log into account";
		_occlusionWarningTitleString = "Experimental Feature";
		_occlusionWarningBodyString = "The Google Depth API used in our occlusion feature may not work properly on your device.";
	}
}
