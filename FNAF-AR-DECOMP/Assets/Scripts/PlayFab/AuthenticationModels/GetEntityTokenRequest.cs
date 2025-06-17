using UnityEngine;

namespace PlayFab.AuthenticationModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetEntityTokenRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.AuthenticationModels.EntityKey Entity;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetEntityTokenRequest()
        {
        
        }
    
    }

}
