using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RegisterPlayFabUserResult : PlayFabLoginResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.EntityTokenResponse EntityToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SessionTicket;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserSettings SettingsForUser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Username;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RegisterPlayFabUserResult()
        {
        
        }
    
    }

}
