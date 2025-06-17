using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicEntityUpdateResponseHandler : EventResponseHandler
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
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "AnimatronicEntityUpdate");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleProcess(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleProcess(Systems.Server.ServerData data)
        {
            this.AnimatronicEntityUpdated.Invoke(obj:  this.loader.Invoke(arg:  data));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntityUpdateResponseHandler()
        {
        
        }
    
    }

}
