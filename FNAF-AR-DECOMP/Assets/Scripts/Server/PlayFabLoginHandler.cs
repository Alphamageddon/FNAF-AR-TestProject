using UnityEngine;

namespace Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabLoginHandler : AbstractLoginHandler, ILoginHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PLAYER_PREF_DEVICEID_KEY = "FNAFAR_DeviceId";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler _syncPreviousPlayerHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string previousId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Awake()
        {
            mem[1152921523197259232] = 257;
            this.ConnectThroughServer();
            this._syncPreviousPlayerHandler = new Systems.Server.PlayFabProxy.PFSyncPreviousPlayerHandler();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown(System.Action onShutdownComplete)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendDeviceAuthenticationRequest()
        {
            string val_8;
            this.SendDeviceAuthenticationRequest();
            val_8 = UnityEngine.PlayerPrefs.GetString(key:  "FNAFAR_DeviceId", defaultValue:  System.String.alignConst);
            if((val_8.Equals(value:  System.String.alignConst)) != false)
            {
                    System.Guid val_3 = System.Guid.NewGuid();
                val_8;
                UnityEngine.PlayerPrefs.SetString(key:  "FNAFAR_DeviceId", value:  val_3._a);
                UnityEngine.PlayerPrefs.Save();
            }
            
            .CreateAccount = 0;
            .TitleId = PlayFab.PlayFabSettings.TitleId;
            .CustomId = val_8;
            PlayFab.PlayFabClientAPI.LoginWithCustomID(request:  new PlayFab.ClientModels.LoginWithCustomIDRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.LoginResult>(object:  this, method:  System.Void Server.PlayFabLoginHandler::OnPFDeviceAuthenticationResponse(PlayFab.ClientModels.LoginResult result)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Server.PlayFabLoginHandler::OnPFDeviceAuthenticationError(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPFDeviceAuthenticationResponse(PlayFab.ClientModels.LoginResult result)
        {
            null = null;
            Game.Server.ServerDomain.AuthContext = result;
            UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_2});
            .operatingSystem = val_2.ToString();
            .assetDataVersion = this.serverSpecifiedAssetDataVersion;
            Game.Localization.Language val_8 = Game.Localization.LocalizationDomain.Instance.CurrentLanguage;
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_8});
            .currentLanguage = val_8.ToString();
            .masterDataVersion = this.serverSpecifiedMasterDataVersion;
            .version = UnityEngine.Application.version;
            .scriptData = new PlayFabLoginHandler.DeviceAuthenticationRequestArguments.ScriptData();
            PlayFab.ClientModels.ExecuteCloudScriptRequest val_13 = new PlayFab.ClientModels.ExecuteCloudScriptRequest();
            if(val_13 != null)
            {
                    mem[1152921523197784960] = Game.Server.ServerDomain.AuthContext;
                .FunctionName = "DeviceAuthenticationRequest";
            }
            else
            {
                    mem[16] = Game.Server.ServerDomain.AuthContext;
                mem[24] = "DeviceAuthenticationRequest";
            }
            
            .FunctionParameter = new PlayFabLoginHandler.DeviceAuthenticationRequestArguments();
            .GeneratePlayStreamEvent = 0;
            PlayFab.PlayFabClientAPI.ExecuteCloudScript(request:  val_13, resultCallback:  new System.Action<PlayFab.ClientModels.ExecuteCloudScriptResult>(object:  this, method:  System.Void Server.PlayFabLoginHandler::OnPFServerVersionResponse(PlayFab.ClientModels.ExecuteCloudScriptResult result)), errorCallback:  0, customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPFServerVersionResponse(PlayFab.ClientModels.ExecuteCloudScriptResult result)
        {
            System.Nullable<System.Boolean> val_2;
            PlayFab.ClientModels.ScriptExecutionError val_21;
            object val_22;
            string val_24;
            var val_27;
            var val_28;
            System.Collections.Generic.IDictionary<System.String, System.Object> val_31;
            var val_32;
            var val_33;
            val_21 = this;
            string val_19 = 0;
            val_22 = result.FunctionResult;
            if(val_22 != null)
            {
                    val_22 = 0;
                System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                var val_24 = 0;
                val_24 = val_24 + 1;
            }
            else
            {
                    string[] val_5 = new string[5];
                val_5[0] = result.Error.Error;
                val_5[1] = " | ";
                val_5[2] = result.Error.Message;
                val_5[3] = " | ";
                val_24 = result.Error.StackTrace;
                val_5[4] = val_24;
                ConsoleLogger.LogError(className:  "PlayFabLoginHandler", functionName:  "OnPFServerVersionResponse", logString:  +val_5);
                val_21 = result.Error;
                if((System.String.op_Equality(a:  result.Error.Error, b:  "AccountDeleted")) == false)
            {
                    return;
            }
            
                UnityEngine.PlayerPrefs.DeleteKey(key:  "FNAFAR_DeviceId");
                return;
            }
            
            System.Collections.Generic.IEnumerator<T> val_9 = val_22.Keys.GetEnumerator();
            label_49:
            var val_25 = 0;
            val_25 = val_25 + 1;
            if(val_9.MoveNext() == false)
            {
                goto label_40;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            T val_13 = val_9.Current;
            if((System.String.op_Equality(a:  val_13, b:  "eventKey")) == true)
            {
                goto label_49;
            }
            
            val_3.Add(key:  val_13, value:  val_22.Item[val_13]);
            goto label_49;
            label_40:
            val_27 = 0;
            val_28 = 216;
            if(val_9 == null)
            {
                
            }
            else
            {
                    var val_27 = 0;
                val_27 = val_27 + 1;
                val_9.Dispose();
            }
            
            if(val_3.Item["scriptData"] != null)
            {
                    val_31 = 0;
            }
            
            if((Facebook.Unity.Utilities.TryGetValue<System.String>(dictionary:  val_31, key:  "currentSessionToken", value: out  val_19)) != false)
            {
                    val_32 = null;
                val_32 = null;
                Game.Server.ServerDomain.CurrentSessionToken = val_19;
            }
            
            PlayFab.ClientModels.ExecuteCloudScriptRequest val_21 = null;
            val_24 = val_21;
            val_21 = new PlayFab.ClientModels.ExecuteCloudScriptRequest();
            val_33 = null;
            val_33 = null;
            if(val_24 != null)
            {
                    mem[1152921523198055520] = Game.Server.ServerDomain.AuthContext;
                .FunctionName = "AuthenticationResponse";
            }
            else
            {
                    mem[16] = Game.Server.ServerDomain.AuthContext;
                mem[24] = "AuthenticationResponse";
            }
            
            .FunctionParameter = val_3;
            val_2 = 0;
            .GeneratePlayStreamEvent = val_2;
            PlayFab.PlayFabClientAPI.ExecuteCloudScript(request:  val_21, resultCallback:  new System.Action<PlayFab.ClientModels.ExecuteCloudScriptResult>(object:  this, method:  System.Void Server.PlayFabLoginHandler::OnPFAuthenticationResponse(PlayFab.ClientModels.ExecuteCloudScriptResult result)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Server.PlayFabLoginHandler::OnPFAuthenticationResponseError(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPFDeviceAuthenticationError(PlayFab.PlayFabError error)
        {
            ConsoleLogger.LogError(className:  "PlayFabLoginHandler", functionName:  "OnPFDeviceAuthenticationError", logString:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPFAuthenticationResponse(PlayFab.ClientModels.ExecuteCloudScriptResult result)
        {
            var val_9;
            PlayFab.ClientModels.ScriptExecutionError val_10;
            object val_11;
            var val_12;
            if(result == null)
            {
                goto label_1;
            }
            
            val_10 = result.Error;
            if(val_10 != null)
            {
                goto label_2;
            }
            
            goto label_4;
            label_1:
            val_9 = 69077560;
            if(val_9 == 0)
            {
                goto label_4;
            }
            
            val_10 = 69077560;
            if(val_10 == 0)
            {
                goto label_24;
            }
            
            label_2:
            ConsoleLogger.LogError(className:  "PlayfabLoginHandler", functionName:  "OnPFAuthenticationResponse", logString:  val_10);
            return;
            label_4:
            val_11 = result.FunctionResult;
            if(val_11 != null)
            {
                    val_11 = 0;
            }
            
            new Systems.Server.PlayFabProxy.PFData() = new Systems.Server.PlayFabProxy.PFData(data:  val_11);
            val_12 = null;
            val_12 = null;
            var val_9 = 0;
            val_9 = val_9 + 1;
            (Systems.Server.PlayFabProxy.PFResponse)[1152921523198357808].ScriptData.BaseData.Add(key:  ???, value:  null);
            this.OnDeviceAuthenticationResponse(response:  new Systems.Server.ServerResponse(gsResponse:  0, pfResponse:  new Systems.Server.PlayFabProxy.PFResponse(requestId:  69730304, responseData:  new Systems.Server.PlayFabProxy.PFData())));
            this.playerTitleId = (Systems.Server.PlayFabProxy.PFResponse)[1152921523198357808].ScriptData.GetString(key:  "PlayerTitleId");
            this.SetLanguageOnServer();
            return;
            label_24:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPFAuthenticationResponseError(PlayFab.PlayFabError error)
        {
            ConsoleLogger.LogError(className:  "PlayFabLoginHandler", functionName:  "OnPFAuthenticationError", logString:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendServerFacebookRequestToQueryUser()
        {
            .AccessToken = Facebook.Unity.AccessToken.CurrentAccessToken.TokenString;
            .ForceLink = 0;
            ConsoleLogger.LogError(className:  "PlayFabLoginHandler", functionName:  "SendServerFacebookRequestToQueryUser", logString:  "QueryingAccount!");
            PlayFab.PlayFabClientAPI.LinkFacebookAccount(request:  new PlayFab.ClientModels.LinkFacebookAccountRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.LinkFacebookAccountResult>(object:  this, method:  System.Void Server.PlayFabLoginHandler::LinkNewAccount(PlayFab.ClientModels.LinkFacebookAccountResult res)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Server.PlayFabLoginHandler::AccountMayAlreadyExist(PlayFab.PlayFabError obj)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendServerFacebookRequestToLogin()
        {
            this.SendServerFacebookRequestToLogin();
            .AccessToken = Facebook.Unity.AccessToken.CurrentAccessToken.TokenString;
            .TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.PlayFabClientAPI.LoginWithFacebook(request:  new PlayFab.ClientModels.LoginWithFacebookRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.LoginResult>(object:  this, method:  System.Void Server.PlayFabLoginHandler::Query_Response(PlayFab.ClientModels.LoginResult res)), errorCallback:  0, customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AccountMayAlreadyExist(PlayFab.PlayFabError obj)
        {
            PlayFab.PlayFabErrorCode val_1 = obj.Error;
            val_1 = val_1 - 1011;
            if(val_1 > 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            0.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LinkNewAccount(PlayFab.ClientModels.LinkFacebookAccountResult res)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Query_Response(PlayFab.ClientModels.LoginResult res)
        {
            var val_7;
            var val_8;
            val_7 = null;
            val_7 = null;
            Game.Server.ServerDomain.AuthContext = null;
            Systems.Server.PlayFabProxy.PFResponse val_2 = new Systems.Server.PlayFabProxy.PFResponse(requestId:  69730304, responseData:  new Systems.Server.PlayFabProxy.PFData());
            Systems.Server.PlayFabProxy.PFData val_3 = new Systems.Server.PlayFabProxy.PFData();
            if(val_2 != null)
            {
                    val_8 = val_2;
                .ScriptData = val_3;
            }
            else
            {
                    val_8 = 16;
                mem[16] = val_3;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_3.BaseData.Add(key:  ???, value:  ???);
            this.OnFBConnectResponse(response:  new Systems.Server.ServerResponse(gsResponse:  0, pfResponse:  val_2));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SyncCurrentPlayer()
        {
            this.SyncCurrentPlayer();
            this = new PlayFab.ClientModels.LinkFacebookAccountRequest();
            mem[1152921523199319160] = Facebook.Unity.AccessToken.CurrentAccessToken.TokenString;
            mem[1152921523199319168] = 0;
            PlayFab.PlayFabClientAPI.LinkFacebookAccount(request:  this, resultCallback:  0, errorCallback:  0, customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SyncPreviousPlayer(System.Action callback)
        {
            this.SyncPreviousPlayer(callback:  callback);
            this._syncPreviousPlayerHandler.SyncPreviousPlayer(callback:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLanguageOnServer()
        {
            PlayFab.ProfilesModels.EntityKey val_1 = new PlayFab.ProfilesModels.EntityKey();
            string val_2 = this.playerTitleId;
            if(val_1 != null)
            {
                    .Id = val_2;
            }
            else
            {
                    mem[16] = val_2;
            }
            
            .Type = "title_player_account";
            .Entity = val_1;
            .Language = Game.Localization.LocalizationDomain.Instance.GetCurrentLanguageCode2();
            PlayFab.PlayFabProfilesAPI.SetProfileLanguage(request:  new PlayFab.ProfilesModels.SetProfileLanguageRequest(), resultCallback:  new System.Action<PlayFab.ProfilesModels.SetProfileLanguageResponse>(object:  this, method:  System.Void Server.PlayFabLoginHandler::SetLanguageOnServerSuccessCallback(PlayFab.ProfilesModels.SetProfileLanguageResponse response)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Server.PlayFabLoginHandler::SetLanguageOnServerErrorCallback(PlayFab.PlayFabError error)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetLanguageOnServerSuccessCallback(PlayFab.ProfilesModels.SetProfileLanguageResponse response)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetLanguageOnServerErrorCallback(PlayFab.PlayFabError error)
        {
            ConsoleLogger.LogError(className:  "Localization", functionName:  "SetLanguageErrorCallback", logString:  "Failed to set language");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabLoginHandler()
        {
        
        }
    
    }

}
