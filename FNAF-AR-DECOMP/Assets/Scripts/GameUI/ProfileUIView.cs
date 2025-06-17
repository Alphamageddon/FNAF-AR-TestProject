using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfileUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Profile dialogHandler_Profile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ProfileUIActions profileUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.TabParentKeyValue> tabParents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private HighlightToggle profileButtonHighlightToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private HighlightToggle friendsButtonHighlightToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private HighlightToggle leaderboardButtonHighlightToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI userNameText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI maxStreakNumText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI currentStreakNumText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI TotalRemnantNumText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_InputField nameInputField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject errorPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI errorMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform avatarCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AvatarCell avatarCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AvatarCell mainAvatarImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform friendsCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.FriendRemoveCell friendsCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI numInvitesText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button inviteFriendButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform leaderboardCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.LeaderboardCell leaderboardCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject friendCodePanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI generatedFriendCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_InputField enteredFriendCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI addFriendDefaultText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI addFriendErrorText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button[] addFriendButtons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.MenuTabsHandler menuTabsHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ProfileTabHandler profileTabHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ProfileTabData profileTabData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AvatarSelectionHandler avatarSelectionHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.FriendsListTabHandler friendsListTabHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.FriendsListTabData friendsListTabData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.FriendCodeModel friendCodeModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.LeaderboardTabHandler leaderboardTabHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.LeaderboardTabData leaderboardTabData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.GetSocialInviteHandling.FazPassData fazPassData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string[] UserNameSetErrorStrings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string NumInvitesLocString;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_PersonalFriendCodeUpdate(string personalFriendCode)
        {
            this.generatedFriendCode.text = personalFriendCode;
            this.dialogHandler_Profile.DismissAddFriendDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_PlayerProfileUpdated(Server.PlayerProfile obj)
        {
            this.UpdatePlayerAvatar();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_DisplayNameObscenityFound(GameUI.UserNameSetError error)
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            string val_6 = this.UserNameSetErrorStrings[(long)error];
            var val_7 = 0;
            val_7 = val_7 + 1;
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.ShowError(message:  val_1.ILocalization.GetLocalizedString(localizedStringId:  val_6, originalString:  val_6)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateFazPassInfo()
        {
            this.numInvitesText.gameObject.SetActive(value:  this.fazPassData.IsFazPassInEffect);
            if(this.fazPassData.IsFazPassInEffect == false)
            {
                    return;
            }
            
            if(this.fazPassData.NumInvites != 0)
            {
                    return;
            }
            
            this.inviteFriendButton.interactable = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DidSwitchTabs(GameUI.Tab tab)
        {
            if(tab == 0)
            {
                goto label_0;
            }
            
            if(tab == 2)
            {
                goto label_1;
            }
            
            if(tab != 1)
            {
                    return;
            }
            
            this.leaderboardTabHandler.ClearLeaderboard();
            return;
            label_0:
            this.leaderboardTabHandler.ClearLeaderboard();
            label_1:
            this.friendsListTabHandler.ClearFriendsList();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WillSwitchTabs(GameUI.Tab tab)
        {
            if(tab == 0)
            {
                goto label_0;
            }
            
            if(tab == 2)
            {
                goto label_1;
            }
            
            if(tab != 1)
            {
                    return;
            }
            
            this.friendsListTabHandler.PopulateFriendsTab();
            this.UpdateNumInvitesText();
            return;
            label_0:
            this.UpdatePlayerAvatar();
            return;
            label_1:
            this.leaderboardTabHandler.PopulateLeaderboardTab();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeData()
        {
            GameUI.AvatarCell val_4;
            GameUI.FriendRemoveCell val_5;
            UnityEngine.Transform val_6;
            GameUI.ProfileTabData val_1 = new GameUI.ProfileTabData();
            if(val_1 != null)
            {
                    .userNameText = this.userNameText;
                .maxStreakNumText = this.maxStreakNumText;
                .currentStreakNumText = this.currentStreakNumText;
                .totalRemnantNumText = this.TotalRemnantNumText;
                .tMP_Input = this.nameInputField;
                val_4 = this.mainAvatarImage;
            }
            else
            {
                    mem[16] = this.userNameText;
                mem[24] = this.maxStreakNumText;
                mem[32] = this.currentStreakNumText;
                mem[40] = this.TotalRemnantNumText;
                mem[48] = this.nameInputField;
                val_4 = this.mainAvatarImage;
            }
            
            .avatarImage = val_4;
            this.profileTabData = val_1;
            GameUI.FriendsListTabData val_2 = new GameUI.FriendsListTabData();
            if(val_2 != null)
            {
                    .cellParent = this.friendsCellParent;
                val_5 = this.friendsCellPrefab;
            }
            else
            {
                    mem[16] = this.friendsCellParent;
                val_5 = this.friendsCellPrefab;
            }
            
            .friendSelectCellPrefab = val_5;
            this.friendsListTabData = val_2;
            GameUI.LeaderboardTabData val_3 = new GameUI.LeaderboardTabData();
            if(val_3 != null)
            {
                    .leaderboardCellPrefab = this.leaderboardCellPrefab;
                val_6 = this.leaderboardCellParent;
            }
            else
            {
                    mem[24] = this.leaderboardCellPrefab;
                val_6 = this.leaderboardCellParent;
            }
            
            .cellParent = val_6;
            this.leaderboardTabData = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator ShowError(string message)
        {
            ProfileUIView.<ShowError>d__48 val_1 = new ProfileUIView.<ShowError>d__48(<>1__state:  0);
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .message = message;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddSubcriptions()
        {
            this._masterDomain.eventExposer.add_PlayerProfileUpdated(value:  new System.Action<Server.PlayerProfile>(object:  this, method:  System.Void GameUI.ProfileUIView::EventExposer_PlayerProfileUpdated(Server.PlayerProfile obj)));
            this._masterDomain.eventExposer.add_DisplayNameObscenityFound(value:  new System.Action<GameUI.UserNameSetError>(object:  this, method:  System.Void GameUI.ProfileUIView::EventExposer_DisplayNameObscenityFound(GameUI.UserNameSetError error)));
            this._masterDomain.eventExposer.add_PersonalFriendCodeUpdated(value:  new System.Action<System.String>(object:  this, method:  System.Void GameUI.ProfileUIView::EventExposer_PersonalFriendCodeUpdate(string personalFriendCode)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveSubcriptions()
        {
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.remove_PlayerProfileUpdated(value:  new System.Action<Server.PlayerProfile>(object:  this, method:  System.Void GameUI.ProfileUIView::EventExposer_PlayerProfileUpdated(Server.PlayerProfile obj)));
            this._masterDomain.eventExposer.remove_DisplayNameObscenityFound(value:  new System.Action<GameUI.UserNameSetError>(object:  this, method:  System.Void GameUI.ProfileUIView::EventExposer_DisplayNameObscenityFound(GameUI.UserNameSetError error)));
            this._masterDomain.eventExposer.remove_PersonalFriendCodeUpdated(value:  new System.Action<System.String>(object:  this, method:  System.Void GameUI.ProfileUIView::EventExposer_PersonalFriendCodeUpdate(string personalFriendCode)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetGeneratedFriendCode()
        {
            if(this.generatedFriendCode != null)
            {
                    return this.generatedFriendCode.text;
            }
            
            return this.generatedFriendCode.text;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectedAvatar()
        {
            this.UpdatePlayerAvatar();
            this._masterDomain.eventExposer.OnPlayerAvatarUpdated();
            this.dialogHandler_Profile.DismissAvatarSelectDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdatePlayerAvatar()
        {
            this.profileTabHandler.RefreshAvatarIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAvatarSelectionDialog()
        {
            this.avatarSelectionHandler.GenerateCells();
            this.dialogHandler_Profile.ShowAvatarSelectionDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowTab(GameUI.Tab tab)
        {
            this.menuTabsHandler.ShowTab(tab:  tab);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowErrorOnName()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ShowError(message:  0));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ChangeTopPanelHighlight(GameUI.Tab tab)
        {
            this.profileButtonHighlightToggle.SetHighlight(value:  (tab == 0) ? 1 : 0);
            this.friendsButtonHighlightToggle.SetHighlight(value:  (tab == 1) ? 1 : 0);
            this.leaderboardButtonHighlightToggle.SetHighlight(value:  (tab == 2) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateNumInvitesText()
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.numInvitesText.text = val_1.ILocalization.GetLocalizedString(localizedStringId:  this.NumInvitesLocString, originalString:  "Num invites left:")(val_1.ILocalization.GetLocalizedString(localizedStringId:  this.NumInvitesLocString, originalString:  "Num invites left:")) + " " + this.fazPassData.NumInvites;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DisableInviteButton()
        {
            this.inviteFriendButton.interactable = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowFriendCodeScreen()
        {
            this.generatedFriendCode.text = this.friendCodeModel._myCurrentFriendCode;
            this.friendCodePanel.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DisplayAddFriendCodeError()
        {
            this.addFriendDefaultText.gameObject.SetActive(value:  false);
            this.addFriendErrorText.gameObject.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideFriendCodeScreen()
        {
            this.friendCodePanel.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAddFriend()
        {
            this.addFriendDefaultText.gameObject.SetActive(value:  true);
            this.addFriendErrorText.gameObject.SetActive(value:  false);
            this.dialogHandler_Profile.ShowAddFriendAlert();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideAddFriend()
        {
            this.dialogHandler_Profile.DismissAddFriendDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRefreshFriendCodeConfirmation()
        {
            this.dialogHandler_Profile.ShowRefreshFriendCodeConfirmation();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideFriendCodeRefreshConfirmation()
        {
            this.dialogHandler_Profile.DismissFriendCodeChangeDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAddFriendButtonsEnabled(bool enabled)
        {
            goto label_0;
            label_5:
            this.addFriendButtons[0].enabled = enabled;
            0 = 1;
            label_0:
            if(0 < this.addFriendButtons.Length)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetRequestedFriendCode()
        {
            if(this.enteredFriendCode != null)
            {
                    return this.enteredFriendCode.text;
            }
            
            return this.enteredFriendCode.text;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.InitializeData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            .tabParents = this.tabParents;
            .DidSwitchTabs = new System.Action<GameUI.Tab>(object:  this, method:  System.Void GameUI.ProfileUIView::DidSwitchTabs(GameUI.Tab tab));
            .WillSwitchTabs = new System.Action<GameUI.Tab>(object:  this, method:  System.Void GameUI.ProfileUIView::WillSwitchTabs(GameUI.Tab tab));
            this.menuTabsHandler = new GameUI.MenuTabsHandler();
            this.profileTabHandler = new GameUI.ProfileTabHandler(masterDomain:  this._masterDomain, profileUIActions:  this.profileUIActions, profileTabData:  this.profileTabData);
            GameUI.Domain val_7 = this._masterDomain.gameUIDomain;
            this.avatarSelectionHandler = new GameUI.AvatarSelectionHandler(avatarCellParent:  this.avatarCellParent, avatarCellPrefab:  this.avatarCellPrefab, SelectAvatarCell:  new System.Action<System.String>(object:  this.profileUIActions, method:  public System.Void GameUI.ProfileUIActions::SelectAvatarCell(string avatarId)), availableAvatars:  val_7.profileAvatarConfigs);
            this.friendsListTabHandler = new GameUI.FriendsListTabHandler(masterDomain:  this._masterDomain, friendsListTabData:  this.friendsListTabData, dialogHandler:  this.dialogHandler_Profile);
            this.leaderboardTabHandler = new GameUI.LeaderboardTabHandler(masterDomain:  this._masterDomain, leaderboardTabData:  this.leaderboardTabData);
            this.fazPassData = this._masterDomain.getSocialDomain.fazPassData;
            GameUI.Domain val_11 = this._masterDomain.gameUIDomain;
            this.friendCodeModel = this._masterDomain.getSocialDomain.fazPassData;
            this.AddSubcriptions();
            this.UpdatePlayerAvatar();
            this.ShowTab(tab:  0);
            this.UpdateFazPassInfo();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.profileTabHandler.UpdateProfileStreakDisplays();
            this.profileTabHandler.UpdatePlayerProfileNameDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.RemoveSubcriptions();
            this.avatarSelectionHandler.OnDestroy();
            this.friendsListTabHandler.OnDestroy();
            this.leaderboardTabHandler.OnDestroy();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfileUIView()
        {
            string[] val_1 = new string[6];
            val_1[0] = "ui_error_user_rename_too_short";
            val_1[1] = "ui_error_user_rename_too_long";
            val_1[2] = "ui_error_user_rename_uncapitalized";
            val_1[3] = "ui_error_user_rename_invalid_character_found";
            val_1[4] = "ui_error_user_rename_profanity_found";
            val_1[5] = "ui_error_user_rename_name_not_unique";
            this.UserNameSetErrorStrings = val_1;
            this.NumInvitesLocString = "ui_profile_btn_invite_numInvites";
        }
    
    }

}
