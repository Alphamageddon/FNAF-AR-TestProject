using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RepairAnimatronicRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action RepairFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RepairAnimatronicRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525169907376] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RepairAnimatronic(int slot, int cost)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "REPAIR_ANIMATRONIC");
                GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventAttribute(key:  "slotId", value:  slot);
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventKey(eventKey:  "REPAIR_ANIMATRONIC");
                GameSparks.Api.Requests.LogEventRequest val_5 = val_1.SetEventAttribute(key:  "slotId", value:  slot);
            }
            
            GameSparks.Api.Requests.LogEventRequest val_6 = val_1.SetEventAttribute(key:  "cost", value:  cost);
            cost.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  this, method:  public System.Void Game.Server.RepairAnimatronicRequester::OnRepairError(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRepairError(Systems.Server.ServerData serverData)
        {
            if(this.RepairFailure == null)
            {
                    return;
            }
            
            this.RepairFailure.Invoke();
        }
    
    }

}
