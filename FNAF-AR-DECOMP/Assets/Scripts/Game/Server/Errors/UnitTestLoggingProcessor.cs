using UnityEngine;

namespace Game.Server.Errors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UnitTestLoggingProcessor : ILoggingProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Log(string className, Systems.Server.ServerData data)
        {
            return className + ": "(": ") + data.JSON;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnitTestLoggingProcessor()
        {
        
        }
    
    }

}
