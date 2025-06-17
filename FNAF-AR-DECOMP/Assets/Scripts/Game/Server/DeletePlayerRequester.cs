using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeletePlayerRequester : AbstractRequester
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeletePlayer()
        {
            GameSparks.Api.Requests.LogEventRequest val_1 = new GameSparks.Api.Requests.LogEventRequest();
            GameSparks.Api.Requests.LogEventRequest val_2 = val_1.SetEventKey(eventKey:  "DELETE_PLAYER");
            this.Send(request:  val_1, successCallback:  new System.Action<Systems.Server.ServerResponse>(object:  0, method:  static System.Void Game.Server.DeletePlayerRequester::OnPlayerDeletion(Systems.Server.ServerResponse response)), errorCallback:  new System.Action<Systems.Server.ServerData>(object:  0, method:  static System.Void Game.Server.AbstractRequester::NullErrorResponse(Systems.Server.ServerData serverData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeletePlayerRequester(Game.Server.LogEventHandler eventHandler)
        {
            val_1 = new System.Object();
            mem[1152921525159470576] = eventHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void OnPlayerDeletion(Systems.Server.ServerResponse response)
        {
            Systems.Server.ILoginHandler val_7;
            var val_8;
            if(response.HasErrors != false)
            {
                    ConsoleLogger.LogError(className:  "DeletePlayerRequester", functionName:  "OnPlayerDeletion", logString:  "Player Deletion Failed");
                return;
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  "HasAlreadyPromptedUsernameChange");
            UnityEngine.PlayerPrefs.DeleteKey(key:  "HasVideoPlayed");
            val_7 = 1152921505261690880;
            val_8 = null;
            val_8 = null;
            UnityEngine.PlayerPrefs.DeleteKey(key:  Game.Server.TutorialDataResponseHandler.IgnoreFTUEVO);
            UnityEngine.PlayerPrefs.DeleteKey(key:  "AdditionalResourcesWarningAccepted");
            UnityEngine.PlayerPrefs.DeleteKey(key:  "PrivacyPolicyTermsOfServiceAcceptedKey");
            UnityEngine.PlayerPrefs.DeleteKey(key:  "FNAFAR_DeviceId");
            UnityEngine.PlayerPrefs.DeleteKey(key:  "LocalizationPreviousSystemLanguage");
            UnityEngine.PlayerPrefs.DeleteKey(key:  "LocalizationCurrentLanguage");
            UnityEngine.PlayerPrefs.DeleteKey(key:  "PushNotificationPermissionAsked");
            if(Facebook.Unity.FB.IsLoggedIn != false)
            {
                    Server.LoginDomain val_5 = Master.MasterDomain.GetDomain().theGameDomain.loginDomain;
                val_7 = val_5.LoginController;
                var val_7 = 0;
                val_7 = val_7 + 1;
                val_7.LogoutOfFacebookConnect();
            }
            
            UnityEngine.Application.Quit();
        }
    
    }

}
