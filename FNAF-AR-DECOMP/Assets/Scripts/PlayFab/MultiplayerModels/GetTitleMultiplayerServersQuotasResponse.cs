using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetTitleMultiplayerServersQuotasResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.TitleMultiplayerServersQuotas Quotas;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetTitleMultiplayerServersQuotasResponse()
        {
        
        }
    
    }

}
