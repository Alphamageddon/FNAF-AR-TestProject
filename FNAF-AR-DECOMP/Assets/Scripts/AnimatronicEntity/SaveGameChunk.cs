using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SaveGameChunk
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <entityId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.StateData <stateData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.OriginData <originData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.GeoPositionData <geoPositionData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.DistanceFromPlayerData <distanceFromPlayerData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.UpdateTimerData <updateTimerData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.StalkingTimerData <stalkingTimerData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.MalfunctioningData <malfunctioningData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AttackSequenceData <AttackSequenceData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.MoveStateData <MoveStateData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.OnDeckData <OnDeckData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.ScavengingData <scavengingData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData <endoskeletonData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.RewardDataV3 <rewardDataV3>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <wearAndTear>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string entityId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateData stateData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OriginData originData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.GeoPositionData geoPositionData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.DistanceFromPlayerData distanceFromPlayerData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.UpdateTimerData updateTimerData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StalkingTimerData stalkingTimerData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MalfunctioningData malfunctioningData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AttackSequenceData AttackSequenceData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MoveStateData MoveStateData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OnDeckData OnDeckData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.ScavengingData scavengingData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeletonData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.RewardDataV3 rewardDataV3 { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int wearAndTear { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_entityId()
        {
            return (string)this.<entityId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_entityId(string value)
        {
            this.<entityId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateData get_stateData()
        {
            return (AnimatronicEntity.StateData)this.<stateData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_stateData(AnimatronicEntity.StateData value)
        {
            this.<stateData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OriginData get_originData()
        {
            return (AnimatronicEntity.OriginData)this.<originData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_originData(AnimatronicEntity.OriginData value)
        {
            this.<originData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.GeoPositionData get_geoPositionData()
        {
            return (AnimatronicEntity.GeoPositionData)this.<geoPositionData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_geoPositionData(AnimatronicEntity.GeoPositionData value)
        {
            this.<geoPositionData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.DistanceFromPlayerData get_distanceFromPlayerData()
        {
            return (AnimatronicEntity.DistanceFromPlayerData)this.<distanceFromPlayerData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_distanceFromPlayerData(AnimatronicEntity.DistanceFromPlayerData value)
        {
            this.<distanceFromPlayerData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.UpdateTimerData get_updateTimerData()
        {
            return (AnimatronicEntity.UpdateTimerData)this.<updateTimerData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_updateTimerData(AnimatronicEntity.UpdateTimerData value)
        {
            this.<updateTimerData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StalkingTimerData get_stalkingTimerData()
        {
            return (AnimatronicEntity.StalkingTimerData)this.<stalkingTimerData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_stalkingTimerData(AnimatronicEntity.StalkingTimerData value)
        {
            this.<stalkingTimerData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MalfunctioningData get_malfunctioningData()
        {
            return (AnimatronicEntity.MalfunctioningData)this.<malfunctioningData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_malfunctioningData(AnimatronicEntity.MalfunctioningData value)
        {
            this.<malfunctioningData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AttackSequenceData get_AttackSequenceData()
        {
            return (AnimatronicEntity.AttackSequenceData)this.<AttackSequenceData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AttackSequenceData(AnimatronicEntity.AttackSequenceData value)
        {
            this.<AttackSequenceData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.MoveStateData get_MoveStateData()
        {
            return (AnimatronicEntity.MoveStateData)this.<MoveStateData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MoveStateData(AnimatronicEntity.MoveStateData value)
        {
            this.<MoveStateData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.OnDeckData get_OnDeckData()
        {
            return (AnimatronicEntity.OnDeckData)this.<OnDeckData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_OnDeckData(AnimatronicEntity.OnDeckData value)
        {
            this.<OnDeckData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.ScavengingData get_scavengingData()
        {
            return (AnimatronicEntity.ScavengingData)this.<scavengingData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_scavengingData(AnimatronicEntity.ScavengingData value)
        {
            this.<scavengingData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData get_endoskeletonData()
        {
            return (Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData)this.<endoskeletonData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_endoskeletonData(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData value)
        {
            this.<endoskeletonData>k__BackingField = value;
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
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SaveGameChunk()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SaveGameChunk(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            if(animatronicEntity != null)
            {
                    this.<entityId>k__BackingField = animatronicEntity.<entityId>k__BackingField;
                this.<stateData>k__BackingField = animatronicEntity.<stateData>k__BackingField;
                this.<geoPositionData>k__BackingField = animatronicEntity.<geoPositionData>k__BackingField;
                this.<distanceFromPlayerData>k__BackingField = animatronicEntity.<distanceFromPlayerData>k__BackingField;
                this.<updateTimerData>k__BackingField = animatronicEntity.<updateTimerData>k__BackingField;
                this.<stalkingTimerData>k__BackingField = animatronicEntity.<stalkingTimerData>k__BackingField;
                this.<malfunctioningData>k__BackingField = animatronicEntity.<malfunctioningData>k__BackingField;
                this.<AttackSequenceData>k__BackingField = animatronicEntity.<AttackSequenceData>k__BackingField;
                this.<MoveStateData>k__BackingField = animatronicEntity.<moveStateData>k__BackingField;
                this.<OnDeckData>k__BackingField = animatronicEntity.<OnDeckData>k__BackingField;
                this.<scavengingData>k__BackingField = animatronicEntity.<scavengingData>k__BackingField;
                this.<endoskeletonData>k__BackingField = animatronicEntity.<endoskeletonData>k__BackingField;
                this.<rewardDataV3>k__BackingField = animatronicEntity.<rewardDataV3>k__BackingField;
                this.<wearAndTear>k__BackingField = animatronicEntity.<wearAndTear>k__BackingField;
            }
            else
            {
                    this.<entityId>k__BackingField = 69077560;
                this.<stateData>k__BackingField = 0;
                this.<geoPositionData>k__BackingField = 1;
                this.<distanceFromPlayerData>k__BackingField = 0;
                this.<updateTimerData>k__BackingField = 0;
                this.<stalkingTimerData>k__BackingField = 0;
                this.<malfunctioningData>k__BackingField = 62590012;
                this.<AttackSequenceData>k__BackingField = 65536;
                this.<MoveStateData>k__BackingField = 62590976;
                this.<OnDeckData>k__BackingField = 62656512;
                this.<scavengingData>k__BackingField = 6486152;
                this.<endoskeletonData>k__BackingField = 2;
                this.<rewardDataV3>k__BackingField = 66416176;
                this.<wearAndTear>k__BackingField = 66481712;
            }
            
            this.<originData>k__BackingField = animatronicEntity.<originData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            string[] val_1 = new string[15];
            val_1[0] = "entityId:";
            val_1[1] = this.<entityId>k__BackingField;
            val_1[2] = ", ";
            val_1[3] = System.String.Format(format:  "state:{0}, ", arg0:  this.<stateData>k__BackingField);
            val_1[4] = System.String.Format(format:  "geoPosition:{0}, ", arg0:  this.<geoPositionData>k__BackingField);
            val_1[5] = System.String.Format(format:  "distanceFromPlayer:{0}, ", arg0:  this.<distanceFromPlayerData>k__BackingField);
            val_1[6] = System.String.Format(format:  "updateTimer:{0}, ", arg0:  this.<updateTimerData>k__BackingField);
            val_1[7] = System.String.Format(format:  "stalkingTimerData:{0}, ", arg0:  this.<stalkingTimerData>k__BackingField);
            val_1[8] = System.String.Format(format:  "malfunctioningData:{0}, ", arg0:  this.<malfunctioningData>k__BackingField);
            val_1[9] = System.String.Format(format:  "attackSequenceComplete:{0}, ", arg0:  this.<AttackSequenceData>k__BackingField.<attackSequenceComplete>k__BackingField);
            val_1[10] = System.String.Format(format:  "onDeckTimestamp:{0},", arg0:  this.<OnDeckData>k__BackingField);
            val_1[11] = System.String.Format(format:  "scavengingData:{0},", arg0:  this.<scavengingData>k__BackingField);
            val_1[12] = System.String.Format(format:  "endoskeletonData:{0},", arg0:  this.<endoskeletonData>k__BackingField);
            val_1[13] = System.String.Format(format:  "rewardDataV3:{0}", arg0:  this.<rewardDataV3>k__BackingField);
            val_1[14] = System.String.Format(format:  "wearAndTear:{0}", arg0:  this.<wearAndTear>k__BackingField);
            return (string)+val_1;
        }
    
    }

}
