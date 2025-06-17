using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EventRequestExecutor
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ClassName = "EventRequestExecutor";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<Systems.Server.ServerData> _processDataCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<Systems.Server.ServerResponse> _successCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<Systems.Server.ServerData> _errorCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Errors.ServerErrorLogger _errorLogger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int retries;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Api.Requests.LogEventRequest _logEventRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _eventKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.Server.EventRequestExecutor.RequestType requestType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int _outOfOrderLogThreshold = 5;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameSparks.Api.Requests.LogEventRequest Request { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameSparks.Api.Requests.LogEventRequest get_Request()
        {
            return (GameSparks.Api.Requests.LogEventRequest)this._logEventRequest;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EventRequestExecutor(GameSparks.Api.Requests.LogEventRequest logEventRequest, System.Action<Systems.Server.ServerData> processDataCallback, System.Action<Systems.Server.ServerResponse> successCallback, System.Action<Systems.Server.ServerData> errorCallback, Game.Server.EventRequestExecutor.RequestType type)
        {
            this._logEventRequest = logEventRequest;
            this._processDataCallback = processDataCallback;
            this._successCallback = successCallback;
            this._errorCallback = errorCallback;
            Game.Server.Errors.ServerErrorLogger val_2 = new Game.Server.Errors.ServerErrorLogger();
            ._processor = new Game.Server.Errors.RuntimeLoggingProcessor();
            val_2.GenerateFilterMap();
            this._errorLogger = val_2;
            this.requestType = type;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Send()
        {
            int val_6;
            var val_18;
            System.Action<OUT> val_19;
            string val_21;
            var val_22;
            var val_27;
            var val_29;
            var val_30;
            var val_33;
            val_18 = null;
            val_18 = null;
            if(Game.Server.ServerDomain.CurrentServer != 2)
            {
                    if(Game.Server.ServerDomain.CurrentServer != 1)
            {
                    return;
            }
            
                System.Action<GameSparks.Api.Responses.LogEventResponse> val_1 = null;
                val_19 = val_1;
                val_1 = new System.Action<GameSparks.Api.Responses.LogEventResponse>(object:  this, method:  System.Void Game.Server.EventRequestExecutor::ProcessGsResponse(GameSparks.Api.Responses.LogEventResponse gsResponse));
                this._logEventRequest.Send(callback:  val_1);
                return;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            bool val_5 = this._logEventRequest.JSONData.TryGetValue(key:  0, value: out  TValue val_4 = null);
            val_21 = 0;
            if((val_21 != 0) && (1179403647 != null))
            {
                    val_21 = 0;
            }
            
            this._eventKey = val_21;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_22 = null;
            val_22 = null;
            int val_26 = Game.Server.ServerDomain.ExecuteCloudScriptCount;
            val_26 = val_26 + 1;
            Game.Server.ServerDomain.ExecuteCloudScriptCount = val_26;
            val_6 = Game.Server.ServerDomain.ExecuteCloudScriptCount;
            val_7.Add(key:  "executeCloudScriptCount", value:  val_6);
            val_7.Add(key:  "currentSessionToken", value:  Game.Server.ServerDomain.CurrentSessionToken);
            var val_27 = 0;
            val_27 = val_27 + 1;
            var val_28 = 0;
            val_28 = val_28 + 1;
            System.Collections.Generic.IEnumerator<T> val_12 = this._logEventRequest.JSONData.Keys.GetEnumerator();
            label_49:
            var val_29 = 0;
            val_29 = val_29 + 1;
            if(val_12.MoveNext() == false)
            {
                goto label_35;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            T val_16 = val_12.Current;
            val_27 = 0;
            if((System.String.op_Equality(a:  val_16, b:  "eventKey")) == true)
            {
                goto label_49;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_27 = 0;
            val_7.Add(key:  val_16, value:  this._logEventRequest.JSONData.Item[0]);
            goto label_49;
            label_35:
            val_29 = 0;
            val_30 = 222;
            if(val_12 == null)
            {
                
            }
            else
            {
                    var val_32 = 0;
                val_32 = val_32 + 1;
                val_12.Dispose();
            }
            
            PlayFab.ClientModels.ExecuteCloudScriptRequest val_22 = null;
            val_19 = val_22;
            val_22 = new PlayFab.ClientModels.ExecuteCloudScriptRequest();
            val_33 = null;
            val_33 = null;
            if(val_19 != null)
            {
                    mem[1152921525143987600] = Game.Server.ServerDomain.AuthContext;
                .FunctionName = this._eventKey;
            }
            else
            {
                    mem[16] = Game.Server.ServerDomain.AuthContext;
                mem[24] = this._eventKey;
            }
            
            .FunctionParameter = val_7;
            val_6 = 0;
            .GeneratePlayStreamEvent = val_6;
            PlayFab.PlayFabClientAPI.ExecuteCloudScript(request:  val_22, resultCallback:  new System.Action<PlayFab.ClientModels.ExecuteCloudScriptResult>(object:  this, method:  System.Void Game.Server.EventRequestExecutor::ProcessPfResponse(PlayFab.ClientModels.ExecuteCloudScriptResult result)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Game.Server.EventRequestExecutor::ProcessPfErrors(PlayFab.PlayFabError pfErrors)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessPfResponse(PlayFab.ClientModels.ExecuteCloudScriptResult result)
        {
            Systems.Server.PlayFabProxy.PFData val_8;
            object val_9;
            if(result.Error != null)
            {
                    PlayFab.Json.JsonObject val_1 = new PlayFab.Json.JsonObject();
                val_1.Add(key:  "Error", value:  result.Error);
                PlayFab.Json.JsonObject val_2 = new PlayFab.Json.JsonObject();
                val_2.Add(key:  "scriptError", value:  val_1);
                Systems.Server.PlayFabProxy.PFData val_3 = null;
                val_8 = val_3;
                val_3 = new Systems.Server.PlayFabProxy.PFData(data:  val_2);
            }
            else
            {
                    val_9 = result.FunctionResult;
                val_8 = new Systems.Server.PlayFabProxy.PFData();
                if(val_9 != null)
            {
                    val_9 = 0;
            }
            
                val_8 = new Systems.Server.PlayFabProxy.PFData(data:  val_9);
                this.CheckCloudScriptExecutionOrder(data:  new Systems.Server.PlayFabProxy.PFData());
            }
            
            this.ProcessResponse(gsResponse:  0, pfResponse:  new Systems.Server.PlayFabProxy.PFResponse(requestId:  this._eventKey, responseData:  new Systems.Server.PlayFabProxy.PFData()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckCloudScriptExecutionOrder(Systems.Server.PlayFabProxy.PFData data)
        {
            int val_7;
            int val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = this;
            System.Nullable<System.Int32> val_1 = data.GetInt(key:  "executeCloudScriptCount");
            if(((-937375944) & 1) == 0)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            val_7 = Game.Server.ServerDomain.ExecuteCloudScriptLastProcessed + 1;
            val_10 = null;
            if(val_1.HasValue.region == val_7)
            {
                    if(((-937375960) & 1) != 0)
            {
                goto label_9;
            }
            
            }
            
            val_10 = null;
            int val_6 = Game.Server.ServerDomain.OutOfOrderCounter;
            val_6 = val_6 + 1;
            Game.Server.ServerDomain.OutOfOrderCounter = val_6;
            if(val_6 >= 5)
            {
                    object[] val_3 = new object[6];
                val_3[0] = "Out of Order CloudScript Response Processing detected, expected response number ";
                val_3[1] = val_7;
                val_3[2] = ", received: ";
                val_3[3] = val_1.HasValue;
                val_7 = " for eventKey: ";
                val_3[4] = val_7;
                val_3[5] = this._eventKey;
                ConsoleLogger.LogError(className:  "EventRequestExecutor", functionName:  "CheckCloudScriptExecutionOrder", logString:  +val_3);
                val_10 = null;
                val_10 = null;
                Game.Server.ServerDomain.OutOfOrderCounter = 0;
            }
            
            label_9:
            val_10 = null;
            val_8 = val_1.HasValue.region;
            if(Game.Server.ServerDomain.ExecuteCloudScriptLastProcessed >= val_8)
            {
                    return;
            }
            
            if(((-937375960) & 1) == 0)
            {
                    return;
            }
            
            val_11 = null;
            val_8;
            val_11 = null;
            Game.Server.ServerDomain.ExecuteCloudScriptLastProcessed = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessGsResponse(GameSparks.Api.Responses.LogEventResponse gsResponse)
        {
            this.ProcessResponse(gsResponse:  gsResponse, pfResponse:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessResponse(GameSparks.Api.Responses.LogEventResponse gsResponse, Systems.Server.PlayFabProxy.PFResponse pfResponse)
        {
            Systems.Server.ServerResponse val_1 = new Systems.Server.ServerResponse(gsResponse:  gsResponse, pfResponse:  pfResponse);
            if(val_1.HasErrors != false)
            {
                    this.HandleErrors(serverData:  val_1.Errors);
                return;
            }
            
            if(this._successCallback != null)
            {
                    this._successCallback.Invoke(obj:  val_1);
            }
            
            if(val_1.ScriptData == null)
            {
                    return;
            }
            
            this = this._processDataCallback;
            if(this == null)
            {
                    return;
            }
            
            this.Invoke(obj:  val_1.ScriptData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessPfErrors(PlayFab.PlayFabError pfErrors)
        {
            PlayFab.Json.JsonObject val_1 = new PlayFab.Json.JsonObject();
            val_1.Add(key:  "error", value:  pfErrors.ErrorMessage);
            this.HandleErrors(serverData:  new Systems.Server.ServerData(gsData:  0, pfData:  new Systems.Server.PlayFabProxy.PFData(data:  val_1)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleErrors(Systems.Server.ServerData serverData)
        {
            if((System.String.op_Equality(a:  serverData.GetString(key:  "error"), b:  "timeout")) != false)
            {
                    this.HandleTimeout();
                return;
            }
            
            string val_3 = this._errorLogger.HandleServerError(data:  serverData);
            if(this._errorCallback == null)
            {
                    return;
            }
            
            this._errorCallback.Invoke(obj:  serverData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleTimeout()
        {
            int val_1 = this.retries;
            if(val_1 > 2)
            {
                    ConsoleLogger.LogError(className:  "EventRequestExecutor", functionName:  "ProcessResponse", logString:  "HIT MAXIMUM Retries!");
                if(this._errorCallback == null)
            {
                    return;
            }
            
                this._errorCallback.Invoke(obj:  0);
                return;
            }
            
            val_1 = val_1 + 1;
            this.retries = val_1;
            this.Send();
        }
    
    }

}
