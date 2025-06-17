using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MatchmakeRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GameMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LobbyId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.Region> Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> StartNewIfNoneFound;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StatisticName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.CollectionFilter TagFilter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MatchmakeRequest()
        {
        
        }
    
    }

}
