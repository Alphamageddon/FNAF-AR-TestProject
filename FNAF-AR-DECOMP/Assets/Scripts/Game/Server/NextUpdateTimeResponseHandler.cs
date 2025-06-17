using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NextUpdateTimeResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<long> UpdateNextAnimatronicRequestTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<long> requestTimeCallback)
        {
            this.UpdateNextAnimatronicRequestTime = requestTimeCallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            System.Nullable<System.Int64> val_1 = data.GetLong(key:  "NextUpdateTime");
            if(( & 1) == 0)
            {
                    return;
            }
            
            this = this.UpdateNextAnimatronicRequestTime;
            this.Invoke(obj:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NextUpdateTimeResponseHandler()
        {
        
        }
    
    }

}
