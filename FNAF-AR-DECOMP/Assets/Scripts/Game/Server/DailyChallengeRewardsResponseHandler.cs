using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengeRewardsResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string REWARD_KEY = "DailyChallengeRewardsLogical";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> RewardReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<string> callback)
        {
            this.RewardReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            string val_1 = data.GetString(key:  "DailyChallengeRewardsLogical");
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                    return;
            }
            
            if(this.RewardReceived == null)
            {
                    return;
            }
            
            this.RewardReceived.Invoke(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeRewardsResponseHandler()
        {
        
        }
    
    }

}
