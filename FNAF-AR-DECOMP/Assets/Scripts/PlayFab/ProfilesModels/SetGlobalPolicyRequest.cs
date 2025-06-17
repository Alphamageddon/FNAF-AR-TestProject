using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetGlobalPolicyRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ProfilesModels.EntityPermissionStatement> Permissions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetGlobalPolicyRequest()
        {
            val_1 = new System.Object();
        }
    
    }

}
