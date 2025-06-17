using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UnlockContainerInstanceRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ContainerItemInstanceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string KeyItemInstanceId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnlockContainerInstanceRequest()
        {
        
        }
    
    }

}
