using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetGroupRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GroupName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetGroupRequest()
        {
        
        }
    
    }

}
