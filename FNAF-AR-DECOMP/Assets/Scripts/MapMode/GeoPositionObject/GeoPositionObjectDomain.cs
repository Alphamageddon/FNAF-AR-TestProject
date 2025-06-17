using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GeoPositionObjectDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.Creator <creator>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.Destroyer <destroyer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.Container <container>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.WorkshopFinder <workshopFinder>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer <animatronicEntitiesExistenceSynchronizer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.RefreshGeoPositions <refreshGeoPositions>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.NewWorkshopChooser <newWorkshopChooser>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.Domain_SROptions debugOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.IAnimatronic3DDomain _animatronic3DDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeDomain _movementNodeDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Devices.DevicesDomain _devicesDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.GeoPositionObjectConfig _geoPositionObjectConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MapMode.PlayerTarget _playerTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _referenceCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _transponderActive;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.IAnimatronic3DDomain Animatronic3DDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMap Map { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MapMode.PlayerTarget PlayerTarget { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera ReferenceCamera { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.GeoPositionObject.PrefabInfoData> PossiblePrefabs { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityDomain AnimatronicEntityDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer eventExposer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.Creator creator { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.Destroyer destroyer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.Container container { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.WorkshopFinder workshopFinder { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer animatronicEntitiesExistenceSynchronizer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.RefreshGeoPositions refreshGeoPositions { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.NewWorkshopChooser newWorkshopChooser { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TransponderActive { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.IAnimatronic3DDomain get_Animatronic3DDomain()
        {
            return (Animatronics.Animatronic3d.IAnimatronic3DDomain)this._animatronic3DDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMap get_Map()
        {
            return (Mapbox.Unity.Map.AbstractMap)this._map;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MapMode.PlayerTarget get_PlayerTarget()
        {
            return (Game.MapMode.PlayerTarget)this._playerTarget;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera get_ReferenceCamera()
        {
            return (UnityEngine.Camera)this._referenceCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.GeoPositionObject.PrefabInfoData> get_PossiblePrefabs()
        {
            if(this._geoPositionObjectConfig != null)
            {
                    return (System.Collections.Generic.List<MapMode.GeoPositionObject.PrefabInfoData>)this._geoPositionObjectConfig._possiblePrefabs;
            }
            
            return (System.Collections.Generic.List<MapMode.GeoPositionObject.PrefabInfoData>)this._geoPositionObjectConfig._possiblePrefabs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityDomain get_AnimatronicEntityDomain()
        {
            return (AnimatronicEntity.AnimatronicEntityDomain)this._animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer get_eventExposer()
        {
            return (Master.EventExposer)this._eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.Creator get_creator()
        {
            return (MapMode.GeoPositionObject.Creator)this.<creator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_creator(MapMode.GeoPositionObject.Creator value)
        {
            this.<creator>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.Destroyer get_destroyer()
        {
            return (MapMode.GeoPositionObject.Destroyer)this.<destroyer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_destroyer(MapMode.GeoPositionObject.Destroyer value)
        {
            this.<destroyer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.Container get_container()
        {
            return (MapMode.GeoPositionObject.Container)this.<container>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_container(MapMode.GeoPositionObject.Container value)
        {
            this.<container>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.WorkshopFinder get_workshopFinder()
        {
            return (MapMode.GeoPositionObject.WorkshopFinder)this.<workshopFinder>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_workshopFinder(MapMode.GeoPositionObject.WorkshopFinder value)
        {
            this.<workshopFinder>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer get_animatronicEntitiesExistenceSynchronizer()
        {
            return (MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer)this.<animatronicEntitiesExistenceSynchronizer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_animatronicEntitiesExistenceSynchronizer(MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer value)
        {
            this.<animatronicEntitiesExistenceSynchronizer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.RefreshGeoPositions get_refreshGeoPositions()
        {
            return (MapMode.GeoPositionObject.RefreshGeoPositions)this.<refreshGeoPositions>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_refreshGeoPositions(MapMode.GeoPositionObject.RefreshGeoPositions value)
        {
            this.<refreshGeoPositions>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.NewWorkshopChooser get_newWorkshopChooser()
        {
            return (MapMode.GeoPositionObject.NewWorkshopChooser)this.<newWorkshopChooser>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_newWorkshopChooser(MapMode.GeoPositionObject.NewWorkshopChooser value)
        {
            this.<newWorkshopChooser>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_TransponderActive()
        {
            return (bool)this._transponderActive;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeoPositionObjectDomain(Master.SceneLookupTableAccess sceneLookupTableAccess, Master.EventExposer eventExposer, AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain, MapMode.MovementNode.MovementNodeDomain movementNodeDomain, Game.Devices.DevicesDomain devicesDomain, MapMode.GeoPositionObject.GeoPositionObjectConfig geoPositionObjectConfig, Utilities.AsyncInterfaceAccess<Animatronics.Animatronic3d.IAnimatronic3DDomain> animatronic3DDomain)
        {
            val_1 = new System.Object();
            this.InitExternalHookups(eventExposer:  Master.EventExposer val_1 = eventExposer, animatronicEntityDomain:  animatronicEntityDomain, movementNodeDomain:  movementNodeDomain, devicesDomain:  devicesDomain, geoPositionObjectConfig:  geoPositionObjectConfig);
            this.CreateSubClasses();
            this.StartSubclasses();
            animatronic3DDomain.GetInterfaceAsync(callback:  new System.Action<Animatronics.Animatronic3d.IAnimatronic3DDomain>(object:  this, method:  public System.Void MapMode.GeoPositionObject.GeoPositionObjectDomain::OnAnimatron3DDomainLoaded(Animatronics.Animatronic3d.IAnimatronic3DDomain domain)));
            sceneLookupTableAccess.GetMapSceneLookupTableAsync(returnMapSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnMapSceneLookupTable(object:  this, method:  System.Void MapMode.GeoPositionObject.GeoPositionObjectDomain::OnMapSceneLookupTableLoaded(MapSceneLookupTable mapSceneLookupTable)));
            val_1.add_NodeReset(value:  new System.Action(object:  this, method:  public System.Void MapMode.GeoPositionObject.GeoPositionObjectDomain::OnNodeReset()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitExternalHookups(Master.EventExposer eventExposer, AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain, MapMode.MovementNode.MovementNodeDomain movementNodeDomain, Game.Devices.DevicesDomain devicesDomain, MapMode.GeoPositionObject.GeoPositionObjectConfig geoPositionObjectConfig)
        {
            System.Action val_4;
            this._animatronicEntityDomain = animatronicEntityDomain;
            this._geoPositionObjectConfig = geoPositionObjectConfig;
            this._movementNodeDomain = movementNodeDomain;
            this._devicesDomain = devicesDomain;
            val_4 = System.Delegate.Combine(a:  devicesDomain.AllPlayerDevices.OnDataUpdated, b:  new System.Action(object:  this, method:  public System.Void MapMode.GeoPositionObject.GeoPositionObjectDomain::OnDevicesUpdated()));
            if(devicesDomain.AllPlayerDevices == null)
            {
                goto label_3;
            }
            
            if(val_4 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_4 == null)
            {
                goto label_7;
            }
            
            label_4:
            if(null != null)
            {
                    val_4 = 0;
            }
            
            label_7:
            devicesDomain.AllPlayerDevices.OnDataUpdated = val_4;
            this._eventExposer = eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateSubClasses()
        {
            ._geoPositionObjectDomain = this;
            this.debugOptions = new MapMode.GeoPositionObject.Domain_SROptions();
            ._geoPositionObjectDomain = this;
            this.<creator>k__BackingField = new MapMode.GeoPositionObject.Creator();
            ._geoPositionObjectDomain = this;
            this.<destroyer>k__BackingField = new MapMode.GeoPositionObject.Destroyer();
            this.<container>k__BackingField = new MapMode.GeoPositionObject.Container();
            ._geoPositionObjectDomain = this;
            this.<workshopFinder>k__BackingField = new MapMode.GeoPositionObject.WorkshopFinder();
            ._geoPositionObjectDomain = this;
            this.<animatronicEntitiesExistenceSynchronizer>k__BackingField = new MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer();
            ._geoPositionObjectDomain = this;
            this.<refreshGeoPositions>k__BackingField = new MapMode.GeoPositionObject.RefreshGeoPositions();
            ._geoPositionObjectDomain = this;
            this.<newWorkshopChooser>k__BackingField = new MapMode.GeoPositionObject.NewWorkshopChooser();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartSubclasses()
        {
            DevTools.Runtime.DebugMenu.ShowHideSROptions.RegisterMenuSection(sectionName:  "MapNodes", sectionMenuObject:  this.debugOptions, defaultToOn:  false);
            this.<animatronicEntitiesExistenceSynchronizer>k__BackingField.OnEnable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMapSceneLookupTableLoaded(MapSceneLookupTable mapSceneLookupTable)
        {
            if(mapSceneLookupTable != null)
            {
                    this._map = mapSceneLookupTable._map;
                this._playerTarget = mapSceneLookupTable._playerTarget;
            }
            else
            {
                    this._map = 64;
                this._playerTarget = 69077560;
            }
            
            this._referenceCamera = mapSceneLookupTable.referenceCamera;
            this.<refreshGeoPositions>k__BackingField.OnEnable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.<refreshGeoPositions>k__BackingField.UpdateGeoPositions();
            this.<animatronicEntitiesExistenceSynchronizer>k__BackingField.CleanOldAnimatronics();
            this.<animatronicEntitiesExistenceSynchronizer>k__BackingField.AddNewAnimatronics();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNodeReset()
        {
            this.ClearAllDebugNodes();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDevicesUpdated()
        {
            if(this.TransponderStateUpdated() == false)
            {
                    return;
            }
            
            this.UpdateIcons();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TransponderStateUpdated()
        {
            var val_5;
            int val_1 = this._devicesDomain.AllPlayerDevices.active.Transponder.Count;
            if(((val_1 > 0) ? 1 : 0) != ((this._transponderActive == true) ? 1 : 0))
            {
                    val_5 = 1;
                this._transponderActive = (val_1 > 0) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateIcons()
        {
            var val_9;
            var val_10;
            val_9 = this;
            List.Enumerator<T> val_2 = this.<container>k__BackingField.FindAllOfType(entityType:  1).GetEnumerator();
            label_11:
            if(((-1433642776) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            val_10 = 0;
            if( == 0)
            {
                goto label_11;
            }
            
            ToggleAnimatronicIcon(show:  (this._transponderActive == true) ? 1 : 0);
            goto label_11;
            label_3:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524648040680});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DisplayBoundingBox()
        {
            var val_7 = this;
            List.Enumerator<T> val_2 = this._movementNodeDomain.GetBoundingBox().GetEnumerator();
            label_5:
            if(((-1433489800) & 1) == 0)
            {
                goto label_3;
            }
            
            MapMode.GeoPositionObject.GeocodeResultObject val_4 = this.<creator>k__BackingField.CreateGeocodeResultObject(node:  0.emailUIDataHandler);
            goto label_5;
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524648193656});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DisplayMapNodes()
        {
            var val_6 = this;
            List.Enumerator<T> val_1 = this._movementNodeDomain.<container>k__BackingField._validMovementNodes.GetEnumerator();
            label_6:
            if(((-1433324552) & 1) == 0)
            {
                goto label_4;
            }
            
            MapMode.GeoPositionObject.GeocodeResultObject val_3 = this.<creator>k__BackingField.CreateGeocodeResultObject(node:  0.emailUIDataHandler);
            goto label_6;
            label_4:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524648358904});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearAllDebugNodes()
        {
            this.<destroyer>k__BackingField.DestroyAllWorkshops();
            this.<destroyer>k__BackingField.DestroyAllGeocodeResults();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatron3DDomainLoaded(Animatronics.Animatronic3d.IAnimatronic3DDomain domain)
        {
            this._animatronic3DDomain = domain;
        }
    
    }

}
