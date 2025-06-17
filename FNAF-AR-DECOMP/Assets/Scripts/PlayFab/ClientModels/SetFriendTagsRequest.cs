using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetFriendTagsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FriendPlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Tags;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetFriendTagsRequest()
        {
        
        }
    
    }

}
