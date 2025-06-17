using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UnlockContainerItemRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ContainerItemId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnlockContainerItemRequest()
        {
        
        }
    
    }

}
