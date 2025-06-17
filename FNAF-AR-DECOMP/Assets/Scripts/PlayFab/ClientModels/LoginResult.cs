using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LoginResult : PlayFabLoginResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.EntityTokenResponse EntityToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.GetPlayerCombinedInfoResultPayload InfoResultPayload;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> LastLoginTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool NewlyCreated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SessionTicket;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserSettings SettingsForUser;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoginResult()
        {
        
        }
    
    }

}
