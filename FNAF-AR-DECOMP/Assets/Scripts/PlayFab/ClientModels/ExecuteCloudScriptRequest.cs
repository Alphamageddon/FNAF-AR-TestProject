using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ExecuteCloudScriptRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FunctionName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object FunctionParameter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> GeneratePlayStreamEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.CloudScriptRevisionOption> RevisionSelection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> SpecificRevision;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ExecuteCloudScriptRequest()
        {
        
        }
    
    }

}
