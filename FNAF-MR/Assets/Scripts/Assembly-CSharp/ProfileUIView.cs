using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfileUIView : MonoBehaviour
{
	[SerializeField]
	[Header("Hookups")]
	private DialogHandler_Profile dialogHandler_Profile;

	[SerializeField]
	private ProfileUIActions profileUIActions;

	[SerializeField]
	private List<TabParentKeyValue> tabParents;

	[SerializeField]
	[Header("PanelTop Button HighlightToggles")]
	private HighlightToggle profileButtonHighlightToggle;

	[SerializeField]
	private HighlightToggle friendsButtonHighlightToggle;

	[SerializeField]
	private HighlightToggle leaderboardButtonHighlightToggle;

	[SerializeField]
	[Header("Profile")]
	private TextMeshProUGUI userNameText;

	[SerializeField]
	private TextMeshProUGUI levelText;

	[SerializeField]
	private TextMeshProUGUI experienceText;

	[SerializeField]
	private TextMeshProUGUI bonusXPText;

	[SerializeField]
	private TextMeshProUGUI encountersText;

	[SerializeField]
	private TextMeshProUGUI winsText;

	[SerializeField]
	private Slider xpSlider;

	[SerializeField]
	private GameObject bonusXPGroup;

	[SerializeField]
	private TextMeshProUGUI currentStreakNumText;

	[SerializeField]
	private TMP_InputField nameInputField;

	[SerializeField]
	private GameObject errorPanel;

	[SerializeField]
	private TextMeshProUGUI errorMessage;

	[SerializeField]
	private Transform avatarCellParent;

	[SerializeField]
	private AvatarCell avatarCellPrefab;

	[SerializeField]
	private AvatarCell mainAvatarImage;

	[SerializeField]
	[Header("Friends List")]
	private Transform friendsCellParent;

	[SerializeField]
	private FriendRemoveCell friendsCellPrefab;

	[SerializeField]
	private TextMeshProUGUI numInvitesText;

	[SerializeField]
	private Button inviteFriendButton;

	[SerializeField]
	[Header("Discord")]
	private RawImage discordProfileRawImage;

	[SerializeField]
	private TextMeshProUGUI discordUsernameText;

	[SerializeField]
	[Header("Friend Code")]
	private GameObject friendCodePanel;

	[SerializeField]
	private TextMeshProUGUI generatedFriendCode;

	[SerializeField]
	private TMP_InputField enteredFriendCode;

	[SerializeField]
	private TextMeshProUGUI addFriendDefaultText;

	[SerializeField]
	private TextMeshProUGUI addFriendErrorText;

	[SerializeField]
	private Button[] addFriendButtons;

	private MasterDomain _masterDomain;

	private MenuTabsHandler menuTabsHandler;

	private ProfileTabHandler profileTabHandler;

	private ProfileTabData profileTabData;

	private AvatarSelectionHandler avatarSelectionHandler;

	private FriendsListTabHandler friendsListTabHandler;

	private FriendsListTabData friendsListTabData;

	private FriendCodeModel friendCodeModel;

	private DiscordTabHandler discordTabHandler;

	private DiscordTabData discordTabData;

	private readonly string[] UserNameSetErrorStrings;

	private readonly string NumInvitesLocString;

	private void EventExposer_PersonalFriendCodeUpdate(string personalFriendCode)
	{
		generatedFriendCode.text = personalFriendCode;
		dialogHandler_Profile.DismissAddFriendDialog();
	}

	private void EventExposer_PlayerProfileUpdated(PlayerProfile obj)
	{
		UpdatePlayerAvatar();
	}

	private void EventExposer_DisplayNameObscenityFound(UserNameSetError error)
	{
		string text = UserNameSetErrorStrings[(int)error];
		StartCoroutine(ShowError(LocalizationDomain.Instance.Localization.GetLocalizedString(text, text)));
	}

	private void UpdateFazPassInfo()
	{
		numInvitesText.gameObject.SetActive(value: false);
		inviteFriendButton.interactable = false;
	}

	private void DidSwitchTabs(Tab tab)
	{
		switch (tab)
		{
		case Tab.profile:
			friendsListTabHandler.ClearFriendsFromList();
			break;
		case Tab.leaderboard:
			friendsListTabHandler.ClearFriendsFromList();
			break;
		}
	}

	public void ChooseLeaderboard(string name)
	{
	}

	private void WillSwitchTabs(Tab tab)
	{
		switch (tab)
		{
		case Tab.profile:
			UpdatePlayerAvatar();
			break;
		case Tab.friends:
			friendsListTabHandler.PopulateFriendsTab();
			UpdateNumInvitesText();
			break;
		case Tab.leaderboard:
			discordTabHandler.PopulateDiscordTab();
			break;
		}
	}

	private void InitializeData()
	{
		ProfileTabData profileTabData = new ProfileTabData();
		profileTabData.userNameText = userNameText;
		profileTabData.levelText = levelText;
		profileTabData.experienceText = experienceText;
		profileTabData.currentStreakNumText = currentStreakNumText;
		profileTabData.tMP_Input = nameInputField;
		profileTabData.avatarImage = mainAvatarImage;
		profileTabData.avatarIconLookup = _masterDomain.PlayerAvatarDomain.AvatarIconHandler;
		profileTabData.masterDomain = _masterDomain;
		profileTabData.profileUIActions = profileUIActions;
		profileTabData.bonusXPText = bonusXPText;
		profileTabData.encountersText = encountersText;
		profileTabData.winsText = winsText;
		profileTabData.xpSlider = xpSlider;
		profileTabData.bonusXPGroup = bonusXPGroup;
		this.profileTabData = profileTabData;
		FriendsListTabData friendsListTabData = new FriendsListTabData();
		friendsListTabData.cellParent = friendsCellParent;
		friendsListTabData.friendSelectCellPrefab = friendsCellPrefab;
		this.friendsListTabData = friendsListTabData;
		DiscordTabData discordTabData = new DiscordTabData();
		discordTabData.controller = GameObject.Find("Constant Scripts").GetComponent<Discord_Controller>();
		discordTabData.profileRawImage = discordProfileRawImage;
		discordTabData.usernameText = discordUsernameText;
		this.discordTabData = discordTabData;
	}

	private IEnumerator ShowError(string message)
	{
		errorMessage.text = ((message == null) ? "" : message);
		errorPanel.SetActive(value: true);
		yield return new WaitForSeconds(3f);
		errorPanel.SetActive(value: false);
		yield return null;
	}

	private void AddSubcriptions()
	{
		_masterDomain.eventExposer.add_PlayerProfileUpdated(EventExposer_PlayerProfileUpdated);
		_masterDomain.eventExposer.add_DisplayNameObscenityFound(EventExposer_DisplayNameObscenityFound);
		_masterDomain.eventExposer.add_PersonalFriendCodeUpdated(EventExposer_PersonalFriendCodeUpdate);
	}

	private void RemoveSubcriptions()
	{
		if (_masterDomain.eventExposer != null)
		{
			_masterDomain.eventExposer.remove_PlayerProfileUpdated(EventExposer_PlayerProfileUpdated);
			_masterDomain.eventExposer.remove_DisplayNameObscenityFound(EventExposer_DisplayNameObscenityFound);
			_masterDomain.eventExposer.remove_PersonalFriendCodeUpdated(EventExposer_PersonalFriendCodeUpdate);
		}
	}

	public string GetGeneratedFriendCode()
	{
		if (generatedFriendCode == null)
		{
			return "";
		}
		return generatedFriendCode.text;
	}

	public void SelectedAvatar()
	{
		UpdatePlayerAvatar();
		_masterDomain.eventExposer.OnPlayerAvatarUpdated();
		dialogHandler_Profile.DismissAvatarSelectDialog();
	}

	public void UpdatePlayerAvatar()
	{
		profileTabHandler.RefreshAvatarIcon();
	}

	public void ShowAvatarSelectionDialog()
	{
		avatarSelectionHandler.GenerateCells();
		dialogHandler_Profile.ShowAvatarSelectionDialog();
	}

	public void ShowTab(Tab tab)
	{
		menuTabsHandler.ShowTab(tab);
	}

	public void ShowErrorOnName()
	{
		StartCoroutine(ShowError(null));
	}

	public void ChangeTopPanelHighlight(Tab tab)
	{
		profileButtonHighlightToggle.SetHighlight(tab == Tab.profile);
		friendsButtonHighlightToggle.SetHighlight(tab == Tab.friends);
		leaderboardButtonHighlightToggle.SetHighlight(tab == Tab.leaderboard);
	}

	public void UpdateNumInvitesText()
	{
		numInvitesText.text = LocalizationDomain.Instance.Localization.GetLocalizedString(NumInvitesLocString, "Num invites left:") + " 0";
	}

	public void DisableInviteButton()
	{
		inviteFriendButton.interactable = false;
	}

	public void ShowFriendCodeScreen()
	{
		generatedFriendCode.text = friendCodeModel.MyCurrentFriendCode;
		friendCodePanel.SetActive(value: true);
	}

	public void DisplayAddFriendCodeError()
	{
		addFriendDefaultText.gameObject.SetActive(value: false);
		addFriendErrorText.gameObject.SetActive(value: true);
	}

	public void HideFriendCodeScreen()
	{
		friendCodePanel.SetActive(value: false);
	}

	public void ShowAddFriend()
	{
		addFriendDefaultText.gameObject.SetActive(value: true);
		addFriendErrorText.gameObject.SetActive(value: false);
		dialogHandler_Profile.ShowAddFriendAlert();
	}

	public void HideAddFriend()
	{
		dialogHandler_Profile.DismissAddFriendDialog();
	}

	public void ShowRefreshFriendCodeConfirmation()
	{
		dialogHandler_Profile.ShowRefreshFriendCodeConfirmation();
	}

	public void HideFriendCodeRefreshConfirmation()
	{
		dialogHandler_Profile.DismissFriendCodeChangeDialog();
	}

	public void SetAddFriendButtonsEnabled(bool enabled)
	{
		Button[] array = addFriendButtons;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].enabled = enabled;
		}
	}

	public string GetRequestedFriendCode()
	{
		return enteredFriendCode.text;
	}

	private void Awake()
	{
		_masterDomain = MasterDomain.GetDomain();
		InitializeData();
	}

	private void Start()
	{
		menuTabsHandler = new MenuTabsHandler(tabParents, DidSwitchTabs, WillSwitchTabs);
		profileTabHandler = new ProfileTabHandler(profileTabData);
		avatarSelectionHandler = new AvatarSelectionHandler(avatarCellParent, avatarCellPrefab, profileUIActions.SelectAvatarCell, _masterDomain.PlayerAvatarDomain.AvatarIconHandler);
		friendsListTabHandler = new FriendsListTabHandler(_masterDomain, friendsListTabData, dialogHandler_Profile, _masterDomain.PlayerAvatarDomain.AvatarIconHandler);
		discordTabHandler = new DiscordTabHandler(discordTabData);
		friendCodeModel = _masterDomain.GameUIDomain.GameUIData.friendCodeModel;
		AddSubcriptions();
		UpdatePlayerAvatar();
		ShowTab(Tab.profile);
		UpdateFazPassInfo();
	}

	private void Update()
	{
		profileTabHandler.Update();
	}

	private void OnDestroy()
	{
		RemoveSubcriptions();
		friendsListTabHandler.OnDestroy();
		discordTabHandler.OnDestroy();
	}

	public ProfileUIView()
	{
		UserNameSetErrorStrings = new string[6] { "ui_error_user_rename_too_short", "ui_error_user_rename_too_long", "ui_error_user_rename_uncapitalized", "ui_error_user_rename_invalid_character_found", "ui_error_user_rename_profanity_found", "ui_error_user_rename_name_not_unique" };
		NumInvitesLocString = "ui_profile_btn_invite_numInvites";
	}
}
