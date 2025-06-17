using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class DeleteGroupRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeleteGroupRequest()
        {
        
        }
    
    }

}
