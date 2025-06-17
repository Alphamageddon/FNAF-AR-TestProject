using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListMembershipRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.GroupsModels.EntityKey Entity;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListMembershipRequest()
        {
        
        }
    
    }

}
