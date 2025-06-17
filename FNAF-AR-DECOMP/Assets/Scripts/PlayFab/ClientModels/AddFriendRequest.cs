using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AddFriendRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FriendEmail;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FriendPlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FriendTitleDisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FriendUsername;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddFriendRequest()
        {
        
        }
    
    }

}
