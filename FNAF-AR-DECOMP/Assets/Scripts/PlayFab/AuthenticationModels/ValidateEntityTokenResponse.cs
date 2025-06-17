using UnityEngine;

namespace PlayFab.AuthenticationModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ValidateEntityTokenResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.AuthenticationModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.AuthenticationModels.LoginIdentityProvider> IdentityProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.AuthenticationModels.EntityLineage Lineage;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ValidateEntityTokenResponse()
        {
        
        }
    
    }

}
