using UnityEngine;

namespace Systems.Server.PlayFabProxy
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PFSyncPreviousPlayerHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string previousId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _successCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SyncPreviousPlayer(System.Action callback)
        {
            var val_4;
            this._successCallback = callback;
            val_4 = null;
            val_4 = null;
            .PlayFabId = Game.Server.ServerDomain.AuthContext.PlayFabId;
            PlayFab.PlayFabClientAPI.GetAccountInfo(request:  new PlayFab.ClientModels.GetAccountInfoRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.GetAccountInfoResult>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler::GetAccountInfo_ResultCallback(PlayFab.ClientModels.GetAccountInfoResult result)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler::HandleError(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleError(PlayFab.PlayFabError error)
        {
            ConsoleLogger.LogError(className:  "PlayFabLoginHandler", functionName:  "HandleError", logString:  error.GenerateErrorReport());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetAccountInfo_ResultCallback(PlayFab.ClientModels.GetAccountInfoResult result)
        {
            if(((result.AccountInfo != null) && (result.AccountInfo.CustomIdInfo != null)) && (result.AccountInfo.CustomIdInfo.CustomId != null))
            {
                    this.previousId = result.AccountInfo.CustomIdInfo.CustomId;
                this.UnlinkCustomId(customId:  result.AccountInfo.CustomIdInfo.CustomId);
                return;
            }
            
            ConsoleLogger.LogError(className:  "PlayFabLoginHandler", functionName:  "GetAccountInfo_ResultCallback", logString:  "CustomID not found!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UnlinkCustomId(string customId)
        {
            .CustomId = customId;
            PlayFab.PlayFabClientAPI.UnlinkCustomID(request:  new PlayFab.ClientModels.UnlinkCustomIDRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.UnlinkCustomIDResult>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler::UnlinkCustomId_ResultCallback(PlayFab.ClientModels.UnlinkCustomIDResult obj)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler::HandleError(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UnlinkCustomId_ResultCallback(PlayFab.ClientModels.UnlinkCustomIDResult obj)
        {
            this.LoginWithFacebook();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoginWithFacebook()
        {
            .AccessToken = Facebook.Unity.AccessToken.CurrentAccessToken.TokenString;
            .TitleId = PlayFab.PlayFabSettings.TitleId;
            .CreateAccount = 0;
            PlayFab.PlayFabClientAPI.LoginWithFacebook(request:  new PlayFab.ClientModels.LoginWithFacebookRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.LoginResult>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler::LoginWithFacebook_ResultCallback(PlayFab.ClientModels.LoginResult obj)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler::HandleError(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoginWithFacebook_ResultCallback(PlayFab.ClientModels.LoginResult obj)
        {
            this.LinkCustomId();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LinkCustomId()
        {
            .CustomId = this.previousId;
            .ForceLink = 0;
            PlayFab.PlayFabClientAPI.LinkCustomID(request:  new PlayFab.ClientModels.LinkCustomIDRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.LinkCustomIDResult>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler::LinkCustomId_ResultCallback(PlayFab.ClientModels.LinkCustomIDResult obj)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler::HandleError(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LinkCustomId_ResultCallback(PlayFab.ClientModels.LinkCustomIDResult obj)
        {
            if(this._successCallback == null)
            {
                    return;
            }
            
            this._successCallback.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PFSyncPreviousPlayerHandler()
        {
        
        }
    
    }

}
