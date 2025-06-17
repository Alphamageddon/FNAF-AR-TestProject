using UnityEngine;

namespace Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LoginDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly string PlayerPrefsLastServerSyncedNameKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.ILoginHandler LoginController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.BestStreakLeaderboardGetter bestStreakLeaderboardGetter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.CurrentStreakLeaderboardGetter currentStreakLeaderboardGetter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Server.PlayerProfileUpdater playerProfileUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Server.PlayerProfile playerProfile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.ChangeDisplayNameRequester changeDisplayNameRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.PushNotificationsInitializer pushNotificationsInitializer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoginDomain(Master.EventExposer eventExposer)
        {
            var val_15;
            Systems.Server.CurrentStreakLeaderboardGetter val_16;
            Systems.Server.ILoginHandler val_17;
            var val_18;
            var val_19;
            this.playerProfileUpdater = new Server.PlayerProfileUpdater();
            val_15 = null;
            val_15 = null;
            if(Game.Server.ServerDomain.CurrentServer == 2)
            {
                goto label_3;
            }
            
            if(Game.Server.ServerDomain.CurrentServer != 1)
            {
                goto label_4;
            }
            
            this.LoginController = new Server.GameSparksLoginHandler();
            this.changeDisplayNameRequester = new Game.Server.GameSparksChangeDisplayNameRequester(callback:  new System.Action<Systems.Server.ServerData>(object:  this.playerProfileUpdater, method:  public System.Void Server.PlayerProfileUpdater::UpdateProfile(Systems.Server.ServerData data)), obscenityFoundCallback:  new System.Action<GameUI.UserNameSetError>(object:  this.playerProfileUpdater, method:  public System.Void Server.PlayerProfileUpdater::OnDisplayNameObscenityFound(GameUI.UserNameSetError error)));
            this.bestStreakLeaderboardGetter = new Server.GameSparksBestStreakLeaderboardGetter();
            Server.GameSparksCurrentStreakLeaderboardGetter val_7 = null;
            val_16 = val_7;
            val_7 = new Server.GameSparksCurrentStreakLeaderboardGetter();
            goto label_5;
            label_3:
            this.LoginController = new Server.PlayFabLoginHandler();
            this.changeDisplayNameRequester = new Systems.Server.PlayFabProxy.PlayfabChangeDisplayNameRequester();
            this.bestStreakLeaderboardGetter = new Systems.Server.PlayFabProxy.PlayFabBestStreakLeaderboardGetter();
            Systems.Server.PlayFabProxy.PlayFabCurrentStreakLeaderboardGetter val_11 = null;
            val_16 = val_11;
            val_11 = new Systems.Server.PlayFabProxy.PlayFabCurrentStreakLeaderboardGetter();
            label_5:
            val_17 = this.LoginController;
            this.currentStreakLeaderboardGetter = val_16;
            val_18 = val_17;
            if(val_17 != null)
            {
                goto label_6;
            }
            
            goto label_7;
            label_4:
            val_17 = 0;
            this.LoginController = 0;
            label_7:
            val_18 = 0;
            label_6:
            if(mem[282584257676957] == 0)
            {
                goto label_11;
            }
            
            var val_14 = mem[282584257676847];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_10:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < mem[282584257676957])
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            var val_16 = val_14;
            val_16 = val_16 + 7;
            val_18 = val_18 + val_16;
            val_19 = val_18 + 296;
            label_11:
            val_17.Awake();
            this.playerProfile = new Server.PlayerProfile();
            this.pushNotificationsInitializer = new Systems.Server.PushNotificationsInitializer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetupForAuthentication(System.Action authFunction, System.Action<string> forcedUpdateFunction, System.Action<Systems.Server.ServerData> streakUpdater)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.LoginController.Setup(authFunction:  authFunction, forcedUpdateFunction:  forcedUpdateFunction, streakDataUpdater:  streakUpdater, playerProfileUpdater:  new System.Action<Systems.Server.ServerData>(object:  this.playerProfileUpdater, method:  public System.Void Server.PlayerProfileUpdater::UpdateProfile(Systems.Server.ServerData data)), changeDisplayNameRequester:  this.changeDisplayNameRequester);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer masterEvents, Game.Server.ServerDomain serverDomain, GameUI.ServerGameUIDataModel serverGameUiDataModel)
        {
            IntPtr val_10;
            IntPtr val_12;
            System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> val_1 = null;
            val_10 = public System.Void Master.EventExposer::OnBestStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> data);
            val_1 = new System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>>(object:  masterEvents, method:  val_10);
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = 0;
            this.bestStreakLeaderboardGetter.Setup(callback:  val_1);
            System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> val_3 = null;
            val_12 = public System.Void Master.EventExposer::OnCurrentStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> data);
            val_3 = new System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>>(object:  masterEvents, method:  val_12);
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = 0;
            this.currentStreakLeaderboardGetter.Setup(callback:  val_3);
            this.playerProfileUpdater.Setup(eventExposer:  masterEvents);
            masterEvents.add_PlayerProfileUpdated(value:  new System.Action<Server.PlayerProfile>(object:  this, method:  System.Void Server.LoginDomain::OnPlayerProfileUpdated(Server.PlayerProfile profile)));
            masterEvents.add_DisplayNameObscenityFound(value:  new System.Action<GameUI.UserNameSetError>(object:  this, method:  System.Void Server.LoginDomain::MasterEvents_DisplayNameObscenityFound(GameUI.UserNameSetError error)));
            var val_12 = 0;
            val_12 = val_12 + 1;
            this.changeDisplayNameRequester.Setup(playerProfileCallback:  new System.Action<Server.PlayerProfile>(object:  masterEvents, method:  public System.Void Master.EventExposer::OnPlayerProfileUpdated(Server.PlayerProfile data)), obscenityFoundCallback:  new System.Action<GameUI.UserNameSetError>(object:  masterEvents, method:  public System.Void Master.EventExposer::OnDisplayNameObscenityFound(GameUI.UserNameSetError error)));
            this.pushNotificationsInitializer.Setup(requester:  serverDomain.registerForPushNotificationsRequester);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown(System.Action onShutdownComplete)
        {
            this.changeDisplayNameRequester = 0;
            this.playerProfileUpdater = 0;
            this.bestStreakLeaderboardGetter = 0;
            if(this.LoginController == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.LoginController.Teardown(onShutdownComplete:  onShutdownComplete);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPlayerProfileUpdated(Server.PlayerProfile profile)
        {
            null = null;
            UnityEngine.PlayerPrefs.SetString(key:  Server.LoginDomain.PlayerPrefsLastServerSyncedNameKey, value:  profile.displayName);
            this.playerProfile = profile;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterEvents_DisplayNameObscenityFound(GameUI.UserNameSetError error)
        {
            null = null;
            this.playerProfile.displayName = UnityEngine.PlayerPrefs.GetString(key:  Server.LoginDomain.PlayerPrefsLastServerSyncedNameKey, defaultValue:  this.playerProfile.displayName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this.pushNotificationsInitializer == null)
            {
                    return;
            }
            
            this.pushNotificationsInitializer.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LoginDomain()
        {
            Server.LoginDomain.PlayerPrefsLastServerSyncedNameKey = "LoginDomain_LastServerSyncedName";
        }
    
    }

}
