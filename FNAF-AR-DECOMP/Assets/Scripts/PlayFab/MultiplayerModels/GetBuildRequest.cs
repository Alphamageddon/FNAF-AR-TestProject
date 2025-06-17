using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetBuildRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetBuildRequest()
        {
        
        }
    
    }

}
