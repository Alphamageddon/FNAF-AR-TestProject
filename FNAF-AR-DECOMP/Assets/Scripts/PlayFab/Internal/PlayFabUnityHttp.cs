using UnityEngine;

namespace PlayFab.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabUnityHttp : ITransportPlugin, IPlayFabPlugin
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly int _pendingWwwMessages;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInitialized { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsInitialized()
        {
            return (bool)this._isInitialized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize()
        {
            this._isInitialized = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimpleGetCall(string fullUrl, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            UnityEngine.Coroutine val_3 = PlayFab.Internal.SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>.instance.StartCoroutine(routine:  PlayFab.Internal.PlayFabUnityHttp.SimpleCallCoroutine(method:  "get", fullUrl:  fullUrl, payload:  0, successCallback:  successCallback, errorCallback:  errorCallback));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimplePutCall(string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            UnityEngine.Coroutine val_3 = PlayFab.Internal.SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>.instance.StartCoroutine(routine:  PlayFab.Internal.PlayFabUnityHttp.SimpleCallCoroutine(method:  "put", fullUrl:  fullUrl, payload:  payload, successCallback:  successCallback, errorCallback:  errorCallback));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimplePostCall(string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            UnityEngine.Coroutine val_3 = PlayFab.Internal.SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>.instance.StartCoroutine(routine:  PlayFab.Internal.PlayFabUnityHttp.SimpleCallCoroutine(method:  "post", fullUrl:  fullUrl, payload:  payload, successCallback:  successCallback, errorCallback:  errorCallback));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.IEnumerator SimpleCallCoroutine(string method, string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            PlayFabUnityHttp.<SimpleCallCoroutine>d__10 val_1 = new PlayFabUnityHttp.<SimpleCallCoroutine>d__10();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .successCallback = successCallback;
                .method = method;
                .payload = payload;
                .fullUrl = fullUrl;
            }
            else
            {
                    mem[64] = method;
                mem[40] = fullUrl;
                mem[32] = payload;
                mem[56] = successCallback;
            }
            
            .errorCallback = errorCallback;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MakeApiCall(object reqContainerObj)
        {
            var val_11;
            var val_15;
            val_11 = 1152921517553276976;
            0.set_Item(key:  "Content-Type", value:  "application/json");
            if(PlayFab.PlayFabSettings.CompressApiData == false)
            {
                goto label_35;
            }
            
            0.set_Item(key:  "Content-Encoding", value:  "GZIP");
            0.set_Item(key:  "Accept-Encoding", value:  "GZIP");
            System.IO.MemoryStream val_4 = new System.IO.MemoryStream();
            new Ionic.Zlib.GZipStream() = new Ionic.Zlib.GZipStream(stream:  val_4, mode:  0, level:  9);
            val_11 = 0;
            var val_10 = 0;
            val_10 = val_10 + 1;
            new Ionic.Zlib.GZipStream().Dispose();
            if(126 != 126)
            {
                goto label_16;
            }
            
            if(val_4 != null)
            {
                goto label_27;
            }
            
            goto label_18;
            label_16:
            if( != 0)
            {
                    val_11 = 0;
            }
            
            if(X21 != 0)
            {
                goto label_27;
            }
            
            label_18:
            label_27:
            mem2[0] = X21;
            var val_13 = X21;
            if((X21 + 286) == 0)
            {
                goto label_32;
            }
            
            var val_11 = X21 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_31:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_30;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (X21 + 286))
            {
                goto label_31;
            }
            
            goto label_32;
            label_30:
            val_13 = val_13 + (((X21 + 176 + 8)) << 4);
            val_15 = val_13 + 296;
            label_32:
            X21.Dispose();
            label_35:
            UnityEngine.Coroutine val_9 = PlayFab.Internal.SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>.instance.StartCoroutine(routine:  this.Post(reqContainer:  reqContainerObj));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator Post(PlayFab.Internal.CallRequestContainer reqContainer)
        {
            PlayFabUnityHttp.<Post>d__12 val_1 = new PlayFabUnityHttp.<Post>d__12();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .reqContainer = reqContainer;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPendingMessages()
        {
            return (int)this._pendingWwwMessages;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnResponse(string response, PlayFab.Internal.CallRequestContainer reqContainer)
        {
            PlayFab.PlayFabError val_6;
            object val_7;
            var val_9;
            val_6 = reqContainer;
            val_7 = PlayFab.PluginManager.GetPlugin<PlayFab.ISerializerPlugin>(contract:  0, instanceName:  "");
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_9 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_1, typeof(public PlayFab.SharedModels.HttpResponseObject PlayFab.ISerializerPlugin::DeserializeObject<PlayFab.SharedModels.HttpResponseObject>(string serialized).__il2cppRuntimeField_18), slot: 0) + 8;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = 3;
            string val_5 = val_7.SerializeObject(obj:  response);
            if(val_6 != null)
            {
                    reqContainer.JsonResponse = val_5;
            }
            else
            {
                    mem[56] = val_5;
            }
            
            reqContainer.DeserializeResultJson.Invoke();
            reqContainer.ApiResult.Request = reqContainer.ApiRequest;
            reqContainer.ApiResult.CustomData = reqContainer.CustomData;
            PlayFab.Internal.SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>.instance.OnPlayFabApiResult(reqContainer:  val_6);
            PlayFab.Internal.PlayFabDeviceUtil.OnPlayFabLogin(result:  reqContainer.ApiResult, settings:  reqContainer.settings, instanceApi:  reqContainer.instanceApi);
            val_7 = reqContainer.ApiEndpoint;
            PlayFab.Internal.PlayFabHttp.SendEvent(apiEndpoint:  val_7, request:  reqContainer.ApiRequest, result:  reqContainer.ApiResult, eventType:  1);
            val_6 = reqContainer.InvokeSuccessCallback;
            val_6.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnError(string error, PlayFab.Internal.CallRequestContainer reqContainer)
        {
            string val_2;
            if(reqContainer != null)
            {
                    val_2 = reqContainer;
                reqContainer.JsonResponse = error;
            }
            else
            {
                    val_2 = 56;
                mem[56] = error;
            }
            
            if(reqContainer.ErrorCallback == null)
            {
                    return;
            }
            
            PlayFab.PlayFabError val_1 = PlayFab.Internal.PlayFabHttp.GeneratePlayFabError(apiEndpoint:  reqContainer.ApiEndpoint, json:  val_2, customData:  reqContainer.CustomData);
            reqContainer.Error = val_1;
            PlayFab.Internal.PlayFabHttp.SendErrorEvent(request:  reqContainer.ApiRequest, error:  val_1);
            reqContainer.ErrorCallback.Invoke(obj:  reqContainer.Error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabUnityHttp()
        {
        
        }
    
    }

}
