using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkFacebookInstantGamesIdRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FacebookInstantGamesSignature;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkFacebookInstantGamesIdRequest()
        {
        
        }
    
    }

}
