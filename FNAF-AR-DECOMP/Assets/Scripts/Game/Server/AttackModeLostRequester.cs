using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackModeLostRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action OnAttackModeLost;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackModeLostRequester(Game.Server.LogEventHandler eventHandler, System.Action callback)
        {
            val_1 = new System.Object();
            mem[1152921525153062816] = eventHandler;
            this.OnAttackModeLost = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AttackModeLost(string entityId)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "ATTACK_MODE_LOST_V2");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "ATTACK_MODE_LOST_V2");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "entityId", value:  entityId);
            entityId.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  this, method:  System.Void Game.Server.AttackModeLostRequester::OnEventResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEventResponse(Systems.Server.ServerResponse response)
        {
            this.OnAttackModeLost.Invoke();
        }
    
    }

}
