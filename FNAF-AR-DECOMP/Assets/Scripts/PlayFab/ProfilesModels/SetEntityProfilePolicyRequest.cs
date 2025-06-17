using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetEntityProfilePolicyRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ProfilesModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ProfilesModels.EntityPermissionStatement> Statements;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetEntityProfilePolicyRequest()
        {
            val_1 = new System.Object();
        }
    
    }

}
