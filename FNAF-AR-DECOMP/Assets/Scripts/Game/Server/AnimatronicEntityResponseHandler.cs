using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicEntityResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk> loader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>> PlayerAnimatronicDataLoaded;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk> entityLoader, System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>> callback)
        {
            this.loader = entityLoader;
            this.PlayerAnimatronicDataLoaded = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "AnimatronicEntities");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            this.PlayerAnimatronicDataLoaded.Invoke(obj:  this.ConstructAnimatronicEntities(data:  data));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> ConstructAnimatronicEntities(Systems.Server.ServerData data)
        {
            var val_14;
            var val_15;
            System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> val_1 = new System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>();
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = data.BaseData.Keys.GetEnumerator();
            label_26:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_1.Add(item:  this.loader.Invoke(arg:  data.GetServerData(key:  val_6.Current)));
            goto label_26;
            label_17:
            val_14 = 0;
            val_15 = 82;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_6.Dispose();
            }
            
            if( == 82)
            {
                    return val_1;
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntityResponseHandler()
        {
        
        }
    
    }

}
