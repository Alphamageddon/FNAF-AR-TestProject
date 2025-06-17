using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RecallChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected RecallChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RecallChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
            this._masterDomain = Master.MasterDomain.GetDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            Master.EventExposer val_11;
            AnimatronicEntity.DistanceFromPlayerData val_12;
            var val_13;
            val_11 = this;
            val_12 = animatronicEntity.<distanceFromPlayerData>k__BackingField;
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField.<initialized>k__BackingField) == false)
            {
                goto label_5;
            }
            
            val_12 = animatronicEntity.<distanceFromPlayerData>k__BackingField;
            if((SRF.SRFFloatExtensions.Approx(f:  animatronicEntity.<distanceFromPlayerData>k__BackingField._distance, f2:  0f)) == false)
            {
                goto label_5;
            }
            
            AnimatronicState val_2 = animatronicEntity.<stateData>k__BackingField.animatronicState;
            animatronicEntity.<stateData>k__BackingField.animatronicState = 6;
            Master.MasterDomain val_3 = Master.MasterDomain.GetDomain();
            val_3.serverDomain.removeEntityRequester.RemoveEntityRequest(entityId:  animatronicEntity.<entityId>k__BackingField);
            val_12 = val_2.Equals(obj:  10);
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_2});
            if(val_12 == true)
            {
                goto label_13;
            }
            
            val_12 = val_5.Equals(obj:  11);
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_5});
            if(val_12 == false)
            {
                goto label_21;
            }
            
            label_13:
            if(this._masterDomain.WorkshopDomain.Inventory.WorkshopData.ShouldRepair() != false)
            {
                    val_11 = this._masterDomain.eventExposer;
                val_11.OnAnimatronicEntityReturned();
            }
            
            label_21:
            val_13 = 1;
            return (bool)val_13;
            label_5:
            val_13 = 0;
            return (bool)val_13;
        }
    
    }

}
