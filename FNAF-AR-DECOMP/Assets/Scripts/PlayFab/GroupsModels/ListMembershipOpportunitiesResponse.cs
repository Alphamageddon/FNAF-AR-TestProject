using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListMembershipOpportunitiesResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.GroupsModels.GroupApplication> Applications;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.GroupsModels.GroupInvitation> Invitations;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListMembershipOpportunitiesResponse()
        {
        
        }
    
    }

}
