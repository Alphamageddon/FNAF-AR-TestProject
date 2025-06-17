using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UpdateBuildRegionsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.BuildRegionParams> BuildRegions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateBuildRegionsRequest()
        {
        
        }
    
    }

}
