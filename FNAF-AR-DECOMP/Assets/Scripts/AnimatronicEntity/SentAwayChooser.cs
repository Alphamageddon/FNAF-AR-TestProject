using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SentAwayChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SentAwayChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SentAwayChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            AnimatronicEntity.SentAnimatronicData val_1;
            var val_2;
            val_1 = animatronicEntity;
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField._distance) < this._animatronicEntityDomain._animatronicEntityConfig.sendDistance)
            {
                    val_2 = 0;
                return (bool)val_2;
            }
            
            animatronicEntity.<stateData>k__BackingField.animatronicState = 13;
            val_1 = animatronicEntity.<SentAnimatronicData>k__BackingField;
            val_2 = 1;
            animatronicEntity.<SentAnimatronicData>k__BackingField.<timeElapsed>k__BackingField = 0f;
            return (bool)val_2;
        }
    
    }

}
