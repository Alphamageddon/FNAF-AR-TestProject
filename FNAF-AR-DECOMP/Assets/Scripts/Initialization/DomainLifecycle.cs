using UnityEngine;

namespace Initialization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DomainLifecycle : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomainBuilder serverDomainBuilder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasToSBeenAcceptedYet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Action> _registeredTeardownCallbacks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SceneLookupTableAccess _sceneLookupTableAccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Initialization.Configs _configs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Initialization.CameraFx _cameraFx;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            Game.MasterData.MasterDataDomain val_52;
            Master.MasterDomain val_53;
            Master.MasterDomain val_54;
            var val_55;
            Master.EventExposer val_56;
            Master.SceneLookupTableAccess val_57;
            Master.MasterDomain val_58;
            Master.MasterDomain val_59;
            Master.EventExposer val_60;
            Master.MasterDomain val_61;
            Master.MasterDomain val_62;
            Master.EventExposer val_63;
            Master.MasterDomain val_64;
            Game.Server.ServerDomain val_65;
            Master.MasterDomain val_66;
            Master.MasterDomain val_67;
            Master.EventExposer val_68;
            Master.MasterDomain val_69;
            Game.CameraEquipment.CameraEquipmentDomain val_70;
            Master.MasterDomain val_71;
            Master.MasterDomain val_72;
            Master.MasterDomain val_73;
            Master.EventExposer val_74;
            Master.MasterDomain val_75;
            Master.MasterDomain val_76;
            Master.EventExposer val_77;
            Master.MasterDomain val_78;
            Master.MasterDomain val_79;
            Game.Server.ServerDomain val_80;
            Game.MasterData.MasterDataDomain val_81;
            Master.MasterDomain val_82;
            Game.MasterData.MasterDataDomain val_83;
            Master.MasterDomain val_84;
            Master.MasterDomain val_85;
            Game.MasterData.MasterDataDomain val_86;
            this._registeredTeardownCallbacks = new System.Collections.Generic.List<System.Action>();
            this._hasToSBeenAcceptedYet = ((UnityEngine.PlayerPrefs.GetInt(key:  "PrivacyPolicyTermsOfServiceAcceptedKey", defaultValue:  0)) == 1) ? 1 : 0;
            UnityEngine.Transform val_5 = this.masterDomain.gameObject.transform;
            this.masterDomain.eventExposer = new Master.EventExposer();
            this.masterDomain.serverDomain = new Game.Server.ServerDomain();
            this.serverDomainBuilder = new Game.Server.ServerDomainBuilder(masterDomain:  this.masterDomain);
            if(this._hasToSBeenAcceptedYet != true)
            {
                    new Master.PreTOSAcceptanceHandler(eventExposer:  this.masterDomain.eventExposer).DisableNecessaryComponentsBeforeToSAcceptance();
            }
            
            this.masterDomain.arObjectDetectionDomain = new Systems.ARObjectDetection.ARObjectDetectionDomain();
            this.masterDomain.MasterDataDomain = new Game.MasterData.MasterDataDomain(eventExposer:  this.masterDomain.eventExposer);
            if(this.masterDomain != null)
            {
                    val_52 = this.masterDomain.MasterDataDomain;
            }
            else
            {
                    val_52 = this.masterDomain.MasterDataDomain;
            }
            
            this.masterDomain.LocalizationDomain = new Game.Localization.LocalizationDomain(masterDataDomain:  val_52, localLocalizationKVPs:  0.LocalLocalizationKVPs);
            val_53 = this.masterDomain;
            if(this.masterDomain != null)
            {
                goto label_14;
            }
            
            val_53 = this.masterDomain;
            if(val_53 == null)
            {
                goto label_128;
            }
            
            label_14:
            this.masterDomain.ItemDefinitionDomain = new Game.ItemDefinition.ItemDefinitionDomain(eventExposer:  this.masterDomain.eventExposer, masterDataDomain:  this.masterDomain.MasterDataDomain);
            val_54 = this.masterDomain;
            if(this.masterDomain != null)
            {
                goto label_16;
            }
            
            val_54 = this.masterDomain;
            if(val_54 == null)
            {
                goto label_128;
            }
            
            label_16:
            this.masterDomain.GameAssetManagementDomain = new Game.AssetManagement.GameAssetManagementDomain(parent:  val_5, masterEventExposer:  this.masterDomain.eventExposer, masterDataDomain:  this.masterDomain.MasterDataDomain);
            if(this.masterDomain == null)
            {
                goto label_18;
            }
            
            val_55 = this;
            val_56 = this.masterDomain.eventExposer;
            val_57 = this._sceneLookupTableAccess;
            val_58 = this.masterDomain;
            val_59 = this.masterDomain;
            goto label_21;
            label_18:
            val_55 = this;
            val_57 = this._sceneLookupTableAccess;
            val_56 = this.masterDomain.eventExposer;
            val_58 = this.masterDomain;
            if(val_58 == null)
            {
                goto label_20;
            }
            
            val_59 = val_58;
            goto label_21;
            label_20:
            val_59 = this.masterDomain;
            if(val_59 == null)
            {
                goto label_128;
            }
            
            label_21:
            this.masterDomain.GameAudioDomain = new Game.Audio.GameAudioDomain(parent:  val_5, masterEventExposer:  val_56, sceneLookupTableAccess:  val_57, gameAssetManagementDomain:  this.masterDomain.GameAssetManagementDomain, masterDataDomain:  this.masterDomain.MasterDataDomain);
            if(this.masterDomain == null)
            {
                goto label_23;
            }
            
            val_60 = this.masterDomain.eventExposer;
            val_61 = this.masterDomain;
            val_62 = this.masterDomain;
            goto label_26;
            label_23:
            val_61 = this.masterDomain;
            val_60 = this.masterDomain.eventExposer;
            if(val_61 == null)
            {
                goto label_25;
            }
            
            val_62 = val_61;
            goto label_26;
            label_25:
            val_62 = this.masterDomain;
            if(val_62 == null)
            {
                goto label_128;
            }
            
            label_26:
            this.masterDomain.animatronic3DDomain = new Animatronics.Animatronic3d.Animatronic3DDomain(parent:  val_5, masterEventExposer:  val_60, gameAssetManagementDomain:  this.masterDomain.GameAssetManagementDomain, gameAudioDomain:  this.masterDomain.GameAudioDomain);
            this.masterDomain.MovementNodeDomain = new MapMode.MovementNode.MovementNodeDomain(sceneLookupTableAccess:  val_57, eventExposer:  this.masterDomain.eventExposer, movementNodeConfig:  this._configs._movementNodeConfig);
            if(this.masterDomain == null)
            {
                goto label_30;
            }
            
            val_63 = this.masterDomain.eventExposer;
            val_64 = this.masterDomain;
            goto label_31;
            label_30:
            val_64 = this.masterDomain;
            val_63 = this.masterDomain.eventExposer;
            if(val_64 == null)
            {
                goto label_32;
            }
            
            label_31:
            label_123:
            this.masterDomain.AnimatronicEntityDomain = new AnimatronicEntity.AnimatronicEntityDomain(sceneLookupTableAccess:  val_57, exposer:  val_63, serverDomain:  this.masterDomain.serverDomain, movementNodeDomain:  this.masterDomain.MovementNodeDomain, masterDataDomain:  this.masterDomain.MasterDataDomain, animatronicEntityConfig:  this._configs._animatronicEntityConfig, itemDefinitionDomain:  this.masterDomain.ItemDefinitionDomain);
            this.masterDomain.AnimatronicStatsDomain = new Animatronics.AnimatronicStats.AnimatronicStatsDomain();
            if(this.masterDomain == null)
            {
                goto label_36;
            }
            
            val_65 = this.masterDomain.serverDomain;
            val_66 = this.masterDomain;
            val_67 = this.masterDomain;
            goto label_39;
            label_36:
            val_66 = this.masterDomain;
            val_65 = this.masterDomain.serverDomain;
            if(val_66 == null)
            {
                goto label_38;
            }
            
            val_67 = val_66;
            goto label_39;
            label_32:
            if(this.masterDomain == null)
            {
                goto label_40;
            }
            
            goto label_123;
            label_38:
            val_67 = this.masterDomain;
            if(val_67 == null)
            {
                goto label_128;
            }
            
            label_39:
            this.masterDomain.devicesDomain = new Game.Devices.DevicesDomain(serverDomain:  val_65, itemDefinitionDomain:  this.masterDomain.ItemDefinitionDomain, eventExposer:  this.masterDomain.eventExposer);
            this.masterDomain.guideDomain = new Systems.Guide.GuideDomain();
            if(this.masterDomain == null)
            {
                goto label_44;
            }
            
            val_68 = this.masterDomain.eventExposer;
            val_69 = this.masterDomain;
            goto label_45;
            label_44:
            val_69 = this.masterDomain;
            val_68 = this.masterDomain.eventExposer;
            if(val_69 == null)
            {
                goto label_46;
            }
            
            label_45:
            label_125:
            this.masterDomain.CameraEquipmentDomain = new Game.CameraEquipment.CameraEquipmentDomain(sceneLookupTableAccess:  val_57, masterEventExposer:  val_68, devicesDomain:  this.masterDomain.devicesDomain, masterDataDomain:  this.masterDomain.MasterDataDomain, serverDomain:  this.masterDomain.serverDomain);
            if(this.masterDomain != null)
            {
                    val_70 = this.masterDomain.CameraEquipmentDomain;
            }
            else
            {
                    val_70 = this.masterDomain.CameraEquipmentDomain;
            }
            
            this.masterDomain.analyticsDomain = new Systems.Analytics.AnalyticsDomain(cameraEquipmentDomain:  val_70, theGameDomain:  0.theGameDomain, devicesDomain:  this.masterDomain.devicesDomain);
            val_71 = this.masterDomain;
            if(this.masterDomain != null)
            {
                goto label_51;
            }
            
            val_71 = this.masterDomain;
            if(val_71 == null)
            {
                goto label_128;
            }
            
            label_51:
            this.masterDomain.PlayerStatsDomain = new Game.PlayerStats.PlayerStatsDomain(exposer:  this.masterDomain.eventExposer, itemDefinitions:  this.masterDomain.ItemDefinitionDomain.ItemDefinitions, serverDomain:  this.masterDomain.serverDomain);
            if(this.masterDomain == null)
            {
                goto label_55;
            }
            
            val_72 = this.masterDomain;
            goto label_56;
            label_55:
            val_72 = this.masterDomain;
            if(val_72 == null)
            {
                goto label_57;
            }
            
            label_56:
            label_76:
            label_77:
            label_78:
            label_79:
            label_129:
            this.masterDomain.AttackSequenceDomain = new Game.AttackSequence.AttackSequenceDomain(sceneLookupTableAccess:  val_57, masterEventExposer:  this.masterDomain.eventExposer, animatronicEntityDomain:  this.masterDomain.AnimatronicEntityDomain, animatronic3DDomain:  this.masterDomain.animatronic3DDomain, cameraEquipmentDomain:  this.masterDomain.CameraEquipmentDomain, itemDefinitionDomain:  this.masterDomain.ItemDefinitionDomain, masterDataDomain:  this.masterDomain.MasterDataDomain, serverDomain:  this.masterDomain.serverDomain, cameraFx:  this._cameraFx, playerStatsDomain:  this.masterDomain.PlayerStatsDomain);
            val_73 = this.masterDomain;
            if(this.masterDomain != null)
            {
                goto label_58;
            }
            
            val_73 = this.masterDomain;
            if(val_73 == null)
            {
                goto label_128;
            }
            
            label_58:
            this.masterDomain.AnimatronicsSpawnerDomain = new Animatronics.Spawner.AnimatronicsSpawnerDomain(masterDomain:  this.masterDomain, animatronicEntityDomain:  this.masterDomain.AnimatronicEntityDomain, movementNodeDomain:  this.masterDomain.MovementNodeDomain);
            if(this.masterDomain == null)
            {
                goto label_60;
            }
            
            val_74 = this.masterDomain.eventExposer;
            val_75 = this.masterDomain;
            goto label_61;
            label_60:
            val_75 = this.masterDomain;
            val_74 = this.masterDomain.eventExposer;
            if(val_75 == null)
            {
                goto label_62;
            }
            
            label_61:
            label_127:
            this.masterDomain.GeoPositionObjectDomain = new MapMode.GeoPositionObject.GeoPositionObjectDomain(sceneLookupTableAccess:  val_57, eventExposer:  val_74, animatronicEntityDomain:  this.masterDomain.AnimatronicEntityDomain, movementNodeDomain:  this.masterDomain.MovementNodeDomain, devicesDomain:  this.masterDomain.devicesDomain, geoPositionObjectConfig:  this._configs._geoPositionObjectConfig, animatronic3DDomain:  this.masterDomain.animatronic3DDomain);
            if(this.masterDomain == null)
            {
                goto label_65;
            }
            
            val_76 = this.masterDomain;
            goto label_66;
            label_65:
            val_76 = this.masterDomain;
            if(val_76 == null)
            {
                goto label_67;
            }
            
            label_66:
            label_84:
            label_85:
            label_86:
            label_87:
            label_88:
            label_90:
            this.masterDomain.essenceCollectionDomain = new Game.EssenceCollection.EssenceCollectionDomain(sceneLookupTableAccess:  val_57, masterDataDomain:  this.masterDomain.MasterDataDomain, serverDomain:  this.masterDomain.serverDomain, eventExposer:  this.masterDomain.eventExposer, arObjectDetectionDomain:  this.masterDomain.arObjectDetectionDomain, attackSequenceDomain:  this.masterDomain.AttackSequenceDomain, cameraEquipmentDomain:  this.masterDomain.CameraEquipmentDomain, gameAssetManagementDomain:  this.masterDomain.GameAssetManagementDomain, gameDisplay:  val_76.theGameDomain.gameDisplayChanger, gameAudioDomain:  this.masterDomain.GameAudioDomain);
            if(this.masterDomain == null)
            {
                goto label_70;
            }
            
            val_77 = this.masterDomain.eventExposer;
            val_78 = this.masterDomain;
            val_79 = this.masterDomain;
            goto label_73;
            label_70:
            val_78 = this.masterDomain;
            val_77 = this.masterDomain.eventExposer;
            if(val_78 == null)
            {
                goto label_72;
            }
            
            val_79 = val_78;
            goto label_73;
            label_46:
            if(this.masterDomain == null)
            {
                goto label_74;
            }
            
            goto label_125;
            label_57:
            if(this.masterDomain != null)
            {
                goto label_76;
            }
            
            if(this.masterDomain != null)
            {
                goto label_77;
            }
            
            if(this.masterDomain != null)
            {
                goto label_78;
            }
            
            if(this.masterDomain != null)
            {
                goto label_79;
            }
            
            if(this.masterDomain == null)
            {
                goto label_80;
            }
            
            goto label_129;
            label_62:
            if(this.masterDomain == null)
            {
                goto label_82;
            }
            
            goto label_127;
            label_67:
            if(this.masterDomain != null)
            {
                goto label_84;
            }
            
            if(this.masterDomain != null)
            {
                goto label_85;
            }
            
            if(this.masterDomain != null)
            {
                goto label_86;
            }
            
            if(this.masterDomain != null)
            {
                goto label_87;
            }
            
            if(this.masterDomain != null)
            {
                goto label_88;
            }
            
            if(this.masterDomain != null)
            {
                goto label_90;
            }
            
            goto label_90;
            label_72:
            val_79 = this.masterDomain;
            if(val_79 == null)
            {
                goto label_128;
            }
            
            label_73:
            this.masterDomain.WorkshopDomain = new Workshop.WorkshopDomain(exposer:  val_77, itemDefinitionDomain:  this.masterDomain.ItemDefinitionDomain, serverDomain:  this.masterDomain.serverDomain);
            if(this.masterDomain != null)
            {
                    val_80 = this.masterDomain.serverDomain;
            }
            else
            {
                    val_80 = this.masterDomain.serverDomain;
            }
            
            this.masterDomain.getSocialDomain = new Systems.GetSocialInviteHandling.GetSocialDomain(serverDomain:  val_80, loginDomain:  0.theGameDomain.loginDomain, eventExposer:  this.masterDomain.eventExposer);
            if(this.masterDomain == null)
            {
                goto label_97;
            }
            
            val_81 = this.masterDomain.MasterDataDomain;
            val_82 = this.masterDomain;
            goto label_98;
            label_97:
            val_82 = this.masterDomain;
            val_81 = this.masterDomain.MasterDataDomain;
            if(val_82 == null)
            {
                goto label_99;
            }
            
            label_98:
            label_113:
            label_115:
            this.masterDomain.StoreDomain = new Game.Store.StoreDomain(masterDataDomain:  val_81, serverDomain:  this.masterDomain.serverDomain, exposer:  this.masterDomain.eventExposer, bank:  val_82.theGameDomain.bank, lookupAccess:  this.masterDomain.GameAssetManagementDomain.IconLookupAccess);
            this.masterDomain.seasonalEventDomain = new Game.SeasonalEvents.SeasonalEventDomain(getAccessToData:  this.masterDomain.MasterDataDomain.GetAccessToData, eventExposer:  this.masterDomain.eventExposer);
            this.masterDomain.seasonalAssetDomain = new Game.SeasonalAssets.SeasonalAssetDomain(getAccessToData:  this.masterDomain.MasterDataDomain.GetAccessToData, eventExposer:  this.masterDomain.eventExposer);
            if(this.masterDomain == null)
            {
                goto label_109;
            }
            
            val_83 = this.masterDomain.MasterDataDomain;
            val_84 = this.masterDomain;
            val_85 = this.masterDomain;
            goto label_112;
            label_109:
            val_84 = this.masterDomain;
            val_83 = this.masterDomain.MasterDataDomain;
            if(val_84 == null)
            {
                goto label_111;
            }
            
            val_85 = val_84;
            goto label_112;
            label_99:
            if(this.masterDomain != null)
            {
                goto label_113;
            }
            
            if(this.masterDomain != null)
            {
                goto label_115;
            }
            
            goto label_115;
            label_111:
            val_85 = this.masterDomain;
            if(val_85 == null)
            {
                goto label_128;
            }
            
            label_112:
            this.masterDomain.dailyChallengeDomain = new Game.DailyChallenge.DailyChallengeDomain(masterDataDomain:  val_83, serverDomain:  this.masterDomain.serverDomain, exposer:  this.masterDomain.eventExposer);
            if(this.masterDomain != null)
            {
                    val_86 = this.masterDomain.MasterDataDomain;
            }
            else
            {
                    val_86 = this.masterDomain.MasterDataDomain;
            }
            
            this.masterDomain.AdsDomain = new Game.Ads.AdsDomain(masterDataDomain:  val_86, theGameDomain:  0.theGameDomain);
            this.masterDomain.loadingHandler = new Master.LoadingHandler();
            this.masterDomain.eventConnector = new Master.EventConnector();
            this.masterDomain.GameLifecycleHandler = new Master.Restart.GameLifecycleHandler();
            return;
            label_40:
            if(this.masterDomain != null)
            {
                goto label_123;
            }
            
            goto label_128;
            label_74:
            if(this.masterDomain != null)
            {
                goto label_125;
            }
            
            goto label_128;
            label_82:
            if(this.masterDomain != null)
            {
                goto label_127;
            }
            
            goto label_128;
            label_80:
            if(this.masterDomain != null)
            {
                goto label_129;
            }
            
            label_128:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Master.MasterDomain val_7;
            Master.MasterDomain val_8;
            Master.MasterDomain val_9;
            this.serverDomainBuilder.SetupDomain(masterDomain:  this.masterDomain);
            Master.Restart.ShutdownParameters val_1 = new Master.Restart.ShutdownParameters();
            if(val_1 != null)
            {
                    .DomainLifecycle = this;
                val_7 = this.masterDomain;
            }
            else
            {
                    mem[24] = this;
                val_7 = this.masterDomain;
            }
            
            .MasterDomain = val_7;
            .DisplayChooser = this.masterDomain.theGameDomain.gameStartDisplayChooser;
            .AudioDomain = this.masterDomain.GameAudioDomain;
            Master.Restart.RestartParameters val_4 = new Master.Restart.RestartParameters();
            if(val_4 != null)
            {
                    .DomainLifecycle = this;
                val_8 = this.masterDomain;
            }
            else
            {
                    mem[24] = this;
                val_8 = this.masterDomain;
            }
            
            .MasterDomain = val_8;
            .DisplayChooser = this.masterDomain.theGameDomain.gameDisplayChanger;
            .AudioDomain = this.masterDomain.GameAudioDomain;
            val_9 = this.masterDomain;
            if(this.masterDomain != null)
            {
                goto label_12;
            }
            
            val_9 = this.masterDomain;
            if(val_9 == null)
            {
                goto label_13;
            }
            
            label_12:
            this.masterDomain.GameLifecycleHandler.Setup(shutdownData:  val_1, restartData:  val_4, masterEvents:  this.masterDomain.eventExposer, lookupTable:  this._sceneLookupTableAccess);
            this.Setup();
            return;
            label_13:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup()
        {
            Master.MasterDomain val_6;
            Master.MasterDomain val_7;
            Master.MasterDomain val_8;
            Game.SeasonalAssets.SeasonalAssetDomain val_9;
            Master.MasterDomain val_10;
            Master.MasterDomain val_11;
            Master.LoadingHandler val_12;
            val_6 = this.masterDomain;
            if(this.masterDomain == null)
            {
                    val_6 = this.masterDomain;
            }
            
            this.masterDomain.guideDomain.Setup(masterDomain:  val_6);
            this.masterDomain.getSocialDomain.Setup(shouldInitOnSetup:  (this._hasToSBeenAcceptedYet == true) ? 1 : 0);
            val_7 = this.masterDomain;
            if(this.masterDomain == null)
            {
                    val_7 = this.masterDomain;
            }
            
            this.masterDomain.eventConnector.Setup(masterDomain:  val_7);
            this.masterDomain.eventExposer.add_LoadingDone(value:  new System.Action(object:  this, method:  System.Void Initialization.DomainLifecycle::OnLoadingDone()));
            val_8 = this.masterDomain;
            if(val_8 == null)
            {
                goto label_9;
            }
            
            val_9 = this.masterDomain.seasonalAssetDomain;
            val_10 = val_8;
            goto label_12;
            label_9:
            val_10 = this.masterDomain;
            val_9 = this.masterDomain.seasonalAssetDomain;
            if(val_10 == null)
            {
                goto label_11;
            }
            
            val_8 = val_10;
            goto label_12;
            label_11:
            val_8 = this.masterDomain;
            if(val_8 == null)
            {
                goto label_13;
            }
            
            label_12:
            val_9.Setup(eventExposer:  this.masterDomain.eventExposer, assetCacheAccess:  this.masterDomain.GameAssetManagementDomain.AssetCacheAccess);
            this.masterDomain.loadingHandler = new Master.LoadingHandler();
            val_11 = this.masterDomain;
            if(val_11 != null)
            {
                    val_12 = this.masterDomain.loadingHandler;
            }
            else
            {
                    val_12 = this.masterDomain.loadingHandler;
                if(this.masterDomain != null)
            {
                    val_11 = this.masterDomain;
            }
            else
            {
                    val_11 = 0;
            }
            
            }
            
            val_12.Setup(masterDomain:  val_11, callback:  new System.Action(object:  456, method:  public System.Void Master.EventExposer::OnLoadingDone()), registeredTeardownCallbacks:  this._registeredTeardownCallbacks);
            return;
            label_13:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            var val_3;
            this.TeardownLoadingHandler();
            this.masterDomain.eventConnector.Teardown();
            this.masterDomain.guideDomain.Teardown();
            this.masterDomain.serverDomain.Teardown();
            this.masterDomain.seasonalAssetDomain.Teardown();
            val_3 = 0;
            goto label_9;
            label_13:
            X21.Item[0].Invoke();
            val_3 = 1;
            label_9:
            if(val_3 < this._registeredTeardownCallbacks.Count)
            {
                goto label_13;
            }
            
            this._registeredTeardownCallbacks.Clear();
            this._registeredTeardownCallbacks = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            Master.MasterDomain val_2;
            this.masterDomain.GameAssetManagementDomain.Update();
            this.masterDomain.guideDomain.Update();
            this.masterDomain.serverDomain.Update();
            val_2 = this.masterDomain;
            if(val_2 == null)
            {
                goto label_7;
            }
            
            if(this.masterDomain.loadingHandler == null)
            {
                goto label_8;
            }
            
            label_11:
            this.masterDomain.loadingHandler.Update();
            return;
            label_7:
            if(this.masterDomain == null)
            {
                goto label_10;
            }
            
            val_2 = this.masterDomain;
            if(this.masterDomain.loadingHandler != null)
            {
                goto label_11;
            }
            
            label_8:
            this.masterDomain.AnimatronicEntityDomain.Update();
            this.masterDomain.AnimatronicsSpawnerDomain.Update();
            this.masterDomain.GeoPositionObjectDomain.Update();
            this.masterDomain.essenceCollectionDomain.Update(deltaTime:  UnityEngine.Time.deltaTime);
            this.masterDomain.MovementNodeDomain.Update();
            this.masterDomain.CameraEquipmentDomain.Update();
            this.masterDomain.AttackSequenceDomain.Update();
            Systems.Android.AndroidBackButtonHandler.Update();
            return;
            label_10:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator OnApplicationPause(bool paused)
        {
            DomainLifecycle.<OnApplicationPause>d__12 val_1 = new DomainLifecycle.<OnApplicationPause>d__12();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .paused = paused;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationFocus(bool hasFocus)
        {
            if(this.masterDomain.AnimatronicEntityDomain != null)
            {
                    hasFocus = hasFocus;
                this.masterDomain.AnimatronicEntityDomain.HandleApplicationFocus(hasFocus:  hasFocus);
            }
            
            if(this.masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this.masterDomain.eventExposer.OnApplicationFocus(focus:  hasFocus);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationQuit()
        {
            if(this.masterDomain.AnimatronicEntityDomain == null)
            {
                    return;
            }
            
            this.masterDomain.AnimatronicEntityDomain.HandleApplicationQuit();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.serverDomainBuilder = 0;
            this.masterDomain.serverDomain = 0;
            this.masterDomain.AttackSequenceDomain.Teardown();
            this.masterDomain.CameraEquipmentDomain.Teardown();
            this.masterDomain.animatronic3DDomain.Teardown();
            this.masterDomain.animatronic3DDomain = 0;
            this.masterDomain.guideDomain.Teardown();
            this.masterDomain.guideDomain = 0;
            this.masterDomain.GameAudioDomain.Teardown();
            this.masterDomain.GameAudioDomain = 0;
            this.masterDomain.GameAssetManagementDomain.Teardown();
            this.masterDomain.GameAssetManagementDomain = 0;
            this.masterDomain.eventExposer = 0;
            this.masterDomain.eventConnector.Teardown();
            this.masterDomain.getSocialDomain.Teardown();
            this.masterDomain.getSocialDomain = 0;
            this.TeardownLoadingHandler();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLoadingDone()
        {
            this.TeardownLoadingHandler();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TeardownLoadingHandler()
        {
            if(this.masterDomain.loadingHandler == null)
            {
                    return;
            }
            
            if(this.masterDomain.eventExposer != null)
            {
                    this.masterDomain.eventExposer.remove_LoadingDone(value:  new System.Action(object:  this, method:  System.Void Initialization.DomainLifecycle::OnLoadingDone()));
            }
            
            this.masterDomain.loadingHandler.Teardown();
            this = this.masterDomain;
            this.masterDomain.loadingHandler = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DomainLifecycle()
        {
        
        }
    
    }

}
