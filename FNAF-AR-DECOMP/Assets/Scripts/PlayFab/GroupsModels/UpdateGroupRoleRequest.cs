using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UpdateGroupRoleRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> ExpectedProfileVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateGroupRoleRequest()
        {
        
        }
    
    }

}
