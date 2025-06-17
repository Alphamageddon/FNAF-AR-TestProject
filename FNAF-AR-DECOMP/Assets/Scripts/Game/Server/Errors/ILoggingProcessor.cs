using UnityEngine;

namespace Game.Server.Errors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ILoggingProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string Log(string className, Systems.Server.ServerData data); // 0
    
    }

}
