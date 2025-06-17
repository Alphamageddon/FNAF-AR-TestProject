using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPhotonAuthenticationTokenRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PhotonApplicationId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPhotonAuthenticationTokenRequest()
        {
        
        }
    
    }

}
