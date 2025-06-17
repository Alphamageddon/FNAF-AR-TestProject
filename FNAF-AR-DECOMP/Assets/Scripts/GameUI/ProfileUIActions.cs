using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfileUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ProfileUIView profileUIView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.GameUI.Utilities.ChangeDefaultDisplayNamePrompter _inviteHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.GetSocialInviteHandling.FazPassData _fazPassData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowProfile()
        {
            this.profileUIView.ShowTab(tab:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowFriends()
        {
            this.profileUIView.ShowTab(tab:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowLeaderboard()
        {
            this.profileUIView.ShowTab(tab:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAvatarSelectionDialog()
        {
            this.profileUIView.ShowAvatarSelectionDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectAvatarCell(string avatarId)
        {
            Server.LoginDomain val_2 = this._masterDomain.theGameDomain.loginDomain;
            val_2.playerProfile.avatarId = avatarId;
            this._masterDomain.serverDomain.avatarSaveRequester.SaveAvatarId(avatarId:  avatarId);
            this.profileUIView.SelectedAvatar();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MakeInvite()
        {
            this._inviteHandler.HandleInvite();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OpenFriendCode()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_OpenFriendCodeUI();
            this.profileUIView.ShowFriendCodeScreen();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CloseFriendCode()
        {
            this.profileUIView.HideFriendCodeScreen();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OpenAddFriend()
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_SelectEnterFriendCode();
            this.profileUIView.ShowAddFriend();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CancelAddFriendCode()
        {
            this.profileUIView.HideAddFriend();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ConfirmAddFriendCode()
        {
            string val_1 = this.profileUIView.GetRequestedFriendCode();
            if((System.String.IsNullOrEmpty(value:  val_1)) != false)
            {
                    return;
            }
            
            this.profileUIView.SetAddFriendButtonsEnabled(enabled:  false);
            this._masterDomain.serverDomain.friendCodeRequester.RequestFriendByCode(friendCode:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_FriendCodeLookedUp(Game.Server.FriendCodeResponseHandler.FriendLookupResponse response)
        {
            this.profileUIView.SetAddFriendButtonsEnabled(enabled:  true);
            if(this.profileUIView == null)
            {
                goto label_1;
            }
            
            if(response == 0)
            {
                goto label_2;
            }
            
            label_3:
            this.profileUIView.DisplayAddFriendCodeError();
            return;
            label_1:
            if(response != 0)
            {
                goto label_3;
            }
            
            label_2:
            this.profileUIView.HideAddFriend();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ConfirmRefreshFriendCode()
        {
            var val_2 = null;
            if((ProfileUIActions.<>c.<>9__16_0) == null)
            {
                goto label_5;
            }
            
            label_11:
            this._masterDomain.serverDomain.friendCodeRequester.RefreshCode(errorCallback:  ProfileUIActions.<>c.<>9__16_0);
            this.profileUIView.HideFriendCodeRefreshConfirmation();
            return;
            label_5:
            ProfileUIActions.<>c.<>9__16_0 = new System.Action(object:  ProfileUIActions.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ProfileUIActions.<>c::<ConfirmRefreshFriendCode>b__16_0());
            if(this._masterDomain.serverDomain.friendCodeRequester != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CancelRefreshFriendCode()
        {
            this.profileUIView.HideFriendCodeRefreshConfirmation();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CopyFriendCode()
        {
            UnityEngine.TextEditor val_1 = new UnityEngine.TextEditor();
            string val_2 = this.profileUIView.GetGeneratedFriendCode();
            if(val_1 != null)
            {
                    val_1.text = val_2;
                val_1.SelectAll();
            }
            else
            {
                    val_1.text = val_2;
                val_1.SelectAll();
            }
            
            val_1.Copy();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShareFriendCode()
        {
            .<>4__this = this;
            .payload = this.profileUIView.GetGeneratedFriendCode();
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  new ProfileUIActions.<>c__DisplayClass19_0(), method:  System.Void ProfileUIActions.<>c__DisplayClass19_0::<ShareFriendCode>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshFriendCode()
        {
            this.profileUIView.ShowRefreshFriendCodeConfirmation();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DecrementNumInvites()
        {
            this._fazPassData.decrementInvites();
            this.profileUIView.UpdateNumInvitesText();
            if(this._fazPassData.NumInvites != 0)
            {
                    return;
            }
            
            this.profileUIView.DisableInviteButton();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ChangeTopPanel(GameUI.Tab tab)
        {
            this.profileUIView.ChangeTopPanelHighlight(tab:  tab);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveFriend(string userId)
        {
            this._masterDomain.serverDomain.removeFriendRequester.RemoveFriend(userId:  userId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            this.AddSubscriptions();
            Game.GameUI.Utilities.ChangeDefaultDisplayNamePrompter val_2 = new Game.GameUI.Utilities.ChangeDefaultDisplayNamePrompter();
            this._inviteHandler = val_2;
            val_2.Setup(profileUiActions:  this, masterDomain:  this._masterDomain);
            this._fazPassData = this._masterDomain.getSocialDomain.fazPassData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.RemoveSubscriptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddSubscriptions()
        {
            this._masterDomain.eventExposer.add_FriendCodeLookedUp(value:  new System.Action<FriendLookupResponse>(object:  this, method:  System.Void GameUI.ProfileUIActions::EventExposer_FriendCodeLookedUp(Game.Server.FriendCodeResponseHandler.FriendLookupResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveSubscriptions()
        {
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.remove_FriendCodeLookedUp(value:  new System.Action<FriendLookupResponse>(object:  this, method:  System.Void GameUI.ProfileUIActions::EventExposer_FriendCodeLookedUp(Game.Server.FriendCodeResponseHandler.FriendLookupResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfileUIActions()
        {
        
        }
    
    }

}
