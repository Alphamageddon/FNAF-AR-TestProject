using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HeartbeatPeriodResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string HeartbeatPeriodKey = "HeartbeatPeriod";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> OnHeartbeatPeriodReceivedFromServer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<float> callback)
        {
            this.OnHeartbeatPeriodReceivedFromServer = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            System.Nullable<System.Single> val_1 = data.GetFloat(key:  "HeartbeatPeriod");
            if(((-900316168) & 1) == 0)
            {
                    return;
            }
            
            this = this.OnHeartbeatPeriodReceivedFromServer;
            this.Invoke(obj:  V0.16B);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HeartbeatPeriodResponseHandler()
        {
        
        }
    
    }

}
