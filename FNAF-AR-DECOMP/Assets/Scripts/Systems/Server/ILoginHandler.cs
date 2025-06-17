using UnityEngine;

namespace Systems.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ILoginHandler
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Systems.Server.AuthType authType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string userId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string playerTitleId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string PlayerToSwitchTo { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int serverSpecifiedMasterDataVersion { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int serverSpecifiedAssetDataVersion { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Systems.Server.AuthType get_authType(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_userId(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_playerTitleId(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_PlayerToSwitchTo(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_serverSpecifiedMasterDataVersion(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_serverSpecifiedAssetDataVersion(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetServerVersion(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Awake(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Setup(System.Action authFunction, System.Action<string> forcedUpdateFunction, System.Action<Systems.Server.ServerData> streakDataUpdater, System.Action<Systems.Server.ServerData> playerProfileUpdater, Systems.Server.ChangeDisplayNameRequester changeDisplayNameRequester); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Teardown(System.Action onShutdownComplete); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FacebookTryToLink(System.Action determineSyncAccountCallback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void LoginToFacebookConnect(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void LogoutOfFacebookConnect(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SwitchToOtherAccount(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SyncPreviousPlayer(System.Action callback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SyncCurrentPlayer(); // 0
    
    }

}
