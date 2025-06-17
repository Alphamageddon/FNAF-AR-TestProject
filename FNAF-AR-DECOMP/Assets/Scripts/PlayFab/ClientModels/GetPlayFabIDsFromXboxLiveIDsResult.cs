using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayFabIDsFromXboxLiveIDsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.XboxLiveAccountPlayFabIdPair> Data;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayFabIDsFromXboxLiveIDsResult()
        {
        
        }
    
    }

}
