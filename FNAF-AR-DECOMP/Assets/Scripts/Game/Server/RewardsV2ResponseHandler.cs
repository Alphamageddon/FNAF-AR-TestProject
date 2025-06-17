using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardsV2ResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<Systems.Server.ServerData, Game.TheGame.Data.RewardDataV2> ProcessRewards;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.RewardDataV2> RewardsV2Received;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.TheGame.Data.RewardDataV2> callback, System.Func<Systems.Server.ServerData, Game.TheGame.Data.RewardDataV2> processor)
        {
            this.ProcessRewards = processor;
            this.RewardsV2Received = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "RewardsV2");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            this.RewardsV2Received.Invoke(obj:  this.ProcessRewards.Invoke(arg:  data));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardsV2ResponseHandler()
        {
        
        }
    
    }

}
