using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GroupWithRoles : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GroupName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProfileVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.GroupsModels.GroupRole> Roles;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GroupWithRoles()
        {
        
        }
    
    }

}
