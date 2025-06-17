using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetFriendsListResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.FriendInfo> Friends;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetFriendsListResult()
        {
        
        }
    
    }

}
