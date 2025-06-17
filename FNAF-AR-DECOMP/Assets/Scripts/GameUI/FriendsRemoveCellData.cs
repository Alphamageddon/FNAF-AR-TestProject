using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FriendsRemoveCellData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<string, GameUI.FriendRemoveCell> callback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PlayerFriendsEntry playerFriendsEntry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string buttonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Func<bool> getSendingEnabled;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FriendsRemoveCellData()
        {
        
        }
    
    }

}
