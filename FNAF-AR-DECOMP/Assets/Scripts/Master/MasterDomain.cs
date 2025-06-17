using UnityEngine;

namespace Master
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MasterDomain : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SceneLookupTableAccess _sceneLookupTableAccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.Domain _theGameDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.Domain _gameUIDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.Domain _mapModeDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _alertsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Initialization.SkyboxSceneConfig _skyboxConfigs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Devices.DeviceConfigs.DeviceConfigs _deviceConfigs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _afterTOSAccept;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.LocalLocalizationKVPs _localLocalizationKVPs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MasterData.MasterDataDomain MasterDataDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityDomain AnimatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.CameraEquipment.CameraEquipmentDomain CameraEquipmentDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.AttackSequenceDomain AttackSequenceDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Spawner.AnimatronicsSpawnerDomain AnimatronicsSpawnerDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.AnimatronicStatsDomain AnimatronicStatsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeDomain MovementNodeDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.GeoPositionObjectDomain GeoPositionObjectDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Workshop.WorkshopDomain WorkshopDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.StoreDomain StoreDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.ItemDefinitionDomain ItemDefinitionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.PlayerStats.PlayerStatsDomain PlayerStatsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Animatronic3DDomain animatronic3DDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AssetManagement.GameAssetManagementDomain GameAssetManagementDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Audio.GameAudioDomain GameAudioDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Analytics.AnalyticsDomain analyticsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.ARObjectDetection.ARObjectDetectionDomain arObjectDetectionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.EssenceCollectionDomain essenceCollectionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventConnector eventConnector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.LoadingHandler loadingHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ServerDomain serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Devices.DevicesDomain devicesDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideDomain guideDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.GetSocialInviteHandling.GetSocialDomain getSocialDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.LocalizationDomain LocalizationDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Restart.GameLifecycleHandler GameLifecycleHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.SeasonalAssets.SeasonalAssetDomain seasonalAssetDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.SeasonalEvents.SeasonalEventDomain seasonalEventDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.DailyChallenge.DailyChallengeDomain dailyChallengeDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Ads.AdsDomain AdsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Master.MasterDomain _masterDomain;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.SceneLookupTableAccess SceneLookupTableAccess { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Domain alertsDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.Domain gameUIDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.Domain mapModeDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.Domain theGameDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Initialization.SkyboxSceneConfig SkyboxConfigs { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Devices.DeviceConfigs.DeviceConfigs DeviceConfigs { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject AfterTosAccept { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.LocalLocalizationKVPs LocalLocalizationKVPs { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.SceneLookupTableAccess get_SceneLookupTableAccess()
        {
            return (Master.SceneLookupTableAccess)this._sceneLookupTableAccess;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Domain get_alertsDomain()
        {
            return (Alerts.Domain)this._alertsDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.Domain get_gameUIDomain()
        {
            return (GameUI.Domain)this._gameUIDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.Domain get_mapModeDomain()
        {
            return (MapMode.Domain)this._mapModeDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.Domain get_theGameDomain()
        {
            return (TheGame.Domain)this._theGameDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Initialization.SkyboxSceneConfig get_SkyboxConfigs()
        {
            return (Initialization.SkyboxSceneConfig)this._skyboxConfigs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Devices.DeviceConfigs.DeviceConfigs get_DeviceConfigs()
        {
            return (Game.Devices.DeviceConfigs.DeviceConfigs)this._deviceConfigs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject get_AfterTosAccept()
        {
            return (UnityEngine.GameObject)this._afterTOSAccept;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.LocalLocalizationKVPs get_LocalLocalizationKVPs()
        {
            return (Game.Localization.LocalLocalizationKVPs)this._localLocalizationKVPs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Master.MasterDomain GetDomain()
        {
            if((UnityEngine.Object.op_Implicit(exists:  Master.MasterDomain._masterDomain)) == true)
            {
                    return (Master.MasterDomain)Master.MasterDomain._masterDomain;
            }
            
            Master.MasterDomain._masterDomain = UnityEngine.Object.FindObjectOfType<Master.MasterDomain>();
            return (Master.MasterDomain)Master.MasterDomain._masterDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MasterDomain()
        {
        
        }
    
    }

}
