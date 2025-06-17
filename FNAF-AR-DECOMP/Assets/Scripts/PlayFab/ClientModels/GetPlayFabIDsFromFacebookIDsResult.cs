using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayFabIDsFromFacebookIDsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.FacebookPlayFabIdPair> Data;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayFabIDsFromFacebookIDsResult()
        {
        
        }
    
    }

}
