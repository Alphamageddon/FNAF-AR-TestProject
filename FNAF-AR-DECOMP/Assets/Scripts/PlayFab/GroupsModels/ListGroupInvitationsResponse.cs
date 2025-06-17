using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListGroupInvitationsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.GroupsModels.GroupInvitation> Invitations;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListGroupInvitationsResponse()
        {
        
        }
    
    }

}
