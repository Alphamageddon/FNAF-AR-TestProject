using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetEntityProfilesRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> DataAsObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ProfilesModels.EntityKey> Entities;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetEntityProfilesRequest()
        {
            val_1 = new System.Object();
        }
    
    }

}
