using UnityEngine;

namespace PlayFab.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabHttp : SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<PlayFab.Internal.CallRequestContainer> _apiCallQueue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Internal.PlayFabHttp.ApiProcessingEvent<PlayFab.Internal.ApiProcessingEventArgs> ApiProcessingEventHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Internal.PlayFabHttp.ApiProcessErrorEvent ApiProcessingErrorEventHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.Dictionary<string, string> GlobalHeaderInjection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Public.IPlayFabLogger _logger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Public.IScreenTimeTracker screenTimeTracker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float delayBetweenBatches = 5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Queue<System.Collections.IEnumerator> _injectedCoroutines;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Queue<System.Action> _injectedAction;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_ApiProcessingEventHandler(PlayFab.Internal.PlayFabHttp.ApiProcessingEvent<PlayFab.Internal.ApiProcessingEventArgs> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PlayFab.Internal.PlayFabHttp.ApiProcessingEventHandler, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PlayFab.Internal.PlayFabHttp.ApiProcessingEventHandler != 1152921505300832264);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_ApiProcessingEventHandler(PlayFab.Internal.PlayFabHttp.ApiProcessingEvent<PlayFab.Internal.ApiProcessingEventArgs> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PlayFab.Internal.PlayFabHttp.ApiProcessingEventHandler, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PlayFab.Internal.PlayFabHttp.ApiProcessingEventHandler != 1152921505300832264);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_ApiProcessingErrorEventHandler(PlayFab.Internal.PlayFabHttp.ApiProcessErrorEvent value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PlayFab.Internal.PlayFabHttp.ApiProcessingErrorEventHandler, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PlayFab.Internal.PlayFabHttp.ApiProcessingErrorEventHandler != 1152921505300832272);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_ApiProcessingErrorEventHandler(PlayFab.Internal.PlayFabHttp.ApiProcessErrorEvent value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PlayFab.Internal.PlayFabHttp.ApiProcessingErrorEventHandler, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PlayFab.Internal.PlayFabHttp.ApiProcessingErrorEventHandler != 1152921505300832272);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetPendingMessages()
        {
            PlayFab.ITransportPlugin val_1 = PlayFab.PluginManager.GetPlugin<PlayFab.ITransportPlugin>(contract:  1, instanceName:  "");
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(val_1.IsInitialized == false)
            {
                    return 0;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            return val_1.GetPendingMessages();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void InitializeHttp()
        {
            if((System.String.IsNullOrEmpty(value:  PlayFab.PlayFabSettings.TitleId)) != true)
            {
                    PlayFab.ITransportPlugin val_3 = PlayFab.PluginManager.GetPlugin<PlayFab.ITransportPlugin>(contract:  1, instanceName:  "");
                var val_8 = 0;
                val_8 = val_8 + 1;
                if(val_3.IsInitialized != false)
            {
                    return;
            }
            
                UnityEngine.Application.runInBackground = true;
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_3.Initialize();
                PlayFab.Internal.SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>.CreateInstance();
                return;
            }
            
            PlayFab.PlayFabException val_7 = new PlayFab.PlayFabException(code:  5, message:  "You must set PlayFabSettings.TitleId before making API Calls.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void InitializeLogger(PlayFab.Public.IPlayFabLogger setLogger)
        {
            PlayFab.Public.PlayFabLogger val_3;
            var val_4;
            val_3 = setLogger;
            val_4 = null;
            val_4 = null;
            if(PlayFab.Internal.PlayFabHttp._logger == null)
            {
                    if(val_3 == null)
            {
                    PlayFab.Public.PlayFabLogger val_1 = null;
                val_3 = val_1;
                val_1 = new PlayFab.Public.PlayFabLogger();
                val_4 = null;
            }
            
                val_4 = null;
                PlayFab.Internal.PlayFabHttp._logger = val_3;
                return;
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "Once initialized, the logger cannot be reset.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void InitializeScreenTimeTracker(string entityId, string entityType, string playFabUserId)
        {
            var val_5 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            PlayFab.Internal.PlayFabHttp.screenTimeTracker.ClientSessionStart(entityId:  entityId, entityType:  entityType, playFabUserId:  playFabUserId);
            UnityEngine.Coroutine val_4 = PlayFab.Internal.SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>.instance.StartCoroutine(routine:  PlayFab.Internal.PlayFabHttp.SendScreenTimeEvents(secondsBetweenBatches:  5f));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.IEnumerator SendScreenTimeEvents(float secondsBetweenBatches)
        {
            .<>1__state = 0;
            .secondsBetweenBatches = secondsBetweenBatches;
            return (System.Collections.IEnumerator)new PlayFabHttp.<SendScreenTimeEvents>d__17();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SimpleGetCall(string fullUrl, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            PlayFab.Internal.PlayFabHttp.InitializeHttp();
            var val_3 = 0;
            val_3 = val_3 + 1;
            PlayFab.PluginManager.GetPlugin<PlayFab.ITransportPlugin>(contract:  1, instanceName:  "").SimpleGetCall(fullUrl:  fullUrl, successCallback:  successCallback, errorCallback:  errorCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SimplePutCall(string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            PlayFab.Internal.PlayFabHttp.InitializeHttp();
            var val_3 = 0;
            val_3 = val_3 + 1;
            PlayFab.PluginManager.GetPlugin<PlayFab.ITransportPlugin>(contract:  1, instanceName:  "").SimplePutCall(fullUrl:  fullUrl, payload:  payload, successCallback:  successCallback, errorCallback:  errorCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SimplePostCall(string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            PlayFab.Internal.PlayFabHttp.InitializeHttp();
            var val_3 = 0;
            val_3 = val_3 + 1;
            PlayFab.PluginManager.GetPlugin<PlayFab.ITransportPlugin>(contract:  1, instanceName:  "").SimplePostCall(fullUrl:  fullUrl, payload:  payload, successCallback:  successCallback, errorCallback:  errorCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal static void MakeApiCall<TResult>(string apiEndpoint, PlayFab.SharedModels.PlayFabRequestCommon request, PlayFab.Internal.AuthType authType, System.Action<TResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders, PlayFab.PlayFabAuthenticationContext authenticationContext, PlayFab.PlayFabApiSettings apiSettings, PlayFab.SharedModels.IPlayFabInstanceApi instanceApi)
        {
            PlayFab.PlayFabApiSettings val_1;
            var val_2;
            val_1 = apiSettings;
            if(val_1 != null)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            val_1 = PlayFab.PlayFabSettings.staticSettings;
            if(val_1 == null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal static void MakeApiCallWithFullUri<TResult>(string fullUri, PlayFab.SharedModels.PlayFabRequestCommon request, PlayFab.Internal.AuthType authType, System.Action<TResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders, PlayFab.PlayFabAuthenticationContext authenticationContext, PlayFab.PlayFabApiSettings apiSettings, PlayFab.SharedModels.IPlayFabInstanceApi instanceApi)
        {
            PlayFab.PlayFabApiSettings val_1;
            System.Collections.Generic.Dictionary<System.String, System.String> val_2;
            var val_3;
            val_1 = apiSettings;
            val_2 = extraHeaders;
            val_2 = val_2;
            if(val_1 == null)
            {
                    val_3 = null;
                val_3 = null;
                val_2 = val_2;
                val_1 = PlayFab.PlayFabSettings.staticSettings;
            }
            
            val_2 = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void _MakeApiCall<TResult>(string apiEndpoint, string fullUrl, PlayFab.SharedModels.PlayFabRequestCommon request, PlayFab.Internal.AuthType authType, System.Action<TResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders, bool allowQueueing, PlayFab.PlayFabAuthenticationContext authenticationContext, PlayFab.PlayFabApiSettings apiSettings, PlayFab.SharedModels.IPlayFabInstanceApi instanceApi)
        {
            var val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.Dictionary<System.String, System.String> val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_32;
            string val_33;
            string val_34;
            var val_35;
            System.Action val_36;
            IntPtr val_37;
            var val_38;
            float val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            PlayFab.Internal.CallRequestContainer val_45;
            val_23 = extraHeaders;
            mem2[0] = resultCallback;
            PlayFab.Internal.PlayFabHttp.InitializeHttp();
            PlayFab.Internal.PlayFabHttp.SendEvent(apiEndpoint:  apiEndpoint, request:  request, result:  0, eventType:  0);
            val_24 = public static PlayFab.ISerializerPlugin PlayFab.PluginManager::GetPlugin<PlayFab.ISerializerPlugin>(PlayFab.PluginContract contract, string instanceName);
            mem2[0] = PlayFab.PluginManager.GetPlugin<PlayFab.ISerializerPlugin>(contract:  0, instanceName:  "");
            PlayFab.Internal.CallRequestContainer val_2 = new PlayFab.Internal.CallRequestContainer();
            if(val_2 != null)
            {
                    .ApiEndpoint = apiEndpoint;
                .FullUrl = fullUrl;
                .settings = apiSettings;
                .context = authenticationContext;
            }
            else
            {
                    mem[32] = apiEndpoint;
                mem[40] = fullUrl;
                mem[128] = apiSettings;
                mem[136] = authenticationContext;
            }
            
            .CustomData = customData;
            System.Text.Encoding val_3 = System.Text.Encoding.UTF8;
            var val_24 = __RuntimeMethodHiddenParam + 48 + 24;
            if((__RuntimeMethodHiddenParam + 48 + 24 + 286) == 0)
            {
                goto label_10;
            }
            
            var val_21 = __RuntimeMethodHiddenParam + 48 + 24 + 176;
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_12:
            if(((__RuntimeMethodHiddenParam + 48 + 24 + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < (__RuntimeMethodHiddenParam + 48 + 24 + 286))
            {
                goto label_12;
            }
            
            label_10:
            val_24 = 3;
            goto label_13;
            label_11:
            var val_23 = val_21;
            val_23 = val_23 + 3;
            val_24 = val_24 + val_23;
            val_25 = val_24 + 296;
            label_13:
            string val_4 = __RuntimeMethodHiddenParam + 48 + 24.SerializeObject(obj:  request);
            if(val_2 != null)
            {
                    .Payload = val_3;
                .ApiRequest = request;
            }
            else
            {
                    mem[48] = val_3;
                mem[64] = request;
            }
            
            .ErrorCallback = errorCallback;
            if(val_23 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.String> val_5 = null;
                val_23 = val_5;
                val_5 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            }
            
            .RequestHeaders = val_23;
            .instanceApi = instanceApi;
            mem2[0] = val_2;
            val_26 = null;
            val_26 = null;
            Dictionary.Enumerator<TKey, TValue> val_6 = PlayFab.Internal.PlayFabHttp.GlobalHeaderInjection.GetEnumerator();
            label_28:
            if(((-322287824) & 1) == 0)
            {
                goto label_22;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_10 = val_9.trackableId;
            if((__RuntimeMethodHiddenParam + 48 + 16 + 72.ContainsKey(key:  val_10.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key()))) == true)
            {
                goto label_28;
            }
            
            __RuntimeMethodHiddenParam + 48 + 16 + 72.set_Item(key:  val_10.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key()), value:  val_10.m_SubId1);
            goto label_28;
            label_22:
            val_27 = 1152921505300828160;
            val_28 = __RuntimeMethodHiddenParam;
            val_29 = 0;
            val_30 = 263;
            val_7 = val_8;
            val_8 = val_9;
            val_9 = null;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_9.Dispose();
            __RuntimeMethodHiddenParam + 48 + 16 + 72.set_Item(key:  "X-ReportErrorAsSuccess", value:  "true");
            __RuntimeMethodHiddenParam + 48 + 16 + 72.set_Item(key:  "X-PlayFabSDK", value:  "UnitySDK-2.75.191001");
            if(authType == 4)
            {
                goto label_51;
            }
            
            if((authType != 2) || (authenticationContext == 0))
            {
                goto label_57;
            }
            
            val_32 = mem[__RuntimeMethodHiddenParam + 48 + 16 + 72];
            val_32 = __RuntimeMethodHiddenParam + 48 + 16 + 72;
            val_33 = mem[authenticationContext + 16];
            val_33 = authenticationContext + 16;
            val_34 = "X-Authorization";
            goto label_56;
            label_51:
            if(authenticationContext == 0)
            {
                goto label_57;
            }
            
            val_32 = mem[__RuntimeMethodHiddenParam + 48 + 16 + 72];
            val_32 = __RuntimeMethodHiddenParam + 48 + 16 + 72;
            val_33 = mem[authenticationContext + 32];
            val_33 = authenticationContext + 32;
            val_34 = "X-EntityToken";
            label_56:
            val_32.set_Item(key:  val_34, value:  val_33);
            label_57:
            val_35 = 1152921504614727680;
            mem2[0] = new System.Action(object:  __RuntimeMethodHiddenParam + 48, method:  __RuntimeMethodHiddenParam + 48 + 16);
            System.Action val_16 = null;
            val_36 = val_16;
            val_37 = mem[__RuntimeMethodHiddenParam + 48 + 24];
            val_37 = __RuntimeMethodHiddenParam + 48 + 24;
            val_16 = new System.Action(object:  __RuntimeMethodHiddenParam + 48, method:  val_37);
            mem2[0] = val_36;
            if(allowQueueing != false)
            {
                    val_38 = null;
                val_39 = PlayFab.Internal.PlayFabHttp.delayBetweenBatches;
                if(val_39 != 0)
            {
                    val_39 = PlayFab.Internal.PlayFabHttp.delayBetweenBatches;
                if(val_39 == 0)
            {
                    val_39 = 0;
            }
            
                val_40 = null;
                val_36 = val_39.Count - 1;
                val_41 = (uint)(((uint)((PlayFab.Internal.PlayFabHttp.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
                if((val_36 & 2147483648) == 0)
            {
                    val_35 = 1152921525759372496;
                do
            {
                val_42 = null;
                PlayFab.Internal.CallRequestContainer val_18 = PlayFab.Internal.PlayFabHttp.delayBetweenBatches.Item[val_36];
                if((System.String.op_Equality(a:  val_18.ApiEndpoint, b:  apiEndpoint)) != false)
            {
                    val_43 = null;
                val_43 = null;
                PlayFab.Internal.PlayFabHttp.delayBetweenBatches.RemoveAt(index:  val_36);
            }
            
                val_44 = null;
                val_36 = val_36 - 1;
                val_41 = (uint)(((uint)((PlayFab.Internal.PlayFabHttp.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
            }
            while((val_36 & 2147483648) == 0);
            
            }
            
                val_44 = null;
                val_45 = mem[__RuntimeMethodHiddenParam + 48 + 16];
                val_45 = __RuntimeMethodHiddenParam + 48 + 16;
                PlayFab.Internal.PlayFabHttp.delayBetweenBatches.Add(item:  val_45);
                return;
            }
            
            }
            
            val_45 = mem[__RuntimeMethodHiddenParam + 48 + 16];
            val_45 = __RuntimeMethodHiddenParam + 48 + 16;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_37 = 7;
            PlayFab.PluginManager.GetPlugin<PlayFab.ITransportPlugin>(contract:  1, instanceName:  "").MakeApiCall(reqContainer:  val_45);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void OnPlayFabApiResult(PlayFab.Internal.CallRequestContainer reqContainer)
        {
            var val_6;
            string val_7;
            var val_8;
            var val_9;
            string val_10;
            string val_11;
            PlayFab.PlayFabAuthenticationContext val_12;
            if(reqContainer.ApiResult == null)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            PlayFab.PlayFabSettings.staticPlayer.EntityToken = null;
            val_7 = 0;
            val_8 = 0;
            val_9 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 40;
            val_9 = mem[(PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 40];
            val_9 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 40;
            val_10 = mem[(PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 40 + 24];
            val_10 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 40 + 24;
            val_11 = mem[(PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 40 + 16 + 16];
            val_11 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 40 + 16 + 16;
            PlayFab.PlayFabAuthenticationContext val_3 = null;
            val_12 = val_3;
            val_3 = new PlayFab.PlayFabAuthenticationContext();
            .ClientSessionTicket = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 88;
            .PlayFabId = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 80;
            .EntityToken = val_10;
            .EntityId = val_11;
            .EntityType = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? reqContainer.ApiResult : 0 + 40 + 16 + 24;
            mem2[0] = val_12;
            if(reqContainer.context == null)
            {
                    return;
            }
            
            reqContainer.context.CopyFrom(other:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            var val_4;
            PlayFab.Public.IPlayFabLogger val_5;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = PlayFab.Internal.PlayFabHttp._logger;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            val_5 = PlayFab.Internal.PlayFabHttp._logger;
            if(val_5 == null)
            {
                goto label_6;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5.OnEnable();
            val_4 = null;
            label_3:
            val_4 = null;
            if(PlayFab.Internal.PlayFabHttp.screenTimeTracker == null)
            {
                    return;
            }
            
            if(PlayFab.PlayFabSettings.DisableFocusTimeCollection != false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            PlayFab.Internal.PlayFabHttp.screenTimeTracker.OnEnable();
            return;
            label_6:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            var val_4;
            PlayFab.Public.IPlayFabLogger val_5;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = PlayFab.Internal.PlayFabHttp._logger;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            val_5 = PlayFab.Internal.PlayFabHttp._logger;
            if(val_5 == null)
            {
                goto label_6;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5.OnDisable();
            val_4 = null;
            label_3:
            val_4 = null;
            if(PlayFab.Internal.PlayFabHttp.screenTimeTracker == null)
            {
                    return;
            }
            
            if(PlayFab.PlayFabSettings.DisableFocusTimeCollection != false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            PlayFab.Internal.PlayFabHttp.screenTimeTracker.OnDisable();
            return;
            label_6:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            var val_9;
            PlayFab.Public.IPlayFabLogger val_10;
            var val_12;
            PlayFab.ITransportPlugin val_1 = PlayFab.PluginManager.GetPlugin<PlayFab.ITransportPlugin>(contract:  1, instanceName:  "");
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(val_1.IsInitialized != false)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_1.OnDestroy();
            }
            
            val_9 = null;
            val_9 = null;
            val_10 = PlayFab.Internal.PlayFabHttp._logger;
            if(val_10 == null)
            {
                goto label_16;
            }
            
            val_10 = PlayFab.Internal.PlayFabHttp._logger;
            if(val_10 == null)
            {
                goto label_19;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10.OnDestroy();
            val_9 = null;
            label_16:
            val_9 = null;
            if(PlayFab.Internal.PlayFabHttp.screenTimeTracker == null)
            {
                    return;
            }
            
            if(PlayFab.PlayFabSettings.DisableFocusTimeCollection != false)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            var val_11 = 0;
            val_11 = val_11 + 1;
            PlayFab.Internal.PlayFabHttp.screenTimeTracker.OnDestroy();
            return;
            label_19:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnApplicationFocus(bool isFocused)
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if(PlayFab.Internal.PlayFabHttp.screenTimeTracker == null)
            {
                    return;
            }
            
            if(PlayFab.PlayFabSettings.DisableFocusTimeCollection != false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            var val_4 = 0;
            val_4 = val_4 + 1;
            PlayFab.Internal.PlayFabHttp.screenTimeTracker.OnApplicationFocus(isFocused:  isFocused);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnApplicationQuit()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(PlayFab.Internal.PlayFabHttp.screenTimeTracker == null)
            {
                    return;
            }
            
            if(PlayFab.PlayFabSettings.DisableFocusTimeCollection != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            var val_3 = 0;
            val_3 = val_3 + 1;
            PlayFab.Internal.PlayFabHttp.screenTimeTracker.OnApplicationQuit();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_6;
            var val_17;
            var val_19;
            float val_20;
            var val_22;
            val_17 = public static PlayFab.ITransportPlugin PlayFab.PluginManager::GetPlugin<PlayFab.ITransportPlugin>(PlayFab.PluginContract contract, string instanceName);
            PlayFab.ITransportPlugin val_1 = PlayFab.PluginManager.GetPlugin<PlayFab.ITransportPlugin>(contract:  1, instanceName:  "");
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = 0;
            if(val_1.IsInitialized == false)
            {
                goto label_33;
            }
            
            val_19 = null;
            val_19 = null;
            val_20 = PlayFab.Internal.PlayFabHttp.delayBetweenBatches;
            if(val_20 == 0)
            {
                goto label_11;
            }
            
            val_20 = PlayFab.Internal.PlayFabHttp.delayBetweenBatches;
            if(val_20 == 0)
            {
                    val_20 = 0;
            }
            
            List.Enumerator<T> val_4 = val_20.GetEnumerator();
            label_21:
            if(((-321323152) & 1) == 0)
            {
                goto label_15;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_17 = 7;
            val_1.MakeApiCall(reqContainer:  val_6.emailUIDataHandler);
            goto label_21;
            label_15:
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525760360304});
            val_22 = null;
            val_22 = null;
            PlayFab.Internal.PlayFabHttp.delayBetweenBatches = 0f;
            PlayFab.Internal.PlayFabHttp.delayBetweenBatches.__il2cppRuntimeField_3 = 0;
            label_11:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_1.Update();
            goto label_33;
            label_36:
            UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this._injectedCoroutines.Dequeue());
            label_33:
            if(this._injectedCoroutines.Count > 0)
            {
                goto label_36;
            }
            
            goto label_39;
            label_41:
            System.Action val_15 = this._injectedAction.Dequeue();
            if(val_15 != null)
            {
                    val_15.Invoke();
            }
            
            label_39:
            if(this._injectedAction.Count > 0)
            {
                goto label_41;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal static PlayFab.PlayFabError GeneratePlayFabError(string apiEndpoint, string json, object customData)
        {
            string val_18;
            var val_21;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_22;
            object val_24;
            string val_25;
            object val_26;
            val_18 = json;
            PlayFab.ISerializerPlugin val_1 = PlayFab.PluginManager.GetPlugin<PlayFab.ISerializerPlugin>(contract:  0, instanceName:  "");
            var val_18 = 0;
            val_18 = val_18 + 1;
            if(val_1 == null)
            {
                goto label_8;
            }
            
            if((val_1.TryGetValue(key:  "errorDetails", value: out  0)) == false)
            {
                goto label_9;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            goto label_15;
            label_8:
            val_21 = 0;
            val_22 = 0;
            goto label_16;
            label_15:
            val_22 = val_1;
            goto label_17;
            label_9:
            val_22 = 0;
            label_17:
            val_21 = 1;
            label_16:
            .ApiEndpoint = apiEndpoint;
            if(val_21 == 0)
            {
                goto label_23;
            }
            
            if((val_1.ContainsKey(key:  "code")) == false)
            {
                goto label_25;
            }
            
            val_24 = val_1.Item["code"];
            int val_9 = System.Convert.ToInt32(value:  val_24);
            goto label_29;
            label_23:
            .HttpCode = 400;
            .Error = 1123;
            .HttpStatus = "BadRequest";
            goto label_47;
            label_25:
            val_24 = 400;
            label_29:
            .HttpCode = 400;
            if((val_1.ContainsKey(key:  "status")) == false)
            {
                goto label_32;
            }
            
            if((val_1.Item["status"] == null) || (null == null))
            {
                goto label_36;
            }
            
            val_25 = 0;
            goto label_36;
            label_32:
            val_25 = "BadRequest";
            label_36:
            .HttpStatus = val_25;
            if((val_1.ContainsKey(key:  "errorCode")) != false)
            {
                    val_26 = val_1.Item["errorCode"];
                int val_15 = System.Convert.ToInt32(value:  val_26);
            }
            else
            {
                    val_26 = 1123;
            }
            
            .Error = 1123;
            if((val_1.ContainsKey(key:  "errorMessage")) != false)
            {
                    val_18 = val_1.Item["errorMessage"];
                if((val_18 != null) && (null != null))
            {
                    val_18 = 0;
            }
            
            }
            
            label_47:
            .ErrorMessage = val_18;
            .ErrorDetails = val_22;
            .CustomData = customData;
            return (PlayFab.PlayFabError)new PlayFab.PlayFabError();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal static void SendErrorEvent(PlayFab.SharedModels.PlayFabRequestCommon request, PlayFab.PlayFabError error)
        {
            var val_1;
            ApiProcessErrorEvent val_2;
            val_1 = null;
            val_1 = null;
            val_2 = PlayFab.Internal.PlayFabHttp.ApiProcessingErrorEventHandler;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = PlayFab.Internal.PlayFabHttp.ApiProcessingErrorEventHandler;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(request:  request, error:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal static void SendEvent(string apiEndpoint, PlayFab.SharedModels.PlayFabRequestCommon request, PlayFab.SharedModels.PlayFabResultCommon result, PlayFab.Internal.ApiProcessingEventType eventType)
        {
            var val_2;
            PlayFabHttp.ApiProcessingEvent<PlayFab.Internal.ApiProcessingEventArgs> val_3;
            val_2 = null;
            val_2 = null;
            val_3 = PlayFab.Internal.PlayFabHttp.ApiProcessingEventHandler;
            if(val_3 == null)
            {
                    return;
            }
            
            val_3 = PlayFab.Internal.PlayFabHttp.ApiProcessingEventHandler;
            new PlayFab.Internal.ApiProcessingEventArgs() = new System.Object();
            if(new PlayFab.Internal.ApiProcessingEventArgs() != null)
            {
                    .ApiEndpoint = apiEndpoint;
                .EventType = eventType;
                .Request = request;
            }
            else
            {
                    mem[16] = apiEndpoint;
                mem[24] = eventType;
                mem[32] = request;
            }
            
            .Result = result;
            val_3.Invoke(e:  new PlayFab.Internal.ApiProcessingEventArgs());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal static void ClearAllEvents()
        {
            null = null;
            PlayFab.Internal.PlayFabHttp.ApiProcessingEventHandler = 0;
            PlayFab.Internal.PlayFabHttp.ApiProcessingErrorEventHandler = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InjectInUnityThread(System.Collections.IEnumerator x)
        {
            this._injectedCoroutines.Enqueue(item:  x);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InjectInUnityThread(System.Action action)
        {
            this._injectedAction.Enqueue(item:  action);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabHttp()
        {
            this._injectedCoroutines = new System.Collections.Generic.Queue<System.Collections.IEnumerator>();
            this._injectedAction = new System.Collections.Generic.Queue<System.Action>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabHttp()
        {
            PlayFab.Internal.PlayFabHttp.delayBetweenBatches = new System.Collections.Generic.List<PlayFab.Internal.CallRequestContainer>();
            PlayFab.Internal.PlayFabHttp.GlobalHeaderInjection = new System.Collections.Generic.Dictionary<System.String, System.String>();
            PlayFab.Internal.PlayFabHttp.screenTimeTracker = new PlayFab.Public.ScreenTimeTracker();
        }
    
    }

}
