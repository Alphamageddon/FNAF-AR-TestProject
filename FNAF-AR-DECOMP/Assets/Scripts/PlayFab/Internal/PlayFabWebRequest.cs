using UnityEngine;

namespace PlayFab.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabWebRequest : ITransportPlugin, IPlayFabPlugin
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.Queue<System.Action> ResultQueueTransferThread;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.Queue<System.Action> ResultQueueMainThread;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.List<PlayFab.Internal.CallRequestContainer> ActiveRequests;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool certValidationSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Threading.Thread _requestQueueThread;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly object _ThreadLock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.TimeSpan ThreadKillTimeout;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.DateTime _threadKillTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _isApplicationPlaying;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int _activeCallCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string _unityVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInitialized;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Net.Security.RemoteCertificateValidationCallback CustomCertValidationHook { set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInitialized { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SkipCertificateValidation()
        {
            var val_2;
            System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(object:  0, method:  static System.Boolean PlayFab.Internal.PlayFabWebRequest::AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors));
            val_2 = null;
            val_2 = null;
            PlayFab.Internal.PlayFabWebRequest.certValidationSet = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_CustomCertValidationHook(System.Net.Security.RemoteCertificateValidationCallback value)
        {
            var val_1;
            System.Net.ServicePointManager.ServerCertificateValidationCallback = value;
            val_1 = null;
            val_1 = null;
            PlayFab.Internal.PlayFabWebRequest.certValidationSet = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsInitialized()
        {
            return (bool)this._isInitialized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize()
        {
            var val_2;
            this.SetupCertificates();
            val_2 = null;
            val_2 = null;
            PlayFab.Internal.PlayFabWebRequest._isApplicationPlaying = true;
            PlayFab.Internal.PlayFabWebRequest._unityVersion = UnityEngine.Application.unityVersion;
            this._isInitialized = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_5 = null;
            val_5 = null;
            PlayFab.Internal.PlayFabWebRequest._isApplicationPlaying = false;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread, lockTaken: ref  val_1);
            val_6 = null;
            val_6 = null;
            PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread.Clear();
            val_7 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread);
            }
            
            if(44 == 44)
            {
                
            }
            else
            {
                    if(val_7 != 0)
            {
                    val_7 = 0;
            }
            
            }
            
            val_8 = null;
            val_8 = null;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ActiveRequests, lockTaken: ref  val_2);
            val_9 = null;
            val_9 = null;
            PlayFab.Internal.PlayFabWebRequest.ActiveRequests.Clear();
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ActiveRequests);
            }
            
            if(((82 == 0) ? 82 : 82) == 82)
            {
                
            }
            else
            {
                    if(val_7 != 0)
            {
                    val_7 = 0;
            }
            
            }
            
            val_10 = null;
            val_10 = null;
            bool val_4 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest._ThreadLock, lockTaken: ref  val_4);
            val_11 = null;
            val_11 = null;
            PlayFab.Internal.PlayFabWebRequest._requestQueueThread = 0;
            if(val_4 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest._ThreadLock);
            }
            
            if(val_7 == 0)
            {
                    return;
            }
            
            if(116 == 0)
            {
                    return;
            }
            
            if(116 == 116)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupCertificates()
        {
            var val_1;
            System.Net.ServicePointManager.DefaultConnectionLimit = 10;
            System.Net.ServicePointManager.Expect100Continue = false;
            val_1 = null;
            val_1 = null;
            if(PlayFab.Internal.PlayFabWebRequest.certValidationSet != false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "PlayFab API calls will likely fail because you have not set up a HttpWebRequest certificate validation mechanism");
            UnityEngine.Debug.LogWarning(message:  "Please set a validation callback into PlayFab.Internal.PlayFabWebRequest.CustomCertValidationHook, or set PlayFab.Internal.PlayFabWebRequest.SkipCertificateValidation()");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimpleGetCall(string fullUrl, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            PlayFabWebRequest.<>c__DisplayClass21_0 val_1 = new PlayFabWebRequest.<>c__DisplayClass21_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .fullUrl = fullUrl;
                .successCallback = successCallback;
            }
            else
            {
                    mem[16] = this;
                mem[24] = fullUrl;
                mem[32] = successCallback;
            }
            
            .errorCallback = errorCallback;
            new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  val_1, method:  System.Void PlayFabWebRequest.<>c__DisplayClass21_0::<SimpleGetCall>b__0())).Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimplePutCall(string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            PlayFabWebRequest.<>c__DisplayClass22_0 val_1 = new PlayFabWebRequest.<>c__DisplayClass22_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .fullUrl = fullUrl;
                .payload = payload;
                .successCallback = successCallback;
            }
            else
            {
                    mem[16] = this;
                mem[24] = fullUrl;
                mem[32] = payload;
                mem[40] = successCallback;
            }
            
            .errorCallback = errorCallback;
            new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  val_1, method:  System.Void PlayFabWebRequest.<>c__DisplayClass22_0::<SimplePutCall>b__0())).Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimplePostCall(string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            PlayFabWebRequest.<>c__DisplayClass23_0 val_1 = new PlayFabWebRequest.<>c__DisplayClass23_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .fullUrl = fullUrl;
                .payload = payload;
                .successCallback = successCallback;
            }
            else
            {
                    mem[16] = this;
                mem[24] = fullUrl;
                mem[32] = payload;
                mem[40] = successCallback;
            }
            
            .errorCallback = errorCallback;
            new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  val_1, method:  System.Void PlayFabWebRequest.<>c__DisplayClass23_0::<SimplePostCall>b__0())).Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SimpleHttpsWorker(string httpMethod, string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            System.Byte[] val_18;
            var val_19;
            var val_20;
            val_13 = payload;
            val_14 = System.Net.WebRequest.Create(requestUriString:  fullUrl);
            if(val_14 != null)
            {
                    val_14 = 0;
            }
            
            val_15 = null;
            val_15 = null;
            string val_4 = "UnityEngine-Unity; Version: "("UnityEngine-Unity; Version: ") + PlayFab.Internal.PlayFabWebRequest._unityVersion;
            if(val_14 != 0)
            {
                    val_16 = 0;
                val_14.UserAgent = val_4;
            }
            else
            {
                    val_16 = 0;
                val_14.UserAgent = val_4;
            }
            
            val_14.KeepAlive = PlayFab.PlayFabSettings.RequestKeepAlive;
            int val_7 = PlayFab.PlayFabSettings.RequestTimeout;
            val_14.ReadWriteTimeout = PlayFab.PlayFabSettings.RequestTimeout;
            if(val_13 == null)
            {
                goto label_12;
            }
            
            val_13 = 0;
            var val_13 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_17;
            }
            
            var val_11 = mem[282584257676847];
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_16:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < mem[282584257676957])
            {
                goto label_16;
            }
            
            goto label_17;
            label_12:
            if(val_14 != 0)
            {
                goto label_27;
            }
            
            goto label_22;
            label_15:
            val_13 = val_13 + (((mem[282584257676847] + 8)) << 4);
            val_17 = val_13 + 296;
            label_17:
            val_14.Dispose();
            if(122 != 122)
            {
                goto label_20;
            }
            
            if(val_14 != 0)
            {
                goto label_27;
            }
            
            goto label_22;
            label_20:
            if( != 0)
            {
                    val_13 = 0;
            }
            
            if(val_14 != 0)
            {
                goto label_27;
            }
            
            label_22:
            label_27:
            if(val_14 == 0)
            {
                goto label_29;
            }
            
            byte[] val_9 = new byte[0];
            val_18 = val_9;
            val_19 = 184;
            var val_16 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_34;
            }
            
            var val_14 = mem[282584257676847];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_33:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_32;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < mem[282584257676957])
            {
                goto label_33;
            }
            
            goto label_34;
            label_29:
            val_18 = 0;
            val_19 = 184;
            goto label_35;
            label_32:
            val_16 = val_16 + (((mem[282584257676847] + 8)) << 4);
            val_20 = val_16 + 296;
            label_34:
            val_14.Dispose();
            label_35:
            if(((184 == 0) ? 184 : 184) != 184)
            {
                goto label_36;
            }
            
            if(successCallback != null)
            {
                goto label_40;
            }
            
            goto label_38;
            label_36:
            if(successCallback != null)
            {
                goto label_40;
            }
            
            label_38:
            label_40:
            successCallback.Invoke(obj:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MakeApiCall(object reqContainerObj)
        {
            PlayFab.Internal.CallRequestContainer val_4;
            var val_5;
            var val_6;
            val_4 = reqContainerObj;
            val_4 = 0;
            mem[16] = 2;
            val_5 = null;
            val_5 = null;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ActiveRequests, lockTaken: ref  val_3);
            val_6 = null;
            val_6 = null;
            PlayFab.Internal.PlayFabWebRequest.ActiveRequests.Insert(index:  0, item:  val_4);
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ActiveRequests);
            }
            
            PlayFab.Internal.PlayFabWebRequest.ActivateThreadWorker();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ActivateThreadWorker()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest._ThreadLock, lockTaken: ref  val_1);
            val_5 = null;
            val_5 = null;
            if(PlayFab.Internal.PlayFabWebRequest._requestQueueThread == null)
            {
                    new System.Threading.ThreadStart() = new System.Threading.ThreadStart(object:  0, method:  static System.Void PlayFab.Internal.PlayFabWebRequest::WorkerThreadMainLoop());
                new System.Threading.Thread() = new System.Threading.Thread(start:  new System.Threading.ThreadStart());
                val_6 = null;
                val_6 = null;
                PlayFab.Internal.PlayFabWebRequest._requestQueueThread = new System.Threading.Thread();
                new System.Threading.Thread().Start();
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest._ThreadLock);
            }
            
            if(69 == 69)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void WorkerThreadMainLoop()
        {
            var val_20;
            var val_21;
            var val_22;
            System.Collections.Generic.List<PlayFab.Internal.CallRequestContainer> val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_29;
            var val_30;
            var val_31;
            val_20 = null;
            val_20 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest._ThreadLock, lockTaken: ref  val_1);
            System.DateTime val_2 = System.DateTime.UtcNow;
            val_21 = null;
            val_21 = null;
            System.DateTime val_3 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_2.dateData}, t:  new System.TimeSpan() {_ticks = PlayFab.Internal.PlayFabWebRequest.ThreadKillTimeout});
            val_22 = 0;
            PlayFab.Internal.PlayFabWebRequest._threadKillTime = val_3.dateData;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest._ThreadLock);
            }
            
            if(48 == 48)
            {
                
            }
            else
            {
                    if(val_22 != 0)
            {
                    val_22 = 0;
            }
            
            }
            
            val_23 = null;
            val_23 = new System.Collections.Generic.List<PlayFab.Internal.CallRequestContainer>();
            label_71:
            val_24 = null;
            val_24 = null;
            bool val_5 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ActiveRequests, lockTaken: ref  val_5);
            val_25 = null;
            val_25 = null;
            null.AddRange(collection:  PlayFab.Internal.PlayFabWebRequest.ActiveRequests);
            PlayFab.Internal.PlayFabWebRequest.ActiveRequests.Clear();
            PlayFab.Internal.PlayFabWebRequest._activeCallCount = null.Count;
            if(val_5 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ActiveRequests);
            }
            
            if(((117 == 0) ? 117 : 117) != 117)
            {
                goto label_19;
            }
            
            if(val_23 != null)
            {
                goto label_23;
            }
            
            goto label_21;
            label_19:
            if(val_22 != 0)
            {
                    val_22 = 0;
            }
            
            if(val_23 != null)
            {
                goto label_23;
            }
            
            label_21:
            label_23:
            int val_8 = null.Count;
            int val_9 = val_8 - 1;
            if((val_9 & 2147483648) != 0)
            {
                goto label_24;
            }
            
            label_46:
            PlayFab.Internal.CallRequestContainer val_10 = null.Item[val_9];
            if(val_10.HttpState > 3)
            {
                goto label_41;
            }
            
            var val_20 = 49756172 + (val_10.HttpState) << 2;
            val_20 = val_20 + 49756172;
            goto (49756172 + (val_10.HttpState) << 2 + 49756172);
            label_41:
            val_9 = val_9 - 1;
            if((val_9 & 2147483648) == 0)
            {
                goto label_46;
            }
            
            label_24:
            val_26 = null;
            val_26 = null;
            bool val_15 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest._ThreadLock, lockTaken: ref  val_15);
            System.DateTime val_16 = System.DateTime.UtcNow;
            val_27 = null;
            if(val_8 >= 1)
            {
                    val_27 = null;
                if(PlayFab.Internal.PlayFabWebRequest._isApplicationPlaying != false)
            {
                    System.DateTime val_17 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_16.dateData}, t:  new System.TimeSpan() {_ticks = PlayFab.Internal.PlayFabWebRequest.ThreadKillTimeout});
                val_27 = null;
                PlayFab.Internal.PlayFabWebRequest._threadKillTime = val_17.dateData;
            }
            
            }
            
            val_27 = null;
            if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_16.dateData}, t2:  new System.DateTime() {dateData = PlayFab.Internal.PlayFabWebRequest._threadKillTime})) != false)
            {
                    val_29 = 1;
            }
            else
            {
                    val_30 = null;
                val_30 = null;
                val_29 = 0;
                PlayFab.Internal.PlayFabWebRequest._requestQueueThread = 0;
            }
            
            if(val_15 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest._ThreadLock);
            }
            
            if(((354 == 0) ? 354 : 354) == 354)
            {
                    val_31 = 0;
            }
            
            System.Threading.Thread.Sleep(millisecondsTimeout:  1);
            if((val_29 & 1) != 0)
            {
                goto label_71;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void Post(PlayFab.Internal.CallRequestContainer reqContainer)
        {
            var val_8;
            System.Net.HttpWebRequest val_24;
            var val_25;
            var val_26;
            var val_27;
            string val_30;
            var val_31;
            val_24 = System.Net.WebRequest.Create(requestUriString:  reqContainer.FullUrl);
            if(val_24 != null)
            {
                    val_24 = 0;
            }
            
            reqContainer.HttpRequest = val_24;
            val_25 = null;
            val_25 = null;
            val_24.UserAgent = "UnityEngine-Unity; Version: "("UnityEngine-Unity; Version: ") + PlayFab.Internal.PlayFabWebRequest._unityVersion;
            reqContainer.HttpRequest.SendChunked = false;
            Dictionary.Enumerator<TKey, TValue> val_5 = reqContainer.RequestHeaders.GetEnumerator();
            label_16:
            if(((-310513344) & 1) == 0)
            {
                goto label_13;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_9 = val_8.trackableId;
            ulong val_10 = val_9.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key());
            if(reqContainer.HttpRequest != null)
            {
                goto label_16;
            }
            
            goto label_16;
            label_13:
            val_26 = 0;
            val_27 = 149;
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525771170112});
            if( == 149)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_26 = 0;
            }
            
            }
            
            reqContainer.HttpRequest.KeepAlive = PlayFab.PlayFabSettings.RequestKeepAlive;
            int val_14 = PlayFab.PlayFabSettings.RequestTimeout;
            reqContainer.HttpRequest.ReadWriteTimeout = PlayFab.PlayFabSettings.RequestTimeout;
            val_30 = reqContainer.HttpRequest;
            val_31 = 317;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_30.Dispose();
            reqContainer.HttpState = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ProcessHttpResponse(PlayFab.Internal.CallRequestContainer reqContainer)
        {
            reqContainer.HttpRequest = 0;
            if(reqContainer.HttpRequest == 200)
            {
                    reqContainer.JsonResponse = PlayFab.Internal.PlayFabWebRequest.ResponseToString(webResponse:  reqContainer.HttpRequest);
            }
            
            if(reqContainer.HttpRequest == 200)
            {
                    if((System.String.IsNullOrEmpty(value:  reqContainer.JsonResponse)) == false)
            {
                goto label_10;
            }
            
            }
            
            reqContainer.JsonResponse = (reqContainer.JsonResponse == null) ? "No response from server" : reqContainer.JsonResponse;
            PlayFab.Internal.PlayFabWebRequest.QueueRequestError(reqContainer:  reqContainer);
            return;
            label_10:
            reqContainer.HttpState = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void QueueRequestError(PlayFab.Internal.CallRequestContainer reqContainer)
        {
            var val_5;
            var val_6;
            PlayFabWebRequest.<>c__DisplayClass30_0 val_1 = new PlayFabWebRequest.<>c__DisplayClass30_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .reqContainer = reqContainer;
            if(reqContainer != null)
            {
                goto label_20;
            }
            
            label_21:
            label_20:
            reqContainer.Error = PlayFab.Internal.PlayFabHttp.GeneratePlayFabError(apiEndpoint:  reqContainer.ApiEndpoint, json:  reqContainer.JsonResponse, customData:  reqContainer.CustomData);
            HttpState = 3;
            val_5 = null;
            val_5 = null;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread, lockTaken: ref  val_3);
            val_6 = null;
            val_6 = null;
            new System.Action() = new System.Action(object:  val_1, method:  System.Void PlayFabWebRequest.<>c__DisplayClass30_0::<QueueRequestError>b__0());
            PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread.Enqueue(item:  new System.Action());
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread);
            }
            
            if(124 == 124)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            return;
            label_1:
            mem[16] = reqContainer;
            if(mem[16] != 0)
            {
                goto label_20;
            }
            
            goto label_21;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ProcessJsonResponse(PlayFab.Internal.CallRequestContainer reqContainer)
        {
            var val_15;
            PlayFab.Internal.CallRequestContainer val_17;
            PlayFab.SharedModels.PlayFabResultCommon val_18;
            PlayFab.Internal.CallRequestContainer val_19;
            PlayFab.SharedModels.PlayFabResultCommon val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            PlayFabWebRequest.<>c__DisplayClass31_0 val_1 = new PlayFabWebRequest.<>c__DisplayClass31_0();
            .reqContainer = reqContainer;
            PlayFab.ISerializerPlugin val_2 = PlayFab.PluginManager.GetPlugin<PlayFab.ISerializerPlugin>(contract:  0, instanceName:  "");
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_2, typeof(public PlayFab.SharedModels.HttpResponseObject PlayFab.ISerializerPlugin::DeserializeObject<PlayFab.SharedModels.HttpResponseObject>(string serialized).__il2cppRuntimeField_18), slot: 0) + 8;
            if(val_2 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_15 = 3;
            }
            else
            {
                    PlayFab.Internal.PlayFabWebRequest.QueueRequestError(reqContainer:  (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer);
                return;
            }
            
            (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer.JsonResponse = val_2.SerializeObject(obj:  val_2);
            (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer.DeserializeResultJson.Invoke();
            val_17 = (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer;
            if(val_17 != null)
            {
                    val_18 = (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer.ApiResult;
            }
            else
            {
                    val_18 = (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer.ApiResult;
                if(((PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer) != null)
            {
                    val_17 = (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer;
            }
            else
            {
                    val_17 = 0;
            }
            
            }
            
            (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer.ApiResult.Request = 1;
            val_19 = (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer;
            if(val_19 != null)
            {
                    val_20 = (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer.ApiResult;
            }
            else
            {
                    val_20 = (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer.ApiResult;
                if(((PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer) != null)
            {
                    val_19 = (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer;
            }
            else
            {
                    val_19 = 0;
            }
            
            }
            
            (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer.ApiResult.CustomData = 1;
            PlayFab.Internal.SingletonMonoBehaviour<PlayFab.Internal.PlayFabHttp>.instance.OnPlayFabApiResult(reqContainer:  (PlayFabWebRequest.<>c__DisplayClass31_0)[1152921525771946848].reqContainer);
            val_21 = null;
            val_21 = null;
            bool val_7 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread, lockTaken: ref  val_7);
            val_22 = null;
            val_22 = null;
            new System.Action() = new System.Action(object:  val_1, method:  System.Void PlayFabWebRequest.<>c__DisplayClass31_0::<ProcessJsonResponse>b__0());
            PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread.Enqueue(item:  new System.Action());
            val_23 = 0;
            if(val_7 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread);
            }
            
            if(236 == 236)
            {
                
            }
            else
            {
                    if(val_23 != 0)
            {
                    val_23 = 0;
            }
            
            }
            
            val_24 = null;
            val_24 = null;
            bool val_9 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread, lockTaken: ref  val_9);
            val_25 = null;
            val_25 = null;
            new System.Action() = new System.Action(object:  val_1, method:  System.Void PlayFabWebRequest.<>c__DisplayClass31_0::<ProcessJsonResponse>b__1());
            PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread.Enqueue(item:  new System.Action());
            if(val_9 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread);
            }
            
            if(val_23 == 0)
            {
                    return;
            }
            
            if(288 == 0)
            {
                    return;
            }
            
            if(288 == 288)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_6 = null;
            val_6 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread, lockTaken: ref  val_1);
            label_11:
            val_7 = null;
            val_7 = null;
            if(PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread.Count < 1)
            {
                goto label_6;
            }
            
            val_8 = null;
            val_8 = null;
            PlayFab.Internal.PlayFabWebRequest.ResultQueueMainThread.Enqueue(item:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread.Dequeue());
            goto label_11;
            label_6:
            val_9 = 0;
            val_10 = 80;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread);
            }
            
            if( == 80)
            {
                goto label_19;
            }
            
            label_29:
            val_11 = null;
            val_11 = null;
            PlayFab.Internal.PlayFabWebRequest.ResultQueueMainThread.Dequeue().Invoke();
            label_19:
            val_12 = null;
            val_12 = null;
            if(PlayFab.Internal.PlayFabWebRequest.ResultQueueMainThread.Count > 0)
            {
                goto label_29;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string ResponseToString(System.Net.WebResponse webResponse)
        {
            System.IO.Stream val_9;
            System.IO.Stream val_10;
            var val_11;
            val_9 = webResponse;
            if(val_9 == null)
            {
                    return (string)val_9;
            }
            
            val_10 = val_9;
            if(val_10 != null)
            {
                    new System.IO.StreamReader() = new System.IO.StreamReader(stream:  val_10);
                val_9 = new System.IO.StreamReader();
                val_11 = 0;
                var val_9 = 0;
                val_9 = val_9 + 1;
                new System.IO.StreamReader().Dispose();
                if((val_11 != 0) && (139 != 139))
            {
                    val_11 = 0;
            }
            
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_10.Dispose();
                if(139 == 139)
            {
                    return (string)val_9;
            }
            
                if(val_11 != 0)
            {
                    val_11 = 0;
            }
            
                val_10 = 0;
                System.Net.WebResponse val_4 = val_10.Response;
                if(val_4 != null)
            {
                    new System.IO.StreamReader() = new System.IO.StreamReader(stream:  val_4);
                val_9 = new System.IO.StreamReader();
                var val_11 = 0;
                val_11 = val_11 + 1;
                new System.IO.StreamReader().Dispose();
                var val_7 = (139 == 0) ? 139 : 139;
                if((val_11 != 0) && (val_7 != 139))
            {
                    val_11 = 0;
            }
            
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_4.Dispose();
                if(val_7 == 0)
            {
                    return (string)val_9;
            }
            
                if(val_7 == 139)
            {
                    return (string)val_9;
            }
            
                UnityEngine.Debug.LogException(exception:  val_10);
            }
            
            }
            
            val_9 = 0;
            return (string)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPendingMessages()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_5 = null;
            val_5 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ActiveRequests, lockTaken: ref  val_1);
            val_6 = null;
            val_6 = null;
            System.Collections.Generic.List<PlayFab.Internal.CallRequestContainer> val_5 = PlayFab.Internal.PlayFabWebRequest.ActiveRequests;
            val_7 = 0;
            val_5 = PlayFab.Internal.PlayFabWebRequest._activeCallCount + val_5.Count;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ActiveRequests);
            }
            
            if(49 == 49)
            {
                
            }
            else
            {
                    if(val_7 != 0)
            {
                    val_7 = 0;
            }
            
            }
            
            val_8 = null;
            val_8 = null;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread, lockTaken: ref  val_3);
            val_9 = null;
            val_9 = null;
            val_5 = PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread.Count + val_5;
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread);
            }
            
            if(val_7 == 0)
            {
                    return (int)val_5;
            }
            
            if(90 == 0)
            {
                    return (int)val_5;
            }
            
            if(90 == 90)
            {
                    return (int)val_5;
            }
            
            return (int)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabWebRequest()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabWebRequest()
        {
            PlayFab.Internal.PlayFabWebRequest.ResultQueueTransferThread = new System.Collections.Generic.Queue<System.Action>();
            PlayFab.Internal.PlayFabWebRequest.ResultQueueMainThread = new System.Collections.Generic.Queue<System.Action>();
            PlayFab.Internal.PlayFabWebRequest.ActiveRequests = new System.Collections.Generic.List<PlayFab.Internal.CallRequestContainer>();
            PlayFab.Internal.PlayFabWebRequest.certValidationSet = false;
            PlayFab.Internal.PlayFabWebRequest._ThreadLock = new System.Object();
            System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  60);
            PlayFab.Internal.PlayFabWebRequest.ThreadKillTimeout = val_5._ticks;
            System.DateTime val_6 = System.DateTime.UtcNow;
            System.DateTime val_7 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_6.dateData}, t:  new System.TimeSpan() {_ticks = PlayFab.Internal.PlayFabWebRequest.ThreadKillTimeout});
            PlayFab.Internal.PlayFabWebRequest._threadKillTime = val_7.dateData;
        }
    
    }

}
