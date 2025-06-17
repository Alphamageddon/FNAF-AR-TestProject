using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayFabEventsAPI
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabEventsAPI()
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
        public static void WriteEvents(PlayFab.EventsModels.WriteEventsRequest request, System.Action<PlayFab.EventsModels.WriteEventsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.EventsModels.WriteEventsResponse>(apiEndpoint:  "/Event/WriteEvents", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void WriteTelemetryEvents(PlayFab.EventsModels.WriteEventsRequest request, System.Action<PlayFab.EventsModels.WriteEventsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.EventsModels.WriteEventsResponse>(apiEndpoint:  "/Event/WriteTelemetryEvents", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
    
    }

}
