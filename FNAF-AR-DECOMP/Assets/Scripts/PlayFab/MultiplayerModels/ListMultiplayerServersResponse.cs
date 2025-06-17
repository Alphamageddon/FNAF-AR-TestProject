using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListMultiplayerServersResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.MultiplayerServerSummary> MultiplayerServerSummaries;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int PageSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SkipToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListMultiplayerServersResponse()
        {
        
        }
    
    }

}
