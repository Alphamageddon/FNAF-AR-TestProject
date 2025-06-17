using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TravelChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected TravelChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TravelChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(this._animatronicEntityDomain.animatronicEntityUpdater.FastForwarder.HasCompleted == false)
            {
                    return false;
            }
            
            if(animatronicEntity.distanceFromPlayerData.initialized == false)
            {
                    return false;
            }
            
            AnimatronicEntity.AnimatronicEntityConfig val_9 = this._animatronicEntityDomain.AnimatronicEntityConfig;
            if(animatronicEntity.distanceFromPlayerData.distance > val_9.playerDistanceToTriggerTravelMode)
            {
                    return false;
            }
            
            AnimatronicEntity.StateData val_10 = animatronicEntity.stateData;
            val_10.<animatronicState>k__BackingField = 0;
            animatronicEntity.LocationInitialized = false;
            return false;
        }
    
    }

}
