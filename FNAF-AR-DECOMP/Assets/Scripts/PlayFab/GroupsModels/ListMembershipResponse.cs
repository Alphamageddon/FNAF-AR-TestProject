using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListMembershipResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.GroupsModels.GroupWithRoles> Groups;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListMembershipResponse()
        {
        
        }
    
    }

}
