using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PassiveRequestListResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<string>> Callback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<System.Collections.Generic.List<string>> requestTimeCallback)
        {
            this.Callback = requestTimeCallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            System.Collections.Generic.List<System.String> val_1 = data.GetStringList(key:  "PassiveRequestList");
            if(val_1 == null)
            {
                    return;
            }
            
            this.Callback.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PassiveRequestListResponseHandler()
        {
        
        }
    
    }

}
