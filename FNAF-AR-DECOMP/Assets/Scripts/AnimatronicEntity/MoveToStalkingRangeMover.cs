using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MoveToStalkingRangeMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected MoveToStalkingRangeMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MoveToStalkingRangeMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, float delta)
        {
            AnimatronicEntity.AnimatronicEntity val_2;
            AnimatronicEntity.AnimatronicEntityDomain val_3;
            var val_4;
            val_2 = animatronicEntity;
            val_3 = this._animatronicEntityDomain;
            if(this._animatronicEntityDomain != null)
            {
                goto label_0;
            }
            
            val_3 = this._animatronicEntityDomain;
            if(val_3 == null)
            {
                goto label_1;
            }
            
            label_0:
            this._animatronicEntityDomain.<MapMovementUtilities>k__BackingField.MoveTowardsPlayer(entity:  val_2, delta:  delta, bufferMeters:  this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerStalkingMode);
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField._distance) > 0f)
            {
                    val_2 = animatronicEntity.<distanceFromPlayerData>k__BackingField;
                var val_1 = ((animatronicEntity.<distanceFromPlayerData>k__BackingField.<initialized>k__BackingField) == true) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
            label_1:
        }
    
    }

}
