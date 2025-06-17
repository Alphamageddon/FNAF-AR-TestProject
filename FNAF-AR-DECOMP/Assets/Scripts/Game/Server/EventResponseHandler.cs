using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface EventResponseHandler
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TryHandleResponse(Systems.Server.ServerData data); // 0
    
    }

}
