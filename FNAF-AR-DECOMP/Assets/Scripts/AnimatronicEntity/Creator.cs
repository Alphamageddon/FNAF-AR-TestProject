using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Creator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Creator(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain, Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain> itemDefinitionDomain)
        {
            val_1 = new System.Object();
            this._animatronicEntityDomain = animatronicEntityDomain;
            val_1.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void AnimatronicEntity.Creator::ItemDefinitionDomainReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ItemDefinitionDomainReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._itemDefinitions = itemDefinitionDomain.ItemDefinitions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity CreateEntity(AnimatronicEntity.SaveGameChunk saveGameChunk)
        {
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_8;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_9;
            string val_10;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_11;
            AnimatronicEntity.StalkingTimerData val_12;
            AnimatronicEntity.AttackSequenceData val_13;
            AnimatronicEntity.MoveStateData val_14;
            AnimatronicEntity.OnDeckData val_15;
            AnimatronicEntity.ScavengingData val_16;
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_17;
            Game.TheGame.Data.RewardDataV3 val_18;
            if(this._itemDefinitions == null)
            {
                goto label_1;
            }
            
            val_8 = this._itemDefinitions.GetCPUById(id:  saveGameChunk.<endoskeletonData>k__BackingField.cpu);
            if(val_8 != null)
            {
                goto label_4;
            }
            
            label_1:
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_2 = null;
            val_8 = val_2;
            val_2 = new Game.ItemDefinition.Data.DataDefinitions.CPUData(data:  0);
            label_4:
            if(this._itemDefinitions == null)
            {
                goto label_5;
            }
            
            val_9 = this._itemDefinitions.GetPlushSuitById(id:  saveGameChunk.<endoskeletonData>k__BackingField.plushSuit);
            if(val_9 != null)
            {
                goto label_8;
            }
            
            label_5:
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_4 = null;
            val_9 = val_4;
            val_4 = new Game.ItemDefinition.Data.DataDefinitions.PlushSuitData(data:  0);
            label_8:
            if(this._itemDefinitions == null)
            {
                goto label_9;
            }
            
            if(val_8 == null)
            {
                goto label_10;
            }
            
            val_10 = (Game.ItemDefinition.Data.DataDefinitions.CPUData)[1152921525007050656].AttackProfile;
            goto label_11;
            label_9:
            val_11 = 0;
            goto label_12;
            label_10:
            val_10 = 0;
            label_11:
            val_11 = this._itemDefinitions.GetAttackProfile(profileId:  val_10);
            label_12:
            if(saveGameChunk != null)
            {
                    val_12 = saveGameChunk.<stalkingTimerData>k__BackingField;
            }
            else
            {
                    val_12 = 1;
            }
            
            .<CpuData>k__BackingField = val_8;
            .<PlushSuitData>k__BackingField = val_9;
            .<AttackProfile>k__BackingField = val_11;
            if(saveGameChunk != null)
            {
                    val_13 = saveGameChunk.<AttackSequenceData>k__BackingField;
                val_14 = saveGameChunk.<MoveStateData>k__BackingField;
                val_15 = saveGameChunk.<OnDeckData>k__BackingField;
                val_16 = saveGameChunk.<scavengingData>k__BackingField;
                val_17 = saveGameChunk.<endoskeletonData>k__BackingField;
                val_18 = saveGameChunk.<rewardDataV3>k__BackingField;
                return (AnimatronicEntity.AnimatronicEntity)this.CreateEntity(entityId:  11993091, stateData:  15026800, originData:  64, geoPositionData:  69077560, distanceFromPlayerData:  0, updateTimerData:  4194311, stalkingTimerData:  val_12, malfunctioningData:  saveGameChunk.<malfunctioningData>k__BackingField, animatronicConfigData:  new AnimatronicEntity.AnimatronicConfigData(), attackSequenceData:  val_13 = 0, moveStateData:  val_14 = 0, onDeckData:  val_15 = 62590012, scavengingData:  val_16 = 62590012, endoskeletonData:  val_17 = 65536, rewardDataV3:  val_18 = 1, wearAndTear:  saveGameChunk.<wearAndTear>k__BackingField);
            }
            
            return (AnimatronicEntity.AnimatronicEntity)this.CreateEntity(entityId:  11993091, stateData:  15026800, originData:  64, geoPositionData:  69077560, distanceFromPlayerData:  0, updateTimerData:  4194311, stalkingTimerData:  val_12, malfunctioningData:  saveGameChunk.<malfunctioningData>k__BackingField, animatronicConfigData:  new AnimatronicEntity.AnimatronicConfigData(), attackSequenceData:  val_13, moveStateData:  val_14, onDeckData:  val_15, scavengingData:  val_16, endoskeletonData:  val_17, rewardDataV3:  val_18, wearAndTear:  saveGameChunk.<wearAndTear>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity CreateEntity(string entityId, AnimatronicEntity.StateData stateData, AnimatronicEntity.OriginData originData, AnimatronicEntity.GeoPositionData geoPositionData, AnimatronicEntity.DistanceFromPlayerData distanceFromPlayerData, AnimatronicEntity.UpdateTimerData updateTimerData, AnimatronicEntity.StalkingTimerData stalkingTimerData, AnimatronicEntity.MalfunctioningData malfunctioningData, AnimatronicEntity.AnimatronicConfigData animatronicConfigData, AnimatronicEntity.AttackSequenceData attackSequenceData, AnimatronicEntity.MoveStateData moveStateData, AnimatronicEntity.OnDeckData onDeckData, AnimatronicEntity.ScavengingData scavengingData, Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeletonData, Game.TheGame.Data.RewardDataV3 rewardDataV3, int wearAndTear)
        {
            return (AnimatronicEntity.AnimatronicEntity)new AnimatronicEntity.AnimatronicEntity(animatronicEntityDomain:  this._animatronicEntityDomain, entityId:  entityId, stateData:  stateData, originData:  originData, geoPositionData:  geoPositionData, distanceFromPlayerData:  distanceFromPlayerData, updateTimerData:  updateTimerData, stalkingTimerData:  stalkingTimerData, malfunctioningData:  malfunctioningData, animatronicConfigData:  animatronicConfigData, attackSequenceData:  attackSequenceData, moveStateData:  moveStateData, onDeckData:  onDeckData, scavengingData:  scavengingData, endoskeletonData:  endoskeletonData, rewardDataV3:  rewardDataV3, wearAndTear:  wearAndTear);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateFakeEntityToSend(string id)
        {
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_6;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_7;
            if(this._itemDefinitions == null)
            {
                goto label_1;
            }
            
            val_6 = this._itemDefinitions.GetCPUById(id:  id);
            if(val_6 != null)
            {
                goto label_2;
            }
            
            label_1:
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_2 = null;
            val_6 = val_2;
            val_2 = new Game.ItemDefinition.Data.DataDefinitions.CPUData(data:  0);
            label_2:
            if(this._itemDefinitions == null)
            {
                goto label_3;
            }
            
            val_7 = this._itemDefinitions.GetPlushSuitById(id:  id);
            if(val_7 != null)
            {
                goto label_4;
            }
            
            label_3:
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_4 = null;
            val_7 = val_4;
            val_4 = new Game.ItemDefinition.Data.DataDefinitions.PlushSuitData(data:  0);
            label_4:
            AnimatronicEntity.AnimatronicEntity val_5 = new AnimatronicEntity.AnimatronicEntity(id:  id, domain:  this._animatronicEntityDomain, cpu:  val_2, plushSuit:  val_4, originState:  4);
            val_5.InitDataForSent();
            this._animatronicEntityDomain.<container>k__BackingField.AddFakeEntity(entity:  val_5);
        }
    
    }

}
