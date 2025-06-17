using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayFabAuthenticationAPI
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabAuthenticationAPI()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsEntityLoggedIn()
        {
            null = null;
            bool val_1 = System.String.IsNullOrEmpty(value:  PlayFab.PlayFabSettings.staticPlayer.EntityToken);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ForgetAllCredentials()
        {
            null = null;
            PlayFab.PlayFabSettings.staticPlayer.EntityType = 0;
            PlayFab.PlayFabSettings.staticPlayer.ClientSessionTicket = 0;
            PlayFab.PlayFabSettings.staticPlayer.EntityToken = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetEntityToken(PlayFab.AuthenticationModels.GetEntityTokenRequest request, System.Action<PlayFab.AuthenticationModels.GetEntityTokenResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            if(val_3 != null)
            {
                    label_2:
                PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.AuthenticationModels.GetEntityTokenResponse>(apiEndpoint:  "/Authentication/GetEntityToken", request:  request, authType:  (PlayFab.PlayFabSettings.staticPlayer.EntityToken == null) ? ((PlayFab.PlayFabSettings.staticPlayer.ClientSessionTicket == null) ? 0 : 2) : 4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ValidateEntityToken(PlayFab.AuthenticationModels.ValidateEntityTokenRequest request, System.Action<PlayFab.AuthenticationModels.ValidateEntityTokenResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            var val_2;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_2 = null;
            val_2 = null;
            val_1 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.AuthenticationModels.ValidateEntityTokenResponse>(apiEndpoint:  "/Authentication/ValidateEntityToken", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
    
    }

}
