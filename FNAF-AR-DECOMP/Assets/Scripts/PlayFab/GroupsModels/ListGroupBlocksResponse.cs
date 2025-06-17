using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListGroupBlocksResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.GroupsModels.GroupBlock> BlockedEntities;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListGroupBlocksResponse()
        {
        
        }
    
    }

}
