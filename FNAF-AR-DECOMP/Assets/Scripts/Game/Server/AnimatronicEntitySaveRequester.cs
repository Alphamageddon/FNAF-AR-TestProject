using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicEntitySaveRequester : AbstractRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SAVE_ENTITIES = "SAVE_ENTITIES_V3";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ENTITY_DATA = "entityData";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.GSRequestGenerator generator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.EntitySaveChunkGetter creator;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(AnimatronicEntity.EntitySaveChunkGetter theCreator, AnimatronicEntity.GSRequestGenerator theGenerator)
        {
            this.generator = theGenerator;
            this.creator = theCreator;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Save()
        {
            this.SendSaveEntityRequest(entityData:  this.GenerateEntityData());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendSaveEntityRequest(GameSparks.Core.GSRequestData entityData)
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "SAVE_ENTITIES_V3");
            }
            else
            {
                    GameSparks.Api.Requests.LogEventRequest val_3 = val_1.SetEventKey(eventKey:  "SAVE_ENTITIES_V3");
            }
            
            GameSparks.Api.Requests.LogEventRequest val_4 = val_1.SetEventAttribute(key:  "entityData", value:  entityData);
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullResponse(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateEntityData()
        {
            var val_9;
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            var val_10 = 0;
            val_10 = val_10 + 1;
            System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> val_3 = this.creator.GetSaveGameChunks();
            int val_4 = val_3.Count;
            if(val_4 < 1)
            {
                    return val_1;
            }
            
            var val_12 = 0;
            do
            {
                val_9 = public AnimatronicEntity.SaveGameChunk System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>::get_Item(int index);
                AnimatronicEntity.SaveGameChunk val_5 = val_3.Item[0];
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_9 = 0;
                GameSparks.Core.GSRequestData val_9 = val_1.AddObject(paramName:  val_5.entityId, child:  this.generator.GenerateStringFromChunk(chunk:  val_5));
                val_12 = val_12 + 1;
            }
            while(val_12 != val_4);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntitySaveRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525152938528] = eventHandler;
        }
    
    }

}
