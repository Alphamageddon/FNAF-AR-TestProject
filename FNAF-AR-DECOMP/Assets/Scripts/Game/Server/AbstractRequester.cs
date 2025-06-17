using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly Game.Server.LogEventHandler logEventHandler;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AbstractRequester(Game.Server.LogEventHandler eventHandler)
        {
            this.logEventHandler = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static void NullResponse(Systems.Server.ServerResponse response)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static void NullErrorResponse(Systems.Server.ServerData serverData)
        {
        
        }
    
    }

}
