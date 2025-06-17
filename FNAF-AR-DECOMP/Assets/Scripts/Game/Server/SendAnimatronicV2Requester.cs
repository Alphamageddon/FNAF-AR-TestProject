using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SendAnimatronicV2Requester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendAnimatronic(Game.Server.SendAnimatronicV2Params parameters, Game.Server.SendAnimatronicV2Callbacks callbacks)
        {
            var val_8;
            SendAnimatronicV2Requester.<>c__DisplayClass0_0 val_1 = new SendAnimatronicV2Requester.<>c__DisplayClass0_0();
            if(val_1 != null)
            {
                    val_8 = val_1;
                .parameters = parameters;
            }
            else
            {
                    val_8 = 16;
                mem[16] = parameters;
            }
            
            .callbacks = callbacks;
            GameSparks.Api.Requests.LogEventRequest val_2 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_3 = val_2.SetEventKey(eventKey:  "SEND_ANIMATRONIC_ATTACK_V2");
            GameSparks.Api.Requests.LogEventRequest val_4 = val_2.SetEventAttribute(key:  "userId", value:  parameters + 24);
            GameSparks.Api.Requests.LogEventRequest val_5 = val_2.SetEventAttribute(key:  "slotId", value:  parameters + 16);
            this.Send(request:  val_2, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  val_1, method:  System.Void SendAnimatronicV2Requester.<>c__DisplayClass0_0::<SendAnimatronic>g__OnAnimatronicSent|0(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  val_1, method:  System.Void SendAnimatronicV2Requester.<>c__DisplayClass0_0::<SendAnimatronic>g__OnError|1(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SendAnimatronicV2Requester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525163032112] = eventHandler;
        }
    
    }

}
