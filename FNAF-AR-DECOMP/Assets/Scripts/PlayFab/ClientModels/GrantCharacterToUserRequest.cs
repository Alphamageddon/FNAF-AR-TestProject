using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GrantCharacterToUserRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GrantCharacterToUserRequest()
        {
        
        }
    
    }

}
