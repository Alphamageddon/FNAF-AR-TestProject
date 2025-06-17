using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetTitlePlayersFromMasterPlayerAccountIdsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ProfilesModels.EntityKey> TitlePlayerAccounts;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetTitlePlayersFromMasterPlayerAccountIdsResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
