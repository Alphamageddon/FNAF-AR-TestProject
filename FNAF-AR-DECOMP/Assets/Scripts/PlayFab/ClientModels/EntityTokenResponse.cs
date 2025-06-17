using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityTokenResponse : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> TokenExpiration;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityTokenResponse()
        {
        
        }
    
    }

}
