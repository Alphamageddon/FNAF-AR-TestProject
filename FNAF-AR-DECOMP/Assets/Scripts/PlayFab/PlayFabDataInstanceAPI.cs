using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabDataInstanceAPI : IPlayFabInstanceApi
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly PlayFab.PlayFabApiSettings apiSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly PlayFab.PlayFabAuthenticationContext authenticationContext;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabDataInstanceAPI(PlayFab.PlayFabAuthenticationContext context)
        {
            if(context != null)
            {
                    this.authenticationContext = context;
                return;
            }
            
            PlayFab.PlayFabException val_1 = new PlayFab.PlayFabException(code:  0, message:  "Context cannot be null, create a PlayFabAuthenticationContext for each player in advance, or call <PlayFabClientInstanceAPI>.GetAuthenticationContext()");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabDataInstanceAPI(PlayFab.PlayFabApiSettings settings, PlayFab.PlayFabAuthenticationContext context)
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
        public void AbortFileUploads(PlayFab.DataModels.AbortFileUploadsRequest request, System.Action<PlayFab.DataModels.AbortFileUploadsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.AbortFileUploadsResponse>(apiEndpoint:  "/File/AbortFileUploads", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteFiles(PlayFab.DataModels.DeleteFilesRequest request, System.Action<PlayFab.DataModels.DeleteFilesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.DeleteFilesResponse>(apiEndpoint:  "/File/DeleteFiles", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FinalizeFileUploads(PlayFab.DataModels.FinalizeFileUploadsRequest request, System.Action<PlayFab.DataModels.FinalizeFileUploadsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.FinalizeFileUploadsResponse>(apiEndpoint:  "/File/FinalizeFileUploads", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetFiles(PlayFab.DataModels.GetFilesRequest request, System.Action<PlayFab.DataModels.GetFilesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.GetFilesResponse>(apiEndpoint:  "/File/GetFiles", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetObjects(PlayFab.DataModels.GetObjectsRequest request, System.Action<PlayFab.DataModels.GetObjectsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.GetObjectsResponse>(apiEndpoint:  "/Object/GetObjects", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitiateFileUploads(PlayFab.DataModels.InitiateFileUploadsRequest request, System.Action<PlayFab.DataModels.InitiateFileUploadsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.InitiateFileUploadsResponse>(apiEndpoint:  "/File/InitiateFileUploads", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetObjects(PlayFab.DataModels.SetObjectsRequest request, System.Action<PlayFab.DataModels.SetObjectsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.SetObjectsResponse>(apiEndpoint:  "/Object/SetObjects", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  val_2, instanceApi:  this);
        }
    
    }

}
