using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetAccountInfoResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserAccountInfo AccountInfo;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetAccountInfoResult()
        {
        
        }
    
    }

}
