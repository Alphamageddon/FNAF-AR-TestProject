using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TimeResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<long> ServerTimeReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<long> callback)
        {
            this.ServerTimeReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            System.Nullable<System.Int64> val_1 = data.GetLong(key:  "Time");
            if(( & 1) == 0)
            {
                    return;
            }
            
            this.HandleResponse(timeRef:  new System.Nullable<System.Int64>() {HasValue = val_1.HasValue});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(System.Nullable<long> timeRef)
        {
            this.ServerTimeReceived.Invoke(obj:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TimeResponseHandler()
        {
        
        }
    
    }

}
