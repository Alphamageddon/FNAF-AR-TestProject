using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetEntityProfilesResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ProfilesModels.EntityProfileBody> Profiles;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetEntityProfilesResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
