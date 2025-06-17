using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AdCampaignAttributionModel : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime AttributedAt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CampaignId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Platform;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AdCampaignAttributionModel()
        {
        
        }
    
    }

}
