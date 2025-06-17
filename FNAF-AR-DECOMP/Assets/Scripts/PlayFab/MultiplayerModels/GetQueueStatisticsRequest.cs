using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetQueueStatisticsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string QueueName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetQueueStatisticsRequest()
        {
        
        }
    
    }

}
