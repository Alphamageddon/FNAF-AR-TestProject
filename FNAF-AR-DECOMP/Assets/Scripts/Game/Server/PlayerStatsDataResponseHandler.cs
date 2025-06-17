using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerStatsDataResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.PlayerStats.Data.PlayerStatsData> PlayerStatsDataUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<Systems.Server.ServerData, Game.PlayerStats.Data.PlayerStatsData> ProcessPlayerStats;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.PlayerStats.Data.PlayerStatsData> callback, System.Func<Systems.Server.ServerData, Game.PlayerStats.Data.PlayerStatsData> processor)
        {
            this.PlayerStatsDataUpdated = callback;
            this.ProcessPlayerStats = processor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerStatsData");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            if(this.PlayerStatsDataUpdated == null)
            {
                    return;
            }
            
            this.PlayerStatsDataUpdated.Invoke(obj:  this.ProcessPlayerStats.Invoke(arg:  data));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerStatsDataResponseHandler()
        {
        
        }
    
    }

}
