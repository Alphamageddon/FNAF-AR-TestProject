using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreIdChangedResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<string> StoreIdReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<string> callback)
        {
            this.StoreIdReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            var val_3;
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "StoreItems");
            if(val_1 == null)
            {
                    return;
            }
            
            string val_2 = val_1.ConvertPlayFabResponse(data:  val_1);
            val_3 = null;
            val_3 = null;
            Game.Server.ServerDomain.StoreName = val_2;
            if(this.StoreIdReceived == null)
            {
                    return;
            }
            
            this.StoreIdReceived.Invoke(obj:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ConvertPlayFabResponse(Systems.Server.ServerData data)
        {
            string val_1 = data.GetString(key:  "StoreId");
            return (string)(val_1 == null) ? "" : (val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreIdChangedResponseHandler()
        {
        
        }
    
    }

}
