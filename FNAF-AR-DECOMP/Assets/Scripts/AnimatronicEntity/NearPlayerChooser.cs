using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NearPlayerChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected NearPlayerChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NearPlayerChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            AnimatronicEntity.StateData val_1;
            var val_2;
            val_1 = animatronicEntity;
            if((animatronicEntity.<AttackSequenceData>k__BackingField.<attackSequenceComplete>k__BackingField) != false)
            {
                    val_1 = animatronicEntity.<stateData>k__BackingField;
                val_1.animatronicState = 6;
                val_2 = 1;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
    
    }

}
