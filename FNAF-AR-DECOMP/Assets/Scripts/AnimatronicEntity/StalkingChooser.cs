using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StalkingChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected StalkingChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StalkingChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            var val_6;
            AnimatronicEntity.StateData val_17;
            AnimatronicEntity.AnimatronicEntityConfig val_18;
            var val_20;
            val_17 = animatronicEntity;
            val_18 = this._animatronicEntityDomain._animatronicEntityConfig;
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField._distance) >= this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerTravelMode)
            {
                goto label_5;
            }
            
            val_18 = this._animatronicEntityDomain.<animatronicEntityUpdater>k__BackingField._fastForwarder;
            var val_17 = 0;
            val_17 = val_17 + 1;
            goto label_12;
            label_5:
            val_17 = animatronicEntity.<stateData>k__BackingField;
            label_50:
            val_17.animatronicState = 9;
            val_20 = 1;
            return (bool)val_20;
            label_12:
            if(val_18.HasCompleted == false)
            {
                goto label_46;
            }
            
            val_18 = this._animatronicEntityDomain.<animatronicEntityUpdater>k__BackingField;
            if((this._animatronicEntityDomain.<animatronicEntityUpdater>k__BackingField.<CanAttack>k__BackingField) == false)
            {
                goto label_46;
            }
            
            List.Enumerator<T> val_4 = this._animatronicEntityDomain.<container>k__BackingField.GetAllEntities().GetEnumerator();
            label_32:
            if(((-1098648784) & 1) == 0)
            {
                goto label_22;
            }
            
            GameUI.EmailUIDataHandler val_7 = val_6.emailUIDataHandler;
            val_18 = val_7._emailIdsToBeSetToReadOnServer;
            if(val_18.expressDelivery == false)
            {
                goto label_25;
            }
            
            val_18 = animatronicEntity.<stateData>k__BackingField;
            if(val_18.expressDelivery == false)
            {
                goto label_28;
            }
            
            label_25:
            if((AnimatronicEntity.StateData.IsAfterStalking(sourceState:  val_7._emailIdsToBeSetToReadOnServer.animatronicState)) == false)
            {
                goto label_32;
            }
            
            label_28:
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524983034672});
            goto label_46;
            label_22:
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524983034672});
            if((animatronicEntity.<stalkingTimerData>k__BackingField.timeRemainingInitialized) != false)
            {
                    if((animatronicEntity.<stalkingTimerData>k__BackingField.timeRemaining) <= 0f)
            {
                goto label_48;
            }
            
            }
            
            label_46:
            val_20 = 0;
            return (bool)val_20;
            label_48:
            if((animatronicEntity.<stateData>k__BackingField) != null)
            {
                goto label_50;
            }
            
            goto label_50;
        }
    
    }

}
