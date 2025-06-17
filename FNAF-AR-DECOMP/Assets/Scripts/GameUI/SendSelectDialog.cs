using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SendSelectDialog : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string LocalizedStringId_Send = "ui_friend_cell_send_button_text";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string LocalizedStringId_Sent = "ui_friend_cell_send_button_text";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform listParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.FriendSelectCell friendSelectCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject noFriendsTextObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.FriendSelectCell> _sendListCells;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> _friendsList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _SendSlotIdToUserId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.ProfileAvatarSet> _profileAvatarConfigs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _enableSending;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_FriendListUpdated(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> obj)
        {
            this._masterDomain.eventExposer.remove_FriendListUpdated(value:  new System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>>(object:  this, method:  System.Void GameUI.SendSelectDialog::EventExposer_FriendListUpdated(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> obj)));
            this.PopulateSelectList(friendsList:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool SendingIsEnabled()
        {
            return (bool)this._enableSending;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendAnimatronicDelegate(string userId)
        {
            this._enableSending = false;
            if(this._SendSlotIdToUserId == null)
            {
                    return;
            }
            
            this._SendSlotIdToUserId.Invoke(obj:  userId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PopulateSelectList(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> friendsList)
        {
            this._friendsList.Clear();
            this._friendsList = friendsList;
            this.noFriendsTextObject.SetActive(value:  (friendsList.Count == 0) ? 1 : 0);
            this.CreateFriendCells();
            this.PopulateFriendList();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PopulateFriendList()
        {
            var val_3;
            object val_16;
            Game.Server.PlayerFriendsEntry val_17;
            System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> val_18;
            UnityEngine.Sprite val_19;
            val_16 = this;
            List.Enumerator<T> val_1 = this._friendsList.GetEnumerator();
            label_16:
            if(((-1269893680) & 1) == 0)
            {
                    return;
            }
            
            new SendSelectDialog.<>c__DisplayClass15_0() = new System.Object();
            GameUI.EmailUIDataHandler val_5 = val_3.emailUIDataHandler;
            if((new SendSelectDialog.<>c__DisplayClass15_0()) != null)
            {
                    val_17 = new SendSelectDialog.<>c__DisplayClass15_0();
                .playerFriendsEntry = val_5;
                val_18 = this._friendsList;
            }
            else
            {
                    mem[16] = val_5;
                val_18 = this._friendsList;
                val_17 = 16;
            }
            
            GameUI.FriendSelectCell val_7 = this._sendListCells.Item[val_18.IndexOf(item:  val_17)];
            new GameUI.FriendsListCellData() = new GameUI.FriendsListCellData();
            .playerFriendsEntry = mem[16];
            System.Action<System.String> val_9 = new System.Action<System.String>(object:  this, method:  System.Void GameUI.SendSelectDialog::SendAnimatronicDelegate(string userId));
            .callback = null;
            System.Func<System.Boolean> val_10 = new System.Func<System.Boolean>(object:  this, method:  System.Boolean GameUI.SendSelectDialog::SendingIsEnabled());
            .getSendingEnabled = null;
            val_7.SetData(data:  new GameUI.FriendsListCellData());
            System.Predicate<GameUI.ProfileAvatarSet> val_11 = new System.Predicate<GameUI.ProfileAvatarSet>(object:  new SendSelectDialog.<>c__DisplayClass15_0(), method:  System.Boolean SendSelectDialog.<>c__DisplayClass15_0::<PopulateFriendList>b__0(GameUI.ProfileAvatarSet x));
            GameUI.ProfileAvatarSet val_12 = this._profileAvatarConfigs.Find(match:  null);
            var val_13 = (val_12 == 0) ? 0 : (val_12);
            if(val_12 == null)
            {
                goto label_11;
            }
            
            val_19 = mem[val_12 == null ? 0 : val_12 + 24];
            val_19 = val_12 == null ? 0 : val_12 + 24;
            if(val_7 != null)
            {
                goto label_15;
            }
            
            goto label_14;
            label_11:
            val_19 = 0;
            if(val_7 != null)
            {
                goto label_15;
            }
            
            label_14:
            label_15:
            val_7.SetSprite(sprite:  val_19);
            goto label_16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateFriendCells()
        {
            int val_3 = this._friendsList.Count - this._sendListCells.Count;
            if(val_3 >= 1)
            {
                    do
            {
                this._sendListCells.Add(item:  UnityEngine.Object.Instantiate<GameUI.FriendSelectCell>(original:  this.friendSelectCellPrefab, parent:  this.listParent));
                val_3 = val_3 - 1;
            }
            while(val_3 != 0);
            
                return;
            }
            
            if(val_3 == 0)
            {
                    return;
            }
            
            this._sendListCells.RemoveRange(index:  0, count:  -val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void QueryFriendsList()
        {
            this._masterDomain.eventExposer.add_FriendListUpdated(value:  new System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>>(object:  this, method:  System.Void GameUI.SendSelectDialog::EventExposer_FriendListUpdated(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> obj)));
            this._masterDomain.serverDomain.getPlayerFriendsRequester.GetPlayerFriends();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReenableSendSelect()
        {
            this._enableSending = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetupSendSelectDialog(Master.MasterDomain masterDomain, System.Action<string> sendSelectedSlotToUserId, System.Collections.Generic.List<GameUI.ProfileAvatarSet> profileAvatarConfigs)
        {
            this._masterDomain = masterDomain;
            this._SendSlotIdToUserId = sendSelectedSlotToUserId;
            this._profileAvatarConfigs = profileAvatarConfigs;
            this.QueryFriendsList();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SendSelectDialog()
        {
            this._sendListCells = new System.Collections.Generic.List<GameUI.FriendSelectCell>();
            this._friendsList = new System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>();
            this._enableSending = true;
        }
    
    }

}
