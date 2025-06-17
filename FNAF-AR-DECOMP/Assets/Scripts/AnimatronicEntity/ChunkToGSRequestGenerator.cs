using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ChunkToGSRequestGenerator : GSRequestGenerator
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameSparks.Core.GSRequestData GenerateStringFromChunk(AnimatronicEntity.SaveGameChunk chunk)
        {
            GameSparks.Core.GSData val_47;
            GameSparks.Core.GSData val_48;
            GameSparks.Core.GSData val_49;
            GameSparks.Core.GSData val_50;
            GameSparks.Core.GSData val_51;
            GameSparks.Core.GSData val_52;
            GameSparks.Core.GSData val_53;
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            if(chunk != null)
            {
                    GameSparks.Core.GSRequestData val_2 = val_1.GenerateGeoPositionData(data:  chunk.<geoPositionData>k__BackingField);
                val_47 = val_2;
                GameSparks.Core.GSRequestData val_3 = val_2.GenerateStateData(data:  chunk.<stateData>k__BackingField);
                val_48 = val_3;
                GameSparks.Core.GSRequestData val_4 = val_3.GenerateDistanceFromPlayerData(data:  chunk.<distanceFromPlayerData>k__BackingField);
                val_49 = val_4;
                GameSparks.Core.GSRequestData val_5 = val_4.GenerateUpdateTimerData(data:  chunk.<updateTimerData>k__BackingField);
                val_50 = val_5;
                GameSparks.Core.GSRequestData val_6 = val_5.GenerateStalkingTimerData(data:  chunk.<stalkingTimerData>k__BackingField);
                val_51 = val_6;
                GameSparks.Core.GSRequestData val_7 = val_6.GenerateMalfunctioningData(data:  chunk.<malfunctioningData>k__BackingField);
                val_52 = val_7;
                GameSparks.Core.GSRequestData val_8 = val_7.GenerateAttackStateData(data:  chunk.<AttackSequenceData>k__BackingField);
                val_53 = this.GenerateMoveStateData(data:  chunk.<MoveStateData>k__BackingField);
                GameSparks.Core.GSRequestData val_12 = this.GenerateScavengingData(data:  chunk.<scavengingData>k__BackingField).GenerateEndoskeletonData(data:  chunk.<endoskeletonData>k__BackingField).GenerateOriginData(data:  chunk.<originData>k__BackingField);
            }
            else
            {
                    val_47 = this.GenerateGeoPositionData(data:  69077560);
                val_48 = this.GenerateStateData(data:  15026800);
                val_49 = this.GenerateDistanceFromPlayerData(data:  0);
                val_50 = this.GenerateUpdateTimerData(data:  4194311);
                val_51 = this.GenerateStalkingTimerData(data:  1);
                val_52 = this.GenerateMalfunctioningData(data:  0);
                GameSparks.Core.GSRequestData val_19 = this.GenerateAttackStateData(data:  0);
                val_53 = this.GenerateMoveStateData(data:  0);
                GameSparks.Core.GSRequestData val_21 = this.GenerateScavengingData(data:  62590012);
                GameSparks.Core.GSRequestData val_22 = this.GenerateEndoskeletonData(data:  65536);
            }
            
            if(val_1 != null)
            {
                    GameSparks.Core.GSRequestData val_24 = val_1.AddString(paramName:  "entityId", value:  chunk.<entityId>k__BackingField);
                GameSparks.Core.GSRequestData val_25 = val_1.AddObject(paramName:  "geoPositionData", child:  val_47);
                GameSparks.Core.GSRequestData val_26 = val_1.AddObject(paramName:  "stateData", child:  val_48);
                GameSparks.Core.GSRequestData val_27 = val_1.AddObject(paramName:  "distanceFromPlayerData", child:  val_49);
                GameSparks.Core.GSRequestData val_28 = val_1.AddObject(paramName:  "updateTimerData", child:  val_50);
                GameSparks.Core.GSRequestData val_29 = val_1.AddObject(paramName:  "stalkingTimerData", child:  val_51);
                GameSparks.Core.GSRequestData val_30 = val_1.AddObject(paramName:  "malfunctioningData", child:  val_52);
                GameSparks.Core.GSRequestData val_31 = val_1.AddObject(paramName:  "attackStateData", child:  val_19);
                GameSparks.Core.GSRequestData val_32 = val_1.AddObject(paramName:  "moveStateData", child:  val_53);
                GameSparks.Core.GSRequestData val_33 = val_1.AddObject(paramName:  "ScavengingData", child:  val_21);
                GameSparks.Core.GSRequestData val_34 = val_1.AddObject(paramName:  "endoskeleton", child:  val_22);
            }
            else
            {
                    GameSparks.Core.GSRequestData val_35 = val_1.AddString(paramName:  "entityId", value:  chunk.<entityId>k__BackingField);
                GameSparks.Core.GSRequestData val_36 = val_1.AddObject(paramName:  "geoPositionData", child:  val_47);
                GameSparks.Core.GSRequestData val_37 = val_1.AddObject(paramName:  "stateData", child:  val_48);
                GameSparks.Core.GSRequestData val_38 = val_1.AddObject(paramName:  "distanceFromPlayerData", child:  val_49);
                GameSparks.Core.GSRequestData val_39 = val_1.AddObject(paramName:  "updateTimerData", child:  val_50);
                GameSparks.Core.GSRequestData val_40 = val_1.AddObject(paramName:  "stalkingTimerData", child:  val_51);
                GameSparks.Core.GSRequestData val_41 = val_1.AddObject(paramName:  "malfunctioningData", child:  val_52);
                GameSparks.Core.GSRequestData val_42 = val_1.AddObject(paramName:  "attackStateData", child:  val_19);
                GameSparks.Core.GSRequestData val_43 = val_1.AddObject(paramName:  "moveStateData", child:  val_53);
                GameSparks.Core.GSRequestData val_44 = val_1.AddObject(paramName:  "ScavengingData", child:  val_21);
                GameSparks.Core.GSRequestData val_45 = val_1.AddObject(paramName:  "endoskeleton", child:  val_22);
            }
            
            GameSparks.Core.GSRequestData val_46 = val_1.AddObject(paramName:  "originData", child:  this.GenerateOriginData(data:  64));
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateMoveStateData(AnimatronicEntity.MoveStateData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            if((data.<endNode>k__BackingField) != null)
            {
                    GameSparks.Core.GSRequestData val_5 = val_1.AddObject(paramName:  "endNode", child:  val_1.AddObject(paramName:  "startNode", child:  this.GenerateLocationNodeData(data:  data.<startNode>k__BackingField)).GenerateLocationNodeData(data:  data.<endNode>k__BackingField));
            }
            
            GameSparks.Core.GSRequestData val_6 = val_1.AddNumber(paramName:  "timeElapsed", value:  data.<timeElapsed>k__BackingField);
            GameSparks.Core.GSRequestData val_7 = val_1.AddNumber(paramName:  "nodeCounter", value:  data.<nodeCounter>k__BackingField);
            GameSparks.Core.GSRequestData val_8 = val_1.AddNumber(paramName:  "nodeTravelTime", value:  data.<nodeTravelTime>k__BackingField);
            GameSparks.Core.GSRequestData val_9 = val_1.AddNumber(paramName:  "maxNodes", value:  data.<maxNodes>k__BackingField);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateLocationNodeData(MapMode.MovementNode.LocationNode data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_3 = val_1.AddString(paramName:  "name", value:  data.Name);
            GameSparks.Core.GSRequestData val_5 = val_1.AddString(paramName:  "id", value:  data.Id);
            GameSparks.Core.GSRequestData val_7 = val_1.AddNumber(paramName:  "type", value:  data.Type);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateGeoPositionData(AnimatronicEntity.GeoPositionData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_2 = new GameSparks.Core.GSRequestData();
            if(val_2 != null)
            {
                    GameSparks.Core.GSRequestData val_3 = val_2.AddNumber(paramName:  "x", value:  data.<geoPosition>k__BackingField);
            }
            else
            {
                    GameSparks.Core.GSRequestData val_4 = val_2.AddNumber(paramName:  "x", value:  data.<geoPosition>k__BackingField);
            }
            
            GameSparks.Core.GSRequestData val_5 = val_2.AddNumber(paramName:  "y", value:  data.<geoPosition>k__BackingField);
            GameSparks.Core.GSRequestData val_6 = val_1.AddObject(paramName:  "geoPosition", child:  val_2);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateStateData(AnimatronicEntity.StateData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_3 = val_1.AddNumber(paramName:  "animatronicState", value:  data.animatronicState);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateOriginData(AnimatronicEntity.OriginData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_2 = val_1.AddNumber(paramName:  "animatronicOrigin", value:  data.<originState>k__BackingField);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateDistanceFromPlayerData(AnimatronicEntity.DistanceFromPlayerData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_2 = val_1.AddNumber(paramName:  "distance", value:  data._distance);
            GameSparks.Core.GSRequestData val_4 = val_1.AddBoolean(paramName:  "initialized", value:  ((data.<initialized>k__BackingField) == true) ? 1 : 0);
            GameSparks.Core.GSRequestData val_5 = val_1.AddNumber(paramName:  "minDistance", value:  data.<minDistance>k__BackingField);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateUpdateTimerData(AnimatronicEntity.UpdateTimerData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_3 = val_1.AddNumber(paramName:  "accumulatedDeltaTime", value:  data.accumulatedDeltaTime);
            GameSparks.Core.GSRequestData val_5 = val_1.AddNumber(paramName:  "nextUpdateTimer", value:  data.nextUpdateTimer);
            GameSparks.Core.GSRequestData val_7 = val_1.AddNumber(paramName:  "lastUpdateTimestamp", value:  data.LastUpdateTimestamp);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateStalkingTimerData(AnimatronicEntity.StalkingTimerData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_4 = val_1.AddBoolean(paramName:  "timeRemainingInitialized", value:  data.timeRemainingInitialized);
            GameSparks.Core.GSRequestData val_6 = val_1.AddNumber(paramName:  "timeRemaining", value:  data.timeRemaining);
            GameSparks.Core.GSRequestData val_8 = val_1.AddNumber(paramName:  "switchbackTimeRemaining", value:  data.switchbackTimeRemaining);
            GameSparks.Core.GSRequestData val_10 = val_1.AddNumber(paramName:  "direction", value:  data.direction);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateMalfunctioningData(AnimatronicEntity.MalfunctioningData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_3 = val_1.AddBoolean(paramName:  "isMalfunctioning", value:  ((data.<isMalfunctioning>k__BackingField) == true) ? 1 : 0);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateAttackStateData(AnimatronicEntity.AttackSequenceData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_3 = val_1.AddBoolean(paramName:  "attackSequenceComplete", value:  ((data.<attackSequenceComplete>k__BackingField) == true) ? 1 : 0);
            GameSparks.Core.GSRequestData val_4 = val_1.AddNumber(paramName:  "encounterStartTime", value:  data.<encounterStartTime>k__BackingField);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateScavengingData(AnimatronicEntity.ScavengingData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_3 = val_1.AddObject(paramName:  "NextPoint", child:  this.GenerateLocationNodeData(data:  data.nextPoint));
            GameSparks.Core.GSRequestData val_4 = val_1.AddNumber(paramName:  "TimeStamp", value:  data.timeStamp);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameSparks.Core.GSRequestData GenerateEndoskeletonData(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData data)
        {
            GameSparks.Core.GSRequestData val_1 = new GameSparks.Core.GSRequestData();
            GameSparks.Core.GSRequestData val_2 = val_1.AddString(paramName:  "cpu", value:  data.cpu);
            GameSparks.Core.GSRequestData val_3 = val_1.AddString(paramName:  "plushSuit", value:  data.plushSuit);
            GameSparks.Core.GSRequestData val_4 = val_1.AddStringList(paramName:  "mods", child:  data.mods);
            GameSparks.Core.GSRequestData val_5 = val_1.AddNumber(paramName:  "essence", value:  data.numEssence);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ChunkToGSRequestGenerator()
        {
        
        }
    
    }

}
