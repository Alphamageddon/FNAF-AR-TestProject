using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkKongregateAccountRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AuthTicket;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string KongregateId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkKongregateAccountRequest()
        {
        
        }
    
    }

}
