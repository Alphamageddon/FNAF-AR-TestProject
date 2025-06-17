using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class DeleteRoleRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeleteRoleRequest()
        {
        
        }
    
    }

}
