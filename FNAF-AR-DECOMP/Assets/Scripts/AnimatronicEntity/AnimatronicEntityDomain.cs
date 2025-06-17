using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicEntityDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int DEFAULT_PERIOD_FALLBACK = 30;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityConfig _animatronicEntityConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeDomain _movementNodeDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MapMode.PlayerTarget _playerTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain> _itemDefinitionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SceneLookupTableAccess _sceneLookupTableAccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Data.MasterDataConnector _masterDataConnector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Creator <creator>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Container <container>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.StateTracker <stateTracker>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Mover <mover>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.StateChooser <stateChooser>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityUpdater <animatronicEntityUpdater>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.SaveChunkGetter <SaveChunkGetter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Loader <loader>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.ServerChunkLoader <ServerChunkLoader>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.ChunkToGSRequestGenerator <chunkToGsRequestGenerator>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.WorkshopLocations <workshopLocations>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.GeoPositionUtilities <geoPositionUtilities>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.MapMovementUtilities <MapMovementUtilities>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Domain_SROptions debugOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool forceMalfunction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _realSpawns;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _scavengePeriod;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityConfig AnimatronicEntityConfig { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMap map { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MapMode.PlayerTarget playerTarget { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeDomain movementNodeDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ServerDomain serverDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer eventExposer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Creator creator { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Container container { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateTracker stateTracker { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Mover mover { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateChooser stateChooser { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityUpdater animatronicEntityUpdater { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.SaveChunkGetter SaveChunkGetter { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Loader loader { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.ServerChunkLoader ServerChunkLoader { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.ChunkToGSRequestGenerator chunkToGsRequestGenerator { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.WorkshopLocations workshopLocations { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.GeoPositionUtilities geoPositionUtilities { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MapMovementUtilities MapMovementUtilities { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ScavengePeriod { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityConfig get_AnimatronicEntityConfig()
        {
            return (AnimatronicEntity.AnimatronicEntityConfig)this._animatronicEntityConfig;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMap get_map()
        {
            return (Mapbox.Unity.Map.AbstractMap)this._map;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MapMode.PlayerTarget get_playerTarget()
        {
            return (Game.MapMode.PlayerTarget)this._playerTarget;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeDomain get_movementNodeDomain()
        {
            return (MapMode.MovementNode.MovementNodeDomain)this._movementNodeDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ServerDomain get_serverDomain()
        {
            return (Game.Server.ServerDomain)this._serverDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer get_eventExposer()
        {
            return (Master.EventExposer)this._eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Creator get_creator()
        {
            return (AnimatronicEntity.Creator)this.<creator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_creator(AnimatronicEntity.Creator value)
        {
            this.<creator>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Container get_container()
        {
            return (AnimatronicEntity.Container)this.<container>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_container(AnimatronicEntity.Container value)
        {
            this.<container>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateTracker get_stateTracker()
        {
            return (AnimatronicEntity.StateTracker)this.<stateTracker>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_stateTracker(AnimatronicEntity.StateTracker value)
        {
            this.<stateTracker>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Mover get_mover()
        {
            return (AnimatronicEntity.Mover)this.<mover>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_mover(AnimatronicEntity.Mover value)
        {
            this.<mover>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateChooser get_stateChooser()
        {
            return (AnimatronicEntity.StateChooser)this.<stateChooser>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_stateChooser(AnimatronicEntity.StateChooser value)
        {
            this.<stateChooser>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityUpdater get_animatronicEntityUpdater()
        {
            return (AnimatronicEntity.AnimatronicEntityUpdater)this.<animatronicEntityUpdater>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_animatronicEntityUpdater(AnimatronicEntity.AnimatronicEntityUpdater value)
        {
            this.<animatronicEntityUpdater>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.SaveChunkGetter get_SaveChunkGetter()
        {
            return (AnimatronicEntity.SaveChunkGetter)this.<SaveChunkGetter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_SaveChunkGetter(AnimatronicEntity.SaveChunkGetter value)
        {
            this.<SaveChunkGetter>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Loader get_loader()
        {
            return (AnimatronicEntity.Loader)this.<loader>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_loader(AnimatronicEntity.Loader value)
        {
            this.<loader>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.ServerChunkLoader get_ServerChunkLoader()
        {
            return (AnimatronicEntity.ServerChunkLoader)this.<ServerChunkLoader>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ServerChunkLoader(AnimatronicEntity.ServerChunkLoader value)
        {
            this.<ServerChunkLoader>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.ChunkToGSRequestGenerator get_chunkToGsRequestGenerator()
        {
            return (AnimatronicEntity.ChunkToGSRequestGenerator)this.<chunkToGsRequestGenerator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_chunkToGsRequestGenerator(AnimatronicEntity.ChunkToGSRequestGenerator value)
        {
            this.<chunkToGsRequestGenerator>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.WorkshopLocations get_workshopLocations()
        {
            return (AnimatronicEntity.WorkshopLocations)this.<workshopLocations>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_workshopLocations(AnimatronicEntity.WorkshopLocations value)
        {
            this.<workshopLocations>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.GeoPositionUtilities get_geoPositionUtilities()
        {
            return (AnimatronicEntity.GeoPositionUtilities)this.<geoPositionUtilities>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_geoPositionUtilities(AnimatronicEntity.GeoPositionUtilities value)
        {
            this.<geoPositionUtilities>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MapMovementUtilities get_MapMovementUtilities()
        {
            return (AnimatronicEntity.MapMovementUtilities)this.<MapMovementUtilities>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_MapMovementUtilities(AnimatronicEntity.MapMovementUtilities value)
        {
            this.<MapMovementUtilities>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_ScavengePeriod()
        {
            return (float)this._scavengePeriod;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntityDomain(Master.SceneLookupTableAccess sceneLookupTableAccess, Master.EventExposer exposer, Game.Server.ServerDomain serverDomain, MapMode.MovementNode.MovementNodeDomain movementNodeDomain, Game.MasterData.MasterDataDomain masterDataDomain, AnimatronicEntity.AnimatronicEntityConfig animatronicEntityConfig, Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain> itemDefinitionDomain)
        {
            this._scavengePeriod = 30f;
            val_1 = new System.Object();
            this._eventExposer = val_1;
            this._movementNodeDomain = movementNodeDomain;
            this._serverDomain = serverDomain;
            this._masterDataConnector = new AnimatronicEntity.Data.MasterDataConnector(masterDataDomain:  masterDataDomain, callback:  new System.Action<System.Single>(object:  this, method:  System.Void AnimatronicEntity.AnimatronicEntityDomain::SetScavengePeriod(float period)));
            this._animatronicEntityConfig = animatronicEntityConfig;
            this._itemDefinitionDomain = itemDefinitionDomain;
            this._sceneLookupTableAccess = sceneLookupTableAccess;
            this._realSpawns = true;
            this.Setup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetScavengePeriod(float period)
        {
            this._scavengePeriod = period;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup()
        {
            this._sceneLookupTableAccess.GetMapSceneLookupTableAsync(returnMapSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnMapSceneLookupTable(object:  this, method:  System.Void AnimatronicEntity.AnimatronicEntityDomain::OnMapSceneLookupTableLoaded(MapSceneLookupTable mapSceneLookupTable)));
            this.CreateSubclasses(itemDefinitionDomain:  this._itemDefinitionDomain);
            this.CreateDebugMenuOptions();
            this.CompleteSetup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleApplicationPause(bool paused)
        {
            if((this.<animatronicEntityUpdater>k__BackingField) == null)
            {
                    return;
            }
            
            this.<animatronicEntityUpdater>k__BackingField.HandleApplicationPause(paused:  paused);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleApplicationFocus(bool hasFocus)
        {
            if((this.<animatronicEntityUpdater>k__BackingField) == null)
            {
                    return;
            }
            
            this.<animatronicEntityUpdater>k__BackingField.HandleApplicationFocus(hasFocus:  hasFocus);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleApplicationQuit()
        {
            if((this.<animatronicEntityUpdater>k__BackingField) == null)
            {
                    return;
            }
            
            this.<animatronicEntityUpdater>k__BackingField.HandleApplicationQuit();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.debugOptions = 0;
            this.<creator>k__BackingField = 0;
            this.<container>k__BackingField.Clear();
            this.<container>k__BackingField = 0;
            this.<stateTracker>k__BackingField.Teardown();
            mem[1152921525001061712] = 0;
            mem[1152921525001061720] = 0;
            this.<stateTracker>k__BackingField = 0;
            this.<animatronicEntityUpdater>k__BackingField.Teardown();
            this.<animatronicEntityUpdater>k__BackingField = 0;
            mem[1152921525001061744] = 0;
            this.<geoPositionUtilities>k__BackingField = 0;
            this.<MapMovementUtilities>k__BackingField = 0;
            this.<workshopLocations>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateSubclasses(Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain> itemDefinitionDomain)
        {
            ._animatronicEntityDomain = this;
            this.debugOptions = new AnimatronicEntity.Domain_SROptions();
            this.<creator>k__BackingField = new AnimatronicEntity.Creator(animatronicEntityDomain:  this, itemDefinitionDomain:  itemDefinitionDomain);
            this.<container>k__BackingField = new AnimatronicEntity.Container();
            this.<stateTracker>k__BackingField = new AnimatronicEntity.StateTracker(animatronicEntityDomain:  this);
            this.<mover>k__BackingField = new AnimatronicEntity.Mover(animatronicEntityDomain:  this);
            this.<stateChooser>k__BackingField = new AnimatronicEntity.StateChooser(animatronicEntityDomain:  this);
            this.<animatronicEntityUpdater>k__BackingField = new AnimatronicEntity.AnimatronicEntityUpdater(animatronicEntityDomain:  this);
            ._animatronicEntityDomain = this;
            this.<SaveChunkGetter>k__BackingField = new AnimatronicEntity.SaveChunkGetter();
            ._animatronicEntityDomain = this;
            this.<loader>k__BackingField = new AnimatronicEntity.Loader();
            this.<ServerChunkLoader>k__BackingField = new AnimatronicEntity.ServerChunkLoader();
            this.<workshopLocations>k__BackingField = new AnimatronicEntity.WorkshopLocations(animatronicEntityDomain:  this);
            ._animatronicEntityDomain = this;
            this.<geoPositionUtilities>k__BackingField = new AnimatronicEntity.GeoPositionUtilities();
            ._animatronicEntityDomain = this;
            this.<MapMovementUtilities>k__BackingField = new AnimatronicEntity.MapMovementUtilities();
            this.<chunkToGsRequestGenerator>k__BackingField = new AnimatronicEntity.ChunkToGSRequestGenerator();
            this.<stateChooser>k__BackingField.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMapSceneLookupTableLoaded(MapSceneLookupTable mapSceneLookupTable)
        {
            if(mapSceneLookupTable != null)
            {
                    this._map = mapSceneLookupTable.Map;
            }
            else
            {
                    this._map = 0.Map;
            }
            
            this._playerTarget = mapSceneLookupTable.PlayerTarget;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateDebugMenuOptions()
        {
            DevTools.Runtime.DebugMenu.ShowHideSROptions.RegisterMenuSection(sectionName:  "Map Animatronic Tweaks", sectionMenuObject:  this.debugOptions, defaultToOn:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CompleteSetup()
        {
            this._eventExposer.add_AnimatronicSent(value:  new System.Action<System.String>(object:  this, method:  System.Void AnimatronicEntity.AnimatronicEntityDomain::OnEntitySent(string id)));
            this._eventExposer.add_AnimatronicEntityUpdated(value:  new System.Action<AnimatronicEntity.SaveGameChunk>(object:  this, method:  System.Void AnimatronicEntity.AnimatronicEntityDomain::OnEntityUpdated(AnimatronicEntity.SaveGameChunk chunk)));
            this._eventExposer.add_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void AnimatronicEntity.AnimatronicEntityDomain::OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap map)));
            this.<container>k__BackingField.OnEntityAddedEvent = new System.Action<EntityAddedRemovedArgs>(object:  this._eventExposer, method:  public System.Void Master.EventExposer::OnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e));
            this.<container>k__BackingField.OnEntityRemovedEvent = new System.Action<EntityAddedRemovedArgs>(object:  this._eventExposer, method:  public System.Void Master.EventExposer::OnEntityRemovedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e));
            this.<container>k__BackingField.OnEntitiesClearedEvent = new System.Action<EntitiesClearedArgs>(object:  this._eventExposer, method:  public System.Void Master.EventExposer::OnEntitiesClearedEvent(AnimatronicEntity.Container.EntitiesClearedArgs e));
            this.<mover>k__BackingField.OnEntityMovedEvent = new System.Action<EntityMovedArgs>(object:  this._eventExposer, method:  public System.Void Master.EventExposer::OnEntityMovedEvent(AnimatronicEntity.Mover.EntityMovedArgs e));
            this.<stateChooser>k__BackingField.RegisterStateChangedEvent(callback:  new System.Action<EntityStateChangedArgs>(object:  this._eventExposer, method:  public System.Void Master.EventExposer::OnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)));
            this.<loader>k__BackingField.LoadedEvent = new System.Action<LoadedArgs>(object:  this._eventExposer, method:  public System.Void Master.EventExposer::OnLoadedEvent(AnimatronicEntity.Loader.LoadedArgs e));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.<animatronicEntityUpdater>k__BackingField.UpdateEntities(deltaTime:  UnityEngine.Time.deltaTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap map)
        {
            this._realSpawns = map.AreSpawnsAllowed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEntitySent(string id)
        {
            this.<creator>k__BackingField.CreateFakeEntityToSend(id:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEntityUpdated(AnimatronicEntity.SaveGameChunk chunk)
        {
            AnimatronicEntity.ScavengingData val_11;
            AnimatronicEntity.StateData val_12;
            val_11 = chunk;
            AnimatronicEntity.AnimatronicEntity val_1 = this.<container>k__BackingField.GetEntity(entityId:  chunk.<entityId>k__BackingField);
            if(val_1 != null)
            {
                    val_1.<endoskeletonData>k__BackingField.cpu = chunk.<endoskeletonData>k__BackingField.cpu;
                if((val_1.<stateData>k__BackingField.animatronicState) == (chunk.<stateData>k__BackingField.animatronicState))
            {
                    if(((val_1.<stateData>k__BackingField.expressDelivery) ^ (chunk.<stateData>k__BackingField.expressDelivery)) == false)
            {
                goto label_11;
            }
            
            }
            
                val_1.<stateData>k__BackingField.animatronicState = chunk.<stateData>k__BackingField.animatronicState;
                val_1.<stateData>k__BackingField.expressDelivery = chunk.<stateData>k__BackingField.expressDelivery;
                val_1.StateChangedByServer();
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "Trying to update an entity that doesn\'t exist");
            return;
            label_11:
            val_12 = val_1.<stateData>k__BackingField;
            if(val_12.animatronicState != 10)
            {
                    return;
            }
            
            val_12 = chunk.<scavengingData>k__BackingField.timeStamp;
            if(val_12 == (val_1.<scavengingData>k__BackingField.timeStamp))
            {
                    return;
            }
            
            val_12 = chunk.<scavengingData>k__BackingField;
            val_11 = val_1.<scavengingData>k__BackingField;
            val_1.<scavengingData>k__BackingField.timeStamp = chunk.<scavengingData>k__BackingField.timeStamp;
        }
    
    }

}
