using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayFabDataAPI
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabDataAPI()
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
        public static void AbortFileUploads(PlayFab.DataModels.AbortFileUploadsRequest request, System.Action<PlayFab.DataModels.AbortFileUploadsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.AbortFileUploadsResponse>(apiEndpoint:  "/File/AbortFileUploads", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DeleteFiles(PlayFab.DataModels.DeleteFilesRequest request, System.Action<PlayFab.DataModels.DeleteFilesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.DeleteFilesResponse>(apiEndpoint:  "/File/DeleteFiles", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FinalizeFileUploads(PlayFab.DataModels.FinalizeFileUploadsRequest request, System.Action<PlayFab.DataModels.FinalizeFileUploadsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.FinalizeFileUploadsResponse>(apiEndpoint:  "/File/FinalizeFileUploads", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetFiles(PlayFab.DataModels.GetFilesRequest request, System.Action<PlayFab.DataModels.GetFilesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.GetFilesResponse>(apiEndpoint:  "/File/GetFiles", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetObjects(PlayFab.DataModels.GetObjectsRequest request, System.Action<PlayFab.DataModels.GetObjectsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.GetObjectsResponse>(apiEndpoint:  "/Object/GetObjects", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void InitiateFileUploads(PlayFab.DataModels.InitiateFileUploadsRequest request, System.Action<PlayFab.DataModels.InitiateFileUploadsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.InitiateFileUploadsResponse>(apiEndpoint:  "/File/InitiateFileUploads", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetObjects(PlayFab.DataModels.SetObjectsRequest request, System.Action<PlayFab.DataModels.SetObjectsResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
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
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.DataModels.SetObjectsResponse>(apiEndpoint:  "/Object/SetObjects", request:  request, authType:  4, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
    
    }

}
