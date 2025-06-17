using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideEventsSharedContext
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer MasterEvents { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer get_MasterEvents()
        {
            return (Master.EventExposer)this._masterEvents;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.MasterDomain masterDomain)
        {
            this._masterEvents = masterDomain.eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideEventsSharedContext()
        {
        
        }
    
    }

}
