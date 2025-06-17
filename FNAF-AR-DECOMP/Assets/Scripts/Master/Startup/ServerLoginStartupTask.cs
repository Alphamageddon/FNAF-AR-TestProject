using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ServerLoginStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _completeFlags;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.LoginDomain _loginDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.StreakDataUpdater _streakDataUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ServerGameUIDataModel _gameUiDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _dialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Processors.ConfigProcessor _cachedConfigProcessor;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.ServerLoginStartupTask Setup(Master.EventExposer masterEvents, Server.LoginDomain loginDomain, Game.Server.ServerDomain serverDomain, GameUI.ServerGameUIDataModel gameUiDataModel)
        {
            Game.Server.Processors.ConfigProcessor val_1 = new Game.Server.Processors.ConfigProcessor();
            this._cachedConfigProcessor = val_1;
            val_1.Setup(eventExposer:  masterEvents);
            this._masterEvents = masterEvents;
            this._loginDomain = loginDomain;
            this._serverDomain = serverDomain;
            this._gameUiDataModel = gameUiDataModel;
            return (Master.Startup.ServerLoginStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents.remove_PlayerCurrencyRefreshed(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this, method:  System.Void Master.Startup.ServerLoginStartupTask::OnPlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> e)));
            this._masterEvents.remove_InventoryUpdated(value:  new System.Action<TheGame.PlayerInventory>(object:  this, method:  System.Void Master.Startup.ServerLoginStartupTask::OnInventoryUpdated(TheGame.PlayerInventory e)));
            this._masterEvents.remove_AlertPlayerDataUpdatedEvent(value:  new System.Action<Alerts.Data.PlayerAlertData>(object:  this, method:  System.Void Master.Startup.ServerLoginStartupTask::OnAlertPlayerDataUpdated(Alerts.Data.PlayerAlertData e)));
            mem[1152921523309617296] = 0;
            this._masterEvents = 0;
            mem[1152921523309617280] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "ServerLogin";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            this._loginDomain.Setup(masterEvents:  this._masterEvents, serverDomain:  this._serverDomain, serverGameUiDataModel:  this._gameUiDataModel);
            this.OnAuthenticated();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAuthenticated()
        {
            object val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = this;
            this._masterEvents.add_PlayerCurrencyRefreshed(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this, method:  System.Void Master.Startup.ServerLoginStartupTask::OnPlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> e)));
            this._masterEvents.add_InventoryUpdated(value:  new System.Action<TheGame.PlayerInventory>(object:  this, method:  System.Void Master.Startup.ServerLoginStartupTask::OnInventoryUpdated(TheGame.PlayerInventory e)));
            this._masterEvents.add_AlertPlayerDataUpdatedEvent(value:  new System.Action<Alerts.Data.PlayerAlertData>(object:  this, method:  System.Void Master.Startup.ServerLoginStartupTask::OnAlertPlayerDataUpdated(Alerts.Data.PlayerAlertData e)));
            val_7 = null;
            if(this.ShouldRequestConfigs() != false)
            {
                    val_8 = null;
                UnityEngine.PlayerPrefs.DeleteKey(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_MASTER_DATA_VERSION);
                this._serverDomain.serverDataRequester.GetConfigs();
            }
            else
            {
                    val_9 = null;
                int val_5 = UnityEngine.PlayerPrefs.GetInt(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_MASTER_DATA_VERSION);
                this._cachedConfigProcessor.ProcessFromCache();
                val_6 = this._serverDomain;
            }
            
            mem[this._serverDomain] + 144.GetPlayerData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldRequestConfigs()
        {
            var val_5;
            bool val_1 = this.IsVersionMementoValid();
            if(val_1 != false)
            {
                    if(val_1.IsCachedMasterDataAvailable() != false)
            {
                    val_5 = this.IsCachedMasterDataCurrent() ^ 1;
                return (bool)val_5 & 1;
            }
            
            }
            
            val_5 = 1;
            return (bool)val_5 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsVersionMementoValid()
        {
            var val_7 = 0;
            val_7 = val_7 + 1;
            var val_8 = 0;
            val_8 = val_8 + 1;
            int val_4 = this._loginDomain.LoginController.serverSpecifiedAssetDataVersion;
            val_4 = ((this._loginDomain.LoginController.serverSpecifiedMasterDataVersion != 0) ? 1 : 0) & ((val_4 != 0) ? 1 : 0);
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsCachedMasterDataAvailable()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((UnityEngine.PlayerPrefs.HasKey(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_MASTER_DATA_VERSION)) == false)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            return UnityEngine.PlayerPrefs.HasKey(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_ASSET_DATA_VERSION);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsCachedMasterDataCurrent()
        {
            var val_8;
            var val_9;
            var val_10;
            var val_8 = 0;
            val_8 = val_8 + 1;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_8 = null;
            val_8 = null;
            if((UnityEngine.PlayerPrefs.GetInt(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_MASTER_DATA_VERSION)) == this._loginDomain.LoginController.serverSpecifiedMasterDataVersion)
            {
                    val_9 = null;
                val_9 = null;
                var val_7 = ((UnityEngine.PlayerPrefs.GetInt(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_ASSET_DATA_VERSION)) == this._loginDomain.LoginController.serverSpecifiedAssetDataVersion) ? 1 : 0;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAlertPlayerDataUpdated(Alerts.Data.PlayerAlertData e)
        {
            this._masterEvents.remove_AlertPlayerDataUpdatedEvent(value:  new System.Action<Alerts.Data.PlayerAlertData>(object:  this, method:  System.Void Master.Startup.ServerLoginStartupTask::OnAlertPlayerDataUpdated(Alerts.Data.PlayerAlertData e)));
            this.CallIfDone(flag:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> e)
        {
            string val_1 = "_ExterminateColor";
            val_1 = new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this, method:  System.Void Master.Startup.ServerLoginStartupTask::OnPlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> e));
            this._masterEvents.remove_PlayerCurrencyRefreshed(value:  val_1);
            this.CallIfDone(flag:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnInventoryUpdated(TheGame.PlayerInventory e)
        {
            this._masterEvents.remove_InventoryUpdated(value:  new System.Action<TheGame.PlayerInventory>(object:  this, method:  System.Void Master.Startup.ServerLoginStartupTask::OnInventoryUpdated(TheGame.PlayerInventory e)));
            this.CallIfDone(flag:  4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CallIfDone(int flag)
        {
            int val_1 = this._completeFlags;
            val_1 = val_1 | flag;
            this._completeFlags = val_1;
            if(val_1 != 7)
            {
                    return;
            }
            
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerLoginStartupTask()
        {
        
        }
    
    }

}
