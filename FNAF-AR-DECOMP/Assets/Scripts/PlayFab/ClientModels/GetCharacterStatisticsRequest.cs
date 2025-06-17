using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetCharacterStatisticsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetCharacterStatisticsRequest()
        {
        
        }
    
    }

}
