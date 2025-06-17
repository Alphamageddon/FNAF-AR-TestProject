using UnityEngine;

namespace Alerts.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LastKnownAnimatronicPerAlert
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, string> _alertToPlushSuitId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPlushSuitIdForAlertId(string alertId, string plushSuitId)
        {
            this._alertToPlushSuitId.set_Item(key:  alertId, value:  plushSuitId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ContainsAlert(string alertId)
        {
            if(this._alertToPlushSuitId != null)
            {
                    return this._alertToPlushSuitId.ContainsKey(key:  alertId);
            }
            
            return this._alertToPlushSuitId.ContainsKey(key:  alertId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetPlushSuitIdForAlertId(string alertId)
        {
            if(this._alertToPlushSuitId != null)
            {
                    return this._alertToPlushSuitId.Item[alertId];
            }
            
            return this._alertToPlushSuitId.Item[alertId];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LastKnownAnimatronicPerAlert()
        {
            this._alertToPlushSuitId = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
    
    }

}
