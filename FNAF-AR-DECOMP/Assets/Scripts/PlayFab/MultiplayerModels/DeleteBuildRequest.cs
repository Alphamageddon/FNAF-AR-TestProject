using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class DeleteBuildRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeleteBuildRequest()
        {
        
        }
    
    }

}
