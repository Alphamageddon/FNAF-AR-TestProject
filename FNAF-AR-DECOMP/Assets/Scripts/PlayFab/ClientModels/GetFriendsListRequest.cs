using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetFriendsListRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> IncludeFacebookFriends;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> IncludeSteamFriends;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.PlayerProfileViewConstraints ProfileConstraints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string XboxToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetFriendsListRequest()
        {
        
        }
    
    }

}
