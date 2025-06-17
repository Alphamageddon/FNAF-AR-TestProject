using System;
using PaperPlaneTools;
using UnityEngine;

public class DialogHandler_Profile : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public DialogHandler_Profile _003C_003E4__this;

		public string userId;

		public Action<FriendRemoveCell> ConfirmedRemoveFriend;

		public FriendRemoveCell friendRemoveCell;

		internal void _003CShowRemoveFriendDialog_003Eb__0()
		{
			_003C_003E4__this.RemoveFriend(userId, ConfirmedRemoveFriend, friendRemoveCell);
		}
	}

	public const string REMOVE_FRIEND_TITLE = "ui_delete_friend_confirm_text";

	public const string REMOVE_FRIEND_YES = "ui_delete_friend_confirm_yes";

	public const string REMOVE_FRIEND_NO = "ui_delete_friend_confirm_no";

	[SerializeField]
	[Header("Dialog GameObjects")]
	private GameObject avatarSelectionDialog;

	[SerializeField]
	private GameObject addFriendDialog;

	[SerializeField]
	private GameObject friendCodeChangeConfirmationDialog;

	[SerializeField]
	private ProfileUIActions profileUIActions;

	private Alert avatarSelectionAlert;

	private Alert addFriendAlert;

	private Alert friendCodeChangeConfirmationAlert;

	private string _removeFriendTitle;

	private string _removeFriendYes;

	private string _removeFriendNo;

	private void RemoveFriend(string id, Action<FriendRemoveCell> ConfirmedRemoveFriend, FriendRemoveCell friendRemoveCell)
	{
		ConfirmedRemoveFriend(friendRemoveCell);
		profileUIActions.RemoveFriend(id);
	}

	public void ShowAvatarSelectionDialog()
	{
		AlertUtilities.ShowAlertWithAndroidBackButtonAction(avatarSelectionAlert, ShowAvatarSelectionDialogb__14_0);
	}

	public void ShowAddFriendAlert()
	{
		AlertUtilities.ShowAlertWithAndroidBackButtonAction(addFriendAlert, ShowAddFriendAlertb__15_0);
	}

	public void ShowRefreshFriendCodeConfirmation()
	{
		AlertUtilities.ShowAlertWithAndroidBackButtonAction(friendCodeChangeConfirmationAlert, ShowRefreshFriendCodeConfirmationb__16_0);
	}

	public void ShowRemoveFriendDialog(string userId, Action<FriendRemoveCell> ConfirmedRemoveFriend, FriendRemoveCell friendRemoveCell)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass17_.userId = userId;
		_003C_003Ec__DisplayClass17_.ConfirmedRemoveFriend = ConfirmedRemoveFriend;
		_003C_003Ec__DisplayClass17_.friendRemoveCell = friendRemoveCell;
		GenericDialogData genericDialogData = new GenericDialogData();
		genericDialogData.title = _removeFriendTitle;
		genericDialogData.negativeButtonText = _removeFriendNo;
		genericDialogData.positiveButtonText = _removeFriendYes;
		genericDialogData.positiveButtonAction = _003C_003Ec__DisplayClass17_._003CShowRemoveFriendDialog_003Eb__0;
		MasterDomain.GetDomain().eventExposer.GenericDialogRequest(genericDialogData);
	}

	internal void DismissAvatarSelectDialog()
	{
		avatarSelectionAlert.Dismiss();
	}

	internal void DismissFriendCodeChangeDialog()
	{
		friendCodeChangeConfirmationAlert.Dismiss();
	}

	internal void DismissAddFriendDialog()
	{
		addFriendAlert.Dismiss();
	}

	private void Awake()
	{
		avatarSelectionAlert = new Alert();
		avatarSelectionAlert.SetAdapter(avatarSelectionDialog.GetComponent<IAlertPlatformAdapter>());
		addFriendAlert = new Alert();
		addFriendAlert.SetAdapter(addFriendDialog.GetComponent<IAlertPlatformAdapter>());
		friendCodeChangeConfirmationAlert = new Alert();
		friendCodeChangeConfirmationAlert.SetAdapter(friendCodeChangeConfirmationDialog.GetComponent<IAlertPlatformAdapter>());
		GetLocStrings();
	}

	private void GetLocStrings()
	{
		_removeFriendTitle = LocalizationDomain.Instance.Localization.GetLocalizedString("ui_delete_friend_confirm_text", "ui_delete_friend_confirm_text");
		_removeFriendYes = LocalizationDomain.Instance.Localization.GetLocalizedString("ui_delete_friend_confirm_yes", "ui_delete_friend_confirm_yes");
		_removeFriendNo = LocalizationDomain.Instance.Localization.GetLocalizedString("ui_delete_friend_confirm_no", "ui_delete_friend_confirm_no");
	}

	private void OnDestroy()
	{
		if (avatarSelectionAlert != null)
		{
			avatarSelectionAlert.Dismiss();
		}
		avatarSelectionAlert = null;
		if (addFriendAlert != null)
		{
			addFriendAlert.Dismiss();
		}
		addFriendAlert = null;
		if (friendCodeChangeConfirmationAlert != null)
		{
			friendCodeChangeConfirmationAlert.Dismiss();
		}
		friendCodeChangeConfirmationAlert = null;
	}

	private void ShowAvatarSelectionDialogb__14_0()
	{
		avatarSelectionAlert.Dismiss();
	}

	private void ShowAddFriendAlertb__15_0()
	{
		addFriendAlert.Dismiss();
	}

	private void ShowRefreshFriendCodeConfirmationb__16_0()
	{
		friendCodeChangeConfirmationAlert.Dismiss();
	}
}
