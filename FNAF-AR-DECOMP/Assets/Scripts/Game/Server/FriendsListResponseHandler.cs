using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FriendsListResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>> OnFriendsListUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>> callback)
        {
            this.OnFriendsListUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "friendsList");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(friendsListData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData friendsListData)
        {
            var val_14;
            var val_15;
            System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> val_1 = new System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>();
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = friendsListData.BaseData.Keys.GetEnumerator();
            label_25:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_1.Add(item:  Game.Server.Processors.ServerProcessors.ProcessPlayerFriendsEntry(entry:  friendsListData.GetServerData(key:  val_6.Current)));
            goto label_25;
            label_17:
            val_14 = 0;
            val_15 = 72;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_6.Dispose();
            }
            
            this.OnFriendsListUpdated.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FriendsListResponseHandler()
        {
        
        }
    
    }

}
