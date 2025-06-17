using UnityEngine;

namespace PlayFab.GroupsModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListGroupApplicationsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.GroupsModels.GroupApplication> Applications;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListGroupApplicationsResponse()
        {
        
        }
    
    }

}
