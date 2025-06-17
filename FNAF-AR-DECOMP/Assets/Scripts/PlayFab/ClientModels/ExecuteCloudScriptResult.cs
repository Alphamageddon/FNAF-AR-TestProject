using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ExecuteCloudScriptResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int APIRequestsIssued;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.ScriptExecutionError Error;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double ExecutionTimeSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FunctionName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object FunctionResult;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> FunctionResultTooLarge;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int HttpRequestsIssued;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.LogStatement> Logs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> LogsTooLarge;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint MemoryConsumedBytes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double ProcessorTimeSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Revision;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ExecuteCloudScriptResult()
        {
        
        }
    
    }

}
