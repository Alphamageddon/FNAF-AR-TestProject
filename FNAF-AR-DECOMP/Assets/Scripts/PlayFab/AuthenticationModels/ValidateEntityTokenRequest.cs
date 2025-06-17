using UnityEngine;

namespace PlayFab.AuthenticationModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ValidateEntityTokenRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ValidateEntityTokenRequest()
        {
        
        }
    
    }

}
