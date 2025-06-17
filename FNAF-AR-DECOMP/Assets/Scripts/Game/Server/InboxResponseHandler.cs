using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<GameUI.EmailData>> OnInboxDataReceivedFromServer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<Systems.Server.ServerData, GameUI.EmailData> EmailDataLoader;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Func<Systems.Server.ServerData, GameUI.EmailData> inboxLoadFunc, System.Action<System.Collections.Generic.List<GameUI.EmailData>> callback)
        {
            this.OnInboxDataReceivedFromServer = callback;
            this.EmailDataLoader = inboxLoadFunc;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "Inbox");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponseV2(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponseV2(Systems.Server.ServerData data)
        {
            var val_14;
            var val_15;
            System.Collections.Generic.List<GameUI.EmailData> val_1 = new System.Collections.Generic.List<GameUI.EmailData>();
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = data.BaseData.Keys.GetEnumerator();
            label_26:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_1.Add(item:  this.EmailDataLoader.Invoke(arg:  data.GetServerData(key:  val_6.Current)));
            goto label_26;
            label_17:
            val_14 = 0;
            val_15 = 82;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_6.Dispose();
            }
            
            this.OnInboxDataReceivedFromServer.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxResponseHandler()
        {
        
        }
    
    }

}
