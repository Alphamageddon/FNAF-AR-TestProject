using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicEntity
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float timeInSameRoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action StateChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain <AnimatronicEntityDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string <entityId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.StateData <stateData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.OriginData <originData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.GeoPositionData <geoPositionData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.DistanceFromPlayerData <distanceFromPlayerData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.UpdateTimerData <updateTimerData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.StalkingTimerData <stalkingTimerData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.MalfunctioningData <malfunctioningData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicConfigData <animatronicConfigData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AttackSequenceData <AttackSequenceData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicConfigMapper <animatronicConfigMapper>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.MoveStateData <moveStateData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.OnDeckData <OnDeckData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.SentAnimatronicData <SentAnimatronicData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.ScavengingData <scavengingData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.UIStateData <UiStateData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <LocationInitialized>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData <endoskeletonData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.RewardDataV3 <rewardDataV3>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <wearAndTear>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityDomain AnimatronicEntityDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string entityId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateData stateData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OriginData originData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.GeoPositionData geoPositionData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.DistanceFromPlayerData distanceFromPlayerData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.UpdateTimerData updateTimerData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StalkingTimerData stalkingTimerData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MalfunctioningData malfunctioningData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicConfigData animatronicConfigData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AttackSequenceData AttackSequenceData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicConfigMapper animatronicConfigMapper { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MoveStateData moveStateData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OnDeckData OnDeckData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.SentAnimatronicData SentAnimatronicData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.ScavengingData scavengingData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.UIStateData UiStateData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LocationInitialized { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeletonData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.RewardDataV3 rewardDataV3 { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int wearAndTear { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AnimatronicEntity()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity(string id, AnimatronicEntity.AnimatronicEntityDomain domain, Game.ItemDefinition.Data.DataDefinitions.CPUData cpu, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData plushSuit, AnimatronicEntity.OriginData.OriginState originState)
        {
            val_1 = new System.Object();
            this.<AnimatronicEntityDomain>k__BackingField = val_1;
            this.<entityId>k__BackingField = domain.<container>k__BackingField.GetFakeID(id:  id);
            this.<stateData>k__BackingField = new AnimatronicEntity.StateData(animatronicState:  0, expressDelivery:  false);
            .<originState>k__BackingField = originState;
            this.<originData>k__BackingField = new AnimatronicEntity.OriginData();
            Mapbox.Utils.Vector2d val_5 = Mapbox.Utils.Vector2d.zero;
            .<geoPosition>k__BackingField = val_5;
            mem[1152921525010723560] = val_5.y;
            this.<geoPositionData>k__BackingField = new AnimatronicEntity.GeoPositionData();
            .<initialized>k__BackingField = false;
            this.<distanceFromPlayerData>k__BackingField = new AnimatronicEntity.DistanceFromPlayerData();
            this.<updateTimerData>k__BackingField = new AnimatronicEntity.UpdateTimerData();
            this.<stalkingTimerData>k__BackingField = new AnimatronicEntity.StalkingTimerData();
            .<isMalfunctioning>k__BackingField = false;
            this.<malfunctioningData>k__BackingField = new AnimatronicEntity.MalfunctioningData();
            .<CpuData>k__BackingField = cpu;
            .<PlushSuitData>k__BackingField = plushSuit;
            .<AttackProfile>k__BackingField = 0;
            this.<animatronicConfigData>k__BackingField = new AnimatronicEntity.AnimatronicConfigData();
            .<attackSequenceComplete>k__BackingField = false;
            .<encounterStartTime>k__BackingField = 0;
            this.<AttackSequenceData>k__BackingField = new AnimatronicEntity.AttackSequenceData();
            this.<animatronicConfigMapper>k__BackingField = new AnimatronicConfigMapper(data:  this.<animatronicConfigData>k__BackingField);
            this.<moveStateData>k__BackingField = new AnimatronicEntity.MoveStateData();
            .<CompletedTimestamp>k__BackingField = 0;
            this.<OnDeckData>k__BackingField = new AnimatronicEntity.OnDeckData();
            .<timeElapsed>k__BackingField = 0f;
            Mapbox.Utils.Vector2d val_17 = Mapbox.Utils.Vector2d.zero;
            .<direction>k__BackingField = val_17;
            mem[1152921525010768624] = val_17.y;
            this.<SentAnimatronicData>k__BackingField = new AnimatronicEntity.SentAnimatronicData();
            .timeStamp = 0;
            .DistanceFromNextPoint = 0;
            .nextPoint = 0;
            this.<scavengingData>k__BackingField = new AnimatronicEntity.ScavengingData();
            this.<UiStateData>k__BackingField = new AnimatronicEntity.UIStateData();
            this.<endoskeletonData>k__BackingField = new Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData();
            this.<rewardDataV3>k__BackingField = new Game.TheGame.Data.RewardDataV3();
            this.<wearAndTear>k__BackingField = 100;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain, string entityId, AnimatronicEntity.StateData stateData, AnimatronicEntity.OriginData originData, AnimatronicEntity.GeoPositionData geoPositionData, AnimatronicEntity.DistanceFromPlayerData distanceFromPlayerData, AnimatronicEntity.UpdateTimerData updateTimerData, AnimatronicEntity.StalkingTimerData stalkingTimerData, AnimatronicEntity.MalfunctioningData malfunctioningData, AnimatronicEntity.AnimatronicConfigData animatronicConfigData, AnimatronicEntity.AttackSequenceData attackSequenceData, AnimatronicEntity.MoveStateData moveStateData, AnimatronicEntity.OnDeckData onDeckData, AnimatronicEntity.ScavengingData scavengingData, Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeletonData, Game.TheGame.Data.RewardDataV3 rewardDataV3, int wearAndTear)
        {
            val_1 = new System.Object();
            this.<AnimatronicEntityDomain>k__BackingField = animatronicEntityDomain;
            this.<entityId>k__BackingField = val_1;
            this.<stateData>k__BackingField = new AnimatronicEntity.StateData(stateData:  stateData);
            this.<originData>k__BackingField = new AnimatronicEntity.OriginData(originData:  originData);
            this.<geoPositionData>k__BackingField = new AnimatronicEntity.GeoPositionData(geoPositionData:  geoPositionData);
            this.<distanceFromPlayerData>k__BackingField = new AnimatronicEntity.DistanceFromPlayerData(distanceFromPlayerData:  distanceFromPlayerData);
            this.<updateTimerData>k__BackingField = new AnimatronicEntity.UpdateTimerData(updateTimerData:  updateTimerData);
            this.<stalkingTimerData>k__BackingField = new AnimatronicEntity.StalkingTimerData(stalkingTimerData:  stalkingTimerData);
            this.<malfunctioningData>k__BackingField = new AnimatronicEntity.MalfunctioningData(malfunctioningData:  malfunctioningData);
            this.<animatronicConfigData>k__BackingField = new AnimatronicEntity.AnimatronicConfigData(animatronicConfigData:  animatronicConfigData);
            this.<AttackSequenceData>k__BackingField = new AnimatronicEntity.AttackSequenceData(attackSequenceData:  attackSequenceData);
            this.<animatronicConfigMapper>k__BackingField = new AnimatronicConfigMapper(data:  animatronicConfigData);
            this.<moveStateData>k__BackingField = new AnimatronicEntity.MoveStateData(moveStateData:  moveStateData);
            this.<OnDeckData>k__BackingField = new AnimatronicEntity.OnDeckData(onDeckData:  onDeckData);
            this.<scavengingData>k__BackingField = new AnimatronicEntity.ScavengingData(scavengingData:  scavengingData);
            .<timeElapsed>k__BackingField = 0f;
            Mapbox.Utils.Vector2d val_16 = Mapbox.Utils.Vector2d.zero;
            .<direction>k__BackingField = val_16;
            mem[1152921525011155056] = val_16.y;
            this.<SentAnimatronicData>k__BackingField = new AnimatronicEntity.SentAnimatronicData();
            this.<UiStateData>k__BackingField = new AnimatronicEntity.UIStateData();
            this.<endoskeletonData>k__BackingField = new Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData(data:  endoskeletonData);
            this.<LocationInitialized>k__BackingField = false;
            this.<rewardDataV3>k__BackingField = new Game.TheGame.Data.RewardDataV3(rewardDataV3:  rewardDataV3);
            this.<wearAndTear>k__BackingField = wearAndTear;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitDataGeneric()
        {
            this.InitGeoPosition();
            this.<AnimatronicEntityDomain>k__BackingField.<MapMovementUtilities>k__BackingField.UpdateDistanceFromPlayer(entity:  this);
            this.<LocationInitialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitDataForTutorialOrigin()
        {
            Mapbox.Utils.Vector2d val_2 = this.<AnimatronicEntityDomain>k__BackingField._movementNodeDomain.Utilities.GetRandomPointAroundPlayerForRadius(radius:  60f);
            this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField = val_2;
            mem2[0] = val_2.y;
            this.CreateStartNode();
            this.CreateEndNode();
            this.<AnimatronicEntityDomain>k__BackingField.<MapMovementUtilities>k__BackingField.UpdateDistanceFromPlayer(entity:  this);
            this.<LocationInitialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitDataForFarAwayState()
        {
            this.InitGeoPosition();
            this.CreateStartNode();
            this.CreateEndNode();
            this.<AnimatronicEntityDomain>k__BackingField.<MapMovementUtilities>k__BackingField.UpdateDistanceFromPlayer(entity:  this);
            this.<LocationInitialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitDataForScavengeState()
        {
            AnimatronicEntity.AnimatronicEntityDomain val_7;
            AnimatronicEntity.ScavengingData val_8;
            val_7 = this.<AnimatronicEntityDomain>k__BackingField;
            if((this.<AnimatronicEntityDomain>k__BackingField) != null)
            {
                goto label_0;
            }
            
            val_7 = this.<AnimatronicEntityDomain>k__BackingField;
            if(val_7 == null)
            {
                goto label_1;
            }
            
            label_0:
            UnityEngine.Vector3 val_2 = this.<AnimatronicEntityDomain>k__BackingField._playerTarget.transform.position;
            this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField = val_2.x;
            mem2[0] = val_2.y;
            this.<scavengingData>k__BackingField.nextPoint = this.<AnimatronicEntityDomain>k__BackingField._movementNodeDomain.GetNextScavengePoint();
            val_8 = this.<scavengingData>k__BackingField;
            if((this.<geoPositionData>k__BackingField) == null)
            {
                    val_8 = this.<scavengingData>k__BackingField;
            }
            
            Mapbox.Utils.Vector2d val_4 = this.<scavengingData>k__BackingField.nextPoint.PositionLatLon;
            Mapbox.Utils.Vector2d val_5 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField, y = val_2.y}, b:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y});
            this.<scavengingData>k__BackingField.DistanceFromNextPoint = val_5.x.magnitude;
            this.<stateData>k__BackingField.animatronicState = 10;
            this.<LocationInitialized>k__BackingField = true;
            return;
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitDataForSent()
        {
            Mapbox.Utils.Vector2d val_1 = this.SpawnAtPlayerPositionOffset();
            this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField = val_1;
            mem2[0] = val_1.y;
            this.<AnimatronicEntityDomain>k__BackingField.<MapMovementUtilities>k__BackingField.UpdateDistanceFromPlayer(entity:  this);
            this.<stateData>k__BackingField.animatronicState = 12;
            this.SetSentAnimatronicDataDirection();
            this.<LocationInitialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitDataForNearPlayerState()
        {
            Mapbox.Utils.Vector2d val_1 = this.SpawnAtPlayerPositionOffset();
            this.<AnimatronicEntityDomain>k__BackingField.<MapMovementUtilities>k__BackingField.UpdateDistanceFromPlayer(entity:  this);
            this.<LocationInitialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitDataForSentAwayState()
        {
            this.InitGeoPosition();
            this.SetSentAnimatronicDataDirection();
            this.<stateData>k__BackingField.animatronicState = 12;
            this.<LocationInitialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitGeoPosition()
        {
            AnimatronicEntity.GeoPositionData val_4;
            Mapbox.Utils.Vector2d val_5;
            val_4 = this;
            val_5 = this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField;
            Mapbox.Utils.Vector2d val_1 = Mapbox.Utils.Vector2d.zero;
            if((Mapbox.Utils.Vector2d.op_Equality(lhs:  new Mapbox.Utils.Vector2d() {x = val_5, y = V9.16B}, rhs:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y})) == false)
            {
                    return;
            }
            
            val_4 = this.<geoPositionData>k__BackingField;
            Mapbox.Utils.Vector2d val_3 = this.<AnimatronicEntityDomain>k__BackingField._movementNodeDomain.GetRandomSpawnPoint();
            val_5 = val_3.x;
            this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField = val_3;
            mem2[0] = val_3.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitMovementNodes()
        {
            this.CreateStartNode();
            this.CreateEndNode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateStartNode()
        {
            this.<moveStateData>k__BackingField.<startNode>k__BackingField = MapMode.MovementNode.LocationNode.CreateNodeForLatLon(type:  1, locationLatLon:  new Mapbox.Utils.Vector2d() {x = this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField}, name:  "");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateEndNode()
        {
            AnimatronicEntity.MoveStateData val_3;
            this.<moveStateData>k__BackingField.SetEndNode(newNode:  this.<AnimatronicEntityDomain>k__BackingField._movementNodeDomain.GetLocationNode(node:  this.<moveStateData>k__BackingField.<endNode>k__BackingField));
            if((this.<moveStateData>k__BackingField.<endNode>k__BackingField) != null)
            {
                    return;
            }
            
            val_3 = this.<moveStateData>k__BackingField;
            if((this.<moveStateData>k__BackingField) != null)
            {
                goto label_5;
            }
            
            val_3 = this.<moveStateData>k__BackingField;
            if(val_3 == null)
            {
                goto label_6;
            }
            
            label_5:
            this.<moveStateData>k__BackingField.SetEndNode(newNode:  this.<AnimatronicEntityDomain>k__BackingField._movementNodeDomain.GetNextPoint(start:  this.<moveStateData>k__BackingField.<startNode>k__BackingField, end:  this.<moveStateData>k__BackingField.<startNode>k__BackingField, radius:  this.<AnimatronicEntityDomain>k__BackingField._animatronicEntityConfig.playerDistanceToTriggerStalkingMode));
            return;
            label_6:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d SpawnAtPlayerPositionOffset()
        {
            Mapbox.Utils.Vector2d val_1 = this.<AnimatronicEntityDomain>k__BackingField.<geoPositionUtilities>k__BackingField.GetPlayerGeoPositionMeters();
            Mapbox.Utils.Vector2d val_3 = this.<AnimatronicEntityDomain>k__BackingField._movementNodeDomain.MovementNodeProximityTweaks.ChooseNewWorkshopLocationMeters(startingLocationMeters:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            Mapbox.Utils.Vector2d val_4 = Mapbox.Utils.Vector2d.op_Multiply(a:  new Mapbox.Utils.Vector2d() {x = this.<SentAnimatronicData>k__BackingField.<direction>k__BackingField, y = V10.16B}, d:  (double)this.<AnimatronicEntityDomain>k__BackingField._animatronicEntityConfig.sendSpawnOffset);
            Mapbox.Utils.Vector2d val_5 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y});
            return Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetSentAnimatronicDataDirection()
        {
            Mapbox.Utils.Vector2d val_1 = this.<AnimatronicEntityDomain>k__BackingField.<geoPositionUtilities>k__BackingField.GetPlayerGeoPositionMeters();
            Mapbox.Utils.Vector2d val_2 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            this.<SentAnimatronicData>k__BackingField.<direction>k__BackingField = val_2;
            mem2[0] = val_2.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StateChangedByServer()
        {
            if(this.StateChanged != null)
            {
                    this.StateChanged.Invoke();
            }
            
            if((this.<stateData>k__BackingField.animatronicState) != 12)
            {
                    return;
            }
            
            this.SetSentAnimatronicDataDirection();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityDomain get_AnimatronicEntityDomain()
        {
            return (AnimatronicEntity.AnimatronicEntityDomain)this.<AnimatronicEntityDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_entityId()
        {
            return (string)this.<entityId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateData get_stateData()
        {
            return (AnimatronicEntity.StateData)this.<stateData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OriginData get_originData()
        {
            return (AnimatronicEntity.OriginData)this.<originData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.GeoPositionData get_geoPositionData()
        {
            return (AnimatronicEntity.GeoPositionData)this.<geoPositionData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.DistanceFromPlayerData get_distanceFromPlayerData()
        {
            return (AnimatronicEntity.DistanceFromPlayerData)this.<distanceFromPlayerData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.UpdateTimerData get_updateTimerData()
        {
            return (AnimatronicEntity.UpdateTimerData)this.<updateTimerData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StalkingTimerData get_stalkingTimerData()
        {
            return (AnimatronicEntity.StalkingTimerData)this.<stalkingTimerData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MalfunctioningData get_malfunctioningData()
        {
            return (AnimatronicEntity.MalfunctioningData)this.<malfunctioningData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicConfigData get_animatronicConfigData()
        {
            return (AnimatronicEntity.AnimatronicConfigData)this.<animatronicConfigData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AttackSequenceData get_AttackSequenceData()
        {
            return (AnimatronicEntity.AttackSequenceData)this.<AttackSequenceData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicConfigMapper get_animatronicConfigMapper()
        {
            return (AnimatronicConfigMapper)this.<animatronicConfigMapper>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MoveStateData get_moveStateData()
        {
            return (AnimatronicEntity.MoveStateData)this.<moveStateData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OnDeckData get_OnDeckData()
        {
            return (AnimatronicEntity.OnDeckData)this.<OnDeckData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.SentAnimatronicData get_SentAnimatronicData()
        {
            return (AnimatronicEntity.SentAnimatronicData)this.<SentAnimatronicData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.ScavengingData get_scavengingData()
        {
            return (AnimatronicEntity.ScavengingData)this.<scavengingData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.UIStateData get_UiStateData()
        {
            return (AnimatronicEntity.UIStateData)this.<UiStateData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_LocationInitialized()
        {
            return (bool)this.<LocationInitialized>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LocationInitialized(bool value)
        {
            this.<LocationInitialized>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData get_endoskeletonData()
        {
            return (Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData)this.<endoskeletonData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.RewardDataV3 get_rewardDataV3()
        {
            return (Game.TheGame.Data.RewardDataV3)this.<rewardDataV3>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_rewardDataV3(Game.TheGame.Data.RewardDataV3 value)
        {
            this.<rewardDataV3>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_wearAndTear()
        {
            return (int)this.<wearAndTear>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_wearAndTear(int value)
        {
            this.<wearAndTear>k__BackingField = value;
        }
    
    }

}
