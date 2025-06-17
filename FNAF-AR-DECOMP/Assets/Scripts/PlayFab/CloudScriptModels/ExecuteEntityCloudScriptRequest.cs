using UnityEngine;

namespace PlayFab.CloudScriptModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ExecuteEntityCloudScriptRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.CloudScriptModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FunctionName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object FunctionParameter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> GeneratePlayStreamEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.CloudScriptModels.CloudScriptRevisionOption> RevisionSelection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> SpecificRevision;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ExecuteEntityCloudScriptRequest()
        {
        
        }
    
    }

}
