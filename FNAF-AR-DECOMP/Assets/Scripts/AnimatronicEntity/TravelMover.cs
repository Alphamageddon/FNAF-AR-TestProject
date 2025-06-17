using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TravelMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected TravelMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TravelMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, float delta)
        {
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(this._animatronicEntityDomain.animatronicEntityUpdater.FastForwarder.HasCompleted == false)
            {
                    return false;
            }
            
            AnimatronicEntity.AnimatronicEntityConfig val_6 = this._animatronicEntityDomain.AnimatronicEntityConfig;
            this._animatronicEntityDomain.MapMovementUtilities.MoveTowardsPlayer(entity:  animatronicEntity, delta:  delta, bufferMeters:  val_6.playerDistanceToTriggerStalkingMode);
            if(animatronicEntity.distanceFromPlayerData.distance <= 0f)
            {
                    return false;
            }
            
            AnimatronicEntity.DistanceFromPlayerData val_9 = animatronicEntity.distanceFromPlayerData;
            if(val_9 != null)
            {
                    return val_9.initialized;
            }
            
            return val_9.initialized;
        }
    
    }

}
