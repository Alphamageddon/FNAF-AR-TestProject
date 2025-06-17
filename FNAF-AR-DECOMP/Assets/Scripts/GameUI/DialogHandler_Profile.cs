using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DialogHandler_Profile : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string REMOVE_FRIEND_TITLE = "ui_delete_friend_confirm_text";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string REMOVE_FRIEND_YES = "ui_delete_friend_confirm_yes";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string REMOVE_FRIEND_NO = "ui_delete_friend_confirm_no";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject avatarSelectionDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject addFriendDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject friendCodeChangeConfirmationDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ProfileUIActions profileUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert avatarSelectionAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert addFriendAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PaperPlaneTools.Alert friendCodeChangeConfirmationAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _removeFriendTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _removeFriendYes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _removeFriendNo;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveFriend(string id, System.Action<GameUI.FriendRemoveCell> ConfirmedRemoveFriend, GameUI.FriendRemoveCell friendRemoveCell)
        {
            ConfirmedRemoveFriend.Invoke(obj:  friendRemoveCell);
            this.profileUIActions.RemoveFriend(userId:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAvatarSelectionDialog()
        {
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.avatarSelectionAlert, backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.DialogHandler_Profile::<ShowAvatarSelectionDialog>b__14_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowAddFriendAlert()
        {
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.addFriendAlert, backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.DialogHandler_Profile::<ShowAddFriendAlert>b__15_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRefreshFriendCodeConfirmation()
        {
            Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.friendCodeChangeConfirmationAlert, backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.DialogHandler_Profile::<ShowRefreshFriendCodeConfirmation>b__16_0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRemoveFriendDialog(string userId, System.Action<GameUI.FriendRemoveCell> ConfirmedRemoveFriend, GameUI.FriendRemoveCell friendRemoveCell)
        {
            string val_5;
            DialogHandler_Profile.<>c__DisplayClass17_0 val_1 = new DialogHandler_Profile.<>c__DisplayClass17_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .userId = userId;
                .ConfirmedRemoveFriend = ConfirmedRemoveFriend;
            }
            else
            {
                    mem[16] = this;
                mem[24] = userId;
                mem[32] = ConfirmedRemoveFriend;
            }
            
            .friendRemoveCell = friendRemoveCell;
            GameUI.GenericDialogData val_2 = new GameUI.GenericDialogData();
            if(val_2 != null)
            {
                    .title = this._removeFriendTitle;
                .negativeButtonText = this._removeFriendNo;
                val_5 = this._removeFriendYes;
            }
            else
            {
                    mem[16] = this._removeFriendTitle;
                mem[64] = this._removeFriendNo;
                val_5 = this._removeFriendYes;
            }
            
            .positiveButtonText = val_5;
            .positiveButtonAction = new System.Action(object:  val_1, method:  System.Void DialogHandler_Profile.<>c__DisplayClass17_0::<ShowRemoveFriendDialog>b__0());
            Master.MasterDomain val_4 = Master.MasterDomain.GetDomain();
            val_4.eventExposer.GenericDialogRequest(genericDialogData:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void DismissAvatarSelectDialog()
        {
            this.avatarSelectionAlert.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void DismissFriendCodeChangeDialog()
        {
            this.friendCodeChangeConfirmationAlert.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void DismissAddFriendDialog()
        {
            this.addFriendAlert.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            PaperPlaneTools.Alert val_1 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.avatarSelectionAlert = val_1;
            PaperPlaneTools.Alert val_3 = val_1.SetAdapter(adaper:  this.avatarSelectionDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_4 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.addFriendAlert = val_4;
            PaperPlaneTools.Alert val_6 = val_4.SetAdapter(adaper:  this.addFriendDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            PaperPlaneTools.Alert val_7 = new PaperPlaneTools.Alert(title:  0, message:  0);
            this.friendCodeChangeConfirmationAlert = val_7;
            PaperPlaneTools.Alert val_9 = val_7.SetAdapter(adaper:  this.friendCodeChangeConfirmationDialog.GetComponent<PaperPlaneTools.IAlertPlatformAdapter>());
            this.GetLocStrings();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetLocStrings()
        {
            var val_10;
            var val_11;
            var val_12;
            string val_13;
            var val_15;
            var val_16;
            var val_17;
            var val_19;
            val_10 = this;
            if(Game.Localization.LocalizationDomain.Instance == null)
            {
                goto label_1;
            }
            
            Game.Localization.ILocalization val_14 = val_1.ILocalization;
            var val_2 = (val_14 == 0) ? 0 : (val_10);
            if(val_14 == null)
            {
                goto label_2;
            }
            
            val_13 = "ui_delete_friend_confirm_text";
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_6;
            label_2:
            val_11 = 0;
            label_1:
            val_12 = val_10;
            goto label_7;
            label_6:
            val_15 = public System.String Game.Localization.ILocalization::GetLocalizedString(string localizedStringId, string originalString);
            val_11 = val_14;
            string val_4 = val_11.GetLocalizedString(localizedStringId:  val_13, originalString:  val_13);
            label_7:
            val_14 = (val_4 == null) ? "ui_delete_friend_confirm_text" : (val_4);
            mem2[0] = val_14;
            if(Game.Localization.LocalizationDomain.Instance == null)
            {
                goto label_9;
            }
            
            Game.Localization.ILocalization val_16 = val_5.ILocalization;
            var val_6 = (val_16 == 0) ? 0 : (val_10);
            if(val_16 == null)
            {
                goto label_10;
            }
            
            val_13 = "ui_delete_friend_confirm_yes";
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_14;
            label_10:
            val_16 = 0;
            label_9:
            val_17 = val_10;
            goto label_15;
            label_14:
            val_15 = public System.String Game.Localization.ILocalization::GetLocalizedString(string localizedStringId, string originalString);
            val_16 = val_16;
            string val_8 = val_16.GetLocalizedString(localizedStringId:  val_13, originalString:  val_13);
            label_15:
            val_16 = (val_8 == null) ? "ui_delete_friend_confirm_yes" : (val_8);
            mem2[0] = val_16;
            if(Game.Localization.LocalizationDomain.Instance == null)
            {
                goto label_23;
            }
            
            Game.Localization.ILocalization val_18 = val_9.ILocalization;
            if(val_18 == null)
            {
                goto label_18;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            goto label_22;
            label_18:
            val_19 = 0;
            goto label_23;
            label_22:
            val_19 = val_18;
            string val_12 = val_19.GetLocalizedString(localizedStringId:  "ui_delete_friend_confirm_no", originalString:  "ui_delete_friend_confirm_no");
            val_10 = (val_18 == 0) ? 0 : (val_10);
            label_23:
            val_18 = (val_12 == null) ? "ui_delete_friend_confirm_no" : (val_12);
            mem2[0] = val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this.avatarSelectionAlert != null)
            {
                    this.avatarSelectionAlert.Dismiss();
            }
            
            this.avatarSelectionAlert = 0;
            if(this.addFriendAlert != null)
            {
                    this.addFriendAlert.Dismiss();
            }
            
            this.addFriendAlert = 0;
            if(this.friendCodeChangeConfirmationAlert != null)
            {
                    this.friendCodeChangeConfirmationAlert.Dismiss();
            }
            
            this.friendCodeChangeConfirmationAlert = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogHandler_Profile()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowAvatarSelectionDialog>b__14_0()
        {
            this.avatarSelectionAlert.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowAddFriendAlert>b__15_0()
        {
            this.addFriendAlert.Dismiss();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowRefreshFriendCodeConfirmation>b__16_0()
        {
            this.friendCodeChangeConfirmationAlert.Dismiss();
        }
    
    }

}
