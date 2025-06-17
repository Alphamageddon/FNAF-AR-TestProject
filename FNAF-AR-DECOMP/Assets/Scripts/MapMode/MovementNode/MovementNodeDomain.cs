using UnityEngine;

namespace MapMode.MovementNode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MovementNodeDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeConfig _movementNodeConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeUtilities _mapUtilities;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementPathGenerator _pathGenerator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MapMode.PlayerTarget _playerTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.GenerateMovementNodes _generateMovementNodes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeContainer <container>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMap Map { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MapMode.PlayerTarget PlayerTarget { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer EventExposer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.GenerateMovementNodes GenerateMovementNodes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeConfig movementNodeConfig { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeProximityTweaks MovementNodeProximityTweaks { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeUtilities Utilities { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeContainer container { get; set; }
        
        // Methods
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
        public Master.EventExposer get_EventExposer()
        {
            return (Master.EventExposer)this._eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.GenerateMovementNodes get_GenerateMovementNodes()
        {
            return (MapMode.MovementNode.GenerateMovementNodes)this._generateMovementNodes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeConfig get_movementNodeConfig()
        {
            return (MapMode.MovementNode.MovementNodeConfig)this._movementNodeConfig;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeProximityTweaks get_MovementNodeProximityTweaks()
        {
            if(this._movementNodeConfig != null)
            {
                    return (MapMode.MovementNode.MovementNodeProximityTweaks)this._movementNodeConfig.MovementNodeProximityTweaks;
            }
            
            return (MapMode.MovementNode.MovementNodeProximityTweaks)this._movementNodeConfig.MovementNodeProximityTweaks;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MovementNodeProximityTweaks(MapMode.MovementNode.MovementNodeProximityTweaks value)
        {
            this._movementNodeConfig.MovementNodeProximityTweaks = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeUtilities get_Utilities()
        {
            return (MapMode.MovementNode.MovementNodeUtilities)this._mapUtilities;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeContainer get_container()
        {
            return (MapMode.MovementNode.MovementNodeContainer)this.<container>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_container(MapMode.MovementNode.MovementNodeContainer value)
        {
            this.<container>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MovementNodeDomain(Master.SceneLookupTableAccess sceneLookupTableAccess, Master.EventExposer eventExposer, MapMode.MovementNode.MovementNodeConfig movementNodeConfig)
        {
            val_1 = new System.Object();
            this._eventExposer = val_1;
            sceneLookupTableAccess.GetMapSceneLookupTableAsync(returnMapSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnMapSceneLookupTable(object:  this, method:  System.Void MapMode.MovementNode.MovementNodeDomain::OnMapSceneLookupTableLoaded(MapSceneLookupTable mapSceneLookupTable)));
            this._movementNodeConfig = movementNodeConfig;
            this.CreateSubclasses();
            this.<container>k__BackingField.OnNodeReset = new System.Action(object:  this._eventExposer, method:  public System.Void Master.EventExposer::OnNodeReset());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateSubclasses()
        {
            this.<container>k__BackingField = new MapMode.MovementNode.MovementNodeContainer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MapInitialize()
        {
            this._mapUtilities = new MapMode.MovementNode.MovementNodeUtilities(domain:  this);
            ._domain = this;
            this._pathGenerator = new MapMode.MovementNode.MovementPathGenerator();
            this._generateMovementNodes = new MapMode.MovementNode.GenerateMovementNodes(domain:  this);
            this.ResetSpawnPoints();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMapSceneLookupTableLoaded(MapSceneLookupTable mapSceneLookupTable)
        {
            Mapbox.Unity.Map.AbstractMap val_2;
            if(mapSceneLookupTable != null)
            {
                    val_2 = mapSceneLookupTable._map;
                this._map = val_2;
            }
            else
            {
                    this._map = 64;
                val_2 = this._map;
            }
            
            this._playerTarget = mapSceneLookupTable._playerTarget;
            val_2.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void MapMode.MovementNode.MovementNodeDomain::MapInitialize()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetSpawnPoints()
        {
            this.<container>k__BackingField.ClearAllNodes();
            Mapbox.Utils.Vector2d val_1 = this._mapUtilities.GetPlayerPositionLatLon();
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            this.<container>k__BackingField._center = val_2;
            mem2[0] = val_2.y;
            this._generateMovementNodes.Generate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode GetLocationNode(MapMode.MovementNode.LocationNode node)
        {
            if(node == null)
            {
                    return 0;
            }
            
            MapMode.MovementNode.LocationNode val_1 = this.GetNodeForId(id:  node._id);
            if(val_1 == null)
            {
                    return 0;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.LocationNode GetNodeForId(string id)
        {
            GameUI.ServerGameUIDataModel val_7;
            string val_8;
            var val_9;
            val_8 = id;
            List.Enumerator<T> val_1 = this.<container>k__BackingField._validMovementNodes.GetEnumerator();
            label_6:
            if(((-1456934168) & 1) == 0)
            {
                goto label_3;
            }
            
            val_9 = 0.emailUIDataHandler;
            val_7 = val_2._serverGameUIDataModel;
            if((val_7.Equals(value:  val_8)) == false)
            {
                goto label_6;
            }
            
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524624749288});
            return (MapMode.MovementNode.LocationNode)val_9;
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524624749288});
            val_9 = 0;
            return (MapMode.MovementNode.LocationNode)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d GetRandomSpawnPoint()
        {
            if(this._mapUtilities != null)
            {
                    return this._mapUtilities.GetRandomPointAroundPlayerForRadius(radius:  this._movementNodeConfig.MovementNodeProximityTweaks.spawnPointRadius);
            }
            
            return this._mapUtilities.GetRandomPointAroundPlayerForRadius(radius:  this._movementNodeConfig.MovementNodeProximityTweaks.spawnPointRadius);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool FinishedLoading()
        {
            if(this._map == 0)
            {
                    return false;
            }
            
            if(this._map != null)
            {
                    return this._map.isInitialized;
            }
            
            return this._map.isInitialized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode GetNextPoint(MapMode.MovementNode.LocationNode start, MapMode.MovementNode.LocationNode end, float radius)
        {
            if(this._pathGenerator != null)
            {
                    return this._pathGenerator.GetNextPoint(start:  start, end:  end, radius:  radius);
            }
            
            return this._pathGenerator.GetNextPoint(start:  start, end:  end, radius:  radius);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode GetNextScavengePoint()
        {
            if(this._pathGenerator != null)
            {
                    return this._pathGenerator.GetNextScavengePoint();
            }
            
            return this._pathGenerator.GetNextScavengePoint();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode GetClosestToPosition(Mapbox.Utils.Vector2d position)
        {
            .<Node>k__BackingField = 0;
            .<Distance>k__BackingField = -2.2250738585072E-308;
            List.Enumerator<T> val_2 = this.<container>k__BackingField._validMovementNodes.GetEnumerator();
            goto label_6;
            label_7:
            double val_4 = Mapbox.Utils.Vector2d.Distance(a:  new Mapbox.Utils.Vector2d() {x = position.x, y = position.y}, b:  new Mapbox.Utils.Vector2d() {x = val_3._emailIdsToBeSetToReadOnServer, y = val_3._itemDefinitions});
            if(((MapMode.MovementNode.FallbackNode)[1152921524625484448].<Distance>k__BackingField) > val_4)
            {
                    .<Distance>k__BackingField = val_4;
                .<Node>k__BackingField = 0.emailUIDataHandler;
            }
            
            label_6:
            if(((-1456243112) & 1) != 0)
            {
                goto label_7;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524625440344});
            if(new MapMode.MovementNode.FallbackNode() != null)
            {
                    return (MapMode.MovementNode.LocationNode)(MapMode.MovementNode.FallbackNode)[1152921524625484448].<Node>k__BackingField;
            }
            
            return (MapMode.MovementNode.LocationNode)(MapMode.MovementNode.FallbackNode)[1152921524625484448].<Node>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this.FinishedLoading() == false)
            {
                    return;
            }
            
            if(this.NeedReset() == false)
            {
                    return;
            }
            
            this.ResetSpawnPoints();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool NeedReset()
        {
            Mapbox.Utils.Vector2d val_1 = this._mapUtilities.GetPlayerPositionLatLon();
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            Mapbox.Utils.Vector2d val_3 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, b:  new Mapbox.Utils.Vector2d() {x = this.<container>k__BackingField._center});
            return (bool)(val_3.x.magnitude > this._movementNodeConfig.RelocateDistance) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.MovementNode.LocationNode> GetBoundingBox()
        {
            System.Collections.Generic.List<MapMode.MovementNode.LocationNode> val_1 = new System.Collections.Generic.List<MapMode.MovementNode.LocationNode>();
            val_1.Add(item:  MapMode.MovementNode.LocationNode.CreateNodeForLatLon(type:  1, locationLatLon:  new Mapbox.Utils.Vector2d() {x = V10.16B, y = V11.16B}, name:  ""));
            val_1.Add(item:  MapMode.MovementNode.LocationNode.CreateNodeForLatLon(type:  1, locationLatLon:  new Mapbox.Utils.Vector2d() {x = this._mapUtilities._baseBoundingBox, y = V9.16B}, name:  ""));
            return val_1;
        }
    
    }

}
