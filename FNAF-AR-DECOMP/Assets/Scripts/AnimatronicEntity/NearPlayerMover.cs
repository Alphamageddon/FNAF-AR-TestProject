using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NearPlayerMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected NearPlayerMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NearPlayerMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity entity, float deltaTime)
        {
            AnimatronicEntity.FastForwarder val_5;
            float val_7;
            long val_9;
            val_5 = this._animatronicEntityDomain.<animatronicEntityUpdater>k__BackingField._fastForwarder;
            var val_7 = 0;
            val_7 = val_7 + 1;
            if((val_5.HasCompleted == true) || ((entity.<AttackSequenceData>k__BackingField.<encounterStartTime>k__BackingField) < 1))
            {
                    return false;
            }
            
            if((entity.<AttackSequenceData>k__BackingField.<accumulatedOfflineTime>k__BackingField) > 0f)
            {
                    val_7 = (entity.<AttackSequenceData>k__BackingField.<accumulatedOfflineTime>k__BackingField) + deltaTime;
            }
            else
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                if((entity.<AttackSequenceData>k__BackingField) != null)
            {
                    val_9 = entity.<AttackSequenceData>k__BackingField.<encounterStartTime>k__BackingField;
            }
            else
            {
                    val_9 = entity.<AttackSequenceData>k__BackingField.<encounterStartTime>k__BackingField;
            }
            
                val_7 = (float)(this._animatronicEntityDomain.<animatronicEntityUpdater>k__BackingField._fastForwarder.FrameEndTime) - val_9;
            }
            
            entity.<AttackSequenceData>k__BackingField.<accumulatedOfflineTime>k__BackingField = val_7;
            var val_9 = 0;
            val_9 = val_9 + 1;
            this._animatronicEntityDomain.<animatronicEntityUpdater>k__BackingField._fastForwarder.AddTimeInCombat(timeToAdd:  deltaTime);
            val_5 = entity.<animatronicConfigData>k__BackingField.<AttackProfile>k__BackingField;
            if((entity.<AttackSequenceData>k__BackingField.<accumulatedOfflineTime>k__BackingField) < (entity.<animatronicConfigData>k__BackingField.<AttackProfile>k__BackingField.OfflineExpireTime))
            {
                    return false;
            }
            
            Game.AttackSequence.RewardDispatcher.ReportLoss(serverDomain:  this._animatronicEntityDomain._serverDomain, entityId:  entity.<entityId>k__BackingField, cpuId:  entity.<animatronicConfigData>k__BackingField.<CpuData>k__BackingField.Id, plushSuitId:  entity.<animatronicConfigData>k__BackingField.<PlushSuitData>k__BackingField.Id, relativeDirection:  0);
            entity.<AttackSequenceData>k__BackingField.<attackSequenceComplete>k__BackingField = true;
            return false;
        }
    
    }

}
