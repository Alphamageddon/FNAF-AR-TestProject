using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UpdateCharacterStatisticsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> CharacterStatistics;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateCharacterStatisticsRequest()
        {
        
        }
    
    }

}
