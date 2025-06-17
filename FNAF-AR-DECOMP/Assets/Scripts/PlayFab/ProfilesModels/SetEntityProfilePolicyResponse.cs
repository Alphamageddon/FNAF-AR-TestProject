using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetEntityProfilePolicyResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ProfilesModels.EntityPermissionStatement> Permissions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetEntityProfilePolicyResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
