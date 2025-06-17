using UnityEngine;

namespace Alerts.Evaluate
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertChooserByWeight
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string className = "Alerts.AlertChooser";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Trigger.AlertTriggerer _alertTriggerer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Alerts.Evaluate.AlertEvaluator> _alerts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<Alerts.Evaluate.AlertEvaluator> _alertsEvaluatorsTempCache;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AlertChooserByWeight()
        {
            this._alerts = new System.Collections.Generic.List<Alerts.Evaluate.AlertEvaluator>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertChooserByWeight(Alerts.Domain domain)
        {
            this._alerts = new System.Collections.Generic.List<Alerts.Evaluate.AlertEvaluator>();
            this._domain = domain;
            this._alertTriggerer = new Alerts.Trigger.AlertTriggerer(domain:  domain);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAlertsToUse(Alerts.Evaluate.AlertEvaluator[] alerts)
        {
            this._alerts.Clear();
            this._alerts.AddRange(collection:  alerts);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ChooseAlertsAndTriggerThem()
        {
            this.AddAlertsThatAlwaysTriggerToCache();
            this.AddWeightedAlertsToCache();
            bool val_2 = this.TriggerWeightedAlert();
            val_2 = this.TriggerAlertThatAlwaysTriggers() | val_2;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CheckForAndTriggerNextAlertThatAlwaysTriggers()
        {
            this.AddAlertsThatAlwaysTriggerToCache();
            return this.TriggerAlertThatAlwaysTriggers();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddAlertsThatAlwaysTriggerToCache()
        {
            var val_7;
            System.Collections.Generic.List<Alerts.Evaluate.AlertEvaluator> val_8;
            var val_9;
            val_7 = null;
            val_7 = null;
            Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache.Clear();
            val_8 = this._alerts;
            List.Enumerator<T> val_1 = val_8.GetEnumerator();
            label_11:
            if(((-968646424) & 1) == 0)
            {
                goto label_5;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if(val_2.AlwaysTriggers() == false)
            {
                goto label_11;
            }
            
            val_9 = null;
            val_9 = null;
            bool val_4 = Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache.Add(item:  val_2);
            goto label_11;
            label_5:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525113037032});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool TriggerAlertThatAlwaysTriggers()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_7 = this;
            val_8 = 1152921505253650432;
            val_9 = null;
            val_9 = null;
            if(Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache.Count < 1)
            {
                goto label_4;
            }
            
            val_10 = null;
            val_10 = null;
            int val_2 = Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache.Count;
            HashSet.Enumerator<T> val_3 = Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache.GetEnumerator();
            val_8 = 1152921525113151456;
            label_14:
            if(((-968492440) & 1) == 0)
            {
                goto label_21;
            }
            
            GameUI.EmailUIDataHandler val_4 = 0.emailUIDataHandler;
            this._alertTriggerer._alertEntry = val_4._serverGameUIDataModel;
            this._alertTriggerer._displayRestrictionChecker._alertEntry = val_4._serverGameUIDataModel;
            this._alertTriggerer.TriggerTheAlert();
            goto label_14;
            label_4:
            val_11 = 0;
            return (bool)val_11;
            label_21:
            val_11 = 1;
            return (bool)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CheckForAndTriggerNextWeightedAlert()
        {
            this.AddWeightedAlertsToCache();
            return this.TriggerWeightedAlert();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddWeightedAlertsToCache()
        {
            var val_7;
            System.Collections.Generic.List<Alerts.Evaluate.AlertEvaluator> val_8;
            var val_9;
            val_7 = null;
            val_7 = null;
            Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache.Clear();
            val_8 = this._alerts;
            List.Enumerator<T> val_1 = val_8.GetEnumerator();
            label_11:
            if(((-968231576) & 1) == 0)
            {
                goto label_5;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if(val_2.IsWeightedTrigger() == false)
            {
                goto label_11;
            }
            
            val_9 = null;
            val_9 = null;
            bool val_4 = Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache.Add(item:  val_2);
            goto label_11;
            label_5:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525113451880});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool TriggerWeightedAlert()
        {
            Alerts.Trigger.AlertTriggerer val_3;
            Alerts.Trigger.AlertTriggerer val_4;
            var val_5;
            var val_6;
            var val_7;
            val_3 = this;
            val_4 = 1152921505253650432;
            val_5 = null;
            val_5 = null;
            if(Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache.Count >= 1)
            {
                    val_6 = null;
                val_6 = null;
                Alerts.Evaluate.AlertEvaluator val_2 = ChooseWeightedAlertToTrigger(alertsToChooseFrom:  Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache);
                val_4 = this._alertTriggerer;
                this._alertTriggerer._alertEntry = val_2._alertEntry;
                this._alertTriggerer._displayRestrictionChecker._alertEntry = val_2._alertEntry;
                val_3 = this._alertTriggerer;
                val_3.TriggerTheAlert();
                val_7 = 1;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Evaluate.AlertEvaluator ChooseWeightedAlertToTrigger(System.Collections.Generic.HashSet<Alerts.Evaluate.AlertEvaluator> alertsToChooseFrom)
        {
            var val_3;
            float val_18;
            var val_19;
            var val_20;
            var val_21;
            HashSet.Enumerator<T> val_1 = alertsToChooseFrom.GetEnumerator();
            val_18 = 0f;
            goto label_2;
            label_6:
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            val_18 = val_18 + (float)val_4._serverGameUIDataModel.Preconditions.PreconditionWeight;
            label_2:
            if(((-967913008) & 1) != 0)
            {
                goto label_6;
            }
            
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525113770448});
            float val_18 = UnityEngine.Random.Range(min:  0f, max:  val_18);
            HashSet.Enumerator<T> val_10 = alertsToChooseFrom.GetEnumerator();
            goto label_14;
            label_21:
            val_19 = val_3.emailUIDataHandler;
            if(val_18 <= (float)val_11._serverGameUIDataModel.Preconditions.PreconditionWeight)
            {
                goto label_18;
            }
            
            val_18 = val_18 - (float)val_11._serverGameUIDataModel.Preconditions.PreconditionWeight;
            label_14:
            if(((-967913008) & 1) != 0)
            {
                goto label_21;
            }
            
            val_20 = 0;
            val_19 = 0;
            val_21 = 171;
            goto label_23;
            label_18:
            val_20 = 0;
            val_21 = 193;
            label_23:
            long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525113770448});
            var val_17 = (193 == 0) ? 171 : 193;
            if(val_17 != 171)
            {
                    if(val_17 == 193)
            {
                    return (Alerts.Evaluate.AlertEvaluator)val_19;
            }
            
            }
            
            ConsoleLogger.LogError(className:  "Alerts.AlertChooser", functionName:  "ChooseWeightedAlertToTrigger", logString:  "Ran out of alerts to choose from.");
            val_19 = 0;
            return (Alerts.Evaluate.AlertEvaluator)val_19;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AlertChooserByWeight()
        {
            Alerts.Evaluate.AlertChooserByWeight._alertsEvaluatorsTempCache = new System.Collections.Generic.HashSet<Alerts.Evaluate.AlertEvaluator>();
        }
    
    }

}
