using UnityEngine;

namespace Game.Server.Errors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RuntimeLoggingProcessor : ILoggingProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Log(string className, Systems.Server.ServerData data)
        {
            ConsoleLogger.LogError(className:  className, functionName:  "Log", logString:  "ERROR: "("ERROR: ") + data.JSON);
            return (string)System.String.alignConst;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RuntimeLoggingProcessor()
        {
        
        }
    
    }

}
