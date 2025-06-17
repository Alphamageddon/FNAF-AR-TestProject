using UnityEngine;

namespace PlayFab.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CallRequestContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.Internal.HttpRequestState HttpState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Net.HttpWebRequest HttpRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ApiEndpoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FullUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] Payload;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string JsonResponse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.SharedModels.PlayFabRequestCommon ApiRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> RequestHeaders;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.SharedModels.PlayFabResultCommon ApiResult;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.PlayFabError Error;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action DeserializeResultJson;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action InvokeSuccessCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<PlayFab.PlayFabError> ErrorCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object CustomData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.PlayFabApiSettings settings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.PlayFabAuthenticationContext context;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.SharedModels.IPlayFabInstanceApi instanceApi;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CallRequestContainer()
        {
            this.HttpState = 2;
        }
    
    }

}
