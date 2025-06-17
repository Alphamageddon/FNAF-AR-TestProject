using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class OnDeckChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected OnDeckChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OnDeckChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            AnimatronicEntity.StateData val_2;
            var val_3;
            val_2 = animatronicEntity;
            if(TheGame.ServerTime.GetCurrentTime() < (animatronicEntity.<OnDeckData>k__BackingField.<CompletedTimestamp>k__BackingField))
            {
                    val_3 = 0;
                return (bool)val_3;
            }
            
            val_2 = animatronicEntity.<stateData>k__BackingField;
            val_2.animatronicState = 0;
            val_3 = 1;
            return (bool)val_3;
        }
    
    }

}
