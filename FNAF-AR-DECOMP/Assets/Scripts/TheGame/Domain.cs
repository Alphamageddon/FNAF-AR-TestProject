using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Domain : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayData.DisplayType startingGameDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string debugSectionName = "Game Manager";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparksDataDownloader <downloader>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Utilities.ScreenSleepDelayer _screenSleepDelayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.AssetBundleRequirementModule _assetBundleRequirementModule;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<TheGame.GameDisplayChanger.DisplayKeyValuePairs> <displayKeyValuePairs>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger <gameDisplayChanger>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameStartDisplayChooser <gameStartDisplayChooser>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer <eventExposer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.PlayerInventory playerInventory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.PlayerAnimatronicEntityClearer playerAnimatronicEntityClearer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameResetter <gameResetter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Server.LoginDomain <loginDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.CurrencyBank <bank>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Server.StreakDataUpdater streakDataUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Permissions.CameraPermissionGovernor cameraPermissionGovernor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GameActive;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparksDataDownloader downloader { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain MasterDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<TheGame.GameDisplayChanger.DisplayKeyValuePairs> displayKeyValuePairs { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayChanger gameDisplayChanger { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameStartDisplayChooser gameStartDisplayChooser { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer eventExposer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameResetter gameResetter { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Server.LoginDomain loginDomain { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.CurrencyBank bank { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.AssetBundleRequirementModule AssetBundleRequirementModule { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparksDataDownloader get_downloader()
        {
            return (GameSparksDataDownloader)this.<downloader>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_downloader(GameSparksDataDownloader value)
        {
            this.<downloader>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain get_MasterDomain()
        {
            return (Master.MasterDomain)this.masterDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<TheGame.GameDisplayChanger.DisplayKeyValuePairs> get_displayKeyValuePairs()
        {
            return (System.Collections.Generic.List<DisplayKeyValuePairs>)this.<displayKeyValuePairs>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_displayKeyValuePairs(System.Collections.Generic.List<TheGame.GameDisplayChanger.DisplayKeyValuePairs> value)
        {
            this.<displayKeyValuePairs>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayChanger get_gameDisplayChanger()
        {
            return (TheGame.GameDisplayChanger)this.<gameDisplayChanger>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_gameDisplayChanger(TheGame.GameDisplayChanger value)
        {
            this.<gameDisplayChanger>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameStartDisplayChooser get_gameStartDisplayChooser()
        {
            return (TheGame.GameStartDisplayChooser)this.<gameStartDisplayChooser>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_gameStartDisplayChooser(TheGame.GameStartDisplayChooser value)
        {
            this.<gameStartDisplayChooser>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer get_eventExposer()
        {
            return (Master.EventExposer)this.<eventExposer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_eventExposer(Master.EventExposer value)
        {
            this.<eventExposer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameResetter get_gameResetter()
        {
            return (TheGame.GameResetter)this.<gameResetter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_gameResetter(TheGame.GameResetter value)
        {
            this.<gameResetter>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Server.LoginDomain get_loginDomain()
        {
            return (Server.LoginDomain)this.<loginDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_loginDomain(Server.LoginDomain value)
        {
            this.<loginDomain>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.CurrencyBank get_bank()
        {
            return (TheGame.CurrencyBank)this.<bank>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_bank(TheGame.CurrencyBank value)
        {
            this.<bank>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.AssetBundleRequirementModule get_AssetBundleRequirementModule()
        {
            return (TheGame.AssetBundleRequirementModule)this._assetBundleRequirementModule;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetWorkshopLookupTable(WorkshopSceneLookupTable workshopSceneLookupTable)
        {
            .displayType = 2;
            .displayObject = workshopSceneLookupTable.DisplayParent;
            this.<displayKeyValuePairs>k__BackingField.Add(item:  new GameDisplayChanger.DisplayKeyValuePairs());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetCameraLookupTable(CameraSceneLookupTable cameraSceneLookupTable)
        {
            .displayType = 1;
            .displayObject = cameraSceneLookupTable.DisplayParent;
            this.<displayKeyValuePairs>k__BackingField.Add(item:  new GameDisplayChanger.DisplayKeyValuePairs());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetMapLookupTable(MapSceneLookupTable mapSceneLookupTable)
        {
            .displayType = 0;
            .displayObject = mapSceneLookupTable.DisplayParent;
            this.<displayKeyValuePairs>k__BackingField.Add(item:  new GameDisplayChanger.DisplayKeyValuePairs());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetSplashLookupTable(Master.SplashSceneLookupTable splashSceneLookupTable)
        {
            .displayType = 6;
            .displayObject = splashSceneLookupTable.DisplayParent;
            this.<displayKeyValuePairs>k__BackingField.Add(item:  new GameDisplayChanger.DisplayKeyValuePairs());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAnimatronicStatsUpdated(System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData> obj)
        {
            this.masterDomain.AnimatronicStatsDomain.container.SetStatsFromLoad(stats:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGameResetChangeEvent(TheGame.GameResetter.GameResetChangedArgs args)
        {
            this.playerAnimatronicEntityClearer.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPlayerAnimatronicDataLoaded(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> container)
        {
            this.masterDomain.AnimatronicEntityDomain.loader.LoadSaveGameChunks(saveGameChunks:  container);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> data)
        {
            this.<bank>k__BackingField.SetBank(bankData:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnServerTimeReceived(long time)
        {
            TheGame.ServerTime.SetServerTime(serverTime:  time);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_InventoryUpdated(TheGame.PlayerInventory obj)
        {
            this.playerInventory = obj;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Initialize()
        {
            this.GameActive = true;
            this.<gameStartDisplayChooser>k__BackingField = new TheGame.GameStartDisplayChooser(domain:  this);
            this.<gameDisplayChanger>k__BackingField = new TheGame.GameDisplayChanger(domain:  this);
            this.<gameResetter>k__BackingField = new TheGame.GameResetter(domain:  this);
            this.playerAnimatronicEntityClearer = new TheGame.PlayerAnimatronicEntityClearer();
            this.<downloader>k__BackingField = new GameSparksDataDownloader(behaviour:  this);
            this.playerInventory = new TheGame.PlayerInventory();
            this.<loginDomain>k__BackingField = new Server.LoginDomain(eventExposer:  this.masterDomain.eventExposer);
            this.<bank>k__BackingField = new TheGame.CurrencyBank();
            this.streakDataUpdater = new Server.StreakDataUpdater();
            this.cameraPermissionGovernor = new Master.Permissions.CameraPermissionGovernor();
            TheGame.AssetBundleRequirementModule val_11 = null;
            ._shouldDownloadAssetBundles = true;
            val_11 = new TheGame.AssetBundleRequirementModule();
            this._assetBundleRequirementModule = val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddSubscriptions()
        {
            this.<gameResetter>k__BackingField.add_OnGameResetChangeEvent(value:  new System.Action<GameResetChangedArgs>(object:  this, method:  System.Void TheGame.Domain::OnGameResetChangeEvent(TheGame.GameResetter.GameResetChangedArgs args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Restart()
        {
            this.Initialize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InjectScreenSleepDelayer(Game.Utilities.ScreenSleepDelayer screenSleepDelayer)
        {
            this._screenSleepDelayer = screenSleepDelayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.Initialize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.<displayKeyValuePairs>k__BackingField = new System.Collections.Generic.List<DisplayKeyValuePairs>();
            this.masterDomain.SceneLookupTableAccess.GetSplashSceneLookupTableAsync(returnSplashSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnSplashSceneLookupTable(object:  this, method:  System.Void TheGame.Domain::GetSplashLookupTable(Master.SplashSceneLookupTable splashSceneLookupTable)));
            this.masterDomain.SceneLookupTableAccess.GetMapSceneLookupTableAsync(returnMapSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnMapSceneLookupTable(object:  this, method:  System.Void TheGame.Domain::GetMapLookupTable(MapSceneLookupTable mapSceneLookupTable)));
            this.masterDomain.SceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void TheGame.Domain::GetCameraLookupTable(CameraSceneLookupTable cameraSceneLookupTable)));
            this.masterDomain.SceneLookupTableAccess.GetWorkshopSceneLookupTableAsync(returnWorkshopSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnWorkshopSceneLookupTable(object:  this, method:  System.Void TheGame.Domain::GetWorkshopLookupTable(WorkshopSceneLookupTable workshopSceneLookupTable)));
            this.<gameStartDisplayChooser>k__BackingField.Start();
            this.<gameDisplayChanger>k__BackingField.Start();
            this.streakDataUpdater.Setup(eventExposer:  this.masterDomain.eventExposer);
            this.cameraPermissionGovernor.Setup(masterEvents:  this.masterDomain.eventExposer);
            this._assetBundleRequirementModule.Setup(masterEvents:  this.masterDomain.eventExposer);
            this.masterDomain.eventExposer.add_PlayerAnimatronicDataLoaded(value:  new System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>>(object:  this, method:  System.Void TheGame.Domain::OnPlayerAnimatronicDataLoaded(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> container)));
            this.masterDomain.eventExposer.add_AnimatronicStatsUpdated(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, Animatronics.AnimatronicStats.StatsData>>(object:  this, method:  System.Void TheGame.Domain::OnAnimatronicStatsUpdated(System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData> obj)));
            this.masterDomain.eventExposer.add_PlayerCurrencyRefreshed(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this, method:  System.Void TheGame.Domain::OnPlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> data)));
            this.masterDomain.eventExposer.add_ServerTimeReceived(value:  new System.Action<System.Int64>(object:  this, method:  System.Void TheGame.Domain::OnServerTimeReceived(long time)));
            this.masterDomain.eventExposer.add_InventoryUpdated(value:  new System.Action<TheGame.PlayerInventory>(object:  this, method:  System.Void TheGame.Domain::EventExposer_InventoryUpdated(TheGame.PlayerInventory obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown(System.Action onShutdownComplete)
        {
            this.<gameStartDisplayChooser>k__BackingField = 0;
            if((this.<gameResetter>k__BackingField) != null)
            {
                    this.<gameResetter>k__BackingField.remove_OnGameResetChangeEvent(value:  new System.Action<GameResetChangedArgs>(object:  this, method:  System.Void TheGame.Domain::OnGameResetChangeEvent(TheGame.GameResetter.GameResetChangedArgs args)));
            }
            
            this.playerAnimatronicEntityClearer = 0;
            this.<gameResetter>k__BackingField = 0;
            DevTools.Runtime.DebugMenu.ShowHideSROptions.DeregisterMenuSection(sectionName:  "Game Manager");
            this._screenSleepDelayer.Teardown(masterEvents:  this.masterDomain.eventExposer);
            this.playerInventory = 0;
            this.<bank>k__BackingField = 0;
            this.GameActive = false;
            this.<downloader>k__BackingField = 0;
            this._screenSleepDelayer = 0;
            if((this.<loginDomain>k__BackingField) != null)
            {
                    this.<loginDomain>k__BackingField.Teardown(onShutdownComplete:  onShutdownComplete);
            }
            
            this.cameraPermissionGovernor.Teardown();
            this._assetBundleRequirementModule.Teardown();
            this._assetBundleRequirementModule = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if((this.<loginDomain>k__BackingField) == null)
            {
                    return;
            }
            
            this.<loginDomain>k__BackingField.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Domain()
        {
        
        }
    
    }

}
