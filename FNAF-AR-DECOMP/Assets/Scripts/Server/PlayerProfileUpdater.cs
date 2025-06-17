using UnityEngine;

namespace Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerProfileUpdater
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string className;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Server.PlayerProfile> PlayerProfileUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.UserNameSetError> DisplayNameObscenityFound;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer)
        {
            this.PlayerProfileUpdated = new System.Action<Server.PlayerProfile>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnPlayerProfileUpdated(Server.PlayerProfile data));
            this.DisplayNameObscenityFound = new System.Action<GameUI.UserNameSetError>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnDisplayNameObscenityFound(GameUI.UserNameSetError error));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateProfile(Systems.Server.ServerData data)
        {
            if(this.PlayerProfileUpdated == null)
            {
                    return;
            }
            
            this.PlayerProfileUpdated.Invoke(obj:  this.BuildPlayerProfileFromServerData(data:  data));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisplayNameObscenityFound(GameUI.UserNameSetError error)
        {
            if(this.DisplayNameObscenityFound == null)
            {
                    return;
            }
            
            this.DisplayNameObscenityFound.Invoke(obj:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.PlayerProfile BuildPlayerProfileFromServerData(Systems.Server.ServerData data)
        {
            .userName = data.GetString(key:  "userName");
            if(data != null)
            {
                    .displayName = data.GetString(key:  "displayName");
            }
            else
            {
                    .displayName = 0.GetString(key:  "displayName");
            }
            
            .userId = data.GetString(key:  "userId");
            .avatarId = data.GetString(key:  "avatarId");
            return (Server.PlayerProfile)new Server.PlayerProfile();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerProfileUpdater()
        {
            this.className = "PlayerProfileUpdater";
        }
    
    }

}
