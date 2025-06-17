using UnityEngine;

namespace Game.Server.Inbox
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RemoveInboxMessageRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveInboxMessages(System.Collections.Generic.List<string> ids)
        {
            var val_5 = this;
            List.Enumerator<T> val_1 = ids.GetEnumerator();
            label_3:
            if(((-878294952) & 1) == 0)
            {
                goto label_2;
            }
            
            this.RemoveInboxMessage(id:  0.emailUIDataHandler);
            goto label_3;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525203388504});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveInboxMessage(string id)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "REMOVE_INBOX_MESSAGE");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "REMOVE_INBOX_MESSAGE");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "id", value:  id);
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RemoveInboxMessageRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525203698432] = eventHandler;
        }
    
    }

}
