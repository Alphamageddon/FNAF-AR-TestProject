using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerProfileResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.PlayerProfileUpdater playerProfileUpdater;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Server.PlayerProfileUpdater updater)
        {
            this.playerProfileUpdater = updater;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerProfile");
            if(val_1 == null)
            {
                    return;
            }
            
            this.HandleResponse(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleResponse(Systems.Server.ServerData data)
        {
            this.playerProfileUpdater.UpdateProfile(data:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerProfileResponseHandler()
        {
        
        }
    
    }

}
