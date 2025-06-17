using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LogEventHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float _minDelayBetweenCalls = 0.25;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<float> _timeRecord;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.Server.LogEventErrorHandler _logEventErrorHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.HashSet<Game.Server.EventResponseHandler> eventResponseSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<Game.Server.EventRequestExecutor> _unhandledPendingRequests;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<Game.Server.EventRequestExecutor> _passivePendingRequests;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.Server.EventRequestExecutor> _inflightRequestList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lastRequestExecutorTimestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _passiveRequestList;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LogEventHandler(Game.Server.LogEventErrorHandler logEventErrorHandler, System.Collections.Generic.HashSet<Game.Server.EventResponseHandler> responseSet, Master.EventExposer eventExposer)
        {
            this._timeRecord = new System.Collections.Generic.List<System.Single>();
            this._unhandledPendingRequests = new System.Collections.Generic.Queue<Game.Server.EventRequestExecutor>();
            this._passivePendingRequests = new System.Collections.Generic.Queue<Game.Server.EventRequestExecutor>();
            this._inflightRequestList = new System.Collections.Generic.List<Game.Server.EventRequestExecutor>();
            val_5 = new System.Object();
            this._logEventErrorHandler = logEventErrorHandler;
            this.eventResponseSet = val_5;
            eventExposer.add_PassiveRequestListReceived(value:  new System.Action<System.Collections.Generic.List<System.String>>(object:  this, method:  System.Void Game.Server.LogEventHandler::OnPassiveRequestListReceived(System.Collections.Generic.List<string> list)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPassiveRequestListReceived(System.Collections.Generic.List<string> list)
        {
            this._passiveRequestList = list;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ProcessScriptData(Systems.Server.ServerData scriptData)
        {
            this.ProcessServerData(scriptData:  scriptData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Send(GameSparks.Api.Requests.LogEventRequest request, System.Action<Systems.Server.ServerResponse> successCallback, System.Action<Systems.Server.ServerData> errorCallback)
        {
            GameSparks.Api.Requests.LogEventRequest val_8;
            RequestType val_9;
            LogEventHandler.<>c__DisplayClass12_0 val_1 = new LogEventHandler.<>c__DisplayClass12_0();
            if(val_1 != null)
            {
                    val_8 = val_1;
                .request = request;
                mem[1152921525148192416] = this;
                mem[1152921525148192432] = successCallback;
                mem[1152921525148192440] = errorCallback;
                val_9 = this.IsInPassiveRequestList(request:  request);
            }
            else
            {
                    mem[16] = this;
                val_8 = 24;
                mem[24] = request;
                mem[32] = successCallback;
                mem[40] = errorCallback;
                val_9 = this.IsInPassiveRequestList(request:  mem[24]);
            }
            
            val_9 = (~val_9) & 1;
            this.FireOrQueueRequestExecutor(executor:  new Game.Server.EventRequestExecutor(logEventRequest:  val_8, processDataCallback:  new System.Action<Systems.Server.ServerData>(object:  this, method:  System.Void Game.Server.LogEventHandler::ProcessServerData(Systems.Server.ServerData scriptData)), successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  val_1, method:  System.Void LogEventHandler.<>c__DisplayClass12_0::<Send>b__0(Systems.Server.ServerResponse serverResponse)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  val_1, method:  System.Void LogEventHandler.<>c__DisplayClass12_0::<Send>b__1(Systems.Server.ServerData serverData)), type:  val_9));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsInPassiveRequestList(GameSparks.Api.Requests.LogEventRequest request)
        {
            System.Collections.Generic.List<System.String> val_6;
            var val_8;
            string val_9;
            val_6 = this;
            TValue val_3 = 0;
            if(this._passiveRequestList != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
            }
            else
            {
                    val_8 = 0;
                return (bool)val_8.Contains(item:  val_9 = 0);
            }
            
            bool val_4 = request.JSONData.TryGetValue(key:  null, value: out  val_3);
            val_9 = val_3;
            if((val_9 != 0) && (1179403647 != null))
            {
                
            }
            
            val_6 = this._passiveRequestList;
            val_8 = val_6;
            return (bool)val_8.Contains(item:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FireOrQueueRequestExecutor(Game.Server.EventRequestExecutor executor)
        {
            if((this.CanFireExecutorNow(executor:  executor)) != false)
            {
                    this.FireExecutorRequest(executor:  executor);
                return;
            }
            
            if(executor.requestType == 0)
            {
                goto label_3;
            }
            
            if(this._unhandledPendingRequests != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this._unhandledPendingRequests.Enqueue(item:  executor);
            return;
            label_3:
            if(this._passivePendingRequests != null)
            {
                goto label_5;
            }
            
            goto label_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanFireExecutorNow(Game.Server.EventRequestExecutor executor)
        {
            if(executor.requestType != 1)
            {
                    return this.CanFirePassiveRequestNow();
            }
            
            return this.CanFireUnhandledRequestNow();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanFireUnhandledRequestNow()
        {
            var val_4;
            float val_4 = 0.25f;
            val_4 = this._lastRequestExecutorTimestamp + val_4;
            if(val_4 <= UnityEngine.Time.time)
            {
                    val_4 = this.AreUnhandledExecutorsPending() ^ 1;
                return (bool)val_4 & 1;
            }
            
            val_4 = 0;
            return (bool)val_4 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanFirePassiveRequestNow()
        {
            var val_5;
            float val_4 = 0.25f;
            val_4 = this._lastRequestExecutorTimestamp + val_4;
            if(val_4 <= UnityEngine.Time.time)
            {
                    if(this.IsAnExecutorInFlight() == false)
            {
                goto label_1;
            }
            
            }
            
            val_5 = 0;
            goto label_2;
            label_1:
            bool val_3 = this.AreAnyExecutorsPending();
            val_5 = val_3 ^ 1;
            label_2:
            val_3 = val_5;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldExecutorWaitForDelay()
        {
            float val_3 = 0.25f;
            val_3 = this._lastRequestExecutorTimestamp + val_3;
            return (bool)(val_3 > UnityEngine.Time.time) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AreUnhandledExecutorsPending()
        {
            return (bool)(this._unhandledPendingRequests.Count > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsAnExecutorInFlight()
        {
            return (bool)(this._inflightRequestList.Count > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AreAnyExecutorsPending()
        {
            System.Collections.Generic.Queue<Game.Server.EventRequestExecutor> val_4;
            var val_5;
            val_4 = this;
            if(this._unhandledPendingRequests.Count > 0)
            {
                    val_5 = 1;
                return (bool)(val_4.Count > 0) ? 1 : 0;
            }
            
            val_4 = this._passivePendingRequests;
            return (bool)(val_4.Count > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FireExecutorRequest(Game.Server.EventRequestExecutor executor)
        {
            this._lastRequestExecutorTimestamp = UnityEngine.Time.time;
            this._inflightRequestList.Add(item:  executor);
            this.AddToTimeRecord(time:  this._lastRequestExecutorTimestamp);
            executor.Send();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddToTimeRecord(float time)
        {
            this._timeRecord.Add(item:  time);
            if(this._timeRecord.Count < 21)
            {
                    return;
            }
            
            this._timeRecord.RemoveRange(index:  0, count:  10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FirePendingRequest()
        {
            if(this.CanFireQueuedUnhandledEvent() == false)
            {
                goto label_1;
            }
            
            if(this._unhandledPendingRequests != null)
            {
                goto label_4;
            }
            
            label_5:
            label_4:
            this.FireExecutorRequest(executor:  this._unhandledPendingRequests.Dequeue());
            return;
            label_1:
            if(this.CanFireQueuedPassiveEvent() == false)
            {
                    return;
            }
            
            if(this._passivePendingRequests != null)
            {
                goto label_4;
            }
            
            goto label_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanFireQueuedUnhandledEvent()
        {
            var val_4;
            if(this.AreUnhandledExecutorsPending() != false)
            {
                    float val_4 = 0.25f;
                val_4 = this._lastRequestExecutorTimestamp + val_4;
                var val_3 = (val_4 <= UnityEngine.Time.time) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanFireQueuedPassiveEvent()
        {
            var val_5;
            if(this.ArePassiveExecutorsPending() != false)
            {
                    if(this.IsAnExecutorInFlight() == false)
            {
                goto label_1;
            }
            
            }
            
            val_5 = 0;
            return (bool)(val_5 <= UnityEngine.Time.time) ? 1 : 0;
            label_1:
            float val_5 = 0.25f;
            val_5 = this._lastRequestExecutorTimestamp + val_5;
            return (bool)(val_5 <= UnityEngine.Time.time) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ArePassiveExecutorsPending()
        {
            return (bool)(this._passivePendingRequests.Count > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FireQueuedRequest(Game.Server.EventRequestExecutor executor)
        {
            this.FireExecutorRequest(executor:  executor);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessServerData(Systems.Server.ServerData scriptData)
        {
            HashSet.Enumerator<T> val_1 = this.eventResponseSet.GetEnumerator();
            label_8:
            if(((-931387384) & 1) == 0)
            {
                goto label_2;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            0.emailUIDataHandler.TryHandleResponse(data:  scriptData = scriptData);
            goto label_8;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525150296072});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessSuccessCallback(GameSparks.Api.Requests.LogEventRequest request, Systems.Server.ServerResponse serverResponse, System.Action<Systems.Server.ServerResponse> successCallback)
        {
            System.Action<Systems.Server.ServerResponse> val_6 = successCallback;
            this.RemoveRequestExecutor(request:  request);
            if((System.String.IsNullOrEmpty(value:  serverResponse.Errors.GetString(key:  "errCode"))) != false)
            {
                    if(val_6 == null)
            {
                    return;
            }
            
                val_6.Invoke(obj:  serverResponse);
                return;
            }
            
            val_6 = this._logEventErrorHandler;
            if(val_6.HasConfigData() == false)
            {
                    return;
            }
            
            val_6.HandleShowBlockingError(request:  request, serverData:  serverResponse.Errors);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveRequestExecutor(GameSparks.Api.Requests.LogEventRequest request)
        {
            .request = request;
            int val_3 = this._inflightRequestList.FindIndex(match:  new System.Predicate<Game.Server.EventRequestExecutor>(object:  new LogEventHandler.<>c__DisplayClass31_0(), method:  System.Boolean LogEventHandler.<>c__DisplayClass31_0::<RemoveRequestExecutor>b__0(Game.Server.EventRequestExecutor x)));
            if((val_3 & 2147483648) != 0)
            {
                    return;
            }
            
            this._inflightRequestList.RemoveAt(index:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessErrorCallback(GameSparks.Api.Requests.LogEventRequest request, Systems.Server.ServerData serverData, System.Action<Systems.Server.ServerData> errorCallback)
        {
            this.RemoveRequestExecutor(request:  request);
            if(errorCallback != null)
            {
                    errorCallback.Invoke(obj:  serverData);
            }
            
            if(this._logEventErrorHandler.HasConfigData() == false)
            {
                    return;
            }
            
            this._logEventErrorHandler.HandleShowBlockingError(request:  request, serverData:  serverData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.FirePendingRequest();
        }
    
    }

}
