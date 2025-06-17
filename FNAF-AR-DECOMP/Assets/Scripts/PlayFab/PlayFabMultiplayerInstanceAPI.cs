using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabMultiplayerInstanceAPI : IPlayFabInstanceApi
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly PlayFab.PlayFabApiSettings apiSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly PlayFab.PlayFabAuthenticationContext authenticationContext;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabMultiplayerInstanceAPI(PlayFab.PlayFabAuthenticationContext context)
        {
            if(context != null)
            {
                    this.authenticationContext = context;
                return;
            }
            
            PlayFab.PlayFabException val_1 = new PlayFab.PlayFabException(code:  0, message:  "Context cannot be null, create a PlayFabAuthenticationContext for each player in advance, or call <PlayFabClientInstanceAPI>.GetAuthenticationContext()");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabMultiplayerInstanceAPI(PlayFab.PlayFabApiSettings settings, PlayFab.PlayFabAuthenticationContext context)
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
        public void CancelAllMatchmakingTicketsForPlayer(PlayFab.MultiplayerModels.CancelAllMatchmakingTicketsForPlayerRequest request, System.Action<PlayFab.MultiplayerModels.CancelAllMatchmakingTicketsForPlayerResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.CancelAllMatchmakingTicketsForPlayerResult>(apiEndpoint:  "/Match/CancelAllMatchmakingTicketsForPlayer", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CancelMatchmakingTicket(PlayFab.MultiplayerModels.CancelMatchmakingTicketRequest request, System.Action<PlayFab.MultiplayerModels.CancelMatchmakingTicketResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.CancelMatchmakingTicketResult>(apiEndpoint:  "/Match/CancelMatchmakingTicket", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateBuildWithCustomContainer(PlayFab.MultiplayerModels.CreateBuildWithCustomContainerRequest request, System.Action<PlayFab.MultiplayerModels.CreateBuildWithCustomContainerResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.CreateBuildWithCustomContainerResponse>(apiEndpoint:  "/MultiplayerServer/CreateBuildWithCustomContainer", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateBuildWithManagedContainer(PlayFab.MultiplayerModels.CreateBuildWithManagedContainerRequest request, System.Action<PlayFab.MultiplayerModels.CreateBuildWithManagedContainerResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.CreateBuildWithManagedContainerResponse>(apiEndpoint:  "/MultiplayerServer/CreateBuildWithManagedContainer", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateMatchmakingTicket(PlayFab.MultiplayerModels.CreateMatchmakingTicketRequest request, System.Action<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult>(apiEndpoint:  "/Match/CreateMatchmakingTicket", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateRemoteUser(PlayFab.MultiplayerModels.CreateRemoteUserRequest request, System.Action<PlayFab.MultiplayerModels.CreateRemoteUserResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.CreateRemoteUserResponse>(apiEndpoint:  "/MultiplayerServer/CreateRemoteUser", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateServerMatchmakingTicket(PlayFab.MultiplayerModels.CreateServerMatchmakingTicketRequest request, System.Action<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult>(apiEndpoint:  "/Match/CreateServerMatchmakingTicket", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteAsset(PlayFab.MultiplayerModels.DeleteAssetRequest request, System.Action<PlayFab.MultiplayerModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.EmptyResponse>(apiEndpoint:  "/MultiplayerServer/DeleteAsset", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteBuild(PlayFab.MultiplayerModels.DeleteBuildRequest request, System.Action<PlayFab.MultiplayerModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.EmptyResponse>(apiEndpoint:  "/MultiplayerServer/DeleteBuild", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteCertificate(PlayFab.MultiplayerModels.DeleteCertificateRequest request, System.Action<PlayFab.MultiplayerModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.EmptyResponse>(apiEndpoint:  "/MultiplayerServer/DeleteCertificate", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteRemoteUser(PlayFab.MultiplayerModels.DeleteRemoteUserRequest request, System.Action<PlayFab.MultiplayerModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.EmptyResponse>(apiEndpoint:  "/MultiplayerServer/DeleteRemoteUser", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EnableMultiplayerServersForTitle(PlayFab.MultiplayerModels.EnableMultiplayerServersForTitleRequest request, System.Action<PlayFab.MultiplayerModels.EnableMultiplayerServersForTitleResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.EnableMultiplayerServersForTitleResponse>(apiEndpoint:  "/MultiplayerServer/EnableMultiplayerServersForTitle", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetAssetUploadUrl(PlayFab.MultiplayerModels.GetAssetUploadUrlRequest request, System.Action<PlayFab.MultiplayerModels.GetAssetUploadUrlResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetAssetUploadUrlResponse>(apiEndpoint:  "/MultiplayerServer/GetAssetUploadUrl", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetBuild(PlayFab.MultiplayerModels.GetBuildRequest request, System.Action<PlayFab.MultiplayerModels.GetBuildResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetBuildResponse>(apiEndpoint:  "/MultiplayerServer/GetBuild", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetContainerRegistryCredentials(PlayFab.MultiplayerModels.GetContainerRegistryCredentialsRequest request, System.Action<PlayFab.MultiplayerModels.GetContainerRegistryCredentialsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetContainerRegistryCredentialsResponse>(apiEndpoint:  "/MultiplayerServer/GetContainerRegistryCredentials", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetMatch(PlayFab.MultiplayerModels.GetMatchRequest request, System.Action<PlayFab.MultiplayerModels.GetMatchResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetMatchResult>(apiEndpoint:  "/Match/GetMatch", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetMatchmakingTicket(PlayFab.MultiplayerModels.GetMatchmakingTicketRequest request, System.Action<PlayFab.MultiplayerModels.GetMatchmakingTicketResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetMatchmakingTicketResult>(apiEndpoint:  "/Match/GetMatchmakingTicket", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetMultiplayerServerDetails(PlayFab.MultiplayerModels.GetMultiplayerServerDetailsRequest request, System.Action<PlayFab.MultiplayerModels.GetMultiplayerServerDetailsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetMultiplayerServerDetailsResponse>(apiEndpoint:  "/MultiplayerServer/GetMultiplayerServerDetails", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetQueueStatistics(PlayFab.MultiplayerModels.GetQueueStatisticsRequest request, System.Action<PlayFab.MultiplayerModels.GetQueueStatisticsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetQueueStatisticsResult>(apiEndpoint:  "/Match/GetQueueStatistics", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetRemoteLoginEndpoint(PlayFab.MultiplayerModels.GetRemoteLoginEndpointRequest request, System.Action<PlayFab.MultiplayerModels.GetRemoteLoginEndpointResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetRemoteLoginEndpointResponse>(apiEndpoint:  "/MultiplayerServer/GetRemoteLoginEndpoint", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetTitleEnabledForMultiplayerServersStatus(PlayFab.MultiplayerModels.GetTitleEnabledForMultiplayerServersStatusRequest request, System.Action<PlayFab.MultiplayerModels.GetTitleEnabledForMultiplayerServersStatusResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetTitleEnabledForMultiplayerServersStatusResponse>(apiEndpoint:  "/MultiplayerServer/GetTitleEnabledForMultiplayerServersStatus", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetTitleMultiplayerServersQuotas(PlayFab.MultiplayerModels.GetTitleMultiplayerServersQuotasRequest request, System.Action<PlayFab.MultiplayerModels.GetTitleMultiplayerServersQuotasResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.GetTitleMultiplayerServersQuotasResponse>(apiEndpoint:  "/MultiplayerServer/GetTitleMultiplayerServersQuotas", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void JoinMatchmakingTicket(PlayFab.MultiplayerModels.JoinMatchmakingTicketRequest request, System.Action<PlayFab.MultiplayerModels.JoinMatchmakingTicketResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.JoinMatchmakingTicketResult>(apiEndpoint:  "/Match/JoinMatchmakingTicket", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListArchivedMultiplayerServers(PlayFab.MultiplayerModels.ListMultiplayerServersRequest request, System.Action<PlayFab.MultiplayerModels.ListMultiplayerServersResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListMultiplayerServersResponse>(apiEndpoint:  "/MultiplayerServer/ListArchivedMultiplayerServers", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListAssetSummaries(PlayFab.MultiplayerModels.ListAssetSummariesRequest request, System.Action<PlayFab.MultiplayerModels.ListAssetSummariesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListAssetSummariesResponse>(apiEndpoint:  "/MultiplayerServer/ListAssetSummaries", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListBuildSummaries(PlayFab.MultiplayerModels.ListBuildSummariesRequest request, System.Action<PlayFab.MultiplayerModels.ListBuildSummariesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListBuildSummariesResponse>(apiEndpoint:  "/MultiplayerServer/ListBuildSummaries", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListCertificateSummaries(PlayFab.MultiplayerModels.ListCertificateSummariesRequest request, System.Action<PlayFab.MultiplayerModels.ListCertificateSummariesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListCertificateSummariesResponse>(apiEndpoint:  "/MultiplayerServer/ListCertificateSummaries", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListContainerImages(PlayFab.MultiplayerModels.ListContainerImagesRequest request, System.Action<PlayFab.MultiplayerModels.ListContainerImagesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListContainerImagesResponse>(apiEndpoint:  "/MultiplayerServer/ListContainerImages", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListContainerImageTags(PlayFab.MultiplayerModels.ListContainerImageTagsRequest request, System.Action<PlayFab.MultiplayerModels.ListContainerImageTagsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListContainerImageTagsResponse>(apiEndpoint:  "/MultiplayerServer/ListContainerImageTags", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListMatchmakingTicketsForPlayer(PlayFab.MultiplayerModels.ListMatchmakingTicketsForPlayerRequest request, System.Action<PlayFab.MultiplayerModels.ListMatchmakingTicketsForPlayerResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListMatchmakingTicketsForPlayerResult>(apiEndpoint:  "/Match/ListMatchmakingTicketsForPlayer", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListMultiplayerServers(PlayFab.MultiplayerModels.ListMultiplayerServersRequest request, System.Action<PlayFab.MultiplayerModels.ListMultiplayerServersResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListMultiplayerServersResponse>(apiEndpoint:  "/MultiplayerServer/ListMultiplayerServers", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListPartyQosServers(PlayFab.MultiplayerModels.ListPartyQosServersRequest request, System.Action<PlayFab.MultiplayerModels.ListPartyQosServersResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListPartyQosServersResponse>(apiEndpoint:  "/MultiplayerServer/ListPartyQosServers", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListQosServers(PlayFab.MultiplayerModels.ListQosServersRequest request, System.Action<PlayFab.MultiplayerModels.ListQosServersResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListQosServersResponse>(apiEndpoint:  "/MultiplayerServer/ListQosServers", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListQosServersForTitle(PlayFab.MultiplayerModels.ListQosServersForTitleRequest request, System.Action<PlayFab.MultiplayerModels.ListQosServersForTitleResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListQosServersForTitleResponse>(apiEndpoint:  "/MultiplayerServer/ListQosServersForTitle", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ListVirtualMachineSummaries(PlayFab.MultiplayerModels.ListVirtualMachineSummariesRequest request, System.Action<PlayFab.MultiplayerModels.ListVirtualMachineSummariesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.ListVirtualMachineSummariesResponse>(apiEndpoint:  "/MultiplayerServer/ListVirtualMachineSummaries", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestMultiplayerServer(PlayFab.MultiplayerModels.RequestMultiplayerServerRequest request, System.Action<PlayFab.MultiplayerModels.RequestMultiplayerServerResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.RequestMultiplayerServerResponse>(apiEndpoint:  "/MultiplayerServer/RequestMultiplayerServer", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RolloverContainerRegistryCredentials(PlayFab.MultiplayerModels.RolloverContainerRegistryCredentialsRequest request, System.Action<PlayFab.MultiplayerModels.RolloverContainerRegistryCredentialsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.RolloverContainerRegistryCredentialsResponse>(apiEndpoint:  "/MultiplayerServer/RolloverContainerRegistryCredentials", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShutdownMultiplayerServer(PlayFab.MultiplayerModels.ShutdownMultiplayerServerRequest request, System.Action<PlayFab.MultiplayerModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.EmptyResponse>(apiEndpoint:  "/MultiplayerServer/ShutdownMultiplayerServer", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateBuildRegions(PlayFab.MultiplayerModels.UpdateBuildRegionsRequest request, System.Action<PlayFab.MultiplayerModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.EmptyResponse>(apiEndpoint:  "/MultiplayerServer/UpdateBuildRegions", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UploadCertificate(PlayFab.MultiplayerModels.UploadCertificateRequest request, System.Action<PlayFab.MultiplayerModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.MultiplayerModels.EmptyResponse>(apiEndpoint:  "/MultiplayerServer/UploadCertificate", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
    
    }

}
