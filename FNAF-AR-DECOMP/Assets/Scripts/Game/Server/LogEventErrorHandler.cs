using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LogEventErrorHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Master.EventExposer _eventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LogEventErrorHandler(Master.MasterDomain masterDomain, Master.EventExposer eventExposer)
        {
            val_1 = new System.Object();
            this._masterDomain = masterDomain;
            this._eventExposer = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CheckErrorAndHandleDisaster(GameSparks.Api.Requests.LogEventRequest request, Systems.Server.ServerData serverData)
        {
            if(this.HasConfigData() == false)
            {
                    return;
            }
            
            this.HandleShowBlockingError(request:  request, serverData:  serverData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool HasConfigData()
        {
            if(this._masterDomain == null)
            {
                    return false;
            }
            
            Game.MasterData.GetAccessToData val_1 = this._masterDomain.MasterDataDomain.GetAccessToData;
            if(val_1 != null)
            {
                    return val_1.IsInitialized();
            }
            
            return val_1.IsInitialized();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleShowBlockingError(GameSparks.Api.Requests.LogEventRequest request, Systems.Server.ServerData serverData)
        {
            LogEventErrorHandler.<>c__DisplayClass5_0 val_1 = new LogEventErrorHandler.<>c__DisplayClass5_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .request = request;
            }
            else
            {
                    mem[16] = this;
                mem[24] = request;
            }
            
            .serverData = serverData;
            if(this._masterDomain == null)
            {
                    return;
            }
            
            this._masterDomain.MasterDataDomain.GetAccessToData.GetServerBlockingErrorDataAsync(returnServerBlockingErrorDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.SERVERBLOCKINGERROR_DATA>(object:  val_1, method:  System.Void LogEventErrorHandler.<>c__DisplayClass5_0::<HandleShowBlockingError>b__0(ProtoData.SERVERBLOCKINGERROR_DATA serverBlockingErrorData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string ExtractErrorNameFromServerData(Systems.Server.ServerData serverData)
        {
            var val_6;
            var val_8;
            val_6 = 0;
            if((serverData.ContainsKey(key:  "Error")) != false)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_6 = 0;
                TValue val_4 = serverData.BaseData.Item[???];
            }
            
            if((serverData.ContainsKey(key:  "errCode")) != false)
            {
                    if((serverData.GetString(key:  "errCode")) != null)
            {
                    return (string)val_8;
            }
            
            }
            
            val_8 = 0;
            return (string)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.BlockingState GetErrorBlockingState(ProtoData.SERVERBLOCKINGERROR_DATA serverBlockingErrorData, GameSparks.Api.Requests.LogEventRequest request, Systems.Server.ServerData serverData)
        {
            ProtoData.SERVERBLOCKINGERROR_DATA val_33;
            var val_34;
            var val_35;
            var val_38;
            var val_39;
            var val_43;
            var val_45;
            val_33 = serverBlockingErrorData;
            val_34 = 1152921525146867376;
            System.Collections.Generic.IEnumerator<T> val_3 = val_33.Entries.GetEnumerator();
            val_35 = 0;
            goto label_10;
            label_16:
            var val_38 = 0;
            val_38 = val_38 + 1;
            T val_5 = val_3.Current;
            if(val_5.BlockAllow == 2)
            {
                    val_34 = val_34;
            }
            
            label_10:
            var val_39 = 0;
            val_39 = val_39 + 1;
            if(val_3.MoveNext() == true)
            {
                goto label_16;
            }
            
            val_38 = 0;
            val_39 = 87;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_40 = 0;
                val_40 = val_40 + 1;
                val_3.Dispose();
            }
            
            if( != 87)
            {
                goto label_29;
            }
            
            if(val_33 != null)
            {
                goto label_33;
            }
            
            goto label_31;
            label_29:
            if( != false)
            {
                    val_38 = 0;
            }
            
            if(val_33 != null)
            {
                goto label_33;
            }
            
            label_31:
            label_33:
            System.Collections.Generic.IEnumerator<T> val_15 = val_33.Entries.GetEnumerator();
            goto label_42;
            label_48:
            var val_41 = 0;
            val_41 = val_41 + 1;
            T val_17 = val_15.Current;
            if(val_17.BlockAllow == 0)
            {
                    val_33 = val_33;
            }
            
            label_42:
            var val_42 = 0;
            val_42 = val_42 + 1;
            if(val_15.MoveNext() == true)
            {
                goto label_48;
            }
            
            val_43 = val_38;
            if(val_15 != null)
            {
                    var val_43 = 0;
                val_43 = val_43 + 1;
                val_15.Dispose();
            }
            
            if(((167 == 0) ? 167 : 167) != 167)
            {
                goto label_60;
            }
            
            if( != 0)
            {
                goto label_64;
            }
            
            goto label_62;
            label_60:
            if( != false)
            {
                    val_43 = 0;
            }
            
            if( != 0)
            {
                goto label_64;
            }
            
            label_62:
            label_64:
            System.Collections.Generic.IEnumerator<T> val_28 = Entries.GetEnumerator();
            val_45 = val_43;
            goto label_73;
            label_79:
            var val_44 = 0;
            val_44 = val_44 + 1;
            if(val_28.BlockAllow == 1)
            {
                    val_43 = Game.Server.LogEventErrorHandler.EventValuePasses(entry:  val_28, request:  request);
            }
            
            label_73:
            var val_45 = 0;
            val_45 = val_45 + 1;
            if(val_28.MoveNext() == true)
            {
                goto label_79;
            }
            
            if(val_28 == null)
            {
                
            }
            else
            {
                    var val_46 = 0;
                val_46 = val_46 + 1;
                val_28.Dispose();
            }
            
            if( == false)
            {
                    return (Game.Server.BlockingState)((val_43 & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_28, errorName:  1152921504689487872))) != true) ? 0 : (((((Game.Server.LogEventErrorHandler.EventValuePasses(entry:  val_17, request:  87)) & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_17, errorName:  request))) & true) != 0) ? ((((Game.Server.LogEventErrorHandler.EventValuePasses(entry:  val_5, request:  request)) & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_5, errorName:  this.ExtractErrorNameFromServerData(serverData:  serverData)))) != true) ? 2 : (val_35)) : (0 + 1));
            }
            
            if(248 == 0)
            {
                    return (Game.Server.BlockingState)((val_43 & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_28, errorName:  1152921504689487872))) != true) ? 0 : (((((Game.Server.LogEventErrorHandler.EventValuePasses(entry:  val_17, request:  87)) & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_17, errorName:  request))) & true) != 0) ? ((((Game.Server.LogEventErrorHandler.EventValuePasses(entry:  val_5, request:  request)) & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_5, errorName:  this.ExtractErrorNameFromServerData(serverData:  serverData)))) != true) ? 2 : (val_35)) : (0 + 1));
            }
            
            if(248 == 248)
            {
                    return (Game.Server.BlockingState)((val_43 & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_28, errorName:  1152921504689487872))) != true) ? 0 : (((((Game.Server.LogEventErrorHandler.EventValuePasses(entry:  val_17, request:  87)) & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_17, errorName:  request))) & true) != 0) ? ((((Game.Server.LogEventErrorHandler.EventValuePasses(entry:  val_5, request:  request)) & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_5, errorName:  this.ExtractErrorNameFromServerData(serverData:  serverData)))) != true) ? 2 : (val_35)) : (0 + 1));
            }
            
            return (Game.Server.BlockingState)((val_43 & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_28, errorName:  1152921504689487872))) != true) ? 0 : (((((Game.Server.LogEventErrorHandler.EventValuePasses(entry:  val_17, request:  87)) & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_17, errorName:  request))) & true) != 0) ? ((((Game.Server.LogEventErrorHandler.EventValuePasses(entry:  val_5, request:  request)) & (Game.Server.LogEventErrorHandler.ErrorReturnValuePasses(entry:  val_5, errorName:  this.ExtractErrorNameFromServerData(serverData:  serverData)))) != true) ? 2 : (val_35)) : (0 + 1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool EventValuePasses(ProtoData.SERVERBLOCKINGERROR_DATA.Types.ENTRY entry, GameSparks.Api.Requests.LogEventRequest request)
        {
            string val_9;
            string val_10;
            string val_12;
            val_9 = entry;
            if((System.String.IsNullOrEmpty(value:  val_9.Event)) != false)
            {
                    val_10 = 1;
                return (bool)System.String.op_Equality(a:  val_10 = val_9, b:  val_12 = 0);
            }
            
            val_9 = val_9.Event;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = request.JSONData.Item[???];
            if((val_12 != 0) && (val_12 != null))
            {
                
            }
            
            return (bool)System.String.op_Equality(a:  val_10, b:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool ErrorReturnValuePasses(ProtoData.SERVERBLOCKINGERROR_DATA.Types.ENTRY entry, string errorName)
        {
            var val_4;
            if((System.String.IsNullOrEmpty(value:  entry.ErrorReturned)) != false)
            {
                    val_4 = 1;
                return (bool)val_4;
            }
            
            if(errorName != null)
            {
                    return System.String.op_Equality(a:  entry.ErrorReturned, b:  errorName);
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
    
    }

}
