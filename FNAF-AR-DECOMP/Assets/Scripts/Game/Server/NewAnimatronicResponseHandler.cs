using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NewAnimatronicResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.SaveGameChunk> EntityChunkGenerated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk> GenerateChunk;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk> loader, System.Action<AnimatronicEntity.SaveGameChunk> callback)
        {
            this.EntityChunkGenerated = callback;
            this.GenerateChunk = loader;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "NewAnimatronicEntities");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            var val_18;
            var val_19;
            var val_22;
            var val_23;
            var val_20 = 0;
            val_20 = val_20 + 1;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_18 = 1152921504685174784;
            val_19 = data.BaseData.Keys.GetEnumerator();
            label_24:
            var val_22 = 0;
            val_22 = val_22 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            this.ProcessEntity(entity:  data.GetServerData(key:  val_19.Current));
            goto label_24;
            label_17:
            val_22 = 0;
            val_23 = 61;
            if(val_19 == null)
            {
                
            }
            else
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_19.Dispose();
            }
            
            if( == 61)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_22 = ???;
            val_19 = ???;
            val_18 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessEntity(Systems.Server.ServerData entity)
        {
            this.EntityChunkGenerated.Invoke(obj:  this.GenerateChunk.Invoke(arg:  entity));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NewAnimatronicResponseHandler()
        {
        
        }
    
    }

}
