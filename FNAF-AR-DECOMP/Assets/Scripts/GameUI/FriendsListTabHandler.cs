using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FriendsListTabHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.FriendsListTabData friendsListTabData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.FriendRemoveCell> friendsListCells;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Profile _dialogHandler;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_FriendListUpdated(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> friendsList)
        {
            this.ClearFriendsList();
            this.GenerateFriendsList(friendsList:  friendsList);
            Systems.Analytics.AnalyticsCalls.FireEvent_Ui_UserHitNavigationButton_Friends(friendCount:  friendsList.Count);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateFriendsList(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> friendsList)
        {
            var val_3;
            object val_15;
            GameUI.FriendsListTabData val_16;
            GameUI.FriendRemoveCell val_17;
            UnityEngine.Sprite val_18;
            val_15 = this;
            List.Enumerator<T> val_1 = friendsList.GetEnumerator();
            label_19:
            if(((-1245730592) & 1) == 0)
            {
                    return;
            }
            
            new FriendsListTabHandler.<>c__DisplayClass5_0() = new System.Object();
            .playerFriendsEntry = val_3.emailUIDataHandler;
            val_16 = this.friendsListTabData;
            if(val_16 != null)
            {
                    val_17 = this.friendsListTabData.friendSelectCellPrefab;
            }
            else
            {
                    val_17 = this.friendsListTabData.friendSelectCellPrefab;
                if(this.friendsListTabData != null)
            {
                    val_16 = this.friendsListTabData;
            }
            else
            {
                    val_16 = 0;
            }
            
            }
            
            GameUI.FriendRemoveCell val_6 = UnityEngine.Object.Instantiate<GameUI.FriendRemoveCell>(original:  val_17, parent:  11993091);
            new GameUI.FriendsRemoveCellData() = new System.Object();
            .playerFriendsEntry = (FriendsListTabHandler.<>c__DisplayClass5_0)[1152921524836001088].playerFriendsEntry;
            System.Action<System.String, GameUI.FriendRemoveCell> val_8 = new System.Action<System.String, GameUI.FriendRemoveCell>(object:  this, method:  System.Void GameUI.FriendsListTabHandler::SelectFriendsListCell(string userId, GameUI.FriendRemoveCell friendRemoveCell));
            .callback = null;
            .buttonText = "X";
            val_6._data = new GameUI.FriendsRemoveCellData();
            val_6.UpdateText();
            GameUI.Domain val_9 = this._masterDomain.gameUIDomain;
            System.Predicate<GameUI.ProfileAvatarSet> val_10 = new System.Predicate<GameUI.ProfileAvatarSet>(object:  new FriendsListTabHandler.<>c__DisplayClass5_0(), method:  System.Boolean FriendsListTabHandler.<>c__DisplayClass5_0::<GenerateFriendsList>b__0(GameUI.ProfileAvatarSet x));
            GameUI.ProfileAvatarSet val_11 = val_9.profileAvatarConfigs.Find(match:  null);
            var val_12 = (val_11 == 0) ? 0 : (val_11);
            if(val_11 != null)
            {
                    val_18 = mem[val_11 == null ? 0 : val_11 + 24];
                val_18 = val_11 == null ? 0 : val_11 + 24;
            }
            else
            {
                    val_18 = 0;
            }
            
            val_6.SetSprite(sprite:  val_18);
            this.friendsListCells.Add(item:  val_6);
            goto label_19;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConfirmedRemoveFriend(GameUI.FriendRemoveCell cell)
        {
            UnityEngine.Object val_6;
            if((this.friendsListCells.Contains(item:  cell)) != false)
            {
                    bool val_2 = this.friendsListCells.Remove(item:  cell);
            }
            
            if(cell != null)
            {
                    val_6 = cell.gameObject;
            }
            else
            {
                    val_6 = 0;
            }
            
            if(val_6 == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  cell.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SelectFriendsListCell(string userId, GameUI.FriendRemoveCell friendRemoveCell)
        {
            this._dialogHandler.ShowRemoveFriendDialog(userId:  userId, ConfirmedRemoveFriend:  new System.Action<GameUI.FriendRemoveCell>(object:  this, method:  System.Void GameUI.FriendsListTabHandler::ConfirmedRemoveFriend(GameUI.FriendRemoveCell cell)), friendRemoveCell:  friendRemoveCell);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearFriendsList()
        {
            var val_3;
            List.Enumerator<T> val_1 = this.friendsListCells.GetEnumerator();
            label_13:
            if(((-1245213312) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            if((val_4 == 0) || (val_4.gameObject == 0))
            {
                goto label_13;
            }
            
            UnityEngine.Object.Destroy(obj:  val_4.gameObject);
            goto label_13;
            label_2:
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524836470144});
            this.friendsListCells.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FriendsListTabHandler(Master.MasterDomain masterDomain, GameUI.FriendsListTabData friendsListTabData, GameUI.DialogHandler_Profile dialogHandler)
        {
            val_1 = new System.Object();
            this.friendsListTabData = val_1;
            this.friendsListCells = new System.Collections.Generic.List<GameUI.FriendRemoveCell>();
            this._masterDomain = masterDomain;
            masterDomain.eventExposer.add_FriendListUpdated(value:  new System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>>(object:  this, method:  System.Void GameUI.FriendsListTabHandler::EventExposer_FriendListUpdated(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> friendsList)));
            this._dialogHandler = dialogHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopulateFriendsTab()
        {
            this._masterDomain.serverDomain.getPlayerFriendsRequester.GetPlayerFriends();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearFriendsFromList()
        {
            this.ClearFriendsList();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            this.ClearFriendsList();
            this.friendsListCells = 0;
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.remove_FriendListUpdated(value:  new System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>>(object:  this, method:  System.Void GameUI.FriendsListTabHandler::EventExposer_FriendListUpdated(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> friendsList)));
        }
    
    }

}
