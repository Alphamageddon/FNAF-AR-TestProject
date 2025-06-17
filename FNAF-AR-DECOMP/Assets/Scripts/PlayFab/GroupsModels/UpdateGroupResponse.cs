using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UpdateGroupResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OperationReason;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProfileVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.GroupsModels.OperationTypes> SetResult;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateGroupResponse()
        {
        
        }
    
    }

}
