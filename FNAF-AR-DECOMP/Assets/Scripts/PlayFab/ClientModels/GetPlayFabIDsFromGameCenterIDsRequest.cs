using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayFabIDsFromGameCenterIDsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> GameCenterIDs;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayFabIDsFromGameCenterIDsRequest()
        {
        
        }
    
    }

}
