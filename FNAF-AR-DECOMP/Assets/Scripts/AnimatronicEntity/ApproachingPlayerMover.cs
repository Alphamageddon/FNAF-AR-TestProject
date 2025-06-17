using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ApproachingPlayerMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ApproachingPlayerMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ApproachingPlayerMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, float deltaTime)
        {
            Mapbox.Unity.Map.AbstractMap val_3;
            AnimatronicEntity.AnimatronicEntityDomain val_4;
            var val_5;
            val_3 = this._animatronicEntityDomain._map;
            if(val_3 == 0)
            {
                goto label_7;
            }
            
            val_3 = this._animatronicEntityDomain._map;
            if(val_3.isInitialized == false)
            {
                goto label_7;
            }
            
            val_3 = this._animatronicEntityDomain;
            val_4 = val_3;
            if(val_3 != null)
            {
                goto label_8;
            }
            
            val_4 = this._animatronicEntityDomain;
            if(val_4 == null)
            {
                goto label_9;
            }
            
            label_8:
            this._animatronicEntityDomain.<MapMovementUtilities>k__BackingField.MoveTowardsPlayer(entity:  animatronicEntity, delta:  deltaTime, bufferMeters:  this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerDarkMode);
            val_5 = 1;
            return (bool)val_5;
            label_7:
            val_5 = 0;
            return (bool)val_5;
            label_9:
        }
    
    }

}
