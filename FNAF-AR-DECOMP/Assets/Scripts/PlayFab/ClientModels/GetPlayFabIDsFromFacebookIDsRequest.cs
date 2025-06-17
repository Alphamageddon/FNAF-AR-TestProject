using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayFabIDsFromFacebookIDsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> FacebookIDs;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayFabIDsFromFacebookIDsRequest()
        {
        
        }
    
    }

}
