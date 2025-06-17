using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicDataForIDResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk> ChunkGenerator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string, string, AnimatronicEntity.SaveGameChunk> AnimatronicDataRecieved;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk> chunkGenerator, System.Action<string, string, AnimatronicEntity.SaveGameChunk> callback)
        {
            this.ChunkGenerator = chunkGenerator;
            this.AnimatronicDataRecieved = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            if((data.GetServerData(key:  "TransientAnimatronicEntity")) == null)
            {
                    return;
            }
            
            this.ProcessAnimatronicData(data:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessAnimatronicData(Systems.Server.ServerData data)
        {
            string val_7;
            string val_8;
            if(data != null)
            {
                    val_7 = data.GetString(key:  "CpuId");
                val_8 = data.GetString(key:  "PlushSuitId");
            }
            else
            {
                    val_7 = 0.GetString(key:  "CpuId");
                val_8 = 0.GetString(key:  "PlushSuitId");
            }
            
            if(this.AnimatronicDataRecieved == null)
            {
                    return;
            }
            
            this.AnimatronicDataRecieved.Invoke(arg1:  val_7, arg2:  val_8, arg3:  this.ChunkGenerator.Invoke(arg:  data.GetServerData(key:  "TransientAnimatronicEntity")));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicDataForIDResponseHandler()
        {
        
        }
    
    }

}
