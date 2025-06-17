using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class SettingsUIView : MonoBehaviour
{
	[Header("Hookups")]
	[SerializeField]
	private TextMeshProUGUI screenSpaceText;

	[SerializeField]
	private TextMeshProUGUI bloomText;

	[SerializeField]
	private TextMeshProUGUI haywireIndicatorText;

	[SerializeField]
	private TextMeshProUGUI denyFriendsText;

	[SerializeField]
	private TextMeshProUGUI denySendsText;

	[SerializeField]
	private TextMeshProUGUI purgeBundlesText;

	[SerializeField]
	private TextMeshProUGUI aboutDialogVersionText;

	[SerializeField]
	private TextMeshProUGUI aboutDialogModelText;

	[SerializeField]
	private TextMeshProUGUI aboutPlayerIdText;

	[SerializeField]
	private TextMeshProUGUI serverVersionText;

	[SerializeField]
	private TextMeshProUGUI dataVersionText;

	private MasterDomain _masterDomain;

	private string vibrationOnString = "ON";

	private string vibrationOffString = "OFF";

	private string occlusionOnString = "ON";

	private string occlusionOffString = "OFF";

	private string facebookLogOutString;

	private string facebookLoginString = "Login with Facebook";

	private string vibrationNotSupportedString = "NOT SUPPORTED";

	private string pushNotifsAdjust = "ENABLED";

	private string pushNotifsEnable = "DISABLED";

	private string osSignedInString = "Signed in";

	private string osSignInString = "Sign in";

	private string helpUrlString;

	private string privacyPolicyUrlString;

	private string termsOfUseUrlString;

	[SerializeField]
	public Slider ResolutionSlider;

	[SerializeField]
	private TextMeshProUGUI ResolutionSliderCurrentText;

	[SerializeField]
	private GameObject FpsParent;

	[SerializeField]
	private GameObject ScreenSpaceButton;

	[SerializeField]
	private Button DenyFriendsButton;

	[SerializeField]
	private Button DenySendsButton;

	[SerializeField]
	private HighlightToggle FpsButton_30;

	[SerializeField]
	private HighlightToggle FpsButton_60;

	[SerializeField]
	private HighlightToggle FpsButton_120;

	[SerializeField]
	public HighlightToggle MaskControlButton_Button;

	[SerializeField]
	public HighlightToggle MaskControlButton_Flick;

	[SerializeField]
	private List<PostProcessProfile> PostProcessingProfiles;

	private bool screenSpaceActive = true;

	private bool bloomActive = true;

	private bool haywireIndicatorsActive;

	private bool denyFriends;

	private bool denySends;

	private void UpdateAboutDialogText()
	{
		aboutDialogVersionText.text = Application.version;
		aboutDialogModelText.text = SystemInfo.deviceModel;
		LoginDomain loginDomain = _masterDomain.TheGameDomain.loginDomain;
		aboutPlayerIdText.text = loginDomain.playerProfile.userId;
		dataVersionText.text = PlayerPrefs.GetInt("MasterDataVersion").ToString();
		serverVersionText.text = "1";
	}

	public string GetHelpUrl()
	{
		return helpUrlString;
	}

	public string GetPrivacyPolicyUrl()
	{
		return privacyPolicyUrlString;
	}

	public string GetTermsOfUseUrl()
	{
		return termsOfUseUrlString;
	}

	public void SetAccountOSLoginSectionState(bool isActive)
	{
	}

	private void UpdateButtonStates()
	{
		UpdateVibrationButtonText();
		UpdateOcclusionButtonText();
		UpdateOcclusionButtonVisibility();
		UpdateLoginButtons();
		UpdateScreenSpaceButtonText();
		UpdateBloomButtonText();
		UpdateHaywireIndicatorsButtonText();
		UpdateDenyFriendsButtonText();
		UpdateDenySendsButtonText();
		UpdatePurgeBundlesButtonText();
	}

	private void SetOsAccountSignInText()
	{
	}

	private void UpdateFacebookInteractivity()
	{
	}

	private void UpdateFacebookConnectedText()
	{
	}

	private void UpdateVibrationButtonText()
	{
	}

	private void UpdateOcclusionButtonText()
	{
	}

	private void CheckVibrationSupported()
	{
	}

	private void UpdateOcclusionButtonVisibility()
	{
	}

	private void UpdateScreenSpaceButtonText()
	{
		screenSpaceText.text = (screenSpaceActive ? occlusionOnString : occlusionOffString);
	}

	private void UpdateBloomButtonText()
	{
		bloomText.text = (bloomActive ? occlusionOnString : occlusionOffString);
	}

	private void UpdateHaywireIndicatorsButtonText()
	{
		haywireIndicatorText.text = (haywireIndicatorsActive ? occlusionOnString : occlusionOffString);
	}

	private void UpdateDenyFriendsButtonText()
	{
		denyFriendsText.text = (denyFriends ? occlusionOffString : occlusionOnString);
	}

	private void UpdateDenySendsButtonText()
	{
		denySendsText.text = (denySends ? occlusionOffString : occlusionOnString);
	}

	private void UpdatePurgeBundlesButtonText()
	{
		purgeBundlesText.text = "PURGE";
	}

	private void FetchLocalizedStrings()
	{
		SetVibrationButtonText();
		SetOcclusionButtonText();
		SetFacebookConnectedText();
		SetPushNotifText();
		SetOSAccountConnectedText();
	}

	private void SetPushNotifText()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(SetPushNotifTextb__49_0);
	}

	private void SetFacebookConnectedText()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(SetFacebookConnectedTextb__50_0);
	}

	private void SetOSAccountConnectedText()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(SetOSAccountConnectedTextb__51_0);
	}

	private void SetVibrationButtonText()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(SetVibrationButtonTextb__52_0);
	}

	private void SetOcclusionButtonText()
	{
		LocalizationDomain.Instance.Localization.GetInterfaceAsync(SetOcclusionButtonTextb__53_0);
	}

	private void Start()
	{
		_masterDomain = MasterDomain.GetDomain();
		_masterDomain.eventExposer.add_PlayerProfileUpdated(PlayerProfileUpdated);
		FetchLocalizedStrings();
		CheckVibrationSupported();
		UpdateAboutDialogText();
		UpdateLoginButtons();
		GetInitialResolution();
		SetInitialFrameRate();
		SetInitialPostProcessSettings();
		SetInitialAccessibilitySettings();
		SetInitialSocialSettings();
		SetInitialMaskOption();
	}

	private void OnDestroy()
	{
		_masterDomain.eventExposer.remove_PlayerProfileUpdated(PlayerProfileUpdated);
	}

	private void PlayerProfileUpdated(PlayerProfile profile)
	{
		denyFriends = !profile.friendAddsEnabled;
		denySends = !profile.friendSendsEnabled;
		DenySendsButton.interactable = true;
		DenyFriendsButton.interactable = true;
	}

	public void UpdateLoginButtons()
	{
		UpdateFacebookConnectedText();
		UpdateFacebookInteractivity();
		UpdateOsAccountButton();
	}

	public void UpdateOsAccountButton()
	{
		SetOsAccountSignInText();
		UpdateLoginButtonVisibilityAndInteractivity();
	}

	private void UpdateLoginButtonVisibilityAndInteractivity()
	{
	}

	private void UpdateOsButtonVisibility(bool isAccountLinked)
	{
	}

	private void UpdateOSButtonsInteractivity(bool interactivity)
	{
	}

	private void GetInitialResolution()
	{
		int num = PlayerPrefs.GetInt("ResolutionMultiplier");
		UpdateResolutionSliderText((float)num / 10f);
		ResolutionSlider.value = num;
		QualitySetter.Instance.SetResolutionMultiplier(num);
	}

	public void UpdateResolutionSliderText(float value)
	{
		ResolutionSliderCurrentText.text = value + "x";
	}

	private void SetInitialFrameRate()
	{
		FpsParent.SetActive(value: false);
	}

	private void SetInitialMaskOption()
	{
		string text = PlayerPrefs.GetString("MaskControl");
		if (!(text == "button"))
		{
			if (text == "flick")
			{
				MaskControlButton_Flick.SetHighlightAndOtherCellsHighlightState(value: true);
			}
		}
		else
		{
			MaskControlButton_Button.SetHighlightAndOtherCellsHighlightState(value: true);
		}
	}

	private void SetInitialPostProcessSettings()
	{
		if (PlayerPrefs.HasKey("Bloom"))
		{
			bloomActive = PlayerPrefs.GetInt("Bloom") == 1;
		}
		foreach (PostProcessProfile postProcessingProfile in PostProcessingProfiles)
		{
			Bloom outSetting = null;
			if (postProcessingProfile.TryGetSettings<Bloom>(out outSetting))
			{
				outSetting.active = bloomActive;
			}
		}
		if (PlayerPrefs.HasKey("ScreenSpaceReflections"))
		{
			screenSpaceActive = PlayerPrefs.GetInt("ScreenSpaceReflections") == 1;
		}
		foreach (PostProcessProfile postProcessingProfile2 in PostProcessingProfiles)
		{
			ScreenSpaceReflections outSetting2 = null;
			if (postProcessingProfile2.TryGetSettings<ScreenSpaceReflections>(out outSetting2))
			{
				outSetting2.active = screenSpaceActive;
			}
		}
	}

	public void ToggleScreenSpaceReflections()
	{
		screenSpaceActive = !screenSpaceActive;
		foreach (PostProcessProfile postProcessingProfile in PostProcessingProfiles)
		{
			ScreenSpaceReflections outSetting = null;
			if (postProcessingProfile.TryGetSettings<ScreenSpaceReflections>(out outSetting))
			{
				outSetting.active = screenSpaceActive;
			}
		}
		PlayerPrefs.SetInt("ScreenSpaceReflections", screenSpaceActive ? 1 : 0);
		PlayerPrefs.Save();
	}

	public void ToggleBloom()
	{
		bloomActive = !bloomActive;
		foreach (PostProcessProfile postProcessingProfile in PostProcessingProfiles)
		{
			Bloom outSetting = null;
			if (postProcessingProfile.TryGetSettings<Bloom>(out outSetting))
			{
				outSetting.active = bloomActive;
			}
		}
		PlayerPrefs.SetInt("Bloom", bloomActive ? 1 : 0);
		PlayerPrefs.Save();
	}

	private void SetInitialAccessibilitySettings()
	{
		if (PlayerPrefs.HasKey("HaywireIndicators"))
		{
			haywireIndicatorsActive = PlayerPrefs.GetInt("HaywireIndicators") == 1;
		}
	}

	public void ToggleHaywireIndicators()
	{
		haywireIndicatorsActive = !haywireIndicatorsActive;
		PlayerPrefs.SetInt("HaywireIndicators", haywireIndicatorsActive ? 1 : 0);
		PlayerPrefs.Save();
	}

	private void SetInitialSocialSettings()
	{
		denyFriends = !MasterDomain.GetDomain().TheGameDomain.loginDomain.playerProfile.friendAddsEnabled;
		denySends = !MasterDomain.GetDomain().TheGameDomain.loginDomain.playerProfile.friendSendsEnabled;
	}

	public void ToggleDenyFriends()
	{
		DenyFriendsButton.interactable = false;
		_masterDomain.ServerDomain.toggleFriendAddsRequester.ToggleFriendsAdd(denyFriends);
	}

	public void ToggleDenySends()
	{
		DenySendsButton.interactable = false;
		_masterDomain.ServerDomain.toggleFriendSendsRequester.ToggleFriendSends(denySends);
	}

	private void Update()
	{
		UpdateButtonStates();
	}

	public SettingsUIView()
	{
		occlusionOnString = "ON";
		vibrationOnString = "ON";
		vibrationOffString = "OFF";
		occlusionOffString = "OFF";
		facebookLogOutString = "Log Out";
		facebookLoginString = "Login with Facebook";
		vibrationNotSupportedString = "NOT SUPPORTED";
		pushNotifsAdjust = "ENABLED";
		pushNotifsEnable = "DISABLED";
		osSignedInString = "Signed in";
		osSignInString = "Sign in";
	}

	private void SetPushNotifTextb__49_0(Localization localization)
	{
		pushNotifsAdjust = localization.GetLocalizedString("ui_settings_push_notifs_enabled", pushNotifsAdjust);
		pushNotifsEnable = localization.GetLocalizedString("ui_settings_push_notifs_disabled", pushNotifsEnable);
	}

	private void SetFacebookConnectedTextb__50_0(Localization localization)
	{
		facebookLogOutString = localization.GetLocalizedString("ui_settings_logout_button_text", facebookLogOutString);
		facebookLoginString = localization.GetLocalizedString("ui_settings_sign_in_with_facebook", facebookLoginString);
	}

	private void SetOSAccountConnectedTextb__51_0(Localization localization)
	{
		osSignedInString = localization.GetLocalizedString("ui_settings_logout_button_text", osSignedInString);
		osSignInString = localization.GetLocalizedString("ui_settings_sign_in_with_Google", osSignInString);
	}

	private void SetVibrationButtonTextb__52_0(Localization localization)
	{
		vibrationOnString = localization.GetLocalizedString("ui_settings_vibration_on", vibrationOnString);
		vibrationOffString = localization.GetLocalizedString("ui_settings_vibration_off", vibrationOffString);
		vibrationNotSupportedString = localization.GetLocalizedString("ui_settings_vibration_not_supported", vibrationNotSupportedString);
	}

	private void SetOcclusionButtonTextb__53_0(Localization localization)
	{
		occlusionOnString = localization.GetLocalizedString("ui_settings_depth_api_on", occlusionOnString);
		occlusionOffString = localization.GetLocalizedString("ui_settings_depth_api_off", occlusionOffString);
	}
}
