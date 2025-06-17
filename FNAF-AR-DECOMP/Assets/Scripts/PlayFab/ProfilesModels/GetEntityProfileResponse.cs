using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetEntityProfileResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ProfilesModels.EntityProfileBody Profile;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetEntityProfileResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
