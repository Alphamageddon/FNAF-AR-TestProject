using UnityEngine;

namespace PlayFab.AuthenticationModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetEntityTokenResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.AuthenticationModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> TokenExpiration;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetEntityTokenResponse()
        {
        
        }
    
    }

}
