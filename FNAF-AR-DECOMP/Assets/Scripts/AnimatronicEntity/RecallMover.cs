using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RecallMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected RecallMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RecallMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, float delta)
        {
            AnimatronicEntity.AnimatronicEntity val_2;
            var val_3;
            val_2 = animatronicEntity;
            this._animatronicEntityDomain.<MapMovementUtilities>k__BackingField.MoveTowardsPlayer(entity:  val_2, delta:  delta, bufferMeters:  0f);
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField._distance) > 0f)
            {
                    val_2 = animatronicEntity.<distanceFromPlayerData>k__BackingField;
                var val_1 = ((animatronicEntity.<distanceFromPlayerData>k__BackingField.<initialized>k__BackingField) == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
    
    }

}
