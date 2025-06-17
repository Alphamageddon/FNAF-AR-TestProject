using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayFabLocalizationAPI
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabLocalizationAPI()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsEntityLoggedIn()
        {
            null = null;
            if(PlayFab.PlayFabSettings.staticPlayer != null)
            {
                    return PlayFab.PlayFabSettings.staticPlayer.IsEntityLoggedIn();
            }
            
            return PlayFab.PlayFabSettings.staticPlayer.IsEntityLoggedIn();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ForgetAllCredentials()
        {
            null = null;
            PlayFab.PlayFabSettings.staticPlayer.ForgetAllCredentials();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetLanguageList(PlayFab.LocalizationModels.GetLanguageListRequest request, System.Action<PlayFab.LocalizationModels.GetLanguageListResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            var val_2;
            if(request != null)
            {
                    if(!=0)
            {
                goto label_2;
            }
            
            }
            
            val_2 = null;
            val_2 = null;
            val_1 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.LocalizationModels.GetLanguageListResponse>(apiEndpoint:  "/Locale/GetLanguageList", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
    
    }

}
