using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CreateGroupRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GroupName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreateGroupRequest()
        {
        
        }
    
    }

}
