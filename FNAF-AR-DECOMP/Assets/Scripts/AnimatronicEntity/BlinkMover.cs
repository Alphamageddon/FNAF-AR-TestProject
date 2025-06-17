using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BlinkMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BlinkMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BlinkMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity entity, float delta)
        {
            AnimatronicEntity.SentAnimatronicData val_1;
            float val_2;
            val_1 = entity.<SentAnimatronicData>k__BackingField;
            if(val_1 != null)
            {
                    val_2 = entity.<SentAnimatronicData>k__BackingField.<timeElapsed>k__BackingField;
            }
            else
            {
                    val_1 = 16;
                val_2 = 1.68059E-38f;
            }
            
            delta = val_2 + delta;
            mem[16] = delta;
            return false;
        }
    
    }

}
