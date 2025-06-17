using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ConsumePSNEntitlementsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ServiceLabel;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsumePSNEntitlementsRequest()
        {
        
        }
    
    }

}
