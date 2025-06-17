using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetEntityProfileRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> DataAsObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ProfilesModels.EntityKey Entity;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetEntityProfileRequest()
        {
            val_1 = new System.Object();
        }
    
    }

}
