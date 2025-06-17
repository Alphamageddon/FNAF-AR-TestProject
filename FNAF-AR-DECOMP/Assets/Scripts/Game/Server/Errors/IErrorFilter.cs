using UnityEngine;

namespace Game.Server.Errors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IErrorFilter
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string ErrorString { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_ErrorString(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string Log(Game.Server.Errors.ILoggingProcessor processor, Systems.Server.ServerData data); // 0
    
    }

}
