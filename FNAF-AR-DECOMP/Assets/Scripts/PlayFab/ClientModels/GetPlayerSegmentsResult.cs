using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayerSegmentsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.GetSegmentResult> Segments;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayerSegmentsResult()
        {
        
        }
    
    }

}
