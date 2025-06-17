using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StartGameRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CustomCommandLineData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GameMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.Region Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StatisticName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StartGameRequest()
        {
        
        }
    
    }

}
