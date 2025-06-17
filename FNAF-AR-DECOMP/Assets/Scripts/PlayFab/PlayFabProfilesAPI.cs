using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayFabProfilesAPI
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabProfilesAPI()
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
        public static void GetGlobalPolicy(PlayFab.ProfilesModels.GetGlobalPolicyRequest request, System.Action<PlayFab.ProfilesModels.GetGlobalPolicyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.GetGlobalPolicyResponse>(apiEndpoint:  "/Profile/GetGlobalPolicy", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetProfile(PlayFab.ProfilesModels.GetEntityProfileRequest request, System.Action<PlayFab.ProfilesModels.GetEntityProfileResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.GetEntityProfileResponse>(apiEndpoint:  "/Profile/GetProfile", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetProfiles(PlayFab.ProfilesModels.GetEntityProfilesRequest request, System.Action<PlayFab.ProfilesModels.GetEntityProfilesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.GetEntityProfilesResponse>(apiEndpoint:  "/Profile/GetProfiles", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetTitlePlayersFromMasterPlayerAccountIds(PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsRequest request, System.Action<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsResponse>(apiEndpoint:  "/Profile/GetTitlePlayersFromMasterPlayerAccountIds", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetGlobalPolicy(PlayFab.ProfilesModels.SetGlobalPolicyRequest request, System.Action<PlayFab.ProfilesModels.SetGlobalPolicyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.SetGlobalPolicyResponse>(apiEndpoint:  "/Profile/SetGlobalPolicy", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetProfileLanguage(PlayFab.ProfilesModels.SetProfileLanguageRequest request, System.Action<PlayFab.ProfilesModels.SetProfileLanguageResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.SetProfileLanguageResponse>(apiEndpoint:  "/Profile/SetProfileLanguage", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetProfilePolicy(PlayFab.ProfilesModels.SetEntityProfilePolicyRequest request, System.Action<PlayFab.ProfilesModels.SetEntityProfilePolicyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.SetEntityProfilePolicyResponse>(apiEndpoint:  "/Profile/SetProfilePolicy", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
    
    }

}
