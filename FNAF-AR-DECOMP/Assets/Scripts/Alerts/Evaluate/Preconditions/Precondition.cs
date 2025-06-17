using UnityEngine;

namespace Alerts.Evaluate.Preconditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class Precondition
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Alerts.Domain <Domain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly ProtoData.ALERT_DATA.Types.ENTRY <AlertEntry>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Alerts.Domain Domain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ProtoData.ALERT_DATA.Types.ENTRY AlertEntry { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Alerts.Domain get_Domain()
        {
            return (Alerts.Domain)this.<Domain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ProtoData.ALERT_DATA.Types.ENTRY get_AlertEntry()
        {
            return (ENTRY)this.<AlertEntry>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Precondition()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Precondition(Alerts.Domain domain, ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            val_1 = new System.Object();
            this.<Domain>k__BackingField = domain;
            this.<AlertEntry>k__BackingField = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool MeetsPrecondition(); // 0
    
    }

}
