using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StartGameResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Expires;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LobbyID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Password;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerIPV4Address;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerIPV6Address;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> ServerPort;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerPublicDNSName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Ticket;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StartGameResult()
        {
        
        }
    
    }

}
