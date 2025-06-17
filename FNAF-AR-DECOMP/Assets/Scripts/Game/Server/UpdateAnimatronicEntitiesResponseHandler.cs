using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UpdateAnimatronicEntitiesResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.SaveGameChunk> AnimatronicEntityUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk> loader;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk> loadFunc, System.Action<AnimatronicEntity.SaveGameChunk> callback)
        {
            this.AnimatronicEntityUpdated = callback;
            this.loader = loadFunc;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            System.Collections.Generic.List<Systems.Server.ServerData> val_1 = data.GetServerDataList(key:  "UpdateAnimatronicEntities");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleProcess(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleProcess(System.Collections.Generic.List<Systems.Server.ServerData> data)
        {
            goto label_1;
            label_6:
            this.AnimatronicEntityUpdated.Invoke(obj:  this.loader.Invoke(arg:  data.Item[0]));
            0 = 1;
            label_1:
            if(0 < data.Count)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateAnimatronicEntitiesResponseHandler()
        {
        
        }
    
    }

}
