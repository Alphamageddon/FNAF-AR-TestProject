using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ScriptExecutionError : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Error;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Message;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StackTrace;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScriptExecutionError()
        {
        
        }
    
    }

}
