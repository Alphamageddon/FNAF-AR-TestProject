using UnityEngine;

namespace Alerts.Trigger.PeriodicTriggers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PeriodicTriggers
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Trigger.PeriodicTriggers.PeriodicTriggersConfig _periodicTriggersConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Evaluate.AlertChooserByWeight _alertChooserByWeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Alerts.Evaluate.AlertEvaluator> _alertEvaluatorsTempCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _nextCheckTimestamp;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _logClassName { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string get__logClassName()
        {
            if(this._periodicTriggersConfig.GetType() == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PeriodicTriggers()
        {
            this._alertEvaluatorsTempCache = new System.Collections.Generic.HashSet<Alerts.Evaluate.AlertEvaluator>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PeriodicTriggers(Alerts.Domain domain, Alerts.Trigger.PeriodicTriggers.PeriodicTriggersConfig periodicTriggersConfig)
        {
            this._alertEvaluatorsTempCache = new System.Collections.Generic.HashSet<Alerts.Evaluate.AlertEvaluator>();
            val_2 = new System.Object();
            this._domain = domain;
            this._periodicTriggersConfig = val_2;
            this._alertChooserByWeight = new Alerts.Evaluate.AlertChooserByWeight(domain:  domain);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Debug_ForceEvaluationNow()
        {
            this._nextCheckTimestamp = UnityEngine.Time.time;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetNextCheckTimestamp(bool needsCooldown)
        {
            float val_6;
            float val_7;
            val_6 = V0.16B;
            float val_6 = this._domain._debugAlertEvalSpeedup;
            if(this._isInitialized == false)
            {
                goto label_5;
            }
            
            val_6 = val_6 / ((this._domain._debugAlertEvalSpeedup <= 0f) ? 0.001f : this._domain._debugAlertEvalSpeedup);
            if(needsCooldown == false)
            {
                goto label_6;
            }
            
            val_6 = val_6 / ((this._domain._debugAlertEvalSpeedup <= 0f) ? 0.001f : this._domain._debugAlertEvalSpeedup);
            val_6 = UnityEngine.Mathf.Max(a:  val_6, b:  val_6);
            val_7 = val_6 + UnityEngine.Time.time;
            goto label_9;
            label_5:
            this.TryToInitializeCheckTimestamp();
            return;
            label_6:
            val_7 = val_6 + UnityEngine.Time.time;
            label_9:
            this._nextCheckTimestamp = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToInitializeCheckTimestamp()
        {
            if((this._periodicTriggersConfig & 1) == 0)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.time;
            this._isInitialized = true;
            float val_2 = (this._domain._debugAlertEvalSpeedup <= 0f) ? 0.001f : this._domain._debugAlertEvalSpeedup;
            val_2 = val_1 / val_2;
            val_2 = val_1 + val_2;
            this._nextCheckTimestamp = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CheckForAndTriggerNextAlert()
        {
            if(this.RollDiceForTrigger() == false)
            {
                    return false;
            }
            
            return this.TryToTriggerAlerts();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool RollDiceForTrigger()
        {
            return (bool)((UnityEngine.Random.Range(min:  0f, max:  1f)) < 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool TryToTriggerAlerts()
        {
            this._alertChooserByWeight.SetAlertsToUse(alerts:  this.GatherAlertsToChooseFrom());
            if(this._alertChooserByWeight != null)
            {
                    return this._alertChooserByWeight.ChooseAlertsAndTriggerThem();
            }
            
            return this._alertChooserByWeight.ChooseAlertsAndTriggerThem();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Evaluate.AlertEvaluator[] GatherAlertsToChooseFrom()
        {
            var val_4;
            this._alertEvaluatorsTempCache.Clear();
            val_4 = 0;
            goto label_4;
            label_10:
            Alerts.Evaluate.AlertEvaluator val_4 = this._periodicTriggersConfig.Invoke()[0];
            if(val_4.MeetsPreconditions() != false)
            {
                    bool val_3 = this._alertEvaluatorsTempCache.Add(item:  val_4);
            }
            
            val_4 = 1;
            label_4:
            if(val_4 < val_1.Length)
            {
                goto label_10;
            }
            
            return System.Linq.Enumerable.ToArray<Alerts.Evaluate.AlertEvaluator>(source:  this._alertEvaluatorsTempCache);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            var val_4;
            if(this._isInitialized == false)
            {
                goto label_0;
            }
            
            if(this._nextCheckTimestamp <= UnityEngine.Time.time)
            {
                goto label_1;
            }
            
            return;
            label_0:
            this.TryToInitializeCheckTimestamp();
            return;
            label_1:
            if((this.RollDiceForTrigger() != false) && (this.TryToTriggerAlerts() != false))
            {
                    val_4 = 1;
            }
            else
            {
                    val_4 = 0;
            }
            
            this.ResetNextCheckTimestamp(needsCooldown:  false);
        }
    
    }

}
