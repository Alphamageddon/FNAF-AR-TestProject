using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GameInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GameMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GameServerData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.GameInstanceState> GameServerStateEnum;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> LastHeartbeat;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LobbyID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> MaxPlayers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> PlayerUserIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.Region> Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint RunTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerIPV4Address;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerIPV6Address;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> ServerPort;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerPublicDNSName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StatisticName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Tags;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameInfo()
        {
        
        }
    
    }

}
