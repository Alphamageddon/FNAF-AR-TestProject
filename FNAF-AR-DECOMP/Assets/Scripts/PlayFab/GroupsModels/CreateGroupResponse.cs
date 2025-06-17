using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CreateGroupResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AdminRoleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime Created;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GroupName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MemberRoleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProfileVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Roles;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreateGroupResponse()
        {
        
        }
    
    }

}
