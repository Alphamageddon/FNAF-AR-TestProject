using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BlinkChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BlinkChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BlinkChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            AnimatronicEntity.StateData val_1;
            var val_2;
            val_1 = animatronicEntity;
            if((animatronicEntity.<SentAnimatronicData>k__BackingField.<timeElapsed>k__BackingField) < this._animatronicEntityDomain._animatronicEntityConfig.blinkTime)
            {
                    val_2 = 0;
                return (bool)val_2;
            }
            
            val_1 = animatronicEntity.<stateData>k__BackingField;
            val_1.animatronicState = 6;
            val_2 = 1;
            return (bool)val_2;
        }
    
    }

}
