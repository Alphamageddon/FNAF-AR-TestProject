using UnityEngine;

namespace Master
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LoadingHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _sequencer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _onLoadingDoneCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _setup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Analytics.AnalyticsDomain _analyticsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.Domain _theGameDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger _displayChanger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.LoginDomain _loginDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ServerGameUIDataModel _serverGameUiDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.StreakDataUpdater _streakDataUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain _masterDataDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Animatronic3DDomain _animatronic3DDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.ItemDefinitionDomain _itemDefinitionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Restart.GameLifecycleHandler _gameLifecycleHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.GetSocialInviteHandling.GetSocialDomain _getSocialDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.ILocalization _localLocalization;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.GameAssetManagementDomain _gameAssetManagementDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.AssetBundleRequirementModule _assetBundleRequirementModule;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.SeasonalAssets.SeasonalAssetLoader _seasonalAssetLoader;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.MasterDomain masterDomain, System.Action callback, System.Collections.Generic.List<System.Action> registeredTeardownCallbacks)
        {
            var val_8;
            this._onLoadingDoneCallback = callback;
            if(masterDomain != null)
            {
                    val_8 = masterDomain;
                this._theGameDomain = masterDomain._theGameDomain;
                this._masterEvents = masterDomain + 32 + 208;
                this._serverDomain = masterDomain + 32 + 232;
                this._analyticsDomain = masterDomain + 32 + 184;
            }
            else
            {
                    val_8 = 32;
                this._theGameDomain = 64;
                this._masterEvents = 456;
                this._serverDomain = 36;
                this._analyticsDomain = 496;
            }
            
            this._loginDomain = val_8.loginDomain;
            if(masterDomain != null)
            {
                    this._masterDataDomain = masterDomain.MasterDataDomain;
                this._animatronic3DDomain = masterDomain.animatronic3DDomain;
                this._itemDefinitionDomain = masterDomain.ItemDefinitionDomain;
                this._getSocialDomain = masterDomain.getSocialDomain;
            }
            else
            {
                    this._masterDataDomain = 62590012;
                this._animatronic3DDomain = 66481712;
                this._itemDefinitionDomain = 2;
                this._getSocialDomain = 4;
            }
            
            this._localLocalization = masterDomain.LocalizationDomain.ILocalLocalization;
            this._gameAssetManagementDomain = masterDomain.GameAssetManagementDomain;
            this._assetBundleRequirementModule = 64.AssetBundleRequirementModule;
            this._seasonalAssetLoader = masterDomain.seasonalAssetDomain.Loader;
            this._displayChanger = 64.gameDisplayChanger;
            this._serverGameUiDataModel = masterDomain._gameUIDomain.gameUIData;
            this._streakDataUpdater = 66481712;
            this._gameLifecycleHandler = masterDomain.GameLifecycleHandler;
            Master.Startup.StartupSequencer val_6 = new Master.Startup.StartupSequencer();
            this._sequencer = val_6;
            val_6.Setup(masterEvents:  this._masterEvents);
            this.ConstructStartupSequence(registeredTeardownCallbacks:  registeredTeardownCallbacks);
            this._sequencer.Execute(completeCallback:  this._onLoadingDoneCallback, taskCompleteCallback:  new System.Action<System.String>(object:  this._masterEvents, method:  public System.Void Master.EventExposer::OnStartupTaskCompleted(string taskName)));
            this._setup = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            mem[1152921523282424864] = 0;
            if(this._sequencer != null)
            {
                    this._sequencer.Teardown();
            }
            
            this._sequencer = 0;
            mem[1152921523282424856] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._setup == false)
            {
                    return;
            }
            
            this._sequencer.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ConstructStartupSequence(System.Collections.Generic.List<System.Action> registeredTeardownCallbacks)
        {
            Master.Startup.WaitForAuthenticationScreenStartupTask val_1 = new Master.Startup.WaitForAuthenticationScreenStartupTask();
            Master.Startup.WaitForAuthenticationScreenStartupTask val_2 = val_1.Setup(masterEvents:  this._masterEvents);
            this._sequencer.AddTask(task:  val_1);
            ._theGameDomain = this._theGameDomain;
            ._masterEvents = this._masterEvents;
            this._sequencer.AddTask(task:  new Master.Startup.SpawnScreenSleepDelayerTask());
            Master.Startup.PrivacyPolicyTermsOfServiceStartupTask val_4 = new Master.Startup.PrivacyPolicyTermsOfServiceStartupTask();
            Master.Startup.PrivacyPolicyTermsOfServiceStartupTask val_5 = val_4.Setup(masterEvents:  this._masterEvents, localLocalization:  this._localLocalization);
            this._sequencer.AddTask(task:  val_4);
            ._masterDomain = Master.MasterDomain.GetDomain();
            this._sequencer.AddTask(task:  new Master.Startup.AfterPrivacyPolicyTermsOfServiceStartupTask());
            Master.Startup.AuthenticationStartupTask val_8 = new Master.Startup.AuthenticationStartupTask();
            Master.Startup.AuthenticationStartupTask val_9 = val_8.Setup(masterEvents:  this._masterEvents, loginDomain:  this._loginDomain, serverDomain:  this._serverDomain, streakDataUpdater:  this._streakDataUpdater, getSocialDomain:  this._getSocialDomain);
            this._sequencer.AddTask(task:  val_8);
            Master.Startup.FTUEVideoStartupTask val_10 = new Master.Startup.FTUEVideoStartupTask();
            Master.Startup.FTUEVideoStartupTask val_11 = val_10.Setup(masterEvents:  this._masterEvents);
            this._sequencer.AddTask(task:  val_10);
            Master.Startup.WaitForStartLoadingScreenStartupTask val_12 = new Master.Startup.WaitForStartLoadingScreenStartupTask();
            Master.Startup.WaitForStartLoadingScreenStartupTask val_13 = val_12.Setup(masterEvents:  this._masterEvents);
            this._sequencer.AddTask(task:  val_12);
            Master.Startup.ServerLoginStartupTask val_14 = new Master.Startup.ServerLoginStartupTask();
            Master.Startup.ServerLoginStartupTask val_15 = val_14.Setup(masterEvents:  this._masterEvents, loginDomain:  this._loginDomain, serverDomain:  this._serverDomain, gameUiDataModel:  this._serverGameUiDataModel);
            this._sequencer.AddTask(task:  val_14);
            ._loginDomain = this._loginDomain;
            this._sequencer.AddTask(task:  new Master.Startup.PushNotificationsStartupTask());
            ._analyticsDomain = this._analyticsDomain;
            ._teardownCallbacks = registeredTeardownCallbacks;
            ._eventExposer = this._masterEvents;
            this._sequencer.AddTask(task:  new Master.Startup.SetupAnalyticsTask());
            Master.Startup.AdditionalAssetsStartupTask val_18 = new Master.Startup.AdditionalAssetsStartupTask();
            Master.Startup.AdditionalAssetsStartupTask val_19 = val_18.Setup(masterEvents:  this._masterEvents, localLocalizer:  this._localLocalization, assetBundleRequirementModule:  this._assetBundleRequirementModule);
            this._sequencer.AddTask(task:  val_18);
            Master.Startup.StorageSpaceCheckStartupTask val_20 = new Master.Startup.StorageSpaceCheckStartupTask();
            Master.Startup.StorageSpaceCheckStartupTask val_21 = val_20.Setup(masterEvents:  this._masterEvents, assetBundleRequirementModule:  this._assetBundleRequirementModule);
            this._sequencer.AddTask(task:  val_20);
            Master.Startup.StaticDataLoadStartupTask val_22 = null;
            ._progress = 35f;
            val_22 = new Master.Startup.StaticDataLoadStartupTask();
            ._masterEventExposer = this._masterEvents;
            ._masterDataDomain = this._masterDataDomain;
            ._animatronic3DDomain = this._animatronic3DDomain;
            ._itemDefinitionDomain = this._itemDefinitionDomain;
            ._gameAssetManagementDomain = this._gameAssetManagementDomain;
            ._assetBundleRequirementModule = this._assetBundleRequirementModule;
            this._sequencer.AddTask(task:  val_22);
            ._masterEvents = this._masterEvents;
            ._serverDomain = this._serverDomain;
            this._sequencer.AddTask(task:  new Master.Startup.PlayerDataStartupTask());
            Master.Startup.PreambleStartupTask val_24 = new Master.Startup.PreambleStartupTask();
            Master.Startup.PreambleStartupTask val_25 = val_24.Setup(masterEvents:  this._masterEvents);
            this._sequencer.AddTask(task:  val_24);
            Master.Startup.LocationPermissionStartupTask val_26 = new Master.Startup.LocationPermissionStartupTask();
            Master.Startup.LocationPermissionStartupTask val_27 = val_26.Setup(masterEvents:  this._masterEvents);
            this._sequencer.AddTask(task:  val_26);
            ._gameLifecycleHandler = this._gameLifecycleHandler;
            this._sequencer.AddTask(task:  new Master.Startup.CheckLocationPermissionStartupTask());
            ._masterEvents = this._masterEvents;
            this._sequencer.AddTask(task:  new Master.Startup.ShowUIBarsStartUpTask());
            ._seasonalAssetLoader = this._seasonalAssetLoader;
            ._assetBundleRequirementModule = this._assetBundleRequirementModule;
            this._sequencer.AddTask(task:  new Master.Startup.LoadSeasonalAssetsTask());
            ._gameDisplayChanger = this._displayChanger;
            ._masterEvents = this._masterEvents;
            this._sequencer.AddTask(task:  new Master.Startup.ShowMapStartupTask());
            ._masterEvents = this._masterEvents;
            this._sequencer.AddTask(task:  new Master.Startup.EnableAlertsStartupTask());
            ._masterEvents = this._masterEvents;
            this._sequencer.AddTask(task:  new Master.Startup.EnableAnimatronicsStartupTask());
            ._masterEvents = this._masterEvents;
            this._sequencer.AddTask(task:  new Master.Startup.EnableServerHeartbeatStartupTask());
            ._masterEvents = this._masterEvents;
            this._sequencer.AddTask(task:  new Master.Startup.EnableSeasonalUpdateStartupTask());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetTotalLoaded()
        {
            if(this._sequencer != null)
            {
                    return this._sequencer.GetProgressCount();
            }
            
            return this._sequencer.GetProgressCount();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetTotalLoads()
        {
            if(this._sequencer != null)
            {
                    return (int)this._sequencer._maxTasks;
            }
            
            return (int)this._sequencer._maxTasks;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoadingHandler()
        {
        
        }
    
    }

}
