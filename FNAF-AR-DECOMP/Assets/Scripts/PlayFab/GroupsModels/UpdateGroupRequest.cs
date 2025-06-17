using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UpdateGroupRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AdminRoleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> ExpectedProfileVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GroupName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MemberRoleId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateGroupRequest()
        {
        
        }
    
    }

}
