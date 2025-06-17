using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityMemberRole : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.GroupsModels.EntityWithLineage> Members;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RoleName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityMemberRole()
        {
        
        }
    
    }

}
