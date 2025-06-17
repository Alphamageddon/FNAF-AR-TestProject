using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CreateGroupRoleRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreateGroupRoleRequest()
        {
        
        }
    
    }

}
