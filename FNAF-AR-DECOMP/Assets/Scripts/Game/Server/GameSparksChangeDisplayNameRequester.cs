using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameSparksChangeDisplayNameRequester : ChangeDisplayNameRequester
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string className;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<Systems.Server.ServerData> Updater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<GameUI.UserNameSetError> ObscenityFoundCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string[] UserNameSetErrorServerMessage;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameSparksChangeDisplayNameRequester(System.Action<Systems.Server.ServerData> callback, System.Action<GameUI.UserNameSetError> obscenityFoundCallback)
        {
            this.className = "GameSparksChangeDisplayNameRequester";
            string[] val_1 = new string[6];
            val_1[0] = "New name is too short";
            val_1[1] = "New name is too long";
            val_1[2] = "New name must start with a capital letter";
            val_1[3] = "New name contained and invalid character";
            val_1[4] = "New name is obscene";
            val_1[5] = "New name is not unique";
            this.UserNameSetErrorServerMessage = val_1;
            this.Updater = callback;
            this.ObscenityFoundCallback = obscenityFoundCallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ChangeDisplayName(string displayName)
        {
            GameSparks.Api.Requests.ChangeUserDetailsRequest val_1 = new GameSparks.Api.Requests.ChangeUserDetailsRequest();
            GameSparks.Api.Requests.ChangeUserDetailsRequest val_2 = val_1.SetDisplayName(displayName:  displayName);
            val_1.Send(callback:  new System.Action<GameSparks.Api.Responses.ChangeUserDetailsResponse>(object:  this, method:  System.Void Game.Server.GameSparksChangeDisplayNameRequester::OnChangeDisplayName(GameSparks.Api.Responses.ChangeUserDetailsResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Server.PlayerProfile> playerProfileCallback, System.Action<GameUI.UserNameSetError> obscenityFoundCallback)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnChangeDisplayName(GameSparks.Api.Responses.ChangeUserDetailsResponse response)
        {
            string val_21;
            var val_22;
            string val_23;
            string val_24;
            string val_25;
            var val_26;
            var val_27;
            val_21 = this;
            if(response == null)
            {
                goto label_1;
            }
            
            val_22 = response;
            if(response.HasErrors == false)
            {
                goto label_2;
            }
            
            label_8:
            string val_3 = val_22.Errors.GetString(name:  "message");
            if((System.String.IsNullOrEmpty(value:  val_3)) == false)
            {
                goto label_4;
            }
            
            val_23 = "GameSparksChangeDisplayNameRequester";
            val_24 = "OnChangeDisplayName";
            val_25 = "No message field supplied with error";
            goto label_7;
            label_1:
            val_22 = 0;
            if(0.HasErrors == true)
            {
                goto label_8;
            }
            
            label_2:
            Server.LoginDomain val_11 = Master.MasterDomain.GetDomain().theGameDomain.loginDomain;
            val_11.playerProfile.displayName = new Systems.Server.ServerData(gsData:  val_22.ScriptData, pfData:  0).GetServerData(key:  "PlayerProfile").GetString(key:  "displayName");
            if(this.Updater == null)
            {
                    return;
            }
            
            this.Updater.Invoke(obj:  new Systems.Server.ServerData(gsData:  val_22.ScriptData, pfData:  0).GetServerData(key:  "PlayerProfile"));
            return;
            label_4:
            if((val_3.Contains(value:  "ChangeUserDetailsRequest - ")) == false)
            {
                goto label_19;
            }
            
            val_26 = 0;
            val_27 = 3;
            goto label_20;
            label_25:
            val_26 = 1;
            label_20:
            if(val_26 < this.UserNameSetErrorServerMessage.Length)
            {
                goto label_25;
            }
            
            this.ObscenityFoundCallback.Invoke(obj:  ((val_3.Contains(value:  this.UserNameSetErrorServerMessage[0])) != true) ? (val_26) : (val_27));
            return;
            label_19:
            val_21 = this.className;
            val_23 = val_21;
            val_25 = val_22.Errors.JSON;
            val_24 = "OnChangeDisplayName";
            label_7:
            ConsoleLogger.LogError(className:  val_23, functionName:  val_24, logString:  val_25);
        }
    
    }

}
