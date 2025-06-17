using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserSteamInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.TitleActivationStatus> SteamActivationStatus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SteamCountry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.Currency> SteamCurrency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SteamId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SteamName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserSteamInfo()
        {
        
        }
    
    }

}
