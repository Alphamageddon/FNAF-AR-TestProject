using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GroupInvitation : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime Expires;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityWithLineage InvitedByEntity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityWithLineage InvitedEntity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GroupInvitation()
        {
        
        }
    
    }

}
