using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetAccountInfoRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Email;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleDisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Username;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetAccountInfoRequest()
        {
        
        }
    
    }

}
