using UnityEngine;

namespace Alerts.Evaluate.Preconditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PreconditionAnimatronicCheckPhase : Precondition
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PreconditionAnimatronicCheckPhase()
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PreconditionAnimatronicCheckPhase(Alerts.Domain domain, ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            val_1 = new System.Object();
            mem[1152921525116053168] = domain;
            mem[1152921525116053176] = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool MeetsPrecondition()
        {
            string val_6;
            AnimatronicState val_7;
            PRECONDITIONANIMATRONICCHECKPHASE val_2 = X20.Preconditions.PreconditionAnimatronicCheckPhase;
            PRECONDITIONREQUIREMENTS val_4 = X21.Preconditions.PreconditionRequirements;
            if(val_4 != null)
            {
                    val_6 = val_4.PreconditionActiveAnimatronic;
            }
            else
            {
                    val_6 = 0;
            }
            
            if(val_2 == 4)
            {
                    return this.IsAnimatronicAttacking(preconditionActiveAnimatronic:  val_6);
            }
            
            if(val_2 != 3)
            {
                    if(val_2 != 2)
            {
                    return true;
            }
            
                val_7 = 0;
                return this.CheckAnimatronicEntityStateForAnimatronic(animatronicState:  val_7 = 1, plushSuitId:  val_6);
            }
            
            return this.CheckAnimatronicEntityStateForAnimatronic(animatronicState:  val_7, plushSuitId:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsAnimatronicFarAway(string preconditionActiveAnimatronic)
        {
            return this.CheckAnimatronicEntityStateForAnimatronic(animatronicState:  0, plushSuitId:  preconditionActiveAnimatronic);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsAnimatronicStalking(string preconditionActiveAnimatronic)
        {
            return this.CheckAnimatronicEntityStateForAnimatronic(animatronicState:  1, plushSuitId:  preconditionActiveAnimatronic);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsAnimatronicAttacking(string preconditionActiveAnimatronic)
        {
            if((this.CheckAnimatronicEntityStateForAnimatronic(animatronicState:  2, plushSuitId:  preconditionActiveAnimatronic)) == false)
            {
                    return this.CheckAnimatronicEntityStateForAnimatronic(animatronicState:  3, plushSuitId:  preconditionActiveAnimatronic);
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CheckAnimatronicEntityStateForAnimatronic(AnimatronicEntity.StateData.AnimatronicState animatronicState, string plushSuitId)
        {
            AnimatronicEntity.AnimatronicEntity[] val_5 = X22 + 24 + 104.stateTracker.GetAnimatronicEntitiesForState(animatronicState:  animatronicState);
            if((System.String.IsNullOrWhiteSpace(value:  plushSuitId)) == true)
            {
                    return this.ChooseAndRecordAnimatronicEntity(animatronicEntities:  val_5 = Alerts.Evaluate.Preconditions.PreconditionAnimatronicCheckPhase.FilterSpecificAnimatronic(animatronicEntities:  val_5 = X22 + 24 + 104.stateTracker.GetAnimatronicEntitiesForState(animatronicState:  animatronicState), plushSuitId:  plushSuitId));
            }
            
            return this.ChooseAndRecordAnimatronicEntity(animatronicEntities:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AnimatronicEntity.AnimatronicEntity[] FilterSpecificAnimatronic(AnimatronicEntity.AnimatronicEntity[] animatronicEntities, string plushSuitId)
        {
            var val_5;
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_1 = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
            val_5 = 0;
            goto label_1;
            label_9:
            AnimatronicEntity.AnimatronicEntity val_5 = animatronicEntities[0];
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_3 = val_5.animatronicConfigData.PlushSuitData;
            if((System.String.op_Equality(a:  val_3.Id, b:  plushSuitId)) != false)
            {
                    val_1.Add(item:  val_5);
            }
            
            val_5 = 1;
            label_1:
            if(val_5 < animatronicEntities.Length)
            {
                goto label_9;
            }
            
            if(val_1 != null)
            {
                    return val_1.ToArray();
            }
            
            return val_1.ToArray();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ChooseAndRecordAnimatronicEntity(AnimatronicEntity.AnimatronicEntity[] animatronicEntities)
        {
            var val_3;
            if(animatronicEntities.Length != 0)
            {
                    Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_2 = animatronicEntities[0].animatronicConfigData.PlushSuitData;
                this.RecordAnimatronicIdForThisAlert(plushSuitId:  val_2.Id);
                val_3 = 1;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RecordAnimatronicIdForThisAlert(string plushSuitId)
        {
            X22 + 80.SetPlushSuitIdForAlertId(alertId:  X21.Logical, plushSuitId:  plushSuitId);
        }
    
    }

}
