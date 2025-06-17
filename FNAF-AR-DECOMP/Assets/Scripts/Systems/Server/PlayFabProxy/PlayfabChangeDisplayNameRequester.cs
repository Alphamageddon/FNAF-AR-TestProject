using UnityEngine;

namespace Systems.Server.PlayFabProxy
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayfabChangeDisplayNameRequester : ChangeDisplayNameRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string className;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.UserNameSetError> ObscenityFoundCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Server.PlayerProfile> PlayerProfileUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Server.PlayerProfile> playerProfileCallback, System.Action<GameUI.UserNameSetError> obscenityFoundCallback)
        {
            this.ObscenityFoundCallback = obscenityFoundCallback;
            this.PlayerProfileUpdated = playerProfileCallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ChangeDisplayName(string displayName)
        {
            .DisplayName = displayName;
            PlayFab.PlayFabClientAPI.UpdateUserTitleDisplayName(request:  new PlayFab.ClientModels.UpdateUserTitleDisplayNameRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.UpdateUserTitleDisplayNameResult>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PlayfabChangeDisplayNameRequester::OnUserTitleDisplayNameUpdated(PlayFab.ClientModels.UpdateUserTitleDisplayNameResult result)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PlayfabChangeDisplayNameRequester::PlayfabErrorCallback(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnUserTitleDisplayNameUpdated(PlayFab.ClientModels.UpdateUserTitleDisplayNameResult result)
        {
            Server.LoginDomain val_3 = Master.MasterDomain.GetDomain().theGameDomain.loginDomain;
            val_3.playerProfile.displayName = result.DisplayName;
            if(this.PlayerProfileUpdated == null)
            {
                    return;
            }
            
            this.PlayerProfileUpdated.Invoke(obj:  val_3.playerProfile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlayfabErrorCallback(PlayFab.PlayFabError error)
        {
            System.Action<GameUI.UserNameSetError> val_1;
            var val_2;
            GameUI.UserNameSetError val_3;
            if(error.Error == 1234)
            {
                goto label_2;
            }
            
            if(error.Error != 1058)
            {
                goto label_3;
            }
            
            val_1 = this.ObscenityFoundCallback;
            val_2 = 1152921523196828368;
            val_3 = 5;
            goto label_5;
            label_2:
            val_1 = this.ObscenityFoundCallback;
            val_2 = 1152921523196828368;
            val_3 = 4;
            label_5:
            val_1.Invoke(obj:  val_3);
            return;
            label_3:
            ConsoleLogger.LogError(className:  this.className, functionName:  "PlayfabErrorCallback", logString:  error.ErrorMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayfabChangeDisplayNameRequester()
        {
            this.className = "PlayfabChangeDisplayNameRequester";
        }
    
    }

}
