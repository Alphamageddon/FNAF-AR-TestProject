using UnityEngine;

namespace Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameSparksLoginHandler : AbstractLoginHandler, ILoginHandler
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Awake()
        {
            System.Action<System.Boolean> val_5;
            if(((System.Delegate.Combine(a:  GameSparks.Core.GS.GameSparksAvailable, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void Server.GameSparksLoginHandler::OnGameSparksAvailable(bool isConnected)))) != null) && (null != null))
            {
                    val_5 = 0;
            }
            
            GameSparks.Core.GS.GameSparksAvailable = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown(System.Action onShutdownComplete)
        {
            System.Action<System.Boolean> val_6;
            if(((System.Delegate.Remove(source:  GameSparks.Core.GS.GameSparksAvailable, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Server.GameSparksLoginHandler::OnGameSparksAvailable(bool isConnected)))) != null) && (null != null))
            {
                    val_6 = 0;
            }
            
            GameSparks.Core.GS.GameSparksAvailable = val_6;
            GameSparks.Core.GS.Instance.ShutDown(onDone:  onShutdownComplete);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGameSparksAvailable(bool isConnected)
        {
            mem[1152921523193420400] = 1;
            mem[1152921523193420401] = isConnected;
            this.ConnectThroughServer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendServerFacebookRequestToLogin()
        {
            this.SendFacebookConnectRequest(shouldNotSwitchAccounts:  false, callback:  new System.Action<GameSparks.Api.Responses.AuthenticationResponse>(object:  this, method:  System.Void Server.GameSparksLoginHandler::OnGSFBConnectResponse(GameSparks.Api.Responses.AuthenticationResponse gsResponse)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendServerFacebookRequestToQueryUser()
        {
            this.SendFacebookConnectRequest(shouldNotSwitchAccounts:  true, callback:  new System.Action<GameSparks.Api.Responses.AuthenticationResponse>(object:  this, method:  System.Void Server.GameSparksLoginHandler::DetermineIfAccountToSync(GameSparks.Api.Responses.AuthenticationResponse gsResponse)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendFacebookConnectRequest(bool shouldNotSwitchAccounts, System.Action<GameSparks.Api.Responses.AuthenticationResponse> callback)
        {
            GameSparks.Api.Requests.FacebookConnectRequest val_1 = new GameSparks.Api.Requests.FacebookConnectRequest();
            string val_3 = Facebook.Unity.AccessToken.CurrentAccessToken.TokenString;
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.FacebookConnectRequest val_4 = val_1.SetAccessToken(accessToken:  val_3);
                GameSparks.Api.Requests.FacebookConnectRequest val_6 = val_1.SetErrorOnSwitch(errorOnSwitch:  shouldNotSwitchAccounts);
            }
            else
            {
                    GameSparks.Api.Requests.FacebookConnectRequest val_7 = val_1.SetAccessToken(accessToken:  val_3);
                GameSparks.Api.Requests.FacebookConnectRequest val_9 = val_1.SetErrorOnSwitch(errorOnSwitch:  shouldNotSwitchAccounts);
            }
            
            GameSparks.Core.GSRequestData val_11 = val_1.SetDoNotLinkToCurrentPlayer(doNotLinkToCurrentPlayer:  false).GetBuildRequestData();
            if(val_1 != null)
            {
                    GameSparks.Api.Requests.FacebookConnectRequest val_12 = val_1.SetScriptData(data:  val_11);
            }
            else
            {
                    GameSparks.Api.Requests.FacebookConnectRequest val_13 = 0.SetScriptData(data:  val_11);
            }
            
            val_1.Send(callback:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DetermineIfAccountToSync(GameSparks.Api.Responses.AuthenticationResponse gsResponse)
        {
            bool val_6 = System.String.op_Inequality(a:  new Systems.Server.ServerResponse(gsResponse:  gsResponse, pfResponse:  0).BaseData.GetServerData(key:  "switchSummary").GetString(key:  "id"), b:  this.userId);
            if(val_6 == false)
            {
                    return;
            }
            
            if(val_6 == false)
            {
                    return;
            }
            
            val_6.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGSFBConnectResponse(GameSparks.Api.Responses.AuthenticationResponse gsResponse)
        {
            string val_15;
            bool val_10 = false;
            Systems.Server.ServerResponse val_1 = new Systems.Server.ServerResponse(gsResponse:  gsResponse, pfResponse:  0);
            val_15 = val_1.JSONData;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15.Add(key:  null, value:  (gsResponse.SwitchSummary != 0) ? 1 : 0);
            if(val_1.HasErrors != false)
            {
                    val_15 = val_1.Errors.JSON;
                ConsoleLogger.LogError(className:  "Login", functionName:  "OnFBConnectResponse", logString:  val_15);
                bool val_11 = Facebook.Unity.Utilities.TryGetValue<System.Boolean>(dictionary:  val_1.JSONData, key:  "SwitchSummary", value: out  val_10);
                if(val_10 == 0)
            {
                    return;
            }
            
                this.PlayerToSwitchTo = val_1.BaseData.GetServerData(key:  "switchSummary").GetString(key:  "id");
                this.SwitchToOtherAccount();
                return;
            }
            
            this.OnFBConnectResponse(response:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GetBuildRequestData()
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_3 = val_1.AddString(paramName:  "version", value:  UnityEngine.Application.version);
            Game.Localization.Language val_5 = Game.Localization.LocalizationDomain.Instance.CurrentLanguage;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_5});
            GameSparks.Core.GSRequestData val_8 = val_1.AddString(paramName:  "currentLanguage", value:  val_5.ToString());
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendDeviceAuthenticationRequest()
        {
            this.SendDeviceAuthenticationRequest();
            GameSparks.Api.Requests.DeviceAuthenticationRequest val_1 = new GameSparks.Api.Requests.DeviceAuthenticationRequest();
            GameSparks.Api.Requests.DeviceAuthenticationRequest val_3 = val_1.SetScriptData(data:  val_1.GetBuildRequestData());
            val_1.Send(callback:  new System.Action<GameSparks.Api.Responses.AuthenticationResponse>(object:  this, method:  System.Void Server.GameSparksLoginHandler::OnGSDeviceAuthenticationResponse(GameSparks.Api.Responses.AuthenticationResponse gsResponse)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGSDeviceAuthenticationResponse(GameSparks.Api.Responses.AuthenticationResponse gsResponse)
        {
            this.OnDeviceAuthenticationResponse(response:  new Systems.Server.ServerResponse(gsResponse:  gsResponse, pfResponse:  0));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SyncPreviousPlayer(System.Action callback)
        {
            this.SyncPreviousPlayer(callback:  callback);
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SyncCurrentPlayer()
        {
            this.SyncCurrentPlayer();
            ConsoleLogger.LogError(className:  "GameSparksLoginHandler", functionName:  "SyncCurrentPlayer", logString:  "not implemented!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameSparksLoginHandler()
        {
        
        }
    
    }

}
