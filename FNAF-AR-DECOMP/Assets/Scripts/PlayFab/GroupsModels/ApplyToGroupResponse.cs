using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ApplyToGroupResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityWithLineage Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime Expires;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Group;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ApplyToGroupResponse()
        {
        
        }
    
    }

}
