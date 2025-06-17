using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabProfilesInstanceAPI : IPlayFabInstanceApi
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly PlayFab.PlayFabApiSettings apiSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly PlayFab.PlayFabAuthenticationContext authenticationContext;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabProfilesInstanceAPI(PlayFab.PlayFabAuthenticationContext context)
        {
            if(context != null)
            {
                    this.authenticationContext = context;
                return;
            }
            
            PlayFab.PlayFabException val_1 = new PlayFab.PlayFabException(code:  0, message:  "Context cannot be null, create a PlayFabAuthenticationContext for each player in advance, or call <PlayFabClientInstanceAPI>.GetAuthenticationContext()");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabProfilesInstanceAPI(PlayFab.PlayFabApiSettings settings, PlayFab.PlayFabAuthenticationContext context)
        {
            val_1 = new System.Object();
            if(val_1 != null)
            {
                    this.apiSettings = settings;
                this.authenticationContext = val_1;
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  0, message:  "Context cannot be null, create a PlayFabAuthenticationContext for each player in advance, or call <PlayFabClientInstanceAPI>.GetAuthenticationContext()");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEntityLoggedIn()
        {
            if(this.authenticationContext == null)
            {
                    return (bool)this.authenticationContext;
            }
            
            return this.authenticationContext.IsEntityLoggedIn();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ForgetAllCredentials()
        {
            if(this.authenticationContext == null)
            {
                    return;
            }
            
            this.authenticationContext.ForgetAllCredentials();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetGlobalPolicy(PlayFab.ProfilesModels.GetGlobalPolicyRequest request, System.Action<PlayFab.ProfilesModels.GetGlobalPolicyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            PlayFab.PlayFabApiSettings val_2;
            var val_3;
            if(request != null)
            {
                    if(!=0)
            {
                goto label_2;
            }
            
            }
            
            val_1 = this.authenticationContext;
            label_2:
            val_2 = this.apiSettings;
            if(val_2 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = PlayFab.PlayFabSettings.staticSettings;
            }
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.GetGlobalPolicyResponse>(apiEndpoint:  "/Profile/GetGlobalPolicy", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetProfile(PlayFab.ProfilesModels.GetEntityProfileRequest request, System.Action<PlayFab.ProfilesModels.GetEntityProfileResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            PlayFab.PlayFabApiSettings val_2;
            var val_3;
            if(request != null)
            {
                    if(!=0)
            {
                goto label_2;
            }
            
            }
            
            val_1 = this.authenticationContext;
            label_2:
            val_2 = this.apiSettings;
            if(val_2 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = PlayFab.PlayFabSettings.staticSettings;
            }
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.GetEntityProfileResponse>(apiEndpoint:  "/Profile/GetProfile", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetProfiles(PlayFab.ProfilesModels.GetEntityProfilesRequest request, System.Action<PlayFab.ProfilesModels.GetEntityProfilesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            PlayFab.PlayFabApiSettings val_2;
            var val_3;
            if(request != null)
            {
                    if(!=0)
            {
                goto label_2;
            }
            
            }
            
            val_1 = this.authenticationContext;
            label_2:
            val_2 = this.apiSettings;
            if(val_2 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = PlayFab.PlayFabSettings.staticSettings;
            }
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.GetEntityProfilesResponse>(apiEndpoint:  "/Profile/GetProfiles", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetTitlePlayersFromMasterPlayerAccountIds(PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsRequest request, System.Action<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            PlayFab.PlayFabApiSettings val_2;
            var val_3;
            if(request != null)
            {
                    if(!=0)
            {
                goto label_2;
            }
            
            }
            
            val_1 = this.authenticationContext;
            label_2:
            val_2 = this.apiSettings;
            if(val_2 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = PlayFab.PlayFabSettings.staticSettings;
            }
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsResponse>(apiEndpoint:  "/Profile/GetTitlePlayersFromMasterPlayerAccountIds", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetGlobalPolicy(PlayFab.ProfilesModels.SetGlobalPolicyRequest request, System.Action<PlayFab.ProfilesModels.SetGlobalPolicyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            PlayFab.PlayFabApiSettings val_2;
            var val_3;
            if(request != null)
            {
                    if(!=0)
            {
                goto label_2;
            }
            
            }
            
            val_1 = this.authenticationContext;
            label_2:
            val_2 = this.apiSettings;
            if(val_2 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = PlayFab.PlayFabSettings.staticSettings;
            }
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.SetGlobalPolicyResponse>(apiEndpoint:  "/Profile/SetGlobalPolicy", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetProfileLanguage(PlayFab.ProfilesModels.SetProfileLanguageRequest request, System.Action<PlayFab.ProfilesModels.SetProfileLanguageResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            PlayFab.PlayFabApiSettings val_2;
            var val_3;
            if(request != null)
            {
                    if(!=0)
            {
                goto label_2;
            }
            
            }
            
            val_1 = this.authenticationContext;
            label_2:
            val_2 = this.apiSettings;
            if(val_2 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = PlayFab.PlayFabSettings.staticSettings;
            }
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.SetProfileLanguageResponse>(apiEndpoint:  "/Profile/SetProfileLanguage", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetProfilePolicy(PlayFab.ProfilesModels.SetEntityProfilePolicyRequest request, System.Action<PlayFab.ProfilesModels.SetEntityProfilePolicyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            PlayFab.PlayFabApiSettings val_2;
            var val_3;
            if(request != null)
            {
                    if(!=0)
            {
                goto label_2;
            }
            
            }
            
            val_1 = this.authenticationContext;
            label_2:
            val_2 = this.apiSettings;
            if(val_2 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = PlayFab.PlayFabSettings.staticSettings;
            }
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ProfilesModels.SetEntityProfilePolicyResponse>(apiEndpoint:  "/Profile/SetProfilePolicy", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
    
    }

}
