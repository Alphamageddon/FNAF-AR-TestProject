using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListGroupMembersResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.GroupsModels.EntityMemberRole> Members;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListGroupMembersResponse()
        {
        
        }
    
    }

}
