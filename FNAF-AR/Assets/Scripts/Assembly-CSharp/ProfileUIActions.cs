using UnityEngine;

public class ProfileUIActions : MonoBehaviour
{
	[SerializeField]
	private ProfileUIView profileUIView;

	private MasterDomain _masterDomain;

	public void ShowProfile()
	{
		profileUIView.ShowTab(Tab.profile);
	}

	public void ShowFriends()
	{
		profileUIView.ShowTab(Tab.friends);
	}

	public void ShowLeaderboard()
	{
		profileUIView.ShowTab(Tab.leaderboard);
	}

	public void SelectGlobalXP()
	{
	}

	public void SelectWeeklyFriendXP()
	{
	}

	public void SelectWeeklyFriendWins()
	{
	}

	public void ShowAvatarSelectionDialog()
	{
		profileUIView.ShowAvatarSelectionDialog();
	}

	public void SelectAvatarCell(string avatarId)
	{
		_masterDomain.TheGameDomain.loginDomain.playerProfile.avatarId = avatarId;
		_masterDomain.ServerDomain.avatarSaveRequester.SaveAvatarId(avatarId);
		profileUIView.SelectedAvatar();
	}

	public void MakeInvite()
	{
	}

	public void OpenFriendCode()
	{
		profileUIView.ShowFriendCodeScreen();
	}

	public void CloseFriendCode()
	{
		profileUIView.HideFriendCodeScreen();
	}

	public void OpenAddFriend()
	{
		profileUIView.ShowAddFriend();
	}

	public void CancelAddFriendCode()
	{
		profileUIView.HideAddFriend();
	}

	public void ConfirmAddFriendCode()
	{
		string requestedFriendCode = profileUIView.GetRequestedFriendCode();
		if (!string.IsNullOrEmpty(requestedFriendCode))
		{
			profileUIView.SetAddFriendButtonsEnabled(enabled: false);
			_masterDomain.ServerDomain.friendCodeRequester.RequestFriendByCode(requestedFriendCode);
		}
	}

	private void EventExposer_FriendCodeLookedUp(FriendCodeResponseHandler.FriendLookupResponse response)
	{
		profileUIView.SetAddFriendButtonsEnabled(enabled: true);
		if (!(profileUIView == null))
		{
			if (response == FriendCodeResponseHandler.FriendLookupResponse.SUCCESS)
			{
				profileUIView.HideAddFriend();
			}
			else
			{
				profileUIView.DisplayAddFriendCodeError();
			}
		}
	}

	public void ConfirmRefreshFriendCode()
	{
		_masterDomain.ServerDomain.friendCodeRequester.RefreshCode(_003CConfirmRefreshFriendCode_003Eb__19_0);
		profileUIView.HideFriendCodeRefreshConfirmation();
	}

	private void _003CConfirmRefreshFriendCode_003Eb__19_0()
	{
	}

	public void CancelRefreshFriendCode()
	{
		profileUIView.HideFriendCodeRefreshConfirmation();
	}

	public void CopyFriendCode()
	{
		TextEditor textEditor = new TextEditor();
		textEditor.text = profileUIView.GetGeneratedFriendCode();
		textEditor.SelectAll();
		textEditor.Copy();
	}

	public void ShareFriendCode()
	{
	}

	public void RefreshFriendCode()
	{
		profileUIView.ShowRefreshFriendCodeConfirmation();
	}

	public void DecrementNumInvites()
	{
		profileUIView.UpdateNumInvitesText();
		profileUIView.DisableInviteButton();
	}

	public void ChangeTopPanel(Tab tab)
	{
		profileUIView.ChangeTopPanelHighlight(tab);
	}

	public void RemoveFriend(string userId)
	{
		_masterDomain.ServerDomain.removeFriendRequester.RemoveFriend(userId);
	}

	private void Start()
	{
		_masterDomain = MasterDomain.GetDomain();
		AddSubscriptions();
	}

	private void OnDestroy()
	{
		RemoveSubscriptions();
	}

	private void AddSubscriptions()
	{
		_masterDomain.eventExposer.add_FriendCodeLookedUp(EventExposer_FriendCodeLookedUp);
	}

	private void RemoveSubscriptions()
	{
		if (_masterDomain.eventExposer != null)
		{
			_masterDomain.eventExposer.remove_FriendCodeLookedUp(EventExposer_FriendCodeLookedUp);
		}
	}
}
