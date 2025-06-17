using UnityEngine;

namespace Alerts.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerAlertData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<string> firedAlerts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<string> nonRepeatableAlerts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, long> cooldownTimers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerAlertData()
        {
        
        }
    
    }

}
