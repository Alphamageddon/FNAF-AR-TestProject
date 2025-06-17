using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AllEligibleAlerts.AlertList
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Alerts.Evaluate.AlertEvaluator> _alerts;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAlert(Alerts.Evaluate.AlertEvaluator alertEvaluator)
    {
        this._alerts.Add(item:  alertEvaluator);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Alerts.Evaluate.AlertEvaluator[] GetAlerts()
    {
        if(this._alerts != null)
        {
                return this._alerts.ToArray();
        }
        
        return this._alerts.ToArray();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AllEligibleAlerts.AlertList()
    {
        this._alerts = new System.Collections.Generic.List<Alerts.Evaluate.AlertEvaluator>();
    }

}
