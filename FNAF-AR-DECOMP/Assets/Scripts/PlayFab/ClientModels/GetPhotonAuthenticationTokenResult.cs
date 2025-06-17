using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPhotonAuthenticationTokenResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PhotonCustomAuthenticationToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPhotonAuthenticationTokenResult()
        {
        
        }
    
    }

}
