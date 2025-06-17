using UnityEngine;

namespace Alerts.Evaluate
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertEvaluator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ALERT_DATA.Types.ENTRY _alertEntry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Alerts.Evaluate.Preconditions.Precondition> _preconditions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ALERT_DATA.Types.ENTRY AlertEntry { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ALERT_DATA.Types.ENTRY get_AlertEntry()
        {
            return (ENTRY)this._alertEntry;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AlertEvaluator()
        {
            this._preconditions = new System.Collections.Generic.List<Alerts.Evaluate.Preconditions.Precondition>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertEvaluator(Alerts.Domain domain, ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            this._preconditions = new System.Collections.Generic.List<Alerts.Evaluate.Preconditions.Precondition>();
            val_2 = new System.Object();
            this._domain = domain;
            this._alertEntry = val_2;
            mem[1152921525114399792] = domain;
            mem[1152921525114399800] = val_2;
            this._preconditions.Add(item:  new Alerts.Evaluate.Preconditions.PreconditionCanTriggerAlert());
            mem[1152921525114407984] = domain;
            mem[1152921525114407992] = val_2;
            this._preconditions.Add(item:  new Alerts.Evaluate.Preconditions.PreconditionAnimatronicCheckPhase());
            mem[1152921525114416176] = domain;
            mem[1152921525114416184] = val_2;
            this._preconditions.Add(item:  new Alerts.Evaluate.Preconditions.PreconditionPassiveCheckPhase());
            mem[1152921525114424368] = domain;
            mem[1152921525114424376] = val_2;
            this._preconditions.Add(item:  new Alerts.Evaluate.Preconditions.PreconditionDateRange());
            mem[1152921525114432560] = domain;
            mem[1152921525114432568] = val_2;
            this._preconditions.Add(item:  new Alerts.Evaluate.Preconditions.PreconditionOtherAlerts());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AlwaysTriggers()
        {
            var val_5;
            if(this._alertEntry == null)
            {
                goto label_2;
            }
            
            PRECONDITIONS val_1 = this._alertEntry.Preconditions;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            double val_2 = val_1.PreconditionWeight;
            goto label_3;
            label_2:
            label_3:
            if(((-967170672) & 1) != 0)
            {
                    var val_4 = (0.South < 0) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsWeightedTrigger()
        {
            var val_5;
            if(this._alertEntry == null)
            {
                goto label_2;
            }
            
            PRECONDITIONS val_1 = this._alertEntry.Preconditions;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            double val_2 = val_1.PreconditionWeight;
            goto label_3;
            label_2:
            label_3:
            if(((-967042288) & 1) != 0)
            {
                    var val_4 = (0.South > 0f) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool MeetsPreconditions()
        {
            System.Collections.Generic.List<Alerts.Evaluate.Preconditions.Precondition> val_7;
            var val_8;
            val_7 = this;
            if((this._alertEntry == null) || (this._alertEntry.Preconditions == null))
            {
                goto label_11;
            }
            
            val_7 = this._preconditions;
            List.Enumerator<T> val_2 = val_7.GetEnumerator();
            label_6:
            if(((-966897544) & 1) == 0)
            {
                goto label_4;
            }
            
            val_7 = 0.emailUIDataHandler;
            if((val_7 & 1) != 0)
            {
                goto label_6;
            }
            
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525114785912});
            val_8 = 0;
            return (bool)val_8;
            label_4:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525114785912});
            label_11:
            val_8 = 1;
            return (bool)val_8;
        }
    
    }

}
