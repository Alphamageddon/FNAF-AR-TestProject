using UnityEngine;

namespace Systems.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ChangeDisplayNameRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ChangeDisplayName(string displayName); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Setup(System.Action<Server.PlayerProfile> playerProfileCallback, System.Action<GameUI.UserNameSetError> obscenityFoundCallback); // 0
    
    }

}
