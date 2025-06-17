using UnityEngine;

namespace Game.Server.Inbox
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BatchInboxRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BatchUpdateInbox(System.Collections.Generic.List<string> readIds, System.Collections.Generic.List<string> deleteIds)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "BATCH_INBOX_UPDATE");
                GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventAttribute(key:  "messagesToMarkRead", value:  readIds);
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventKey(eventKey:  "BATCH_INBOX_UPDATE");
                GameSparks.Api.Requests.LogEventRequest val_5 = val_1.SetEventAttribute(key:  "messagesToMarkRead", value:  readIds);
            }
            
            GameSparks.Api.Requests.LogEventRequest val_6 = val_1.SetEventAttribute(key:  "messagesToDelete", value:  deleteIds);
            deleteIds.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BatchInboxRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525202315840] = eventHandler;
        }
    
    }

}
