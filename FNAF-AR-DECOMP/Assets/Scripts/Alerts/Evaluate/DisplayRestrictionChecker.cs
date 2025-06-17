using UnityEngine;

namespace Alerts.Evaluate
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DisplayRestrictionChecker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ALERT_DATA.Types.ENTRY _alertEntry;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DisplayRestrictionChecker()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DisplayRestrictionChecker(Alerts.Domain domain)
        {
            this._domain = domain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAlertToUse(ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            this._alertEntry = alertEntry;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanDisplay()
        {
            var val_11;
            DisplayType val_3 = this._domain.TheGameDomain.gameDisplayChanger.GetDisplayType();
            if((this._alertEntry.UI.UIDisplayRestriction - 2) <= 5)
            {
                    var val_11 = 52949024 + ((val_5 - 2)) << 2;
                val_11 = val_11 + 52949024;
            }
            else
            {
                    val_11 = 1;
                return (bool);
            }
        
        }
    
    }

}
