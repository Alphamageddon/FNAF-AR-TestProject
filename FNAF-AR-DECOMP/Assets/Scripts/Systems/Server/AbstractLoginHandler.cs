using UnityEngine;

namespace Systems.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AbstractLoginHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Server.AuthType <authType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Action Authenticated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Action<string> ForcedUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Action<Systems.Server.ServerData> UpdateStreakData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Action<Systems.Server.ServerData> PlayerProfileData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <serverSpecifiedMasterDataVersion>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <serverSpecifiedAssetDataVersion>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <userId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <playerTitleId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <PlayerToSwitchTo>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected string serverVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool _serverApiAvailable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool _isConnected;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool _setup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Action _determineSyncAccountCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Action _onSyncPreviousPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Systems.Server.ChangeDisplayNameRequester _changeDisplayNameRequester;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.AuthType authType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int serverSpecifiedMasterDataVersion { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int serverSpecifiedAssetDataVersion { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string userId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string playerTitleId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayerToSwitchTo { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.AuthType get_authType()
        {
            return (Systems.Server.AuthType)this.<authType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_authType(Systems.Server.AuthType value)
        {
            this.<authType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_serverSpecifiedMasterDataVersion()
        {
            return (int)this.<serverSpecifiedMasterDataVersion>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_serverSpecifiedMasterDataVersion(int value)
        {
            this.<serverSpecifiedMasterDataVersion>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_serverSpecifiedAssetDataVersion()
        {
            return (int)this.<serverSpecifiedAssetDataVersion>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_serverSpecifiedAssetDataVersion(int value)
        {
            this.<serverSpecifiedAssetDataVersion>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_userId()
        {
            return (string)this.<userId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_userId(string value)
        {
            this.<userId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_playerTitleId()
        {
            return (string)this.<playerTitleId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_playerTitleId(string value)
        {
            this.<playerTitleId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_PlayerToSwitchTo()
        {
            return (string)this.<PlayerToSwitchTo>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_PlayerToSwitchTo(string value)
        {
            this.<PlayerToSwitchTo>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action authFunction, System.Action<string> forcedUpdateFunction, System.Action<Systems.Server.ServerData> streakDataUpdater, System.Action<Systems.Server.ServerData> playerProfileUpdater, Systems.Server.ChangeDisplayNameRequester changeDisplayNameRequester)
        {
            this.Authenticated = authFunction;
            this.ForcedUpdate = forcedUpdateFunction;
            this.UpdateStreakData = streakDataUpdater;
            this.PlayerProfileData = playerProfileUpdater;
            this._setup = true;
            this._changeDisplayNameRequester = changeDisplayNameRequester;
            this.ConnectThroughServer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SwitchToOtherAccount()
        {
            if((this.<PlayerToSwitchTo>k__BackingField) != null)
            {
                    this = ???;
            }
            else
            {
                    ConsoleLogger.LogError(className:  "Login", functionName:  "KeepAccount", logString:  "No Account Conflict!");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoginToFacebookConnect()
        {
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    if(Facebook.Unity.FB.IsLoggedIn == false)
            {
                goto label_6;
            }
            
            }
            
            ConsoleLogger.LogError(className:  "Login", functionName:  "LoginToFacebookConnect", logString:  "Facebook not Initialized!");
            return;
            label_6:
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
            if(val_3 != null)
            {
                    val_3.Add(item:  "public_profile");
            }
            else
            {
                    val_3.Add(item:  "public_profile");
            }
            
            val_3.Add(item:  "email");
            val_3.Add(item:  "user_friends");
            Facebook.Unity.FB.LogInWithReadPermissions(permissions:  val_3, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult>(object:  this, method:  System.Void Systems.Server.AbstractLoginHandler::ServerLoginUser(Facebook.Unity.ILoginResult result)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FacebookTryToLink(System.Action determineSyncAccountCallback)
        {
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    if(Facebook.Unity.FB.IsLoggedIn == false)
            {
                goto label_6;
            }
            
            }
            
            ConsoleLogger.LogError(className:  "Login", functionName:  "FacebookTryToLink", logString:  "Facebook not Initialized or already logged in!");
            return;
            label_6:
            this._determineSyncAccountCallback = determineSyncAccountCallback;
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
            if(val_3 != null)
            {
                    val_3.Add(item:  "public_profile");
            }
            else
            {
                    val_3.Add(item:  "public_profile");
            }
            
            val_3.Add(item:  "email");
            val_3.Add(item:  "user_friends");
            Facebook.Unity.FB.LogInWithReadPermissions(permissions:  val_3, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult>(object:  this, method:  System.Void Systems.Server.AbstractLoginHandler::ServerQueryUser(Facebook.Unity.ILoginResult result)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LogoutOfFacebookConnect()
        {
            if((Facebook.Unity.FB.IsInitialized != false) && (Facebook.Unity.FB.IsLoggedIn != false))
            {
                    Facebook.Unity.FB.LogOut();
                this = ???;
            }
            else
            {
                    ConsoleLogger.LogError(className:  "Login", functionName:  "LogoutOfFacebookConnect", logString:  "Can\'t Log out of something I\'m not connected to");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetServerVersion()
        {
            return (string)this.serverVersion;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ServerQueryUser(Facebook.Unity.ILoginResult result)
        {
            string val_10;
            var val_11;
            var val_13;
            val_10 = result;
            val_11 = 1152921504982564864;
            var val_10 = 0;
            val_10 = val_10 + 1;
            if((System.String.IsNullOrEmpty(value:  val_10.Error)) == false)
            {
                goto label_6;
            }
            
            val_10 = ???;
            val_11 = ???;
            goto typeof(Systems.Server.AbstractLoginHandler).__il2cppRuntimeField_238;
            label_6:
            var val_13 = val_10;
            if((val_10 + 286) == 0)
            {
                goto label_11;
            }
            
            var val_11 = val_10 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_10:
            if(((val_10 + 176 + 8) + -8) == val_11)
            {
                goto label_9;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (val_10 + 286))
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            val_13 = val_13 + (((val_10 + 176 + 8)) << 4);
            val_13 = val_13 + 296;
            label_11:
            ConsoleLogger.LogError(className:  "AbstractLoginHandler", functionName:  "ServerQueryUser", logString:  "Error logging in to FB! FBLoginResponse Error: "("Error logging in to FB! FBLoginResponse Error: ") + val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ServerLoginUser(Facebook.Unity.ILoginResult result)
        {
            string val_10;
            var val_11;
            var val_13;
            val_10 = result;
            val_11 = 1152921504982564864;
            var val_10 = 0;
            val_10 = val_10 + 1;
            if((System.String.IsNullOrEmpty(value:  val_10.Error)) == false)
            {
                goto label_6;
            }
            
            val_10 = ???;
            val_11 = ???;
            goto typeof(Systems.Server.AbstractLoginHandler).__il2cppRuntimeField_228;
            label_6:
            var val_13 = val_10;
            if((val_10 + 286) == 0)
            {
                goto label_11;
            }
            
            var val_11 = val_10 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_10:
            if(((val_10 + 176 + 8) + -8) == val_11)
            {
                goto label_9;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (val_10 + 286))
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            val_13 = val_13 + (((val_10 + 176 + 8)) << 4);
            val_13 = val_13 + 296;
            label_11:
            ConsoleLogger.LogError(className:  "AbstractLoginHandler", functionName:  "ServerLoginUser", logString:  "Error logging in to FB! FBLoginResponse Error: "("Error logging in to FB! FBLoginResponse Error: ") + val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnFBInit()
        {
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    Facebook.Unity.FB.ActivateApp();
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ParseVersionMemento(Systems.Server.ServerData data)
        {
            int val_7;
            int val_8;
            val_7 = "MasterDataVersion";
            if(((data.ContainsKey(key:  "MasterDataVersion")) == false) || ((data.ContainsKey(key:  "AssetDataVersion")) == false))
            {
                goto label_4;
            }
            
            System.Nullable<System.Int32> val_3 = data.GetInt(key:  "MasterDataVersion");
            if((1556615144 & 1) == 0)
            {
                goto label_6;
            }
            
            val_7 = val_3.HasValue.region;
            if(this != null)
            {
                goto label_12;
            }
            
            goto label_8;
            label_4:
            ConsoleLogger.LogError(className:  "AbstractLoginHandler", functionName:  "ParseVersionMemento", logString:  "Server did not return MasterDataVersion or AssetDataVersion memento");
            return;
            label_6:
            val_7 = 0;
            if(this != null)
            {
                goto label_12;
            }
            
            label_8:
            label_12:
            this.<serverSpecifiedMasterDataVersion>k__BackingField = val_7;
            System.Nullable<System.Int32> val_5 = data.GetInt(key:  "AssetDataVersion");
            if((1556615144 & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_6 = val_5.HasValue.region;
            }
            else
            {
                    val_8 = 0;
            }
            
            this.<serverSpecifiedAssetDataVersion>k__BackingField = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void StoreAuthTypeAndUserId(Systems.Server.AuthType newAuthType, string responseUserId)
        {
            this.<authType>k__BackingField = newAuthType;
            this.<userId>k__BackingField = responseUserId;
            this.Authenticated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PromptForAccountSwitch(string playerId)
        {
            this.<PlayerToSwitchTo>k__BackingField = playerId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool ShouldForceUpdate(Systems.Server.ServerResponse response)
        {
            var val_5;
            Systems.Server.ServerData val_1 = response.ScriptData;
            if(val_1 != null)
            {
                    Systems.Server.ServerData val_2 = val_1.GetServerData(key:  "VersionMemento");
                if(val_2 != null)
            {
                    System.Nullable<System.Boolean> val_3 = val_2.GetBoolean(key:  "ForcedUpdateRequired");
            }
            
            }
            
            if((1557008716 & 1) != 0)
            {
                
            }
            else
            {
                    val_5 = 0;
            }
            
            val_5 = val_5 & 1;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected string GetForcedUpdateUrl(Systems.Server.ServerResponse response)
        {
            Systems.Server.ServerData val_2 = response.ScriptData.GetServerData(key:  "VersionMemento");
            if(val_2 == null)
            {
                    return (string)(val_3 == null) ? "http://www.illumix.com" : (val_3);
            }
            
            string val_3 = val_2.GetString(key:  "ForcedUpdateUrl");
            return (string)(val_3 == null) ? "http://www.illumix.com" : (val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void UpdateInfo(Systems.Server.AuthType newAuthType, Systems.Server.ServerResponse response)
        {
            Systems.Server.ServerData val_1 = response.ScriptData;
            if(newAuthType == 1)
            {
                    this.StoreAuthTypeAndUserId(newAuthType:  1, responseUserId:  val_1.GetString(key:  "UserId"));
                this.ParseVersionMemento(data:  response.BaseData);
                return;
            }
            
            this.ParseVersionMemento(data:  val_1.GetServerData(key:  "VersionMemento"));
            this.StoreAuthTypeAndUserId(newAuthType:  newAuthType, responseUserId:  response.ScriptData.GetServerData(key:  "PlayerProfile").GetString(key:  "userId"));
            this.UpdateStreakData.Invoke(obj:  response.ScriptData);
            this.PlayerProfileData.Invoke(obj:  response.ScriptData.GetServerData(key:  "PlayerProfile"));
            this.serverVersion = response.ScriptData.GetString(key:  "serverVersion");
            Systems.Server.InitialDisplayNameSaver.SaveNameForNewPlayer(response:  response, changeDisplayNameRequester:  this._changeDisplayNameRequester);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ConnectThroughServer()
        {
            if(this._setup == false)
            {
                    return;
            }
            
            if(this._serverApiAvailable == false)
            {
                    return;
            }
            
            if(this._isConnected == false)
            {
                    return;
            }
            
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    this = ???;
            }
            else
            {
                    Facebook.Unity.FB.Init(onInitComplete:  new Facebook.Unity.InitDelegate(object:  this, method:  System.Void Systems.Server.AbstractLoginHandler::OnFBInit()), onHideUnity:  0, authResponse:  0);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnDeviceAuthenticationResponse(Systems.Server.ServerResponse response)
        {
            bool val_1 = response.HasErrors;
            if(val_1 != false)
            {
                    ConsoleLogger.LogError(className:  "Login", functionName:  "OnDeviceAuthenticationResponse", logString:  response.Errors.JSON);
                return;
            }
            
            bool val_4 = val_1.ShouldForceUpdate(response:  response);
            if(val_4 != false)
            {
                    if(this.ForcedUpdate == null)
            {
                    return;
            }
            
                this.ForcedUpdate.Invoke(obj:  val_4.GetForcedUpdateUrl(response:  response));
                return;
            }
            
            this.UpdateInfo(newAuthType:  2, response:  response);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnFBConnectResponse(Systems.Server.ServerResponse response)
        {
            if(response.HasErrors != false)
            {
                    ConsoleLogger.LogError(className:  "Login", functionName:  "OnFBConnectResponse", logString:  response.Errors.JSON);
                return;
            }
            
            this.UpdateInfo(newAuthType:  1, response:  response);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ConnectToBackendServer()
        {
            goto typeof(Systems.Server.AbstractLoginHandler).__il2cppRuntimeField_248;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void SendServerFacebookRequestToLogin()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void SendServerFacebookRequestToQueryUser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void SendDeviceAuthenticationRequest()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void SyncPreviousPlayer(System.Action callback)
        {
            this._onSyncPreviousPlayer = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void SyncCurrentPlayer()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AbstractLoginHandler()
        {
            this.<serverSpecifiedMasterDataVersion>k__BackingField = 0;
            this.<serverSpecifiedAssetDataVersion>k__BackingField = 0;
        }
    
    }

}
