using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkSteamAccountRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SteamTicket;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkSteamAccountRequest()
        {
        
        }
    
    }

}
