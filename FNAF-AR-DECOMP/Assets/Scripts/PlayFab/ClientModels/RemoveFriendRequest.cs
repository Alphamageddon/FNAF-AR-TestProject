using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RemoveFriendRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FriendPlayFabId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RemoveFriendRequest()
        {
        
        }
    
    }

}
