using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MoveToStalkingRangeChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected MoveToStalkingRangeChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MoveToStalkingRangeChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            AnimatronicEntity.StateData val_1;
            var val_2;
            val_1 = animatronicEntity;
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField.<initialized>k__BackingField) != false)
            {
                    if((animatronicEntity.<distanceFromPlayerData>k__BackingField._distance) <= this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerStalkingMode)
            {
                goto label_6;
            }
            
            }
            
            val_2 = 0;
            return (bool)val_2;
            label_6:
            val_1 = animatronicEntity.<stateData>k__BackingField;
            val_2 = 1;
            val_1.animatronicState = 1;
            return (bool)val_2;
        }
    
    }

}
