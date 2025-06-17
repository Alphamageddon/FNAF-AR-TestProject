using System;
using UnityEngine;

public class SettingsUIActions : MonoBehaviour
{
	[SerializeField]
	private SettingsUIView settingsUIView;

	[SerializeField]
	private DialogHandler_Settings dialogHandler_Settings;

	private EventExposer _eventExposer;

	private int resolutionSliderValue = 10;

	public void RegisterForPushNotifs()
	{
	}

	public void OpenPhoneSettings()
	{
	}

	private void OnSettingsURLFound(string settingsURL)
	{
		Application.OpenURL(settingsURL);
	}

	private void OpenTermsOfService()
	{
		Application.OpenURL(settingsUIView.GetTermsOfUseUrl());
	}

	private void OpenPrivacyPolicy()
	{
		Application.OpenURL(settingsUIView.GetPrivacyPolicyUrl());
	}

	private void OpenHelpAndSupport()
	{
		Application.OpenURL(settingsUIView.GetHelpUrl());
	}

	private void RunFaceBookLogic()
	{
	}

	private void ConnectToFacebook()
	{
	}

	private void OnCanSyncCallback()
	{
		dialogHandler_Settings.ShowFacebookAccountSyncDialog(SyncPrevPlayer, SyncNewPlayer);
	}

	private void SyncPrevPlayer()
	{
	}

	private void LogOutOfOsAccountOnSwitch()
	{
	}

	private void RestartGame()
	{
	}

	private void SyncNewPlayer()
	{
	}

	private void LogoutOfFaceBookConfirm()
	{
	}

	public void ToggleVibration()
	{
		VibrationSettings.VibrationEnable(!VibrationSettings.VibrationIsEnabled());
	}

	public void ToggleOcclusion()
	{
	}

	private void PresentOcclusionWarning()
	{
		dialogHandler_Settings.ShowOcclusionWarningDialog();
	}

	public void OpenAbout()
	{
		dialogHandler_Settings.ShowAboutDialog();
	}

	public void SelectTermsAndService()
	{
		dialogHandler_Settings.ShowTermsDialog(OpenTermsOfService);
	}

	public void SelectPrivacyPolicy()
	{
		dialogHandler_Settings.ShowPrivacyDialog(OpenPrivacyPolicy);
	}

	public void SelectHelpAndSupport()
	{
		dialogHandler_Settings.OpenHelpDialog(OpenHelpAndSupport);
	}

	public void SwitchMaskToggle(string option)
	{
		string text = option.ToLower();
		if (!(text == "button"))
		{
			if (text == "flick")
			{
				GenericDialogData genericDialogData = new GenericDialogData
				{
					title = "WARNING",
					message = "This option is here just for fun. It will make the game harder to play. The option will be removed next update. Are you sure?",
					positiveButtonText = "YES",
					negativeButtonText = "NO",
					negativeButtonAction = DeclineMaskToggleFlick
				};
				MasterDomain.GetDomain().eventExposer.GenericDialogRequest(genericDialogData);
				PlayerPrefs.SetString("MaskControl", "flick");
			}
			else
			{
				Debug.LogError("That's not a valid mask toggle option!");
			}
		}
		else
		{
			PlayerPrefs.SetString("MaskControl", "button");
		}
	}

	private void DeclineMaskToggleFlick()
	{
		PlayerPrefs.SetString("MaskControl", "button");
		settingsUIView.MaskControlButton_Button.SetHighlightAndOtherCellsHighlightState(value: true);
	}

	public void SelectFacebook()
	{
		RunFaceBookLogic();
	}

	public void LinkAccountByOS()
	{
	}

	private void LinkAccountByOSByForce(Action success, Action<string> failure, bool forceLink)
	{
	}

	private void OnLinkAccountSuccess()
	{
		settingsUIView.UpdateLoginButtons();
	}

	private void OnLinkAccountByOsFailed(string errorCode)
	{
	}

	private void PopUpAskingToForceLink()
	{
	}

	private void LinkAccountByOSByForceButtonPressed()
	{
	}

	private void PopUpOnLinkAccountByOsForcedFailed(string error)
	{
		dialogHandler_Settings.ShowForceLinkFailureDialog();
		Debug.LogError("SettingsUIActions PopUpOnLinkAccountByOsForcedFailed - " + error);
	}

	private void PopUpFailedToLinkDialog()
	{
		dialogHandler_Settings.ShowLinkFailureDialog();
	}

	public void UnLinkAccount()
	{
		dialogHandler_Settings.ShowUnLinkWarningDialog(UnLinkAccountAction);
	}

	private void PopUpRestartGameDialog(Action callback)
	{
		dialogHandler_Settings.ShowRestartGameDialog(callback);
	}

	private void UnLinkAccountAction()
	{
	}

	private void UnLinkAccountSuccess()
	{
		settingsUIView.UpdateLoginButtons();
		PopUpRestartGameDialog(RestartGame);
	}

	private void LoginToAccountByOS()
	{
	}

	private void LoginToAccountBySuccessConfirm()
	{
	}

	private void AttemptToLogOutOfFacebookOnAccountSwitch()
	{
	}

	private void LoginToAccountByOsFailure(IllumixErrorData error)
	{
		dialogHandler_Settings.ShowLoginToAccountByOSFailure();
	}

	public void SelectPushNotifications()
	{
	}

	private void Start()
	{
		MasterDomain domain = MasterDomain.GetDomain();
		_eventExposer = domain.eventExposer;
		_ = domain.TheGameDomain.loginDomain;
		domain.MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(ConfigDataLoaded);
	}

	private void ConfigDataLoaded(CONFIG_DATA.Root data)
	{
	}

	private void Update()
	{
	}

	public void ResolutionSliderUpdated()
	{
		resolutionSliderValue = (int)settingsUIView.ResolutionSlider.value;
		settingsUIView.UpdateResolutionSliderText((float)resolutionSliderValue / 10f);
	}

	public void ApplyResolution()
	{
		QualitySetter.Instance.SetResolutionMultiplier(resolutionSliderValue);
	}

	public void ToggleFrameRate(int fps)
	{
		QualitySetter.Instance.SetFPS(fps);
	}

	public void ToggleScreenSpaceReflections()
	{
		settingsUIView.ToggleScreenSpaceReflections();
	}

	public void ToggleBloom()
	{
		settingsUIView.ToggleBloom();
	}

	public void ToggleHaywireIndicators()
	{
		settingsUIView.ToggleHaywireIndicators();
	}

	public void ToggleFriendAdds()
	{
		settingsUIView.ToggleDenyFriends();
	}

	public void ToggleFriendSends()
	{
		settingsUIView.ToggleDenySends();
	}

	public void PurgeBundles()
	{
		GenericDialogData genericDialogData = new GenericDialogData
		{
			title = "BUNDLE PURGE",
			message = "Are you sure you want to delete ALL AssetBundles?",
			positiveButtonText = "YES",
			negativeButtonText = "NO",
			positiveButtonAction = ReallyPurgeBundles
		};
		MasterDomain.GetDomain().eventExposer.GenericDialogRequest(genericDialogData);
	}

	private void ReallyPurgeBundles()
	{
		AssetBundle.UnloadAllAssetBundles(unloadAllObjects: true);
		Caching.ClearCache();
		Application.Quit();
	}
}
