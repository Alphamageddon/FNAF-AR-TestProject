using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CreateGroupRoleResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProfileVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreateGroupRoleResponse()
        {
        
        }
    
    }

}
