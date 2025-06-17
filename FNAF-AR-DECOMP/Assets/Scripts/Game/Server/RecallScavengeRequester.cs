using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RecallScavengeRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.GSRequestGenerator generator;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RecallScavengeRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525161171648] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(AnimatronicEntity.GSRequestGenerator theGenerator)
        {
            this.generator = theGenerator;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Recall(AnimatronicEntity.AnimatronicEntity entity)
        {
            var val_8;
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "SCAVENGE_RECALL");
            AnimatronicEntity.SaveGameChunk val_3 = null;
            val_8 = 0;
            val_3 = new AnimatronicEntity.SaveGameChunk(animatronicEntity:  entity);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_8 = 0;
            GameSparks.Api.Requests.LogEventRequest val_6 = val_1.SetEventAttribute(key:  "animatronicEntity", value:  this.generator.GenerateStringFromChunk(chunk:  val_3));
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
    
    }

}
