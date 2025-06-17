using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StalkingPlayerMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected StalkingPlayerMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StalkingPlayerMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, float deltaTime)
        {
            Mapbox.Unity.Map.AbstractMap val_4;
            var val_5;
            val_4 = this._animatronicEntityDomain._map;
            if(val_4 != 0)
            {
                    val_4 = this._animatronicEntityDomain._map;
                if(val_4.isInitialized != false)
            {
                    MinMaxTimers val_3 = animatronicEntity.<animatronicConfigMapper>k__BackingField.GetStalkingTimers();
                val_4 = this._animatronicEntityDomain._animatronicEntityConfig.stalkingSwitchbackMinTimer;
                0.UpdateStalkingTimers(updateStalkingTimersParams:  new UpdateStalkingTimersParams() {animatronicEntity = animatronicEntity, deltaTime = deltaTime, stalkingMinTimer = val_3.minTimeSeconds, stalkingMaxTimer = val_3.maxTimeSeconds, stalkingSwitchbackMinTimer = val_4, stalkingSwitchbackMaxTimer = this._animatronicEntityDomain._animatronicEntityConfig.stalkingSwitchbackMaxTimer, clockwiseChance = this._animatronicEntityDomain._animatronicEntityConfig.stalkingClockwiseChance});
                this._animatronicEntityDomain.<MapMovementUtilities>k__BackingField.MoveEntityInACircleAroundPlayer(entity:  animatronicEntity, delta:  deltaTime);
                val_5 = 1;
                return (bool)val_5;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
    
    }

}
