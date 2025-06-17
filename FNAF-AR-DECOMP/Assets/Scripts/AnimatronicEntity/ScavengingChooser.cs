using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScavengingChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ScavengingChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScavengingChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            AnimatronicEntity.AnimatronicEntity val_2 = animatronicEntity;
            if((animatronicEntity.<scavengingData>k__BackingField.nextPoint) == null)
            {
                    val_2.InitDataForScavengeState();
            }
            
            if((animatronicEntity.<scavengingData>k__BackingField.DistanceFromNextPoint) <= (4.94065645841247E-324))
            {
                    this.GetNextPoint(entity:  val_2 = animatronicEntity);
            }
            
            long val_1 = TheGame.ServerTime.GetCurrentTime();
            if((animatronicEntity.<scavengingData>k__BackingField.timeStamp) >= val_1)
            {
                    return false;
            }
            
            this._animatronicEntityDomain.<animatronicEntityUpdater>k__BackingField.RequestScavenge(entity:  val_2);
            val_2 = animatronicEntity.<scavengingData>k__BackingField;
            long val_2 = (long)this._animatronicEntityDomain._scavengePeriod;
            val_2 = val_1 + val_2;
            animatronicEntity.<scavengingData>k__BackingField.timeStamp = val_2;
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetNextPoint(AnimatronicEntity.AnimatronicEntity entity)
        {
            entity.<scavengingData>k__BackingField.nextPoint = this._animatronicEntityDomain._movementNodeDomain.GetNextScavengePoint();
        }
    
    }

}
