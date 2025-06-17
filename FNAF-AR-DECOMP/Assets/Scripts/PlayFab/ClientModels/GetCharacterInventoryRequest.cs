using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetCharacterInventoryRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetCharacterInventoryRequest()
        {
        
        }
    
    }

}
