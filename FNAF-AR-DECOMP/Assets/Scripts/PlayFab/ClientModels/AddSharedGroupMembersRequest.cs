using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AddSharedGroupMembersRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> PlayFabIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SharedGroupId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddSharedGroupMembersRequest()
        {
        
        }
    
    }

}
