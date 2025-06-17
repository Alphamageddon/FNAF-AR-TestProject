using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayFabIDsFromTwitchIDsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> TwitchIds;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayFabIDsFromTwitchIDsRequest()
        {
        
        }
    
    }

}
