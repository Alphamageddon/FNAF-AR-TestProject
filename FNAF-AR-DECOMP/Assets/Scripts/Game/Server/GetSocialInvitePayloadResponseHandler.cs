using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GetSocialInvitePayloadResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> PayloadReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<string> callback)
        {
            this.PayloadReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "payload");
            if(val_1 == null)
            {
                    return;
            }
            
            this.PayloadReceived.Invoke(obj:  val_1.JSON);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialInvitePayloadResponseHandler()
        {
        
        }
    
    }

}
