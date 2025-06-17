using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ApproachingChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ApproachingChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ApproachingChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            var val_4;
            AnimatronicEntity.StateData val_12;
            AnimatronicEntity.DistanceFromPlayerData val_13;
            var val_14;
            val_12 = animatronicEntity;
            val_13 = animatronicEntity.<distanceFromPlayerData>k__BackingField;
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField.<initialized>k__BackingField) == false)
            {
                goto label_3;
            }
            
            val_13 = this._animatronicEntityDomain._animatronicEntityConfig;
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField._distance) <= this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerDarkMode)
            {
                goto label_7;
            }
            
            label_3:
            val_14 = 0;
            return (bool)val_14;
            label_7:
            List.Enumerator<T> val_2 = this._animatronicEntityDomain.<container>k__BackingField.GetAllEntities().GetEnumerator();
            val_13 = 1152921524628111520;
            label_18:
            if(((-1103398864) & 1) == 0)
            {
                goto label_12;
            }
            
            if((val_4.emailUIDataHandler == val_12) || ((AnimatronicEntity.StateData.IsAfterStalking(sourceState:  val_5._emailIdsToBeSetToReadOnServer.animatronicState)) == false))
            {
                goto label_18;
            }
            
            animatronicEntity.<stateData>k__BackingField.animatronicState = 1;
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524978284592});
            goto label_21;
            label_12:
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524978284592});
            val_12 = animatronicEntity.<stateData>k__BackingField;
            val_12.animatronicState = 3;
            label_21:
            val_14 = 1;
            return (bool)val_14;
        }
    
    }

}
