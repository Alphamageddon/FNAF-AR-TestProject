using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ServerChunkLoader
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.SaveGameChunk GenerateChunk(Systems.Server.ServerData data)
        {
            string val_31;
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "geoPositionData");
            AnimatronicEntity.GeoPositionData val_2 = val_1.GenerateGeoPositionData(data:  val_1);
            Systems.Server.ServerData val_3 = data.GetServerData(key:  "distanceFromPlayerData");
            AnimatronicEntity.DistanceFromPlayerData val_4 = val_3.GenerateDistanceFromPlayerData(data:  val_3);
            Systems.Server.ServerData val_5 = data.GetServerData(key:  "updateTimerData");
            AnimatronicEntity.UpdateTimerData val_6 = val_5.GenerateUpdateTimerData(data:  val_5);
            Systems.Server.ServerData val_7 = data.GetServerData(key:  "stalkingTimerData");
            AnimatronicEntity.StalkingTimerData val_8 = val_7.GenerateStalkingTimerData(data:  val_7);
            Systems.Server.ServerData val_9 = data.GetServerData(key:  "malfunctioningData");
            AnimatronicEntity.MalfunctioningData val_10 = val_9.GenerateMalfunctioningData(data:  val_9);
            Systems.Server.ServerData val_11 = data.GetServerData(key:  "attackStateData");
            AnimatronicEntity.AttackSequenceData val_12 = val_11.GenerateAttackStateData(data:  val_11);
            Systems.Server.ServerData val_13 = data.GetServerData(key:  "stateData");
            AnimatronicEntity.StateData val_14 = val_13.GenerateStateData(data:  val_13);
            Systems.Server.ServerData val_15 = data.GetServerData(key:  "originData");
            AnimatronicEntity.OriginData val_16 = val_15.GenerateOriginData(data:  val_15);
            AnimatronicEntity.MoveStateData val_18 = this.GenerateMoveStateData(data:  data.GetServerData(key:  "moveStateData"));
            if(data != null)
            {
                    val_31 = data.GetString(key:  "entityId");
            }
            else
            {
                    val_31 = 0.GetString(key:  "entityId");
            }
            
            AnimatronicEntity.OnDeckData val_22 = data.GetServerData(key:  "onDeckData").GenerateOnDeckData(data:  "onDeckData");
            AnimatronicEntity.ScavengingData val_24 = this.GenerateScavengingData(data:  data.GetServerData(key:  "ScavengingData"));
            Systems.Server.ServerData val_25 = data.GetServerData(key:  "endoskeleton");
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_26 = val_25.GenerateEndoskeletonData(data:  val_25);
            Game.TheGame.Data.RewardDataV3 val_28 = Game.Server.Processors.ServerProcessors.ProcessRewardDataV3(data:  data.GetServerData(key:  "rewardsV3"));
            System.Nullable<System.Int32> val_29 = data.GetInt(key:  "wearAndTear");
            AnimatronicEntity.SaveGameChunk val_30 = new AnimatronicEntity.SaveGameChunk();
            if(val_30 != null)
            {
                    .<entityId>k__BackingField = val_31;
                .<stateData>k__BackingField = val_14;
                .<originData>k__BackingField = val_16;
                .<geoPositionData>k__BackingField = val_2;
                .<distanceFromPlayerData>k__BackingField = val_4;
                .<updateTimerData>k__BackingField = val_6;
                .<stalkingTimerData>k__BackingField = val_8;
                .<malfunctioningData>k__BackingField = val_10;
                .<OnDeckData>k__BackingField = val_22;
                .<scavengingData>k__BackingField = val_24;
                .<endoskeletonData>k__BackingField = val_26;
                .<rewardDataV3>k__BackingField = val_28;
                .<AttackSequenceData>k__BackingField = val_12;
                .<MoveStateData>k__BackingField = val_18;
            }
            else
            {
                    mem[16] = val_31;
                mem[24] = val_14;
                mem[32] = val_16;
                mem[40] = val_2;
                mem[48] = val_4;
                mem[56] = val_6;
                mem[64] = val_8;
                mem[72] = val_10;
                mem[80] = val_12;
                mem[88] = val_18;
                mem[96] = val_22;
                mem[104] = val_24;
                mem[112] = val_26;
                mem[120] = val_28;
            }
            
            .<wearAndTear>k__BackingField = ;
            return val_30;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.GeoPositionData GenerateGeoPositionData(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "geoPosition");
            System.Nullable<System.Double> val_2 = val_1.GetDouble(key:  "x");
            System.Nullable<System.Double> val_3 = val_1.GetDouble(key:  "y");
            Mapbox.Utils.Vector2d val_4 = new Mapbox.Utils.Vector2d(x:  V0.16B, y:  V0.16B);
            .<geoPosition>k__BackingField = val_4.x;
            mem[1152921525039110632] = val_4.y;
            return (AnimatronicEntity.GeoPositionData)new AnimatronicEntity.GeoPositionData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.StateData GenerateStateData(Systems.Server.ServerData data)
        {
            System.Nullable<System.Int32> val_1 = data.GetInt(key:  "animatronicState");
            System.Nullable<System.Boolean> val_2 = data.GetBoolean(key:  "expressDelivery");
            return (AnimatronicEntity.StateData)new AnimatronicEntity.StateData(animatronicState:  val_1.HasValue, expressDelivery:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.OriginData GenerateOriginData(Systems.Server.ServerData data)
        {
            System.Nullable<System.Int32> val_1 = data.GetInt(key:  "animatronicOrigin");
            .<originState>k__BackingField = ;
            return (AnimatronicEntity.OriginData)new AnimatronicEntity.OriginData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.DistanceFromPlayerData GenerateDistanceFromPlayerData(Systems.Server.ServerData data)
        {
            System.Nullable<System.Single> val_1 = data.GetFloat(key:  "distance");
            System.Nullable<System.Single> val_2 = data.GetFloat(key:  "minDistance");
            System.Nullable<System.Boolean> val_3 = data.GetBoolean(key:  "initialized");
            ._distance = V0.16B;
            .<minDistance>k__BackingField = V0.16B;
            .<initialized>k__BackingField = false;
            return (AnimatronicEntity.DistanceFromPlayerData)new AnimatronicEntity.DistanceFromPlayerData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.UpdateTimerData GenerateUpdateTimerData(Systems.Server.ServerData data)
        {
            long val_5;
            if(data != null)
            {
                    System.Nullable<System.Single> val_1 = data.GetFloat(key:  "accumulatedDeltaTime");
            }
            else
            {
                    System.Nullable<System.Single> val_2 = 0.GetFloat(key:  "accumulatedDeltaTime");
            }
            
            System.Nullable<System.Int64> val_3 = data.GetLong(key:  "lastUpdateTimestamp");
            val_5 = 0;
            if(( & 1) == 0)
            {
                    return (AnimatronicEntity.UpdateTimerData)new AnimatronicEntity.UpdateTimerData(lastUpdateTime:  V0.16B, lastUpdateTimestamp:  val_5 =);
            }
            
            return (AnimatronicEntity.UpdateTimerData)new AnimatronicEntity.UpdateTimerData(lastUpdateTime:  V0.16B, lastUpdateTimestamp:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.StalkingTimerData GenerateStalkingTimerData(Systems.Server.ServerData data)
        {
            System.Nullable<System.Int32> val_1 = data.GetInt(key:  "direction");
            System.Nullable<System.Boolean> val_2 = data.GetBoolean(key:  "timeRemainingInitialized");
            System.Nullable<System.Single> val_3 = data.GetFloat(key:  "switchbackTimeRemaining");
            System.Nullable<System.Single> val_4 = data.GetFloat(key:  "timeRemaining");
            return (AnimatronicEntity.StalkingTimerData)new AnimatronicEntity.StalkingTimerData(newTimeRemainingInitialized:  false, newDirection:  val_1.HasValue, newSwitchbackTimeRemaining:  V0.16B, newTimeRemaining:  V0.16B);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.MalfunctioningData GenerateMalfunctioningData(Systems.Server.ServerData data)
        {
            System.Nullable<System.Boolean> val_1 = data.GetBoolean(key:  "isMalfunctioning");
            .<isMalfunctioning>k__BackingField = false;
            return (AnimatronicEntity.MalfunctioningData)new AnimatronicEntity.MalfunctioningData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AttackSequenceData GenerateAttackStateData(Systems.Server.ServerData data)
        {
            System.Nullable<System.Boolean> val_1 = data.GetBoolean(key:  "attackSequenceComplete");
            System.Nullable<System.Int64> val_2 = data.GetLong(key:  "encounterStartTime");
            .<attackSequenceComplete>k__BackingField = false;
            .<encounterStartTime>k__BackingField = ;
            return (AnimatronicEntity.AttackSequenceData)new AnimatronicEntity.AttackSequenceData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.MoveStateData GenerateMoveStateData(Systems.Server.ServerData data)
        {
            System.Nullable<System.Single> val_1 = data.GetFloat(key:  "nodeTravelTime");
            System.Nullable<System.Single> val_2 = data.GetFloat(key:  "timeElapsed");
            System.Nullable<System.Int32> val_3 = data.GetInt(key:  "nodeCounter");
            System.Nullable<System.Int32> val_4 = data.GetInt(key:  "maxNodes");
            Systems.Server.ServerData val_5 = data.GetServerData(key:  "startNode");
            MapMode.MovementNode.LocationNode val_6 = val_5.GenerateLocationNode(nodeData:  val_5);
            Systems.Server.ServerData val_7 = data.GetServerData(key:  "endNode");
            AnimatronicEntity.MoveStateData val_9 = new AnimatronicEntity.MoveStateData();
            if(val_9 != null)
            {
                    .<startNode>k__BackingField = val_6;
                .<timeElapsed>k__BackingField = V0.16B;
                .<nodeTravelTime>k__BackingField = V0.16B;
                .<nodeCounter>k__BackingField = ;
                .<maxNodes>k__BackingField = ;
            }
            else
            {
                    mem[16] = val_6;
                .<nodeTravelTime>k__BackingField = V0.16B;
                mem[40] = V0.16B;
                mem[32] = ;
                .<maxNodes>k__BackingField = ;
            }
            
            val_9.SetEndNode(newNode:  val_7.GenerateLocationNode(nodeData:  val_7));
            return val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.LocationNode GenerateLocationNode(Systems.Server.ServerData nodeData)
        {
            Systems.Server.ServerData val_5 = nodeData;
            if(val_5 == null)
            {
                    return (MapMode.MovementNode.LocationNode)val_5;
            }
            
            System.Nullable<System.Int32> val_1 = val_5.GetInt(key:  "type");
            MapMode.MovementNode.LocationNode val_4 = null;
            val_5 = val_4;
            val_4 = new MapMode.MovementNode.LocationNode(type:  val_1.HasValue, name:  val_5.GetString(key:  "name"), id:  val_5.GetString(key:  "id"));
            return (MapMode.MovementNode.LocationNode)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.OnDeckData GenerateOnDeckData(Systems.Server.ServerData data)
        {
            long val_3 = TheGame.ServerTime.GetCurrentTime();
            AnimatronicEntity.OnDeckData val_2 = null;
            val_3 = val_3 + 15;
            val_2 = new AnimatronicEntity.OnDeckData();
            .<CompletedTimestamp>k__BackingField = val_3;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.ScavengingData GenerateScavengingData(Systems.Server.ServerData data)
        {
            .nextPoint = 0;
            .timeStamp = 0;
            .DistanceFromNextPoint = 0;
            Systems.Server.ServerData val_2 = data.GetServerData(key:  "NextPoint");
            mem[1152921525040580304] = val_2.GenerateLocationNode(nodeData:  val_2);
            System.Nullable<System.Int64> val_4 = data.GetLong(key:  "TimeStamp");
            .timeStamp = ;
            return (AnimatronicEntity.ScavengingData)new AnimatronicEntity.ScavengingData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData GenerateEndoskeletonData(Systems.Server.ServerData data)
        {
            .cpu = data.GetString(key:  "cpu");
            if(data != null)
            {
                    .plushSuit = data.GetString(key:  "plushSuit");
            }
            else
            {
                    .plushSuit = 0.GetString(key:  "plushSuit");
            }
            
            .mods = data.GetStringList(key:  "mods");
            System.Nullable<System.Int32> val_6 = data.GetInt(key:  "essence");
            .numEssence = val_6.HasValue;
            return (Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData)new Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.RewardDataV3 GenerateRewardData(Systems.Server.ServerData data)
        {
            return Game.Server.Processors.ServerProcessors.ProcessRewardDataV3(data:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerChunkLoader()
        {
        
        }
    
    }

}
